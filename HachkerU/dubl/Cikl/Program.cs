using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikl
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.WriteLine("i= {0}, j= {1}", i, j);
                }
            }
            Console.ReadLine();
        }
    }
}
