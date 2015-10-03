using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dejkstra
{
    class Program
    {
        private static int[,] _matrix;
        private static int[] _bestCurrent;
        private static bool[] _trueFalse;
        private static int _n;
        private static int _start;

        public static void Dejkstra()
        {
            int counter = _n;
            int node = _start;
            while (counter != 1)
            {
                //run over column k v Matrix
                for (int i = 1; i <= _n; i++)
                {
                    if (!_trueFalse[i] 
                        && _matrix[node, i] != 0
                        && _bestCurrent[node] + _matrix[node, i] < _bestCurrent[i])
                    {
                        _bestCurrent[i] = _bestCurrent[node] + _matrix[node, i];
                    }
                }

                int maxValue = int.MaxValue;
                node = 0;
                for (int i = 1; i <= _bestCurrent.Length - 1; i++)
                {
                    if ((_bestCurrent[i] > 0) && (!_trueFalse[i]))
                    {
                        if (_bestCurrent[i] < maxValue)
                        {
                            maxValue = _bestCurrent[i];
                            node = i;
                        }
                    }
                }
                _trueFalse[node] = true;
                counter--;
            }

            //print to console
            for (int i = 1; i <= _bestCurrent.Length - 1; i++)
            {
                if (_bestCurrent[i] > 0 && _bestCurrent[i] != int.MaxValue)
                {
                    Console.Write("{0} ", _bestCurrent[i]);
                }
                else if (_bestCurrent[i] == int.MaxValue)
                {
                    Console.Write("-1 ");
                }
            }

            Console.WriteLine();
        }

        public static void Prepare(int start)
        {
            for (int i = 1; i <= _bestCurrent.Length - 1; i++)
            {
                _bestCurrent[i] = int.MaxValue;
            }
            _bestCurrent[start] = 0;
            _trueFalse[start] = true;
            Dejkstra();
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
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
                    int r = int.Parse(shura[2]);

                    if (_matrix[x, y] > 0)
                    {
                        if (_matrix[x, y] > r)
                        {
                            _matrix[x, y] = r;
                            _matrix[y, x] = r;
                        }
                    }
                    else if (_matrix[x, y] == 0)
                    {
                        _matrix[x, y] = r;
                        _matrix[y, x] = r;
                    }

                }

                string startString = Console.ReadLine();
                _start = int.Parse(startString);
                _bestCurrent = new int[_n + 1];
                _trueFalse = new bool[_n + 1];

                Prepare(_start);
            }
        }
    }
}

