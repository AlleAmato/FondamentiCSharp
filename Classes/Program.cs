using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime data = new DateTime(2022, 10, 12);
            //DayOfWeek dow = data.DayOfWeek;
            //data = data.AddDays(1);


            //TIMER
            //Premo invio da tastiera --> Timer start
            Console.ReadLine();
            DateTime startTime = DateTime.Now;
            //Premo invio da tastiera --> Timer stop 
            Console.ReadLine();
            DateTime stopTime = DateTime.Now;
            
            //Stampo i millisecondi trascorsi
            TimeSpan ts1 = stopTime.Subtract(startTime);
            TimeSpan ts2 = stopTime - startTime;

            Console.WriteLine(ts1.TotalMilliseconds);
            Console.WriteLine(ts2.TotalMilliseconds);

            Console.ReadLine();
        }

    }



}
