namespace VoteSystem
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.btnIniciarVotacao = new System.Windows.Forms.Button();
            this.btnEscolherImagem = new System.Windows.Forms.Button();
            this.btnCadastroOK = new System.Windows.Forms.Button();
            this.btnCadastroCancel = new System.Windows.Forms.Button();
            this.btnCadastrarNovo = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionarVotacao = new System.Windows.Forms.Button();
            this.txtNumeroCandidato = new System.Windows.Forms.TextBox();
            this.txtNomeCandidato = new System.Windows.Forms.TextBox();
            this.pbFotosCandidatos = new System.Windows.Forms.PictureBox();
            this.tabVotar = new System.Windows.Forms.TabPage();
            this.cbConfirma = new System.Windows.Forms.CheckBox();
            this.lbNomeVoto = new System.Windows.Forms.Label();
            this.pbVotacaoImagem = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntradaNum = new System.Windows.Forms.TextBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgElegiveis = new System.Windows.Forms.DataGridView();
            this.c_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabResultado = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabs.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotosCandidatos)).BeginInit();
            this.tabVotar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVotacaoImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgElegiveis)).BeginInit();
            this.tabResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabCadastro);
            this.tabs.Controls.Add(this.tabVotar);
            this.tabs.Controls.Add(this.tabResultado);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(402, 453);
            this.tabs.TabIndex = 0;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.btnIniciarVotacao);
            this.tabCadastro.Controls.Add(this.btnEscolherImagem);
            this.tabCadastro.Controls.Add(this.btnCadastroOK);
            this.tabCadastro.Controls.Add(this.btnCadastroCancel);
            this.tabCadastro.Controls.Add(this.btnCadastrarNovo);
            this.tabCadastro.Controls.Add(this.btnPrevious);
            this.tabCadastro.Controls.Add(this.btnNext);
            this.tabCadastro.Controls.Add(this.label3);
            this.tabCadastro.Controls.Add(this.label1);
            this.tabCadastro.Controls.Add(this.btnAdicionarVotacao);
            this.tabCadastro.Controls.Add(this.txtNumeroCandidato);
            this.tabCadastro.Controls.Add(this.txtNomeCandidato);
            this.tabCadastro.Controls.Add(this.pbFotosCandidatos);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(394, 427);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "CADASTRO";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // btnIniciarVotacao
            // 
            this.btnIniciarVotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarVotacao.Location = new System.Drawing.Point(286, 293);
            this.btnIniciarVotacao.Name = "btnIniciarVotacao";
            this.btnIniciarVotacao.Size = new System.Drawing.Size(75, 99);
            this.btnIniciarVotacao.TabIndex = 15;
            this.btnIniciarVotacao.Text = "Iniciar votação";
            this.btnIniciarVotacao.UseVisualStyleBackColor = true;
            this.btnIniciarVotacao.Click += new System.EventHandler(this.btnIniciarVotacao_Click);
            // 
            // btnEscolherImagem
            // 
            this.btnEscolherImagem.Location = new System.Drawing.Point(180, 185);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.Size = new System.Drawing.Size(96, 23);
            this.btnEscolherImagem.TabIndex = 14;
            this.btnEscolherImagem.Text = "Escolher Imagem";
            this.btnEscolherImagem.UseVisualStyleBackColor = true;
            this.btnEscolherImagem.Click += new System.EventHandler(this.btnEscolherImagem_Click);
            // 
            // btnCadastroOK
            // 
            this.btnCadastroOK.BackColor = System.Drawing.Color.Green;
            this.btnCadastroOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroOK.Location = new System.Drawing.Point(131, 293);
            this.btnCadastroOK.Name = "btnCadastroOK";
            this.btnCadastroOK.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroOK.TabIndex = 13;
            this.btnCadastroOK.Text = "OK";
            this.btnCadastroOK.UseVisualStyleBackColor = false;
            this.btnCadastroOK.Click += new System.EventHandler(this.btnCadastroOK_Click);
            // 
            // btnCadastroCancel
            // 
            this.btnCadastroCancel.BackColor = System.Drawing.Color.Red;
            this.btnCadastroCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCancel.Location = new System.Drawing.Point(206, 293);
            this.btnCadastroCancel.Name = "btnCadastroCancel";
            this.btnCadastroCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroCancel.TabIndex = 12;
            this.btnCadastroCancel.Text = "CANCEL";
            this.btnCadastroCancel.UseVisualStyleBackColor = false;
            this.btnCadastroCancel.Click += new System.EventHandler(this.btnCadastroCancel_Click);
            // 
            // btnCadastrarNovo
            // 
            this.btnCadastrarNovo.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCadastrarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarNovo.Location = new System.Drawing.Point(85, 335);
            this.btnCadastrarNovo.Name = "btnCadastrarNovo";
            this.btnCadastrarNovo.Size = new System.Drawing.Size(194, 57);
            this.btnCadastrarNovo.TabIndex = 11;
            this.btnCadastrarNovo.Text = "CADASTRAR NOVO CANDIDATO";
            this.btnCadastrarNovo.UseVisualStyleBackColor = false;
            this.btnCadastrarNovo.Click += new System.EventHandler(this.btnCadastrarNovo_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(4, 111);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(285, 111);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // btnAdicionarVotacao
            // 
            this.btnAdicionarVotacao.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAdicionarVotacao.FlatAppearance.BorderSize = 0;
            this.btnAdicionarVotacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarVotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarVotacao.Location = new System.Drawing.Point(137, 293);
            this.btnAdicionarVotacao.Name = "btnAdicionarVotacao";
            this.btnAdicionarVotacao.Size = new System.Drawing.Size(142, 22);
            this.btnAdicionarVotacao.TabIndex = 4;
            this.btnAdicionarVotacao.Text = "Colocar na votacao";
            this.btnAdicionarVotacao.UseVisualStyleBackColor = false;
            this.btnAdicionarVotacao.Click += new System.EventHandler(this.btnAdicionarVotacao_Click);
            // 
            // txtNumeroCandidato
            // 
            this.txtNumeroCandidato.Enabled = false;
            this.txtNumeroCandidato.Location = new System.Drawing.Point(85, 295);
            this.txtNumeroCandidato.Name = "txtNumeroCandidato";
            this.txtNumeroCandidato.Size = new System.Drawing.Size(41, 20);
            this.txtNumeroCandidato.TabIndex = 3;
            this.txtNumeroCandidato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCandidato_KeyPress);
            // 
            // txtNomeCandidato
            // 
            this.txtNomeCandidato.Enabled = false;
            this.txtNomeCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCandidato.Location = new System.Drawing.Point(85, 244);
            this.txtNomeCandidato.Name = "txtNomeCandidato";
            this.txtNomeCandidato.Size = new System.Drawing.Size(194, 23);
            this.txtNomeCandidato.TabIndex = 1;
            this.txtNomeCandidato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCandidato_KeyPress);
            // 
            // pbFotosCandidatos
            // 
            this.pbFotosCandidatos.Location = new System.Drawing.Point(85, 20);
            this.pbFotosCandidatos.Name = "pbFotosCandidatos";
            this.pbFotosCandidatos.Size = new System.Drawing.Size(194, 192);
            this.pbFotosCandidatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotosCandidatos.TabIndex = 0;
            this.pbFotosCandidatos.TabStop = false;
            // 
            // tabVotar
            // 
            this.tabVotar.Controls.Add(this.cbConfirma);
            this.tabVotar.Controls.Add(this.lbNomeVoto);
            this.tabVotar.Controls.Add(this.pbVotacaoImagem);
            this.tabVotar.Controls.Add(this.label4);
            this.tabVotar.Controls.Add(this.txtEntradaNum);
            this.tabVotar.Controls.Add(this.btnVotar);
            this.tabVotar.Controls.Add(this.label2);
            this.tabVotar.Controls.Add(this.dgElegiveis);
            this.tabVotar.Location = new System.Drawing.Point(4, 22);
            this.tabVotar.Name = "tabVotar";
            this.tabVotar.Padding = new System.Windows.Forms.Padding(3);
            this.tabVotar.Size = new System.Drawing.Size(394, 427);
            this.tabVotar.TabIndex = 1;
            this.tabVotar.Text = "VOTAR";
            this.tabVotar.UseVisualStyleBackColor = true;
            // 
            // cbConfirma
            // 
            this.cbConfirma.AutoSize = true;
            this.cbConfirma.BackColor = System.Drawing.Color.Transparent;
            this.cbConfirma.Location = new System.Drawing.Point(134, 294);
            this.cbConfirma.Name = "cbConfirma";
            this.cbConfirma.Size = new System.Drawing.Size(76, 17);
            this.cbConfirma.TabIndex = 7;
            this.cbConfirma.Text = "Confirmar?";
            this.cbConfirma.UseVisualStyleBackColor = false;
            this.cbConfirma.CheckedChanged += new System.EventHandler(this.cbConfirma_CheckedChanged);
            // 
            // lbNomeVoto
            // 
            this.lbNomeVoto.AutoSize = true;
            this.lbNomeVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeVoto.Location = new System.Drawing.Point(135, 256);
            this.lbNomeVoto.Name = "lbNomeVoto";
            this.lbNomeVoto.Size = new System.Drawing.Size(0, 20);
            this.lbNomeVoto.TabIndex = 6;
            // 
            // pbVotacaoImagem
            // 
            this.pbVotacaoImagem.Location = new System.Drawing.Point(134, 6);
            this.pbVotacaoImagem.Name = "pbVotacaoImagem";
            this.pbVotacaoImagem.Size = new System.Drawing.Size(257, 247);
            this.pbVotacaoImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVotacaoImagem.TabIndex = 5;
            this.pbVotacaoImagem.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Insira o numero do candidato";
            // 
            // txtEntradaNum
            // 
            this.txtEntradaNum.Location = new System.Drawing.Point(213, 350);
            this.txtEntradaNum.Name = "txtEntradaNum";
            this.txtEntradaNum.Size = new System.Drawing.Size(75, 20);
            this.txtEntradaNum.TabIndex = 3;
            this.txtEntradaNum.TextChanged += new System.EventHandler(this.txtEntradaNum_TextChanged);
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.Silver;
            this.btnVotar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotar.Location = new System.Drawing.Point(213, 376);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(75, 23);
            this.btnVotar.TabIndex = 2;
            this.btnVotar.Text = "VOTAR";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista dos Elegiveis";
            // 
            // dgElegiveis
            // 
            this.dgElegiveis.AllowUserToDeleteRows = false;
            this.dgElegiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgElegiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_Nome,
            this.c_Numero});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgElegiveis.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgElegiveis.Location = new System.Drawing.Point(6, 23);
            this.dgElegiveis.Name = "dgElegiveis";
            this.dgElegiveis.ReadOnly = true;
            this.dgElegiveis.RowHeadersVisible = false;
            this.dgElegiveis.Size = new System.Drawing.Size(123, 387);
            this.dgElegiveis.TabIndex = 0;
            // 
            // c_Nome
            // 
            this.c_Nome.HeaderText = "Nome";
            this.c_Nome.Name = "c_Nome";
            this.c_Nome.ReadOnly = true;
            this.c_Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c_Nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.c_Nome.Width = 80;
            // 
            // c_Numero
            // 
            this.c_Numero.HeaderText = "Num.";
            this.c_Numero.Name = "c_Numero";
            this.c_Numero.ReadOnly = true;
            this.c_Numero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c_Numero.Width = 40;
            // 
            // tabResultado
            // 
            this.tabResultado.Controls.Add(this.chart1);
            this.tabResultado.Location = new System.Drawing.Point(4, 22);
            this.tabResultado.Name = "tabResultado";
            this.tabResultado.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultado.Size = new System.Drawing.Size(394, 427);
            this.tabResultado.TabIndex = 2;
            this.tabResultado.Text = "RESULTADO";
            this.tabResultado.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 68);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 453);
            this.Controls.Add(this.tabs);
            this.Name = "TelaInicial";
            this.Text = "Form1";
            this.tabs.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotosCandidatos)).EndInit();
            this.tabVotar.ResumeLayout(false);
            this.tabVotar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVotacaoImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgElegiveis)).EndInit();
            this.tabResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabVotar;
        private System.Windows.Forms.TabPage tabResultado;
        private System.Windows.Forms.Button btnAdicionarVotacao;
        private System.Windows.Forms.TextBox txtNumeroCandidato;
        private System.Windows.Forms.TextBox txtNomeCandidato;
        private System.Windows.Forms.PictureBox pbFotosCandidatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCadastrarNovo;
        private System.Windows.Forms.Button btnCadastroOK;
        private System.Windows.Forms.Button btnCadastroCancel;
        private System.Windows.Forms.Button btnEscolherImagem;
        private System.Windows.Forms.DataGridView dgElegiveis;
        private System.Windows.Forms.Label lbNomeVoto;
        private System.Windows.Forms.PictureBox pbVotacaoImagem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntradaNum;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Numero;
        private System.Windows.Forms.Button btnIniciarVotacao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox cbConfirma;
    }
}

