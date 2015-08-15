using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamParlor
{
    class Program
    {
        public static void podschot(int[] numbers, int vsegoDeneg)
        {
            int summa = 0;
            int j = 0;
            int i;
            for (i = 0; i < numbers.Length; i++)
            {
                j = 0;
                while ((summa != vsegoDeneg)&&(j<=numbers.Length-1))
                {
                    if (i != j)
                    {
                        summa = numbers[i] + numbers[j];
                    }
                    j++;
                }
                if (summa == vsegoDeneg)
                {
                    break;
                }
            }
            Console.WriteLine("{0} {1}", i + 1, j);
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int vsegoDeneg = int.Parse(Console.ReadLine());
                int length = int.Parse(Console.ReadLine());
                string[] mymass = new string[length];
                mymass = Console.ReadLine().Split(' ');
                int[] numbers = mymass.Select(ch => int.Parse(ch.ToString())).ToArray();

                podschot(numbers, vsegoDeneg);
            }
        }
    }
}
