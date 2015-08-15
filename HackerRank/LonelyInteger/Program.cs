using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static int lonelyInteger(int[] a)
    {
        int res=0;
        int[] dubl = new int[100];
        int j = 0;
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            j = a[i];
            count++;
            dubl[j] = dubl[j]+count;
            count = 0;
        }

        for (var k = 0; k < dubl.Length; k++)
        {
            if (dubl[k] == 1)
            {
                res = k;
            }

        }



        return res;

    }
    static void Main(String[] args)
    {
        int result;
        int t = Convert.ToInt32(Console.ReadLine());
        //int[] temp = new int[t];
        //int i;
        //String move = Console.ReadLine();
        //String[] move_split = move.Split(' ');
        //for (int j = 0; j < move_split.Length; j++)
        //{
        //    i = Convert.ToInt32(move_split[j]);
        //    temp[j] = i;
        //}

        var temp = Console.ReadLine()
            .Split(' ')
            .Select(str => int.Parse(str))
            .ToArray();

        result = lonelyInteger(temp);
        Console.WriteLine(result);

    }
}
