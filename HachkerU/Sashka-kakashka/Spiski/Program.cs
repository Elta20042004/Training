using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiski
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new[] { 1, 5, 7, 11, 17, 25, 1000, 1200, 1300 };
            int[] b = new[] { 4, 7, 12, 14, 17, 31, 100, 112 };

            int[] c = new int[a.Length + b.Length];
            int i = 0;
            int j = 0;
            while (j + i < c.Length)
            {
                if ((j >= b.Length) || ((i< a.Length) && (a[i] < b[j])))
                {
                    c[j + i] = a[i];
                    i++;
                }
                else
                {
                    c[j + i] = b[j];
                    j++;
                }

            }


            for (var k = 0; k <= c.Length - 1; k++)
            {
                Console.WriteLine(c[k]);
            }


            Console.ReadLine();
        }
    }
}
