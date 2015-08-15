using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = int.Parse(Console.ReadLine());
            int x = 52;
            int ostatok = x;
            
            //int min = 60;
            //int hours = 3600;
            //int day = 86400;
            float abc;
            
            if (x >= 86400)
            {
               abc = x / 86400;
               ostatok = x - (86400 * (int)Math.Round(abc));           
               Console.WriteLine("{0} day", (int)Math.Round(abc));
            }
            if (ostatok >= 3600)
            {
                abc = ostatok/3600;
                ostatok = ostatok - (3600*(int) Math.Round(abc));
                Console.WriteLine("{0} hours", (int)Math.Round(abc));
            }
            if (ostatok >= 60)
            {
                abc = ostatok/60;
                ostatok = ostatok - (60*(int) Math.Round(abc));
                Console.WriteLine("{0} min", (int)Math.Round(abc));
            }
            if (ostatok<60)
            {
                Console.WriteLine("{0} seconds", ostatok);
            }
           
        }

    }
}
