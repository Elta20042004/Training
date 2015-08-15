using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SayingHi
{
    class Program
    {
        public static string test(string k)
        {
            string temp = @"^[hH][iI]\s[^dD].*";
            var regex = new Regex(temp);
            var match = regex.Match(k);
            string otvet = "";

            if (match.Success)
            {
                otvet = k;
            }

            return otvet;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<string> summa=new List<string>();
            for (int i = 0; i < t; i++)
            {
                string k = Console.ReadLine();
                summa.Add(test(k));
            }

            for (int i = 0; i < summa.Count; i++)
            {
                if (summa[i] != "")
                {
                     Console.WriteLine(summa[i]);
                }

            }


        }
    }
}
