using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library_Fine
{
    class Program
    {
        // 2 7 1014
        // 1 1 1015
        //0

        //2 6 2014
        //5 7 2014
        //0
        static void Main(string[] args)
        {
            string[] k = new string[3];
            k = Console.ReadLine().Split(' ');
            int[] segodnyaVernuli = k.Select(t => int.Parse(t.ToString())).ToArray();

            string[] d = new string[3];
            d = Console.ReadLine().Split(' ');
            int[] dolzhnyByli = d.Select(t => int.Parse(t.ToString())).ToArray();

            int dolg = 0;

            if (segodnyaVernuli[2] != dolzhnyByli[2])
            {
                if (segodnyaVernuli[2] < dolzhnyByli[2])
                {
                    dolg = 0;
                }
                else
                {
                    dolg = 10000;
                }

            }
            else if (segodnyaVernuli[1] != dolzhnyByli[1])
            {
                if (segodnyaVernuli[1] < dolzhnyByli[1])
                {
                    dolg = 0;
                }
                else
                {
                     dolg = 500 * Math.Abs(segodnyaVernuli[1] - dolzhnyByli[1]);
                }
               
            }
            else if (segodnyaVernuli[0] != dolzhnyByli[0])
            {
                if (segodnyaVernuli[0] > dolzhnyByli[0])
                {
                    dolg = 15 * Math.Abs(segodnyaVernuli[0] - dolzhnyByli[0]);
                }
                else
                {
                    dolg = 0;
                }
            }
            Console.WriteLine(dolg);

        }
    }
}
