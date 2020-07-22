using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class TelaInicial : Form
    {
        string[] palavra = new string[4];
        string[] dica = new string[4];
        string palavraReserva;
        char[] palavraEscondidaVetor;
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

        public string EsconderPalavra(string palavra)
        {
            string palavraEscondida = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                palavraEscondida = palavraEscondida + "*";
            }
            return palavraEscondida;
        }

        public void IniciarJogo(string dica, string palavra)
        {
            lbDica.Text = $"Com {palavra.Length} letras a dica é : {dica} ";
            palavraEscondidaVetor = EsconderPalavra(palavra).ToCharArray();
            txtPalavra.Text = EsconderPalavra(palavra);
            panelJogo.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //criando um randomizador.
            Random randomizar = new Random();
            //randomizando os valores para escolher uma palavra utilizando o metodo NEXT
            int escolha = randomizar.Next(0, 4);
            //aplicando a palavra e a dica randomizada de acordo com o numero que ficou armazenado na variavel {escolha}.
            palavraReserva = palavra[escolha];
            //aplicando as palavras nos campos.
            IniciarJogo(dica[escolha], palavraReserva);
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            bool checkSpacePalavra = txtPalavraEscrita.Text.Contains(" ");
            bool checkPalavra = String.IsNullOrWhiteSpace(txtPalavraEscrita.Text);
            bool checkDica = String.IsNullOrWhiteSpace(txtDicaEscrita.Text);
            if (!checkPalavra && !checkDica && !checkSpacePalavra)
            {
                palavraReserva = txtPalavraEscrita.Text.ToLower().Trim();
                IniciarJogo(txtDicaEscrita.Text, palavraReserva);
            }
            else
            {
                //generic error
                MessageBox.Show("A palavra não pode conter espaços, e a dica não pode ser vazia");
            }
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
                if (!matchLetra)
                {
                    numeroTentativas--;
                    lbFotos.ImageIndex = numeroTentativas;
                }
                txtPalavra.Text = palavraAuxiliar;

                //TESTE WIN/LOSS
                if (palavraReserva == txtPalavra.Text && numeroTentativas < 5)
                {
                    MessageBox.Show("Bom, voce salvou ele, QUER DIZER o que restou dele..", "Desligar");
                    TelaInicial NovoJogo = new TelaInicial();
                    NovoJogo.Show();
                    this.Dispose(false);
                }
                else if (palavraReserva == txtPalavra.Text)
                {
                    MessageBox.Show("WOWWWW VOCE SALVOU ELE MESMO !", "Desligar");
                    TelaInicial NovoJogo = new TelaInicial();
                    NovoJogo.Show();
                    this.Dispose(false);
                }
                else if (numeroTentativas <= 0)
                {
                    MessageBox.Show("AWWW VOCE PERDEU", "Desligar", MessageBoxButtons.OK);
                    TelaInicial NovoJogo = new TelaInicial();
                    NovoJogo.Show();
                    this.Dispose(false);
                }
            }
            txtLetra.Focus();
        }

    }
}

