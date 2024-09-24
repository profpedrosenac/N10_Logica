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
    public partial class frmJuros : Form
    {
        public frmJuros()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            float total = float.Parse(txtTotal.Text.Replace("R$ ","").Replace(".",""));
            float qtde = float.Parse(txtQtde.Text);
            float parcelas;

            parcelas = total / qtde;

            txtParcelas.Text = parcelas.ToString("C");

        }

        private void frmJuros_Load(object sender, EventArgs e)
        {
            txtTotal.Text = MDIPrincipal.valorTotalCompra.ToString("C");
        }
    }
}
