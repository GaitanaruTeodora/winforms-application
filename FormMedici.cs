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
    public partial class FormMedici : Form
    {
        public FormMedici()
        {
            InitializeComponent();
        }

        private void btnPopulare_Click(object sender, EventArgs e)
        {
            List<Medic> lista = new List<Medic>();

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            FormAdaugareMedic form = new FormAdaugareMedic();
            //this.Hide();
            form.Show();
            //this.Close();
        }
    }
}
