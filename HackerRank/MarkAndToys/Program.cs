using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkAndToys
{
    class Program
    {
        public static void podschot(int[] numbers, int dengi)
        {
            int i = 0;
            int summ = 0;
            int counter = 0;
            while (numbers[i] <= dengi)
            {
                summ = summ + numbers[i];              
                if (summ <= dengi)
                {
                    i++;
                    counter++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(counter);
        }

        static void Main(string[] args)
        {
            string[] k = Console.ReadLine().Split(' ');
            int t = int.Parse(k[0]);
            int vsegoDeneg = int.Parse(k[1]);
            string[] m = new string[t];
            m = Console.ReadLine().Split(' ');
            int[] numbers = m.Select(ch => int.Parse(ch.ToString())).ToArray();
            Array.Sort(numbers);
            podschot(numbers, vsegoDeneg);
        }
    }
}
