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
    public partial class Form1 : Form
    {
        //inicializando vetor de strings para armezenar um numero X de palavras 
        string[] palavra = new string[3];
        string[] dica = new string[3];
        string palavraReserva;
        string dicaDaPalavra;
        char[] palavraEscondidaVetor;
        string palavraEscondida;
        int numeroTentativas = 5;

        public Form1()
        {
            InitializeComponent();

            palavra[0] = "holanda";
            palavra[1] = "batata";
            palavra[2] = "japao";
            dica[0] = "Pais da Europa";
            dica[1] = "Pão de ..";
            dica[2] = "Xingling";
            
        }
        private void button1_Click(object sender, EventArgs e)
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
            lbNumeroTentativas.Text =$"{numeroTentativas}";            
        }

            
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palavraAuxiliar = "";
            //criando variavel para letra que sera inserida pelo usuario
            char letraInserida;
            //convertendo esta letra recebida para CHAR para poder utilizar a comparacao no FOR .Trim() para garantir que sera minusculo
            letraInserida = Convert.ToChar(txtLetra.Text.ToLower());
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
            if (matchLetra){ }
            else
            {
                numeroTentativas--;
                lbNumeroTentativas.Text = $"{numeroTentativas}";
            }
            txtPalavra.Text = palavraAuxiliar;

            //TESTE WIN/LOSS
            if (palavraReserva == txtPalavra.Text)
            {
                MessageBox.Show("WOOOW VOCÊ VENCEU");
            }
            else if (numeroTentativas <= 0)
            {
                MessageBox.Show("AWWW VOCE PERDEU");
            }
            
        }
    }
}
