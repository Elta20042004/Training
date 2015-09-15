using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dihotomiya
{
    class Program
    {
        static int BinarySearch(int[] numbers, int searchNumber)
        {
            int start = 0;
            int end = numbers.Length - 1;
            int middle = start + end / 2;

            while (numbers[middle] != searchNumber && start != middle)
            {
                if (numbers[middle] < searchNumber)
                {
                    start = middle;
                }
                else if (numbers[middle] > searchNumber)
                {
                    end = middle;
                }

                middle = (start + end) / 2;
            }

            if (numbers[middle] == searchNumber)
            {
                return middle;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 26, 33, 114, 521, 633, 71111, 821221, 1900000 };
            int searchNumbers = 26;
            var found = BinarySearch(numbers, searchNumbers);
        }
    }
}
