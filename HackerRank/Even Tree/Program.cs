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
        private static int counter = 0;

        public static int Recursiya(int start)
        {
            int i = 1;
            int temp = 1;         

            while (i <= n)
            {
                if (Matrix[start, i] == 1)
                {
                    Matrix[start, i] = -1;   //ya tut byla
                    temp = temp + Recursiya(i);
                }
                i++;
            }

            if (temp % 2 == 0)
            {
                counter++;
            }

            return temp;
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
            int k = Recursiya(start);
            Console.WriteLine(counter);
        }
    }
}
