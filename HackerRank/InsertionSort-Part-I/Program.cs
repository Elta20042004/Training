using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort_Part_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            string[] k = new string[t];
            k = Console.ReadLine().Split(' ');
            int[] numbers = k.Select(ch => int.Parse(ch.ToString())).ToArray();
            int i = numbers.Length - 1;
            while ((i>0)&&(numbers[i] <= numbers[i - 1]))
            {

                int p = numbers[i];
                numbers[i] = numbers[i - 1];

                string[] result = numbers.Select(x => x.ToString()).ToArray();
                Console.WriteLine(String.Join(" ", result));

                numbers[i - 1] = p;

                i--;
            }

            string[] result1 = numbers.Select(x => x.ToString()).ToArray();
            Console.WriteLine(String.Join(" ", result1));


        }




    }

}
