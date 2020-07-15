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
    public partial class Exercicio6_naMAO : Form
    {
        public Exercicio6_naMAO()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double valor1 = 10;
            double valor2 = 9;
            double valor3 = 8;
            double auxiliar = 0;

            if (valor1 > valor2)
            {
                auxiliar = valor1;
                valor1 = valor2;
                valor2 = auxiliar;
            } 
            else if(valor1 > valor3)
            {
                auxiliar = valor1;
                valor1 = valor3;
                valor3 = auxiliar;
            }
            else if (valor2 > valor3)
            {
                auxiliar = valor2;
                valor2 = valor3;
                valor3 = auxiliar;
            }


            MessageBox.Show("Os valores em ordenados são = "+ valor1 + ", "+ valor2 +  ", " + valor3);
        }
    }
}
