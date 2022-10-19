using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clessidra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;

            //Parte superiore della clessidra
            //La prima riga stampa 0 spazi e n-0 asterischi
            //La seconda riga stampa 1 spazio e n-2 asterischi
            //Gli spazi aumentano di 1 e gli asterischi diminuiscono di 2
            //Mi fermo quando ho stampato un solo asterisco

            int spazi = 0;
            int asterischi = n;

            while (asterischi > 0)
            {
                for (int j = 0; j < spazi; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= asterischi; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                spazi++;
                asterischi -= 2;
            }

            //Parte inferiore della clessidra
            //Parto da dove mi sono fermato e inverto il processo: gli spazi diminuiscono di 1 e gli asterischi aumentano di 2
            //Mi fermo dopo aver stampato n asterischi
            //ATTENZIONE: Il ciclo precedente ha effettuato un incremento di troppo.....
            spazi -= 2;
            asterischi += 4;
            while (asterischi <= n)
            {
                for (int j = 0; j < spazi; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= asterischi; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                spazi--;
                asterischi += 2;
            }




            Console.ReadLine();
        }
    }
}
