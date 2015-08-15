using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Versioning;

namespace MySortirovka
{
    class Program
    {
        static Random rand = new Random();

        public static void Sortirovka(int[] temp, int min, int max)
        {
            if (max - min < 1)
            {
                return;
            }

            int seredina = temp[rand.Next(min, max)];
            int k;
            int i = min;
            int j = max;
            while (i < j)
            {
                if ((temp[i] >= seredina) && (temp[j] <= seredina))
                {
                    k = temp[i];
                    temp[i] = temp[j];
                    temp[j] = k;
                }

                if (temp[j] > seredina)
                {
                    j--;
                }
                else if (temp[i] <= seredina)
                {
                    i++;
                }
            }

            Sortirovka(temp, min, i - 1);
            Sortirovka(temp, j + 1, max);
        }

        public static void Sortirovka2(int[] temp, int min, int max)
        {
            var num = max - min + 1;
            if (num==1)
            {
                return;
            } 
            


            do
            {
                num = max - min + 1;
                if (num <= 16)
                {
                    if (num == 1)
                    {
                        return;
                    }
                    if (num == 2)
                    {
                        SwapIfGreaterWithItems(temp, min, max);
                        return;
                    }
                    if (num == 3)
                    {
                        SwapIfGreaterWithItems(temp, min, max - 1);
                        SwapIfGreaterWithItems(temp, min, max);
                        SwapIfGreaterWithItems(temp, max - 1, max);
                        return;
                    }
                    InsertionSort(temp, min, max);
                    return;
                }

                int i = min;
                int j = max;
                int seredina = temp[rand.Next(min, max)];
                while (i < j)
                {
                    if ((temp[i] >= seredina) && (temp[j] <= seredina))
                    {
                        int k = temp[i];
                        temp[i] = temp[j];
                        temp[j] = k;
                    }

                    if (temp[j] > seredina)
                    {
                        j--;
                    }
                    else if (temp[i] <= seredina)
                    {
                        i++;
                    }
                }
                Sortirovka2(temp, min, i - 1);
                min = j + 1;
            } while (min < max);
            //Sortirovka2(temp, j + 1, max);
        }

        private static void InsertionSort(int[] temp, int min, int max)
        {
            for (int i = min; i < max; i++)
            {
                int num = i;
                int value = temp[i + 1];
                while (num >= min && temp[num] > value)
                {
                    temp[num+1] = temp[num];
                    num--;
                }
                temp[num + 1] = value;
            }
        }

        private static void SwapIfGreaterWithItems(int[] temp, int a, int b)
        {
            if (a != b && temp[a] > temp[b])
            {
                int tempT = temp[a];
                temp[b] = temp[a];
                temp[b] = tempT;
            }
        }

        static void Main(string[] args)
        {

            int[] test1 = new[] { 9, 1, 6, 3, 3, 8, 4, 7, 3, 2, 1, 5 };

            var test = new int[20000000];
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = rand.Next();
            }

            var test2 = new int[test.Length];
            Array.Copy(test, test2, test.Length);
            Stopwatch s = new Stopwatch();
            s.Start();
            Array.Sort(test2);

            Console.WriteLine("Array.Sort time:{0}", s.Elapsed);

            s.Restart();

            Sortirovka2(test, 0, test.Length - 1);
            Console.WriteLine("My sort time:{0}", s.Elapsed);

        }
    }
}
