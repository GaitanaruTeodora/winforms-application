using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProiect
{   
    [Serializable]
    public class Pacient
    {
        private string nume;
        private string prenume;
        private string cnp;
        private string sex;
        private int varsta;
        private DateTime dataNastere;
        private string localitate;
        
        public Pacient() {}

        public string Nume
        {
            get { return nume; }
            set  { nume = value; }
        }
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }
        public string Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
           
        }
        public DateTime DataNastere
        {
            get { return dataNastere; }
            set { dataNastere = value; }
        
        }
        public string Localitate
        {
            get { return localitate; }
            set { localitate = value; }
        }

        public override string ToString()
        {
            String message = "Pacientul " + nume + " " + prenume + " cu cnp ul " + cnp + " ,sex ul  " + sex + ", data nasterii " + dataNastere.ToShortDateString() + ", domiciliat in localitatea " + localitate + " a fost adaugat cu succes!";
            return message;
        }

    }
}
