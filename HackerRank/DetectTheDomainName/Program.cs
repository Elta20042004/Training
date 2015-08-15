using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DetectTheDomainName
{
    class Program
    {

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] k = new string[t];
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = Console.ReadLine();
            }

            string temp = @"https?:\/\/(www\.|ww2\.)?(?<telo>[a-zA-Z0-9\.\-]+\.[a-zA-Z0-9\.]+)";
            var regex = new Regex(temp);
            HashSet<string> rez = new HashSet<string>();
            for (int i = 0; i < k.Length; i++)
            {
                var matchs = regex.Matches(k[i]);
                foreach (var r in matchs)
                {
                    var match = (Match)r;

                    string body = match.Groups["telo"].Value;
                    rez.Add(body);

                }
            }

            var s = rez.OrderBy(str => str, new QueryParameterComparer()).ToArray();
            //.Select(f => f.Substring(2))
            //.ToArray();

            string mimimi = "";

            Array.Sort(s);
            for (int i = s.Length - 1; i >= 0; i--)
            {
                mimimi = s[i] + ';' + mimimi;
            }

            //mimimi= string.Join(";", s);
            Console.Write(mimimi.Substring(0, mimimi.Length - 1));

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
//coursera-placement-resumes.s3.amazonaws.com;coursera.org;d2wvvaown1ul17.cloudfront.net;
//eventing.coursera.org;linkedin.com;ogp.me;
//s3.amazonaws.com;schema.org;ssl.google-analytics.com;thelearningpoint.net