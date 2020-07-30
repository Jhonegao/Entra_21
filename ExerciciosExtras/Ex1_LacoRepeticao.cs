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
    public partial class Ex1_LacoRepeticao : Form
    {
        public Ex1_LacoRepeticao()
        {
            InitializeComponent();
        }

        // não esta validando se a entrada de dado é uma letra, apenas verifica se é positivo ou negativo.
        private void btnFatorial_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtEntradaValor.Text) < 0)
            {
                MessageBox.Show("Não é permetido numeros negativos para fatorar");
            }
            else
            {
                int valorDeEntrada = Convert.ToInt32(txtEntradaValor.Text);
                int valorResposta = valorDeEntrada;
                valorDeEntrada--;
                for (int i = 1; i <= valorDeEntrada; valorDeEntrada--)
                {
                    valorResposta = valorResposta * valorDeEntrada;
                }
                if (valorResposta == 0)
                {
                    MessageBox.Show("Valor fatorial : 1");
                }
                else
                {
                    MessageBox.Show("Valor fatorial : " + valorResposta);
                }
            }
        }

    }
}
