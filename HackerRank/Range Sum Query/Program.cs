using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Sum_Query
{

    public class NumArray
    {
        public int[] myMas;
        public NumArray(int[] nums)
        {
            myMas = new int[nums.Length];
            int prev = 0;
            int t = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                myMas[i] = nums[i] + prev;
                prev = myMas[i];
            }
        }

        public int SumRange(int i, int j)
        {
            int result;
            if (i > 0)
            {
                result = myMas[j] - myMas[i - 1];
            }
            else
            {
                result = myMas[j];
            }
            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] k = new[] { -2, 0, 3, -5, 2, -1 };
            NumArray nA = new NumArray(k);
            int a = nA.SumRange(0, 2);
            int b = nA.SumRange(0, 5);
            int c = nA.SumRange(2, 5);
            int d = nA.SumRange(2, 4);
        }
    }
}
