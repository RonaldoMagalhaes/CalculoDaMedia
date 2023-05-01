using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDaMedia
{
    public partial class FrmCalcMedia : Form
    {
        
        public FrmCalcMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ClassCalculo valores = new ClassCalculo();
            double a = new double();
            double b = new double();
            double c = new double();
            double d = new double();
            double valor = new double();

            try
            {

                string v1 = txtN1.Text;
                v1 = v1.Replace('.', ',');
                a = double.Parse(v1);

                string v2 = txtN2.Text;
                v2 = v2.Replace('.', ',');
                b = double.Parse(v2);

                string v3 = txtN3.Text;
                v3 = v3.Replace('.', ',');
                c = double.Parse(v3);

                string v4 = txtN4.Text;
                v4 = v4.Replace('.', ',');
                d = double.Parse(v4);

                if(a<0 || a > 10 || b<0 || b > 10 || c<0 || c>10 || d<0 || d > 10)
                {
                    MessageBox.Show("Entrada de notas inválidas\nDigite as notas novamente", "*********** NOTAS INVÁLIDAS *********** ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        Limpar();
                }
                else
                {
                    valor = valores.Processar(a, b, c, d);
                    lblMedia.Text = "A média das notas : " + valor.ToString();
                }


            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message + "\nTente novamente", "######## ERRO ##########", MessageBoxButtons.OK,MessageBoxIcon.Error);
                Limpar();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            lblMedia.Text = "";
            txtN1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ClassSair sair = new ClassSair();
            sair.fim();
        }

        public void Limpar()
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();

            lblMedia.Text = "";
        }

        private void txtN1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtN2.Focus();
            }
        }

        private void txtN2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtN3.Focus();
            }
        }

        private void txtN3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtN4.Focus();
            }
        }

        private void txtN4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.Focus();
            }
        }

        private void btnCalcular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLimpar.Focus();
            }
        }

        private void btnLimpar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSair.Focus();
            }
        }
    }
}
