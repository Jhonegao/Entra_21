namespace Exercicios
{
    partial class Exercicio6_naMAO
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
            this.txtEntrada3 = new System.Windows.Forms.TextBox();
            this.txtEntrada2 = new System.Windows.Forms.TextBox();
            this.txtEntrada1 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEntrada3
            // 
            this.txtEntrada3.Location = new System.Drawing.Point(346, 145);
            this.txtEntrada3.Name = "txtEntrada3";
            this.txtEntrada3.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada3.TabIndex = 0;
            // 
            // txtEntrada2
            // 
            this.txtEntrada2.Location = new System.Drawing.Point(223, 145);
            this.txtEntrada2.Name = "txtEntrada2";
            this.txtEntrada2.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada2.TabIndex = 1;
            // 
            // txtEntrada1
            // 
            this.txtEntrada1.Location = new System.Drawing.Point(99, 145);
            this.txtEntrada1.Name = "txtEntrada1";
            this.txtEntrada1.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada1.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(235, 201);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Exercicio6_naMAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 343);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEntrada1);
            this.Controls.Add(this.txtEntrada2);
            this.Controls.Add(this.txtEntrada3);
            this.Name = "Exercicio6_naMAO";
            this.Text = "Exercicio6_naMAO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada3;
        private System.Windows.Forms.TextBox txtEntrada2;
        private System.Windows.Forms.TextBox txtEntrada1;
        private System.Windows.Forms.Button btnEnviar;
    }
}