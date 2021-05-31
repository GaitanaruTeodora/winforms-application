namespace WindowsFormsProiect
{
    partial class FormRetete
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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnGolire = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbSerie = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbNr = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pgDetaliuReteta = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGolireDetaliu = new System.Windows.Forms.Button();
            this.btnModificareDetaliu = new System.Windows.Forms.Button();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.btnAdaugareDetaliu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDenumireMed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.COD = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboCategorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbParafa = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pgReteta = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDet = new System.Windows.Forms.DataGridView();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdReteta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DenumireMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliuRetetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cabinetMedicalDataSet = new WindowsFormsProiect.CabinetMedicalDataSet();
            this.dgvReteta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrReteta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataReteta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parafa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliuRetetaTableAdapter = new WindowsFormsProiect.CabinetMedicalDataSetTableAdapters.DetaliuRetetaTableAdapter();
            this.cabinetMedicalDataSet1 = new WindowsFormsProiect.CabinetMedicalDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.pgDetaliuReteta.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pgReteta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaliuRetetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetMedicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReteta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetMedicalDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(628, 16);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(99, 30);
            this.btnAdauga.TabIndex = 7;
            this.btnAdauga.Text = "Adaugare";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Enabled = false;
            this.btnModificare.Location = new System.Drawing.Point(628, 62);
            this.btnModificare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(99, 30);
            this.btnModificare.TabIndex = 8;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnGolire
            // 
            this.btnGolire.Location = new System.Drawing.Point(628, 110);
            this.btnGolire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGolire.Name = "btnGolire";
            this.btnGolire.Size = new System.Drawing.Size(99, 30);
            this.btnGolire.TabIndex = 9;
            this.btnGolire.Text = "Golire Formular";
            this.btnGolire.UseVisualStyleBackColor = true;
            this.btnGolire.Click += new System.EventHandler(this.btnGolire_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1079, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tbSerie
            // 
            this.tbSerie.Location = new System.Drawing.Point(123, 16);
            this.tbSerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.Size = new System.Drawing.Size(124, 22);
            this.tbSerie.TabIndex = 1;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(123, 117);
            this.tbData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(124, 22);
            this.tbData.TabIndex = 3;
            // 
            // tbNr
            // 
            this.tbNr.Location = new System.Drawing.Point(123, 65);
            this.tbNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNr.Name = "tbNr";
            this.tbNr.Size = new System.Drawing.Size(124, 22);
            this.tbNr.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pgDetaliuReteta);
            this.tabControl.Controls.Add(this.pgReteta);
            this.tabControl.Location = new System.Drawing.Point(15, 27);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1055, 512);
            this.tabControl.TabIndex = 9;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // pgDetaliuReteta
            // 
            this.pgDetaliuReteta.Controls.Add(this.panel2);
            this.pgDetaliuReteta.Controls.Add(this.panel1);
            this.pgDetaliuReteta.Location = new System.Drawing.Point(4, 25);
            this.pgDetaliuReteta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgDetaliuReteta.Name = "pgDetaliuReteta";
            this.pgDetaliuReteta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgDetaliuReteta.Size = new System.Drawing.Size(1047, 483);
            this.pgDetaliuReteta.TabIndex = 0;
            this.pgDetaliuReteta.Text = "Adaugare/Modificare Reteta";
            this.pgDetaliuReteta.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnGolireDetaliu);
            this.panel2.Controls.Add(this.btnModificareDetaliu);
            this.panel2.Controls.Add(this.tbCantitate);
            this.panel2.Controls.Add(this.btnAdaugareDetaliu);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbDenumireMed);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbCod);
            this.panel2.Controls.Add(this.COD);
            this.panel2.Location = new System.Drawing.Point(47, 215);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 159);
            this.panel2.TabIndex = 20;
            // 
            // btnGolireDetaliu
            // 
            this.btnGolireDetaliu.Location = new System.Drawing.Point(628, 100);
            this.btnGolireDetaliu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGolireDetaliu.Name = "btnGolireDetaliu";
            this.btnGolireDetaliu.Size = new System.Drawing.Size(99, 30);
            this.btnGolireDetaliu.TabIndex = 15;
            this.btnGolireDetaliu.Text = "Golire Formular";
            this.btnGolireDetaliu.UseVisualStyleBackColor = true;
            this.btnGolireDetaliu.Click += new System.EventHandler(this.btnGolireDetaliu_Click);
            // 
            // btnModificareDetaliu
            // 
            this.btnModificareDetaliu.Location = new System.Drawing.Point(628, 55);
            this.btnModificareDetaliu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificareDetaliu.Name = "btnModificareDetaliu";
            this.btnModificareDetaliu.Size = new System.Drawing.Size(99, 30);
            this.btnModificareDetaliu.TabIndex = 14;
            this.btnModificareDetaliu.Text = "Modificare";
            this.btnModificareDetaliu.UseVisualStyleBackColor = true;
            this.btnModificareDetaliu.Click += new System.EventHandler(this.btnModifiareDetaliu_Click);
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(189, 108);
            this.tbCantitate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(116, 22);
            this.tbCantitate.TabIndex = 12;
            // 
            // btnAdaugareDetaliu
            // 
            this.btnAdaugareDetaliu.Location = new System.Drawing.Point(628, 14);
            this.btnAdaugareDetaliu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdaugareDetaliu.Name = "btnAdaugareDetaliu";
            this.btnAdaugareDetaliu.Size = new System.Drawing.Size(99, 30);
            this.btnAdaugareDetaliu.TabIndex = 13;
            this.btnAdaugareDetaliu.Text = "Adaugare";
            this.btnAdaugareDetaliu.UseVisualStyleBackColor = true;
            this.btnAdaugareDetaliu.Click += new System.EventHandler(this.btnAdaugareDetaliu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cantitate";
            // 
            // tbDenumireMed
            // 
            this.tbDenumireMed.Location = new System.Drawing.Point(189, 63);
            this.tbDenumireMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDenumireMed.Name = "tbDenumireMed";
            this.tbDenumireMed.Size = new System.Drawing.Size(345, 22);
            this.tbDenumireMed.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Denumire Medicament";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(189, 21);
            this.tbCod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(116, 22);
            this.tbCod.TabIndex = 10;
            // 
            // COD
            // 
            this.COD.AutoSize = true;
            this.COD.Location = new System.Drawing.Point(71, 26);
            this.COD.Name = "COD";
            this.COD.Size = new System.Drawing.Size(113, 17);
            this.COD.TabIndex = 0;
            this.COD.Text = "Cod Medicament";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboCategorie);
            this.panel1.Controls.Add(this.btnGolire);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbData);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbNr);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnModificare);
            this.panel1.Controls.Add(this.tbParafa);
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Controls.Add(this.tbCNP);
            this.panel1.Controls.Add(this.tbSerie);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(47, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 163);
            this.panel1.TabIndex = 19;
            // 
            // comboCategorie
            // 
            this.comboCategorie.FormattingEnabled = true;
            this.comboCategorie.Items.AddRange(new object[] {
            "Salariat",
            "Elev",
            "Pensionar",
            "Coasigurat",
            "Plata directa"});
            this.comboCategorie.Location = new System.Drawing.Point(428, 113);
            this.comboCategorie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCategorie.Name = "comboCategorie";
            this.comboCategorie.Size = new System.Drawing.Size(121, 24);
            this.comboCategorie.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Categorie Asigurat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "CNP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Parafa Medic";
            // 
            // tbParafa
            // 
            this.tbParafa.Location = new System.Drawing.Point(428, 16);
            this.tbParafa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbParafa.Name = "tbParafa";
            this.tbParafa.Size = new System.Drawing.Size(121, 22);
            this.tbParafa.TabIndex = 4;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(428, 65);
            this.tbCNP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(119, 22);
            this.tbCNP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data Retata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Serie Reteta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nr Reteta";
            // 
            // pgReteta
            // 
            this.pgReteta.Controls.Add(this.label8);
            this.pgReteta.Controls.Add(this.label7);
            this.pgReteta.Controls.Add(this.dgvDet);
            this.pgReteta.Controls.Add(this.dgvReteta);
            this.pgReteta.Location = new System.Drawing.Point(4, 25);
            this.pgReteta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgReteta.Name = "pgReteta";
            this.pgReteta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgReteta.Size = new System.Drawing.Size(1047, 483);
            this.pgReteta.TabIndex = 1;
            this.pgReteta.Text = "Vizualizare Retete";
            this.pgReteta.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Detaliu reteta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Antet reteta:";
            // 
            // dgvDet
            // 
            this.dgvDet.AllowUserToAddRows = false;
            this.dgvDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.IdReteta,
            this.CodW,
            this.DenumireMedicament,
            this.Cantitate});
            this.dgvDet.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.detaliuRetetaBindingSource, "IdReteta", true));
            this.dgvDet.Location = new System.Drawing.Point(27, 295);
            this.dgvDet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDet.Name = "dgvDet";
            this.dgvDet.ReadOnly = true;
            this.dgvDet.RowHeadersWidth = 51;
            this.dgvDet.RowTemplate.Height = 24;
            this.dgvDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDet.Size = new System.Drawing.Size(1008, 194);
            this.dgvDet.TabIndex = 1;
            this.dgvDet.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDet_RowHeaderMouseClick);
            this.dgvDet.DoubleClick += new System.EventHandler(this.dgvDet_DoubleClick);
            // 
            // ID2
            // 
            this.ID2.HeaderText = "ID";
            this.ID2.MinimumWidth = 6;
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Visible = false;
            this.ID2.Width = 125;
            // 
            // IdReteta
            // 
            this.IdReteta.HeaderText = "IdReteta";
            this.IdReteta.MinimumWidth = 6;
            this.IdReteta.Name = "IdReteta";
            this.IdReteta.ReadOnly = true;
            this.IdReteta.Visible = false;
            this.IdReteta.Width = 125;
            // 
            // CodW
            // 
            this.CodW.HeaderText = "CodW";
            this.CodW.MinimumWidth = 6;
            this.CodW.Name = "CodW";
            this.CodW.ReadOnly = true;
            this.CodW.Width = 125;
            // 
            // DenumireMedicament
            // 
            this.DenumireMedicament.HeaderText = "DenumireMedicament";
            this.DenumireMedicament.MinimumWidth = 6;
            this.DenumireMedicament.Name = "DenumireMedicament";
            this.DenumireMedicament.ReadOnly = true;
            this.DenumireMedicament.Width = 125;
            // 
            // Cantitate
            // 
            this.Cantitate.HeaderText = "Cantitate";
            this.Cantitate.MinimumWidth = 6;
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.ReadOnly = true;
            this.Cantitate.Width = 125;
            // 
            // detaliuRetetaBindingSource
            // 
            this.detaliuRetetaBindingSource.DataMember = "DetaliuReteta";
            this.detaliuRetetaBindingSource.DataSource = this.cabinetMedicalDataSet;
            // 
            // cabinetMedicalDataSet
            // 
            this.cabinetMedicalDataSet.DataSetName = "CabinetMedicalDataSet";
            this.cabinetMedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvReteta
            // 
            this.dgvReteta.AllowUserToAddRows = false;
            this.dgvReteta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReteta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Serie,
            this.NrReteta,
            this.DataReteta,
            this.Parafa,
            this.CNP,
            this.Categorie});
            this.dgvReteta.Location = new System.Drawing.Point(27, 32);
            this.dgvReteta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReteta.Name = "dgvReteta";
            this.dgvReteta.ReadOnly = true;
            this.dgvReteta.RowHeadersWidth = 51;
            this.dgvReteta.RowTemplate.Height = 24;
            this.dgvReteta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReteta.Size = new System.Drawing.Size(1008, 219);
            this.dgvReteta.TabIndex = 0;
            this.dgvReteta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReteta_CellClick);
            this.dgvReteta.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReteta_RowEnter);
            this.dgvReteta.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReteta_RowHeaderMouseClick);
            this.dgvReteta.DoubleClick += new System.EventHandler(this.dgvReteta_DoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // Serie
            // 
            this.Serie.HeaderText = "Serie";
            this.Serie.MinimumWidth = 6;
            this.Serie.Name = "Serie";
            this.Serie.ReadOnly = true;
            this.Serie.Width = 125;
            // 
            // NrReteta
            // 
            this.NrReteta.HeaderText = "Nr Reteta";
            this.NrReteta.MinimumWidth = 6;
            this.NrReteta.Name = "NrReteta";
            this.NrReteta.ReadOnly = true;
            this.NrReteta.Width = 125;
            // 
            // DataReteta
            // 
            this.DataReteta.HeaderText = "Data Reteta";
            this.DataReteta.MinimumWidth = 6;
            this.DataReteta.Name = "DataReteta";
            this.DataReteta.ReadOnly = true;
            this.DataReteta.Width = 125;
            // 
            // Parafa
            // 
            this.Parafa.HeaderText = "Parafa Medic";
            this.Parafa.MinimumWidth = 6;
            this.Parafa.Name = "Parafa";
            this.Parafa.ReadOnly = true;
            this.Parafa.Width = 125;
            // 
            // CNP
            // 
            this.CNP.HeaderText = "CNP Pacient";
            this.CNP.MinimumWidth = 6;
            this.CNP.Name = "CNP";
            this.CNP.ReadOnly = true;
            this.CNP.Width = 125;
            // 
            // Categorie
            // 
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.MinimumWidth = 6;
            this.Categorie.Name = "Categorie";
            this.Categorie.ReadOnly = true;
            this.Categorie.Width = 125;
            // 
            // detaliuRetetaTableAdapter
            // 
            this.detaliuRetetaTableAdapter.ClearBeforeFill = true;
            // 
            // cabinetMedicalDataSet1
            // 
            this.cabinetMedicalDataSet1.DataSetName = "CabinetMedicalDataSet";
            this.cabinetMedicalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 31);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(78, 27);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(74, 27);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // FormRetete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 561);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRetete";
            this.Load += new System.EventHandler(this.FormRetete_Load);
            this.tabControl.ResumeLayout(false);
            this.pgDetaliuReteta.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pgReteta.ResumeLayout(false);
            this.pgReteta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaliuRetetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetMedicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReteta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetMedicalDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnGolire;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox tbSerie;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbNr;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pgDetaliuReteta;
        private System.Windows.Forms.TabPage pgReteta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbParafa;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.DataGridView dgvReteta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDet;
        private CabinetMedicalDataSet cabinetMedicalDataSet;
        private System.Windows.Forms.BindingSource detaliuRetetaBindingSource;
        private CabinetMedicalDataSetTableAdapters.DetaliuRetetaTableAdapter detaliuRetetaTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGolireDetaliu;
        private System.Windows.Forms.Button btnModificareDetaliu;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Button btnAdaugareDetaliu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDenumireMed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label COD;
        private System.Windows.Forms.Panel panel1;
        private CabinetMedicalDataSet cabinetMedicalDataSet1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReteta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodW;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenumireMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrReteta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataReteta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parafa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
    }
}