using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class MDIPrincipal : Form
    {
  
        public MDIPrincipal()
        {
            InitializeComponent();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadora frm = new frmCalculadora();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedia frm = new frmMedia();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
