namespace ExerciciosExtras
{
    partial class Ex2_LacoRepeticao
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
            this.lbEntreComOValor = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtEntradaValor = new System.Windows.Forms.TextBox();
            this.dataGridValores = new System.Windows.Forms.DataGridView();
            this.cNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDivide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEntreComOValor
            // 
            this.lbEntreComOValor.AutoSize = true;
            this.lbEntreComOValor.Location = new System.Drawing.Point(242, 45);
            this.lbEntreComOValor.Name = "lbEntreComOValor";
            this.lbEntreComOValor.Size = new System.Drawing.Size(90, 13);
            this.lbEntreComOValor.TabIndex = 5;
            this.lbEntreComOValor.Text = "Entre com o valor";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(250, 94);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtEntradaValor
            // 
            this.txtEntradaValor.Location = new System.Drawing.Point(238, 68);
            this.txtEntradaValor.Name = "txtEntradaValor";
            this.txtEntradaValor.Size = new System.Drawing.Size(100, 20);
            this.txtEntradaValor.TabIndex = 3;
            // 
            // dataGridValores
            // 
            this.dataGridValores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNum,
            this.cDivide});
            this.dataGridValores.Location = new System.Drawing.Point(12, 136);
            this.dataGridValores.Name = "dataGridValores";
            this.dataGridValores.RowHeadersVisible = false;
            this.dataGridValores.Size = new System.Drawing.Size(551, 215);
            this.dataGridValores.TabIndex = 6;
            // 
            // cNum
            // 
            this.cNum.HeaderText = "Num";
            this.cNum.Name = "cNum";
            this.cNum.ReadOnly = true;
            this.cNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNum.Width = 35;
            // 
            // cDivide
            // 
            this.cDivide.HeaderText = "É divisivel";
            this.cDivide.Name = "cDivide";
            this.cDivide.ReadOnly = true;
            this.cDivide.Width = 250;
            // 
            // Ex2_LacoRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 363);
            this.Controls.Add(this.dataGridValores);
            this.Controls.Add(this.lbEntreComOValor);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtEntradaValor);
            this.Name = "Ex2_LacoRepeticao";
            this.Text = "Ex2_LacoRepeticao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEntreComOValor;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtEntradaValor;
        private System.Windows.Forms.DataGridView dataGridValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDivide;
    }
}