using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Coin_Change_Problem
{
    class Program
    {
        private static int counter ;
        private static int[] numbers;

        static void Recursiya(int summa, int index)
        {
            if (summa == 0)
            {
                counter++;
                return;
            }

            if (summa < 0)
            {
                return;
            }

            for (int k = index; k < numbers.Length; k++)
            {
                Recursiya(summa - numbers[k], k);
            }
        }

        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(' ');
            string[] str2 = Console.ReadLine()
                .Split(
                new [] { ' '} , 
                StringSplitOptions.RemoveEmptyEntries);

            int summa = int.Parse(str1[0]);
            numbers = str2.Select(t => int.Parse(t.ToString())).ToArray();
            Recursiya(summa, 0);
            Console.WriteLine(counter);
        }
    }
}
