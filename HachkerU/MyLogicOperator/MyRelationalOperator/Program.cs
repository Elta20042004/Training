using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRelationalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("a == b {0}", a == b);
            Console.WriteLine("a != b {0}", a != b);
            Console.WriteLine("a > b {0}", a > b);
            Console.WriteLine("a < b {0}", a < b);
            Console.WriteLine("a >= b {0}", a >= b);
            Console.WriteLine("a <= b {0}", a <= b);
            Console.ReadLine();

        }
    }
}
