namespace WindowsFormsProiect
{
    partial class FormInitial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInitial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIesire = new System.Windows.Forms.Button();
            this.btnMedici = new System.Windows.Forms.Button();
            this.btnPacienti = new System.Windows.Forms.Button();
            this.btnRetete = new System.Windows.Forms.Button();
            this.btnStatistici = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIesire);
            this.panel1.Controls.Add(this.btnMedici);
            this.panel1.Controls.Add(this.btnPacienti);
            this.panel1.Controls.Add(this.btnRetete);
            this.panel1.Controls.Add(this.btnStatistici);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 624);
            this.panel1.TabIndex = 0;
            // 
            // btnIesire
            // 
            this.btnIesire.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIesire.FlatAppearance.BorderSize = 0;
            this.btnIesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIesire.Image = ((System.Drawing.Image)(resources.GetObject("btnIesire.Image")));
            this.btnIesire.Location = new System.Drawing.Point(0, 506);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(173, 118);
            this.btnIesire.TabIndex = 7;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // btnMedici
            // 
            this.btnMedici.FlatAppearance.BorderSize = 0;
            this.btnMedici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedici.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedici.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMedici.Image = ((System.Drawing.Image)(resources.GetObject("btnMedici.Image")));
            this.btnMedici.Location = new System.Drawing.Point(0, -35);
            this.btnMedici.Name = "btnMedici";
            this.btnMedici.Size = new System.Drawing.Size(173, 156);
            this.btnMedici.TabIndex = 6;
            this.btnMedici.Text = "Medici";
            this.btnMedici.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMedici.UseVisualStyleBackColor = true;
            this.btnMedici.Click += new System.EventHandler(this.btnMedici_Click);
            // 
            // btnPacienti
            // 
            this.btnPacienti.FlatAppearance.BorderSize = 0;
            this.btnPacienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacienti.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacienti.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPacienti.Image = ((System.Drawing.Image)(resources.GetObject("btnPacienti.Image")));
            this.btnPacienti.Location = new System.Drawing.Point(3, 118);
            this.btnPacienti.Name = "btnPacienti";
            this.btnPacienti.Size = new System.Drawing.Size(173, 128);
            this.btnPacienti.TabIndex = 5;
            this.btnPacienti.Text = "Pacienti";
            this.btnPacienti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPacienti.UseVisualStyleBackColor = true;
            this.btnPacienti.Click += new System.EventHandler(this.btnPacienti_Click);
            // 
            // btnRetete
            // 
            this.btnRetete.FlatAppearance.BorderSize = 0;
            this.btnRetete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetete.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRetete.Image = ((System.Drawing.Image)(resources.GetObject("btnRetete.Image")));
            this.btnRetete.Location = new System.Drawing.Point(0, 238);
            this.btnRetete.Name = "btnRetete";
            this.btnRetete.Size = new System.Drawing.Size(176, 140);
            this.btnRetete.TabIndex = 4;
            this.btnRetete.Text = "Retete";
            this.btnRetete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetete.UseVisualStyleBackColor = true;
            this.btnRetete.Click += new System.EventHandler(this.btnRetete_Click);
            // 
            // btnStatistici
            // 
            this.btnStatistici.FlatAppearance.BorderSize = 0;
            this.btnStatistici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistici.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistici.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStatistici.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistici.Image")));
            this.btnStatistici.Location = new System.Drawing.Point(3, 373);
            this.btnStatistici.Name = "btnStatistici";
            this.btnStatistici.Size = new System.Drawing.Size(173, 136);
            this.btnStatistici.TabIndex = 3;
            this.btnStatistici.Text = "Statistici";
            this.btnStatistici.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStatistici.UseVisualStyleBackColor = true;
            this.btnStatistici.Click += new System.EventHandler(this.btnStatistici_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(318, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to\r\n GT Derma Clinic";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(13)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(946, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormInitial";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMedici;
        private System.Windows.Forms.Button btnPacienti;
        private System.Windows.Forms.Button btnRetete;
        private System.Windows.Forms.Button btnStatistici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIesire;
    }
}

