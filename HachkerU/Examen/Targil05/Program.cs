using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil05
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            bool correctAnswer;
            int answer;
            int z;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = ", x, y);

            z = int.Parse(Console.ReadLine());
            answer = x + y;

            correctAnswer = answer == z;
            Console.WriteLine("{0}!",correctAnswer);          

            if (!correctAnswer)
            {
                Console.WriteLine("={0}", answer);
            }



        }

        private static void Main2(string[] args)
        {

            bool correctAnswer = true;
            int answer;
            int z;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = ", x, y);

            do
            {
                z = int.Parse(Console.ReadLine());
                answer = x + y;


                if (answer == z)
                {
                    Console.WriteLine(correctAnswer);
                }
                else if (answer != z)
                {
                    Console.WriteLine("!");
                    Console.WriteLine("=");

                }
            } while (answer != z);

        }
    }
}
