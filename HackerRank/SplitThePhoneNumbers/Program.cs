using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SplitThePhoneNumbers
{
    class Program
    {
        public static void proverka(string str)
        {
            string pattern = @"(?<country>\d+)[\s-]+(?<local>\d+)[\s-]+(?<number>\d+)";
            var regex = new Regex(pattern);
            var match = regex.Match(str);
            if (match.Success)
            {
                Console.WriteLine(
                    "CountryCode={0},LocalAreaCode={1},Number={2}", 
                    match.Groups["country"].Value,
                    match.Groups["local"].Value,
                    match.Groups["number"].Value);
            }
        }

        private static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string k = Console.ReadLine();
                proverka(k);
            }
        }
    }
}
