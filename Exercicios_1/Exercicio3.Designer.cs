namespace Exercicios
{
    partial class Exercicio3
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
            this.txtEntrada1 = new System.Windows.Forms.TextBox();
            this.txtEntrada2 = new System.Windows.Forms.TextBox();
            this.lbEntrada1 = new System.Windows.Forms.Label();
            this.lbEntrada2 = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEntrada1
            // 
            this.txtEntrada1.Location = new System.Drawing.Point(106, 195);
            this.txtEntrada1.Name = "txtEntrada1";
            this.txtEntrada1.Size = new System.Drawing.Size(100, 22);
            this.txtEntrada1.TabIndex = 0;
            // 
            // txtEntrada2
            // 
            this.txtEntrada2.Location = new System.Drawing.Point(324, 195);
            this.txtEntrada2.Name = "txtEntrada2";
            this.txtEntrada2.Size = new System.Drawing.Size(100, 22);
            this.txtEntrada2.TabIndex = 1;
            // 
            // lbEntrada1
            // 
            this.lbEntrada1.AutoSize = true;
            this.lbEntrada1.Location = new System.Drawing.Point(77, 157);
            this.lbEntrada1.Name = "lbEntrada1";
            this.lbEntrada1.Size = new System.Drawing.Size(169, 17);
            this.lbEntrada1.TabIndex = 2;
            this.lbEntrada1.Text = "Primeira Entrada de valor";
            // 
            // lbEntrada2
            // 
            this.lbEntrada2.AutoSize = true;
            this.lbEntrada2.Location = new System.Drawing.Point(295, 157);
            this.lbEntrada2.Name = "lbEntrada2";
            this.lbEntrada2.Size = new System.Drawing.Size(173, 17);
            this.lbEntrada2.TabIndex = 3;
            this.lbEntrada2.Text = "Segunda entrada de valor";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(212, 239);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(108, 23);
            this.btnExecutar.TabIndex = 4;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 426);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lbEntrada2);
            this.Controls.Add(this.lbEntrada1);
            this.Controls.Add(this.txtEntrada2);
            this.Controls.Add(this.txtEntrada1);
            this.Name = "Exercicio3";
            this.Text = "Exercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada1;
        private System.Windows.Forms.TextBox txtEntrada2;
        private System.Windows.Forms.Label lbEntrada1;
        private System.Windows.Forms.Label lbEntrada2;
        private System.Windows.Forms.Button btnExecutar;
    }
}