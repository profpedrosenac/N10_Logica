using System.Data;
using System.Data.SqlClient;

namespace MiniProjeto
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        string conexao = "Server=localhost;Database=N10_Ferragens;User Id=sa;Password=123456;";

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void CarregarGridUsuario()
        {
            string sql = "select " +
                "id_usuario as 'ID'," +
                "nome_usuario as 'Nome'," +
                "login_usuario as 'Login' "+
                "from usuario " +
                "where nome_usuario like '%" + txtPesquisaNome.Text + "%'";

            SqlConnection conn = new SqlConnection(conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();

            try
            {
                adapter.Fill(ds);
                dataGridUsuario.DataSource = ds.Tables[0];
                dataGridUsuario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridUsuario.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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


        private void frmUsuario_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarGridUsuario();
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            // realizar a validação de dados!

            string sql = "insert into usuario " +
                "(nome_usuario,login_usuario,senha_usuario,email_usuario,obs_usuario,status_usuario)" +
                "values" +
                "('"+txtNome.Text+"','"+txtLogin.Text+"','"+txtSenha.Text+"','"+txtEmail.Text+"','"+txtObs.Text+"','"+cboStatus.Text+"')" +
                "Select scope_identity()";

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                //int i = cmd.ExecuteNonQuery();
                //if (i == 1)
                //{
                //    MessageBox.Show("Cadastro realizado com sucesso");
                //}

                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    
                    btoLimpar.PerformClick();
                    txtCodigo.Text = leitura[0].ToString();

                    MessageBox.Show("Cadastro realizado com sucesso");

                    btoPesquisar.PerformClick();
                    CarregarGridUsuario();
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

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update usuario set " +
                         "nome_usuario = '"+txtNome.Text+"'," +
                         "login_usuario = '"+txtLogin.Text+"'," +
                         "senha_usuario = '"+txtSenha.Text+"'," +
                         "email_usuario = '"+txtEmail.Text+"'," +
                         "obs_usuario = '"+txtObs.Text+"'," +
                         "status_usuario = '"+cboStatus.Text+"' " +
                         "where id_usuario = "+txtCodigo.Text;

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                    CarregarGridUsuario();
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

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from usuario where id_usuario = " + txtCodigo.Text;

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados excluidos com sucesso");
                    CarregarGridUsuario();
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

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario where id_usuario = " + txtCodigo.Text;

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
                    txtCodigo.Text = leitura[0].ToString();
                    txtNome.Text = leitura[1].ToString();
                    txtLogin.Text = leitura[2].ToString();
                    txtSenha.Text = leitura[3].ToString();
                    txtEmail.Text = leitura[4].ToString();
                    txtObs.Text = leitura[5].ToString();
                    cboStatus.Text = leitura[6].ToString();
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado");
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

        private void LimparDados(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }

                if (control.HasChildren)
                {
                    LimparDados(control);
                }
            }
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            LimparDados(this);
        }

        private void dataGridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridUsuario.CurrentRow.Cells["ID"].Value.ToString();
            btoPesquisar.PerformClick();
        }

        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            CarregarGridUsuario();
        }
    }
}