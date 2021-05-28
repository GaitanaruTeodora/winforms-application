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
    public partial class FormModificarePacient : Form
    {
        Pacient instance;
        public FormModificarePacient(Pacient pacient)
        {
            InitializeComponent();
            instance = pacient;
        }
        private void completareFormular(Pacient pacient)
        {   
           
                tbNume.Text = pacient.Nume;
                tbPrenume.Text = pacient.Prenume;
                tbCnp.Text = pacient.Cnp;
                if (pacient.Sex == "Feminin")
                    rbFeminin.Checked = true;
                else
                    rbMasculin.Checked = true;
                dateTimePicker.Value = pacient.DataNastere;
                tbLocalitate.Text = pacient.Localitate;

            
            
        }
        private void FormModificarePacient_Load(object sender, EventArgs e)
        {
            completareFormular(instance);
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void golireFormular()
        {
            tbNume.Clear();
            tbPrenume.Clear();
            tbCnp.Clear();
            rbFeminin.Checked = false;
            rbMasculin.Checked = false;
            dateTimePicker.Value = DateTime.Now;
            tbLocalitate.Clear();

        }
        private void btnGolire_Click(object sender, EventArgs e)
        {
            golireFormular();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            instance.Nume = tbNume.Text;
            instance.Prenume = tbPrenume.Text;
            instance.Cnp = tbCnp.Text;
            if (rbFeminin.Checked)
                instance.Sex = "Feminin";
            else
                instance.Sex = "Masculin";
            instance.DataNastere = dateTimePicker.Value;
            instance.Localitate = tbLocalitate.Text;

            this.Close();          

        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if(tbNume.Text == "")
            {
                epNume.SetError(tbNume, "Introduceti numele");
                e.Cancel = true;
            }
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            epNume.Clear();
        }

        private void tbCnp_Validating(object sender, CancelEventArgs e)
        {
            if(tbCnp.Text == "")
            {
                epCnp.SetError(tbCnp, "Introduceti Cnp ul");
                e.Cancel = true;
            }
        }

        private void tbCnp_Validated(object sender, EventArgs e)
        {
            epCnp.Clear();
        }
    }
}
