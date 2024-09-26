using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjeto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "123" && txtUsuario.Text == "admin")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }
    }
}
