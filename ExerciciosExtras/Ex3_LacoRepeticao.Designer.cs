namespace ExerciciosExtras
{
    partial class Ex3_LacoRepeticao
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbtest = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(84, 92);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Começar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbtest);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.txtValorEntrada);
            this.panel1.Location = new System.Drawing.Point(22, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(59, 52);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Location = new System.Drawing.Point(47, 16);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtValorEntrada.TabIndex = 0;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(92, 50);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(0, 13);
            this.lbQuantidade.TabIndex = 9;
            // 
            // lbtest
            // 
            this.lbtest.AutoSize = true;
            this.lbtest.Location = new System.Drawing.Point(144, 71);
            this.lbtest.Name = "lbtest";
            this.lbtest.Size = new System.Drawing.Size(0, 13);
            this.lbtest.TabIndex = 2;
            // 
            // Ex3_LacoRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 211);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerificar);
            this.Name = "Ex3_LacoRepeticao";
            this.Text = "Ex3_LacoRepeticao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtValorEntrada;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbtest;
    }
}