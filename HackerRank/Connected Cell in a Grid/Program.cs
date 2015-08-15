using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connected_Cell_in_a_Grid
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }



    class Program
    {

        public static int Bfs(int[,] matrix, int x, int y, int m, int n)
        {
            int counter = 1;
            List<Point> tekushij = new List<Point>();
            Point point = new Point();
            point.X = x;
            point.Y = y;
            tekushij.Add(point);


            while (tekushij.Count > 0)
            {
                List<Point> sleduyushij = new List<Point>();

                foreach (var i in tekushij)
                {
                    CheckNewPoint(matrix, i.X, i.Y + 1, m, n, sleduyushij);
                    CheckNewPoint(matrix, i.X + 1, i.Y + 1, m, n, sleduyushij);
                    CheckNewPoint(matrix, i.X + 1, i.Y, m, n, sleduyushij);
                    CheckNewPoint(matrix, i.X + 1, i.Y - 1, m, n, sleduyushij);
                    CheckNewPoint(matrix, i.X, i.Y - 1, m, n, sleduyushij);
                    CheckNewPoint(matrix, i.X - 1, i.Y - 1, m, n, sleduyushij);
                    CheckNewPoint(matrix, i.X - 1, i.Y, m, n, sleduyushij);
                    CheckNewPoint(matrix, i.X - 1, i.Y + 1, m, n, sleduyushij);
                }
                counter = counter + sleduyushij.Count;
                tekushij = sleduyushij;
            }
            return counter;
        }

        private static void CheckNewPoint(int[,] matrix, int x, int y, int m, int n, List<Point> sleduyushij)
        {
            Point point;
            if ((x < m) && (y < n) && (x >= 0) && (y >= 0))
            {
                if (matrix[x, y] == 1)
                {
                    point = new Point();
                    point.X = x;
                    point.Y = y;
                    sleduyushij.Add(point);
                    matrix[x, y] = 2;
                }
            }
        }

        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] k = Console.ReadLine().Split(' ');
                int[] numbers = k.Select(t => int.Parse(t.ToString())).ToArray();
                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }
            //4
            //4
            //1 1 0 0
            //0 1 1 0
            //0 0 1 0
            //1 0 0 0

            int max = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        matrix[i, j] = 2;                      
                        int k = Bfs(matrix, i, j, m, n);
                        if (k > max)
                        {
                            max = k;
                        }               
                    }
                }            
            }
            
            Console.WriteLine(max);
        }
    }
}
