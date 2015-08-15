using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTargil02
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterX = 0;
            int counterY = 0;
            int counterZ = 0;
            int sum = 0;
            
            do
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int z = int.Parse(Console.ReadLine());
            


                for (var i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        counterX++;
                    }
                }
                for (var i = 1; i <= y; i++)
                {
                    if (y % i == 0)
                    {
                        counterY++;
                    }
                }

                for (var i = 1; i <= z; i++)
                {
                    if (z % i == 0)
                    {
                        counterZ++;
                    }
                }
                if ((counterX == 2) && (counterY == 2) && (counterZ == 2))
                {
                    sum = x + y + z;
                    Console.WriteLine(sum);
                }
   
            } while (sum==0);
           
        }
    }
}
