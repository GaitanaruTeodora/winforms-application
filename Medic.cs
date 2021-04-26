using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProiect
{
    class Medic
    {
        private static int counter = 0;
        private int cod;
        private string nume;
        private string prenume;
        private string parafa;
        private int cnp;
        private string grad;
        private string specialitate;

        public Medic(string nume,string prenume, string parafa,int cnp, string grad, string specialitate)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.parafa = parafa;
            this.cnp = cnp;
            this.grad = grad;
            this.specialitate = specialitate;

            counter++;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }
        public string Parafa
        {
            get { return parafa; }
            set { parafa = value; }
        }
        public int Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }
        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }
        public string Specialitate
        {
            get { return specialitate; }
            set { specialitate = value; }
        }

        public override string ToString()
        {
            return "Medicul " + nume + prenume + " cu parafa " + parafa + " si cnp " + cnp + " are gradul " + grad + " si specialitatea " + specialitate;
        }
    }
}
