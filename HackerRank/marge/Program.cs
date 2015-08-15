using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marge
{
    class Program
    {
        public static int[] myNum;
        public static int counter = 1;
        public static int[] temp;
        public static int[] test = new int[myNum.Length];
        public static int k = 0;

        public static void tester()
        {
            if (counter > myNum.Length / 2)
            {
                return;
            }

            temp = new int[counter + 1];
            int enumerator = counter;
            int i = 0;
            int l = 0;
            while (i < myNum.Length)
            {
                while (enumerator >= 0)
                {
                    temp[l] = myNum[i];
                    enumerator--;
                    i++;
                    l++;
                }
                int j = temp.Length - 1;
                l = 0;
                while (l <= j)
                {
                    if (temp[l] < temp[j])
                    {
                        test[k] = temp[l];
                        l++;
                    }
                    else
                    {
                        test[k] = temp[j];
                        j--;
                    }

                    k++;
                }
                enumerator = counter;
                l = 0;
            }
            counter = counter + counter;
            tester();

        }



        static void Main(string[] args)
        {
            myNum = new[] { 5, 4, 7, 11, 2, 5, 10, 1, 6, 3 };

            tester();
        }
    }
}
