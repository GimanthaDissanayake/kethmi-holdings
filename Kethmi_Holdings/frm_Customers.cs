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
    public partial class frm_Customers : Form
    {
        ButtonsStates btnStat = new ButtonsStates();
        public frm_Customers()
        {
            InitializeComponent();
        }

        private void frm_Customers_Load(object sender, EventArgs e)
        {

        }

        private void frm_Customers_FormClosing(object sender, FormClosingEventArgs e)
        {            
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }

        private void frm_Customers_Activated(object sender, EventArgs e)
        {
            btnStat.VisibleToolStrip((frm_Main)this.MdiParent);
        }
    }
}
