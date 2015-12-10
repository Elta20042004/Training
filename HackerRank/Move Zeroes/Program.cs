using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Zeroes
{
    class Program
    {
        public static void MoveZeroes(int[] nums)
        {
            int k = 0;
            int i = 0;
            while (k < nums.Length)
            {
                if (nums[k] > 0)
                {
                    nums[i] = nums[k];
                }



            }


        }

        static void Main(string[] args)
        {
            int[] num =new []{ 0, 1, 0, 3, 12 };
            MoveZeroes(num);
        }
    }
}
