using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProiect
{
    public class DetaliuReteta
    {   
        public int Id { get; set; }
        public int IdReteta { get; set; }
        public string CodW { get; set; }
        public string DenumireMedicament { get; set; }
        public int Cantitate { get; set; }

        public DetaliuReteta(int id, int idReteta, string codW, string denumireMedicament, int cantitate)
        {
            Id = id;
            IdReteta = idReteta;
            CodW = codW;
            DenumireMedicament = denumireMedicament;
            Cantitate = cantitate;
        }
    }
}
