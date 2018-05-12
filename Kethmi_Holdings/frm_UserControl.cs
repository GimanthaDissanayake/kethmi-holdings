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
        public frm_UserControl(string username)
        {
            InitializeComponent();
            this.strUsername = username;
        }

        public bool gb_CurrentUsersEnabled {set { gb_currentUsers.Enabled = value; }}
        public bool gb_InputAreaEnabled { set { gb_inputArea.Enabled = value; } }

        private void frm_UserControl_Activated(object sender, EventArgs e)
        {
            lastButtonStates.restore();
        }

        private void frm_UserControl_Deactivate(object sender, EventArgs e)
        {
            lastButtonStates.save();
        }

        ButtonsStates lastButtonStates;
        private void frm_UserControl_Load(object sender, EventArgs e)
        {
            lastButtonStates = new ButtonsStates();
        }
        public void ButtonAdd()
        {
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
            ButtonsStates btnStat = new ButtonsStates();
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }
    }
}
