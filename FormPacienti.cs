using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        private static List<Pacient> listaPacienti;
        public FormPacienti()
        {
            InitializeComponent();
            listaPacienti = new List<Pacient>();
        }
        public static List<Pacient> ListaPacienti
        {
            get { return listaPacienti; }
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
                pacient.Nume = tbNume.Text;
                pacient.Prenume = tbPrenume.Text;

                pacient.Cnp = tbCnp.Text;
                   if (rbFeminin.Checked)
                    pacient.Sex = rbFeminin.Text;
                   else
                 pacient.Sex = rbMasculin.Text;
                 pacient.DataNastere = dateTimePickerDataN.Value;
                 pacient.Localitate = tbLocalitate.Text;
                try
                {
                    if (tbVarsta.Text == "")
                        throw new ExceptieValidare();
                    else if (tbVarsta.Text.All(char.IsDigit))
                    {
                        pacient.Varsta = Int32.Parse(tbVarsta.Text);
                        listaPacienti.Add(pacient);
                        golireFormular();
                    }
                    else
                        MessageBox.Show("Format incorect pentru varsta!");
                }catch(ExceptieValidare ex)
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
            tbVarsta.Clear();
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
                itm.SubItems.Add(pacient.Varsta.ToString());
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
            itm.SubItems.Add(pacient.Varsta.ToString());
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
            p.Varsta = Int32.Parse(itm.SubItems[5].Text);
            p.Localitate = itm.SubItems[6].Text;
           
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

        private void fisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("pacient.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            foreach (Pacient p in listaPacienti)
            {
                sw.WriteLine("\" {0}\", \"{1}\", \"{2}\", \" {3}\", \"{4}\", \"{5}\" ,\"{6}\"",
                    p.Nume, p.Prenume, p.Cnp, p.Sex, p.DataNastere.ToShortDateString(),p.Varsta, p.Localitate);
            }
            sw.Close();
            file.Close();
            MessageBox.Show("Scriere in fisier cu succes!");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 14);
            Brush brush = Brushes.Purple;
            Pen pen = new Pen(brush);
            PageSettings settings = printDocument.DefaultPageSettings;
            var totalW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalH;
                totalH = totalW;
                totalW = temp;
            }

            var cellW = totalW / 4;
            var cellH = 40;

            int x = settings.Margins.Left;
            int y = 100;

            //desenare cap tabel
            graphics.DrawRectangle(pen, x, y,cellW,cellH);
            graphics.DrawRectangle(pen, x + cellW , y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 3, y, cellW, cellH);

            //desenare text coloane
            graphics.DrawString("Nume", font, brush, x,y);
            graphics.DrawString("Prenume", font, brush, x+ cellW, y);
            graphics.DrawString("Cnp", font, brush, x + cellW * 2, y);
            graphics.DrawString("Localitate", font, brush, x + cellW * 3, y);

            y += cellH;
            foreach(Pacient p in listaPacienti)
            {
                graphics.DrawRectangle(pen, x, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 3, y, cellW, cellH);

                //desenare celula
                graphics.DrawString(p.Nume, font, brush, x, y);
                graphics.DrawString(p.Prenume, font, brush, x + cellW, y);
                graphics.DrawString(p.Cnp, font, brush, x + cellW * 2, y);
                graphics.DrawString(p.Localitate, font, brush, x + cellW * 3, y);

                y += cellH;
            }

        }

   
    }

}


