using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangoloDx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;

            for(int i = 1; i <= n; i++)
            {
                for(int j=0; j < n-i ; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
