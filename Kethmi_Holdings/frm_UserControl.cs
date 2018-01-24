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
    public partial class frm_UserControl : Form
    {
        public frm_UserControl()
        {
            InitializeComponent();
        }

        public bool gb_CurrentUsersEnabled {set { gb_currentUsers.Enabled = value; }}
        public bool gb_InputAreaEnabled { set { gb_inputArea.Enabled = value; } }

        private void frm_UserControl_Activated(object sender, EventArgs e)
        {
            lastButtonStates.restore();
        }

        private void frm_UserControl_Deactivate(object sender, EventArgs e)
        {
            lastButtonStates.save();
        }

        ButtonsStates lastButtonStates;
        private void frm_UserControl_Load(object sender, EventArgs e)
        {
            lastButtonStates = new ButtonsStates();
        }
    }
}
