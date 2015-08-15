using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWhileEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 0;

            while (myInt<=10)
            {
                Console.WriteLine(myInt);
                myInt++;
            }
            Console.ReadLine();
        }
    }
}
