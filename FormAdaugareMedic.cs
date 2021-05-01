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
     partial class FormAdaugareMedic : Form
    {
        List<Medic> listaMedici;
        public FormAdaugareMedic()
        {
            InitializeComponent();
            listaMedici = new List<Medic>();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            Medic medic = new Medic();
            medic.Nume = tbNume.Text;
            medic.Prenume = tbPrenume.Text;
            medic.Parafa = tbParafa.Text;
            medic.Grad = cbGrad.SelectedItem.ToString();
            medic.Specialitate = tbSpecialitate.Text;
           
            listaMedici.Add(medic);
            golireFormular();
            MessageBox.Show(medic.ToString());
            this.Hide();

            
        }

        private void golireFormular()
        {
            tbNume.Clear();
            tbPrenume.Clear();
            tbParafa.Clear();
            cbGrad.SelectedItem = null;
            tbSpecialitate.Clear();
        }
        private void btnGolire_Click(object sender, EventArgs e)
        {
            golireFormular();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<Medic> ListaM
        {
            get { return listaMedici; }

        }
    }
}
