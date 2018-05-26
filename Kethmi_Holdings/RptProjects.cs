using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kethmi_Holdings
{
    public partial class RptProjects : Form
    {
        Database db;
        String strsql;
        List<String> list;
        ButtonsStates btnStat = new ButtonsStates();
        FormControl frmCtrl = new FormControl();
        string rptType = "";
        string selectionFormula = "";
        bool landDetails;
        bool costOfPurchase;
        bool dev;
        bool travel;
        public RptProjects()
        {
            InitializeComponent();
        }

        private void RptProjects_Load(object sender, EventArgs e)
        {
            btnStat.ControlSideToolStrip(this.ParentForm,false, false, false, true, false, false);
            rbtDetailReport.Checked = true;
            loadProjName();
        }

        private void loadProjName()
        {
            strsql = "SELECT projID,projName FROM ProjectMaster WHERE isDeleted='false' UNION SELECT '0','All'";
            frmCtrl.Fill_Combo(cmbProjectList, strsql, "projID", "projName");                       
        }

        public void ButtonPrint()
        {
            if (cmbProjectList.SelectedIndex==-1)
            {
                MessageBox.Show("Please select a project !!", "Warning", MessageBoxButtons.OK);
                return;
            }
            if (rbtDetailReport.Checked)
            { 
                rptType = "ProjectDetails";
                if (cmbProjectList.Text!="All")
                {
                    selectionFormula = " {ProjectMaster.projID} = " + cmbProjectList.SelectedValue + "";
                }
                frm_ReportViewer vwr = new frm_ReportViewer(rptType, selectionFormula);
                vwr.Show();
            }
            else
            {
                rptType = "ProjectSummary";
                landDetails = chkLandInfo.Checked;
                costOfPurchase = chkCostOfPurchase.Checked;
                dev = chkDevelopment.Checked;
                travel = chkTravelling.Checked;

                frm_ReportViewer vwr = new frm_ReportViewer(rptType, selectionFormula,landDetails,costOfPurchase,dev,travel);
                vwr.Show();
            }
            
        }

        private void RptProjects_Activated(object sender, EventArgs e)
        {
            btnStat.VisibleToolStrip((frm_Main)this.MdiParent);
            btnStat.ControlSideToolStrip(this.ParentForm, false, false, false, true, false, false);
        }

        private void RptProjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }

        private void rbtDetailReport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDetailReport.Checked)            
                grpSelection.Enabled = false;
            else
                grpSelection.Enabled = true;
        }
    }
}
