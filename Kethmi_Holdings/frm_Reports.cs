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
    public partial class frm_Reports : Form
    {
        public frm_Reports()
        {
            InitializeComponent();
        }

        private void frm_Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            ButtonsStates btnStat = new ButtonsStates();
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }
    }
}
