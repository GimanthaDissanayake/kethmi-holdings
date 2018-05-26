using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;
using System.IO;

namespace Kethmi_Holdings
{
    public partial class frm_ReportViewer : Form
    {
        String rptName = "";
        string selectionFormula = "";
        bool land;
        bool cost;
        bool dev;
        bool travel;
        bool survay;
        bool util;
        bool adv;
        bool isLetterHead;
        public frm_ReportViewer()
        {
            InitializeComponent();
        }
        public frm_ReportViewer(String type, string formula)
        {
            this.rptName = type;
            this.selectionFormula = formula;
            InitializeComponent();
        }
        public frm_ReportViewer(String type, string formula,bool isLetterHead)
        {
            this.rptName = type;
            this.selectionFormula = formula;
            this.isLetterHead = isLetterHead;
            InitializeComponent();
        }
        public frm_ReportViewer(String type, string formula,bool land, bool cost, bool dev, bool travel, bool survey, bool util, bool adv,bool isLetterHead)
        {
            this.rptName = type;
            this.selectionFormula = formula;
            this.land = land;
            this.cost = cost;
            this.dev = dev;
            this.travel = travel;
            this.survay = survey;
            this.util = util;
            this.adv = adv;
            this.isLetterHead = isLetterHead;
            InitializeComponent();
        }
        private void frm_ReportViewer_Load(object sender, EventArgs e)
        {
            string strServer = ConfigurationManager.AppSettings["Server"].ToString();

           ConnectionInfo crConnection = new ConnectionInfo();
           crConnection.UserID = "smgsystems";
            crConnection.ServerName = strServer;
            crConnection.DatabaseName = "KethmiHoldings";
            crConnection.Password = "smgsoft";

            ReportDocument myRpt = new ReportDocument();

            if (rptName == "ProjectDetails")
            {
                myRpt.Load(Application.StartupPath + "\\Reports\\ProjectDetails.rpt");
                myRpt.SetParameterValue("landDetails", true);
                myRpt.SetParameterValue("costDetails", true);
                myRpt.SetParameterValue("devDetails", true);
                myRpt.SetParameterValue("travelDetails", true);
                myRpt.SetParameterValue("survay", true);
                myRpt.SetParameterValue("utilities", true);
                myRpt.SetParameterValue("advertising", true);
                myRpt.SetParameterValue("letterHead", isLetterHead);
            }
            else if (rptName == "ProjectSummary")
            {
                myRpt.Load(Application.StartupPath + "\\Reports\\ProjectDetails.rpt");
                myRpt.SetParameterValue("landDetails", land);
                myRpt.SetParameterValue("costDetails", cost);
                myRpt.SetParameterValue("devDetails", dev);
                myRpt.SetParameterValue("travelDetails", travel);
                myRpt.SetParameterValue("survay", survay);
                myRpt.SetParameterValue("utilities", util);
                myRpt.SetParameterValue("advertising", adv);
                myRpt.SetParameterValue("letterHead", isLetterHead);
            }
            else if (rptName == "CustomerDetails")
            {
                myRpt.Load(Application.StartupPath + "\\Reports\\Customers.rpt");
            }
            else if (rptName == "Reciept")
            {
                myRpt.Load(Application.StartupPath + "\\Reports\\Reciept.rpt");
            }


            AssignConnectionInfo(myRpt, crConnection);
            myRpt.SetDatabaseLogon(crConnection.UserID, crConnection.Password, strServer, crConnection.DatabaseName);
            crystalReportViewer1.ReportSource = myRpt;
            if (selectionFormula!="")
            {
                crystalReportViewer1.SelectionFormula = selectionFormula;
            }
            
       
          //  crystalReportViewer1.Refresh();
            crystalReportViewer1.Show();
        }
        private void AssignConnectionInfo(ReportDocument document, ConnectionInfo crConnection)
        {
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in document.Database.Tables)
            {
                TableLogOnInfo logOnInfo = table.LogOnInfo;
                if (logOnInfo != null)
                {
                    table.ApplyLogOnInfo(table.LogOnInfo);
                    table.LogOnInfo.TableName = table.Name;
                    table.LogOnInfo.ConnectionInfo.UserID = crConnection.UserID;
                    table.LogOnInfo.ConnectionInfo.Password = crConnection.Password;
                    table.LogOnInfo.ConnectionInfo.DatabaseName = crConnection.DatabaseName;
                    table.LogOnInfo.ConnectionInfo.ServerName = crConnection.ServerName;
                }
            }
        }
    }
}
