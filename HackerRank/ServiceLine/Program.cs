using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLine
{
    class Program
    {
        public static int solve(int[] test)
        {
            string[] temper = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(temper[0]);
            int j = Convert.ToInt32(temper[1]); ;
            int res = int.MaxValue;

            while (i <= j)
            {
                if (test[i] < res)
                {
                    res = test[i];

                }
                i++;
            }

            return res;
        }

        static void Main(string[] args)
        {
            string[] temper = Console.ReadLine().Split(' ');
            int length = Convert.ToInt32(temper[0]);
            int test = Convert.ToInt32(temper[1]);


            temper = Console.ReadLine().Split(' ');
            int[] f = temper.Select(ch => int.Parse(ch.ToString())).ToArray();

            for (var i = 0; i < test; i++)
            {
                int k = solve(f);

                Console.WriteLine(k);
            }

            Console.ReadLine();
        }
    }
}
