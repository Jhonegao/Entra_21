namespace JogoDaForca
{
    partial class Form1
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
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lbInsiraLetra = new System.Windows.Forms.Label();
            this.lbFixDica = new System.Windows.Forms.Label();
            this.lbDica = new System.Windows.Forms.Label();
            this.lbTentativasTexto = new System.Windows.Forms.Label();
            this.lbNumeroTentativas = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalavra
            // 
            this.txtPalavra.Enabled = false;
            this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(36, 24);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(514, 26);
            this.txtPalavra.TabIndex = 0;
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(261, 204);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(100, 20);
            this.txtLetra.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(276, 230);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lbInsiraLetra
            // 
            this.lbInsiraLetra.AutoSize = true;
            this.lbInsiraLetra.Location = new System.Drawing.Point(283, 188);
            this.lbInsiraLetra.Name = "lbInsiraLetra";
            this.lbInsiraLetra.Size = new System.Drawing.Size(55, 13);
            this.lbInsiraLetra.TabIndex = 3;
            this.lbInsiraLetra.Text = "Insira letra";
            // 
            // lbFixDica
            // 
            this.lbFixDica.AutoSize = true;
            this.lbFixDica.Location = new System.Drawing.Point(33, 51);
            this.lbFixDica.Name = "lbFixDica";
            this.lbFixDica.Size = new System.Drawing.Size(32, 13);
            this.lbFixDica.TabIndex = 4;
            this.lbFixDica.Text = "DICA";
            // 
            // lbDica
            // 
            this.lbDica.AutoSize = true;
            this.lbDica.Location = new System.Drawing.Point(36, 64);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(10, 13);
            this.lbDica.TabIndex = 5;
            this.lbDica.Text = ":";
            // 
            // lbTentativasTexto
            // 
            this.lbTentativasTexto.AutoSize = true;
            this.lbTentativasTexto.Location = new System.Drawing.Point(408, 188);
            this.lbTentativasTexto.Name = "lbTentativasTexto";
            this.lbTentativasTexto.Size = new System.Drawing.Size(74, 13);
            this.lbTentativasTexto.TabIndex = 6;
            this.lbTentativasTexto.Text = "TENTATIVAS";
            // 
            // lbNumeroTentativas
            // 
            this.lbNumeroTentativas.AutoSize = true;
            this.lbNumeroTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroTentativas.Location = new System.Drawing.Point(420, 215);
            this.lbNumeroTentativas.Name = "lbNumeroTentativas";
            this.lbNumeroTentativas.Size = new System.Drawing.Size(50, 54);
            this.lbNumeroTentativas.TabIndex = 7;
            this.lbNumeroTentativas.Text = "0";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(276, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sortear Palavra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbNumeroTentativas);
            this.Controls.Add(this.lbTentativasTexto);
            this.Controls.Add(this.lbDica);
            this.Controls.Add(this.lbFixDica);
            this.Controls.Add(this.lbInsiraLetra);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.txtPalavra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lbInsiraLetra;
        private System.Windows.Forms.Label lbFixDica;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.Label lbTentativasTexto;
        private System.Windows.Forms.Label lbNumeroTentativas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
    }
}

