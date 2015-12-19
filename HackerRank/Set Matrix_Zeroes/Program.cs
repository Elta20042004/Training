using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Matrix_Zeroes
{
    class Program
    {
        public static void ChangeHorizont(int[,] matrix, int x, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (matrix[x, i] == 0)
                {
                    if (!IVertikal.Contains(i))
                    {
                        IVertikal.Add(i);
                    }
                }
                matrix[x, i] = 0;
            }
        }


        public static void ChangeVertikal(int[,] matrix,int m)
        {
            foreach (var k in IVertikal)
            {
                for (int i = 0; i < m; i++)
                {
                    if (matrix[i, k] != 0)
                    {
                        matrix[i, k] = 0;
                    }
                }       
            }
        }

        public static HashSet<int> IVertikal;

        public static void SetZeroes(int[,] matrix)
        {         
            IVertikal = new HashSet<int>();
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        ChangeHorizont(matrix, i, n);
                        j = n;
                    }
                }
            }

            ChangeVertikal(matrix,m);
        }

        static void Main(string[] args)
        {
            int[,] mat = new int[,]
            {
                {0,0,0,5},
                {4, 3, 1, 4},
                { 0, 1, 1, 4},
                { 1, 2, 1, 3},
                { 0, 0, 1, 1}
            };

            SetZeroes(mat);
        }
    }
}
