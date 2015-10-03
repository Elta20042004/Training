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
        private static int[] _konveer;
        private static bool[] _trueFalse;
        private static int _n;
        private static int _start;

        public static void Dejkstra()
        {
            int counter = _n;
            int index = _start;
            while (counter != 1)
            {
                //run over column k v Matrix
                for (int i = 1; i <= _n; i++)
                {
                    if (!_trueFalse[i]
                        && _matrix[index, i] != 0
                        && _konveer[index] + _matrix[index, i] < _konveer[i])
                    {
                        _konveer[i] = _konveer[index] + _matrix[index, i];
                    }
                }

                int maxValue = int.MaxValue;
                index = 0;
                for (int i = 1; i <= _konveer.Length - 1; i++)
                {
                    if ((_konveer[i] > 0) && (!_trueFalse[i]))
                    {
                        if (_konveer[i] < maxValue)
                        {
                            maxValue = _konveer[i];
                            index = i;
                        }
                    }
                }
                _trueFalse[index] = true;
                counter--;
            }

            //print to console
            for (int i = 1; i <= _konveer.Length - 1; i++)
            {
                if (_konveer[i] > 0 && _konveer[i] != int.MaxValue)
                {
                    Console.Write("{0} ", _konveer[i]);
                }
                else if (_konveer[i] == int.MaxValue)
                {
                    Console.Write("-1 ");
                }
            }

            Console.WriteLine();
        }

        public static void Podgotovka(int start)
        {
            for (int i = 1; i <= _konveer.Length - 1; i++)
            {
                _konveer[i] = int.MaxValue;
            }
            _konveer[start] = 0;
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

                    if (_matrix[x, y] > 0)
                    {
                        if (_matrix[x, y] > 0)
                        {
                            _matrix[x, y] = 6;
                            _matrix[y, x] = 6;
                        }
                    }
                    else if (_matrix[x, y] == 0)
                    {
                        _matrix[x, y] = 6;
                        _matrix[y, x] = 6;
                    }

                }

                string startString = Console.ReadLine();
                _start = int.Parse(startString);
                _konveer = new int[_n + 1];
                _trueFalse = new bool[_n + 1];

                Podgotovka(_start);
            }


        }
    }
}

