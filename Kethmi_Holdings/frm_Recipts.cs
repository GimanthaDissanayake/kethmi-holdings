using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Kethmi_Holdings
{
    public partial class frm_Recipts : Form
    {
        int cusID, pId, recID;
        String strUsername,mode="",strsql="";
        Database db;
        List<String> list;

        private string strConn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        ButtonsStates btnStat = new ButtonsStates();

        

        public frm_Recipts(String s)
        {
            InitializeComponent();
            loadCusName();
            loadProjName();
            strUsername = s;
        }

        public bool inputAreaEnabled {set { gb_inputArea.Enabled = value; } }

        public bool searchEnabled { set { gb_search.Enabled = value; } }

      //  ButtonsStates lastButtonStates;

        private void frm_Recipts_Activated(object sender, EventArgs e)
        {
            //lastButtonStates.restore();
            // btnStat.VisibleToolStrip((frm_Main)this.MdiParent);
            btnStat.VisibleToolStrip((frm_Main)this.MdiParent);
        }

        private void frm_Recipts_Deactivate(object sender, EventArgs e)
        {
           // lastButtonStates.save();
        }

        private void frm_Recipts_Load(object sender, EventArgs e)
        {
            // lastButtonStates = new ButtonsStates();
            btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
            enableEditing(false);
        }

        private void frm_Recipts_FormClosing(object sender, FormClosingEventArgs e)
        {            
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }

        private void getReceiptId()
        {
            db = new Database();
            if (db.getValue("SELECT TOP 1 reciptID FROM RecieptsMaster ORDER BY reciptID DESC") == "")
            {
                recID = 1;
            }
            else
            {
                recID = Convert.ToInt32(db.getValue("SELECT TOP 1 reciptID FROM RecieptsMaster ORDER BY reciptID DESC"))+1;
            }
            txt_ReceiptID.Text = recID.ToString();
        }

        private void getCusID()
        {
            db = new Database();
            cusID = Convert.ToInt32(db.getValue("SELECT cusID FROM Customer WHERE name = '"+cmb_CusName.Text+"'"));            
        }

        private void getProjID()
        {
            db = new Database();
            pId = Convert.ToInt32(db.getValue("SELECT projID FROM ProjectMaster WHERE projName = '" + cmb_ProjName.Text + "'"));
        }

        private void loadData()
        {
            db = new Database();
            strsql = "SELECT reciptID as 'ID',name as 'Customer Name' FROM Customer WHERE isDeleted='false'";
            dataGridView_ReceiptList.DataSource = db.select(strsql);
            dataGridView_ReceiptList.Enabled = true;
        }

        private void loadCusName()
        {
            db = new Database();
            strsql = "SELECT name FROM Customer WHERE isDeleted='false'";
            list = new List<String>();
            list = db.getList(strsql, 0);
            foreach (String name in list)
            {
                cmb_CusName.Items.Add(name);
            }
        }

        private void loadProjName()
        {
            db = new Database();
            strsql = "SELECT projName FROM ProjectMaster WHERE isDeleted='false'";
            list = new List<String>();
            list = db.getList(strsql, 0);
            foreach (String projName in list)
            {
                cmb_ProjName.Items.Add(projName);
            }
        }

        private void clearData()
        {
            cmb_CusName.Text="";
            cmb_ProjName.Text = "";
            txt_ReceiptID.Clear();
            txt_Search.Clear();
            txt_TotVal.Clear();
            txt_Type.Clear();
            txt_TypeAddOrRemove.Clear();
            dateTimePicker_date.ResetText();
        }

        private void enableEditing(bool value)
        {
            cmb_CusName.Enabled = value;
            cmb_ProjName.Enabled = value;
            txt_ReceiptID.Enabled = value;
            txt_Search.Enabled = value;
            txt_TotVal.Enabled = value;
            txt_Type.Enabled = value;
            txt_TypeAddOrRemove.Enabled = value;
            dateTimePicker_date.Enabled = value;
        }

        public void ButtonNew()
        {
            clearData();
            getReceiptId();
            mode = "New";
       
            btnStat.ControlSideToolStrip(this.ParentForm, false, false, true, false, false, true);
            dataGridView_ReceiptList.Enabled = false;
            
            enableEditing(true);
            cmb_CusName.Focus();

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
                    objCmd.CommandText = "INSERT INTO RecieptsMaster(reciptID,cusID,projID,type,date,totValue,addedUser,addedDate,isDeleted) VALUES('"+txt_ReceiptID.Text+"','"+cusID+"','"+pId+"',"+
                        "'"+txt_Type.Text+"','"+dateTimePicker_date.Value.ToShortDateString()+"','"+txt_TotVal.Text+"','"+strUsername+"','"+DateTime.Now+"','false')";
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
                    objCmd.CommandText = "UPDATE RecieptsMaster SET isDeleted = 'true'," +
                            "changedDate='" + DateTime.Now + "',changedUser='" + strUsername + "' WHERE reciptID = '" + cusID + "'";
                    objCmd.ExecuteNonQuery();

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
        
        public void ButtonPrint()
        {
            frm_ReportViewer rptVwr = new frm_ReportViewer();
            rptVwr.Show();
        }        

        private void dataGridView_ReceiptList_MouseClick(object sender, MouseEventArgs e)
        {
            btnStat.ControlSideToolStrip(this.ParentForm, true, true, false, true, true, false);
        }

    }
}
