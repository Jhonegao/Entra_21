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
    public partial class Exercicio6 : Form
    {
        public Exercicio6()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {


            List<double> valores = new List<double> { };

            valores.Add(Convert.ToDouble(txtValor1.Text));
            valores.Add(Convert.ToDouble(txtValor2.Text));
            valores.Add(Convert.ToDouble(txtValor3.Text));
            valores.Sort();

            string valoresString = "";
          
            foreach (double item in valores)
            {
                valoresString = valoresString + item+",";
            }

            MessageBox.Show($"Valores ordenados: {valoresString}");
        }
    }
}
