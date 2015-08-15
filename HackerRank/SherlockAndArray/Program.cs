using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndArray
{
    class Program
    {
        public static void test(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                Console.WriteLine("YES");
                return;
            }
            string mmm = "NO";
            int k = numbers.Length - 1;
            int summ1 = numbers[0];
            int summ2 = 0;
            for (int i = 2; i <= numbers.Length-1; i++)
            {
                summ2 = summ2 + numbers[i];
            }

            for (int i = 1; i <= numbers.Length - 2; i++)
            {
                if (summ1 == summ2)
                {
                    mmm = "YES";
                    break;
                }

                summ1 = summ1 + numbers[i];
                summ2 = summ2 - numbers[i+1];

            }
            Console.WriteLine(mmm);
        }


        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int leng = int.Parse(Console.ReadLine());
                string[] k = new string[leng];
                k = Console.ReadLine().Split(' ');
                int[] numbers = k.Select(ch => int.Parse(ch.ToString())).ToArray();
                test(numbers);
            }
        }
    }
}
