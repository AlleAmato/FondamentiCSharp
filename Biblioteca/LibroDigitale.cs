using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class LibroDigitale : Libro
    {
        public ushort KB { get; set; }

        public LibroDigitale() : base()
        {

        }

        public override string getInfo()
        {
            //return $"{Titolo} {KB}";
            return base.getInfo() + $" Dimensione: {KB}";
        }
    }
}
