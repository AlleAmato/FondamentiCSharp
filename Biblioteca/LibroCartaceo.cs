using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class LibroCartaceo : Libro
    {
        public ushort Pagine { get; set; }

        public LibroCartaceo() : base()
        {
            init();
        }

        public LibroCartaceo(string titolo, string autore) : base(titolo, autore)
        {
            init();
        }

        private void init()
        {
            Pagine = 0;
        }

        public override string getInfo()
        {
            //return $"{Titolo} {KB}";
            return base.getInfo() + $" Pagine: {Pagine}";
        }
    }
}
