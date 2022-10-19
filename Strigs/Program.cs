using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strigs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string testo1 = "Hello";
            //string testo2 = "World";
            //string testo3 = testo1 + " " + testo2 + "!";
            do
            {
                Console.Write("Inserisci un numero: ");
                string testoLettoDaTastiera = Console.ReadLine();

                if (testoLettoDaTastiera == "exit") break;

                int numeroLettoDaTastiera;// = Convert.ToInt32(testoLettoDaTastiera);

                if (Int32.TryParse(testoLettoDaTastiera, out numeroLettoDaTastiera))
                {
                    //conversione avvenuta con successo
                    Console.WriteLine(2 * numeroLettoDaTastiera);
                }
                else
                {
                    Console.WriteLine("Non hai inserito un numero!");
                }
            } while (true);

            //Console.WriteLine(testoLettoDaTastiera);

            //Console.ReadLine();


            //Leggo del testo da tastiera
            //Lo stampo in ordine inverso (di parole)
            //Esempio: Hello World -> World Hello
            string input = Console.ReadLine();
            string[] parole = input.Trim().Split(' ');

            for (int i = parole.Length-1; i >= 0; i--)
            {
                //if(parole[i]!="")
                if ( !String.IsNullOrEmpty(parole[i]) )Console.Write(parole[i] + " ");
            }

            //Leggere una parola da tastiera e verificare se è palindroma

            Console.ReadLine();
        }
    }
}
