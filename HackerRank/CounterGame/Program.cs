using System;

namespace CounterGame
{
    class Program
    {
        public static int Game(ulong n, int player)
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
                player++;
            }

            return player;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int player = 1;
                ulong n = ulong.Parse(Console.ReadLine());
                player = Game(n, player); if (player % 2 == 1)
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