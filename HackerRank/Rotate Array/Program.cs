using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array
{
    class Program
    {
        public static void Reverse(int[] nums, int startIndex, int endIndex)
        {
            int i = startIndex;
            int j = endIndex;

            while (i < j)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;

                i++;
                j--;
            }
        }

        public static void Rotate(int[] nums, int k)
        {
            if (k == 0 || nums.Length == 1)
            {
                return;
            }

            Reverse(nums, 0, nums.Length-1);

            int granica = k % nums.Length;
            Reverse(nums, 0, granica-1);

            Reverse(nums, granica, nums.Length-1);
        }

        static void Main(string[] args)
        {
            int[] num = new[] { 1, 2, 3, 4, 5, 6 };
            Rotate(num, 2);
        }
    }
}
