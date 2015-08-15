using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtopianIdentificationNumber
{
    class Program
    {
        public static void test(string k)
        {
            string temp = @"^[a-z]{0,3}[0-9]{2,8}[A-Z]{3,}$";
            var regex = new Regex(temp);
            var match = regex.Match(k);

            if (match.Success)
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
//INVALID
//INVALID
//VALID
//VALID
//INVALID
//VALID
//INVALID
//INVALID
//INVALID
//INVALID
//INVALID
//INVALID
//VALID
//VALID
//INVALID
//INVALID
//INVALID
//INVALID
//VALID
//INVALID
//INVALID
//INVALID
//INVALID
//INVALID
//INVALID
//INVALID
//INVALID
//INVALID
//INVALID
//INVALID
//VALID
//INVALID
//INVALID
//VALID
//INVALID
//INVALID
//VALID
//VALID
//INVALID
//VALID
//INVALID
//INVALID
//INVALID
//INVALID