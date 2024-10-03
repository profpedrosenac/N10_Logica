using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiniProjeto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string conexao = "Server=localhost;Database=N10_Ferragens;User Id=sa;Password=123456;";

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoEntrar_Click(object sender, EventArgs e)
        {
            //if (txtSenha.Text == "123" && txtUsuario.Text == "admin")
            //{
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Usuário ou Senha inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            //}

            string sql = "select * from usuario where " +
                "login_usuario='" + txtUsuario.Text + "'" +
                " and " +
                "senha_usuario='" + txtSenha.Text + "'";

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    MessageBox.Show("Seja bem vindo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
