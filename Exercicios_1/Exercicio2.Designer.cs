namespace Exercicios
{
    partial class Exercicio2
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
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.lbValorProduto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(70, 278);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(191, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar cobrança";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(70, 79);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(100, 22);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(70, 153);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(100, 22);
            this.txtValorProduto.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(73, 229);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(104, 24);
            this.cbStatus.TabIndex = 3;
            this.cbStatus.Text = "À vista";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.Location = new System.Drawing.Point(70, 43);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(118, 17);
            this.lbNomeProduto.TabIndex = 4;
            this.lbNomeProduto.Text = "Nome do produto";
            // 
            // lbValorProduto
            // 
            this.lbValorProduto.AutoSize = true;
            this.lbValorProduto.Location = new System.Drawing.Point(70, 133);
            this.lbValorProduto.Name = "lbValorProduto";
            this.lbValorProduto.Size = new System.Drawing.Size(114, 17);
            this.lbValorProduto.TabIndex = 5;
            this.lbValorProduto.Text = "Valor do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marcar se pagamento à vista";
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbValorProduto);
            this.Controls.Add(this.lbNomeProduto);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Exercicio2";
            this.Text = "Exercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.Label lbValorProduto;
        private System.Windows.Forms.Label label3;
    }
}