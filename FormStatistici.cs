using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphLibrary;

namespace WindowsFormsProiect
{
    public partial class FormStatistici : Form
    {
        List<BarValue> values;
        public FormStatistici(List<Pacient> listaPacienti)
        {
            values = new List<BarValue>();
            foreach (Pacient p in listaPacienti)
            {

                values.Add(new BarValue(p.Nume + " " + p.Prenume , p.Varsta));
                
            }
            InitializeComponent();    

        }

        private void FormStatistici_Load(object sender, EventArgs e)
        {
            graphControl1.Values = values;
        }
    }
}
