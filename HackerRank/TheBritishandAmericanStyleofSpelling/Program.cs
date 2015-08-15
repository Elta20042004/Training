using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TheBritishandAmericanStyleofSpelling
{
    class Program
    {
        public static List<string[]> k;
        public static void test(string slovo)
        {
            string temp = "";
            int counter = 0;
            for (int i = 0; i <= slovo.Length - 3; i++)
            {
                temp = temp + slovo[i];
            }
            temp = temp + @"[sz]e";
            var regex = new Regex(temp);
            for (int i = 0; i < k.Count; i++)
            {
                for (int j = 0; j < k[i].Length; j++)
                {
                    var match = regex.Match(k[i][j]);
                    if (match.Success)
                    {
                        counter++;
                    }
                }

            }

            Console.WriteLine(counter);
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            k = new List<string[]>(t);
            string slovo = "";
            for (int i = 0; i < t; i++)
            {
                k.Add(Console.ReadLine().Split(' '));
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                slovo = Console.ReadLine();
                test(slovo);
            }


        }
    }
}
