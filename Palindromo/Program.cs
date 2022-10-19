using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().Trim().ToLower();

            //soluzione 1 string reverse
            string r = "";
            for (int i = s.Length-1; i >= 0; i--)
            {
                r += s[i];
            }

            if (r == s)
                Console.WriteLine("Palindromo");
            else
                Console.WriteLine("Non Palindromo");


            //Soluzione 2
            bool palindromo = true;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    palindromo = false;
                    break;
                }
            }

            if (palindromo)
                Console.WriteLine("Palindromo");
            else
                Console.WriteLine("Non Palindromo");
        }
    }
}
