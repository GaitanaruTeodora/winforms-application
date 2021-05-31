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
            this.lvMedici = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Parafa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specialitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmMedici = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnGolireLista = new System.Windows.Forms.Button();
            this.msMedici = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnGolireFormular = new System.Windows.Forms.Button();
            this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epParafa = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureMedic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureClipboard = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cmMedici.SuspendLayout();
            this.msMedici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epParafa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMedic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClipboard)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMedici
            // 
            this.lvMedici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.Parafa,
            this.Grad,
            this.Specialitate});
            this.lvMedici.FullRowSelect = true;
            this.lvMedici.GridLines = true;
            this.lvMedici.HideSelection = false;
            this.lvMedici.Location = new System.Drawing.Point(391, 84);
            this.lvMedici.Name = "lvMedici";
            this.lvMedici.Size = new System.Drawing.Size(494, 260);
            this.lvMedici.TabIndex = 1;
            this.lvMedici.UseCompatibleStateImageBehavior = false;
            this.lvMedici.View = System.Windows.Forms.View.Details;
            this.lvMedici.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMedici_MouseClick);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 86;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 92;
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
            this.modificareToolStripMenuItem,
            this.stergereTSM});
            this.cmMedici.Name = "cmMedici";
            this.cmMedici.Size = new System.Drawing.Size(151, 52);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.modificareToolStripMenuItem.Text = "Modificare";
            this.modificareToolStripMenuItem.Click += new System.EventHandler(this.modificareToolStripMenuItem_Click);
            // 
            // stergereTSM
            // 
            this.stergereTSM.Name = "stergereTSM";
            this.stergereTSM.Size = new System.Drawing.Size(150, 24);
            this.stergereTSM.Text = "Stergere";
            this.stergereTSM.Click += new System.EventHandler(this.stergereTSM_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnAdaugare.Location = new System.Drawing.Point(137, 369);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(101, 41);
            this.btnAdaugare.TabIndex = 2;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnAfisare.Location = new System.Drawing.Point(478, 369);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(147, 41);
            this.btnAfisare.TabIndex = 3;
            this.btnAfisare.Text = "Afisare lista";
            this.btnAfisare.UseVisualStyleBackColor = false;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnGolireLista
            // 
            this.btnGolireLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnGolireLista.Location = new System.Drawing.Point(653, 369);
            this.btnGolireLista.Name = "btnGolireLista";
            this.btnGolireLista.Size = new System.Drawing.Size(147, 41);
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
            this.iesireToolStripMenuItem});
            this.msMedici.Location = new System.Drawing.Point(0, 0);
            this.msMedici.Name = "msMedici";
            this.msMedici.Size = new System.Drawing.Size(909, 31);
            this.msMedici.TabIndex = 7;
            this.msMedici.Text = "menuStrip1";
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
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(74, 27);
            this.iesireToolStripMenuItem.Text = "&Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // lbSpecialitate
            // 
            this.lbSpecialitate.AutoSize = true;
            this.lbSpecialitate.Location = new System.Drawing.Point(134, 291);
            this.lbSpecialitate.Name = "lbSpecialitate";
            this.lbSpecialitate.Size = new System.Drawing.Size(81, 17);
            this.lbSpecialitate.TabIndex = 18;
            this.lbSpecialitate.Text = "Specialitate";
            // 
            // comboGrad
            // 
            this.comboGrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrad.FormattingEnabled = true;
            this.comboGrad.Items.AddRange(new object[] {
            "Medic rezident",
            "Medic specialist",
            "Medic primar"});
            this.comboGrad.Location = new System.Drawing.Point(137, 261);
            this.comboGrad.Name = "comboGrad";
            this.comboGrad.Size = new System.Drawing.Size(219, 24);
            this.comboGrad.TabIndex = 17;
            // 
            // lbGrad
            // 
            this.lbGrad.AutoSize = true;
            this.lbGrad.Location = new System.Drawing.Point(134, 231);
            this.lbGrad.Name = "lbGrad";
            this.lbGrad.Size = new System.Drawing.Size(40, 17);
            this.lbGrad.TabIndex = 16;
            this.lbGrad.Text = "Grad";
            // 
            // tbParafa
            // 
            this.tbParafa.Location = new System.Drawing.Point(137, 202);
            this.tbParafa.Name = "tbParafa";
            this.tbParafa.Size = new System.Drawing.Size(219, 22);
            this.tbParafa.TabIndex = 15;
            this.tbParafa.Validating += new System.ComponentModel.CancelEventHandler(this.tbParafa_Validating);
            this.tbParafa.Validated += new System.EventHandler(this.tbParafa_Validated);
            // 
            // lbParafa
            // 
            this.lbParafa.AutoSize = true;
            this.lbParafa.Location = new System.Drawing.Point(134, 182);
            this.lbParafa.Name = "lbParafa";
            this.lbParafa.Size = new System.Drawing.Size(50, 17);
            this.lbParafa.TabIndex = 14;
            this.lbParafa.Text = "Parafa";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(137, 140);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(219, 22);
            this.tbPrenume.TabIndex = 13;
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Location = new System.Drawing.Point(134, 120);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(65, 17);
            this.lbPrenume.TabIndex = 12;
            this.lbPrenume.Text = "Prenume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(137, 84);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(219, 22);
            this.tbNume.TabIndex = 11;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(134, 64);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(45, 17);
            this.lbNume.TabIndex = 10;
            this.lbNume.Text = "Nume";
            // 
            // comboSpecialitate
            // 
            this.comboSpecialitate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpecialitate.FormattingEnabled = true;
            this.comboSpecialitate.Items.AddRange(new object[] {
            "Dermato-venerolog",
            "Dermato-cosmetolog",
            "Dermato-triholog"});
            this.comboSpecialitate.Location = new System.Drawing.Point(137, 320);
            this.comboSpecialitate.Name = "comboSpecialitate";
            this.comboSpecialitate.Size = new System.Drawing.Size(219, 24);
            this.comboSpecialitate.TabIndex = 19;
            // 
            // btnGolireFormular
            // 
            this.btnGolireFormular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnGolireFormular.Location = new System.Drawing.Point(258, 369);
            this.btnGolireFormular.Name = "btnGolireFormular";
            this.btnGolireFormular.Size = new System.Drawing.Size(98, 41);
            this.btnGolireFormular.TabIndex = 20;
            this.btnGolireFormular.Text = "Golire ";
            this.btnGolireFormular.UseVisualStyleBackColor = false;
            this.btnGolireFormular.Click += new System.EventHandler(this.btnGolireFormular_Click);
            // 
            // epNume
            // 
            this.epNume.ContainerControl = this;
            // 
            // epParafa
            // 
            this.epParafa.ContainerControl = this;
            // 
            // pictureMedic
            // 
            this.pictureMedic.BackColor = System.Drawing.Color.White;
            this.pictureMedic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureMedic.Location = new System.Drawing.Point(12, 70);
            this.pictureMedic.Name = "pictureMedic";
            this.pictureMedic.Size = new System.Drawing.Size(100, 92);
            this.pictureMedic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMedic.TabIndex = 21;
            this.pictureMedic.TabStop = false;
            this.pictureMedic.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureMedic_DragDrop);
            this.pictureMedic.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureMedic_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Imagine medic";
            // 
            // pictureClipboard
            // 
            this.pictureClipboard.BackColor = System.Drawing.Color.White;
            this.pictureClipboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureClipboard.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureClipboard.Location = new System.Drawing.Point(12, 202);
            this.pictureClipboard.Name = "pictureClipboard";
            this.pictureClipboard.Size = new System.Drawing.Size(100, 92);
            this.pictureClipboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClipboard.TabIndex = 23;
            this.pictureClipboard.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 52);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Clipboard";
            // 
            // FormMedici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureClipboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureMedic);
            this.Controls.Add(this.btnGolireFormular);
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
            this.Controls.Add(this.lvMedici);
            this.Name = "FormMedici";
            this.Load += new System.EventHandler(this.FormMedici_Load);
            this.cmMedici.ResumeLayout(false);
            this.msMedici.ResumeLayout(false);
            this.msMedici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epParafa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMedic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClipboard)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvMedici;
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
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmMedici;
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
        private System.Windows.Forms.Button btnGolireFormular;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.ErrorProvider epParafa;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureMedic;
        private System.Windows.Forms.PictureBox pictureClipboard;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}