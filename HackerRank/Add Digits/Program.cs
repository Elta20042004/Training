using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Digits
{
    class Program
    {

        public static int AddDigits(int num)
        {
            string t = num.ToString();
            bool ok = true;
            int sum = 0;
            while (ok)
            {

                int p = 0;
                for (int i = p; i < t.Length; i++)
                {
                    sum = sum + int.Parse(t[i].ToString());
                }

                string temp = sum.ToString();

                if (temp.Length == 1)
                {
                    return sum;
                }

                t = temp;
                sum = 0;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int k = AddDigits(38);
        }
    }
}
