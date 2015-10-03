using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Coin_Change_Problem
{
    class Program
    {
        private static int[] numbers;
        private static long[,] dyn;

        static long Recursiya(int summa, int index)
        {
            if (summa == 0)
            {
                return 1;
            }

            if (summa < 0)
            {
                return 0;
            }

            if (dyn[summa, index] >=0)
            {
                return dyn[summa, index];
            }

            long count = 0;
            for (int k = index; k < numbers.Length; k++)
            {
                count += Recursiya(summa - numbers[k], k);
            }

            dyn[summa, index] = count;
            return count;
        }

        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(' ');
            string[] str2 = Console.ReadLine()
                .Split(
                new [] { ' '} , 
                StringSplitOptions.RemoveEmptyEntries);

            int summa = int.Parse(str1[0]);
            dyn = new long[summa+1, str2.Length+1];
            for (int i = 0; i <= summa; i ++)
            {
                for (int j = 0; j <= str2.Length; j++)
                {
                    dyn[i, j] = -1;
                }
            }

            numbers = str2.Select(t => int.Parse(t.ToString())).ToArray();
            var result = Recursiya(summa, 0);
            Console.WriteLine(result);
        }
    }
}
