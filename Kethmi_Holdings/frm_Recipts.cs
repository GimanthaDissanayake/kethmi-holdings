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
    public partial class frm_Recipts : Form
    {
        public frm_Recipts()
        {
            InitializeComponent();
        }

        public bool inputAreaEnabled {set { gb_inputArea.Enabled = value; } }
        public bool searchEnabled { set { gb_search.Enabled = value; } }


        ButtonsStates lastButtonStates;
        private void frm_Recipts_Activated(object sender, EventArgs e)
        {
            lastButtonStates.restore();
        }

        private void frm_Recipts_Deactivate(object sender, EventArgs e)
        {
            lastButtonStates.save();
        }

        private void frm_Recipts_Load(object sender, EventArgs e)
        {
            lastButtonStates = new ButtonsStates();
        }
    }
}
