using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindaWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            const string temp = @"[0-9a-zA-Z_]*";
            var regex = new Regex(temp);
            var slovar = new Dictionary<string, int>();

            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                var matchs = regex.Matches(s);
                foreach (var r in matchs)
                {
                    var match = (Match)r;
                    if (!slovar.ContainsKey(match.Value))
                    {
                        slovar.Add(match.Value, 0);
                    }
                    slovar[match.Value]++;
                }
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string slovo = Console.ReadLine();
                Console.WriteLine(slovar[slovo]);
            }
        }
    }
}
