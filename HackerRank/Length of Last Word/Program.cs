using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_Last_Word
{
    class Program
    {
        public static int LengthOfLastWord(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            int counter = 0;
            int j = s.Length - 1;
            string temp = "";

            while ((j >= 0) && ((s[j] < 'a' && s[j] < 'A') || (s[j] > 'z' && s[j] > 'Z')))
            {
                j--;
            }

            while (j >= 0)
            {
                if (s[j] != ' ')
                {
                    temp = temp + s[j];
                }
                else
                {
                    break;
                }

                j--;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if ((temp[i] >= 'a' && temp[i] <= 'z') || (temp[i] >= 'A' && temp[i] <= 'Z'))
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main(string[] args)
        {
        }
    }
}
