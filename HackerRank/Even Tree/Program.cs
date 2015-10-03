using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Tree
{
    class Program
    {
        private static int[,] _matrix;
        private static int _start;
        private static int _n;
        private static int _counter = 0;

        public static int Recursion(int start)
        {
            int i = 1;
            int temp = 1;         

            while (i <= _n)
            {
                if (_matrix[start, i] == 1)
                {
                    _matrix[start, i] = -1;   //already was here
                    temp = temp + Recursion(i);
                }
                i++;
            }

            if (temp % 2 == 0)
            {
                _counter++;
            }

            return temp;
        }

        private static void Main(string[] args)
        {
            string[] length = Console.ReadLine().Split(' ');
            _n = int.Parse(length[0]);
            int m = int.Parse(length[1]);

            _matrix = new int[_n + 1, _n + 1];
            for (int j = 0; j < m; j++)
            {
                string[] shura = Console.ReadLine().Split(' ');
                int x = int.Parse(shura[0]);
                int y = int.Parse(shura[1]);

                _matrix[y, x] = 1;
            }
            _start = 1;
            int k = Recursion(_start);
            Console.WriteLine(_counter);
        }
    }
}
