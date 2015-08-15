using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DetectHTMLTags
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

            string temp = @"<[ ]{0,}[a-z]{1,}[\d]{0,}";
            var regex = new Regex(temp);
            HashSet<string> rez = new HashSet<string>();
            for (int i = 0; i < k.Length; i++)
            {
                var matchs = regex.Matches(k[i]);
                foreach (var r in matchs)
                {
                    var match = (Match)r;
                    
                        
                        rez.Add(match.Value);
                    
                }
            }
            var s = rez
                .Select(f=>f.Substring(1))
                .ToArray();
            Array.Sort(s);
            string mimimi = string.Join(";", s);

            

            Console.Write(mimimi);
        }
    }
}
//a;b;div;h2;li;span;ul