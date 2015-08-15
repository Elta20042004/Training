using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterGame
{
    class Program
    {
        public static int game(ulong n, int rebenok)
        {
            while (n > 1)
            {
                ulong result = 1;
                if (ulong.MaxValue / 2 < n)
                {
                    result = ulong.MaxValue / 2 + 1;
                }
                else
                {
                    while (result < n)
                    {
                        result = result * 2;
                    }
                    result = result / 2;
                }
                n = n - result;
                rebenok++;
            }

            return rebenok;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int rebenok = 1;
                ulong n = ulong.Parse(Console.ReadLine());
                rebenok = game(n, rebenok); if (rebenok % 2 == 1)
                {
                    Console.WriteLine("Richard");
                }
                else
                {
                    Console.WriteLine("Louise");
                }
            }




        }
    }
}
//5
//6703734870638684097
//7597026128958891522
//13174607262084689114
//6959712971461184279
//12572864054437627553

//Richard
//Richard
//Louise
//Louise
//Louise