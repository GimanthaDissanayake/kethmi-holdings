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
        public frm_Project(String s)
        {
            InitializeComponent();
            strUsername = s;
        }
        Database db;
        string strsql = "";
        string strUsername = "";
        Form formArg;
        /*
        public frm_Project(Form f)
        {
            InitializeComponent();
            formArg = f;
        }*/
        
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
            strsql = "INSERT INTO ProjectMaster(projName,date,addedDate,addedUser)"+
                " VALUES('"+txt_projectName.Text+"','"+dateTimePicker1.Value.ToShortDateString()+"','"+DateTime.Now+"','"+strUsername+"')";
            db.insertUpdateDelete(strsql);
            int pId;
            pId = Convert.ToInt32(db.getValue("SELECT TOP 1 projID FROM ProjectMaster ORDER BY projID DESC"));
            strsql = "INSERT INTO ProjectBasicDetails(projID,landOwner,location,brokerName,introduction,"+
                "totPerchs,valExpectedByOwner,valAgreedByOwner,roadways,commonArea,reservation,acres,roods,"+
                "perchs,sellableArea,addedUser,addedDate)"+
                " VALUES('"+pId+"','"+txt_owner.Text+"','"+txt_location.Text+"','"+txt_broker.Text+"','"+txt_introduction.Text+"',"+
                "'"+txt_totalPerches.Text+"','"+txt_valExpectedByOwner.Text+"','"+txt_agreedValuePP.Text+"',"+
                "'"+txt_roadways.Text+"','"+txt_commonArea.Text+"','"+txt_reservation.Text+"','"+txt_acres.Text+"',"+
                "'"+txt_roods.Text+"','"+txt_perches.Text+"','"+txt_sellableArea.Text+"','"+strUsername+"','"+DateTime.Now+"')";
            db.insertUpdateDelete(strsql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonSave();
        }
    }
}
