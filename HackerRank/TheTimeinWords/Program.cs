using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTimeinWords
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            Dictionary<int, string> chasy = new Dictionary<int, string>();
            chasy.Add(1, "one"); chasy.Add(11, "eleven"); chasy.Add(21, "twenty one");
            chasy.Add(2, "two"); chasy.Add(12, "twelve"); chasy.Add(22, "twenty two");
            chasy.Add(3, "three"); chasy.Add(13, "thirteen"); chasy.Add(23, "twenty three");
            chasy.Add(4, "four"); chasy.Add(14, "fourteen"); chasy.Add(24, "twenty four");
            chasy.Add(5, "five"); chasy.Add(15, "fifteen"); chasy.Add(25, "twenty five");
            chasy.Add(6, "six"); chasy.Add(16, "sixteen"); chasy.Add(26, "twenty six");
            chasy.Add(7, "seven"); chasy.Add(17, "seventeen"); chasy.Add(27, "twenty seven");
            chasy.Add(8, "eight"); chasy.Add(18, "eighteen"); chasy.Add(28, "twenty eight");
            chasy.Add(9, "nine"); chasy.Add(19, "nineteen"); chasy.Add(29, "twenty nine");
            chasy.Add(10, "ten"); chasy.Add(20, "twenty"); chasy.Add(30, "half"); chasy.Add(45, "quarter");

            int first = int.Parse(Console.ReadLine());
            //int first = 4;
            int second = int.Parse(Console.ReadLine());
            //int second = 15;
            //twenty nine minutes past seven
            if (second == 0)
            {
                Console.WriteLine("{0} o' clock", chasy[first]);             
            }
            else if (second == 15)
            {
                Console.WriteLine("quarter past {0}", chasy[first]);       
            }
            else if (second == 30)
            {
                Console.WriteLine("{0} past {1}", chasy[second], chasy[first]);
            }
            else if (second == 45)
            {
                int k = first + 1;
                Console.WriteLine("{0} to {1}", chasy[second], chasy[k]);
            }
            else if (second < 30)
            {
                Console.WriteLine("{0} minutes past {1}",  chasy[second], chasy[first]);
            }
            else
            {
                int razdnica = 60 - second;
                int k = first + 1;
                Console.WriteLine("{0} minutes to {1}", chasy[razdnica], chasy[k]);
            }
        }
    }
}
