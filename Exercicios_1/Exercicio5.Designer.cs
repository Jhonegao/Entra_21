namespace Exercicios
{
    partial class Exercicio5
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorVeiculo = new System.Windows.Forms.TextBox();
            this.lbValorVeiculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(48, 139);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorVeiculo
            // 
            this.txtValorVeiculo.Location = new System.Drawing.Point(36, 90);
            this.txtValorVeiculo.Name = "txtValorVeiculo";
            this.txtValorVeiculo.Size = new System.Drawing.Size(100, 22);
            this.txtValorVeiculo.TabIndex = 1;
            // 
            // lbValorVeiculo
            // 
            this.lbValorVeiculo.AutoSize = true;
            this.lbValorVeiculo.Location = new System.Drawing.Point(35, 44);
            this.lbValorVeiculo.Name = "lbValorVeiculo";
            this.lbValorVeiculo.Size = new System.Drawing.Size(101, 17);
            this.lbValorVeiculo.TabIndex = 2;
            this.lbValorVeiculo.Text = "Valor do viculo";
            // 
            // Exercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 373);
            this.Controls.Add(this.lbValorVeiculo);
            this.Controls.Add(this.txtValorVeiculo);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Exercicio5";
            this.Text = "Exercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorVeiculo;
        private System.Windows.Forms.Label lbValorVeiculo;
    }
}