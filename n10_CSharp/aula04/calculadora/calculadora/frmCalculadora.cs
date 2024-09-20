namespace calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        float n1;
        float n2;
        float result;

        private bool Verificar()
        {
            if (!float.TryParse(txtN1.Text, out n1))
            {
                MessageBox.Show("Erro, informe n1 com número");
                return false;
            }
            if (!float.TryParse(txtN2.Text, out n2))
            {
                MessageBox.Show("Erro, informe n2 com número");
                return false;
            }

            return true;
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoCE_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lblResult.Text = "0";
        }

        private void btoMais_Click(object sender, EventArgs e)
        {
            if (Verificar()==false)
            {
                return;
            }

            result = n1 + n2;

            lblResult.Text = result.ToString();
        }

        private void btoMenos_Click(object sender, EventArgs e)
        {
            if (Verificar() == false)
            {
                return;
            }

            result = n1 - n2;

            lblResult.Text = result.ToString();
        }

        private void btoMult_Click(object sender, EventArgs e)
        {
            if (Verificar() == false)
            {
                return;
            }

            result = n1 * n2;

            lblResult.Text = result.ToString();
        }

        private void btoDiv_Click(object sender, EventArgs e)
        {
            if (Verificar() == false)
            {
                return;
            }

            result = n1 / n2;

            lblResult.Text = result.ToString();
        }
    }
}