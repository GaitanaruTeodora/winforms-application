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

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            FormAdaugareMedic form = new FormAdaugareMedic();
            listaMedici = form.ListaM;
            //this.Hide();
            form.ShowDialog();
            //this.Close();
            btnAfisare_Click(sender, e);

        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
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

        private void btnGolireLista_Click(object sender, EventArgs e)
        {
            listViewMedic.Items.Clear();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInitial form = new FormInitial();
            form.Show();
            
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
