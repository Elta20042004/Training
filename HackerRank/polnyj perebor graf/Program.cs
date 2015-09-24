using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polnyj_perebor_graf
{
    class Program
    {

        private static int end;
        private static List<int> temp;
        private static int summ = int.MaxValue;

        static void Rec(int[,] Matrix, int startIndex)
        {
            int summTemp = 0;
            if (startIndex == end)
            {
                for (int i = 1; i < temp.Count; i++)
                {
                    summTemp = summTemp + Matrix[temp[i-1], temp[i]];
                }
            
                if (summTemp < summ)
                {
                    summ = summTemp;
                }
                
                return;            
            }

            for (int i = 0; i < 6; i++)
            {
                if (Matrix[startIndex, i] > 0)
                {
                    temp.Add(i);
                    Rec(Matrix,i);
                    temp.Remove(i);
                }
            }
            
        }

        static void Main(string[] args)
        {
            int[,] Matrix = new int[6, 6];
            Matrix[0, 1] = 4;
            Matrix[0, 2] = 3;
            Matrix[0, 3] = 7;
            Matrix[0, 4] = 2;
            Matrix[1, 4] = 6;
            Matrix[2, 3] = 5;
            Matrix[2, 4] = 3;
            Matrix[3, 4] = 1;
            Matrix[5, 4] = 6;
            int start = 0;
            end = 4;
            temp = new List<int>();
            temp.Add(start);
            Rec(Matrix, start);
            Console.WriteLine(summ);
        }
    }
}
