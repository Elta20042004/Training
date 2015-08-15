using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DetectTheEmailAddresses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] k = new string[t];
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = Console.ReadLine();
            }

            string temp = @"[_a-zA-Z0-9\.]+\@[a-zA-Z0-9\._]*[a-zA-Z0-9_]";
            var regex = new Regex(temp);
            HashSet<string> rez = new HashSet<string>();
            for (int i = 0; i < k.Length; i++)
            {
                var matchs = regex.Matches(k[i]);
                foreach (var r in matchs)
                {
                    var match = (Match)r;
                    if (match.Success)
                    {
                        rez.Add(match.Value);
                    }
                }
            }
            var s = rez.OrderBy(str => str, new QueryParameterComparer()).ToArray();

            //Array.Sort(s);
            //Array.Reverse(s);
            //hackers@hackerrank.com;interviewstreet@hackerrank.com;product@hackerrank.com
            string mimi = "";
            for (int i = 0; i < s.Length; i++)
            {
                mimi = s[i] + ';' + mimi;
            }
            Console.WriteLine(mimi.Substring(0, mimi.Length - 1));
        }
    }

    public class QueryParameterComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {

            return string.Compare(y, x, StringComparison.Ordinal);

        }
    }
}