using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summary_Ranges
{
    class Program
    {
        public static IList<string> SummaryRanges(int[] nums)
        {
            IList<string> myRez = new List<string>();
            
            string Index = "";
            if (nums.Length == 0)
            {
                return myRez;
            }
            else if (nums.Length == 1)
            {
                Index = Index + nums[0];
                myRez.Add(Index);
                return myRez;
            }


            int j = 0;
            int i = 1;

            int proverka = nums[j];
            while (i < nums.Length)
            {
                if (nums[i] - nums[j] == 1)
                {
                    Index = Index + nums[j];
                }
                else
                {
                    if (Index.Length > 1)
                    {
                        string rez = Index[0].ToString() + '-' + '>' + Index[Index.Length - 1];
                        myRez.Add(rez);
                    }
                    else
                    {
                        myRez.Add(nums[j].ToString());
                    }
                    Index = "";
                }
                i++;
                j++;

            }

         
            return myRez;

        }

        static void Main(string[] args)
        {
            int[] num = new int[] { 2,1,2,4,5,7 };
            SummaryRanges(num);
        }
    }
}
