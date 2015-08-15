using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidPANformat
{
    class Program
    {
        //public static void proverka(char[] tz)
        //{
        //    string otvet = "YES";
        //    int test1 = 5;
        //    int test2 = 9;
        //    int i = 0;
        //    if (tz.Length != 10)
        //    {
        //        Console.WriteLine("NO");
        //    }
        //    else
        //    {
        //        while (i < test1)
        //        {
        //            if (char.IsUpper(tz[i]))
        //            {
        //                i++;
        //            }
        //            else
        //            {
        //                Console.WriteLine("NO");
        //                i = tz.Length;
        //                break;
        //            }
        //        }
        //        while (i < test2)
        //        {
        //            if (Char.IsDigit(tz[i]))
        //            {
        //                i++;
        //            }
        //            else
        //            {
        //                Console.WriteLine("NO");
        //                i = tz.Length;
        //                break;
        //            }
        //        }
        //        while (i < tz.Length)
        //        {
        //            if (char.IsUpper(tz[tz.Length - 1]))
        //            {
        //                Console.WriteLine(otvet);
        //                i++;
        //            }
        //            else
        //            {
        //                Console.WriteLine("NO");
        //                break;
        //            }
        //        }

        //    }

        //}



        public static void proverka(string k)
        {
            string temp = @"[A-Z]{5}[0-9]{4}[A-Z]{1}";
            var regex = new Regex(temp);
            var match = regex.Matches(k);

            if (match.Count>0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string k = Console.ReadLine();
                proverka(k);
            }

        }
        
    }
}
