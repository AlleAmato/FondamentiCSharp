using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Utils.Reflect<int>(10);
            DateTime d = Utils.Reflect<DateTime>(DateTime.Now);

            ChiaveValore<DateTime> chiave1 = new ChiaveValore<DateTime>("Oggi",DateTime.Today);


            Console.ReadLine();
        }
    }
}
