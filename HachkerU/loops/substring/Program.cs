using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "HEEEELLOOOO";
            string world = "w#o#r#l#d";

            string x = hello.Substring(0, 2) + hello.Substring(5, 2) + hello.Substring(7, 1);
            string y = world.Substring(0, 1) + world.Substring(2, 1) + world.Substring(4, 1) + world.Substring(6, 1) +
                       world.Substring(8, 1);
            Console.WriteLine("{0} {1}!", x,y);
            Console.ReadLine();

        }
    }
}
