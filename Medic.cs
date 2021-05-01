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
    internal class Medic
    {
        private string nume;
        private string prenume;
        private string parafa;
        private string grad;
        private string specialitate;

        public Medic(string nume,string prenume, string parafa, string grad, string specialitate)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.parafa = parafa;
            //this.cnp = cnp;
            this.grad = grad;
            this.specialitate = specialitate;

            
        }
        public Medic() { }

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
            return "Medicul " + nume +" "+ prenume + " cu parafa " + parafa  + " are gradul " + grad + " si specialitatea " + specialitate;
        }
    }
}
