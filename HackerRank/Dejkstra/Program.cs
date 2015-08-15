using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dejkstra
{
    class Program
    {
        public static int[,] Matrix;
        public static int[] Konveer;
        public static bool[] TrueFalse;
        public static int n;
        private static int start;

        public static void Dejkstra()
        {
            int counter = n;
            int index = start;
            while (counter != 1)
            {
                //begu po stolbcu k v Matrix
                for (int i = 1; i <= n; i++)
                {
                    if (!TrueFalse[i] 
                        && Matrix[index, i] != 0
                        && Konveer[index] + Matrix[index, i] < Konveer[i])
                    {
                        Konveer[i] = Konveer[index] + Matrix[index, i];
                    }
                }

                int maxValue = int.MaxValue;
                index = 0;
                for (int i = 1; i <= Konveer.Length - 1; i++)
                {
                    if ((Konveer[i] > 0) && (!TrueFalse[i]))
                    {
                        if (Konveer[i] < maxValue)
                        {
                            maxValue = Konveer[i];
                            index = i;
                        }
                    }
                }
                TrueFalse[index] = true;
                counter--;
            }
            //vyvod na ekran
            for (int i = 1; i <= Konveer.Length - 1; i++)
            {
                if (Konveer[i] > 0 && Konveer[i] != int.MaxValue)
                {
                    Console.Write("{0} ", Konveer[i]);
                }
                else if (Konveer[i] == int.MaxValue)
                {
                    Console.Write("-1 ");
                }
            }

            Console.WriteLine();
        }

        public static void Podgotovka(int start)
        {
            for (int i = 1; i <= Konveer.Length - 1; i++)
            {
                Konveer[i] = int.MaxValue;
            }
            Konveer[start] = 0;
            TrueFalse[start] = true;
            Dejkstra();
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] length = Console.ReadLine().Split(' ');
                n = int.Parse(length[0]);
                int m = int.Parse(length[1]);

                Matrix = new int[n + 1, n + 1];
                for (int j = 0; j < m; j++)
                {
                    string[] shura = Console.ReadLine().Split(' ');
                    int x = int.Parse(shura[0]);
                    int y = int.Parse(shura[1]);
                    int r = int.Parse(shura[2]);

                    if (Matrix[x, y] > 0)
                    {
                        if (Matrix[x, y] > r)
                        {
                            Matrix[x, y] = r;
                            Matrix[y, x] = r;
                        }
                    }
                    else if (Matrix[x, y] == 0)
                    {
                        Matrix[x, y] = r;
                        Matrix[y, x] = r;
                    }

                }

                string startString = Console.ReadLine();
                start = int.Parse(startString);
                Konveer = new int[n + 1];
                TrueFalse = new bool[n + 1];

                Podgotovka(start);
            }


        }
    }
}

