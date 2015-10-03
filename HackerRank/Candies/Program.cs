using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candies
{
    class Program
    {
        private static int[] numbers;
        private static int[] candyArray;

        static void Process()
        {
            int index = 0;
            while (index < numbers.Length)
            {
                if (index == 0)
                {
                    candyArray[index]++;
                    index++;
                }
                else if (numbers[index] < numbers[index - 1] && candyArray[index - 1] == 1)
                {
                    index--;
                }
                else if (numbers[index] < numbers[index - 1])
                {
                    if (candyArray[index] + 1 >= candyArray[index - 1])
                    {
                        index--;
                    }
                    else
                    {
                        candyArray[index]++;
                        index++;
                    }
                }
                else if (numbers[index] > numbers[index - 1])
                {
                    candyArray[index] = Math.Max(candyArray[index - 1] + 1, candyArray[index] + 1);
                    index++;
                }
                else if (numbers[index] == numbers[index - 1])
                {
                    candyArray[index]++;
                    index++;
                }
            }

            Console.WriteLine(candyArray.Sum(t => t));
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            numbers = new int[t];
            candyArray = new int[t];
            for (int i = 0; i < t; i++)
            {
                int rating = int.Parse(Console.ReadLine());
                numbers[i] = rating;
            }

            Process();
        }
    }
}
