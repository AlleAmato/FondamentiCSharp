using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    //Posso definire altre strutture dati
    enum LingueSupportate
    {
        Italian, English
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /*short n;
            
            if( Int16.TryParse(Console.ReadLine(), out n) == true )
            {
                int[] arrayInt = new int[n];

                for(int i = 0; i< arrayInt.Length; i++ )
                {
                    arrayInt[i] = i + 1;
                }

                foreach(int valore in arrayInt)
                {
                    Console.WriteLine(valore);
                }
            }

            Console.ReadLine();*/


            //Creare un array di n short con n letto da tastiera
            //Popolare l'array leggendo n short da tastiera
            //Stampare la media


            //1 - leggo la dimensione da tastiera
            const LingueSupportate lingua = LingueSupportate.Italian;


            short n;

            do
            {
                if( lingua == LingueSupportate.Italian)
                    Console.Write("Inserire la dimensione dell'array: ");
                else
                    Console.Write("Insert array dimension: ");

            } while( !Int16.TryParse(Console.ReadLine(), out n) );

            //1.1 creo l'array
            short[] valori = new short[n];

            //2 - Riempio l'array
            //2.1 - Ciclo su tutti gli elementi
            for (int j = 0; j < valori.Length; j++)
            {
                //2.2 - Per ogni elemento leggo uno short da tastiera (con verifica)
                do
                {
                    Console.Write("Inserire l'elemento di indice " + j+": ");
                } while (!Int16.TryParse(Console.ReadLine(), out valori[j]));
            }

            //3.1 - Calcolo la somma
            short somma = 0;
            foreach (short valore in valori)
            {
                somma += valore;
            }

            //3.2 - Calcolo la media
            double media = 1.0 * somma / valori.Length;

            Console.WriteLine(media);


            //Tavola pitagorica
            byte[,] tavolaPitagorica = new byte[10, 10];

            for (int r = 0; r < tavolaPitagorica.GetLength(0); r++) 
            {
                for (int c = 0; c < tavolaPitagorica.GetLength(1); c++)
                {
                    tavolaPitagorica[r, c] = (byte)((r + 1) * (c + 1));
                }
            }

            Console.ReadLine();

        }
    }



    //Posso definire altre strutture dati
}
