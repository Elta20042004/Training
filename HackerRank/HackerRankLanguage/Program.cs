using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRankLanguage
{
    class Program
    {

        public static void test(string k)
        {
            string temp =
                @"^[0-9]{5}\s(C|CPP|JAVA|PYTHON|PERL|PHP|RUBY|CSHARP|HASKELL|CLOJURE|BASH|SCALA|ERLANG|CLISP|LUA|BRAINFUCK|JAVASCRIPT|GO|D|OCAML|R|PASCAL|SBCL|DART|GROOVY|OBJECTIVEC)$";
            var regex = new Regex(temp);
            
            if (regex.IsMatch(k))
            {
                Console.WriteLine("VALID");
            }
            else
            {
                Console.WriteLine("INVALID");
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
