using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daliz
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void فیلدهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFieldManager frmFieldManager = new frmFieldManager();
            frmFieldManager.Show();
        }
    }
}
