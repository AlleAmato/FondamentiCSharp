using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IGetInfo
    {
        string Titolo { get; set; }
        string getInfo();
    }
}
