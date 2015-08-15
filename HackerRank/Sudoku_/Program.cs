using System;
class Solution
{
    static int G(int i, int j)
    { return (3 * (i / 3)) + (j / 3); }
    static int[,] g; static bool[,] h, v, k; static bool ok;
    static void s()
    {
        h = new bool[9, 10]; v = new bool[9, 10]; k = new bool[9, 10];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (g[i, j] > 0)
                {
                    int pi = g[i, j];
                    h[i, pi] = true;
                    v[j, pi] = true;
                    int index = G(i, j);
                    k[index, pi] = true;
                }
            }
        }
        Rec(0, 0);
    }
    static void Rec(int i, int j)
    {
        if (ok || i == -1)
        {
            if (!ok)
            {
                for (int m = 0; m < 9; m++)
                {
                    Console.WriteLine();
                    for (int n = 0; n < 9; n++)
                    {
                        Console.Write("{0} ", g[m, n]);
                    }
                }
            }
            ok = true;
            return;
        }
        else
        {
            int v;
            int s;
            N(i, j, out v, out s);
            if (g[i, j] == 0)
            {
                for (int t = 1; t < 10; t++)
                {
                    int p = G(i, j);
                    if ((h[i, t] == false)
                        && (Solution.v[j, t] == false)
                        && (k[p, t] == false))
                    {
                        g[i, j] = t;
                        h[i, t] = true;
                        Solution.v[j, t] = true;
                        k[p, t] = true;
                        Rec(v, s);
                        g[i, j] = 0;
                        h[i, t] = false;
                        Solution.v[j, t] = false;
                        k[p, t] = false;
                    }
                }
            }
            else
            { Rec(v, s); }
        }
    }
    static void N(int i, int j, out int e, out int c)
    {
        c = -1; e = -1;
        if (j < 8)
        {
            j++;
            c = j;
            e = i;
        }
        else if ((j == 8) && (i < 8))
        {
            j = 0;
            i++;
            c = j;
            e = i;
        }
    }
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        g = new int[9, 9];
        String l;
        String[] t;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                l = Console.ReadLine();
                t = l.Split(' ');
                for (int k = 0; k < 9; k++)
                {
                    g[j, k] = int.Parse(t[k]);
                }
            }
            s();
        }
    }
}
