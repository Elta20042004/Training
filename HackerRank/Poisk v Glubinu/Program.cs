using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poisk_v_Glubinu
{
    class Program
    {
        public static int m;
        public static int n;
        public static int zvezdaX;
        public static int zvezdaY;
        public static int nachaloX;
        public static int nachaloY;
        public static char[,] les;
        public static int counter;
        public static int otvet;


        public static int Glubina(int x, int y)
        {
            if ((x >= m) || (y >= n) || (x < 0) || (y < 0) || les[x, y] == 'X' || les[x, y] == '_')
            {
                return -1;
            }
            if (les[x, y] == '*')
            {
                return counter;
            }
            int vpravo = PutEnd(x, y + 1); //vpravo
            int vniz = PutEnd(x + 1, y);    // vniz
            int vlevo = PutEnd(x, y - 1);   //vlego
            int vverh = PutEnd(x - 1, y);  // vverh  
            int perekrestok = 0;
            if (les[x, y] == 'M'
                && (vpravo + vniz + vlevo + vverh >= 2))
            {
                perekrestok = 1;
            }
            else if (vpravo + vniz + vlevo + vverh >= 3)
            {
                perekrestok = 1;
            }

            counter += perekrestok;
            char prev = les[x, y];
            les[x, y] = '_';
            int k = -1;
            if ((k = Glubina(x, y + 1)) >= 0
                || (k = Glubina(x + 1, y)) >= 0
                || (k = Glubina(x, y - 1)) >= 0
                || (k = Glubina(x - 1, y)) >= 0)
            {
            }
            les[x, y] = prev;
            counter -= perekrestok;
            return k;
        }

        public static int PutEnd(int x, int y)
        {
            int ch = 0;
            if ((x < m) && (y < n) && (x >= 0) && (y >= 0))
            {
                if (les[x, y] == '.' || les[x, y] == '_' || les[x, y] == 'M' || les[x, y] == '*' )
                {
                    ch = 1;
                }
            }
            return ch;
        }

        private static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] k = Console.ReadLine().Split(' ');
                m = int.Parse(k[0]);
                n = int.Parse(k[1]);
                les = new char[m, n];
                counter = 0;
                for (int j = 0; j < m; j++)
                {
                    string p = Console.ReadLine();
                    for (int l = 0; l < p.Length; l++)
                    {
                        les[j, l] = p[l];
                        if (les[j, l] == '*')
                        {
                            zvezdaX = j;
                            zvezdaY = j;
                        }
                        else if (les[j, l] == 'M')
                        {
                            nachaloX = j;
                            nachaloY = l;
                        }
                    }
                }
                otvet = int.Parse(Console.ReadLine());
                counter = Glubina(nachaloX, nachaloY);
                if (counter == otvet)
                {
                    Console.WriteLine("Impressed");
                }
                else
                {
                    Console.WriteLine("Oops!");
                }
            }
        }
    }
}

//Impressed
//Impressed
//Oops!
