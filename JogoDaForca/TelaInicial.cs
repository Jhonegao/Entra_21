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
        string[] palavra = new string[3];
        string[] dica = new string[3];
        string dicaDaPalavra;
        string palavraReserva;
        char[] palavraEscondidaVetor;
        string palavraEscondida;
        int numeroTentativas = 5;
        public TelaInicial()
        {
            InitializeComponent();
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
            lbNumeroTentativas.Text = $"{numeroTentativas}";
        }
    }
}
