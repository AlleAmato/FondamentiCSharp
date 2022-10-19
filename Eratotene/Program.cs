using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erastotene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short n = 0;

            //Leggo il numero massimo da considerare
            do
            {
                Console.Write("Inserire il numero massimo da considerare: ");

            } while (!Int16.TryParse(Console.ReadLine(), out n));

            //Creo un array di bool. L'indice rappresenta il numero, il valore rappresenta se è primo o no
            //Lo inizializzo a true

            bool[] numeriPrimi = new bool[n + 1];

            for (int i = 0; i < numeriPrimi.Length; i++)
            {
                numeriPrimi[i] = true;
            }

            //L'algoritmo dice di non considerare 0 e 1 in quanto non primi. Si parte da 2 che è primo
            numeriPrimi[0] = false;
            numeriPrimi[1] = false;

            //Ciclo su tutti gli elementi da 2 a n-1
            for (int i = 2; i < numeriPrimi.Length-1; i++)
            {
                //Considero l'elemento corrente solo se è primo
                if(numeriPrimi[i] == true)
                {
                    //Ciclo su tutti gli elementi successivi e "cancello" quelli multipli
                    for (int j = i+1; j < numeriPrimi.Length; j++)
                    {
                        if (numeriPrimi[j] == true && j % i == 0) numeriPrimi[j] = false;
                    }
                }
            }

            //Stampo solo i numeri primi
            for (int i = 0; i < numeriPrimi.Length; i++)
            {
                if (numeriPrimi[i] == true) Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
