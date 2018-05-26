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
        string strsql = "";
        string userType = "";
        string strUsername = "";
        ButtonsStates btnStat = new ButtonsStates();
        public frm_UserControl(string username)
        {
            InitializeComponent();
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
        public void ButtonNew()
        {
            btnStat.ControlSideToolStrip(this.ParentForm,false,false,true,false,false,true);
        }
        public void ButtonClear()
        {
            if (MessageBox.Show("Are you sure want to cancel?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                                
                
                btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
            }
        }

        public void ButtonSave()
        {
            db = new Database();
            if (rbtAdmin.Checked)
                userType = "Admin";
            else
                userType = "User";

            db.select("SELECT * FROM UserDetails WHERE userID = {txtUserID.Text}");

            strsql = "insert into userdetails (userid,username, password, addedDate, "+
                "addedUser,usertype,active ) values ('"+txtUserID.Text+"','"+txtUserName.Text+"','"+txtPW.Text+"','"+DateTime.Now.ToString()+"','"+strUsername+"','"+userType+"','"+chkActive.Checked+"')";
            db.insertUpdateDelete(strsql);

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
