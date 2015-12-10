using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    class Program
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string rez = "";
            if (strs.Length == 0)
            {
                return rez;
            }

            bool found = false;
            int i = 0;
            int j;
            while (!found && i < strs[0].Length)
            {
                char t = strs[0][i];
                for (j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] != t)
                    {
                        found = true;
                        return rez;
                    }
                }

                rez = rez + t;

                i++;
            }

            return rez;

        }

        static void Main(string[] args)
        {
        }
    }
}
