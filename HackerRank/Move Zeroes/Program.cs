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
            int i = 0;
            int j = 0;

            while (i<nums.Length)
            {
                if (nums[i] > 0 || nums[i] < 0)
                {
                    nums[j] = nums[i];
                    j++;
                }
                i++;
            }

            while (j<nums.Length)
            {
                nums[j] = 0;
                j++;
            }
        }

        static void Main(string[] args)
        {
            int[] num =new []{ 0, 1, 0, 3, 12 };
            MoveZeroes(num);
        }
    }
}
