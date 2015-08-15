using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_Tutorial_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int element = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            string[] k = Console.ReadLine().Split(' ');
            int[] numbers = k.Select(ch => int.Parse(ch.ToString())).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == element)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
