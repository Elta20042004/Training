using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Luck
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }


    class Program
    {
        public static int m;
        public static int n;
        public static int t;
        public static int counter;
        public static int q;
        public static int w;
        public static int q1;
        public static int w1;
        public static int otvet;

        public static void MinPut(int[,] les)
        {

            List<Point> rezult = new List<Point>();

            Point point = new Point();
            point.X = q;
            point.Y = w;  //zvezda
            rezult.Add(point);

            while (counter > 0)
            {
                counter--;
                if (
                    Put(les, point.X, point.Y + 1, rezult)    //vpravo
                    || Put(les, point.X + 1, point.Y, rezult) // vniz
                    || Put(les, point.X, point.Y - 1, rezult) //vlego
                    || Put(les, point.X - 1, point.Y, rezult)  // vverh                   
                )
                {
                    point = rezult.Last();
                }
            }

            point = new Point();
            point.X = q1;
            point.Y = w1;
            rezult.Add(point);
            rezult.Reverse();
            End(les, rezult);
        }

        private static bool Put(int[,] les, int x, int y, List<Point> rezult)
        {
            Point point;
            if ((x < m) && (y < n) && (x >= 0) && (y >= 0))
            {
                if (les[x, y] == counter)
                {
                    point = new Point();
                    point.X = x;
                    point.Y = y;
                    rezult.Add(point);
                    return true;
                }
            }
            return false;
        }

        private static void End(int[,] les, List<Point> rezult)
        {
            int j = 0;
            while (j < rezult.Count-1)
            {
                if (j != 0)
                {
                    int vpravo = PutEnd(les, rezult[j].X, rezult[j].Y + 1); //vpravo
                    int vniz = PutEnd(les, rezult[j].X + 1, rezult[j].Y);  // vniz
                    int vlevo = PutEnd(les, rezult[j].X, rezult[j].Y - 1); //vlego
                    int vverh = PutEnd(les, rezult[j].X - 1, rezult[j].Y);  // vverh         

                    if (vpravo + vniz + vlevo + vverh >= 3)
                    {
                        counter++;
                    }
                }
                else
                {
                    int vpravo = PutEnd(les, rezult[j].X, rezult[j].Y + 1); //vpravo
                    int vniz = PutEnd(les, rezult[j].X + 1, rezult[j].Y);  // vniz
                    int vlevo = PutEnd(les, rezult[j].X, rezult[j].Y - 1); //vlego
                    int vverh = PutEnd(les, rezult[j].X - 1, rezult[j].Y);  // vverh         

                    if (vpravo + vniz + vlevo + vverh >= 2)
                    {
                        counter++;
                    }
                }
                j++;
            }

            if (counter == otvet)
            {
                Console.WriteLine("Impressed");
                counter = 0;
                t = 0;
            }
            else
            {
                Console.WriteLine("Oops!");
                counter = 0;
                t = 0;
            }

        }


        private static int PutEnd(int[,] les, int x, int y)
        {
            int ch = 0;
            if ((x < m) && (y < n) && (x >= 0) && (y >= 0))
            {
                if ((les[x, y] >= 0)||(les[x, y]==int.MinValue))
                {
                    ch = 1;
                }

            }
            return ch;
        }



        public static void Bfs(int[,] les, int x, int y)
        {
            List<Point> tekushij = new List<Point>();
            Point point = new Point();
            point.X = x;
            point.Y = y;
            tekushij.Add(point);

            while (t == 0)
            {
                List<Point> sleduyushij = new List<Point>();

                foreach (var i in tekushij)
                {
                    counter++;

                    CheckNewPoint(les, i.X, i.Y + 1, sleduyushij); //vpravo
                    CheckNewPoint(les, i.X + 1, i.Y, sleduyushij);  // vniz
                    CheckNewPoint(les, i.X, i.Y - 1, sleduyushij); //vlego
                    CheckNewPoint(les, i.X - 1, i.Y, sleduyushij);  // vverh

                    //if (pravo + vniz + vlego + vverh >= 2)
                    //{
                    //    counter++;
                    //}

                }
                tekushij = sleduyushij;
            }

            MinPut(les);

        }

        private static int CheckNewPoint(int[,] les, int x, int y, List<Point> sleduyushij)
        {
            Point point;
            int ch = 0;
            if ((x < m) && (y < n) && (x >= 0) && (y >= 0))
            {
                if (les[x, y] == 0)
                {
                    point = new Point();
                    point.X = x;
                    point.Y = y;
                    sleduyushij.Add(point);
                    les[x, y] = counter;
                    ch = 1;
                }
                else if (les[x, y] == int.MinValue)
                {
                    ch = 1;
                    t = 1;               
                }
            }
            return ch;
        }


        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] k = Console.ReadLine().Split(' ');
                m = int.Parse(k[0]);
                n = int.Parse(k[1]);
                char[,] les = new char[m, n];
                for (int j = 0; j < m; j++)
                {
                    string p = Console.ReadLine();
                    for (int l = 0; l < p.Length; l++)
                    {
                        les[j, l] = p[l];
                    }
                }
                int[,] numbers = new int[m, n];
                for (int j = 0; j < m; j++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        if (les[j, l] == 'M')
                        {
                            numbers[j, l] = int.MaxValue;
                            q1 = j;
                            w1 = l;
                        }
                        else if (les[j, l] == '*')
                        {
                            numbers[j, l] = int.MinValue;
                            q = j;
                            w = l;
                        }
                        else if (les[j, l] == 'X')
                        {
                            numbers[j, l] = -1;
                        }
                        else if (les[j, l] == '.')
                        {
                            numbers[j, l] = 0;
                        }
                    }
                }

                otvet = int.Parse(Console.ReadLine());

                for (int j = 0; j < m; j++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        if (numbers[j, l] == int.MaxValue)
                        {
                            Bfs(numbers, j, l);
                            break;
                        }
                    }

                }
            }
        }
    }
}
//Oops!
//Oops!
//Impressed
//Oops!
//Impressed
//Impressed
//Impressed
//Oops!
//Impressed