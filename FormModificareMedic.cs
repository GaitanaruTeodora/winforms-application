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
     partial class FormModificareMedic : Form
    {
        
        Medic instance;
        public FormModificareMedic(Medic medic)
        {
            InitializeComponent();
            instance = medic;
        }

        private void completareFormular(Medic medic)
        {
            tbNume.Text = medic.Nume;
            tbPrenume.Text = medic.Prenume;
            tbParafa.Text = medic.Parafa;
            comboGrad.SelectedItem = medic.Grad;
            comboSpecialitate.SelectedItem = medic.Specialitate;
            
        }
        private void FormModificareMedic_Load(object sender, EventArgs e)
        {
            completareFormular(instance);
        }
        private void btnSalvare_Click(object sender, EventArgs e)
        {
            Medic medic = new Medic();
            medic.Nume = tbNume.Text;
            medic.Prenume = tbPrenume.Text;
            medic.Parafa = tbParafa.Text;
            if(comboGrad.SelectedItem!=null)
            medic.Grad = comboGrad.SelectedItem.ToString();
            if(comboSpecialitate.SelectedItem!=null)
            medic.Specialitate = comboSpecialitate.SelectedItem.ToString();

            this.Close();

            
        }

        private void golireFormular()
        {
            tbNume.Clear();
            tbPrenume.Clear();
            tbParafa.Clear();
            comboGrad.SelectedItem = null;
            comboSpecialitate.SelectedItem = null;
        }
        private void btnGolire_Click(object sender, EventArgs e)
        {
            golireFormular();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}
