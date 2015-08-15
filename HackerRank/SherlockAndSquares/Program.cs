using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndSquares
{
    class Program
    {

        public static void test(long first, long second)
        {
            int counter = 0;

            double k = Math.Sqrt(first);
            long s = (long)Math.Round(k);
            for (long i = s; i <= second/2; i++)
            {
                long temp = i*i;
                if ((temp >= first) && (temp <= second))
                {
                    counter++;
                }
                else if (temp>second)
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }


        static void Main(string[] args)
        {           
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] interval = Console.ReadLine().Split(' ');
                long first = long.Parse(interval[0]);
                long second = long.Parse(interval[1]);

                test(first, second);
            }
        }
    }
}
