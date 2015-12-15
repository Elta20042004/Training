using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Duplicate
{
    class Program
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                   dic.Add(nums[i],1);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] num = new[] {1, 2, 3, 4, 4, 5};
            ContainsDuplicate(num);
        }
    }
}
