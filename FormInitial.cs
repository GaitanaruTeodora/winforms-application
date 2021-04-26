using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProiect
{
    public partial class FormInitial : Form
    {
        public FormInitial()
        {
            InitializeComponent();
        }

        
        private void btnMedici_Click(object sender, EventArgs e)
        {
            FormMedici form = new FormMedici();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnPacienti_Click(object sender, EventArgs e)
        {
            FormPacienti form = new FormPacienti();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnRetete_Click(object sender, EventArgs e)
        {
            FormRetete form = new FormRetete();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnStatistici_Click(object sender, EventArgs e)
        {
            FormStatistici form = new FormStatistici();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
