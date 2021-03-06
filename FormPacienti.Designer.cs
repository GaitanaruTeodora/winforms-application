namespace WindowsFormsProiect
{
    partial class FormPacienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacienti));
            this.lvPacienti = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cnp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Varsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Localitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnGolireLista = new System.Windows.Forms.Button();
            this.msPacienti = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializareBinara = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializareBinara = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializareXML = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializareXML = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGolire = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.tbLocalitate = new System.Windows.Forms.TextBox();
            this.lbLocalitate = new System.Windows.Forms.Label();
            this.rbMasculin = new System.Windows.Forms.RadioButton();
            this.rbFeminin = new System.Windows.Forms.RadioButton();
            this.lbSex = new System.Windows.Forms.Label();
            this.tbCnp = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.lbDataN = new System.Windows.Forms.Label();
            this.lbCnp = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.dateTimePickerDataN = new System.Windows.Forms.DateTimePicker();
            this.epPacienti = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmPacient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.lbVarsta = new System.Windows.Forms.Label();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.msPacienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPacienti)).BeginInit();
            this.cmPacient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
            this.SuspendLayout();
            // 
            // lvPacienti
            // 
            this.lvPacienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.Cnp,
            this.Sex,
            this.DataN,
            this.Varsta,
            this.Localitate});
            this.lvPacienti.FullRowSelect = true;
            this.lvPacienti.GridLines = true;
            this.lvPacienti.HideSelection = false;
            this.lvPacienti.Location = new System.Drawing.Point(359, 70);
            this.lvPacienti.Name = "lvPacienti";
            this.lvPacienti.Size = new System.Drawing.Size(599, 312);
            this.lvPacienti.TabIndex = 3;
            this.lvPacienti.UseCompatibleStateImageBehavior = false;
            this.lvPacienti.View = System.Windows.Forms.View.Details;
            this.lvPacienti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvPacienti_MouseClick);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 78;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 82;
            // 
            // Cnp
            // 
            this.Cnp.Text = "Cnp";
            this.Cnp.Width = 82;
            // 
            // Sex
            // 
            this.Sex.Text = "Sex";
            // 
            // DataN
            // 
            this.DataN.Text = "Data nastere";
            this.DataN.Width = 93;
            // 
            // Varsta
            // 
            this.Varsta.Text = "Varsta";
            // 
            // Localitate
            // 
            this.Localitate.Text = "Localitate";
            this.Localitate.Width = 103;
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnAfisare.Location = new System.Drawing.Point(688, 403);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(127, 38);
            this.btnAfisare.TabIndex = 5;
            this.btnAfisare.Text = "Afisare lista";
            this.btnAfisare.UseVisualStyleBackColor = false;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnGolireLista
            // 
            this.btnGolireLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnGolireLista.Location = new System.Drawing.Point(831, 403);
            this.btnGolireLista.Name = "btnGolireLista";
            this.btnGolireLista.Size = new System.Drawing.Size(127, 38);
            this.btnGolireLista.TabIndex = 6;
            this.btnGolireLista.Text = "Golire lista";
            this.btnGolireLista.UseVisualStyleBackColor = false;
            this.btnGolireLista.Click += new System.EventHandler(this.btnGolireLista_Click);
            // 
            // msPacienti
            // 
            this.msPacienti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.msPacienti.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPacienti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.optiuniToolStripMenuItem,
            this.serializareXMLToolStripMenuItem,
            this.btnPrint,
            this.fisierToolStripMenuItem});
            this.msPacienti.Location = new System.Drawing.Point(0, 0);
            this.msPacienti.Name = "msPacienti";
            this.msPacienti.Size = new System.Drawing.Size(970, 31);
            this.msPacienti.TabIndex = 8;
            this.msPacienti.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.homeToolStripMenuItem.Text = "&Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // optiuniToolStripMenuItem
            // 
            this.optiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializareBinara,
            this.btnDeserializareBinara});
            this.optiuniToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optiuniToolStripMenuItem.Name = "optiuniToolStripMenuItem";
            this.optiuniToolStripMenuItem.Size = new System.Drawing.Size(191, 27);
            this.optiuniToolStripMenuItem.Text = "Serializare Binara";
            // 
            // btnSerializareBinara
            // 
            this.btnSerializareBinara.Name = "btnSerializareBinara";
            this.btnSerializareBinara.Size = new System.Drawing.Size(216, 28);
            this.btnSerializareBinara.Text = "Serializare";
            this.btnSerializareBinara.Click += new System.EventHandler(this.serializareToolStripMenuItem1_Click);
            // 
            // btnDeserializareBinara
            // 
            this.btnDeserializareBinara.Name = "btnDeserializareBinara";
            this.btnDeserializareBinara.Size = new System.Drawing.Size(216, 28);
            this.btnDeserializareBinara.Text = "Deserializare";
            this.btnDeserializareBinara.Click += new System.EventHandler(this.deserializareToolStripMenuItem1_Click);
            // 
            // serializareXMLToolStripMenuItem
            // 
            this.serializareXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializareXML,
            this.btnDeserializareXML});
            this.serializareXMLToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serializareXMLToolStripMenuItem.Name = "serializareXMLToolStripMenuItem";
            this.serializareXMLToolStripMenuItem.Size = new System.Drawing.Size(172, 27);
            this.serializareXMLToolStripMenuItem.Text = "Serializare XML";
            // 
            // btnSerializareXML
            // 
            this.btnSerializareXML.Name = "btnSerializareXML";
            this.btnSerializareXML.Size = new System.Drawing.Size(205, 26);
            this.btnSerializareXML.Text = "Serializare XML";
            this.btnSerializareXML.Click += new System.EventHandler(this.btnSerializareXML_Click);
            // 
            // btnDeserializareXML
            // 
            this.btnDeserializareXML.Name = "btnDeserializareXML";
            this.btnDeserializareXML.Size = new System.Drawing.Size(205, 26);
            this.btnDeserializareXML.Text = "Deserializare XML";
            this.btnDeserializareXML.Click += new System.EventHandler(this.btnDeserializareXML_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(73, 27);
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.fisierToolStripMenuItem.Text = "Fisier";
            this.fisierToolStripMenuItem.Click += new System.EventHandler(this.fisierToolStripMenuItem_Click);
            // 
            // btnGolire
            // 
            this.btnGolire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnGolire.Location = new System.Drawing.Point(155, 403);
            this.btnGolire.Name = "btnGolire";
            this.btnGolire.Size = new System.Drawing.Size(109, 33);
            this.btnGolire.TabIndex = 12;
            this.btnGolire.Text = "Golire formular";
            this.btnGolire.UseVisualStyleBackColor = false;
            this.btnGolire.Click += new System.EventHandler(this.btnGolire_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnAdaugare.Location = new System.Drawing.Point(40, 403);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(109, 33);
            this.btnAdaugare.TabIndex = 11;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // tbLocalitate
            // 
            this.tbLocalitate.Location = new System.Drawing.Point(45, 348);
            this.tbLocalitate.Name = "tbLocalitate";
            this.tbLocalitate.Size = new System.Drawing.Size(217, 22);
            this.tbLocalitate.TabIndex = 26;
            this.tbLocalitate.Validating += new System.ComponentModel.CancelEventHandler(this.tbLocalitate_Validating);
            this.tbLocalitate.Validated += new System.EventHandler(this.tbLocalitate_Validated);
            // 
            // lbLocalitate
            // 
            this.lbLocalitate.AutoSize = true;
            this.lbLocalitate.Location = new System.Drawing.Point(45, 319);
            this.lbLocalitate.Name = "lbLocalitate";
            this.lbLocalitate.Size = new System.Drawing.Size(69, 17);
            this.lbLocalitate.TabIndex = 25;
            this.lbLocalitate.Text = "Localitate";
            // 
            // rbMasculin
            // 
            this.rbMasculin.AutoSize = true;
            this.rbMasculin.Location = new System.Drawing.Point(115, 190);
            this.rbMasculin.Name = "rbMasculin";
            this.rbMasculin.Size = new System.Drawing.Size(84, 21);
            this.rbMasculin.TabIndex = 24;
            this.rbMasculin.Text = "Masculin";
            this.rbMasculin.UseVisualStyleBackColor = true;
            // 
            // rbFeminin
            // 
            this.rbFeminin.AutoSize = true;
            this.rbFeminin.Checked = true;
            this.rbFeminin.Location = new System.Drawing.Point(115, 163);
            this.rbFeminin.Name = "rbFeminin";
            this.rbFeminin.Size = new System.Drawing.Size(78, 21);
            this.rbFeminin.TabIndex = 16;
            this.rbFeminin.TabStop = true;
            this.rbFeminin.Text = "Feminin";
            this.rbFeminin.UseVisualStyleBackColor = true;
            // 
            // lbSex
            // 
            this.lbSex.AutoEllipsis = true;
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(42, 165);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(31, 17);
            this.lbSex.TabIndex = 23;
            this.lbSex.Text = "Sex";
            // 
            // tbCnp
            // 
            this.tbCnp.Location = new System.Drawing.Point(115, 125);
            this.tbCnp.Name = "tbCnp";
            this.tbCnp.Size = new System.Drawing.Size(147, 22);
            this.tbCnp.TabIndex = 22;
            this.tbCnp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCnp_KeyPress);
            this.tbCnp.Validating += new System.ComponentModel.CancelEventHandler(this.tbCnp_Validating);
            this.tbCnp.Validated += new System.EventHandler(this.tbCnp_Validated);
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(115, 94);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(147, 22);
            this.tbPrenume.TabIndex = 21;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.tbPrenume_Validated);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(115, 58);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(147, 22);
            this.tbNume.TabIndex = 20;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated_1);
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Location = new System.Drawing.Point(40, 97);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(65, 17);
            this.lbPrenume.TabIndex = 19;
            this.lbPrenume.Text = "Prenume";
            // 
            // lbDataN
            // 
            this.lbDataN.AutoSize = true;
            this.lbDataN.Location = new System.Drawing.Point(40, 218);
            this.lbDataN.Name = "lbDataN";
            this.lbDataN.Size = new System.Drawing.Size(90, 17);
            this.lbDataN.TabIndex = 18;
            this.lbDataN.Text = "Data nastere";
            // 
            // lbCnp
            // 
            this.lbCnp.AutoSize = true;
            this.lbCnp.Location = new System.Drawing.Point(40, 130);
            this.lbCnp.Name = "lbCnp";
            this.lbCnp.Size = new System.Drawing.Size(33, 17);
            this.lbCnp.TabIndex = 17;
            this.lbCnp.Text = "Cnp";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(40, 58);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(45, 17);
            this.lbNume.TabIndex = 15;
            this.lbNume.Text = "Nume";
            // 
            // dateTimePickerDataN
            // 
            this.dateTimePickerDataN.Location = new System.Drawing.Point(43, 242);
            this.dateTimePickerDataN.MaxDate = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
            this.dateTimePickerDataN.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDataN.Name = "dateTimePickerDataN";
            this.dateTimePickerDataN.Size = new System.Drawing.Size(219, 22);
            this.dateTimePickerDataN.TabIndex = 14;
            this.dateTimePickerDataN.Value = new System.DateTime(2021, 4, 29, 15, 53, 53, 0);
            // 
            // epPacienti
            // 
            this.epPacienti.ContainerControl = this;
            // 
            // cmPacient
            // 
            this.cmPacient.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmPacient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificareToolStripMenuItem,
            this.stergereToolStripMenuItem});
            this.cmPacient.Name = "cmPacient";
            this.cmPacient.Size = new System.Drawing.Size(151, 52);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.modificareToolStripMenuItem.Text = "Modificare";
            this.modificareToolStripMenuItem.Click += new System.EventHandler(this.modificareToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // epNume
            // 
            this.epNume.ContainerControl = this;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // lbVarsta
            // 
            this.lbVarsta.AutoSize = true;
            this.lbVarsta.Location = new System.Drawing.Point(42, 286);
            this.lbVarsta.Name = "lbVarsta";
            this.lbVarsta.Size = new System.Drawing.Size(49, 17);
            this.lbVarsta.TabIndex = 27;
            this.lbVarsta.Text = "Varsta";
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(115, 286);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(147, 22);
            this.tbVarsta.TabIndex = 28;
            // 
            // FormPacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(970, 483);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.lbVarsta);
            this.Controls.Add(this.tbLocalitate);
            this.Controls.Add(this.lbLocalitate);
            this.Controls.Add(this.rbMasculin);
            this.Controls.Add(this.rbFeminin);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.tbCnp);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lbPrenume);
            this.Controls.Add(this.lbDataN);
            this.Controls.Add(this.lbCnp);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.dateTimePickerDataN);
            this.Controls.Add(this.btnGolire);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.msPacienti);
            this.Controls.Add(this.btnGolireLista);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.lvPacienti);
            this.Name = "FormPacienti";
            this.Text = "FormPacient";
            this.msPacienti.ResumeLayout(false);
            this.msPacienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPacienti)).EndInit();
            this.cmPacient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPacienti;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnGolireLista;
        private System.Windows.Forms.MenuStrip msPacienti;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optiuniToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Cnp;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.Button btnGolire;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.TextBox tbLocalitate;
        private System.Windows.Forms.Label lbLocalitate;
        private System.Windows.Forms.RadioButton rbMasculin;
        private System.Windows.Forms.RadioButton rbFeminin;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.TextBox tbCnp;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.Label lbDataN;
        private System.Windows.Forms.Label lbCnp;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataN;
        private System.Windows.Forms.ColumnHeader DataN;
        private System.Windows.Forms.ColumnHeader Localitate;
        private System.Windows.Forms.ErrorProvider epPacienti;
        private System.Windows.Forms.ToolStripMenuItem btnSerializareBinara;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializareBinara;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareXMLToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmPacient;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializareXML;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializareXML;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.ToolStripMenuItem btnPrint;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.Label lbVarsta;
        private System.Windows.Forms.ColumnHeader Varsta;
    }
}