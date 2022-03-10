using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWIFT.NET
{
    class Program
    {
        static void Main(string[] args)

            // დავალება 1
        {

            Console.Write("Shemoitanet sityva: ");
            string test = Console.ReadLine();

            if (IsPaliandrome(test) == true)
            {
                Console.WriteLine("Sityva Paliandromia!");
            }
            else
            {
                Console.WriteLine("Sityva Ar Aris Paliandromi!");
            }

            Console.ReadLine(); //კონსოლი რო არ გაითიშოს
        }

        public static bool IsPaliandrome(string test)
        {
            bool p = true;

            for (int i = 0; i < test.Length - 1; i++)
            {
                int m = test.Length - 1 - i;

                if (test[i] != test[m])
                {

                }



            }

            return p;
        }









    }
}
