using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignmentOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 0;

            c = a + b;
            Console.WriteLine("a + b = {0}", c);
            c += a;
            Console.WriteLine("c + = a {0}", c);
            c -= a;
            Console.WriteLine("c -= a = {0}", c);
            c *= a;
            Console.WriteLine("c *= a = {0}", c);
            Console.ReadLine();
        }
    }
}
