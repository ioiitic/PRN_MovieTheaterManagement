using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmTheaterManagement : Form
    {
        public frmTheaterManagement()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.Closed += (s, args) => this.Close();
            this.Hide();
            frmAdmin.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();
    }
}
