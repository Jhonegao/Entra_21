using AulaEAD.Properties;
using Microsoft.SqlServer.Server;
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
        int seletorTimeA = 0;
        int seletorTimeB = 0;

        TimeSpan cronometro;        

        //Criando um método(funcao) para atulizar os placares.
        private void atualizarPlacares()
        {
            lbTimeA.Text = placarTimeA.ToString();
            lbTimeB.Text = placarTimeB.ToString();
        }
        //adicionar o valor de acordo com cada botão.
        //vetor com as logos do time (!??referenciado no resources??!)
        Image[] logos = { Resources.team1, Resources.team2, Resources.team3, Resources.team4, Resources.team5, Resources.team6, Resources.team7,
         Resources.team8, Resources.team9, Resources.team10, Resources.team11, Resources.team12, Resources.team13, Resources.team14, Resources.team15,
         Resources.team16, Resources.team17, Resources.team18, Resources.team19, Resources.team20, Resources.team21, Resources.team22, Resources.team23, Resources.team24};
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
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        //funcao para troca de ambos times
        private void trocarTime(int valor, bool condicao)
        {
            if (condicao)
            {
                pbTimeA.Image = logos[valor];
            }
            else
            {
                pbTimeB.Image = logos[valor];
            }
        }
        private void btnNextTimeA_Click(object sender, EventArgs e)
        {
            seletorTimeA++;
            if (seletorTimeA > 22)
            {
                seletorTimeA = 0;
            }
            trocarTime(seletorTimeA, true);            
        }
        private void btnPreviousTimeA_Click(object sender, EventArgs e)
        {
            seletorTimeA--;
            if (seletorTimeA < 0)
            {
                seletorTimeA = 22;
            }
            trocarTime(seletorTimeA, true);
        }
        private void btnNextTimeB_Click(object sender, EventArgs e)
        {
            seletorTimeB++;
            if (seletorTimeB > 22)
            {
                seletorTimeB = 0;
            }
            trocarTime(seletorTimeB, false);
        }
        private void btnPreviousTimeB_Click(object sender, EventArgs e)
        {
            seletorTimeB--;
            if (seletorTimeB < 0)
            {
                seletorTimeB = 22;
            }
            trocarTime(seletorTimeB, false);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            cronometro = TimeSpan.FromMinutes(12);
            tempo.Start();
        }
        //criar demais botoes, pause, desabilitar selecao de times apos start(verificar decrementacao de pontos).
        private void tempo_Tick(object sender, EventArgs e)
        {
            cronometro = cronometro.Subtract(TimeSpan.FromSeconds(1));
            lbTempo.Text = $"{cronometro.Minutes}:{cronometro.Seconds}";
        }
    }
}
