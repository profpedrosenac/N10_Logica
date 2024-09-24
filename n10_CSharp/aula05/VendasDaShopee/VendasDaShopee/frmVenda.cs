namespace VendasDaShopee
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboValor.SelectedIndex = cboProduto.SelectedIndex;
            txtTotal.Text = "R$ 0,00";
            txtQtde.Text = "0";
        }

        
        private void txtQtde_Leave(object sender, EventArgs e)
        {
            try
            {
                string bla;

                bla = cboValor.Text.Replace("R$ ", "");
                bla = bla.Replace(".", "");

                float valor = float.Parse(bla);
                float qtde = float.Parse(txtQtde.Text);

                float total = valor * qtde;

                txtTotal.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, produto e qtde devem ser preenchidos " + ex.ToString());
            }
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            string bla = txtTotal.Text.Replace("R$ ", "");
            bla = bla.Replace(".","");

            float total = float.Parse(bla);
            float totalGeral = 0;

            if (cboTipo.SelectedIndex == 0)
            {
                totalGeral = total;
            }
            else if (cboTipo.SelectedIndex == 1)
            {
                totalGeral = total * 0.9F;
            }
            else if (cboTipo.SelectedIndex == 2)
            {
                totalGeral = total * 0.95F;
            }
            else if (cboTipo.SelectedIndex == 3)
            {
                totalGeral = total * 1.25F;

                MDIPrincipal.valorTotalCompra = totalGeral;

                frmJuros frm = new frmJuros();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro, Tipo não existente");
                return;
            }

            txtTotalFinal.Text = totalGeral.ToString("C");
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            cboProduto.SelectedIndex = -1;
            txtQtde.Text = "0";
            cboTipo.SelectedIndex = -1;
            txtTotal.Text = "R$ 0,00";
            txtTotalFinal.Text = "R$ 0,00";
        }       
    }
}