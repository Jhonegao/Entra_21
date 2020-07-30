using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaEAD
{
    //criar cronometro, painel de logos
    public partial class PlacarBasqueteForm : Form
    {
        //Permitir que o usuario selecione os LOGOS dos times.
        public PlacarBasqueteForm()
        {
            InitializeComponent();
        }
        //Criar variavel para armazenar o valor dos placares.
        int placarTimeA = 0;
        int placarTimeB = 0;
        //Criando um método(funcao) para atulizar os placares.
        private void atualizarPlacares()
        {
            lbTimeA.Text = placarTimeA.ToString();
            lbTimeB.Text = placarTimeB.ToString();
        }
        //adicionar o valor de acordo com cada botão.
        private void btn_1_TimeA_Click(object sender, EventArgs e)
        {
            placarTimeA++;
            atualizarPlacares();
        }
        private void btn_2_TimeA_Click(object sender, EventArgs e)
        {
            placarTimeA += 2;
            atualizarPlacares();
        }
        private void btn_3_TimeA_Click(object sender, EventArgs e)
        {
            placarTimeA += 3;
            atualizarPlacares();
        }
        private void btn_DrementTimeA_Click(object sender, EventArgs e)
        {
            placarTimeA--;
            atualizarPlacares();
        }

        private void btn_1_TimeB_Click(object sender, EventArgs e)
        {
            placarTimeB++;
            atualizarPlacares();
        }

        private void btn_2_TimeB_Click(object sender, EventArgs e)
        {
            placarTimeB += 2;
            atualizarPlacares();
        }

        private void btn_3_TimeB_Click(object sender, EventArgs e)
        {
            placarTimeB += 3;
            atualizarPlacares();
        }

        private void btn_DrementTimeB_Click(object sender, EventArgs e)
        {
            placarTimeB--;
            atualizarPlacares();
        }
    }
}
