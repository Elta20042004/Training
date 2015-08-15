using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlienUsername
{
    class Program
    {
        public static void test(string k)
        {
            string temp = @"^[_\.]\d{1,}[a-z,A-Z]{0,}[_]{0,}$";
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
