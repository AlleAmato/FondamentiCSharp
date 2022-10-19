using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Libro> Biblioteca = new List<Libro>();
            /*List<Dvd> Cineteca = new List<Dvd>();

            Libro libroEBasta = new LibroCartaceo
            {
                Titolo = "Il sabato del villaggio",
                Autore = "Leopardi",
                Prezzo = 1
            };

            LibroCartaceo libroC = new LibroCartaceo
            {
                Titolo = "Promessi sposi",
                Autore = "Manzoni",
                Prezzo = 2,
                Pagine = 450
            };

            LibroDigitale libroD = new LibroDigitale
            {
                Titolo = "I Malavoglia",
                Autore = "Verga",
                Prezzo = 3,
                KB = 100
            };

            Dvd dvd = new Dvd
            {
                Titolo = "Maverik",
                Cast = new List<string>
                {
                    "Tom Cruise","to be defined"
                }
            };

            Biblioteca.Add(libroEBasta);
            Biblioteca.Add(libroC);
            Biblioteca.Add(libroD);
            Cineteca.Add(dvd);

            List<IGetInfo> info = new List<IGetInfo>();
            info.Add(libroEBasta);
            info.Add(libroC);
            info.Add(libroD);
            info.Add(dvd);


            foreach(IGetInfo i in info)
            {
                Console.Write(i.getInfo());
            }



            foreach(Libro l in Biblioteca)
            {
                if(l.GetType() == typeof(LibroDigitale))
                {
                    LibroDigitale b = (LibroDigitale)l;
                    Console.Write("***");
                }



                //Solo proprietà e metodi della classe base (Libro)
                //Se ci sono metodi sovrascritti dalle classi derivate, vengono eseguiti quelli
                Console.WriteLine(l.getInfo());
            }*/

            /*Libro libro = new Libro("Ritratto in seppia", "Isabelle Allende", 9.99f);

            Libro libro2 = new Libro();
            libro2.Titolo = "La concessione del telefono";
            libro2.Autore = "Andrea Camilleri";
            libro2.Prezzo = 9.99f;

            Libro libro3 = new Libro
            {
                Titolo = "1984",
                Autore = "Orwell"
            };


            Biblioteca.Add(libro);
            Biblioteca.Add(libro2);
            Biblioteca.Add(libro3);

            foreach(Libro l in Biblioteca) 
                Console.WriteLine(l.getInfo());*/
            string scelta = "";
            do
            {
                Console.WriteLine("1- Inserimento nuovo libro");
                Console.WriteLine("2- Stampa libri");
                Console.WriteLine("9- Esci");
                Console.WriteLine();
                Console.Write("Inserisci la scelta: ");
                scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.Write("Titolo: ");
                        string t = Console.ReadLine();
                        Console.Write("Autore: ");
                        string a = Console.ReadLine();
                        Console.Write("Prezzo: ");
                        float p = (float)Convert.ToDouble(Console.ReadLine());

                        Libro l = new LibroCartaceo
                        {
                            Titolo = t,
                            Autore = a,
                            Prezzo = p
                        };
                        Biblioteca.Add(l);

                        //Biblioteca.Add(new Libro(t, a, p));

                        break;
                    case "2":
                        foreach (Libro libro in Biblioteca)
                            Console.WriteLine(libro.getInfo());
                        break;
                    case "9":
                        break;
                    default:
                        Console.WriteLine("Scelta non corretta");
                        break;
                }
            } while (scelta != "9");
        }
   
    
    
    
    }
}
