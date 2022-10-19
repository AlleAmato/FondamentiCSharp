using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Dvd : IGetInfo
    {
        public string Titolo { get; set; }
        public List<string> Cast { get; set; }

        public string getInfo()
        {
            return $"{Titolo} cast composto da {Cast.Count} attori";
        }

    }
}
