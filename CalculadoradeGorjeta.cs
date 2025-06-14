using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
   
    
        public partial class frmCalculadoraGorjeta : Form
        {
            public frmCalculadoraGorjeta()
            {
                InitializeComponent();
            }

            private void btnCalcular_Click(object sender, EventArgs e)
            {
                double conta = 0, gorjeta = 0, total = 0;

                if (!double.TryParse(txtValorConta.Text, out conta))
                {
                    MessageBox.Show("Digite um valor válido para a conta.");
                    return;
                }

                //verifica a qualidade do serviço
                if (cbbQualidade.SelectedIndex == 0)
                {
                    gorjeta = conta * 10 / 100;
                    total = conta + gorjeta;
                }
                if (cbbQualidade.SelectedIndex == 1)
                {
                    gorjeta = conta * 8 / 100;
                    total = conta + gorjeta;
                }
                if (cbbQualidade.SelectedIndex == 2)
                {
                    gorjeta = conta * 5 / 100;
                    total = conta + gorjeta;
                }
                if (cbbQualidade.SelectedIndex == 3)
                {
                    gorjeta = conta * 2 / 100;
                    total = conta + gorjeta;
                }

                txtGorjeta.Text = gorjeta.ToString();
                txtValorTotal.Text = total.ToString();
            }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            {
                txtValorConta.Clear();
                txtGorjeta.Clear();
                txtValorTotal.Clear();
                txtValorConta.Focus();
            }
        }

       
    }
}


