using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_SherlockAndAnagrams
{
    class Program
    {
        public static void test(string f, string s)
        {
            int[] numbers = new int[26];          
            string otvet = "NO";
            int t = 0;
            for (int i = 0; i < f.Length; i++)
            {
                t = f[i] - 'a';
                numbers[t] = numbers[t] + 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                int k = s[i] - 'a';
                if (numbers[k] > 0)
                {
                    otvet = "YES";
                    break;
                }
            }

            Console.WriteLine(otvet);
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] numbers = new int[26];
            for (int i = 0; i < t; i++)
            {
                string f = Console.ReadLine().ToLower();
                string s = Console.ReadLine().ToLower();
                test(f, s);
            }
        }
    }
}
