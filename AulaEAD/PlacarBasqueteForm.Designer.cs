namespace AulaEAD
{
    partial class PlacarBasqueteForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlacarBasqueteForm));
            this.btn_1_TimeA = new System.Windows.Forms.Button();
            this.btn_2_TimeA = new System.Windows.Forms.Button();
            this.btn_3_TimeA = new System.Windows.Forms.Button();
            this.btn_DrementTimeA = new System.Windows.Forms.Button();
            this.btn_DrementTimeB = new System.Windows.Forms.Button();
            this.btn_3_TimeB = new System.Windows.Forms.Button();
            this.btn_2_TimeB = new System.Windows.Forms.Button();
            this.btn_1_TimeB = new System.Windows.Forms.Button();
            this.lbTimeA = new System.Windows.Forms.Label();
            this.lbTimeB = new System.Windows.Forms.Label();
            this.btnNextTimeA = new System.Windows.Forms.Button();
            this.btnPreviousTimeA = new System.Windows.Forms.Button();
            this.btnPreviousTimeB = new System.Windows.Forms.Button();
            this.btnNextTimeB = new System.Windows.Forms.Button();
            this.pbTimeA = new System.Windows.Forms.PictureBox();
            this.pbTimeB = new System.Windows.Forms.PictureBox();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.lbTempo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeB)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_1_TimeA
            // 
            this.btn_1_TimeA.Location = new System.Drawing.Point(152, 473);
            this.btn_1_TimeA.Name = "btn_1_TimeA";
            this.btn_1_TimeA.Size = new System.Drawing.Size(75, 23);
            this.btn_1_TimeA.TabIndex = 0;
            this.btn_1_TimeA.Text = "Um Ponto";
            this.btn_1_TimeA.UseVisualStyleBackColor = true;
            this.btn_1_TimeA.Click += new System.EventHandler(this.btn_1_TimeA_Click);
            // 
            // btn_2_TimeA
            // 
            this.btn_2_TimeA.Location = new System.Drawing.Point(152, 502);
            this.btn_2_TimeA.Name = "btn_2_TimeA";
            this.btn_2_TimeA.Size = new System.Drawing.Size(75, 23);
            this.btn_2_TimeA.TabIndex = 1;
            this.btn_2_TimeA.Text = "Dois Pontos";
            this.btn_2_TimeA.UseVisualStyleBackColor = true;
            this.btn_2_TimeA.Click += new System.EventHandler(this.btn_2_TimeA_Click);
            // 
            // btn_3_TimeA
            // 
            this.btn_3_TimeA.Location = new System.Drawing.Point(152, 531);
            this.btn_3_TimeA.Name = "btn_3_TimeA";
            this.btn_3_TimeA.Size = new System.Drawing.Size(75, 23);
            this.btn_3_TimeA.TabIndex = 2;
            this.btn_3_TimeA.Text = "Tres Pontos";
            this.btn_3_TimeA.UseVisualStyleBackColor = true;
            this.btn_3_TimeA.Click += new System.EventHandler(this.btn_3_TimeA_Click);
            // 
            // btn_DrementTimeA
            // 
            this.btn_DrementTimeA.BackColor = System.Drawing.Color.Coral;
            this.btn_DrementTimeA.Location = new System.Drawing.Point(142, 560);
            this.btn_DrementTimeA.Name = "btn_DrementTimeA";
            this.btn_DrementTimeA.Size = new System.Drawing.Size(94, 23);
            this.btn_DrementTimeA.TabIndex = 3;
            this.btn_DrementTimeA.Text = "Decrementar";
            this.btn_DrementTimeA.UseVisualStyleBackColor = false;
            this.btn_DrementTimeA.Click += new System.EventHandler(this.btn_DrementTimeA_Click);
            // 
            // btn_DrementTimeB
            // 
            this.btn_DrementTimeB.BackColor = System.Drawing.Color.Coral;
            this.btn_DrementTimeB.Location = new System.Drawing.Point(766, 560);
            this.btn_DrementTimeB.Name = "btn_DrementTimeB";
            this.btn_DrementTimeB.Size = new System.Drawing.Size(94, 23);
            this.btn_DrementTimeB.TabIndex = 7;
            this.btn_DrementTimeB.Text = "Decrementar";
            this.btn_DrementTimeB.UseVisualStyleBackColor = false;
            this.btn_DrementTimeB.Click += new System.EventHandler(this.btn_DrementTimeB_Click);
            // 
            // btn_3_TimeB
            // 
            this.btn_3_TimeB.Location = new System.Drawing.Point(776, 531);
            this.btn_3_TimeB.Name = "btn_3_TimeB";
            this.btn_3_TimeB.Size = new System.Drawing.Size(75, 23);
            this.btn_3_TimeB.TabIndex = 6;
            this.btn_3_TimeB.Text = "Tres Pontos";
            this.btn_3_TimeB.UseVisualStyleBackColor = true;
            this.btn_3_TimeB.Click += new System.EventHandler(this.btn_3_TimeB_Click);
            // 
            // btn_2_TimeB
            // 
            this.btn_2_TimeB.Location = new System.Drawing.Point(776, 502);
            this.btn_2_TimeB.Name = "btn_2_TimeB";
            this.btn_2_TimeB.Size = new System.Drawing.Size(75, 23);
            this.btn_2_TimeB.TabIndex = 5;
            this.btn_2_TimeB.Text = "Dois Pontos";
            this.btn_2_TimeB.UseVisualStyleBackColor = true;
            this.btn_2_TimeB.Click += new System.EventHandler(this.btn_2_TimeB_Click);
            // 
            // btn_1_TimeB
            // 
            this.btn_1_TimeB.Location = new System.Drawing.Point(776, 473);
            this.btn_1_TimeB.Name = "btn_1_TimeB";
            this.btn_1_TimeB.Size = new System.Drawing.Size(75, 23);
            this.btn_1_TimeB.TabIndex = 4;
            this.btn_1_TimeB.Text = "Um Ponto";
            this.btn_1_TimeB.UseVisualStyleBackColor = true;
            this.btn_1_TimeB.Click += new System.EventHandler(this.btn_1_TimeB_Click);
            // 
            // lbTimeA
            // 
            this.lbTimeA.AutoSize = true;
            this.lbTimeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeA.Location = new System.Drawing.Point(174, 400);
            this.lbTimeA.Name = "lbTimeA";
            this.lbTimeA.Size = new System.Drawing.Size(36, 39);
            this.lbTimeA.TabIndex = 8;
            this.lbTimeA.Text = "0";
            // 
            // lbTimeB
            // 
            this.lbTimeB.AutoSize = true;
            this.lbTimeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeB.Location = new System.Drawing.Point(796, 400);
            this.lbTimeB.Name = "lbTimeB";
            this.lbTimeB.Size = new System.Drawing.Size(36, 39);
            this.lbTimeB.TabIndex = 9;
            this.lbTimeB.Text = "0";
            // 
            // btnNextTimeA
            // 
            this.btnNextTimeA.Location = new System.Drawing.Point(389, 141);
            this.btnNextTimeA.Name = "btnNextTimeA";
            this.btnNextTimeA.Size = new System.Drawing.Size(75, 23);
            this.btnNextTimeA.TabIndex = 12;
            this.btnNextTimeA.Text = "/\\";
            this.btnNextTimeA.UseVisualStyleBackColor = true;
            this.btnNextTimeA.Click += new System.EventHandler(this.btnNextTimeA_Click);
            // 
            // btnPreviousTimeA
            // 
            this.btnPreviousTimeA.Location = new System.Drawing.Point(389, 208);
            this.btnPreviousTimeA.Name = "btnPreviousTimeA";
            this.btnPreviousTimeA.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousTimeA.TabIndex = 13;
            this.btnPreviousTimeA.Text = "\\/";
            this.btnPreviousTimeA.UseVisualStyleBackColor = true;
            this.btnPreviousTimeA.Click += new System.EventHandler(this.btnPreviousTimeA_Click);
            // 
            // btnPreviousTimeB
            // 
            this.btnPreviousTimeB.Location = new System.Drawing.Point(540, 208);
            this.btnPreviousTimeB.Name = "btnPreviousTimeB";
            this.btnPreviousTimeB.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousTimeB.TabIndex = 15;
            this.btnPreviousTimeB.Text = "\\/";
            this.btnPreviousTimeB.UseVisualStyleBackColor = true;
            this.btnPreviousTimeB.Click += new System.EventHandler(this.btnPreviousTimeB_Click);
            // 
            // btnNextTimeB
            // 
            this.btnNextTimeB.Location = new System.Drawing.Point(540, 141);
            this.btnNextTimeB.Name = "btnNextTimeB";
            this.btnNextTimeB.Size = new System.Drawing.Size(75, 23);
            this.btnNextTimeB.TabIndex = 14;
            this.btnNextTimeB.Text = "/\\";
            this.btnNextTimeB.UseVisualStyleBackColor = true;
            this.btnNextTimeB.Click += new System.EventHandler(this.btnNextTimeB_Click);
            // 
            // pbTimeA
            // 
            this.pbTimeA.Image = ((System.Drawing.Image)(resources.GetObject("pbTimeA.Image")));
            this.pbTimeA.Location = new System.Drawing.Point(12, 12);
            this.pbTimeA.Name = "pbTimeA";
            this.pbTimeA.Size = new System.Drawing.Size(371, 361);
            this.pbTimeA.TabIndex = 16;
            this.pbTimeA.TabStop = false;
            // 
            // pbTimeB
            // 
            this.pbTimeB.Image = ((System.Drawing.Image)(resources.GetObject("pbTimeB.Image")));
            this.pbTimeB.Location = new System.Drawing.Point(620, 12);
            this.pbTimeB.Name = "pbTimeB";
            this.pbTimeB.Size = new System.Drawing.Size(376, 361);
            this.pbTimeB.TabIndex = 17;
            this.pbTimeB.TabStop = false;
            // 
            // tempo
            // 
            this.tempo.Interval = 1000;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // lbTempo
            // 
            this.lbTempo.AutoSize = true;
            this.lbTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempo.Location = new System.Drawing.Point(445, 327);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(119, 46);
            this.lbTempo.TabIndex = 18;
            this.lbTempo.Text = "12:00";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(467, 459);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // PlacarBasqueteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTempo);
            this.Controls.Add(this.pbTimeB);
            this.Controls.Add(this.pbTimeA);
            this.Controls.Add(this.btnPreviousTimeB);
            this.Controls.Add(this.btnNextTimeB);
            this.Controls.Add(this.btnPreviousTimeA);
            this.Controls.Add(this.btnNextTimeA);
            this.Controls.Add(this.lbTimeB);
            this.Controls.Add(this.lbTimeA);
            this.Controls.Add(this.btn_DrementTimeB);
            this.Controls.Add(this.btn_3_TimeB);
            this.Controls.Add(this.btn_2_TimeB);
            this.Controls.Add(this.btn_1_TimeB);
            this.Controls.Add(this.btn_DrementTimeA);
            this.Controls.Add(this.btn_3_TimeA);
            this.Controls.Add(this.btn_2_TimeA);
            this.Controls.Add(this.btn_1_TimeA);
            this.Name = "PlacarBasqueteForm";
            this.Text = "PlacarBasqueteForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1_TimeA;
        private System.Windows.Forms.Button btn_2_TimeA;
        private System.Windows.Forms.Button btn_3_TimeA;
        private System.Windows.Forms.Button btn_DrementTimeA;
        private System.Windows.Forms.Button btn_DrementTimeB;
        private System.Windows.Forms.Button btn_3_TimeB;
        private System.Windows.Forms.Button btn_2_TimeB;
        private System.Windows.Forms.Button btn_1_TimeB;
        private System.Windows.Forms.Label lbTimeA;
        private System.Windows.Forms.Label lbTimeB;
        private System.Windows.Forms.Button btnNextTimeA;
        private System.Windows.Forms.Button btnPreviousTimeA;
        private System.Windows.Forms.Button btnPreviousTimeB;
        private System.Windows.Forms.Button btnNextTimeB;
        private System.Windows.Forms.PictureBox pbTimeA;
        private System.Windows.Forms.PictureBox pbTimeB;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.Button btnStart;
    }
}