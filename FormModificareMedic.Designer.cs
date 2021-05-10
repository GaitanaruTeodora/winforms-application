namespace WindowsFormsProiect
{
    partial class FormModificareMedic
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
            this.lbNume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.tbParafa = new System.Windows.Forms.TextBox();
            this.lbParafa = new System.Windows.Forms.Label();
            this.lbGrad = new System.Windows.Forms.Label();
            this.comboGrad = new System.Windows.Forms.ComboBox();
            this.lbSpecialitate = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnGolire = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.comboSpecialitate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(30, 74);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(45, 17);
            this.lbNume.TabIndex = 0;
            this.lbNume.Text = "Nume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(33, 94);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(219, 22);
            this.tbNume.TabIndex = 1;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(33, 150);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(219, 22);
            this.tbPrenume.TabIndex = 3;
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Location = new System.Drawing.Point(30, 130);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(65, 17);
            this.lbPrenume.TabIndex = 2;
            this.lbPrenume.Text = "Prenume";
            // 
            // tbParafa
            // 
            this.tbParafa.Location = new System.Drawing.Point(33, 212);
            this.tbParafa.Name = "tbParafa";
            this.tbParafa.Size = new System.Drawing.Size(219, 22);
            this.tbParafa.TabIndex = 5;
            // 
            // lbParafa
            // 
            this.lbParafa.AutoSize = true;
            this.lbParafa.Location = new System.Drawing.Point(30, 192);
            this.lbParafa.Name = "lbParafa";
            this.lbParafa.Size = new System.Drawing.Size(50, 17);
            this.lbParafa.TabIndex = 4;
            this.lbParafa.Text = "Parafa";
            // 
            // lbGrad
            // 
            this.lbGrad.AutoSize = true;
            this.lbGrad.Location = new System.Drawing.Point(30, 259);
            this.lbGrad.Name = "lbGrad";
            this.lbGrad.Size = new System.Drawing.Size(40, 17);
            this.lbGrad.TabIndex = 6;
            this.lbGrad.Text = "Grad";
            // 
            // comboGrad
            // 
            this.comboGrad.FormattingEnabled = true;
            this.comboGrad.Items.AddRange(new object[] {
            "Medic rezident",
            "Medic specialist",
            "Medic primar"});
            this.comboGrad.Location = new System.Drawing.Point(33, 289);
            this.comboGrad.Name = "comboGrad";
            this.comboGrad.Size = new System.Drawing.Size(219, 24);
            this.comboGrad.TabIndex = 7;
            // 
            // lbSpecialitate
            // 
            this.lbSpecialitate.AutoSize = true;
            this.lbSpecialitate.Location = new System.Drawing.Point(30, 340);
            this.lbSpecialitate.Name = "lbSpecialitate";
            this.lbSpecialitate.Size = new System.Drawing.Size(81, 17);
            this.lbSpecialitate.TabIndex = 8;
            this.lbSpecialitate.Text = "Specialitate";
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(32)))), ((int)(((byte)(82)))));
            this.btnSalvare.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvare.Location = new System.Drawing.Point(33, 409);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(100, 48);
            this.btnSalvare.TabIndex = 10;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = false;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnGolire
            // 
            this.btnGolire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(32)))), ((int)(((byte)(82)))));
            this.btnGolire.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGolire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGolire.Location = new System.Drawing.Point(152, 409);
            this.btnGolire.Name = "btnGolire";
            this.btnGolire.Size = new System.Drawing.Size(100, 48);
            this.btnGolire.TabIndex = 11;
            this.btnGolire.Text = "Golire formular";
            this.btnGolire.UseVisualStyleBackColor = false;
            this.btnGolire.Click += new System.EventHandler(this.btnGolire_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(32)))), ((int)(((byte)(82)))));
            this.btnRenunta.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenunta.Location = new System.Drawing.Point(275, 409);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(106, 48);
            this.btnRenunta.TabIndex = 12;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = false;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // comboSpecialitate
            // 
            this.comboSpecialitate.FormattingEnabled = true;
            this.comboSpecialitate.Items.AddRange(new object[] {
            "Medic rezident",
            "Medic specialist",
            "Medic primar"});
            this.comboSpecialitate.Location = new System.Drawing.Point(33, 360);
            this.comboSpecialitate.Name = "comboSpecialitate";
            this.comboSpecialitate.Size = new System.Drawing.Size(219, 24);
            this.comboSpecialitate.TabIndex = 13;
            // 
            // FormModificareMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(143)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(396, 482);
            this.Controls.Add(this.comboSpecialitate);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnGolire);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.lbSpecialitate);
            this.Controls.Add(this.comboGrad);
            this.Controls.Add(this.lbGrad);
            this.Controls.Add(this.tbParafa);
            this.Controls.Add(this.lbParafa);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.lbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lbNume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModificareMedic";
            this.Text = "FormAdaugareMedic";
            this.Load += new System.EventHandler(this.FormModificareMedic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.TextBox tbParafa;
        private System.Windows.Forms.Label lbParafa;
        private System.Windows.Forms.Label lbGrad;
        private System.Windows.Forms.ComboBox comboGrad;
        private System.Windows.Forms.Label lbSpecialitate;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnGolire;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.ComboBox comboSpecialitate;
    }
}