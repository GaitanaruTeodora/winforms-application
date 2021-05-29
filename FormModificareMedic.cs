using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsProiect
{
     public partial class FormModificareMedic : Form
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
           
            instance.Nume = tbNume.Text;
            instance.Prenume = tbPrenume.Text;
            instance.Parafa = tbParafa.Text;
            if(comboGrad.SelectedItem!=null)
            instance.Grad = comboGrad.SelectedItem.ToString();
            if(comboSpecialitate.SelectedItem!=null)
            instance.Specialitate = comboSpecialitate.SelectedItem.ToString();
            
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

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("medic.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, instance);
            file.Close();
            golireFormular();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("medic.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Medic m = (Medic)bf.Deserialize(file);
            file.Close();
            completareFormular(m);
        }

        private void serializareXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("medic.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Medic));
            xmlSerializer.Serialize(file, instance);
            file.Close();
            golireFormular();
        }

        private void deserializareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("medic.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Medic));
            Medic p = (Medic)xmlSerializer.Deserialize(file);
            file.Close();
            completareFormular(p);
        }

      

        private void exportFisierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("medic.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);

            string nume = tbNume.Text;
            string prenume = tbPrenume.Text;
            string parafa = tbParafa.Text;
            string grad = comboGrad.Text;
            string specialitate = comboSpecialitate.Text;
            sw.WriteLine(nume + "," + prenume + "," + parafa + "," + grad + "," + specialitate);
            sw.Close();
            golireFormular();
            file.Close();
        }

        private void citireFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("medic.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(file);

            string linie = null;
            while ((linie = sw.ReadLine())!=null)
            {
                tbNume.Text = linie.Split(',')[0];
                tbPrenume.Text = linie.Split(',')[1];
                tbParafa.Text = linie.Split(',')[2];
                comboGrad.Text = linie.Split(',')[3];
                comboSpecialitate.Text = linie.Split(',')[4];
            }
            file.Close();
            sw.Close();
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (tbNume.Text == "")
            {
                epNume.SetError(tbNume, "Infromatie lipsa!");
                e.Cancel = true;
            }

        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            epNume.Clear();
        }

        private void tbParafa_Validated(object sender, EventArgs e)
        {
            epParafa.Clear();
        }

        private void tbParafa_Validating(object sender, CancelEventArgs e)
        {
            if (tbParafa.Text == "")
            {
                epParafa.SetError(tbParafa, "Infromatie lipsa!");
                e.Cancel = true;
            }
        }
    }
}
