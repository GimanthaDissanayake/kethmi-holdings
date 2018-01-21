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
    public partial class frm_Main : Form
    {
        frm_Project frmProject;
        frm_Advertising frmAdvertising;
        frm_Customers frmCustomers;
        frm_Reports frmReports;
        frm_Sales frmSales;
        frm_Recipts frmRecipts;
        public frm_Main()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login f = new frm_Login();
            f.MdiParent = this;
            f.Show();
        }



        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProject = new frm_Project();
            frmProject.FormClosed += new FormClosedEventHandler(frmProject_FormClosed);

            frmProject.MdiParent = this;
            frmProject.Show();
            projectToolStripMenuItem.Enabled = false;
            btnProjects.Enabled = false;
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            frmProject = new frm_Project();
            frmProject.FormClosed += new FormClosedEventHandler(frmProject_FormClosed);

            frmProject.MdiParent = this;
            frmProject.Show();
            btnProjects.Enabled = false;
            projectToolStripMenuItem.Enabled = false;
        }

        private void frmProject_FormClosed(object sender, EventArgs e) {
            btnProjects.Enabled = true;
            projectToolStripMenuItem.Enabled = true;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales = new frm_Sales();
            frmSales.FormClosed += new FormClosedEventHandler(frmSales_FormClosed);
            frmSales.MdiParent = this;
            frmSales.Show();
            btnSales.Enabled = false;

        }
        private void frmSales_FormClosed(object sender, EventArgs e) {
            btnSales.Enabled = true;
        }

        private void btnAdvertising_Click(object sender, EventArgs e)
        {
            frmAdvertising = new frm_Advertising();
            frmAdvertising.FormClosed += new FormClosedEventHandler(frmAdvertising_FormClosed);
            frmAdvertising.MdiParent = this;
            frmAdvertising.Show();
            btnAdvertising.Enabled = false;
        }
        private void frmAdvertising_FormClosed(object sender, EventArgs e)
        {
            btnAdvertising.Enabled = true;
        }


        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports = new frm_Reports();
            frmReports.FormClosed += new FormClosedEventHandler(frmReports_FormClosed);
            frmReports.MdiParent = this;
            frmReports.Show();
            btnReports.Enabled = false;
        }

        private void frmReports_FormClosed(object sender, EventArgs e)
        {
            btnReports.Enabled = true;
        }

        private void btnReciepts_Click(object sender, EventArgs e)
        {
            frmRecipts = new frm_Recipts();
            frmRecipts.FormClosed += new FormClosedEventHandler(frmRecipts_FormClosed);
            frmRecipts.MdiParent = this;
            frmRecipts.Show();
            btnReciepts.Enabled = false;
        }

        private void frmRecipts_FormClosed(object sender, EventArgs e)
        {
            btnReciepts.Enabled = true;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers = new frm_Customers();
            frmCustomers.FormClosed += new FormClosedEventHandler(frmCustomers_FormClosed);
            frmCustomers.MdiParent = this;
            frmCustomers.Show();
            btnCustomers.Enabled = false;
        }

        private void frmCustomers_FormClosed(object sender, EventArgs e)
        {
            btnCustomers.Enabled = true;
        }
    }
}
