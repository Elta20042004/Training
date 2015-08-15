using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Program
    {

        static void Main(string[] args)
        {
            int leng = int.Parse(Console.ReadLine());
            string[] k = new string[leng];
            k = Console.ReadLine().Split(' ');
            int[] numbers = k.Select(t => int.Parse(t.ToString())).ToArray();

            int minus = 0;
            int plyus = 0;
            int nol = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    minus++;
                }
                else if (numbers[i] == 0)
                {
                    nol++;
                }
                else
                {
                    plyus++;
                }
            }

            double min = (double)minus/leng;
            //min = Math.Round(min, 3);
            string result1 = min.ToString("0.000");
            Console.WriteLine(result1);

            double pol = (double)plyus/leng;
            string result2 = pol.ToString("0.000");           
            Console.WriteLine(result2);

            double nul = (double)nol/ leng ;
            string result3 = nul.ToString("0.000");
            Console.WriteLine( result3);
        }

    }
}
