using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTargil01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            string x="";

            for (i = 1; i <= 7; i++)
            {
                x = x + i.ToString();
                Console.Write(x);

                for (j = 7; j > i; j--)
                {

                    Console.Write("{0}", "*");
                }
                
                Console.WriteLine();               
            }
        }
    }
}
