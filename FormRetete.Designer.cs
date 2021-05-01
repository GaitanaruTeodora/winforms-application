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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetete));
            this.msMedici = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGolireLista = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.listViewMedic = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Parafa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specialitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msMedici.SuspendLayout();
            this.SuspendLayout();
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
            this.msMedici.Size = new System.Drawing.Size(800, 31);
            this.msMedici.TabIndex = 12;
            this.msMedici.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.homeToolStripMenuItem.Text = "Home";
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
            // 
            // btnGolireLista
            // 
            this.btnGolireLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnGolireLista.Location = new System.Drawing.Point(556, 376);
            this.btnGolireLista.Name = "btnGolireLista";
            this.btnGolireLista.Size = new System.Drawing.Size(141, 41);
            this.btnGolireLista.TabIndex = 11;
            this.btnGolireLista.Text = "Golire lista";
            this.btnGolireLista.UseVisualStyleBackColor = false;
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnAfisare.Location = new System.Drawing.Point(332, 376);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(141, 41);
            this.btnAfisare.TabIndex = 10;
            this.btnAfisare.Text = "Afisare lista";
            this.btnAfisare.UseVisualStyleBackColor = false;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(206)))));
            this.btnAdaugare.Location = new System.Drawing.Point(94, 376);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(141, 41);
            this.btnAdaugare.TabIndex = 9;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            // 
            // listViewMedic
            // 
            this.listViewMedic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.Parafa,
            this.Grad,
            this.Specialitate});
            this.listViewMedic.FullRowSelect = true;
            this.listViewMedic.GridLines = true;
            this.listViewMedic.HideSelection = false;
            this.listViewMedic.Location = new System.Drawing.Point(94, 68);
            this.listViewMedic.Name = "listViewMedic";
            this.listViewMedic.Size = new System.Drawing.Size(603, 276);
            this.listViewMedic.TabIndex = 8;
            this.listViewMedic.UseCompatibleStateImageBehavior = false;
            this.listViewMedic.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 87;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 110;
            // 
            // Parafa
            // 
            this.Parafa.Text = "Parafa";
            this.Parafa.Width = 117;
            // 
            // Grad
            // 
            this.Grad.Text = "Grad";
            this.Grad.Width = 167;
            // 
            // Specialitate
            // 
            this.Specialitate.Text = "Specialitate";
            this.Specialitate.Width = 231;
            // 
            // FormRetete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMedici);
            this.Controls.Add(this.btnGolireLista);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.listViewMedic);
            this.Name = "FormRetete";
            this.Text = "FormReteta";
            this.msMedici.ResumeLayout(false);
            this.msMedici.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMedici;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.Button btnGolireLista;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.ListView listViewMedic;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Parafa;
        private System.Windows.Forms.ColumnHeader Grad;
        private System.Windows.Forms.ColumnHeader Specialitate;
    }
}