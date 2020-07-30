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
    public partial class Ex2_LacoRepeticao : Form
    {
        public Ex2_LacoRepeticao()
        {
            InitializeComponent();
        }

        //não esta tratando caso usuario entre com valores negativos nem com letras.
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double valorDeEntrada = Convert.ToDouble(txtEntradaValor.Text);
            int valor = 1;

            for (double i = valorDeEntrada; i >= 1; i--)
            {                
                //1 nao e divisivel por 3 nem por 7
                if (valor % 3 == 0 && valor % 7 == 0)
                {
                    dataGridValores.Rows.Add(valor, $"é divisivel 3 e por 7");
                }
                else if (valor % 3 == 0)
                {
                    dataGridValores.Rows.Add(valor, $"é divisivel por 3");
                }
                else if (valor % 7 == 0)
                {
                    dataGridValores.Rows.Add(valor, $"é divisivel por 7");                }
                else
                {
                  dataGridValores.Rows.Add(valor, $"não é divisivel por 3 nem por 7");
                }
                valor++;
            }

        }
    }
}
