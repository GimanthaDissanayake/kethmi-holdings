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
        Database db;

        private string strConn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        ButtonsStates btnStat = new ButtonsStates();
        public frm_Customers(String s)
        {
            InitializeComponent();
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
            cusID = Convert.ToInt32(db.getValue("SELECT TOP 1 cusID FROM Customer ORDER BY cusID DESC")) + 1;
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

        public void ButtonClear()
        {
            clearData();
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
                    objCmd.CommandText = "INSERT INTO Customer(name,phone,nic,projID,type,address,addedUser,addedDate,changedUser,changedDate)" +
                        " VALUES('" + txt_CusName.Text + "','" + txt_Phone.Text + "','"+txt_NIC.Text+"','"+pId+"','"+txt_Type.Text+"','"+txt_Address.Text+"',"+
                        "'"+ strUsername + "','" + DateTime.Now + "')";
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
            else if(mode == "Edit")
            {
                try
                {
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
