using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if ((x >= 0) && (x <= 100))
            {
                Console.WriteLine("Good");
            }
            else
            {
               Console.WriteLine("Bad");
            }
        }
    }
}
