using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongOfPi
{
    class Program
    {
        public static string songOfPi(string k)
        {
            string pi = "314159265358979323846";
            string otvet = "";
            int count = 0;
            for (var i = 0; i <= k.Length - 1; i++)
            {
                if (k[i] != ' ')
                {
                    count++;
                }
                else
                {
                    if (count > 0)
                    {
                        otvet = otvet + count.ToString();
                    }
                    count = 0;
                }
            }
            otvet = otvet + count.ToString();
            int element = 0;
            while ((element < otvet.Length) && (element < pi.Length) && (pi[element] == otvet[element]))
            {
                element++;
            }

            if (element < otvet.Length && element < pi.Length)
            {
                otvet = "It's not a pi song.";
            }
            else
            {
                otvet = "It's a pi song.";
            }
            return otvet;
        }

        static void Main(string[] args)
        {


            int t = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < t; i++)
            {
                string test = Console.ReadLine();
                string res = songOfPi(test);
                Console.WriteLine(res);
            }

            Console.ReadLine();
        }
    }
}
