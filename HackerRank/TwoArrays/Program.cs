using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoArrays
{
    class Program
    {
        public static void test(int[] A, int[] B, int summa)
        {
            string otvet = "YES";

            int i = A.Length - 1;
            while (i>=0)
            {
                if (A[i] + B[i] < summa)
                {
                   otvet = "NO";
                    break;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine(otvet);
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] dannye = Console.ReadLine().Split(' ');
                int length = int.Parse(dannye[0]);
                int summa = int.Parse(dannye[1]);

                string[] massivA = new string[length];
                massivA = Console.ReadLine().Split(' ');
                int[] A = massivA.Select(ch => int.Parse(ch.ToString())).ToArray();
                Array.Sort(A);

                string[] massivB = new string[length];
                massivB = Console.ReadLine().Split(' ');
                int[] B = massivB.Select(ch => int.Parse(ch.ToString())).ToArray();
                Array.Sort(B);
                Array.Reverse(B);
                test(A, B, summa);
            }
        }
    }
}
