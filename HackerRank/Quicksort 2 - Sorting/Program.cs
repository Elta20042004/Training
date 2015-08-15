using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort_2___Sorting
{

    //    7
    //5 8 1 3 7 9 2

    //2 3
    //1 2 3
    //7 8 9
    //1 2 3 5 7 8 9
    class Program
    {
        public static void Sort(int[] numbers, int start, int end)
        {
            if (end - start < 1)
            {
                return;
            }
            
            int i = start;
            int j = end;
            int seredina = numbers[0];
            List<int> pit = new List<int>();
            int z = 0;
            while (i<j)
            {
                 if ((numbers[i] >= seredina) && (numbers[j] <= seredina))
                 {
                     int temp = numbers[i];
                     numbers[i] = numbers[j];

                     pit.Add(numbers[i]);

                     numbers[j] = temp;
                 }
                 if (numbers[j] > seredina)
                 {
                     j--;
                 }
                 else if (numbers[i] <= seredina)
                 {
                     i++;
                 }
            }
            pit.Sort();
            foreach (var k in pit)
            {
                Console.Write(k);
            }
            Console.WriteLine();
      
            Sort(numbers,start,i-1);
            Sort(numbers, i+1, end);
        }

        static void Main(string[] args)
        {
            //int t = int.Parse(Console.ReadLine());
            string[] k = Console.ReadLine().Split(' ');
            int[] numbers = k.Select(ch => int.Parse(ch.ToString())).ToArray();

            Sort(numbers, 0, numbers.Length - 1);
        }
    }
}
