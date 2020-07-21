using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class TelaInicial : Form
    {
        string[] palavra = new string[4];
        string[] dica = new string[4];
        string dicaDaPalavra;
        string palavraReserva;
        char[] palavraEscondidaVetor;
        string palavraEscondida;
        int numeroTentativas = 5;
        public TelaInicial()
        {
            palavra[0] = "holanda";
            palavra[1] = "batata";
            palavra[2] = "china";
            dica[0] = "MEME: É um pais da Europa";
            dica[1] = "MEME: Pão de ...";
            dica[2] = "Coronga";
            InitializeComponent();
            panelJogo.Visible = false;
        }
        public void PanelReset() {
            txtPalavra.Text = "";
            panelJogo.Visible = false;
            numeroTentativas = 5;
            lbFotos.ImageIndex = numeroTentativas;
            txtLetra.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //RESETANDO a string para armazenar caracteres ao invez da palavra real.
            palavraEscondida = "";
            //criando um randomizador.
            Random randomizar = new Random();
            //randomizando os valores para escolher uma palavra utilizando o metodo NEXT
            int escolha = randomizar.Next(0, 3);
            //aplicando a palavra randomizada de acordo com o numero que ficou armazenado na variavel {escolha}.
            palavraReserva = palavra[escolha];
            dicaDaPalavra = dica[escolha];
            //aplicando as palavras nos campos.
            lbDica.Text = dicaDaPalavra;

            for (int i = 0; i < palavraReserva.Length; i++)
            {
                palavraEscondida = palavraEscondida + "*";
            }
            palavraEscondidaVetor = palavraEscondida.ToCharArray();
            txtPalavra.Text = palavraEscondida;
            //lbNumeroTentativas.Text = $"{numeroTentativas}";
            panelJogo.Visible = true;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palavraAuxiliar = "";
            //criando variavel para letra que sera inserida pelo usuario
            //convertendo esta letra recebida para CHAR para poder utilizar a comparacao no FOR .Trim() para garantir que sera minusculo
            char letraInserida = Convert.ToChar(txtLetra.Text.ToLower());
            //controlador de match
            bool matchLetra = false;

            for (int i = 0; i < palavraReserva.Length; i++)
            {
                if (letraInserida == palavraReserva.ElementAt(i))
                {
                    matchLetra = true;
                    palavraEscondidaVetor[i] = letraInserida;
                    palavraAuxiliar = palavraAuxiliar + letraInserida;
                }
                else
                {
                    palavraAuxiliar = palavraAuxiliar + palavraEscondidaVetor[i];
                }
            }
            if (matchLetra) { }
            else
            {
                numeroTentativas--;
                lbFotos.ImageIndex = numeroTentativas;
            }
            txtPalavra.Text = palavraAuxiliar;

            //TESTE WIN/LOSS
            if (palavraReserva == txtPalavra.Text)
            {
                MessageBox.Show("WOOOW VOCÊ VENCEU");
            }
            else if (numeroTentativas <= 0)
            {

               var close = MessageBox.Show("AWWW VOCE PERDEU", "Desligar", MessageBoxButtons.OK);
                if (close == DialogResult.OK)
                {
                    PanelReset();
                }
                
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            bool checkPalavra = String.IsNullOrWhiteSpace(txtPalavraEscrita.Text);
            bool checkDica = String.IsNullOrWhiteSpace(txtDicaEscrita.Text);
            if (!checkPalavra && !checkDica)
            {
                palavraReserva = txtPalavraEscrita.Text.ToLower();
                MessageBox.Show("Test");

            }
        }
    }
}
