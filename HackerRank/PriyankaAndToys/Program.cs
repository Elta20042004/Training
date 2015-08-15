using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriyankaAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] k = new string[t];
            k = Console.ReadLine().Split(' ');
            int[] numbers = k.Select(ch => int.Parse(ch.ToString())).ToArray();
            Array.Sort(numbers);
            //int[] numbers = new[] { 0, 2, 9, 10, 13, 16, 17, 17, 18, 19 };
            int maxVes = numbers[0] + 4;
            int counter = 1;



            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxVes)
                {
                    counter++;
                    maxVes = numbers[i] + 4;
                }


            }

            Console.WriteLine(counter);
        }
    }

}
