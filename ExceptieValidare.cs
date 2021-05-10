using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProiect
{
    class ExceptieValidare : Exception
    {
        public override string Message
        {
            get { return "Exceptie validare date"; }
        }
    }
}
