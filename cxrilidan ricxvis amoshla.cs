using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba_6
{
    class Program
    {
        public void RemoveAt(string[] index)
        {

            int[] a = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            int del = 30;
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (del == a[i])
                {
                    for (int j = i; j < a.Length - 1; j++)
                    {
                        a[j] = a[j + 1];
                    }

                    count = count + 1;
                        break;

                }
            }
            if (count == 0)
            {
                Console.WriteLine("elementi ar moidzebna");
            }
            else
            {
                Console.WriteLine("elementi warmatebit waishala");
                for (int i = 0; i < a.Length - 1; i++)
                {
                    Console.Write(a[i]+ " ");
                }
            }

        }
    }
}
