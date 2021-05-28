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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pgDetaliuReteta = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pgReteta = new System.Windows.Forms.TabPage();
            this.dgvReteta = new System.Windows.Forms.DataGridView();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrReteta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataReteta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parafa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.pgDetaliuReteta.SuspendLayout();
            this.pgReteta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReteta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 130);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(63, 349);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(136, 47);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "Adaugare";
            this.btnAdauga.UseVisualStyleBackColor = true;
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(342, 349);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(136, 47);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(632, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(381, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 22);
            this.textBox4.TabIndex = 8;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pgDetaliuReteta);
            this.tabControl.Controls.Add(this.pgReteta);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(934, 440);
            this.tabControl.TabIndex = 9;
            // 
            // pgDetaliuReteta
            // 
            this.pgDetaliuReteta.Controls.Add(this.comboBox1);
            this.pgDetaliuReteta.Controls.Add(this.label4);
            this.pgDetaliuReteta.Controls.Add(this.label5);
            this.pgDetaliuReteta.Controls.Add(this.label6);
            this.pgDetaliuReteta.Controls.Add(this.textBox3);
            this.pgDetaliuReteta.Controls.Add(this.textBox5);
            this.pgDetaliuReteta.Controls.Add(this.label3);
            this.pgDetaliuReteta.Controls.Add(this.label2);
            this.pgDetaliuReteta.Controls.Add(this.label1);
            this.pgDetaliuReteta.Controls.Add(this.textBox1);
            this.pgDetaliuReteta.Controls.Add(this.btnAdauga);
            this.pgDetaliuReteta.Controls.Add(this.btnModificare);
            this.pgDetaliuReteta.Controls.Add(this.button3);
            this.pgDetaliuReteta.Controls.Add(this.textBox4);
            this.pgDetaliuReteta.Controls.Add(this.textBox2);
            this.pgDetaliuReteta.Controls.Add(this.dataGridView1);
            this.pgDetaliuReteta.Location = new System.Drawing.Point(4, 25);
            this.pgDetaliuReteta.Name = "pgDetaliuReteta";
            this.pgDetaliuReteta.Padding = new System.Windows.Forms.Padding(3);
            this.pgDetaliuReteta.Size = new System.Drawing.Size(926, 411);
            this.pgDetaliuReteta.TabIndex = 0;
            this.pgDetaliuReteta.Text = "Detaliu Reteta";
            this.pgDetaliuReteta.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(419, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Categorie Asigurat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "CNP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Parafa Medic";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(159, 121);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 22);
            this.textBox5.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data Retata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nr Reteta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Serie Reteta";
            // 
            // pgReteta
            // 
            this.pgReteta.Controls.Add(this.dgvReteta);
            this.pgReteta.Location = new System.Drawing.Point(4, 25);
            this.pgReteta.Name = "pgReteta";
            this.pgReteta.Padding = new System.Windows.Forms.Padding(3);
            this.pgReteta.Size = new System.Drawing.Size(926, 411);
            this.pgReteta.TabIndex = 1;
            this.pgReteta.Text = "Retete";
            this.pgReteta.UseVisualStyleBackColor = true;
            // 
            // dgvReteta
            // 
            this.dgvReteta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReteta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serie,
            this.NrReteta,
            this.DataReteta,
            this.Parafa,
            this.CNP,
            this.Categorie});
            this.dgvReteta.Location = new System.Drawing.Point(50, 28);
            this.dgvReteta.Name = "dgvReteta";
            this.dgvReteta.RowHeadersWidth = 51;
            this.dgvReteta.RowTemplate.Height = 24;
            this.dgvReteta.Size = new System.Drawing.Size(771, 307);
            this.dgvReteta.TabIndex = 0;
            this.dgvReteta.DoubleClick += new System.EventHandler(this.dgvReteta_DoubleClick);
            // 
            // Serie
            // 
            this.Serie.HeaderText = "Serie";
            this.Serie.MinimumWidth = 6;
            this.Serie.Name = "Serie";
            this.Serie.Width = 125;
            // 
            // NrReteta
            // 
            this.NrReteta.HeaderText = "Nr Reteta";
            this.NrReteta.MinimumWidth = 6;
            this.NrReteta.Name = "NrReteta";
            this.NrReteta.Width = 125;
            // 
            // DataReteta
            // 
            this.DataReteta.HeaderText = "Data Reteta";
            this.DataReteta.MinimumWidth = 6;
            this.DataReteta.Name = "DataReteta";
            this.DataReteta.Width = 125;
            // 
            // Parafa
            // 
            this.Parafa.HeaderText = "Parafa Medic";
            this.Parafa.MinimumWidth = 6;
            this.Parafa.Name = "Parafa";
            this.Parafa.Width = 125;
            // 
            // CNP
            // 
            this.CNP.HeaderText = "CNP Pacient";
            this.CNP.MinimumWidth = 6;
            this.CNP.Name = "CNP";
            this.CNP.Width = 125;
            // 
            // Categorie
            // 
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.MinimumWidth = 6;
            this.Categorie.Name = "Categorie";
            this.Categorie.Width = 125;
            // 
            // FormRetete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 462);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormRetete";
            this.Load += new System.EventHandler(this.FormRetete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.pgDetaliuReteta.ResumeLayout(false);
            this.pgDetaliuReteta.PerformLayout();
            this.pgReteta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReteta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pgDetaliuReteta;
        private System.Windows.Forms.TabPage pgReteta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dgvReteta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrReteta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataReteta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parafa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
    }
}