namespace AulaEAD
{
    partial class VetorArrayList
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
            this.btnEvento = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvento
            // 
            this.btnEvento.Location = new System.Drawing.Point(23, 28);
            this.btnEvento.Name = "btnEvento";
            this.btnEvento.Size = new System.Drawing.Size(75, 23);
            this.btnEvento.TabIndex = 0;
            this.btnEvento.Text = "-";
            this.btnEvento.UseVisualStyleBackColor = true;
            this.btnEvento.Click += new System.EventHandler(this.btnEvento_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(178, 27);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 1;
            this.btnLista.Text = "Listas";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // VetorArrayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 232);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnEvento);
            this.Name = "VetorArrayList";
            this.Text = "VetorArrayList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvento;
        private System.Windows.Forms.Button btnLista;
    }
}