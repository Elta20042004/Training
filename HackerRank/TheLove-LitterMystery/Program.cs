using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLove_LitterMystery
{
    class Program
    {
        public static int palindrom(string k)
        {
            int count=0;
            int j = k.Length - 1;
            int i = 0;
            while (i < (k.Length)/2)
            {
                if (k[i] != k[j])
                {
                    int g = k[i] - k[j];
                    count=Math.Abs(g)+count;
                }
                    i++;
                    j--;            
            }


            return count;
        }
           
        

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (var i = 0; i < t; i++)
            {
                string k = Console.ReadLine();
                int m = palindrom(k);
                Console.WriteLine(m);
            }
            Console.ReadLine();
        }
    }
}
