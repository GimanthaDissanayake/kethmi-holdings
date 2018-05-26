using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kethmi_Holdings
{
    public partial class frm_Recipts : Form
    {
        int cusID, pId, recID;
        String strUsername,mode="",strsql="";
        Database db;

        private string strConn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        ButtonsStates btnStat = new ButtonsStates();

        public frm_Recipts(String s)
        {
            InitializeComponent();
            strUsername = s;
        }

        public bool inputAreaEnabled {set { gb_inputArea.Enabled = value; } }

        public bool searchEnabled { set { gb_search.Enabled = value; } }

        ButtonsStates lastButtonStates;

        private void frm_Recipts_Activated(object sender, EventArgs e)
        {
            lastButtonStates.restore();
            btnStat.VisibleToolStrip((frm_Main)this.MdiParent);
        }

        private void frm_Recipts_Deactivate(object sender, EventArgs e)
        {
            lastButtonStates.save();
        }

        private void frm_Recipts_Load(object sender, EventArgs e)
        {
            lastButtonStates = new ButtonsStates();
        }

        private void frm_Recipts_FormClosing(object sender, FormClosingEventArgs e)
        {            
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }

        private void getReceiptId()
        {
            db = new Database();
            recID = Convert.ToInt32(db.getValue("SELECT TOP 1 reciptID FROM RecieptsMaster ORDER BY reciptID DESC"))+1;
            txt_ReceiptID.Text = recID.ToString();
        }

        private void getCusID()
        {
            db = new Database();
            cusID = Convert.ToInt32(db.getValue("SELECT cusID FROM Customer WHERE name = '"+txt_CusName.Text+"'"));            
        }

        private void getProjID()
        {
            db = new Database();
            pId = Convert.ToInt32(db.getValue("SELECT projID FROM ProjectMaster WHERE projName = '" + txt_ProjName.Text + "'"));
        }

        private void loadData()
        {

        }

        private void clearData()
        {
            txt_CusName.Clear();
            txt_ProjName.Clear();
            txt_ReceiptID.Clear();
            txt_Search.Clear();
            txt_TotVal.Clear();
            txt_Type.Clear();
            txt_TypeAddOrRemove.Clear();
            dateTimePicker_date.ResetText();
        }

        private void enableEditing(bool value)
        {
            txt_CusName.Enabled = value;
            txt_ProjName.Enabled = value;
            txt_ReceiptID.Enabled = value;
            txt_Search.Enabled = value;
            txt_TotVal.Enabled = value;
            txt_Type.Enabled = value;
            txt_TypeAddOrRemove.Enabled = value;
            dateTimePicker_date.Enabled = value;
        }

        public void ButtonNew()
        {
            getReceiptId();
            mode = "New";
            btnStat.ControlSideToolStrip(this.ParentForm, false, false, true, false, false, true);
            dataGridView_ReceiptList.Enabled = false;
            clearData();
            enableEditing(true);
            txt_CusName.Focus();
        }

        public void ButtonEdit()
        {
            mode = "Edit";
            enableEditing(true);
            btnStat.ControlSideToolStrip(this.ParentForm, false, false, true, false, false, true);
        }

        public void ButtonClear()
        {
            if (MessageBox.Show("Are you sure want to cancel?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clearData();
                enableEditing(false);
                dataGridView_ReceiptList.Enabled = true;
                btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
            }
        }        

        public void ButtonSave()
        {
            SqlConnection objConn = new SqlConnection(strConn);
            objConn.Open();
            SqlTransaction sqlTrans = objConn.BeginTransaction();
            SqlCommand objCmd = new SqlCommand();
            objCmd.Transaction = sqlTrans;
            objCmd.Connection = objConn;

            if(mode == "New")
            {
                try
                {
                    //Get Customer ID
                    getCusID();

                    //Get Project ID
                    getProjID();

                    //Save to ReceiptMaster
                    objCmd.CommandText = "INSERT INTO RecieptsMaster(reciptID,cusID,projID,type,date,totValue,addedUser,addedDate) VALUES('"+txt_ReceiptID.Text+"','"+cusID+"','"+pId+"',"+
                        "'"+txt_Type.Text+"','"+dateTimePicker_date.Value.ToShortDateString()+"','"+txt_TotVal.Text+"','"+strUsername+"','"+DateTime.Now+"')";
                    objCmd.ExecuteNonQuery();

                    //Save to ReceiptDetails
                    objCmd.CommandText = "INSERT INTO RecieptsDetails(reciptID,type,value) VALUES('" + txt_ReceiptID.Text + "','" + txt_Type.Text + "','" + txt_TotVal.Text + "')";
                    objCmd.ExecuteNonQuery();

                    //Commit changes 
                    sqlTrans.Commit();

                    //Clear Data Fields
                    clearData();
                    loadData();
                    getReceiptId();
                    btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);

                }
                catch(Exception ex)
                {
                    sqlTrans.Rollback();
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else if(mode == "Edit")
            {
                try
                {
                    //Get Customer ID
                    getCusID();

                    //Get Project ID
                    getProjID();

                    //Update ReceiptMaster
                    objCmd.CommandText = "UPDATE RecieptsMaster SET cusID,projID,type,date,totValue,changedUser,changedDate WHERE reciptID = '" + txt_ReceiptID.Text+"'";
                    objCmd.ExecuteNonQuery();

                    //Update ReceiptDetails
                    objCmd.CommandText = "UPDATE RecieptsDetails SET type,value WHERE reciptID = '" + txt_ReceiptID.Text + "'";
                    objCmd.ExecuteNonQuery();

                    //Commit changes 
                    sqlTrans.Commit();

                    //Clear Data Fields
                    clearData();
                    loadData();
                    getReceiptId();
                    btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        public void ButtonDelete()
        {
            if (MessageBox.Show("Are you sure want to delete the Receipt?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection objConn = new SqlConnection(strConn);
                objConn.Open();
                SqlTransaction sqlTrans = objConn.BeginTransaction();
                SqlCommand objCmd = new SqlCommand();
                objCmd.Transaction = sqlTrans;
                objCmd.Connection = objConn;

                try
                {
                    //objCmd.CommandText = "UPDATE Customer SET isDeleted = 1," +
                            //"changedDate='" + DateTime.Now + "',changedUser='" + strUsername + "' WHERE cusID = '" + cusID + "'";
                    //objCmd.ExecuteNonQuery();

                    //Commit changes 
                    sqlTrans.Commit();

                    //Clear Data Fields
                    clearData();
                    loadData();
                    btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void dataGridView_ReceiptList_MouseClick(object sender, MouseEventArgs e)
        {

        }

    }
}
