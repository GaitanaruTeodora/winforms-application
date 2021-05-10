namespace WindowsFormsProiect
{
    partial class FormMedici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedici));
            this.listViewMedic = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Parafa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specialitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmMedici = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnGolireLista = new System.Windows.Forms.Button();
            this.msMedici = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSpecialitate = new System.Windows.Forms.Label();
            this.comboGrad = new System.Windows.Forms.ComboBox();
            this.lbGrad = new System.Windows.Forms.Label();
            this.tbParafa = new System.Windows.Forms.TextBox();
            this.lbParafa = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lbNume = new System.Windows.Forms.Label();
            this.comboSpecialitate = new System.Windows.Forms.ComboBox();
            this.cmMedici.SuspendLayout();
            this.msMedici.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMedic
            // 
            this.listViewMedic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.Parafa,
            this.Grad,
            this.Specialitate});
            this.listViewMedic.ContextMenuStrip = this.cmMedici;
            this.listViewMedic.FullRowSelect = true;
            this.listViewMedic.GridLines = true;
            this.listViewMedic.HideSelection = false;
            this.listViewMedic.Location = new System.Drawing.Point(375, 61);
            this.listViewMedic.Name = "listViewMedic";
            this.listViewMedic.Size = new System.Drawing.Size(407, 276);
            this.listViewMedic.TabIndex = 1;
            this.listViewMedic.UseCompatibleStateImageBehavior = false;
            this.listViewMedic.View = System.Windows.Forms.View.Details;
            this.listViewMedic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewMedic_MouseClick);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 66;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 72;
            // 
            // Parafa
            // 
            this.Parafa.Text = "Parafa";
            this.Parafa.Width = 71;
            // 
            // Grad
            // 
            this.Grad.Text = "Grad";
            this.Grad.Width = 77;
            // 
            // Specialitate
            // 
            this.Specialitate.Text = "Specialitate";
            this.Specialitate.Width = 231;
            // 
            // cmMedici
            // 
            this.cmMedici.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmMedici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem1,
            this.deserializareToolStripMenuItem1,
            this.modificareTSM,
            this.stergereTSM});
            this.cmMedici.Name = "cmMedici";
            this.cmMedici.Size = new System.Drawing.Size(165, 100);
            // 
            // serializareToolStripMenuItem1
            // 
            this.serializareToolStripMenuItem1.Name = "serializareToolStripMenuItem1";
            this.serializareToolStripMenuItem1.Size = new System.Drawing.Size(164, 24);
            this.serializareToolStripMenuItem1.Text = "Serializare";
            this.serializareToolStripMenuItem1.Click += new System.EventHandler(this.serializareToolStripMenuItem1_Click);
            // 
            // deserializareToolStripMenuItem1
            // 
            this.deserializareToolStripMenuItem1.Name = "deserializareToolStripMenuItem1";
            this.deserializareToolStripMenuItem1.Size = new System.Drawing.Size(164, 24);
            this.deserializareToolStripMenuItem1.Text = "Deserializare";
            this.deserializareToolStripMenuItem1.Click += new System.EventHandler(this.deserializareToolStripMenuItem1_Click);
            // 
            // modificareTSM
            // 
            this.modificareTSM.Name = "modificareTSM";
            this.modificareTSM.Size = new System.Drawing.Size(164, 24);
            this.modificareTSM.Text = "Modificare";
            this.modificareTSM.Click += new System.EventHandler(this.modificareTSM_Click);
            // 
            // stergereTSM
            // 
            this.stergereTSM.Name = "stergereTSM";
            this.stergereTSM.Size = new System.Drawing.Size(164, 24);
            this.stergereTSM.Text = "Stergere";
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnAdaugare.Location = new System.Drawing.Point(37, 369);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(116, 41);
            this.btnAdaugare.TabIndex = 2;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnAfisare.Location = new System.Drawing.Point(493, 369);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(106, 41);
            this.btnAfisare.TabIndex = 3;
            this.btnAfisare.Text = "Afisare lista";
            this.btnAfisare.UseVisualStyleBackColor = false;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnGolireLista
            // 
            this.btnGolireLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnGolireLista.Location = new System.Drawing.Point(647, 369);
            this.btnGolireLista.Name = "btnGolireLista";
            this.btnGolireLista.Size = new System.Drawing.Size(112, 41);
            this.btnGolireLista.TabIndex = 4;
            this.btnGolireLista.Text = "Golire lista";
            this.btnGolireLista.UseVisualStyleBackColor = false;
            this.btnGolireLista.Click += new System.EventHandler(this.btnGolireLista_Click);
            // 
            // msMedici
            // 
            this.msMedici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.msMedici.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMedici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.optiuniToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.msMedici.Location = new System.Drawing.Point(0, 0);
            this.msMedici.Name = "msMedici";
            this.msMedici.Size = new System.Drawing.Size(824, 31);
            this.msMedici.TabIndex = 7;
            this.msMedici.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // optiuniToolStripMenuItem
            // 
            this.optiuniToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optiuniToolStripMenuItem.Name = "optiuniToolStripMenuItem";
            this.optiuniToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
            this.optiuniToolStripMenuItem.Text = "Optiuni";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(58, 27);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // lbSpecialitate
            // 
            this.lbSpecialitate.AutoSize = true;
            this.lbSpecialitate.Location = new System.Drawing.Point(34, 295);
            this.lbSpecialitate.Name = "lbSpecialitate";
            this.lbSpecialitate.Size = new System.Drawing.Size(81, 17);
            this.lbSpecialitate.TabIndex = 18;
            this.lbSpecialitate.Text = "Specialitate";
            // 
            // comboGrad
            // 
            this.comboGrad.FormattingEnabled = true;
            this.comboGrad.Items.AddRange(new object[] {
            "Medic rezident",
            "Medic specialist",
            "Medic primar"});
            this.comboGrad.Location = new System.Drawing.Point(37, 265);
            this.comboGrad.Name = "comboGrad";
            this.comboGrad.Size = new System.Drawing.Size(219, 24);
            this.comboGrad.TabIndex = 17;
            // 
            // lbGrad
            // 
            this.lbGrad.AutoSize = true;
            this.lbGrad.Location = new System.Drawing.Point(34, 235);
            this.lbGrad.Name = "lbGrad";
            this.lbGrad.Size = new System.Drawing.Size(40, 17);
            this.lbGrad.TabIndex = 16;
            this.lbGrad.Text = "Grad";
            // 
            // tbParafa
            // 
            this.tbParafa.Location = new System.Drawing.Point(37, 206);
            this.tbParafa.Name = "tbParafa";
            this.tbParafa.Size = new System.Drawing.Size(219, 22);
            this.tbParafa.TabIndex = 15;
            // 
            // lbParafa
            // 
            this.lbParafa.AutoSize = true;
            this.lbParafa.Location = new System.Drawing.Point(34, 186);
            this.lbParafa.Name = "lbParafa";
            this.lbParafa.Size = new System.Drawing.Size(50, 17);
            this.lbParafa.TabIndex = 14;
            this.lbParafa.Text = "Parafa";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(37, 144);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(219, 22);
            this.tbPrenume.TabIndex = 13;
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Location = new System.Drawing.Point(34, 124);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(65, 17);
            this.lbPrenume.TabIndex = 12;
            this.lbPrenume.Text = "Prenume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(37, 88);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(219, 22);
            this.tbNume.TabIndex = 11;
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(34, 68);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(45, 17);
            this.lbNume.TabIndex = 10;
            this.lbNume.Text = "Nume";
            // 
            // comboSpecialitate
            // 
            this.comboSpecialitate.FormattingEnabled = true;
            this.comboSpecialitate.Items.AddRange(new object[] {
            "Dermato-venerolog",
            "Dermato-cosmetolog",
            "Dermato-triholog"});
            this.comboSpecialitate.Location = new System.Drawing.Point(37, 324);
            this.comboSpecialitate.Name = "comboSpecialitate";
            this.comboSpecialitate.Size = new System.Drawing.Size(219, 24);
            this.comboSpecialitate.TabIndex = 19;
            // 
            // FormMedici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.comboSpecialitate);
            this.Controls.Add(this.lbSpecialitate);
            this.Controls.Add(this.comboGrad);
            this.Controls.Add(this.lbGrad);
            this.Controls.Add(this.tbParafa);
            this.Controls.Add(this.lbParafa);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.lbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.msMedici);
            this.Controls.Add(this.btnGolireLista);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.listViewMedic);
            this.Name = "FormMedici";
            this.cmMedici.ResumeLayout(false);
            this.msMedici.ResumeLayout(false);
            this.msMedici.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewMedic;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Parafa;
        private System.Windows.Forms.ColumnHeader Grad;
        private System.Windows.Forms.ColumnHeader Specialitate;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnGolireLista;
        private System.Windows.Forms.MenuStrip msMedici;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmMedici;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificareTSM;
        private System.Windows.Forms.Label lbSpecialitate;
        private System.Windows.Forms.ComboBox comboGrad;
        private System.Windows.Forms.Label lbGrad;
        private System.Windows.Forms.TextBox tbParafa;
        private System.Windows.Forms.Label lbParafa;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.ComboBox comboSpecialitate;
        private System.Windows.Forms.ToolStripMenuItem stergereTSM;
    }
}