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
    public partial class RptCustomerDetails : Form
    {
        ButtonsStates btnStat = new ButtonsStates();
        FormControl frmCtrl = new FormControl();
        string selectionFormula = "";
        public RptCustomerDetails()
        {
            InitializeComponent();
        }

        private void RptCustomerDetails_Load(object sender, EventArgs e)
        {
            btnStat.ControlSideToolStrip(this.ParentForm, false, false, false, true, false, false);
            frmCtrl.Fill_Combo(cmbCustomer, "SELECT CusID, name from Customer union select 0,'All'", "CusID", "name");
        }

        public void ButtonPrint()
        {
            selectionFormula = "";
            if (cmbCustomer.Text!="All")
            {
                selectionFormula = "{Customer.cusID} = "+cmbCustomer.SelectedValue+"";
            }
            frm_ReportViewer frm = new frm_ReportViewer("CustomerDetails",selectionFormula);
            frm.Show();
        }

        private void RptCustomerDetails_Activated(object sender, EventArgs e)
        {
            btnStat.VisibleToolStrip((frm_Main)this.MdiParent);
            btnStat.ControlSideToolStrip(this.ParentForm, false, false, false, true, false, false);
        }

        private void RptCustomerDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }
    }
}
