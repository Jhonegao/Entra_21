using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoteSystem.Properties;

namespace VoteSystem
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            btnCadastroCancel.Visible = false;
            btnCadastroOK.Visible = false;
            btnEscolherImagem.Visible = false;
            tabs.TabPages.Remove(tabVotar);
            tabs.TabPages.Remove(tabResultado);
            btnIniciarVotacao.Enabled = false;
        }
        public void atualizarLista()
        {
            for (int i = 0; i < list_Elegiveis.Count; i = i+2)
            {
                dgElegiveis.Rows.Add(list_Elegiveis.ElementAt(i), list_Elegiveis.ElementAt(i + 1));
            }
            dgElegiveis.AllowUserToAddRows = false;
        }
        //funcao para habilitar os botoes e limpar caixas de texto
        public void mostrarBotoes(bool set)
        {
            btnCadastroCancel.Visible = set;
            btnCadastroOK.Visible = set;
            btnEscolherImagem.Visible = set;
            pbFotosCandidatos.Image = null;
            txtNomeCandidato.Clear();
            txtNumeroCandidato.Clear();
            btnCadastrarNovo.Visible = !set;
            btnAdicionarVotacao.Visible = !set;
            //resetando a listagem de amostra para o primeiro item do itendex
            contadorAuxiliar = -1;
        }

        //iniciando listas necessarias
        //lista de coligacoes pré setadas
        //iniciando lista com nome de 15 candidatos.
        List<string> list_NomeCandidatos = new List<string> { "BrunoH", "Bia", "Helo", "Luiz", "Joana", "Vinicius", "Katia", "Alan", "Marcelo", "BrunoF", "Kaue", "Gustavo", "Pablo", "Duda", "Felipe" };
        //inician lista com imagens pré setada dos candidatos
        List<Image> list_ImagensCandidatos = new List<Image> { Resources.pic1_BrunoHenrique, Resources.pic10_Bia, Resources.pic11_Helo, Resources.pic12_Luiz, Resources.pic13_Joana, Resources.pic14_Vinicius,
        Resources.pic15_Katia, Resources.pic16_Alan, Resources.pic2_Marcelo, Resources.pic3_BrunoFelipe, Resources.pic4_Kaue, Resources.pic5_Gustavo, Resources.pic7_Pablo, Resources.pic8_Duda, Resources.pic9_Felipe,};
        //inicia numero dos candidatos
        List<int> list_NumerosCandidatos = new List<int> { 11, 10, 44, 3, 8, 1, 7, 88, 9, 180, 118, 12, 183, 14, 154 };
        //iniciando uma lista com votos e dos candidatos para votacao
        List<int> list_Votos = new List<int>();
        List<string> list_Elegiveis = new List<string>();
        List<Image> list_VotacaoImagens = new List<Image>();
        //auxiliares para lsitagem
        int contadorAuxiliar = -1;
        bool temImagem = false;
        int qntCanditados = 0;

        //iniciando logica para adicionar os candidatos ja pré cadastrados
        private void btnNext_Click(object sender, EventArgs e)
        {
            contadorAuxiliar++;
            if (contadorAuxiliar >= list_NumerosCandidatos.Count)
            {
                contadorAuxiliar = 0;
            }
            pbFotosCandidatos.Image = list_ImagensCandidatos.ElementAt(contadorAuxiliar);
            txtNomeCandidato.Text = list_NomeCandidatos.ElementAt(contadorAuxiliar);
            txtNumeroCandidato.Text = list_NumerosCandidatos.ElementAt(contadorAuxiliar).ToString();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            contadorAuxiliar--;
            if (contadorAuxiliar < 0)
            {
                contadorAuxiliar = (list_NumerosCandidatos.Count - 1);
            }
            pbFotosCandidatos.Image = list_ImagensCandidatos.ElementAt(contadorAuxiliar);
            txtNomeCandidato.Text = list_NomeCandidatos.ElementAt(contadorAuxiliar);
            txtNumeroCandidato.Text = list_NumerosCandidatos.ElementAt(contadorAuxiliar).ToString();
        }
        private void btnCadastrarNovo_Click(object sender, EventArgs e)
        {
            mostrarBotoes(true);
            txtNomeCandidato.Enabled = true;
            txtNomeCandidato.Focus();
            txtNumeroCandidato.Enabled = true;
        }
        //cadastro de um novo candidato, com checagem dos numeros ja existende pre cadastrados.
        private void btnCadastroOK_Click(object sender, EventArgs e)
        {
            bool checkagem = true;
            if (txtNomeCandidato.Text != "" && txtNumeroCandidato.Text != "" && temImagem)
            {
                for (int i = 0; i < list_NomeCandidatos.Count; i++)
                {
                    if (Convert.ToInt32(txtNumeroCandidato.Text) == list_NumerosCandidatos.ElementAt(i))
                    {
                        checkagem = false;
                        MessageBox.Show("TA IGUAL");
                        return;
                    }
                }
                if (checkagem)
                {
                    list_NomeCandidatos.Add(txtNomeCandidato.Text);
                    list_NumerosCandidatos.Add(Convert.ToInt32(txtNumeroCandidato.Text));
                    list_ImagensCandidatos.Add(pbFotosCandidatos.Image);
                    temImagem = false;
                    MessageBox.Show("Candidato cadastrado");
                    mostrarBotoes(false);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos campos e escolha uma imagem");
            }
        }
        private void btnCadastroCancel_Click(object sender, EventArgs e)
        {
            mostrarBotoes(false);
        }
        //checagem de eventos se os campos estao entrado caracteres validos para cadastro.
        private void txtNomeCandidato_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        private void txtNumeroCandidato_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg) | *.jpg; *.jpeg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                temImagem = true;
                // display image in picture box  
                pbFotosCandidatos.Image = new Bitmap(open.FileName);
            }
        }
        private void btnAdicionarVotacao_Click(object sender, EventArgs e)
        {
            if (txtNomeCandidato.Text != "" && txtNumeroCandidato.Text != "")
            {
                bool checkDual = false;
                for (int i = 0; i < list_Elegiveis.Count; i++)
                {
                    if (txtNumeroCandidato.Text == list_Elegiveis.ElementAt(i))
                    {
                        checkDual = true;
                        MessageBox.Show("Candidato já adicionado");
                        return;
                    }
                }
                if (!checkDual)
                {
                    list_Elegiveis.Add(txtNomeCandidato.Text);
                    list_Elegiveis.Add(txtNumeroCandidato.Text);
                    list_Votos.Add(0);
                    list_VotacaoImagens.Add(pbFotosCandidatos.Image);
                    qntCanditados++;
                }
            }
            else
            {
                MessageBox.Show("wtf");
            }
            if (qntCanditados > 1)
            {
                btnIniciarVotacao.Enabled = true;                
            }
        }
        private void btnIniciarVotacao_Click(object sender, EventArgs e)
        {
            atualizarLista();
            tabs.TabPages.Add(tabVotar);
            tabs.TabPages.Remove(tabCadastro);
        }
        bool checkStatus = false;
        int posicaoVoto = 0;
        private void txtEntradaNum_TextChanged(object sender, EventArgs e)
        {
            pbVotacaoImagem.Image = null;
            lbNomeVoto.Text = null;
            int indexador = 0;
            for (int i = 1; i < list_Elegiveis.Count; i += 2)
            {
                if (txtEntradaNum.Text == list_Elegiveis.ElementAt(i))
                {
                    pbVotacaoImagem.Image = list_VotacaoImagens.ElementAt(indexador);
                    lbNomeVoto.Text = list_Elegiveis.ElementAt(i - 1);
                    checkStatus = true;
                    posicaoVoto = indexador;
                    return;
                }
                indexador++;
            }
            checkStatus = false;
        }
        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (checkStatus)
            {
                list_Votos.Insert(posicaoVoto, list_Votos.ElementAt(posicaoVoto) + 1);
                MessageBox.Show("ok");
            }
            MessageBox.Show($"votacao esta em {list_Votos.ElementAt(posicaoVoto)}");
        }
    }
}
