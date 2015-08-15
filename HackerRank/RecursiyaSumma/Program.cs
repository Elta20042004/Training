using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RecursiyaSumma
{
    class Program
    {
        static int[] Arr;
        static int counter = 0;
        static int n;
        static int v = 1;
        static ulong[,] dyn;

        static void See(int i)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(Arr[j]);
            }
            Console.WriteLine();
        }

        static ulong Rec3(int left, int last)
        {
            if (left == 0)
            {
                return 1;
            }

            if (dyn[left, last] != ulong.MaxValue)
            {
                return dyn[left, last];
            }

            dyn[left, last] = 0;
            for (int i = last; i <= left; i++)
            {
                dyn[left, last] += Rec3(left - i, i);
            }

            return dyn[left, last];
        }

        static void Rec2(int left, int last)
        {
            if (left == 0)
            {
                counter++;
                return;
            }

            for (int i = last; i <= left; i++)
            {
                Rec2(left - i, i);
            }
        }


        static void Rec(int i)
        {
            if (i == n)
            {
                return;
            }
            else
            {

                int pi = v;

                for (int f = pi; f <= n; f++)
                {
                    Arr[i] = f;
                    v = f;
                    int summ = 0;
                    for (int k = 0; k <= i; k++)
                    {
                        summ = summ + Arr[k];
                    }

                    if (summ == n)
                    {
                        counter++;
                        // See(i);
                    }

                    Rec(i + 1);
                }
            }

        }

        static void Main(string[] args)
        {
            n = 1000;
            Arr = new int[n];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = 0;
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            //Rec(0);
            Console.WriteLine(counter);
            Console.WriteLine(s.Elapsed);
            Console.WriteLine();

            s.Reset();
            s.Start();
            counter = 0;
            //Rec2(n, 1);
            Console.WriteLine(counter);
            Console.WriteLine(s.Elapsed);

            s.Reset();
            s.Start();
            dyn = new ulong[n + 1, n + 1];
            counter = 0;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    dyn[i, j] = ulong.MaxValue;
                }
            }
            Console.WriteLine(Rec3(n, 1));
            Console.WriteLine(s.Elapsed);
        }
    }
}
