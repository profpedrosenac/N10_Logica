using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendasDaShopee
{
    public partial class MDIPrincipal : Form
    {
        
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        public static float valorTotalCompra = 0;

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frm = new frmVenda();
            frm.MdiParent = this;
            frm.Show();
        }

        private void parcelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJuros frm = new frmJuros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
