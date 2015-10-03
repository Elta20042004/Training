using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RecursiyaSumma
{
    class Program
    {
        static int[] _arr;
        static int _counter = 0;
        static int _n;
        static int _v = 1;
        static ulong[,] _dyn;

        static void See(int i)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(_arr[j]);
            }

            Console.WriteLine();
        }

        static ulong Rec3(int left, int last)
        {
            if (left == 0)
            {
                return 1;
            }

            if (_dyn[left, last] != ulong.MaxValue)
            {
                return _dyn[left, last];
            }

            _dyn[left, last] = 0;
            for (int i = last; i <= left; i++)
            {
                _dyn[left, last] += Rec3(left - i, i);
            }

            return _dyn[left, last];
        }

        static void Rec2(int left, int last)
        {
            if (left == 0)
            {
                _counter++;
                return;
            }

            for (int i = last; i <= left; i++)
            {
                Rec2(left - i, i);
            }
        }

        static void Rec(int i)
        {
            if (i == _n)
            {
                return;
            }
            else
            {

                int pi = _v;

                for (int f = pi; f <= _n; f++)
                {
                    _arr[i] = f;
                    _v = f;
                    int summ = 0;
                    for (int k = 0; k <= i; k++)
                    {
                        summ = summ + _arr[k];
                    }

                    if (summ == _n)
                    {
                        _counter++;
                        // See(i);
                    }

                    Rec(i + 1);
                }
            }
        }

        static void Main(string[] args)
        {
            _n = 1000;
            _arr = new int[_n];
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = 0;
            }

            Stopwatch s = new Stopwatch();
            s.Start();
            //Rec(0);
            Console.WriteLine(_counter);
            Console.WriteLine(s.Elapsed);
            Console.WriteLine();

            s.Reset();
            s.Start();
            _counter = 0;
            //Rec2(n, 1);
            Console.WriteLine(_counter);
            Console.WriteLine(s.Elapsed);

            s.Reset();
            s.Start();
            _dyn = new ulong[_n + 1, _n + 1];
            _counter = 0;
            for (int i = 0; i <= _n; i++)
            {
                for (int j = 0; j <= _n; j++)
                {
                    _dyn[i, j] = ulong.MaxValue;
                }
            }
            Console.WriteLine(Rec3(_n, 1));
            Console.WriteLine(s.Elapsed);
        }
    }
}
