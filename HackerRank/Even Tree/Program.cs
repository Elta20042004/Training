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
        private static int start;
        private static int n;
        private static int counter = 1;
        private static int temp = 0;
        private static int k = 0;

        public static void Recursiya(int start)
        {
            if (k == n)
            {
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                k = i;
                if (Matrix[start, i] == 1)
                {
                    temp++;
                    start = i;
                    Matrix[start, i] = -1;   //ya tut byla
                    Recursiya(start);
                }
            }



        }


        private static void Main(string[] args)
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

                Matrix[y, x] = 1;
            }
            start = 1;
            Recursiya(start);

        }
    }
}
