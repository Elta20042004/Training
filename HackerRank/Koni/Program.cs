using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Koni
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        public static int t;
        public static int counter;
        private static int second_X;
        private static int second_Y;
        private static int m;
        private static int n;

        public static int Bfs(int[,] matrix, int x, int y)
        {
            List<Point> tekushij = new List<Point>();
            Point point = new Point();
            point.X = x;
            point.Y = y;
            tekushij.Add(point);
            matrix[x, y] = counter;
           counter ++;

            while (t == 0)
            {
                List<Point> sleduyushij = new List<Point>();

                foreach (var i in tekushij)
                {
                    last_Hod(matrix, i.X + 1, i.Y + 2, sleduyushij);
                    last_Hod(matrix, i.X + 2, i.Y + 1, sleduyushij);
                    last_Hod(matrix, i.X + 2, i.Y - 1, sleduyushij);
                    last_Hod(matrix, i.X + 1, i.Y - 2, sleduyushij);
                    last_Hod(matrix, i.X - 1, i.Y - 2, sleduyushij);
                    last_Hod(matrix, i.X - 2, i.Y - 1, sleduyushij);
                    last_Hod(matrix, i.X - 2, i.Y + 1, sleduyushij);
                    last_Hod(matrix, i.X - 1, i.Y + 2, sleduyushij);
                }

                tekushij = sleduyushij;
                counter++;
            }
            return counter;
        }

        public static void last_Hod(int[,] matrix, int x, int y, List<Point> sleduyushij)
        {
            Point point = new Point();
            if ((x < m) && (y < n) && (x >= 0) && (y >= 0))
            {
                if (((x != second_X) && (y == second_Y))||((x == second_X) && (y != second_Y))||((x!= second_X)&&(y != second_Y)))
                {
                    if (matrix[x, y] == 0)
                    {
                        point.X = x;
                        point.Y = y;
                        sleduyushij.Add(point);
                        matrix[x, y] = counter;
                    }
                }
                else
                {
                    t++;

                }
            }
        }

        static void Main(string[] args)
        {
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[m, n];

            string[] f = Console.ReadLine().Split(' ');
            int firs_X = int.Parse(f[0]);
            int first_Y = int.Parse(f[1]);

            string[] s = Console.ReadLine().Split(' ');
            second_X = int.Parse(s[0]);
            second_Y = int.Parse(s[1]);

            // m n - 11
            //2 2
            //10 10
            int p;

            p = Bfs(matrix, firs_X, first_Y);



            Console.WriteLine(p);

        }
    }
}
