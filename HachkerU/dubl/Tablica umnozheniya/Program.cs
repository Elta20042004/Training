using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica_umnozheniya
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int temp = 0;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    temp = i * j;

                    Console.Write("{0} ", temp);
                }
                Console.WriteLine("");
            } 
        }
        static void Main2(string[] args)
        {
            int i;
            int j;
            int temp = 0;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    temp = i * j;

                    Console.Write("{0}*{1}={2}   ", i, j, temp);
                }
                Console.WriteLine("");
            }
        }


    }
}
