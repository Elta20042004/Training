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
        private static int _start;

        private static int summ;
        public static void Dejkstra()                
        {         
            int counter = _n;
            int node = _start;
            while (counter != 1)
            {
                for (int i = 1; i <= _n; i++)
                {
                    if (!_trueFalse[i]
                        && _matrix[node, i] >= 0
                        && _matrix[node, i] < _bestCurrent[i])
                    {
                        _bestCurrent[i] =_matrix[node, i];                      
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
                        }
                    }
                }
                _trueFalse[node] = true;
                if (maxValue != int.MaxValue)
                {
                     summ = summ + maxValue;
                }           
                counter--;
            }

 
            Console.WriteLine(summ);
        }

        public static void Prepare()
        {
            for (int i = 1; i <= _bestCurrent.Length - 1; i++)
            {
                _bestCurrent[i] = int.MaxValue;
            }
            _bestCurrent[_start] = 0;
            _trueFalse[_start] = true;
          
            Dejkstra();
        }

        private static void Main(string[] args)
        {
            string[] length = Console.ReadLine().Split(' ');
            _n = int.Parse(length[1]);
            
            _start = 0;
            _matrix = new int[_n + 1, _n + 1];

            for (int i = 0; i < _n+1; i++)
            {
                for (int j = 0; j < _n+1; j++)
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
                _matrix[y, x] = r;
            }

            string k = Console.ReadLine();
            _start = int.Parse(k);
            
            _bestCurrent = new int[_n + 1];
            _trueFalse = new bool[_n + 1];

            Prepare();
        }
    }
    //150
    //6359060
    //    5 7
    //1 2 20
    //1 3 50
    //1 4 70
    //1 5 90
    //2 3 30
    //3 4 40
    //4 5 60
    //2
}
