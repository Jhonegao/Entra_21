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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            double valor1 = Convert.ToDouble(txtEntrada1.Text);
            double valor2 = Convert.ToDouble(txtEntrada2.Text);

            if (valor1 == valor2)
            {
                MessageBox.Show($"Os valores {valor1} e {valor2} somados são : {valor2+valor1}");
            }
            else
            {
                MessageBox.Show($"Os valores {valor1} e {valor2} multiplicados são : {valor2*valor1}");
            }

        }
    }
}
