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
        string rptType = "";
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
            db = new Database();
            strsql = "SELECT projName FROM ProjectMaster WHERE isDeleted='false' UNION SELECT 'All'";
            list = new List<String>();
            list = db.getList(strsql, 0);
            foreach (String projName in list)
            {
                cmbProjectList.Items.Add(projName);
            }
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
            }
            else
            {
                rptType = "ProjectSummary";

            }
            frm_ReportViewer vwr = new frm_ReportViewer(rptType);
            vwr.Show();
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
