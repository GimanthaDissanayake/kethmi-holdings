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
            frmProject.MdiParent = this;
            frmProject.Show();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            frmProject = new frm_Project();
            frmProject.MdiParent = this;
            frmProject.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales = new frm_Sales();
            frmSales.MdiParent = this;
            frmSales.Show();
        }

        private void btnAdvertising_Click(object sender, EventArgs e)
        {
            frmAdvertising = new frm_Advertising();
            frmAdvertising.MdiParent = this;
            frmAdvertising.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports = new frm_Reports();
            frmReports.MdiParent = this;
            frmReports.Show();
        }

        private void btnReciepts_Click(object sender, EventArgs e)
        {
            frmRecipts = new frm_Recipts();
            frmRecipts.MdiParent = this;
            frmRecipts.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers = new frm_Customers();
            frmCustomers.MdiParent = this;
            frmCustomers.Show();
        }
    }
}
