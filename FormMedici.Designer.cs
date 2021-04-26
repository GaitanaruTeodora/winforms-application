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
            this.msMedic = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewMedic = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnPopulare = new System.Windows.Forms.Button();
            this.msMedic.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMedic
            // 
            this.msMedic.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMedic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiToolStripMenuItem});
            this.msMedic.Location = new System.Drawing.Point(0, 0);
            this.msMedic.Name = "msMedic";
            this.msMedic.Size = new System.Drawing.Size(800, 28);
            this.msMedic.TabIndex = 0;
            this.msMedic.Text = "menuStrip1";
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            // 
            // listViewMedic
            // 
            this.listViewMedic.CheckBoxes = true;
            this.listViewMedic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewMedic.GridLines = true;
            this.listViewMedic.HideSelection = false;
            this.listViewMedic.Location = new System.Drawing.Point(72, 46);
            this.listViewMedic.Name = "listViewMedic";
            this.listViewMedic.Size = new System.Drawing.Size(602, 278);
            this.listViewMedic.TabIndex = 1;
            this.listViewMedic.UseCompatibleStateImageBehavior = false;
            this.listViewMedic.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Prenume";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Parafa";
            this.columnHeader9.Width = 71;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Cnp";
            this.columnHeader10.Width = 117;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Grad";
            this.columnHeader11.Width = 89;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Specialitate";
            this.columnHeader12.Width = 188;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(318, 369);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(141, 41);
            this.btnAdaugare.TabIndex = 2;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnPopulare
            // 
            this.btnPopulare.Location = new System.Drawing.Point(72, 369);
            this.btnPopulare.Name = "btnPopulare";
            this.btnPopulare.Size = new System.Drawing.Size(141, 41);
            this.btnPopulare.TabIndex = 3;
            this.btnPopulare.Text = "Populare lista";
            this.btnPopulare.UseVisualStyleBackColor = true;
            this.btnPopulare.Click += new System.EventHandler(this.btnPopulare_Click);
            // 
            // FormMedici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPopulare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.listViewMedic);
            this.Controls.Add(this.msMedic);
            this.MainMenuStrip = this.msMedic;
            this.Name = "FormMedici";
            this.Text = "FormMedic";
            this.msMedic.ResumeLayout(false);
            this.msMedic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMedic;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.ListView listViewMedic;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnPopulare;
    }
}