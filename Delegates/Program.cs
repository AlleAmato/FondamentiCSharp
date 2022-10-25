using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger<string> l = new Logger<string>(nonRilevante);
            l.Log("App started");

            Logger<string> l2 = new Logger<string>(Console.WriteLine);
            l2.Log("App Started");

            Logger<int> l3 = new Logger<int>(nonRilevantePerInt);
            l3.Log(12);

            Console.ReadKey();
        }

        static void nonRilevantePerInt(int i)
        {
            Console.WriteLine(string.Format("{0,3}", i));
        }

        static void nonRilevante(string s)
        {
            Console.WriteLine(s);
        }
    }
}
