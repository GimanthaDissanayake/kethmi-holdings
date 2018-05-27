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
    public partial class frm_UserControl : Form
    {
        Database db;
        int userID,isActive;
        string strsql = "";
        string userType = "";
        string strUsername = "";
        string mode;

        ButtonsStates btnStat = new ButtonsStates();

        private string strConn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public frm_UserControl(string username)
        {
            InitializeComponent();
            loadUserData();
            setEnabled(false);
            txtUserID.Enabled = false;
            this.strUsername = username;
        }     

        private void frm_UserControl_Activated(object sender, EventArgs e)
        {
            btnStat.VisibleToolStrip((frm_Main)this.MdiParent);
        }

        private void frm_UserControl_Deactivate(object sender, EventArgs e)
        { 

        }

      
        private void frm_UserControl_Load(object sender, EventArgs e)
        {
            btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
        }

        private void loadUserData()
        {
            db = new Database();
            strsql = "SELECT userID as 'ID',username as 'Username',userType as 'Type' FROM UserDetails";
            dataGridViewUsers.DataSource = db.select(strsql);
            dataGridViewUsers.Enabled = true;
        }

        private void loadUserID()
        {
            Database db = new Database();
            if (db.getValue("SELECT TOP 1 userID FROM UserDetails ORDER BY userID DESC") == "")
            {
                userID = 1;
            }
            else
            {
                userID = Convert.ToInt32(db.getValue("SELECT TOP 1 userID FROM UserDetails ORDER BY userID DESC")) + 1;
            }
            txtUserID.Text = userID.ToString();
            strsql = "";
        }

        private void setEnabled(Boolean value)
        {
            txtPW.Enabled = value;
            txtUserName.Enabled = value;
            rbtAdmin.Enabled = value;
            rbtUser.Enabled = value;
            chkActive.Enabled = value;
        }

        private void clearData()
        {
            txtPW.Clear();
            txtUserName.Clear();
            rbtAdmin.Checked = false;
            rbtUser.Checked = false;
            chkActive.Checked = false;
        }

        public void ButtonNew()
        {
            mode = "New";
            setEnabled(true);
            btnStat.ControlSideToolStrip(this.ParentForm,false,false,true,false,false,true);
            loadUserID();
        }
        public void ButtonClear()
        {
            if (MessageBox.Show("Are you sure want to cancel?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clearData();
                enableEditing(false);
                dataGridViewUsers.Enabled = true;
                btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
            }
        }

        public void ButtonEdit()
        {
            mode = "Edit";
            txtUserID.Enabled = false;
            enableEditing(true);
            btnStat.ControlSideToolStrip(this.ParentForm, false, false, true, false, false, true);        
        }

        public void ButtonSave()
        {
            if (mode == Modes.NEW)
            {
                db = new Database();
                if (rbtAdmin.Checked)
                    userType = "Admin";
                else
                    userType = "User";

                strsql = "INSERT INTO UserDetails (username, password, addedDate, " +
                    "addedUser,usertype,isActive ) VALUES ('" + txtUserName.Text + "','" + txtPW.Text + "','" + DateTime.Now + "','" + strUsername + "','" + userType + "','" + chkActive.Checked + "')";
                db.insertUpdateDelete(strsql);
                clearData();
                loadUserData();
            }
            else if (mode == Modes.EDIT)
            {
                if (MessageBox.Show("Are you sure you want to Update data?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        db = new Database();

                        //get userID
                        userID = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells[0].Value);

                        //set user type
                        if (rbtAdmin.Checked)
                            userType = "Admin";
                        else
                            userType = "User";

                        //update user details
                        strsql = "UPDATE UserDetails SET username = '"+txtUserName.Text+"',password = '"+txtPW.Text+"',userType = '"+userType+ "',isActive = '" + chkActive.Checked + "'," +
                            "changedDate='" + DateTime.Now + "',changedUser='" + strUsername + "' WHERE userID = '" + userID + "'";
                        db.insertUpdateDelete(strsql);

                        //Clear Data Fields
                        clearData();
                        loadUserData();
                        btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }         
        }

        private void frm_UserControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }

        private void dataGridViewUsers_MouseClick(object sender, MouseEventArgs e)
        {
            db = new Database();

            btnStat.ControlSideToolStrip(this.ParentForm, true, true, false, false, false, false);
            userID = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells[0].Value);
            txtUserID.Text = userID.ToString();
            txtUserName.Text = dataGridViewUsers.SelectedRows[0].Cells[1].Value.ToString();
            txtPW.Text = dataGridViewUsers.SelectedRows[0].Cells[2].Value.ToString();

            strsql = "SELECT userType FROM userDetails WHERE userID = '"+ userID + "'";
            userType = db.getValue(strsql);
            if (userType == "Admin")
                rbtAdmin.Checked = true;
            else
                rbtUser.Checked = true;

            strsql = "SELECT isActive From userDetails WHERE userID = '" + userID + "'";
            if (db.getValue(strsql) == "True")
                chkActive.Checked = true;
            else
                chkActive.Checked = false;
            Console.WriteLine(db.getValue(strsql));
        }

        private void enableEditing(bool value)
        {
            txtUserName.Enabled = value;
            txtPW.Enabled = value;
            rbtAdmin.Enabled = value;
            rbtUser.Enabled = value;
            chkActive.Enabled = value;
        }
    }
}
