using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority_Element
{
    class Program
    {
        public static int MajorityElement(int[] nums)
        {
            Dictionary<int,int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i],1);
                }
                else
                {
                    dic[nums[i]]++;
                }
            }

            int maxI = 0;
            int max = 0;
            foreach (var i in dic)
            {
                if (i.Value > max)
                {
                    max = i.Value;
                    maxI = i.Key;
                }
            }

            return maxI;
        }

        static void Main(string[] args)
        {
            int[] nums = new []{1,1,2};

            MajorityElement(nums);
        }
    }
}
