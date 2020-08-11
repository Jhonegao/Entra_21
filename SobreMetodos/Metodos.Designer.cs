namespace SobreMetodos
{
    partial class Metodos
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEntrada_Nome = new System.Windows.Forms.TextBox();
            this.lbENome = new System.Windows.Forms.Label();
            this.lbECPF = new System.Windows.Forms.Label();
            this.txt_Entrada_CPF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 113);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtEntrada_Nome
            // 
            this.txtEntrada_Nome.Location = new System.Drawing.Point(12, 33);
            this.txtEntrada_Nome.Name = "txtEntrada_Nome";
            this.txtEntrada_Nome.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada_Nome.TabIndex = 1;
            // 
            // lbENome
            // 
            this.lbENome.AutoSize = true;
            this.lbENome.Location = new System.Drawing.Point(13, 13);
            this.lbENome.Name = "lbENome";
            this.lbENome.Size = new System.Drawing.Size(35, 13);
            this.lbENome.TabIndex = 2;
            this.lbENome.Text = "Nome";
            // 
            // lbECPF
            // 
            this.lbECPF.AutoSize = true;
            this.lbECPF.Location = new System.Drawing.Point(13, 56);
            this.lbECPF.Name = "lbECPF";
            this.lbECPF.Size = new System.Drawing.Size(35, 13);
            this.lbECPF.TabIndex = 4;
            this.lbECPF.Text = "Nome";
            // 
            // txt_Entrada_CPF
            // 
            this.txt_Entrada_CPF.Location = new System.Drawing.Point(12, 76);
            this.txt_Entrada_CPF.Name = "txt_Entrada_CPF";
            this.txt_Entrada_CPF.Size = new System.Drawing.Size(100, 20);
            this.txt_Entrada_CPF.TabIndex = 3;
            // 
            // Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 282);
            this.Controls.Add(this.lbECPF);
            this.Controls.Add(this.txt_Entrada_CPF);
            this.Controls.Add(this.lbENome);
            this.Controls.Add(this.txtEntrada_Nome);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Metodos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtEntrada_Nome;
        private System.Windows.Forms.Label lbENome;
        private System.Windows.Forms.Label lbECPF;
        private System.Windows.Forms.TextBox txt_Entrada_CPF;
    }
}

