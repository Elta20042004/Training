using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        public static void Sale(int[] numbers, int friends)
        {
            int summa = 0;
            int i = numbers.Length - 1;
            int counter = friends;
            int j = 1;
            while (i>=0)
            {
                while ((counter > 0)&&(i>=0))
                {
                    summa = summa + (numbers[i]*j);                   
                    i--;
                    counter--;
                }

                j++;
                counter = friends;
            }
            Console.WriteLine(summa);
        }

        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Split(' ');
            int length = int.Parse(t[0]);
            int friends = int.Parse(t[1]);
            string[] m = new string[length];
            m = Console.ReadLine().Split(' ');
            int[] numbers = m.Select(ch => int.Parse(ch.ToString())).ToArray();
            Array.Sort(numbers);
            Sale(numbers, friends);
        }
    }
}
