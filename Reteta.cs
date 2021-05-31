using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProiect
{
    public class Reteta
    {
        public int ID { get; set; }
        public string Serie { get; set; }
        public int NrReteta { get; set; }
        public DateTime DataReteta { get; set; }
        public string Parafa { get; set; }
        public string Cnp { get; set; }
        public string Categorie { get; set; }

        public Reteta(int id, string serie, int nrReteta, DateTime dataReteta, string parafa, string cnp, string categorie)
        {
            ID = id;
            Serie = serie;
            NrReteta = nrReteta;
            DataReteta = dataReteta;
            Parafa = parafa;
            Cnp = cnp;
            Categorie = categorie;
        }

    }
}
