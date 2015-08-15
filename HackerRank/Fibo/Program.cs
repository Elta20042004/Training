using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo
{
    class Program
    {
        public static string fibo(long fibonachi)
        {
            string otvet;
            long j = 1;
            long i = 0;
            long sum = 0;

            while (sum < fibonachi)
            {
                i = sum;
                sum = sum + j;
                j = i;
            }

            if (sum == fibonachi)
            {
                otvet="IsFibo";
            
            }
            else
            {
                otvet="IsNotFibo";
            }
            return otvet;
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i <t; i++)
            {
                long elements = long.Parse(Console.ReadLine());
                string res = fibo(elements);
                Console.WriteLine(res);
            }
            Console.ReadLine();

        }
    }
}
