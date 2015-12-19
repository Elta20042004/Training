using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Size_Subarray_Sum
{
    class Program
    {

        public static List<int> test;
        public static int i;
        public static void Rec(int sum, int[] nums)
        {

            if (i >= nums.Length - 1)
            {
                return;
            }

            if (sum < 0)
            {
                test.Remove(nums[i]);
                return;
            }

            if (sum == 0)
            {
                int counter = test.Count;
            }

            i++;
            sum = sum - nums[i];
            test.Add(nums[i]);
            Rec(sum, nums);

        }


        public static int MinSubArrayLen(int sum, int[] nums)
        {
            i = -1;
            test = new List<int>();
            Rec(sum, nums);
            return 0;
        }

        static void Main(string[] args)
        {
            int[] num = new[] { 2, 3, 1, 2, 4, 3 };
            MinSubArrayLen(7, num);
        }
    }
}
