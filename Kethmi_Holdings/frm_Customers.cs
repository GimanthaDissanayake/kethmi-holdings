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
    public partial class frm_Customers : Form
    {
        int cusID,pId;
        string strUsername = "",mode = "",strsql;
        List<String> list;
        Database db;
        DataTable dt;

        private string strConn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        ButtonsStates btnStat = new ButtonsStates();
        public frm_Customers(String s)
        {
            InitializeComponent();
            loadProjectNames();
            strUsername = s;           
        }

        private void frm_Customers_Load(object sender, EventArgs e)
        {
            enableEditing(false);
            loadData();
            btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
        }

        private void frm_Customers_FormClosing(object sender, FormClosingEventArgs e)
        {            
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }

        private void frm_Customers_Activated(object sender, EventArgs e)
        {
            btnStat.VisibleToolStrip((frm_Main)this.MdiParent);
        }

        private void getCusID()
        {
            db = new Database();
            cusID = Convert.ToInt32(db.getValue("SELECT TOP 1 cusID FROM Customer ORDER BY cusID DESC"))+1;
            txt_CusID.Text = cusID.ToString();
        }

        private void getProjID()
        {
            pId = Convert.ToInt32(db.getValue("SELECT TOP 1 projID FROM ProjectMaster WHERE projName='"+cmb_ProjectName.Text+"'"));
        }

        private void loadData()
        {
            db = new Database();
            strsql = "SELECT cusID as 'ID',name as 'Customer Name' FROM Customer WHERE isDeleted=0";
            dataGridView_CustomerList.DataSource = db.select(strsql);
            dataGridView_CustomerList.Enabled = true;
        }

        private void loadProjectNames()
        {
            db = new Database();
            strsql = "SELECT projName FROM ProjectMaster WHERE isDeleted=0";
            list = new List<String>();
            list = db.getList(strsql, 0);
            foreach (String projName in list)
            {
                cmb_ProjectName.Items.Add(projName);
            }
        }

        private void clearData()
        {
            txt_CusName.Clear();
            txt_NIC.Clear(); 
            txt_Phone.Clear();
            cmb_ProjectName.Text = "";
            txt_Type.Clear();
            txt_Address.Clear();
        }

        private void enableEditing(bool value)
        {
            txt_CusName.Enabled = value;
            txt_NIC.Enabled = value;
            txt_Phone.Enabled = value;
            cmb_ProjectName.Enabled = value;
            txt_Type.Enabled = value;
            txt_Address.Enabled = value;
        }

        public void ButtonNew()
        {
            getCusID();
            mode = "New";
            btnStat.ControlSideToolStrip(this.ParentForm, false, false, true, false, false, true);
            dataGridView_CustomerList.Enabled = false;
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

        private void dataGridView_CustomerList_MouseClick(object sender, MouseEventArgs e)
        {
            db = new Database();
            dt = new DataTable();

            btnStat.ControlSideToolStrip(this.ParentForm, true, true, false, false, true, false);

            cusID = Convert.ToInt32(dataGridView_CustomerList.SelectedRows[0].Cells[0].Value);

            //Fill Customer Data
            strsql = "SELECT * FROM Customer WHERE cusID='" + cusID + "'";
            dt = db.select(strsql);

            foreach (DataRow row in dt.Rows)
            {
                txt_CusName.Text = row[1].ToString();
                txt_NIC.Text = row[3].ToString();
                txt_Phone.Text = row[2].ToString();

                pId = Convert.ToInt32(row[4].ToString());
                strsql = "SELECT projName FROM ProjectMaster WHERE projID = '" + pId + "'";
                cmb_ProjectName.Text = db.getValue(strsql);
                txt_Type.Text = row[5].ToString();
                txt_Address.Text = row[6].ToString();
            }
        }

        public void ButtonClear()
        {
            if (MessageBox.Show("Are you sure want to cancal?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clearData();
                enableEditing(false);
                dataGridView_CustomerList.Enabled = true;
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
                    //get Project ID
                    getProjID();

                    //Save to Cutomers
                    objCmd.CommandText = "INSERT INTO Customer(name,phone,nic,projID,type,address,addedUser,addedDate)" +
                        " VALUES('" + txt_CusName.Text + "','" + txt_Phone.Text + "','"+txt_NIC.Text+"','"+pId+"','"+txt_Type.Text+"','"+txt_Address.Text+"',"+
                        "'"+ strUsername + "','" + DateTime.Now + "')";
                    objCmd.ExecuteNonQuery();

                    //Commit changes 
                    sqlTrans.Commit();

                    //Clear Data Fields
                    clearData();
                    loadData();
                    getCusID();
                    btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else if(mode == "Edit")
            {

                if (MessageBox.Show("Are you sure you want to Update data?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //get Project ID
                        getProjID();

                        //get Customer ID
                        db = new Database();
                        cusID = Convert.ToInt32(dataGridView_CustomerList.SelectedRows[0].Cells[0].Value);

                        //Update Customers
                        objCmd.CommandText = "UPDATE Customer SET name='" + txt_CusName.Text + "',phone='" + txt_Phone.Text + "',nic='"+ txt_NIC.Text + "'," +
                            "projID='"+pId+"',type='"+ txt_Type.Text + "',address='"+ txt_Address.Text + "'" +
                            ",changedDate='" + DateTime.Now + "',changedUser='" + strUsername + "' WHERE cusID='" + cusID + "'";
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
        }

        public void ButtonDelete()
        {
            if (MessageBox.Show("Are you sure want to delete the entire Customer?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection objConn = new SqlConnection(strConn);
                objConn.Open();
                SqlTransaction sqlTrans = objConn.BeginTransaction();
                SqlCommand objCmd = new SqlCommand();
                objCmd.Transaction = sqlTrans;
                objCmd.Connection = objConn;

                try
                {
                    objCmd.CommandText = "UPDATE Customer SET isDeleted = 1," +
                            "changedDate='" + DateTime.Now + "',changedUser='" + strUsername + "' WHERE cusID = '" + cusID + "'";
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

    }
}
