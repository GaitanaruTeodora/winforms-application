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
            if (tbNume.Text == "")
                epPacienti.SetError(tbNume, "Introduceti numele!");
            else
            if (tbPrenume.Text == "")
                epPacienti.SetError(tbPrenume, "Introduceti prenumele!");
            else
            if (tbCnp.Text == "")
                epPacienti.SetError(tbCnp, "Introduceti CNP!");
            else
            if (tbLocalitate.Text == "")
                epPacienti.SetError(tbLocalitate, "Introduceti localitatea");
            else
            {
                try
                {
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

                    //throw new ExceptieValidare();

                }catch(ExceptieValidare ex)
                {
                    MessageBox.Show(ex.Message);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
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
            populareLista();
        }
        private void populareLista()
        {
            golireLista();
            foreach (Pacient pacient in listaPacienti)
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

        private void completareLista(Pacient pacient)
        {
            ListViewItem itm = new ListViewItem(pacient.Nume);
            itm.SubItems.Add(pacient.Prenume);
            itm.SubItems.Add(pacient.Cnp.ToString());
            itm.SubItems.Add(pacient.Sex);
            itm.SubItems.Add(pacient.DataNastere.ToShortDateString());
            itm.SubItems.Add(pacient.Localitate);

            lvPacienti.Items.Add(itm);
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

        private Pacient getPacientFromList(ListViewItem itm)
        {
            Pacient p = new Pacient();
            p.Nume = itm.SubItems[0].Text;
            p.Prenume = itm.SubItems[1].Text;
            p.Cnp = itm.SubItems[2].Text;
            p.Sex = itm.SubItems[3].Text;
            p.DataNastere =DateTime.Parse(itm.SubItems[4].Text);
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
            if (lvPacienti.SelectedItems.Count == 0)
                return;
            if (lvPacienti.SelectedItems[0]!=null)
            {   
                ListViewItem itm = lvPacienti.SelectedItems[0];
                Pacient p = getPacientFromList(itm);

                FileStream file = new FileStream("pacient.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pacient));
                xmlSerializer.Serialize(file, p);

                file.Close();
                MessageBox.Show("Serializare Xml realizata cu succes!");
            }
            else
            {
                MessageBox.Show("Nu sunt pacienti in lista");
            }
        }

        private void btnDeserializareXML_Click(object sender, EventArgs e)
        {
            golireLista();
            FileStream file = new FileStream("pacient.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer serializer = new XmlSerializer(typeof(Pacient));
            Pacient p = (Pacient)serializer.Deserialize(file);
            completareLista(p);
            file.Close();
         
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvPacienti.SelectedItems[0]!=null)
            {
                ListViewItem itm = lvPacienti.SelectedItems[0];
                //Pacient pacient = getPacientFromList(itm);
                int index = itm.Index;
                Pacient pacient = listaPacienti[index];
                FormModificarePacient form = new FormModificarePacient(pacient);
                
                form.ShowDialog();
                populareLista();
            }
            
           
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPacienti.SelectedItems[0] != null)
            {
                ListViewItem item = lvPacienti.SelectedItems[0];
                int index = item.Index;

                listaPacienti.RemoveAt(index);

                populareLista();  
                
            }
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {

            if (tbNume.Text == "" )
            {
                epPacienti.SetError((Control)sender, "Iformatie lipsa");
                e.Cancel = true;
            }
            if(tbNume.Text.Any(char.IsDigit))
            {
                epPacienti.SetError((Control)sender, "Informatie eronata");
                e.Cancel = true;
            }
           
        }
        private void tbNume_Validated_1(object sender, EventArgs e)
        {
            epPacienti.Clear();
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrenume.Text == "")
            {
                epPacienti.SetError((Control)sender, "Iformatie lipsa");
                e.Cancel = true;
            }
            if (tbPrenume.Text.Any(char.IsDigit))
            {
                epPacienti.SetError((Control)sender, "Informatie eronata");
                e.Cancel = true;
            }
        }

        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            epPacienti.Clear();
        }

        private void tbLocalitate_Validated(object sender, EventArgs e)
        {
            epPacienti.Clear();
        }

        private void tbLocalitate_Validating(object sender, CancelEventArgs e)
        {
            if (tbLocalitate.Text == "")
            {
                epPacienti.SetError((Control)sender, "Iformatie lipsa");
                e.Cancel = true;
            }
        }

        private void dataD()
        {

        }
        private void tbCnp_Validating(object sender, CancelEventArgs e)
        {

            if (tbCnp.Text == "")
            {
                epPacienti.SetError((Control)sender, "Iformatie lipsa");
                e.Cancel = true;
            }
            else
             if ((tbCnp.Text.Substring(0, 1) == "1" || tbCnp.Text.Substring(0, 1) == "5"))
            {
                //epPacienti.SetError(tbCnp, "CNP nu corespunde cu sex");
                //epPacienti.SetError(rbFeminin, "Sex nu corespunde cu CNP");
                rbMasculin.Checked = true;
                rbMasculin.Text = "Masculin";

                if(tbCnp.Text.Substring(0, 1) == "1")
                {
                    //DateTime data;

                    //string ex;
                    //ex = tbCnp.Text.Substring(6, 2) + "." + tbCnp.Text.Substring(4, 2) + ".19" + tbCnp.Text.Substring(2, 2);
                    //Console.WriteLine(ex);
                    //dateTimePickerDataN.Value.Day = (tbCnp.Text.Substring(6, 2));
                    //dateTimePickerDataN = DateTime.Parse(ex);
                   
                    //dateTimePickerDataN.Value = new DateTime(Int32.Parse(tbCnp.Text.Substring(6, 2)), Int32.Parse(tbCnp.Text.Substring(4, 2)), Int32.Parse(tbCnp.Text.Substring(2, 2)));
                }
                else if(tbCnp.Text.Substring(0, 1) == "5")
                {
                    string ex = tbCnp.Text.Substring(6, 2) + "." + tbCnp.Text.Substring(4, 2) + ".20" + tbCnp.Text.Substring(2, 2);
                }



            }
            else
              if ((tbCnp.Text.Substring(0, 1) == "2" || tbCnp.Text.Substring(0, 1) == "6"))
            {
                //epPacienti.SetError(tbCnp, "CNP nu corespunde cu sex");
                //epPacienti.SetError(rbMasculin, "Sex nu corespunde cu CNP");

                rbFeminin.Checked = true;
                rbFeminin.Text = "Feminin";

            }
        }

        private void tbCnp_Validated(object sender, EventArgs e)
        {
            epPacienti.Clear();
        }

        
    }

}


