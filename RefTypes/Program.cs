using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = x;
            y = 20;

            Console.WriteLine($"x:{x}  y:{y}");


            int[] a1 = new int[3] { 10, 20, 30 };
            int[] a2 = a1;
            a2[1] = 999;

            Console.WriteLine("Array a1:");
            foreach (int i in a1) Console.WriteLine(i);

            Console.WriteLine("Array a2:");
            foreach (int i in a2) Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
