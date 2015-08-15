using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInput = 30;

            if (myInput > 0)
            {
                Console.WriteLine("myInput is greater then 10");
            }

            if (myInput < 0)
            {
                Console.WriteLine("{0}", myInput);
            }

            if (myInput != 0)
            {
                Console.WriteLine("{0}", myInput);
            }

            if (myInput < 0 || myInput == 0)
            {
                 Console.WriteLine("{0}", myInput);
            }
            else if (myInput > 0 && myInput < 10)
            {
                Console.WriteLine("{0}", myInput);
            }
            else if (myInput > 11 && myInput < 20)
            {
                Console.WriteLine("{0}", myInput);
            }
            else if (myInput > 21 && myInput < 30)
            {
                Console.WriteLine("{0}", myInput);
            }
            else if (myInput > 30)
            {
                Console.WriteLine("{0}", myInput);
            }
        }
    }
}
