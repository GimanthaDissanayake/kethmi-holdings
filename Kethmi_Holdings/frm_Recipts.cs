using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Kethmi_Holdings
{
    public partial class frm_Recipts : Form
    {
        int cusID, pId, recID;
        String strUsername,mode="",strsql="";
        Database db;
        DataTable dt;
        List<String> list;

        private string strConn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        ButtonsStates btnStat = new ButtonsStates();

        

        public frm_Recipts(String s)
        {
            InitializeComponent();
            loadCusName();
            loadProjName();
            loadData();
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
            strsql = "SELECT m.reciptID as 'ID',c.name as 'Customer Name',p.projName as 'Project Name' FROM RecieptsMaster m,"+
                " ProjectMaster p, Customer c WHERE m.cusID = c.cusID AND "+
                "m.projID = p.projID  AND m.isDeleted='false'";
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
            dataGridView_PaymentTypes.DataSource = null;
            dataGridView_PaymentTypes.Columns.Add("PaymentType", "Payment Type");
            dataGridView_PaymentTypes.Columns.Add("Value", "Value");

            cmb_CusName.Text="";
            cmb_ProjName.Text = "";
            txt_ReceiptID.Clear();
            txt_Search.Clear();
            txt_TotVal.Text = "0.00";
            txt_Type.Clear();
            txt_PaymentType.Clear();
            txt_Value.Clear();
            dateTimePicker_date.ResetText();
        }

        private void enableEditing(bool value)
        {
            cmb_CusName.Enabled = value;
            cmb_ProjName.Enabled = value;
            txt_ReceiptID.Enabled = value;
            txt_Type.Enabled = value;
            txt_Value.Enabled = value;
            txt_PaymentType.Enabled = value;
            dateTimePicker_date.Enabled = value;
        }

        private void search()
        {
            db = new Database();
            strsql = "SELECT m.reciptID as 'ID',c.name as 'Customer Name',p.projName as 'Project Name' FROM RecieptsMaster m," +
                " ProjectMaster p, Customer c WHERE m.cusID = c.cusID AND " +
                "m.projID = p.projID AND (c.name LIKE '" + txt_Search.Text + "%' OR c.name LIKE '" + txt_Search.Text + "%')  AND m.isDeleted='false'";
            dataGridView_ReceiptList.DataSource = db.select(strsql);
            dataGridView_ReceiptList.Enabled = true;
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

        private void calTotal()
        {
            double tot = Convert.ToDouble(txt_Value.Text) + Convert.ToDouble(txt_TotVal.Text);
            txt_TotVal.Text = tot.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dataGridView_PaymentTypes.Rows.Add(txt_PaymentType.Text,txt_Value.Text);
            calTotal();
            txt_Value.Clear();
            txt_PaymentType.Clear();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            dataGridView_PaymentTypes.Rows.RemoveAt(this.dataGridView_PaymentTypes.SelectedRows[0].Index);
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        public void ButtonSave()
        {
            SqlConnection objConn = new SqlConnection(strConn);
            objConn.Open();
            SqlTransaction sqlTrans = objConn.BeginTransaction();
            SqlCommand objCmd = new SqlCommand();
            objCmd.Transaction = sqlTrans;
            objCmd.Connection = objConn;

            if(mode == Modes.NEW)
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
                    for(int rowCount = 0; rowCount < dataGridView_PaymentTypes.Rows.Count; rowCount++)
                    {
                        objCmd.CommandText = "INSERT INTO RecieptsDetails(reciptID,type,value) VALUES('" + txt_ReceiptID.Text + "','" + dataGridView_PaymentTypes.Rows[rowCount].Cells[0].Value.ToString() + "','" + dataGridView_PaymentTypes.Rows[rowCount].Cells["Value"].Value.ToString() + "')";
                        objCmd.ExecuteNonQuery();
                    }
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
            else if(mode == Modes.EDIT)
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
            db = new Database();
            dt = new DataTable();

            btnStat.ControlSideToolStrip(this.ParentForm, true, true, false, true, true, false);

            recID = Convert.ToInt32(dataGridView_ReceiptList.SelectedRows[0].Cells[0].Value);
            txt_ReceiptID.Text = recID.ToString();

            strsql = "SELECT cusID FROM RecieptsMaster WHERE reciptID = '"+recID+"'";
            cusID = Convert.ToInt32(db.getValue(strsql));
            cmb_CusName.Text = dataGridView_ReceiptList.SelectedRows[0].Cells[1].Value.ToString();

            strsql = "SELECT projID FROM RecieptsMaster WHERE reciptID = '" + recID + "'";
            pId = Convert.ToInt32(db.getValue(strsql));
            cmb_ProjName.Text = dataGridView_ReceiptList.SelectedRows[0].Cells[2].Value.ToString();

            strsql = "SELECT type FROM RecieptsMaster WHERE reciptID = '" + recID + "'";
            txt_Type.Text = db.getValue(strsql);

            strsql = "SELECT date FROM RecieptsMaster WHERE reciptID = '" + recID + "'";
            dateTimePicker_date.Text = db.getValue(strsql);

            strsql = "SELECT totValue FROM RecieptsMaster WHERE reciptID = '" + recID + "'";
            txt_TotVal.Text = db.getValue(strsql);

            strsql = "SELECT type as 'Payment Type', value as 'Value' FROM RecieptsDetails WHERE reciptID = '" + recID + "'";
            dataGridView_PaymentTypes.Columns.Clear();
            dataGridView_PaymentTypes.DataSource = db.select(strsql);
        }

    }
}
