namespace WindowsFormsProiect
{
    partial class FormModificarePacient
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbLocalitate = new System.Windows.Forms.TextBox();
            this.lbLocalitate = new System.Windows.Forms.Label();
            this.rbMasculin = new System.Windows.Forms.RadioButton();
            this.rbFeminin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCnp = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnGolire = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCnp = new System.Windows.Forms.ErrorProvider(this.components);
            this.epVarsta = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCnp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVarsta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbVarsta);
            this.panel2.Controls.Add(this.tbLocalitate);
            this.panel2.Controls.Add(this.lbLocalitate);
            this.panel2.Controls.Add(this.rbMasculin);
            this.panel2.Controls.Add(this.rbFeminin);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbCnp);
            this.panel2.Controls.Add(this.tbPrenume);
            this.panel2.Controls.Add(this.tbNume);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 300);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Varsta";
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(103, 194);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(147, 22);
            this.tbVarsta.TabIndex = 12;
            this.tbVarsta.Validating += new System.ComponentModel.CancelEventHandler(this.tbVarsta_Validating);
            this.tbVarsta.Validated += new System.EventHandler(this.tbVarsta_Validated);
            // 
            // tbLocalitate
            // 
            this.tbLocalitate.Location = new System.Drawing.Point(40, 266);
            this.tbLocalitate.Name = "tbLocalitate";
            this.tbLocalitate.Size = new System.Drawing.Size(368, 22);
            this.tbLocalitate.TabIndex = 11;
            // 
            // lbLocalitate
            // 
            this.lbLocalitate.AutoSize = true;
            this.lbLocalitate.Location = new System.Drawing.Point(37, 234);
            this.lbLocalitate.Name = "lbLocalitate";
            this.lbLocalitate.Size = new System.Drawing.Size(69, 17);
            this.lbLocalitate.TabIndex = 10;
            this.lbLocalitate.Text = "Localitate";
            // 
            // rbMasculin
            // 
            this.rbMasculin.AutoSize = true;
            this.rbMasculin.Location = new System.Drawing.Point(336, 34);
            this.rbMasculin.Name = "rbMasculin";
            this.rbMasculin.Size = new System.Drawing.Size(84, 21);
            this.rbMasculin.TabIndex = 9;
            this.rbMasculin.TabStop = true;
            this.rbMasculin.Text = "Masculin";
            this.rbMasculin.UseVisualStyleBackColor = true;
            // 
            // rbFeminin
            // 
            this.rbFeminin.AutoSize = true;
            this.rbFeminin.Location = new System.Drawing.Point(336, 7);
            this.rbFeminin.Name = "rbFeminin";
            this.rbFeminin.Size = new System.Drawing.Size(78, 21);
            this.rbFeminin.TabIndex = 2;
            this.rbFeminin.TabStop = true;
            this.rbFeminin.Text = "Feminin";
            this.rbFeminin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sex";
            // 
            // tbCnp
            // 
            this.tbCnp.Location = new System.Drawing.Point(101, 82);
            this.tbCnp.Name = "tbCnp";
            this.tbCnp.Size = new System.Drawing.Size(149, 22);
            this.tbCnp.TabIndex = 7;
            this.tbCnp.Validating += new System.ComponentModel.CancelEventHandler(this.tbCnp_Validating);
            this.tbCnp.Validated += new System.EventHandler(this.tbCnp_Validated);
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(103, 42);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(147, 22);
            this.tbPrenume.TabIndex = 6;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(103, 6);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(147, 22);
            this.tbNume.TabIndex = 5;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data nastere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cnp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(40, 151);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(143)))), ((int)(((byte)(190)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 67);
            this.panel3.TabIndex = 1;
            
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(12, 390);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(150, 49);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnGolire
            // 
            this.btnGolire.Location = new System.Drawing.Point(191, 390);
            this.btnGolire.Name = "btnGolire";
            this.btnGolire.Size = new System.Drawing.Size(139, 49);
            this.btnGolire.TabIndex = 3;
            this.btnGolire.Text = "Golire formular";
            this.btnGolire.UseVisualStyleBackColor = true;
            this.btnGolire.Click += new System.EventHandler(this.btnGolire_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(362, 390);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(139, 49);
            this.btnRenunta.TabIndex = 4;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // epNume
            // 
            this.epNume.ContainerControl = this;
            // 
            // epCnp
            // 
            this.epCnp.ContainerControl = this;
            // 
            // epVarsta
            // 
            this.epVarsta.ContainerControl = this;
            // 
            // FormModificarePacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(143)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(513, 457);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnGolire);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FormModificarePacient";
            this.Text = "FormModificarePacient ";
            this.Load += new System.EventHandler(this.FormModificarePacient_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCnp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVarsta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbMasculin;
        private System.Windows.Forms.RadioButton rbFeminin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCnp;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbLocalitate;
        private System.Windows.Forms.Label lbLocalitate;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnGolire;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.ErrorProvider epCnp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.ErrorProvider epVarsta;
    }
}