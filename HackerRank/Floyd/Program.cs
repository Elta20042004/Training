using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Subtree
{

    class Program
    {
        private static int[,] _matrix;
        private static int[] _bestCurrent;

        private static bool[] _trueFalse;
        private static int _n;
        private static int startIndex;
        private static int endIndex;
        private static int t;

        private static int summ;
        public static void Dejkstra()
        {
            int counter = _n;
            int node = startIndex;
            while (t == 0)
            {
                for (int i = 1; i <= _n; i++)
                {
                    if (!_trueFalse[i]
                        && _matrix[node, i] >= 0
                        )

                    {
                        _bestCurrent[i] = _bestCurrent[node] + _matrix[node, i];


                        if (_bestCurrent[startIndex] > 0)
                        {
                            t = 1;
                            return;
                        }
                    }
                }

                for (int i = 0; i < _bestCurrent.Length; i++)
                {
                    if (!_trueFalse[i])
                    {
                        _trueFalse[i] = true;
                        node = i;
                    }
                }


            }


            Console.WriteLine(summ);
        }

        public static void Prepare()
        {
            for (int i = 1; i <= _bestCurrent.Length - 1; i++)
            {
                _bestCurrent[i] = int.MaxValue;
            }
            _bestCurrent[startIndex] = 0;

            _trueFalse[startIndex] = true;

            Dejkstra();
        }

        private static void Main(string[] args)
        {
            string[] length = Console.ReadLine().Split(' ');
            _n = int.Parse(length[1]);
            _matrix = new int[_n + 1, _n + 1];

            for (int i = 0; i < _n + 1; i++)
            {
                for (int j = 0; j < _n + 1; j++)
                {
                    _matrix[i, j] = -1;
                }
            }

            for (int j = 0; j < _n; j++)
            {
                string[] shura = Console.ReadLine().Split(' ');
                int x = int.Parse(shura[0]);
                int y = int.Parse(shura[1]);
                int r = int.Parse(shura[2]);

                _matrix[x, y] = r;
            }

            string k = Console.ReadLine();
            int t = int.Parse(k);


            for (int i = 0; i < t; i++)
            {
                string[] len = Console.ReadLine().Split(' ');
                startIndex = int.Parse(len[0]);
                endIndex = int.Parse(len[1]);

                _bestCurrent = new int[_n + 1];
                _trueFalse = new bool[_n + 1];

                Prepare();
                Console.WriteLine(summ);
            }
        }
        //70
        //-1
        //130
        //40
        //70
        //20
        //-1
        //20
    }
}
