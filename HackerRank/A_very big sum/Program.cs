using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_very_big_sum
{
    class Program
    {

        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            ulong summ = 0;
            string[] temp = Console.ReadLine().Split(' ');
            ulong[] big = temp.Select(t => ulong.Parse(t.ToString())).ToArray();

            for (int i = 0; i < big.Length; i++)
            {               
                summ = summ + big[i];
            }

            Console.WriteLine(summ);
        }
    }
}
