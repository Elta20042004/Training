using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LatitudeandLongitudePairs
{
    class Program
    {

        //var match = regex.Match(str);
        //   if (match.Success)
        //   {
        //       Console.WriteLine(
        //           "CountryCode={0},LocalAreaCode={1},Number={2}", 
        //           match.Groups["country"].Value,
        //           match.Groups["local"].Value,
        //           match.Groups["number"].Value);

        public static void test(string k)
        {
            string temp =
                @"^\((?<first>[-+]?[1-9]\d*(\.\d+)?), (?<second>[-+]?[1-9]\d*(\.\d+)?)\)$";
            var regex = new Regex(temp);
            var match = regex.Match(k);
            if (match.Success)
            {
                double shirota = double.Parse(match.Groups["first"].Value);
                double dolgota = double.Parse(match.Groups["second"].Value);

                if ((shirota <= 90) && (shirota >= -90) && (dolgota <= 180) && (dolgota >= -180))
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            else
            {
                Console.WriteLine("Invalid");
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
