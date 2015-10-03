using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GridChallenge
{
    class Program
    {
        private static int[,] _rezult;
        private static void Calculate(int[] k, int row)
        {
            int j = 0;
            int m = 0;
            while (j < k.Length)
            {
                _rezult[row, j] = k[m];
                j++;
                m++;
            }

            row++;
        }

        private static void Compare(int[,] rezult, int length)
        {
            string result = "YES";
            bool found = false;
            for (int j = 0; j < length && !found; j++)
            {
                for (int i = 0; i <= length - 2 && !found; i++)
                {
                    if (rezult[i, j] > rezult[i + 1, j])
                    {
                        result = "NO";
                        j = length - 1;
                        found = true;
                    }
                }
            }

            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            for (int k = 0; k < p; k++)
            {
                int n = int.Parse(Console.ReadLine());
                _rezult = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    string str = Console.ReadLine();
                    int[] numbers = str.Select(t => t - 'a').ToArray();
                    Array.Sort(numbers);
                    Calculate(numbers, i);
                }

                Compare(_rezult, n);
            }
        }
    }
}
