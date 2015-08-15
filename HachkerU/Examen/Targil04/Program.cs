using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
