using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";
            lblResult.Text = "-";
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            float n1;
            float n2;
            float n3;
            float n4;
            float result;
            string status;
            lblResult.BackColor = SystemColors.ActiveCaption;
            lblResult.Text = "-";

            if (!float.TryParse(txtN1.Text, out n1))
            {
                MessageBox.Show("Erro, informe n1");
                return;
            }
            if (n1 < 0 || n1 >10)
            {
                MessageBox.Show("Erro, informe n1 entre 0 e 10");
                return;
            }
            if (!float.TryParse(txtN2.Text, out n2))
            {
                MessageBox.Show("Erro, informe n2");
                return;
            }
            if (n2 < 0 || n2 > 10)
            {
                MessageBox.Show("Erro, informe n2 entre 0 e 10");
                return;
            }
            if (!float.TryParse(txtN3.Text, out n3))
            {
                MessageBox.Show("Erro, informe n3");
                return;
            }
            if (n3 < 0 || n3 > 10)
            {
                MessageBox.Show("Erro, informe n3 entre 0 e 10");
                return;
            }
            if (!float.TryParse(txtN4.Text, out n4))
            {
                MessageBox.Show("Erro, informe n4");
                return;
            }
            if (n4 < 0 || n4 > 10)
            {
                MessageBox.Show("Erro, informe n4 entre 0 e 10");
                return;
            }

            result = (n1 + n2 + n3 + n4) / 4;

            if (result >= 7)
            {
                status = "Aprovado";
                lblResult.BackColor = Color.Blue;
            }
            else if (result < 5)
            {
                status = "Reprovado";
                lblResult.BackColor = Color.Red;
            }
            else
            {
                status = "Exame";
                lblResult.BackColor= Color.Orange;
            }

            lblResult.Text = "Média: " + result + " está " + status;
        }

        private void txtN1_Enter(object sender, EventArgs e)
        {
            txtN1.Text = "";
        }

        private void txtN2_Enter(object sender, EventArgs e)
        {
            txtN2.Text = "";
        }

        private void txtN3_Enter(object sender, EventArgs e)
        {
            txtN3.Text = "";
        }

        private void txtN4_Enter(object sender, EventArgs e)
        {
            txtN4.Text = "";
        }
    }
}
