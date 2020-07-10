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
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {

            double menorValor = Convert.ToDouble(txtValor1.Text);
            if (menorValor > Convert.ToDouble(txtValor2.Text))
            {
                menorValor = Convert.ToDouble(txtValor2.Text);
            }
            if (menorValor > Convert.ToDouble(txtValor3.Text))
            {
                menorValor = Convert.ToDouble(txtValor3.Text);
            }

            MessageBox.Show($"o menor valor é {menorValor}");

        }
    }
}
