using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int summA = 0;
            int summB = 0;
            int j = 0;
            int f = t - 1;
            for (int i = 0; i < t; i++)
            {
                string[] k = Console.ReadLine().Split(' ');
                int diagonalA = int.Parse(k[j]);
                int diagonalB = int.Parse(k[f]);
                f--;
                j++;
                summA = summA + diagonalA;
                summB = summB + diagonalB;
            }
            int otvet = Math.Abs(summA - summB);
            Console.WriteLine(otvet);
        }
    }
}
