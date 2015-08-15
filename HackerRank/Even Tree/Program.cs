using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Tree
{
    class Program
    {
        public static int[,] Matrix;
        public static int[] Konveer;
        public static int n;
        private static int start;
        private static int counter=1;


        public static void Recursiya(int start)
        {

          
        

        }


        private static void Main(string[] args)
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

                    Matrix[x, y] = 1;
                    Matrix[y, x] = 1;
                }

                string startString = Console.ReadLine();
                start = int.Parse(startString);
                Konveer = new int[n + 1];
                Konveer[start] = 1;
                Recursiya(start);
            }
        }
    }
}
