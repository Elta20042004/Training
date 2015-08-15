using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangram
{
    class Program
    {
        public static string Pangramma(char[] myChar)
        {
            string temp = " ";
            int counter = 1;
            int[] myMas = new int[26];

            for (int i = 0; i < myChar.Length; i++)
            {
                int m = myChar[i] - 'a';
                if (m > 0)
                {
                     myMas[m] = myMas[m] + counter;
                }
                else if (m==0)
                {
                     myMas[m] = myMas[m] + counter;
                }
            }

            for (int i = 0; i < myMas.Length; i++)
            {
                if (myMas[i] == 0)
                {
                    temp = "not pangram";
                    return temp;
                }
                else
                {
                    temp = "pangram";
                }
            }

            return temp;
        }
        static void Main(string[] args)
        {
            //string k = Console.ReadLine().ToLower();
            string k = "We promptly judged antique ivory buckles for the prize".ToLower();
            char[] myChar = new char[k.Length];
            myChar = k.ToCharArray();
            string result = Pangramma(myChar);
            Console.WriteLine(result);
            Console.ReadLine();
        }
//        152 560
//94 217
    }
}
