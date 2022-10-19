using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> test = null;
            test.Add(210);

            int? x = null;
            x = x*2;
            x = null;

            Nullable<int> z = null;


            int y = x != null ? (int)x : -1;

            if (x != null)
                y = (int)x;
            else
                y = -1;



            y = x.HasValue ? x.Value : -1;
            y = x.GetValueOrDefault(-1);
            y = x ?? -1;






            //1 - Crea una lista vuota
            List<short> numeri = new List<short>();

            //2 - leggi elementi da tastiera
            //2.1 se sono numeri aggiungili alla lista
            //2.2 se è exit vai al calcol della media

            while (true)
            {
                string inputTastiera = Console.ReadLine();
                if (inputTastiera.ToLower().Trim() == "exit") break;

                short n;
                if( Int16.TryParse(inputTastiera, out n) == true )
                {
                    numeri.Add(n);
                }
            }

            if (numeri.Count > 0)
            {
                //3 - Calcola la media
                short somma = 0;
                foreach (short numero in numeri)
                {
                    somma += numero;
                }

                double media = (double)somma / numeri.Count;
                Console.WriteLine(media);
            }
            else
            {
                Console.WriteLine("Nessun numero inserito");
            }
            Console.ReadLine();
        }
    }
}
