using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class Program
    {
        public static void test(string k, int m)
        {            
            int counter = 0;
            for (int i = 0; i < k.Length; i++)
            {
                int p = k[i] - '0';
                if ((p!=0)&&(m%p == 0))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);


        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string k = Console.ReadLine();
                int m = int.Parse(k);
                test(k,m);
            }
        }
    }
}
