using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProiect
{   
    [Serializable]
    public class Medic
    {
        String nume;
        String prenume;
        String parafa;
        String grad;
        String specialitate;

        public String Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public String Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }
        public String Parafa
        {
            get { return parafa; }
            set { parafa = value; }
        }

        public String Grad
        {
            get { return grad; }
            set { grad = value; }
        }
        public String Specialitate
        {
            get { return specialitate; }
            set { specialitate = value; }
        }
        public Medic()
        {
            this.nume = "Anonim";
            this.prenume = "Anonim";
            this.parafa = "Anonim";
            this.grad = "Medic rezident";
            this.specialitate = "Dermato-venerolog";
        }
        public Medic(string nume, string prenume, string parafa, string grad, string specialitate)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.parafa = parafa;
            this.grad = grad;
            this.specialitate = specialitate;

            
        }
        public override string ToString()
        {
            return "Medicul " + nume + " "+ prenume + " cu parafa " + parafa + " are gradul " + grad + " si specialitatea " + specialitate;
        }
    }
}
