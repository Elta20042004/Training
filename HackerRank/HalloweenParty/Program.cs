using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenParty
{
    class Program
    {
        public static void test(long k)
        {
            long first = k/2;
            long second = k - first;
            long rez = first*second;

            Console.WriteLine(rez);
        }


        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                long k = long.Parse(Console.ReadLine());
                test(k);
            }
        }
    }
}

//861534819721
//69035986009
//4280698930225
//226812633752
//3022872526881
//6041092984632
//5624097624324
//15951976090056
//10371227352721
//580113007452