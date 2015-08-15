using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correctness_and_the_Loop_Invariant
{
    class Program
    {
        //        5
        //2 1 3 1 2         4 3 2 1
        static void Main(string[] args)
        {
            //int t = int.Parse(Console.ReadLine());
            string[] p = Console.ReadLine().Split(' ');
            int[] numbers = p.Select(ch => int.Parse(ch.ToString())).ToArray();
            int j;
            int test = 0;
            for (int k = 1; k < numbers.Length; k++)
            {
                j = k - 1;
                int i = k;
                while ((j >= 0) && (numbers[j] > numbers[i]))
                {
                    test++;
                    int temp = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = temp;
                    j--;
                    i--;
                }

            }

            Console.WriteLine(test);

        }

    }
}
