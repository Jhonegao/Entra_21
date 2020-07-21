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
        string[] palavra = new string[5];
        string[] dica = new string[5];
        string dicaDaPalavra;
        string palavraReserva;
        char[] palavraEscondidaVetor;
        //string palavraEscondida;
        int numeroTentativas = 5;
        public TelaInicial()
        {
            palavra[0] = "holanda";
            palavra[1] = "batata";
            palavra[2] = "china";
            palavra[3] = "donald";
            dica[0] = "É um pais da Europa";
            dica[1] = "Pão de ...";
            dica[2] = "Coronga";
            dica[3] = "Existe o presidente, mas tambem o pato.";
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

        public string EsconderPalavra(string palavra)
        {
            string palavraEscondida = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                palavraEscondida = palavraEscondida + "*";
            }

            return palavraEscondida;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //criando um randomizador.
            Random randomizar = new Random();
            //randomizando os valores para escolher uma palavra utilizando o metodo NEXT
            int escolha = randomizar.Next(0, 3);
            //aplicando a palavra e a dica randomizada de acordo com o numero que ficou armazenado na variavel {escolha}.
            palavraReserva = palavra[escolha];
            dicaDaPalavra = dica[escolha];
            //aplicando as palavras nos campos.
            lbDica.Text = $"Com {palavraReserva.Length} letras a dica é : {dicaDaPalavra} ";
            palavraEscondidaVetor = EsconderPalavra(palavraReserva).ToCharArray();
            txtPalavra.Text = EsconderPalavra(palavraReserva);
            //lbNumeroTentativas.Text = $"{numeroTentativas}";
            panelJogo.Visible = true;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtLetra.Text == "")
            {
                MessageBox.Show("Insira uma letra");
            }
            else
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
                        TelaInicial NovoJogo = new TelaInicial();
                        NovoJogo.Show();
                        this.Dispose(false);                        
                        //PanelReset();
                    }
                }
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            bool checkSpacePalavra = txtPalavraEscrita.Text.Contains(" ");
            bool checkPalavra = String.IsNullOrWhiteSpace(txtPalavraEscrita.Text);
            bool checkDica = String.IsNullOrWhiteSpace(txtDicaEscrita.Text);
            if (!checkPalavra && !checkDica && !checkSpacePalavra)
            {
                palavraReserva = txtPalavraEscrita.Text.ToLower();
            }
            else
            {
                //generic error
                MessageBox.Show("A palavra não pode conter espaços, e a dica não pode ser vazia");               
            }
        }
    }
}
