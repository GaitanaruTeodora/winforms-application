using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsProiect
{
    
     partial class FormMedici : Form
    {
        List<Medic> listaMedici;
        Medic instance;
        public FormMedici()
        {
            InitializeComponent();
            listaMedici = new List<Medic>();
        }

        private void golireFormular()
        {
            tbNume.Clear();
            tbPrenume.Clear();
            tbParafa.Clear();
            comboGrad.SelectedItem = null;
            comboSpecialitate.SelectedItem = null;
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {

            Medic medic = new Medic();
            medic.Nume = tbNume.Text;
            medic.Prenume = tbPrenume.Text;
            medic.Parafa = tbParafa.Text;
            if (comboGrad.SelectedItem != null)
                medic.Grad = comboGrad.SelectedItem.ToString();
            if (comboSpecialitate.SelectedItem != null)
                medic.Specialitate = comboSpecialitate.SelectedItem.ToString();
            listaMedici.Add(medic);
            golireFormular();

        }

        private void populareLista()
        {
            golireLista();
            if (listaMedici.Count != 0)
            {
                foreach (Medic medic in listaMedici)
                {
                    ListViewItem itm = new ListViewItem(medic.Nume);
                    itm.SubItems.Add(medic.Prenume);
                    itm.SubItems.Add(medic.Parafa);
                    itm.SubItems.Add(medic.Grad);
                    itm.SubItems.Add(medic.Specialitate);

                    listViewMedic.Items.Add(itm);
                }
            }
            else
            {
                MessageBox.Show("Nu sunt medici adaugati. Introduceti un medic!");
            }
        }

        private void golireLista()
        {
            listViewMedic.Items.Clear();
        }
        private void btnAfisare_Click(object sender, EventArgs e)
        {
            populareLista();
        }

        private void btnGolireLista_Click(object sender, EventArgs e)
        {
            golireLista();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void serializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("medici.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, listViewMedic.Text);
                                            
            file.Close();

        }

        private void deserializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("medici.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            listViewMedic.Text = (string)bf.Deserialize(file);
            file.Close();
        }

        private void listViewMedic_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cmMedici.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void modificareTSM_Click(object sender, EventArgs e)
        {
            if(listViewMedic.SelectedItems[0]!=null)
            {
                ListViewItem item = listViewMedic.SelectedItems[0];
                int index = item.Index;
                Medic medic = listaMedici[index];
                FormModificareMedic form = new FormModificareMedic(medic);
                form.ShowDialog();
            }
           
            
        }



        //private void serializareToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    FileStream file = new FileStream("medici.dat", FileMode.Create, FileAccess.Write);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    bf.Serialize(file, listViewMedic.Text);
        //    /listViewMedic.Clear();
        //    file.Close();
        //}

        //private void deserializareToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    FileStream file = new FileStream("medici.dat", FileMode.Open, FileAccess.Read);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    listViewMedic.Text = (string)bf.Deserialize(file);
        //    file.Close();
        //}
    }
}
