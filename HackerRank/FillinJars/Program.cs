using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FillinJars
{
    class Program
    {
        public static long temp(long m, long n, long kolkonfety)
        {
            long res = ((n - m) + 1) * kolkonfety;
            return res;
        }

        static void Main(string[] args)
        {
            string[] dannye = Console.ReadLine().Split(' ');
            long collichestvoUrn = long.Parse(dannye[0]);
            long t = long.Parse(dannye[1]);
            //int[] urny = new int[collichestvoUrn];

            long summa = 0;
            for (var k = 0; k < t; k++)
            {
                string[] dannye2 = Console.ReadLine().Split(' ');
                long i = long.Parse(dannye2[0]);
                long j = long.Parse(dannye2[1]);
                long kollichestvoKonfet = long.Parse(dannye2[2]);

                summa = summa + temp(i, j, kollichestvoKonfet);
            }


            long srednee = summa / collichestvoUrn;

            Console.WriteLine(srednee);
            Console.ReadLine();

        }
    }
}
