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
            txtTotal.Text = "0";
            txtQtde.Text = "0";
        }

        
        private void txtQtde_Leave(object sender, EventArgs e)
        {
            try
            {
                float valor = float.Parse(cboValor.Text);
                float qtde = float.Parse(txtQtde.Text);

                float total = valor * qtde;

                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, produto e qtde devem ser preenchidos " + ex.ToString());
            }
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            float total = float.Parse(txtTotal.Text);
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
            }
            else
            {
                MessageBox.Show("Erro, Tipo não existente");
                return;
            }
            txtTotalFinal.Text = totalGeral.ToString();
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
            txtTotal.Text = "0";
            txtTotalFinal.Text = "0";
        }
    }
}