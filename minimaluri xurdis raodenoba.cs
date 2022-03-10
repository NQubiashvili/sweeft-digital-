using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            static int minsplit(int[] coins, int m, int V)
            {

                if (V == 0) return 0;

                int res = int.MaxValue;

                
                for (int i = 0; i < m; i++)
                {
                    if (coins[i] <= V)
                    {
                        int sub_res = minsplit(coins, m,
                                          V - coins[i]);

                        if (sub_res != int.MaxValue &&
                                    sub_res + 1 < res)
                            res = sub_res + 1;
                    }
                }
                return res;
            }

            public static void Main()
            {
                int[] coins = { 50, 20, 10, 5 , 1 };
                int m = coins.Length;
                int V = 11;
                Console.Write("Minimum coins required is " +
                                     minsplit(coins, m, V));
            }
        }
    }
}

