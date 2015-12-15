using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Element
{
    class Program
    {
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else if (nums.Length == 1 && nums[0] == val)
            {
                return 0;
            }
            else if (nums.Length == 1 && nums[0] != val)
            {
                return 1;
            }
            int counter = 0;

            int i = 0;
            int j = nums.Length - 1;

            while (i<j)
            {              
                if (nums[i] == val && nums[j] != val)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;                   
                }
                else if (nums[i]!=val)
                {
                    i++;
                    counter++;
                }
                else if (nums[j]==val)
                {
                    j--;
                }
            }

            if (nums[j] != val)
            {
                counter++;
            }

            return counter;


        }

        static void Main(string[] args)
        {
            int[] num = new[] { 3,3};
            RemoveElement(num, 5);
        }
    }
}
