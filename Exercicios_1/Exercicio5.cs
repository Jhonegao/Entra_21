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

        //5)O cliente irá informar o valor do veículo e em seguida deverá ser informado o valor do mesmo sem os
        //impostos e o percentual do distribuidor.Informe também quanto foi arrecado de impostos e quanto foi
        //repassado ao distribuidor.

        //Valor do veículo  % do distribuidor    % de impostos
        //Até R$ 12.000,00            Isento	     5%             								    
        //Até R$ 25.000,00 	          10%	         15%			           				
        //Acima de R$ 25.000 	      15%		     20%		

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorVeiculo = Convert.ToDouble(txtValorVeiculo.Text.Replace(".", ","));
            double valorVeiculoS;
            double distribuidor;
            double imposto;

            if (valorVeiculo <= 12000)
            {
                valorVeiculoS = valorVeiculo * 0.95;
                imposto = valorVeiculo * 0.05;
                MessageBox.Show("O imposto arrecadado foi de " + imposto);
                MessageBox.Show("Está isento do valor do distribuidor");
                MessageBox.Show("O valor do veículo sem as taxas é " + valorVeiculoS);
            }
            else if (valorVeiculo <= 25000)
            {
                valorVeiculoS = valorVeiculo * 0.85 * 0.90;
                imposto = valorVeiculo * 0.15;
                distribuidor = valorVeiculo * 0.1;
                MessageBox.Show("O imposto arrecadado foi de " + imposto);
                MessageBox.Show("Foi repassado " + distribuidor + " ao distribuidor");
                MessageBox.Show("O valor do veículo sem as taxas é " + valorVeiculoS);
            }
            else
            {
                valorVeiculoS = valorVeiculo * 0.80 * 0.85;
                imposto = valorVeiculo * 0.2;
                distribuidor = valorVeiculo * 0.15;
                MessageBox.Show("O imposto arrecadado foi de " + imposto);
                MessageBox.Show("Foi repassado " + distribuidor + " ao distribuidor");
                MessageBox.Show("O valor do veículo sem as taxas é " + valorVeiculoS);
            }
        }
    }
}
