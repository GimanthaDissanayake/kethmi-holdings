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
    public partial class frm_Project : Form
    {
        public frm_Project()
        {
            InitializeComponent();
        }
        Form formArg;
        public frm_Project(Form f)
        {
            InitializeComponent();
            formArg = f;
        }

        private void frm_Project_Load(object sender, EventArgs e)
        {

        }

        private void frm_Project_FormClosing(object sender, FormClosingEventArgs e) {
            formArg = null;
            MessageBox.Show(this,"Done");
        }
    }
}
