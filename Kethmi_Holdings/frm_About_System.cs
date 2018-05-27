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
    public partial class frm_About_System : Form
    {
        public frm_About_System()
        {
            InitializeComponent();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
