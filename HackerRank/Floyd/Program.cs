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
        private static int[,] _matrixSecond;
        private static int[] _bestCurrent;
        private static bool[] _trueFalse;
        private static int _n;
        private static int _temp;
        private static int summ;

        public static void Dejkstra(int startIndex, int endIndex)
        {
            if (_temp==endIndex && _matrixSecond[startIndex, _temp] > 0)
            {
                summ = _matrixSecond[startIndex, _temp];
                if (summ == int.MaxValue)
                {
                    summ = 0;
                }
                _temp = 0;
                return;
            }
            int counter = _n;
            int node = startIndex;
            while (counter != 1)
            {
                for (int i = 1; i <= _n; i++)
                {
                    if (!_trueFalse[i]
                        && _matrix[node, i] >= 0
                        && _bestCurrent[node] + _matrix[node, i] < _bestCurrent[i])
                    {
                        _bestCurrent[i] = _bestCurrent[node] + _matrix[node, i];
                    }
                }

                int maxValue = int.MaxValue;
                node = 0;
                for (int i = 1; i <= _bestCurrent.Length - 1; i++)
                {
                    if ((_bestCurrent[i] >= 0) && (!_trueFalse[i]))
                    {
                        if (_bestCurrent[i] < maxValue)
                        {
                            maxValue = _bestCurrent[i];
                            node = i;
                            _temp = node;
                        }
                    }
                }
                _trueFalse[node] = true;
                _matrixSecond[startIndex, _temp] = maxValue;
                if (_trueFalse[endIndex] == true)
                {
                    summ = maxValue;
                    if (summ == int.MaxValue)
                    {
                        summ = 0;
                    }
                    return;
                }
                else if (node == 0)
                {
                    summ = -1;
                    return;
                }

                counter--;
            }
        }

        public static void Prepare(int startIndex, int endIndex)
        {
            for (int i = 1; i <= _bestCurrent.Length - 1; i++)
            {
                _bestCurrent[i] = int.MaxValue;
            }
            _bestCurrent[startIndex] = 0;
            _trueFalse[startIndex] = true;

            Dejkstra(startIndex, endIndex);


        }

        private static void Main(string[] args)
        {
            string[] length = Console.ReadLine().Split(' ');
            _n = int.Parse(length[1]);
            _matrix = new int[_n + 1, _n + 1];
            _matrixSecond = new int[_n + 1, _n + 1];
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
            int startIndex = 0;
            int endIndex = 0;



            for (int i = 0; i < t; i++)
            {
                string[] len = Console.ReadLine().Split(' ');
                startIndex = int.Parse(len[0]);
                endIndex = int.Parse(len[1]);

                _bestCurrent = new int[_n + 1];
                _trueFalse = new bool[_n + 1];
                Prepare(startIndex, endIndex);
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
