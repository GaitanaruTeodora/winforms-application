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
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace WindowsFormsProiect
{
    
     partial class FormMedici : Form
    {
        List<Medic> listaMedici;
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
            pictureMedic.Image = null;
            pictureClipboard.Image = null;
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {

            Medic medic = new Medic();
            if (tbNume.Text == "")
                epNume.SetError(tbNume, "Introduceti numele medicului!");
            else
            if (tbParafa.Text == "")
                epParafa.SetError(tbParafa, "Introduceti parafa medicului!");
            else
            {
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
           

        }

        private void populareLista()
        {
            golireLista();
            
            foreach (Medic medic in listaMedici)
                {
                    ListViewItem itm = new ListViewItem(medic.Nume);
                    itm.SubItems.Add(medic.Prenume);
                    itm.SubItems.Add(medic.Parafa);
                    itm.SubItems.Add(medic.Grad);
                    itm.SubItems.Add(medic.Specialitate);

                    lvMedici.Items.Add(itm);
                }
            
           
        }

        private void golireLista()
        {
            lvMedici.Items.Clear();
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
            Environment.Exit(0);
        }

        private void serializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("medici.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, lvMedici.Text);
                                            
            file.Close();

        }

        private void deserializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("medici.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            lvMedici.Text = (string)bf.Deserialize(file);
            file.Close();
        }

            

        private void btnGolireFormular_Click(object sender, EventArgs e)
        {
            golireFormular();
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            epNume.Clear();
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if(tbNume.Text == "")
            {
                epNume.SetError(tbNume, "Informatie lipsa");
                e.Cancel = true;
            }
        }

        private void tbParafa_Validated(object sender, EventArgs e)
        {
            epParafa.Clear();
        }

        private void tbParafa_Validating(object sender, CancelEventArgs e)
        {
            if(tbParafa.Text == "")
            {
                epParafa.SetError(tbParafa, "Infromatie lipsa!");
                e.Cancel = true;
            }
        }

        private void stergereTSM_Click(object sender, EventArgs e)
        {
            if (lvMedici.SelectedItems[0] != null)
            {
                ListViewItem item = lvMedici.SelectedItems[0];
                int index = item.Index;

                listaMedici.RemoveAt(index);

                populareLista();

            }
        }

       
        private Medic getMedicFromList(ListViewItem item)
        {
            Medic medic = new Medic();
            medic.Nume = item.SubItems[0].Text;
            medic.Prenume = item.SubItems[1].Text;
            medic.Parafa = item.SubItems[2].Text;
            medic.Grad = item.SubItems[3].Text;
            medic.Specialitate = item.SubItems[4].Text;
            return medic;
        }
        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvMedici.SelectedItems[0] !=null)
            {
                ListViewItem item = lvMedici.SelectedItems[0];
                Medic m = getMedicFromList(item);

                FileStream file = new FileStream("medici.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, m);
                golireLista();
                file.Close();
                MessageBox.Show("Serializarea s-a realizat cu succes!");
            }
        }

        private void modificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMedici.SelectedItems[0] != null)
            {
                ListViewItem item = lvMedici.SelectedItems[0];
                int index = item.Index;
                Medic medic = listaMedici[index];
                FormModificareMedic form = new FormModificareMedic(medic);
                form.ShowDialog();
                populareLista();
            }
        }

        private void lvMedici_MouseClick(object sender, MouseEventArgs e)
        {
           if(e.Button == MouseButtons.Right)
            {
                cmMedici.Show(Cursor.Position);
            }
        }

        private void pictureMedic_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data!= null)
            {
                var fileName = data as string[];
                pictureMedic.Image = Image.FromFile(fileName[0]);
            }

                    
        }

        private void FormMedici_Load(object sender, EventArgs e)
        {
            pictureMedic.AllowDrop = true;
        }

        private void pictureMedic_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pictureMedic.Image !=null)
            {
                Clipboard.SetImage(pictureMedic.Image);
            }
                   }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureClipboard.Handle);
            IDataObject o = Clipboard.GetDataObject();
            if(o.GetDataPresent(typeof(string)))
            {
                
            }
            else
            {
                if (o.GetDataPresent(typeof(Bitmap)))
                {
                    Bitmap bmp = (Bitmap)o.GetData(typeof(Bitmap));
                    g.DrawImage(bmp, 0, 0);

                }

            }

        }

    }
}
