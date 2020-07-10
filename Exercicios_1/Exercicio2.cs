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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            double valorProduto = Convert.ToDouble(txtValorProduto.Text);


            if (cbStatus.Checked && valorProduto > 500)
            {
                valorProduto = valorProduto * 0.90;

            }

            MessageBox.Show($"O produto {txtNomeProduto.Text} irá custar {valorProduto} dinheiros");
        }
    }
}
