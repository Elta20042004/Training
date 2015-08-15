using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil07
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int temp = x;
            if (temp < y)
            {
                temp = y;
            }

            if (temp < z)
            {
                temp = z;
            }

            Console.WriteLine(temp);
            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            if ((x >= y) && (x >= z))
            {
                Console.WriteLine(x);
            }
            else if ((y >= x) && (y >= z))
            {
                Console.WriteLine(y);
            }
            else if ((z >= x) && (z >= y))
            {
                Console.WriteLine(z);
            }

            Console.ReadLine();
        }
    }
}
