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
    public partial class VetorArrayList : Form
    {
        public VetorArrayList()
        {
            InitializeComponent();
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            //Vetor - Array

            int[] numeros = new int[10];

            //array com 10 espacos de 0 a 9.
            string[] nomes = new string[10];
            nomes[0] = "Alan";
            //outra inicializacao possivel, nesse caso cria um vetor apenas com os especos alocados.
            string[] nomesDiferente = { "Antonio", "Marcos", "Carol", "Sanches" };            
            
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            //Mais utilizado do que vetores, mas mesmo conceito.
            List<string> alunos = new List<string>();
            //voce acessa os metodos da lista.
            alunos.Add("Alan");
            alunos.Add("Romario");
            alunos.Add("Bia");
            //ja redimenciona as posicoes dos vetores.
            alunos.Remove("Romario");
            //Nao recomendavel utilizar ArrayList pois aceita qualquer dado, e a list é tipada.--
        }
    }
}
