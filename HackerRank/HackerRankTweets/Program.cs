using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRankTweets
{
    class Program
    {
        public static int proverka(string k)
        {
            int counter = 0;
            string pattern = @"[Hh]acker[Rr]ank";
            var regex = new Regex(pattern);
            var match = regex.Matches(k);
            counter=match.Count;


            return counter;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int res = 0;
            for (int i = 0; i < t; i++)
            {
                string k = Console.ReadLine().ToLower();

               res=proverka(k)+res;
            }

            Console.WriteLine(res);
        }
    }
}
