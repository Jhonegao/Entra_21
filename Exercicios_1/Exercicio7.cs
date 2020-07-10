using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Exercicio7 : Form
    {
        public Exercicio7()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int valorEntrada = Convert.ToInt32(txtValor.Text);
            if (valorEntrada % 2 == 0 && valorEntrada > 0)
            {
                MessageBox.Show($"O numero {valorEntrada} é positivo e par.");
            }
            else if (valorEntrada % 2 == 0 && valorEntrada < 0)
            {
                MessageBox.Show($"O numero {valorEntrada} é negativo e par.");

            }
            else if (valorEntrada < 0 )
            {
                MessageBox.Show($"O numero {valorEntrada} é negativo e impar.");

            }
            else
            {
                MessageBox.Show($"O numero {valorEntrada} é positivo e impar.");

            }


        }
    }
}
