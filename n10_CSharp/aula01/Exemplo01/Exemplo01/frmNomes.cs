namespace Exemplo01
{
    public partial class frmNomes : Form
    {
        public frmNomes()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu nome é: " + txtNome.Text + " " + txtSobrenome.Text);
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtNome.Focus();
        }
    }
}