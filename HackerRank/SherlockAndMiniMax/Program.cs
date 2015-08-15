using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndMiniMax
{
    class Program
    {
        public static int proverka(int a, int b, int seredina)
        {
            return Math.Min(seredina - a, b - seredina);
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] k = new string[t];
            k = Console.ReadLine().Split(' ');
            int[] mass = k.Select(ch => int.Parse(ch.ToString())).ToArray();
            Array.Sort(mass);
            string[] m = Console.ReadLine().Split(' ');
            int min = int.Parse(m[0]);
            int max = int.Parse(m[1]);
            int bestValue = 0;
            int bestSeredinka = 0;
            for (int i =0; i<mass.Length-1; i++)
            {
                int pervayaS = (mass[i] + mass[i + 1]) / 2;
                int tmp=0;
                if (InBounds(pervayaS, min,  max))
                {
                    tmp = proverka(mass[i], mass[i + 1], pervayaS);
                    if (tmp > bestValue)
                    {
                        bestValue = tmp;
                        bestSeredinka = pervayaS;
                    }
                }
                if (InBounds(pervayaS+1 , min, max))
                {
                    tmp = proverka(mass[i], mass[i + 1], pervayaS+1);
                    if (tmp > bestValue)
                    {
                        bestValue = tmp;
                        bestSeredinka = pervayaS+1;
                    }
                }
            }

            int minCurrent = -1;
            foreach (var v in mass)
            {
                if (minCurrent == -1 || Math.Abs(minCurrent - min) > Math.Abs(v - min))
                {
                    minCurrent = v;
                }
            }

            if (Math.Abs(minCurrent - min) >= bestValue)
            {
                bestValue = Math.Abs(minCurrent - min);
                bestSeredinka = min;
            }

            minCurrent = -1;
            foreach (var v in mass)
            {
                if (minCurrent == -1 || Math.Abs(minCurrent - max) > Math.Abs(v - max))
                {
                    minCurrent = v;
                }
            }

            if (Math.Abs(minCurrent - max) > bestValue)
            {
                bestValue = Math.Abs(minCurrent - min);
                bestSeredinka = max;
            }

            Console.WriteLine(bestSeredinka);
        }

        private static bool InBounds(int pervayaS, int min, int max)
        {
            return pervayaS >= min && pervayaS <= max;
        }
    }
}

//    5
//38 50 60 30 48
//23 69
//    69



//10
//46 64 26 82 18 106 60 138 194 22
//82 182

//166