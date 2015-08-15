using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;

namespace IPAddressValidation
{
    class Program
    {
        private const string IPv4 = @"^(\d{1,3})\.(\d{1,3})\.(\d{1,3})\.(\d{1,3})$";
        private const string IPv6 = @"^[\da-f]{1,4}:[\da-f]{1,4}:[\da-f]{1,4}:[\da-f]{1,4}:[\da-f]{1,4}:[\da-f]{1,4}:[\da-f]{1,4}:[\da-f]{1,4}$";


        public static void test(string k)
        {
            var regex4 = new Regex(IPv4);
            var regex6 = new Regex(IPv6);
            var match = regex4.Match(k);

            if (match.Success)
            {
                int counter = 4;
                foreach (var group in match.Groups)
                {
                    if (group.ToString().Length <= 3)
                    {
                        int pic = int.Parse(group.ToString());
                        if (pic > 255)
                        {
                            counter--;
                            break;
                        }
                    }

                }
                if (counter == 4)
                {
                    Console.WriteLine("IPv4");
                }
                else
                {
                    Console.WriteLine("Neither");
                }

            }

            else if (regex6.IsMatch(k))
            {
                Console.WriteLine("IPv6");
            }
            else
            {
                Console.WriteLine("Neither");
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
