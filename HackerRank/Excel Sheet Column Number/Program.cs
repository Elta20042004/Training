using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_Sheet_Column_Number
{
    class Program
    {
        public static int TitleToNumber(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum = sum + s[i] - 'a';
            }

            sum = sum + 1;
            return sum;
        }

        static void Main(string[] args)
        {
            TitleToNumber("AA");
        }
    }
}
