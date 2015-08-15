using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort_I_Partition
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] k = new string[t];
            k = Console.ReadLine().Split(' ');
            int[] numbers = k.Select(ch => int.Parse(ch.ToString())).ToArray();

            //int random = numbers[new Random().Next(0, numbers.Length)];
            int random = numbers[0];
            int i = 0;
            int j = numbers.Length - 1;
            while (i<j)
            {
                
               if ((numbers[i]>=random)&&(numbers[j]<=random))
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
                
                if (numbers[i] < random)
                {
                    i++;
                }
                if (numbers[j] > random) 
                {
                    j--;
                }
                
            }

            string[] result1 = numbers.Select(x => x.ToString()).ToArray();
            Console.WriteLine(String.Join(" ", result1));
            Console.ReadLine();
        }
    }
}
