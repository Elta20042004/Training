using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Point
{
    class Program
    {
        public static void test(int[] numbers)
        {
            int x;
            int y;
            if (numbers[0] < numbers[2])
            {
                x = numbers[2] + (numbers[2] - numbers[0]);
            }
            else if (numbers[0] > numbers[2])
            {
                x = numbers[2] - (numbers[0] - numbers[2]);
            }
            else
            {
                x = numbers[0];
            }

            if (numbers[1] < numbers[3])
            {
                y = numbers[3] + (numbers[3] - numbers[1]);
            }
            else if (numbers[1] > numbers[3])
            {
                y = numbers[3] - (numbers[1] - numbers[3]);
            }
            else
            {
                y = numbers[1];
            }

            Console.WriteLine("{0} {1}",x,y);
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] k = Console.ReadLine().Split(' ');
                int[] numbers = k.Select(c => int.Parse(c.ToString())).ToArray();
                test(numbers);
            }
        }
    }
}
//10
//1 1 2 2
//4 3 5 2
//2 4 5 6
//1 2 2 2
//1 1 1 1
//1 2 2 1
//1 8 7 8
//9 1 1 1
//8 4 3 2
//7 8 9 1

//3 3
//6 1
//8 8
//3 2
//1 1
//3 0
//13 8
//-7 1
//-2 0
//11 -6