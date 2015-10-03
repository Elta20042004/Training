using System;

class Solution
{
    static int[,] _matrix;
    static bool[,] _height, _width, _smallSquare;
    static bool _done;

    static void s()
    {
        _height = new bool[9, 10];
        _width = new bool[9, 10];
        _smallSquare = new bool[9, 10];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (_matrix[i, j] > 0)
                {
                    int pi = _matrix[i, j];
                    _height[i, pi] = true;
                    _width[j, pi] = true;
                    int index = G(i, j);
                    _smallSquare[index, pi] = true;
                }
            }
        }

        Rec(0, 0);
    }

    static int G(int i, int j)
    {
        return (3 * (i / 3)) + (j / 3);
    }

    static void Rec(int i, int j)
    {
        if (_done || i == -1)
        {
            if (!_done)
            {
                PrintResult();
            }
            _done = true;
            return;
        }
        int prevI = i;
        int prevJ = j;
        Increment(ref i, ref j);
        if (_matrix[i, j] != 0)
        {
            Rec(i, j);
        }
        else
        {
            for (int t = 1; t < 10; t++)
            {
                int p = G(prevI, prevJ);
                if ((_height[prevI, t] == false)
                    && (_width[prevJ, t] == false)
                    && (_smallSquare[p, t] == false))
                {
                    _matrix[prevI, prevJ] = t;
                    _height[prevI, t] = true;
                    _width[prevJ, t] = true;
                    _smallSquare[p, t] = true;
                    Rec(i, j);
                    _matrix[prevI, prevJ] = 0;
                    _height[prevI, t] = false;
                    _width[prevJ, t] = false;
                    _smallSquare[p, t] = false;
                }
            }
        }
    }

    private static void PrintResult()
    {
        for (int m = 0; m < 9; m++)
        {
            Console.WriteLine();
            for (int n = 0; n < 9; n++)
            {
                Console.Write("{0} ", _matrix[m, n]);
            }
        }
    }

    static void Increment(ref int i, ref int j)
    {
        if (j < 8)
        {
            j++;
        }
        else if (j == 8 && i < 8)
        {
            j = 0;
            i++;
        }
        else
        {
            i = -1;
            j = -1;
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        _matrix = new int[9, 9];
        string l;
        string[] t;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                l = Console.ReadLine();
                t = l.Split(' ');
                for (int k = 0; k < 9; k++)
                {
                    _matrix[j, k] = int.Parse(t[k]);
                }
            }

            s();
        }
    }
}
