using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanyRekursiya
{
    class Program
    {
        private static int[] numbers;
        private static long[,] dyn;

        static long Rec(int summa, int index)
        {
            if (summa == 0)
            {
                return 1;
            }

            if (summa < 0)
            {
                return 0;
            }

            if (dyn[summa, index] >= 0)
            {
                return dyn[summa, index];
            }

            long count = 0;
            for (int k = index + 1; k < numbers.Length; k++)
            {
                count += Rec(summa - numbers[k], k);
            }

            dyn[summa, index] = count;
            return count;
        }

        static void Main(string[] args)
        {
            //int[] k = new[] { 3,5,1,15,7,6 };
            int[] numbers = new[] { 3, 5 };
            int summa = 5;

            dyn = new long[summa + 1, numbers.Length + 1];
            for (int i = 0; i <= summa; i++)
            {
                for (int j = 0; j <= numbers.Length; j++)
                {
                    dyn[i, j] = -1;
                }
            }

            Rec(summa, -1);
        }
    }
}
