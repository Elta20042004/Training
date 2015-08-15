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
        public static int[,] rezult;
        public static int tim;
        public static void preobrazovanie(int[] k)
        {
            int j = 0;
            int m = 0;
            while (j < k.Length)
            {
                rezult[tim, j] = k[m];
                j++;
                m++;
            }
            tim++;
        }

        public static void sravnenie(int[,] rezult, int length)
        {
            string otvet = "YES";
            for (int j = 0; j < length; j++)
            {
                for (int i = 0; i <= length - 2; i++)
                {
                    if (rezult[i, j] > rezult[i + 1, j])
                    {
                        otvet = "NO";
                        j = length - 1;
                        break;
                    }

                }
            }

            Console.WriteLine(otvet);
        }

        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            for (int k = 0; k < p; k++)
            {
                int n = int.Parse(Console.ReadLine());
                rezult = new int[n, n];
                tim = 0;
                for (int i = 0; i < n; i++)
                {
                    string stroka = Console.ReadLine();
                    int[] numbers = stroka.Select(t => t - 'a').ToArray();
                    Array.Sort(numbers);
                    preobrazovanie(numbers);
                }

                sravnenie(rezult, n);

            }
        }
    }
}
