using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queck_Sort
{
    class Program
    {
        public static void Sort(int[] numbers, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
              return;
            }
            
            int i = startIndex;
            int j = endIndex;
            Random k = new Random();
            int seredina = k.Next(startIndex,endIndex);

            while (i < j)
            {
                if ((numbers[i] >= numbers[seredina]) && (numbers[j] <= numbers[seredina]))
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
                if (numbers[i] <= numbers[seredina])
                {
                    i++;
                }
                else if (numbers[j] > numbers[seredina])
                {
                    j--;
                }
            }

            Sort(numbers,startIndex,i-1);
            Sort(numbers,i+1,endIndex);

        }

        static void Main(string[] args)
        {
            int[] k = new[] {5, 7, 8, 9,1};
            int startIndex = 0;
            int endIndex = k.Length-1;
           
            Sort(k, startIndex, endIndex);
        }
    }
}
