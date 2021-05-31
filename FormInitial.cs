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
        public static FormPacienti formPacienti;
        public FormInitial()
        {
            InitializeComponent();
        }

        
        private void btnMedici_Click(object sender, EventArgs e)
        {
            FormMedici form = new FormMedici();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnPacienti_Click(object sender, EventArgs e)
        {
            formPacienti = new FormPacienti();
            this.Hide();
            formPacienti.ShowDialog();
            this.Show();
        }

        private void btnRetete_Click(object sender, EventArgs e)
        {
            FormRetete form = new FormRetete();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStatistici_Click_1(object sender, EventArgs e)
        {
            List<Pacient> listaPacienti = FormPacienti.ListaPacienti;
           
            if (listaPacienti == null)
            {
                MessageBox.Show("Nu exista pacienti de afisat");
            }
            else
            {

                FormStatistici form = new FormStatistici(listaPacienti);

                this.Hide();
                form.ShowDialog();
                this.Show();
            }
           
        }
    }
}
