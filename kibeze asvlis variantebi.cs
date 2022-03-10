using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba_5
{
    class Program
    {
        static int countVariants(int stearsCount)
        {
            if (stearsCount <= 1)
                return stearsCount;
            return countVariants(stearsCount - 1) + countVariants(stearsCount - 2);
        }

        static int countWays(int s)
        {
            return countVariants(s + 1);
        }

        static public void Main()
        {
            Console.Write("shemoitanet safexurebis raodenoba: ");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kibeze asvlis gzebis varianti= " + countWays(s));


            Console.ReadLine();

        }

    }
}
