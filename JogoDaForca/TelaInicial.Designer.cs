namespace JogoDaForca
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPalavraEscrita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDicaEscrita = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDica = new System.Windows.Forms.Label();
            this.lbFixDica = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lbInsiraLetra = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sortear uma plavra";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(142, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jogo da forca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "OU";
            // 
            // txtPalavraEscrita
            // 
            this.txtPalavraEscrita.Location = new System.Drawing.Point(351, 130);
            this.txtPalavraEscrita.Name = "txtPalavraEscrita";
            this.txtPalavraEscrita.Size = new System.Drawing.Size(100, 20);
            this.txtPalavraEscrita.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Insira uma palavra";
            // 
            // txtDicaEscrita
            // 
            this.txtDicaEscrita.Location = new System.Drawing.Point(351, 178);
            this.txtDicaEscrita.Name = "txtDicaEscrita";
            this.txtDicaEscrita.Size = new System.Drawing.Size(100, 20);
            this.txtDicaEscrita.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dica da palavra livre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbInsiraLetra);
            this.panel1.Controls.Add(this.btnVerificar);
            this.panel1.Controls.Add(this.txtLetra);
            this.panel1.Controls.Add(this.lbDica);
            this.panel1.Controls.Add(this.lbFixDica);
            this.panel1.Controls.Add(this.txtPalavra);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 276);
            this.panel1.TabIndex = 19;
            // 
            // lbDica
            // 
            this.lbDica.AutoSize = true;
            this.lbDica.Location = new System.Drawing.Point(3, 46);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(10, 13);
            this.lbDica.TabIndex = 8;
            this.lbDica.Text = ":";
            // 
            // lbFixDica
            // 
            this.lbFixDica.AutoSize = true;
            this.lbFixDica.Location = new System.Drawing.Point(0, 33);
            this.lbFixDica.Name = "lbFixDica";
            this.lbFixDica.Size = new System.Drawing.Size(32, 13);
            this.lbFixDica.TabIndex = 7;
            this.lbFixDica.Text = "DICA";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Enabled = false;
            this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(3, 6);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(532, 26);
            this.txtPalavra.TabIndex = 6;
            // 
            // lbInsiraLetra
            // 
            this.lbInsiraLetra.AutoSize = true;
            this.lbInsiraLetra.Location = new System.Drawing.Point(229, 54);
            this.lbInsiraLetra.Name = "lbInsiraLetra";
            this.lbInsiraLetra.Size = new System.Drawing.Size(55, 13);
            this.lbInsiraLetra.TabIndex = 11;
            this.lbInsiraLetra.Text = "Insira letra";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(222, 96);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 10;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(207, 70);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(100, 20);
            this.txtLetra.TabIndex = 9;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 294);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDicaEscrita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPalavraEscrita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPalavraEscrita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDicaEscrita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.Label lbFixDica;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label lbInsiraLetra;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtLetra;
    }
}