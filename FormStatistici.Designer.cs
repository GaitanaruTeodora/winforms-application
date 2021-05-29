namespace WindowsFormsProiect
{
    partial class FormStatistici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistici));
            this.graphControl1 = new GraphLibrary.GraphControl();
            this.SuspendLayout();
            // 
            // graphControl1
            // 
            this.graphControl1.Location = new System.Drawing.Point(29, 23);
            this.graphControl1.Name = "graphControl1";
            this.graphControl1.Size = new System.Drawing.Size(694, 404);
            this.graphControl1.TabIndex = 0;
            this.graphControl1.Values = ((System.Collections.Generic.List<GraphLibrary.BarValue>)(resources.GetObject("graphControl1.Values")));
            // 
            // FormStatistici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 448);
            this.Controls.Add(this.graphControl1);
            this.Name = "FormStatistici";
            this.Text = "FormStatistici";
            this.Load += new System.EventHandler(this.FormStatistici_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GraphLibrary.GraphControl graphControl1;
    }
}