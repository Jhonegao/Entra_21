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
using System.Windows.Forms.DataVisualization.Charting;
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
            btnVotar.Enabled = false;
        }
        //System.Windows.Forms.DataVisualization.Charting.Series serieTest = new System.Windows.Forms.DataVisualization.Charting.Series();
        private void limparVotacao(bool completo)
        {
            if (completo)
            {
            txtEntradaNum.Clear();
            }
            pbVotacaoImagem.Image = null;
            lbNomeVoto.Text = null;
            btnVotar.Enabled = false;
            cbConfirma.Checked = false;
            txtEntradaNum.Focus();
            cbConfirma.Visible = false;
        }
        public void atualizarLista()
        {
            int votosController = 0;
            for (int i = 0; i < list_Elegiveis.Count; i = i+2)
            {
                dgElegiveis.Rows.Add(list_Elegiveis.ElementAt(i), list_Elegiveis.ElementAt(i + 1), list_Votos.ElementAt(votosController));
                votosController++;
            }
            dgElegiveis.AllowUserToAddRows = false;
            cbConfirma.Visible = false;
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
        List<int> list_NumerosCandidatos = new List<int> { 11, 10, 44, 3, 8, 1, 7, 88, 9, 180, 17, 12, 183, 14, 154 };
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
        //cadastro de um novo candidato, com checagem dos numeros ja existende pre cadastrados.
        private void btnCadastrarNovo_Click(object sender, EventArgs e)
        {
            mostrarBotoes(true);
            txtNomeCandidato.Enabled = true;
            txtNomeCandidato.Focus();
            txtNumeroCandidato.Enabled = true;
        }
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
                if (!checkDual && qntCanditados < 10)
                {
                    qntCanditados++;
                    lbMaxCandidatos.Text = $"Quantidade atual {qntCanditados} /10 candidatos";
                    list_Elegiveis.Add(txtNomeCandidato.Text);
                    list_Elegiveis.Add(txtNumeroCandidato.Text);
                    list_Votos.Add(0);
                    list_VotacaoImagens.Add(pbFotosCandidatos.Image);
                    btnIniciarVotacao.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Numero maximo de candidatos elegiveis atingido.");
                    btnAdicionarVotacao.Visible = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("wtf");
            }
        }
        private void btnIniciarVotacao_Click(object sender, EventArgs e)
        {
            atualizarLista();
            tabs.TabPages.Add(tabVotar);
            tabs.TabPages.Remove(tabCadastro);
        }
        bool checkStatus = false;
        bool checkConfirmar = false;
        int posicaoVoto = 0;
        int totalVotos = 0;
        private void txtEntradaNum_TextChanged(object sender, EventArgs e)
        {
            limparVotacao(false);
            int indexador = 0;
            for (int i = 1; i < list_Elegiveis.Count; i += 2)
            {
                if (txtEntradaNum.Text == list_Elegiveis.ElementAt(i))
                {
                    pbVotacaoImagem.Image = list_VotacaoImagens.ElementAt(indexador);
                    lbNomeVoto.Text = list_Elegiveis.ElementAt(i - 1);
                    checkStatus = true;
                    posicaoVoto = indexador;
                    cbConfirma.Visible = true;
                    return;
                }
                indexador++;
            }
            checkStatus = false;
            cbConfirma.Visible = false;
        }
        private void btnVotar_Click(object sender, EventArgs e)
        {
            //reforcando checagem para votos.
            if (checkStatus && checkConfirmar)
            {
                //list_Votos.Insert(posicaoVoto, (list_Votos.ElementAt(posicaoVoto) + 1)); -->>verificar por que nao funcionou
                list_Votos[posicaoVoto] = list_Votos[posicaoVoto] + 1;
                dgElegiveis.Rows[posicaoVoto].Cells[2].Value = list_Votos[posicaoVoto];
                totalVotos++;
                MessageBox.Show($"Voto registrado para {dgElegiveis.Rows[posicaoVoto].Cells[0].Value.ToString()}");
                limparVotacao(true);
                btnFinalizar.Enabled = true;
            }
        }
        //verificar se é possivel aplicar a checkbox direto na condicao
        private void cbConfirma_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConfirma.Checked)
            {
                checkConfirmar = true;
                cbConfirma.BackColor = System.Drawing.Color.LightGreen;
                btnVotar.Enabled = true;
            }
            else
            {
                checkConfirmar = false;
                cbConfirma.BackColor = System.Drawing.Color.Transparent;
                btnVotar.Enabled = false;
            }
        }
        //criando serie
        private void criarSeries(int candidatos)
        {
            for (int i = 0; i < candidatos; i++)
            {
            Series serie = new Series();
            serie.ChartArea = "ChartArea1";
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serie.IsValueShownAsLabel = true;
            serie.LabelFormat = "#";
            serie.Legend = "";
            serie.Name = dgElegiveis.Rows[i].Cells[0].Value.ToString();
            graphPie.Series.Add(serie);
            graphPie.Series[dgElegiveis.Rows[i].Cells[0].Value.ToString()].Points.AddXY(dgElegiveis.Rows[i].Cells[0].Value, dgElegiveis.Rows[i].Cells[2].Value);
            }
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {            
            this.ClientSize = new System.Drawing.Size(940, 680);
            tabs.TabPages.Add(tabResultado);
            tabs.TabPages.Remove(tabVotar);
            criarSeries(dgElegiveis.Rows.Count);
            //graphPie.Series["Candidatos"].Points.AddXY(dgElegiveis.Rows[0].Cells[0].Value, dgElegiveis.Rows[0].Cells[2].Value);
            //graphPie.Series["Candidatos"].Points.AddXY(dgElegiveis.Rows[1].Cells[0].Value, dgElegiveis.Rows[1].Cells[2].Value);
            //graphPie.Series["Candidatos"].Points.AddXY(dgElegiveis.Rows[2].Cells[0].Value, dgElegiveis.Rows[2].Cells[2].Value);            
           // graphPie.Series["Candidatos"].Points.AddXY(dgElegiveis.Rows[3].Cells[0].Value, dgElegiveis.Rows[3].Cells[2].Value);
            //graphPie.Series["Candidatos"].Points.AddXY(dgElegiveis.Rows[4].Cells[0].Value, dgElegiveis.Rows[4].Cells[2].Value);
        }
    }
}