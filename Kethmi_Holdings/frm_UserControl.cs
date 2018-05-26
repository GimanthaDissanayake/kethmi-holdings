using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            strsql = "SELECT userID as 'ID',username as 'Username',userType as 'Type' FROM UserDetails WHERE isActive=1";
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
            setEnabled(true);
            btnStat.ControlSideToolStrip(this.ParentForm,false,false,true,false,false,true);
            loadUserID();
        }
        public void ButtonClear()
        {
            if (MessageBox.Show("Are you sure want to cancel?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clearData();
                btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
            }
        }

        public void ButtonSave()
        {
            if(mode== Modes.NEW)
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
            else if(mode == Modes.EDIT)
            {

            }          
        }

        private void frm_UserControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void dataGridViewUsers_MouseClick(object sender, MouseEventArgs e)
        {
            btnStat.ControlSideToolStrip(this.ParentForm, true, true, false, false, true, false);
        }

        private void enableEditing(bool value)
        {
            txtUserName.Enabled = value;

        }
    }
}
