namespace Correcao
{
    public partial class frmCorrecao : Form
    {
        public frmCorrecao()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtIdade.Text = "";
            lblResult.Text = "";
            txtNome.Focus();
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome deve ser preenchido");
                return;
            }

            if (txtSobrenome.Text == "")
            {
                MessageBox.Show("Sobrenome deve ser preenchido");
                return;
            }
            
            int idade = 0;

            if (!int.TryParse(txtIdade.Text, out idade))
            {
                MessageBox.Show("Idade deve ser numérico");
                txtIdade.Text = "";
                return;
            }

            mensagem = "Seu nome completo é " + txtNome.Text + " " +
                "" + txtSobrenome.Text + " com " +
                "" + txtIdade.Text + " anos.";

            btoLimpar.PerformClick();

            lblResult.Text = mensagem;

        }
    }
}