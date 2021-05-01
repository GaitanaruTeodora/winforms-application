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
using Microsoft.SqlServer.Server;

namespace WindowsFormsProiect
{   
    public partial class FormPacienti : Form
    {
        private List<Pacient> listaPacienti;
        public FormPacienti()
        {
            InitializeComponent();
            listaPacienti = new List<Pacient>();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            Pacient pacient = new Pacient();
            pacient.Nume = tbNume.Text;
            pacient.Prenume = tbPrenume.Text;

            pacient.Cnp = tbCnp.Text;
            if (rbFeminin.Checked)
                pacient.Sex = rbFeminin.Text;
            else
                pacient.Sex = rbMasculin.Text;
            pacient.DataNastere = dateTimePickerDataN.Value;
            pacient.Localitate = tbLocalitate.Text;

            MessageBox.Show(pacient.ToString());
            listaPacienti.Add(pacient);
            golireFormular();
        }


        private void golireFormular()
        {
            tbNume.Clear();
            tbPrenume.Clear();
            tbCnp.Clear();
            rbFeminin.Checked = false;
            rbMasculin.Checked = false;
            dateTimePickerDataN.Value = DateTime.Now;
            tbLocalitate.Clear();

        }

        private void btnGolire_Click(object sender, EventArgs e)
        {
            golireFormular();
        }
        
        private void golireLista()
        {
            lvPacienti.Items.Clear();
        }
        private void btnAfisare_Click(object sender, EventArgs e)
        {
            golireLista();
            foreach(Pacient pacient in listaPacienti)
            {
                ListViewItem itm = new ListViewItem(pacient.Nume);
                itm.SubItems.Add(pacient.Prenume);
                itm.SubItems.Add(pacient.Cnp.ToString());
                itm.SubItems.Add(pacient.Sex);
                itm.SubItems.Add(pacient.DataNastere.ToShortDateString());
                itm.SubItems.Add(pacient.Localitate);

                lvPacienti.Items.Add(itm);
            }
        }

        private void btnGolireLista_Click(object sender, EventArgs e)
        {
            golireLista();
        }

        private void tbCnp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        public class ExceptiaMea : ApplicationException
        {
            public ExceptiaMea() : base()
            {

            }

            public ExceptiaMea(string mesaj) : base(mesaj)
            {

            }
        }
        private Pacient getPacientFromList(ListViewItem itm)
        {
            Pacient p = new Pacient();
            p.Nume = itm.SubItems[0].Text;
            p.Prenume = itm.SubItems[1].Text;
            p.Cnp = itm.SubItems[2].Text;
            p.Sex = itm.SubItems[3].Text;
            p.DataNastere = DateTime.Parse(itm.SubItems[4].Text);
            p.Localitate = itm.SubItems[5].Text;
           
            return p;

        }

        private void serializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("pacienti.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, listaPacienti);
            golireLista();
            file.Close();
            
            MessageBox.Show("Serializare cu succes!");
        }

        private void deserializareToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            FileStream file = new FileStream("pacienti.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            listaPacienti = (List < Pacient >) formatter.Deserialize(file);
            btnAfisare_Click(sender,e);
        }

        private void lvPacienti_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmPacient.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void btnExportTxt_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("pacient.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            foreach(Pacient p in listaPacienti)
            {
                sw.WriteLine("\" {0}\", \"{1}\", \"{2}\", \" {3}\", \"{4}\", \"{5}\"" ,
                    p.Nume, p.Prenume, p.Cnp, p.Sex, p.DataNastere.ToShortDateString(), p.Localitate);
            }
            sw.Close();
            file.Close();
            MessageBox.Show("Scriere in fisier cu succes!");
        }

        private void btnSerializareXML_Click(object sender, EventArgs e)
        {
            if(lvPacienti.SelectedItems[0]!=null)
            {
                ListViewItem itm = lvPacienti.SelectedItems[0];
                Pacient p = getPacientFromList(itm);

                FileStream file = new FileStream("pacient.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pacient));
                xmlSerializer.Serialize(file, p);

                file.Close();
                MessageBox.Show("Serializare Xml realizata cu succes!");
            }
        }

        private void btnDeserializareXML_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("pacient.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer serializer = new XmlSerializer(typeof(Pacient));
            Pacient p = (Pacient)serializer.Deserialize(file);
            file.Close();
         
        }
    }

}


