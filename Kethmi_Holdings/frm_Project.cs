using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

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
        int pId;
        DataTable dt;

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
            loadData();
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
            
            //Save to Project Master
            strsql = "INSERT INTO ProjectMaster(projName,date,addedDate,addedUser)"+
                " VALUES('"+txt_projectName.Text+"','"+dateTimePicker1.Value.ToShortDateString()+"','"+DateTime.Now+"','"+strUsername+"')";
            db.insertUpdateDelete(strsql);
            
            //get Project ID
            pId = Convert.ToInt32(db.getValue("SELECT TOP 1 projID FROM ProjectMaster ORDER BY projID DESC"));
            
            //Save Project Basic Details
            strsql = "INSERT INTO ProjectBasicDetails(projID,landOwner,location,brokerName,introduction,"+
                "totPerchs,valExpectedByOwner,valAgreedByOwner,roadways,commonArea,reservation,acres,roods,"+
                "perchs,sellableArea,addedUser,addedDate)"+
                " VALUES('"+pId+"','"+txt_owner.Text+"','"+txt_location.Text+"','"+txt_broker.Text+"','"+txt_introduction.Text+"',"+
                "'"+txt_totalPerches.Text+"','"+txt_valExpectedByOwner.Text+"','"+txt_agreedValuePP.Text+"',"+
                "'"+txt_roadways.Text+"','"+txt_commonArea.Text+"','"+txt_reservation.Text+"','"+txt_acres.Text+"',"+
                "'"+txt_roods.Text+"','"+txt_perches.Text+"','"+txt_sellableArea.Text+"','"+strUsername+"','"+DateTime.Now+"')";
            db.insertUpdateDelete(strsql);

            //Save Project Cost of Purchase
            strsql = "INSERT INTO ProjectCostofPurchase(projID,titleInsurance,stampFees,legalFees,valuationReport,titleReports,"+
                "commision,totCostOfPurchase,addedUser,addedDate)"+
                " VALUES('"+pId+"','"+txt_titleInsurance.Text+"','"+txt_stampFees.Text+"','"+txt_legalFees.Text+"',"+
                "'"+txt_valuationReport.Text+"','"+txt_titleReports.Text+"','"+txt_commision.Text+"',"+
                "'"+txt_totCostOfPurchase.Text+"','"+strUsername+"','"+DateTime.Now+"')";
            db.insertUpdateDelete(strsql);

            //Save Project Survey Charges
            strsql = "INSERT INTO ProjectSurvayCharges(projID,parameterSurvay,dimaBlocks,blockingOutPlanes,individualPlans,"+
                "contourSurvayPlans,totSurvayCost,addedUser,addedDate)"+
                " Values('"+pId+"','"+txt_parameterSurvey.Text+"','"+txt_dimaBlocks.Text+",'"+txt__blockingOutPlans.Text+"',"+
                "'"+txt_extract.Text+"','"+txt_ContourSurveyingPlans.Text+"','"+txt_totSurveyCost.Text+ "','" + strUsername + "','" + DateTime.Now + "')";
            db.insertUpdateDelete(strsql);

            //Save Project Development Cost
            strsql = "INSERT INTO ProjectDevCost(projID,clearing,fillingLeveling,culvertsDrains,parapet,roadWays,huts,"+
                "incidentalCost,fencing,watcherProjOfficer,boundryStones,pradeshiyaSabha,maintenance,donation"+
                ",contingencies,totDevCost,addedUser,addedDate)"+
                " VALUES('"+pId+"','"+txt_clearingOfLand.Text+"','"+txt_fillingAndLeveling.Text+"','"+txt_culvertsAndDrains.Text+"'"+
                ",'"+txt_RetainerWall.Text+"','"+txt_interiorRoadWays.Text+"','"+txt_Huts.Text+"','"+txt_incidentalCost.Text+"',"+
                "'"+txt_fencing.Text+"','"+txt_projectOfficer.Text+"','"+txt_boungryStones.Text+"','"+txt_pradeshiyaSabha.Text+"',"+
                "'"+txt_maintenance.Text+"','"+txt_donation.Text+"','"+txt_contingencies.Text+"','"+txt_totDevCost.Text+"',"+
                "'"+strUsername+"','"+DateTime.Now+"')";
            db.insertUpdateDelete(strsql);

            //Save Project Utilities
            strsql = "INSERT INTO ProjectUtilCost(projID,water,elec,totUtilCost,addedUser,addedDate)"+
                " VALUES('"+pId+"','"+txt_providingWater.Text+"','"+txt_providingElectricity.Text+"',"+
                "'"+strUsername+"','"+DateTime.Now+"')";
            db.insertUpdateDelete(strsql);

            //Save Project Traveling
            strsql = "INSERT INTO ProjectTravellingCost(projID,execDirectors,dgm,manager,officer,telephone,entertainment,totTravellingCost,"+
                "addedUser,addedDate) "+
                "VALUES('"+pId+"','"+txt_execDirectors.Text+"','"+txt_DGM.Text+"','"+txt_managerProject.Text+"','"+txt_projOfficer.Text+"',"+
                "'"+txt_teleAllowance.Text+"','"+txt_entertainment.Text+"','"+txt_totTravCost.Text+"','"+strUsername+"','"+DateTime.Now+"')";
            db.insertUpdateDelete(strsql);

            //Save Project Advertising
            strsql = "INSERT INTO ProjectAdvertisingCost(projID,water,banners,handBills,radioTV,holdings,pressAd,mobile,totAdCost,"+
                "addedUser,addedDate) "+
                "VALUES('"+pId+"','"+txt_water.Text+"','"+txt_banners.Text+"','"+txt_handbills.Text+"','"+txt_radioTV.Text+"',"+
                "'"+txt_holdings.Text+"','"+txt_press.Text+"','"+txt_mobileUnit.Text+"','"+txt_totAdCost.Text+"','"+strUsername+"','"+DateTime.Now+"')";
            db.insertUpdateDelete(strsql);
        }

        public void loadData()
        {
            db = new Database();
            strsql = "SELECT projID as 'ID',projName as 'Project Name' FROM ProjectMaster";
           dataGridView_projectList.DataSource = db.select(strsql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonSave();
        }

        private void dataGridView_projectList_MouseClick(object sender, MouseEventArgs e)
        {
            Console.Out.WriteLine("fsdfdfsd");

            db = new Database();
            dt = new DataTable();

            pId = Convert.ToInt32(dataGridView_projectList.SelectedRows[0].Cells[0].Value);

            strsql = "SELECT projName FROM ProjectMaster WHERE projID='" + pId + "'";
            txt_projectName.Text = db.getValue(strsql);
            
            strsql = "SELECT * FROM ProjectBasicDetails WHERE projID='"+pId+"'";
            dt = db.select(strsql);
            
            foreach (DataRow row in dt.Rows)
            {
                txt_owner.Text = row[1].ToString();
                txt_location.Text = row[2].ToString();
                txt_broker.Text = row[3].ToString();
                dateTimePicker1.Text = row[16].ToString();
                txt_introduction.Text = row[4].ToString();
                txt_totalPerches.Text = row[5].ToString();
                txt_valExpectedByOwner.Text = row[6].ToString();
                txt_agreedValuePP.Text = row[7].ToString();
                txt_roadways.Text = row[8].ToString();
                txt_commonArea.Text = row[9].ToString();
                txt_reservation.Text = row[10].ToString();
                txt_sellableArea.Text = row[14].ToString();
                txt_acres.Text = row[11].ToString();
                txt_roods.Text = row[12].ToString();
                txt_perches.Text = row[13].ToString();
            }

        }
    }
}
