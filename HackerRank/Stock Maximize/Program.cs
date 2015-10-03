using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Maximize
{
    class Program
    {
        private static long[] numbers;
        private static long[,] dyn;

        static long Rec(int index, int shares)
        {
            if (index==numbers.Length)
            {
                return 0;
            }

            if (dyn[index, shares] >= 0)
            {
                return dyn[index, shares];
            }

            long maxValue1 = Rec(index + 1,  shares);

            long maxValue2 = Rec(index + 1, shares + 1) - numbers[index];

            long maxValue3 =0;
            if (shares > 0)
            {
                  maxValue3 = Rec(index, shares - 1) + numbers[index];
            }

            long summa = Math.Max(maxValue1, Math.Max(maxValue2,maxValue3));
            dyn[index, shares] = summa;
            return summa;
        }

        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            for (int k = 0; k < c; k++)
            {
                int length = int.Parse(Console.ReadLine());
                string[] kStr = Console.ReadLine().Split(' ');
                numbers = kStr.Select(t => long.Parse(t.ToString())).ToArray();

                dyn = new long[numbers.Length + 1, numbers.Length + 1];
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        dyn[i, j] = -1;
                    }
                }


                long summa = Rec(0,0);
                Console.WriteLine(summa);
            }
           
           
        }
    }
}
