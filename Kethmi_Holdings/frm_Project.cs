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
    public partial class frm_Project : Form
    {
        public frm_Project()
        {
            InitializeComponent();
        }
        Database db;
        string strsql = "";
        Form formArg;
        public frm_Project(Form f)
        {
            InitializeComponent();
            formArg = f;
        }
        
        public bool setGbProjectSearchEnabled { set { gb_projectSearch.Enabled = value; } }
        public bool setTcProjectsEnabled { set { tc_project.Enabled = value; } }


        private void frm_Project_Load(object sender, EventArgs e)
        {
            tc_project.Enabled = true;
            lastButtonStates = new ButtonsStates();
            CommonClass.setToolTipButtonStates(true, true, false, false, true, false);
            lastButtonStates.save();
        }

        private void frm_Project_FormClosing(object sender, FormClosingEventArgs e) {
            
        }

        ButtonsStates lastButtonStates;
        private void frm_Project_Activated(object sender, EventArgs e)
        {
            lastButtonStates.restore();
        }

        private void frm_Project_Deactivate(object sender, EventArgs e)
        {
            lastButtonStates.save();
        }

        public void ButtonSave()
        {
            db = new Database();
            strsql = "INSERT INTO ProjectMaster(projName) VALUES('"+txt_projectName.Text+"')";
            db.insertUpdateDelete(strsql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonSave();
        }
    }
}
