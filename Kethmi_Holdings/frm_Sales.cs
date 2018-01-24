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
    public partial class frm_Sales : Form
    {
        public frm_Sales()
        {
            InitializeComponent();
        }
        ButtonsStates lastButtonStates;
        private void frm_Sales_Load(object sender, EventArgs e)
        {
            lastButtonStates = new ButtonsStates();
        }

        private void frm_Sales_Activated(object sender, EventArgs e)
        {
            lastButtonStates.restore();
        }

        private void frm_Sales_Deactivate(object sender, EventArgs e)
        {
            lastButtonStates.save();
        }
    }
}
