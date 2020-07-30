using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosExtras
{
    public partial class Ex3_LacoRepeticao : Form
    {
        //não está testando se o usuario entra com uma letra, existe numero limitado para testar se é primo ou não(devido demora de processamento)
        // verificar se é possivel melhorar o desempenho de checagem
        int quantidadeNumeroDigitados = 0;
        public Ex3_LacoRepeticao()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            quantidadeNumeroDigitados ++;
            bool checkPrimo = true;
            double valorUsuario = Convert.ToDouble(txtValorEntrada.Text);
            if (valorUsuario < 0)
            {
                panel1.Dispose();
                btnVerificar.Visible = false;
            }
            else
            {
                txtValorEntrada.Visible = false;
                for (double i = 2; i <= (valorUsuario/2); i++)
                {
                    lbtest.Text = $"{i}";
                    if (valorUsuario % i == 0)
                    {
                        i = valorUsuario;
                        checkPrimo = false;
                    }
                }
                if (checkPrimo)
                {
                    lbQuantidade.Text = $"é primo";
                    panel1.Dispose();
                    btnVerificar.Visible = false;
                }
                txtValorEntrada.Visible = true;
            }
        }
    }
}
