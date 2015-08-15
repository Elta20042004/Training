using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogicOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine("(a && b) = {0}", (a && b));
            Console.WriteLine("(a || b) = {0}", (a || b));
            Console.WriteLine("!(a && b) = {0}", !(a && b));
        }


    }
}
