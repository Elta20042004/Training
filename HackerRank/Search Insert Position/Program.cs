using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Insert_Position
{
    class Program
    {


        public static int SearchInsert(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int m = (start + end) / 2;

            while (nums[m] != target && start != m)
            {
                if (nums[m] < target)
                {
                    start = m;
                }
                else if (nums[m] > target)
                {
                    end = m;
                }
                m = (start + end) / 2;
            }

            if (nums[m] == target)
            {
                return m;
            }
            else
            {
                if (nums[start] < target)
                {
                    return start + 1;
                }
                else
                {
                    if (start != 0)
                    {
                        return start - 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
              
            }
        }

        static void Main(string[] args)
        {
            int[] k = new[] {1,3};
            int t = SearchInsert(k,4);
        }
    }
}
