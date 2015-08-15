using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil03
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            for (var i = 1; i <= 10; i++)
            {
                for (var j = 1; j <= 10; j++)
                {
                    z = i*j;
                    Console.Write("{0} \t",z);
                }
                Console.WriteLine();
            }
        }
    }
}
