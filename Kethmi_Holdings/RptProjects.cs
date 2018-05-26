using System;
using System.Windows.Forms;

namespace Kethmi_Holdings
{
    public partial class RptProjects : Form
    {
        ButtonsStates btnStat = new ButtonsStates();
        public RptProjects()
        {
            InitializeComponent();
        }

        private void RptProjects_Load(object sender, EventArgs e)
        {
            btnStat.ControlSideToolStrip(this.ParentForm,false, false, false, true, false, false);
        }

        public void ButtonPrint()
        {
            frm_ReportViewer vwr = new frm_ReportViewer("ProjectDetails");
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
    }
}
