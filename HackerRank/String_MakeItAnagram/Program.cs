using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_MakeItAnagram
{
    class Program
    {
        private static void Main(string[] args)
        {
            string first = Console.ReadLine().ToLower();
            char[] charFirst;
            charFirst = first.ToCharArray();
            string second = Console.ReadLine().ToLower();
            char[] charSecond;
            charSecond = second.ToCharArray();
            int summ = charFirst.Length + charSecond.Length;
            
            for (int i = 0; i < charFirst.Length; i++)
            {
                for (int j = 0; j < charSecond.Length; j++)
                {
                    if (charFirst[i] == charSecond[j])
                    {
                        charSecond[j] = ' ';
                        summ = summ - 2;
                        break;
                    }
                }                                                       
            }

           
            Console.WriteLine(summ);

        }

      
    }
}
