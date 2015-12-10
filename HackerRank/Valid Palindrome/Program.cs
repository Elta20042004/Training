using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Palindrome
{
    class Program
    {
        public static bool IsValid(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPalindrome(string s)
        {
            string temp = s.ToLower();
            int i = 0;
            int j = s.Length - 1;


            if (s.Length == 0)
            {
                return true;
            }

            while (i < j)
            {
                bool one = IsValid(temp[i]);
                bool two = IsValid(temp[j]);
                if (one == true && two == true)
                {
                    if (temp[i] == temp[j])
                    {
                        i++;
                        j--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (one == false)
                {
                    i++;
                }
                else if (two == false)
                {
                    j--;
                }
                else if (one == false && two == false)
                {
                    i++;
                    j--;
                }

            }


            return true;
        }

        static void Main(string[] args)
        {
        }
    }
}
