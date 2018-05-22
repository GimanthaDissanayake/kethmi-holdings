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
using System.Configuration;

namespace Kethmi_Holdings
{
    public partial class frm_Project : Form
    {
        Database db;
        string strsql = "";
        string strUsername = "";
        int pId;
        DataTable dt;
        ButtonsStates btnStat = new ButtonsStates();
        string mode = "";

        private string strConn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public frm_Project(String s)
        {
            InitializeComponent();
            strUsername = s;
        }

        private void frm_Project_Load(object sender, EventArgs e)
        {
            enableEditing(false);
            tc_project.Enabled = true;
            loadData();
            btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
        }

        private void frm_Project_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frm_Project_Activated(object sender, EventArgs e)
        {
            btnStat.VisibleToolStrip((frm_Main)this.MdiParent);
        }

        private void frm_Project_Deactivate(object sender, EventArgs e)
        {
        }

        public void ButtonClear()
        {
            if (MessageBox.Show("Are you sure want to cancal?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clearData();
                enableEditing(false);
                dataGridView_projectList.Enabled = true;
                btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
            }
        }

        public void ButtonDelete()
        {
            if (MessageBox.Show("Are you sure want to delete the entire project?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);

                SqlConnection objConn = new SqlConnection(strConn);
                objConn.Open();
                SqlTransaction sqlTrans = objConn.BeginTransaction();
                SqlCommand objCmd = new SqlCommand();
                objCmd.Transaction = sqlTrans;
                objCmd.Connection = objConn;

                try
                {
                    objCmd.CommandText = "UPDATE ProjectMaster SET isDeleted = 1," +
                            "changedDate='" + DateTime.Now + "',changedUser='" + strUsername + "' WHERE projID = '" + pId + "'";
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

        //public void ButtonSave() {
        //    MessageBox.Show(Validation.isStringWithoutNumbers("hel3lo").ToString());
        //}

        /// <summary>
        /// Validate fields in frm_Projects check if they are all in prefered format, if it is
        /// return true, else return false.
        /// </summary>
        /// <returns></returns>
        public Boolean ValidateFields() {
            // Validate Project Basic Details

            // + Land Info
            foreach (Control control in landInfo_gb.Controls) {
                if (control is TextBox)
                {
                    if (!Validation.isNumber(control.Text))
                    {
                        return false;
                    }
                }
            }

            // + Profile Info, no Validations for the date since we get it from dtp
            foreach (Control control in profileInfo_gb.Controls)
            {
                if (control is TextBox)
                {
                    if (!Validation.isStringWithoutNumbers(control.Text))
                    {
                        return false;
                    }
                }
            }

            // + cost of purchase
            foreach (Control control in costOfPurchase_gb.Controls)
            {
                if (control is TextBox)
                {
                    if (!Validation.isNumber(control.Text))
                    {
                        return false;
                    }
                }
            }

            // + survey charges
            foreach (Control control in surveyCharges_gb.Controls)
            {
                if (control is TextBox)
                {
                    if (!Validation.isNumber(control.Text))
                    {
                        return false;
                    }
                }
            }

            // + develpoment
            foreach (Control control in development_gb.Controls)
            {
                if (control is TextBox)
                {
                    if (!Validation.isNumber(control.Text))
                    {
                        return false;
                    }
                }
            }

            // + utilities
            foreach (Control control in utilities_gb.Controls)
            {
                if (control is TextBox)
                {
                    if (!Validation.isNumber(control.Text))
                    {
                        return false;
                    }
                }
            }

            // + travelling
            foreach (Control control in travelling_gb.Controls)
            {
                if (control is TextBox)
                {
                    if (!Validation.isNumber(control.Text))
                    {
                        return false;
                    }
                }
            }

            // + advertising
            foreach (Control control in advertising_gb.Controls)
            {
                if (control is TextBox)
                {
                    if (!Validation.isNumber(control.Text))
                    {
                        return false;
                    }
                }
            }

            // cost, sales and profitability part should be validated.

            return true;
        }

        public void ButtonSave()
        {
            SqlConnection objConn = new SqlConnection(strConn);
            objConn.Open();
            SqlTransaction sqlTrans = objConn.BeginTransaction();
            SqlCommand objCmd = new SqlCommand();
            objCmd.Transaction = sqlTrans;
            objCmd.Connection = objConn;

            if (!ValidateFields())
            {
                MessageBox.Show("There is a error of data, please check all fields are correctly filled and try again!", "Validation Error!", MessageBoxButtons.OK);
            }
            else
            {
                if (mode == "New")
                {
                    try
                    {
                        //get Project ID
                        db = new Database();
                        pId = Convert.ToInt32(db.getValue("SELECT TOP 1 projID FROM ProjectMaster ORDER BY projID DESC")) + 1;

                        //Save to Project Master
                        objCmd.CommandText = "INSERT INTO ProjectMaster(projName,date,addedDate,addedUser)" +
                            " VALUES('" + txt_projectName.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + DateTime.Now + "','" + strUsername + "')";
                        objCmd.ExecuteNonQuery();

                        //Save Project Basic Details
                        objCmd.CommandText = "INSERT INTO ProjectBasicDetails(projID,landOwner,location,brokerName,introduction," +
                            "totPerchs,valExpectedByOwner,valAgreedByOwner,roadways,commonArea,reservation,acres,roods," +
                            "perchs,sellableArea,addedUser,addedDate)" +
                            " VALUES('" + pId + "','" + txt_owner.Text + "','" + txt_location.Text + "','" + txt_broker.Text + "','" + txt_introduction.Text + "'," +
                            "'" + txt_totalPerches.Text + "','" + txt_valExpectedByOwner.Text + "','" + txt_agreedValuePP.Text + "'," +
                            "'" + txt_roadways.Text + "','" + txt_commonArea.Text + "','" + txt_reservation.Text + "','" + txt_acres.Text + "'," +
                            "'" + txt_roods.Text + "','" + txt_perches.Text + "','" + txt_sellableArea.Text + "','" + strUsername + "','" + DateTime.Now + "')";
                        objCmd.ExecuteNonQuery();

                        //Save Project Cost of Purchase
                        objCmd.CommandText = "INSERT INTO ProjectCostofPurchase(projID,titleInsurance,stampFees,legalFees,valuationReport,titleReports," +
                            "commision,totCostOfPurchase,addedUser,addedDate)" +
                            " VALUES('" + pId + "','" + txt_titleInsurance.Text + "','" + txt_stampFees.Text + "','" + txt_legalFees.Text + "'," +
                            "'" + txt_valuationReport.Text + "','" + txt_titleReports.Text + "','" + txt_commision.Text + "'," +
                            "'" + txt_totCostOfPurchase.Text + "','" + strUsername + "','" + DateTime.Now + "')";
                        objCmd.ExecuteNonQuery();

                        //Save Project Survey Charges
                        objCmd.CommandText = "INSERT INTO ProjectSurvayCharges(projID,parameterSurvay,dimaBlocks,blockingOutPlanes,individualPlans," +
                            "contourSurvayPlans,totSurvayCost,addedUser,addedDate)" +
                            " Values('" + pId + "','" + txt_parameterSurvey.Text + "','" + txt_dimaBlocks.Text + "','" + txt__blockingOutPlans.Text + "'," +
                            "'" + txt_extract.Text + "','" + txt_ContourSurveyingPlans.Text + "','" + txt_totSurveyCost.Text + "','" + strUsername + "','" + DateTime.Now + "')";
                        objCmd.ExecuteNonQuery();

                        //Save Project Development Cost
                        objCmd.CommandText = "INSERT INTO ProjectDevCost(projID,clearing,fillingLeveling,culvertsDrains,parapet,roadWays,huts," +
                            "incidentalCost,fencing,watcherProjOfficer,boundryStones,pradeshiyaSabha,maintenance,donation" +
                            ",contingencies,totDevCost,addedUser,addedDate)" +
                            " VALUES('" + pId + "','" + txt_clearingOfLand.Text + "','" + txt_fillingAndLeveling.Text + "','" + txt_culvertsAndDrains.Text + "'" +
                            ",'" + txt_RetainerWall.Text + "','" + txt_interiorRoadWays.Text + "','" + txt_Huts.Text + "','" + txt_incidentalCost.Text + "'," +
                            "'" + txt_fencing.Text + "','" + txt_projectOfficer.Text + "','" + txt_boungryStones.Text + "','" + txt_pradeshiyaSabha.Text + "'," +
                            "'" + txt_maintenance.Text + "','" + txt_donation.Text + "','" + txt_contingencies.Text + "','" + txt_totDevCost.Text + "'," +
                            "'" + strUsername + "','" + DateTime.Now + "')";
                        objCmd.ExecuteNonQuery();

                        //Save Project Utilities
                        objCmd.CommandText = "INSERT INTO ProjectUtilCost(projID,water,elec,totUtilCost,addedUser,addedDate)" +
                            " VALUES('" + pId + "','" + txt_providingWater.Text + "','" + txt_providingElectricity.Text + "','" + txt_totUtilityCost.Text + "'," +
                            "'" + strUsername + "','" + DateTime.Now + "')";
                        objCmd.ExecuteNonQuery();

                        //Save Project Traveling
                        objCmd.CommandText = "INSERT INTO ProjectTravellingCost(projID,execDirectors,dgm,manager,officer,telephone,entertainment,totTravellingCost," +
                            "addedUser,addedDate) " +
                            "VALUES('" + pId + "','" + txt_execDirectors.Text + "','" + txt_DGM.Text + "','" + txt_managerProject.Text + "','" + txt_projOfficer.Text + "'," +
                            "'" + txt_teleAllowance.Text + "','" + txt_entertainment.Text + "','" + txt_totTravCost.Text + "','" + strUsername + "','" + DateTime.Now + "')";
                        objCmd.ExecuteNonQuery();

                        //Save Project Advertising
                        objCmd.CommandText = "INSERT INTO ProjectAdvertisingCost(projID,water,banners,handBills,radioTV,holdings,pressAd,mobile,totAdCost," +
                            "addedUser,addedDate) " +
                            "VALUES('" + pId + "','" + txt_water.Text + "','" + txt_banners.Text + "','" + txt_handbills.Text + "','" + txt_radioTV.Text + "'," +
                            "'" + txt_holdings.Text + "','" + txt_press.Text + "','" + txt_mobileUnit.Text + "','" + txt_totAdCost.Text + "','" + strUsername + "','" + DateTime.Now + "')";
                        objCmd.ExecuteNonQuery();

                        //Save Cost Sales and Profitability

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
                else if (mode == "Edit")
                {



                    if (MessageBox.Show("Are you sure you want to Update data?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            //get Project ID
                            db = new Database();
                            pId = Convert.ToInt32(dataGridView_projectList.SelectedRows[0].Cells[0].Value);

                            //update Project Master
                            objCmd.CommandText = "UPDATE ProjectMaster SET projName='" + txt_projectName.Text + "',date='" + dateTimePicker1.Value.ToShortDateString() + "'," +
                                "changedDate='" + DateTime.Now + "',changedUser='" + strUsername + "' WHERE projID='" + pId + "'";
                            objCmd.ExecuteNonQuery();

                            //Update Project Basic Details
                            objCmd.CommandText = "UPDATE ProjectBasicDetails SET landOwner='" + txt_owner.Text + "',location='" + txt_location.Text + "'" +
                                ",brokerName='" + txt_broker.Text + "',introduction='" + txt_introduction.Text + "',totPerchs='" + txt_totalPerches.Text + "'" +
                                ",valExpectedByOwner='" + txt_valExpectedByOwner.Text + "',valAgreedByOwner='" + txt_agreedValuePP.Text + "'" +
                                ",roadways='" + txt_roadways.Text + "',commonArea='" + txt_commonArea.Text + "',reservation='" + txt_reservation.Text + "'" +
                                ",acres='" + txt_acres.Text + "',roods='" + txt_roods.Text + "',perchs='" + txt_perches.Text + "'" +
                                ",sellableArea='" + txt_sellableArea.Text + "',changedUser='" + strUsername + "',changedDate='" + DateTime.Now + "' WHERE projID='" + pId + "'";
                            objCmd.ExecuteNonQuery();

                            //Update Project Cost of Purchase
                            objCmd.CommandText = "UPDATE ProjectCostofPurchase SET titleInsurance='" + txt_titleInsurance.Text + "',stampFees'" + txt_stampFees.Text + "'" +
                                ",legalFees='" + txt_legalFees.Text + "',valuationReport='" + txt_valuationReport.Text + "',titleReports='" + txt_titleReports.Text + "'" +
                                ",commision='" + txt_commision.Text + "',totCostOfPurchase='" + txt_totCostOfPurchase.Text + "'" +
                                ",changedUser='" + strUsername + "',changedDate='" + DateTime.Now + "' WHERE projID='" + pId + "')";
                            objCmd.ExecuteNonQuery();

                            //Update Project Survey Charges
                            objCmd.CommandText = "UPDATE ProjectSurvayCharges SET parameterSurvay='" + txt_parameterSurvey.Text + "' " +
                                ",dimaBlocks='" + txt_dimaBlocks.Text + "',blockingOutPlanes='" + txt__blockingOutPlans.Text + "'" +
                                ",individualPlans='" + txt_extract.Text + "',contourSurvayPlans='" + txt_ContourSurveyingPlans.Text + "'" +
                                ",totSurvayCost='" + txt_totSurveyCost.Text + "',changedUser='" + strUsername + "',changedDate='" + DateTime.Now + "'" +
                                " WHERE projID='" + pId + "')";
                            objCmd.ExecuteNonQuery();

                            //Update Project Development Cost
                            objCmd.CommandText = "UPDATE ProjectDevCost SET clearing='" + txt_clearingOfLand.Text + "',fillingLeveling='" + txt_fillingAndLeveling.Text + "'" +
                                ",culvertsDrains='" + txt_culvertsAndDrains.Text + "',parapet='" + txt_RetainerWall.Text + "'" +
                                ",roadWays='" + txt_interiorRoadWays.Text + "',huts='" + txt_Huts.Text + "',incidentalCost='" + txt_incidentalCost.Text + "'" +
                                ",fencing='" + txt_fencing.Text + "',watcherProjOfficer='" + txt_projectOfficer.Text + "'" +
                                ",boundryStones='" + txt_boungryStones.Text + "',pradeshiyaSabha='" + txt_pradeshiyaSabha.Text + "'" +
                                ",maintenance='" + txt_maintenance.Text + "',donation='" + txt_donation.Text + "',contingencies='" + txt_contingencies.Text + "'" +
                                ",totDevCost='" + txt_totDevCost.Text + "',changedUser='" + strUsername + "',changedDAte='" + DateTime.Now + "' " +
                                "WHERE projID='" + pId + "')";
                            objCmd.ExecuteNonQuery();

                            //Update Project Utilities
                            objCmd.CommandText = "UPDATE ProjectUtilCost SET water='" + txt_providingWater.Text + "',elec='" + txt_providingElectricity.Text + "'" +
                                ",totUtilCost='" + txt_totUtilityCost.Text + "',changedUser='" + strUsername + "',changedDAte='" + DateTime.Now + "' " +
                                "WHERE projID='" + pId + "')";
                            objCmd.ExecuteNonQuery();

                            //Update Project Traveling
                            objCmd.CommandText = "Update ProjectTravellingCost SET execDirectors='" + txt_execDirectors.Text + "',dgm='" + txt_DGM.Text + "'" +
                                ",manager='" + txt_managerProject.Text + "',officer='" + txt_projOfficer.Text + "',telephone='" + txt_teleAllowance.Text + "'" +
                                ",entertainment='" + txt_entertainment.Text + "',totTravellingCost='" + txt_totTravCost.Text + "'," +
                                ",changedUser='" + strUsername + "',changedDAte='" + DateTime.Now + "' " +
                                "WHERE projID='" + pId + "')";
                            objCmd.ExecuteNonQuery();

                            //Update Project Advertising
                            objCmd.CommandText = "Update ProjectAdvertisingCost SET water='" + txt_water.Text + "',banners='" + txt_banners.Text + "'" +
                                ",handBills='" + txt_handbills.Text + "',radioTV='" + txt_radioTV.Text + "',holdings='" + txt_holdings.Text + "'" +
                                ",pressAd='" + txt_press.Text + "',mobile='" + txt_mobileUnit.Text + "',totAdCost='" + txt_totAdCost.Text + "'," +
                                ",changedUser='" + strUsername + "',changedDAte='" + DateTime.Now + "' " +
                                "WHERE projID='" + pId + "')";
                            objCmd.ExecuteNonQuery();

                            //Update Cost Sales and Profitability

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

        public void loadData()
        {
            db = new Database();
            strsql = "SELECT projID as 'ID',projName as 'Project Name' FROM ProjectMaster WHERE isDeleted=0";
            dataGridView_projectList.DataSource = db.select(strsql);
            dataGridView_projectList.Enabled = true;
        }
        public void loadData(string searchString)
        {
            db = new Database();
            strsql = "SELECT projID as 'ID',projName as 'Project Name' FROM ProjectMaster where projName LIKE '%" + searchString + "%'";
            dataGridView_projectList.DataSource = db.select(strsql);
        }

        public void ButtonNew()
        {
            mode = "New";
            btnStat.ControlSideToolStrip(this.ParentForm, false, false, true, false, false, true);
            dataGridView_projectList.Enabled = false;
            clearData();
            enableEditing(true);
            txt_projectName.Focus();
        }

        private void dataGridView_projectList_MouseClick(object sender, MouseEventArgs e)
        {
            db = new Database();
            dt = new DataTable();

            btnStat.ControlSideToolStrip(this.ParentForm, true, true, false, false, true, false);

            pId = Convert.ToInt32(dataGridView_projectList.SelectedRows[0].Cells[0].Value);

            strsql = "SELECT projName FROM ProjectMaster WHERE projID='" + pId + "'";
            txt_projectName.Text = db.getValue(strsql);

            //Fill Basic Details Tab
            strsql = "SELECT * FROM ProjectBasicDetails WHERE projID='" + pId + "'";
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
            txt_totalPerches.Text = "0.00";
            txt_valExpectedByOwner.Text = "0.00";
            txt_agreedValuePP.Text = "0.00";
            txt_roadways.Text = "0.00";
            txt_commonArea.Text = "0.00";
            txt_reservation.Text = "0.00";
            txt_sellableArea.Text = "0.00";
            txt_acres.Text = "0";
            txt_roods.Text = "0";
            txt_perches.Text = "0.00";
            txt_titleInsurance.Text = "0.00";
            txt_stampFees.Text = "0.00";
            txt_legalFees.Text = "0.00";
            txt_valuationReport.Text = "0.00";
            txt_titleReports.Text = "0.00";
            txt_commision.Text = "0.00";
            txt_totCostOfPurchase.Text = "0.00";
            txt_parameterSurvey.Text = "0.00";
            txt_dimaBlocks.Text = "0.00";
            txt__blockingOutPlans.Text = "0.00";
            txt_extract.Text = "0.00";
            txt_ContourSurveyingPlans.Text = "0.00";
            txt_totSurveyCost.Text = "0.00";
            txt_clearingOfLand.Text = "0.00";
            txt_fillingAndLeveling.Text = "0.00";
            txt_culvertsAndDrains.Text = "0.00";
            txt_RetainerWall.Text = "0.00";
            txt_interiorRoadWays.Text = "0.00";
            txt_Huts.Text = "0.00";
            txt_incidentalCost.Text = "0.00";
            txt_fencing.Text = "0.00";
            txt_projectOfficer.Text = "0.00";
            txt_boungryStones.Text = "0.00";
            txt_pradeshiyaSabha.Text = "0.00";
            txt_maintenance.Text = "0.00";
            txt_donation.Text = "0.00";
            txt_contingencies.Text = "0.00";
            txt_totDevCost.Text = "0.00";
            txt_providingWater.Text = "0.00";
            txt_providingElectricity.Text = "0.00";
            txt_totUtilityCost.Text = "0.00";
            txt_execDirectors.Text = "0.00";
            txt_DGM.Text = "0.00";
            txt_managerProject.Text = "0.00";
            txt_projOfficer.Text = "0.00";
            txt_teleAllowance.Text = "0.00";
            txt_entertainment.Text = "0.00";
            txt_totTravCost.Text = "0.00";
            txt_water.Text = "0.00";
            txt_banners.Text = "0.00";
            txt_handbills.Text = "0.00";
            txt_radioTV.Text = "0.00";
            txt_holdings.Text = "0.00";
            txt_press.Text = "0.00";
            txt_mobileUnit.Text = "0.00";
            txt_totAdCost.Text = "0.00";
            /*sm missing*/
        }

        public void enableEditing(bool value)
        {
            txt_projectName.Enabled = value;
            txt_owner.Enabled = value;
            txt_location.Enabled = value;
            txt_broker.Enabled = value;
            dateTimePicker1.Enabled = value;
            txt_introduction.Enabled = value;
            txt_totalPerches.Enabled = value;
            txt_valExpectedByOwner.Enabled = value;
            txt_agreedValuePP.Enabled = value;
            txt_roadways.Enabled = value;
            txt_commonArea.Enabled = value;
            txt_reservation.Enabled = value;
            txt_sellableArea.Enabled = value;
            txt_acres.Enabled = value;
            txt_roods.Enabled = value;
            txt_perches.Enabled = value;
            txt_titleInsurance.Enabled = value;
            txt_stampFees.Enabled = value;
            txt_legalFees.Enabled = value;
            txt_valuationReport.Enabled = value;
            txt_titleReports.Enabled = value;
            txt_commision.Enabled = value;
            txt_totCostOfPurchase.Enabled = value;
            txt_parameterSurvey.Enabled = value;
            txt_dimaBlocks.Enabled = value;
            txt__blockingOutPlans.Enabled = value;
            txt_extract.Enabled = value;
            txt_ContourSurveyingPlans.Enabled = value;
            txt_totSurveyCost.Enabled = value;
            txt_clearingOfLand.Enabled = value;
            txt_fillingAndLeveling.Enabled = value;
            txt_culvertsAndDrains.Enabled = value;
            txt_RetainerWall.Enabled = value;
            txt_interiorRoadWays.Enabled = value;
            txt_Huts.Enabled = value;
            txt_incidentalCost.Enabled = value;
            txt_fencing.Enabled = value;
            txt_projectOfficer.Enabled = value;
            txt_boungryStones.Enabled = value;
            txt_pradeshiyaSabha.Enabled = value;
            txt_maintenance.Enabled = value;
            txt_donation.Enabled = value;
            txt_contingencies.Enabled = value;
            txt_totDevCost.Enabled = value;
            txt_providingWater.Enabled = value;
            txt_providingElectricity.Enabled = value;
            txt_totUtilityCost.Enabled = value;
            txt_execDirectors.Enabled = value;
            txt_DGM.Enabled = value;
            txt_managerProject.Enabled = value;
            txt_projOfficer.Enabled = value;
            txt_teleAllowance.Enabled = value;
            txt_entertainment.Enabled = value;
            txt_totTravCost.Enabled = value;
            txt_water.Enabled = value;
            txt_banners.Enabled = value;
            txt_handbills.Enabled = value;
            txt_radioTV.Enabled = value;
            txt_holdings.Enabled = value;
            txt_press.Enabled = value;
            txt_mobileUnit.Enabled = value;
            txt_totAdCost.Enabled = value;
            /*s missing*/
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

        private void frm_Project_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            loadData(txt_search.Text);
        }

        public void ButtonEdit()
        {
            mode = "Edit";
            enableEditing(true);
            btnStat.ControlSideToolStrip(this.ParentForm, false, false, true, false, false, true);
        }

        private void dataGridView_projectList_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Fuck down");
        }

        private void dataGridView_projectList_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Fuck up");
        }
    }
}
