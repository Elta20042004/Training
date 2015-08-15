using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindHackerRank
{
    class Program
    {
        public static void test(string k)
        {
            string start = @"^hackerrank";
            string end = @"hackerrank$";
            string endStart = @"^hackerrank$";

            var regexStart = new Regex(start);
            var regexEnd = new Regex(end);
            var regexEndStart = new Regex(endStart);

            var matchStart = regexStart.Match(k);
            var matchEnd = regexEnd.Match(k);
            var matchEndStart = regexEndStart.Match(k);

            if (matchEndStart.Success)
            {
                Console.WriteLine("0");
            }
            else if (matchEnd.Success)
            {
                Console.WriteLine("2");
            }
            else if (matchStart.Success)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("-1");
            }

        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string k = Console.ReadLine();
                test(k);
            }
        }
    }
}
