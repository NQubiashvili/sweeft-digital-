using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swift.net_davaleba_2
{
    class Program
    {





        static int search(int[] ar,
                  int size)
        {
            int a = 0, b = size - 1;
            int mid = 0;
            while ((b - a) > 1)
            {
                mid = (a + b) / 2;
                if ((ar[a] - a) != (ar[mid] - mid))
                    b = mid;
                else if ((ar[b] - b) != (ar[mid] - mid))
                    a = mid;
            }
            return (ar[a] + 1);

            Console.ReadLine();
        }


        static public void Main(String[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5, 6, 8 };
            int size = ar.Length;
            Console.WriteLine("Missing number: " +
                                search(ar, size));

            Console.ReadLine();
        }
    }
}


