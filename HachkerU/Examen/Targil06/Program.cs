using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vsego chisel: {0}", 1000 / 3);
        }

        static void Dummy(string[] args)
        {
            int t = 0;

            for (var i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    t++;
                }
            }

            Console.WriteLine("Vsego chisel: {0}", t);

        }
    }
}
