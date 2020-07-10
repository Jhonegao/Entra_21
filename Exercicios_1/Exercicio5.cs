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
    public partial class Exercicio5 : Form
    {
        public Exercicio5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorVeiculo = Convert.ToDouble(txtValorVeiculo.Text);
            double valorVeiculoReal = valorVeiculo;
            double imposto;
            double distribuidor;

            if (valorVeiculo < 12000)
            {
                valorVeiculo = valorVeiculo * 1.05;
                imposto = valorVeiculo - valorVeiculoReal;
                MessageBox.Show($"O valor do veiculo sem impostos e distribuidor é {valorVeiculoReal}");
                MessageBox.Show($"o Valor arrecadado com imposto é {imposto} e com distribuidor é ISENTO");    
                MessageBox.Show($"O valor do veiculo ficou {valorVeiculo}");
            }
            else if (valorVeiculo < 25000)
            {
                valorVeiculo = valorVeiculo * 1.15;
                imposto = valorVeiculo - valorVeiculoReal;
                distribuidor = (valorVeiculoReal * 1.10) - valorVeiculoReal;
                MessageBox.Show($"O valor do veiculo sem impostos e distribuidor é {valorVeiculoReal}");
                MessageBox.Show($"o Valor arrecadado com imposto é {imposto} e com distribuidor é {distribuidor}");
                MessageBox.Show($"O valor do veiculo ficou {valorVeiculo+distribuidor}");
            }
            else
            {
                valorVeiculo = valorVeiculo * 1.20;
                imposto = valorVeiculo - valorVeiculoReal;
                distribuidor = (valorVeiculoReal * 1.15) - valorVeiculoReal;
                MessageBox.Show($"O valor do veiculo sem impostos e distribuidor é {valorVeiculoReal}");
                MessageBox.Show($"o Valor arrecadado com imposto é {imposto} e com distribuidor é {distribuidor}");
                MessageBox.Show($"O valor do veiculo ficou {valorVeiculo + distribuidor}");

            }

        }
    }
}
