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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(75, 367);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(136, 47);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "Adaugare";
            this.btnAdauga.UseVisualStyleBackColor = true;
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(396, 367);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(136, 47);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(724, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormRetete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 462);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRetete";
            this.Text = "FormReteta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button button3;
    }
}