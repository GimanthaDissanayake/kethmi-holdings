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
                " Values('"+pId+"','"+txt_parameterSurvey.Text+"','"+txt_dimaBlocks.Text+"','"+txt__blockingOutPlans.Text+"',"+
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
                " VALUES('"+pId+"','"+txt_providingWater.Text+"','"+txt_providingElectricity.Text+"','"+txt_totUtilityCost.Text+"',"+
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

            //Save Cost Sales and Profitability

            //Clear Data Fields
            clearData();
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
            db = new Database();
            dt = new DataTable();

            pId = Convert.ToInt32(dataGridView_projectList.SelectedRows[0].Cells[0].Value);

            strsql = "SELECT projName FROM ProjectMaster WHERE projID='" + pId + "'";
            txt_projectName.Text = db.getValue(strsql);
            
            //Fill Basic Details Tab
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

            /*Fill Cost Of Purchase Tab*/
            //Fill Cost of Purchase 
            strsql = "SELECT * FROM ProjectCostofPurchase WHERE projID='" + pId + "'";
            dt = db.select(strsql);

            foreach (DataRow row in dt.Rows)
            {
                txt_titleInsurance.Text = row[1].ToString();
                txt_stampFees.Text = row[2].ToString();
                txt_legalFees.Text = row[3].ToString();
                txt_valuationReport.Text = row[4].ToString();
                txt_titleReports.Text = row[5].ToString();
                txt_commision.Text = row[6].ToString();
                txt_totCostOfPurchase.Text = row[7].ToString();
            }
            //Fill Survey Charges
            strsql = "SELECT * FROM ProjectSurvayCharges WHERE projID='" + pId + "'";
            dt = db.select(strsql);

            foreach (DataRow row in dt.Rows)
            {
                txt_parameterSurvey.Text = row[1].ToString();
                txt_dimaBlocks.Text = row[2].ToString();
                txt__blockingOutPlans.Text = row[3].ToString();
                txt_extract.Text = row[4].ToString();
                txt_ContourSurveyingPlans.Text = row[5].ToString();
                txt_totSurveyCost.Text = row[6].ToString();                
            }

            /*Fill Development & Utility Tab*/
            //Fill Development
            strsql = "SELECT * FROM ProjectDevCost WHERE projID='" + pId + "'";
            dt = db.select(strsql);

            foreach (DataRow row in dt.Rows)
            {
                txt_clearingOfLand.Text = row[1].ToString();
                txt_fillingAndLeveling.Text = row[2].ToString();
                txt_culvertsAndDrains.Text = row[3].ToString();
                txt_RetainerWall.Text = row[4].ToString();
                txt_interiorRoadWays.Text = row[5].ToString();
                txt_Huts.Text = row[6].ToString();
                txt_incidentalCost.Text = row[7].ToString();
                txt_fencing.Text = row[8].ToString();
                txt_projectOfficer.Text = row[9].ToString();
                txt_boungryStones.Text = row[10].ToString();
                txt_pradeshiyaSabha.Text = row[11].ToString();
                txt_maintenance.Text = row[12].ToString();
                txt_donation.Text = row[13].ToString();
                txt_contingencies.Text = row[14].ToString();
                txt_totDevCost.Text = row[15].ToString();
            }
            //Fill Utility
            strsql = "SELECT * FROM ProjectUtilCost WHERE projID='" + pId + "'";
            dt = db.select(strsql);

            foreach (DataRow row in dt.Rows)
            {
                txt_providingWater.Text = row[1].ToString();
                txt_providingElectricity.Text = row[2].ToString();
                txt_totUtilityCost.Text = row[3].ToString();                
            }

            /*Fill Travelling & Advertising Tab*/
            //Fill Traveling
            strsql = "SELECT * FROM ProjectTravellingCost WHERE projID='" + pId + "'";
            dt = db.select(strsql);

            foreach (DataRow row in dt.Rows)
            {
                txt_execDirectors.Text = row[1].ToString();
                txt_DGM.Text = row[2].ToString();
                txt_managerProject.Text = row[3].ToString();
                txt_projOfficer.Text = row[4].ToString();
                txt_teleAllowance.Text = row[5].ToString();
                txt_entertainment.Text = row[6].ToString();
                txt_totTravCost.Text = row[7].ToString();
            }
            //Fill Advertising
            strsql = "SELECT * FROM ProjectAdvertisingCost WHERE projID='" + pId + "'";
            dt = db.select(strsql);

            foreach (DataRow row in dt.Rows)
            {
                txt_water.Text = row[1].ToString();
                txt_banners.Text = row[2].ToString();
                txt_handbills.Text = row[3].ToString();
                txt_radioTV.Text = row[4].ToString();
                txt_holdings.Text = row[5].ToString();
                txt_press.Text = row[6].ToString();
                txt_mobileUnit.Text = row[7].ToString();
                txt_totAdCost.Text = row[8].ToString();
            }


            /*Fill Cost Sales & Profitability Tab*/
            //Fill Cost

            //Fill Sales & Profitability


            /*Disable Editing*/
            enableEditing(false);
        }

        public void clearData()
        {
            txt_projectName.Text = "";
            txt_owner.Text = "";
            txt_location.Text = "";
            txt_broker.Text = "";
            dateTimePicker1.Text = "";
            txt_introduction.Text = "";
            txt_totalPerches.Text = "";
            txt_valExpectedByOwner.Text = "";
            txt_agreedValuePP.Text = "";
            txt_roadways.Text = "";
            txt_commonArea.Text = "";
            txt_reservation.Text = "";
            txt_sellableArea.Text = "";
            txt_acres.Text = "";
            txt_roods.Text = "";
            txt_perches.Text = "";
            txt_titleInsurance.Text = "";
            txt_stampFees.Text = "";
            txt_legalFees.Text = "";
            txt_valuationReport.Text = "";
            txt_titleReports.Text = "";
            txt_commision.Text = "";
            txt_totCostOfPurchase.Text = "";
            txt_parameterSurvey.Text = "";
            txt_dimaBlocks.Text = "";
            txt__blockingOutPlans.Text = "";
            txt_extract.Text = "";
            txt_ContourSurveyingPlans.Text = "";
            txt_totSurveyCost.Text = "";
            txt_clearingOfLand.Text = "";
            txt_fillingAndLeveling.Text = "";
            txt_culvertsAndDrains.Text = "";
            txt_RetainerWall.Text = "";
            txt_interiorRoadWays.Text = "";
            txt_Huts.Text = "";
            txt_incidentalCost.Text = "";
            txt_fencing.Text = "";
            txt_projectOfficer.Text = "";
            txt_boungryStones.Text = "";
            txt_pradeshiyaSabha.Text = "";
            txt_maintenance.Text = "";
            txt_donation.Text = "";
            txt_contingencies.Text = "";
            txt_totDevCost.Text = "";
            txt_providingWater.Text = "";
            txt_providingElectricity.Text = "";
            txt_totUtilityCost.Text = "";
            txt_execDirectors.Text = "";
            txt_DGM.Text = "";
            txt_managerProject.Text = "";
            txt_projOfficer.Text = "";
            txt_teleAllowance.Text = "";
            txt_entertainment.Text = "";
            txt_totTravCost.Text = "";
            txt_water.Text = "";
            txt_banners.Text = "";
            txt_handbills.Text = "";
            txt_radioTV.Text = "";
            txt_holdings.Text = "";
            txt_press.Text = "";
            txt_mobileUnit.Text = "";
            txt_totAdCost.Text = "";
            /*sm missing*/
        }

        public void enableEditing(bool value)
        {
            if (value)
            {
                txt_projectName.Enabled = true;
                txt_owner.Enabled = true;
                txt_location.Enabled = true;
                txt_broker.Enabled = true;
                dateTimePicker1.Enabled = true;
                txt_introduction.Enabled = true;
                txt_totalPerches.Enabled = true;
                txt_valExpectedByOwner.Enabled = true;
                txt_agreedValuePP.Enabled = true;
                txt_roadways.Enabled = true;
                txt_commonArea.Enabled = true;
                txt_reservation.Enabled = true;
                txt_sellableArea.Enabled = true;
                txt_acres.Enabled = true;
                txt_roods.Enabled = true;
                txt_perches.Enabled = true;
                txt_titleInsurance.Enabled = true;
                txt_stampFees.Enabled = true;
                txt_legalFees.Enabled = true;
                txt_valuationReport.Enabled = true;
                txt_titleReports.Enabled = true;
                txt_commision.Enabled = true;
                txt_totCostOfPurchase.Enabled = true;
                txt_parameterSurvey.Enabled = true;
                txt_dimaBlocks.Enabled = true;
                txt__blockingOutPlans.Enabled = true;
                txt_extract.Enabled = true;
                txt_ContourSurveyingPlans.Enabled = true;
                txt_totSurveyCost.Enabled = true;
                txt_clearingOfLand.Enabled = true;
                txt_fillingAndLeveling.Enabled = true;
                txt_culvertsAndDrains.Enabled = true;
                txt_RetainerWall.Enabled = true;
                txt_interiorRoadWays.Enabled = true;
                txt_Huts.Enabled = true;
                txt_incidentalCost.Enabled = true;
                txt_fencing.Enabled = true;
                txt_projectOfficer.Enabled = true;
                txt_boungryStones.Enabled = true;
                txt_pradeshiyaSabha.Enabled = true;
                txt_maintenance.Enabled = true;
                txt_donation.Enabled = true;
                txt_contingencies.Enabled = true;
                txt_totDevCost.Enabled = true;
                txt_providingWater.Enabled = true;
                txt_providingElectricity.Enabled = true;
                txt_totUtilityCost.Enabled = true;
                txt_execDirectors.Enabled = true;
                txt_DGM.Enabled = true;
                txt_managerProject.Enabled = true;
                txt_projOfficer.Enabled = true;
                txt_teleAllowance.Enabled = true;
                txt_entertainment.Enabled = true;
                txt_totTravCost.Enabled = true;
                txt_water.Enabled = true;
                txt_banners.Enabled = true;
                txt_handbills.Enabled = true;
                txt_radioTV.Enabled = true;
                txt_holdings.Enabled = true;
                txt_press.Enabled = true;
                txt_mobileUnit.Enabled = true;
                txt_totAdCost.Enabled = true;
                /*sm missing*/
            }
            else if (!value)
            {
                txt_projectName.Enabled = false;
                txt_owner.Enabled = false;
                txt_location.Enabled = false;
                txt_broker.Enabled = false;
                dateTimePicker1.Enabled = false;
                txt_introduction.Enabled = false;
                txt_totalPerches.Enabled = false;
                txt_valExpectedByOwner.Enabled = false;
                txt_agreedValuePP.Enabled = false;
                txt_roadways.Enabled = false;
                txt_commonArea.Enabled = false;
                txt_reservation.Enabled = false;
                txt_sellableArea.Enabled = false;
                txt_acres.Enabled = false;
                txt_roods.Enabled = false;
                txt_perches.Enabled = false;
                txt_titleInsurance.Enabled = false;
                txt_stampFees.Enabled = false;
                txt_legalFees.Enabled = false;
                txt_valuationReport.Enabled = false;
                txt_titleReports.Enabled = false;
                txt_commision.Enabled = false;
                txt_totCostOfPurchase.Enabled = false;
                txt_parameterSurvey.Enabled = false;
                txt_dimaBlocks.Enabled = false;
                txt__blockingOutPlans.Enabled = false;
                txt_extract.Enabled = false;
                txt_ContourSurveyingPlans.Enabled = false;
                txt_totSurveyCost.Enabled = false;
                txt_clearingOfLand.Enabled = false;
                txt_fillingAndLeveling.Enabled = false;
                txt_culvertsAndDrains.Enabled = false;
                txt_RetainerWall.Enabled = false;
                txt_interiorRoadWays.Enabled = false;
                txt_Huts.Enabled = false;
                txt_incidentalCost.Enabled = false;
                txt_fencing.Enabled = false;
                txt_projectOfficer.Enabled = false;
                txt_boungryStones.Enabled = false;
                txt_pradeshiyaSabha.Enabled = false;
                txt_maintenance.Enabled = false;
                txt_donation.Enabled = false;
                txt_contingencies.Enabled = false;
                txt_totDevCost.Enabled = false;
                txt_providingWater.Enabled = false;
                txt_providingElectricity.Enabled = false;
                txt_totUtilityCost.Enabled = false;
                txt_execDirectors.Enabled = false;
                txt_DGM.Enabled = false;
                txt_managerProject.Enabled = false;
                txt_projOfficer.Enabled = false;
                txt_teleAllowance.Enabled = false;
                txt_entertainment.Enabled = false;
                txt_totTravCost.Enabled = false;
                txt_water.Enabled = false;
                txt_banners.Enabled = false;
                txt_handbills.Enabled = false;
                txt_radioTV.Enabled = false;
                txt_holdings.Enabled = false;
                txt_press.Enabled = false;
                txt_mobileUnit.Enabled = false;
                txt_totAdCost.Enabled = false;
                /*some text fields missing*/
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enableEditing(true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearData();
            enableEditing(true);
        }
    }
}
