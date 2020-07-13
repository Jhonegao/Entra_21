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
    public partial class Exercicio8 : Form
    {
        public Exercicio8()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            double lado1 = Convert.ToDouble(txtLado1.Text);
            double lado2 = Convert.ToDouble(txtLado2.Text);
            double lado3 = Convert.ToDouble(txtLado3.Text);

            if (lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2)
            {
                MessageBox.Show("Não é um triangulo váldio");
            }
            else if (lado1 == lado2 && lado2 == lado3)
            {
                MessageBox.Show("Triangulo Equilátero - todos lados iguais");
            }
            else if (lado1 == lado2 || lado1 ==lado3 || lado2 == lado3)
            {
                MessageBox.Show("Triangulo Isósceles - dois lados iguais");
            }
            else
            {
                MessageBox.Show("Triangulo Escaleno - todos lados diferentes");
            }
        }
    }
}
