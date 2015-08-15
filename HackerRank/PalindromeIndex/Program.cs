using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIndex
{
    class Program
    {
        
        
        public static int index(string k)
        {
            int res = -1;
            int i = 0;
            int j = k.Length - 1;
            while (i < j)
            {
                if (k[i] == k[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    if ((k[i]==k[j-1])&&(k[i+1]==k[j-2]))
                    {
                        res = j;
                        return res;
                    }
                    else
                    {
                        res = i;
                        return res;
                    }
                }
            }
  
            return res;
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (var i = 0; i < t; i++)
            {
                string palindrom = Console.ReadLine();
                //char[] myChar = new char[palindrom.Length];
                //myChar = palindrom.ToCharArray();
                int palindromeIndex = index(palindrom);
                Console.WriteLine(palindromeIndex);
            }
            Console.ReadLine();
        }
    }
}
