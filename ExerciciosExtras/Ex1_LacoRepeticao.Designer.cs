namespace ExerciciosExtras
{
    partial class Ex1_LacoRepeticao
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
            this.txtEntradaValor = new System.Windows.Forms.TextBox();
            this.btnFatorial = new System.Windows.Forms.Button();
            this.lbEntreComOValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntradaValor
            // 
            this.txtEntradaValor.Location = new System.Drawing.Point(66, 57);
            this.txtEntradaValor.Name = "txtEntradaValor";
            this.txtEntradaValor.Size = new System.Drawing.Size(100, 20);
            this.txtEntradaValor.TabIndex = 0;
            // 
            // btnFatorial
            // 
            this.btnFatorial.Location = new System.Drawing.Point(78, 83);
            this.btnFatorial.Name = "btnFatorial";
            this.btnFatorial.Size = new System.Drawing.Size(75, 23);
            this.btnFatorial.TabIndex = 1;
            this.btnFatorial.Text = "Fatorar";
            this.btnFatorial.UseVisualStyleBackColor = true;
            this.btnFatorial.Click += new System.EventHandler(this.btnFatorial_Click);
            // 
            // lbEntreComOValor
            // 
            this.lbEntreComOValor.AutoSize = true;
            this.lbEntreComOValor.Location = new System.Drawing.Point(70, 34);
            this.lbEntreComOValor.Name = "lbEntreComOValor";
            this.lbEntreComOValor.Size = new System.Drawing.Size(90, 13);
            this.lbEntreComOValor.TabIndex = 2;
            this.lbEntreComOValor.Text = "Entre com o valor";
            // 
            // Ex1_LacoRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 194);
            this.Controls.Add(this.lbEntreComOValor);
            this.Controls.Add(this.btnFatorial);
            this.Controls.Add(this.txtEntradaValor);
            this.Name = "Ex1_LacoRepeticao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntradaValor;
        private System.Windows.Forms.Button btnFatorial;
        private System.Windows.Forms.Label lbEntreComOValor;
    }
}

