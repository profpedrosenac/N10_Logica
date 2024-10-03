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
    public partial class frmRelacionamento : Form
    {
        public frmRelacionamento()
        {
            InitializeComponent();
        }
        string conexao = "Server=localhost;Database=N10_Ferragens;User Id=sa;Password=123456;";

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Não foi possivel acessar o Banco de Dados");
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }
        }

        private void CarregarComboUsuario()
        {
            string sql = "select id_usuario, nome_usuario from usuario";

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;

            DataTable dt = new DataTable();

            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();

                dt.Load(leitura);

                cboIDUsuario.DisplayMember = "id_usuario";
                cboIDUsuario.DataSource = dt;

                cboNomeUsuario.DisplayMember = "nome_usuario";
                cboNomeUsuario.DataSource = dt;
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

        private void frmRelacionamento_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarComboUsuario();
        }
    }
}
