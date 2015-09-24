using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Modified
{
    class Program
    {
        private static int c;

        static void Recursiya(int a, int b)
        {
            int summa = a + b;
            if (c == 0)
            {
                return;
            }

            a = b;
            b = summa;
            c--;
            Recursiya(a, b);
        }


        static void Main(string[] args)
        {
            //string[] k = Console.ReadLine().Split(' ');
            //int a = int.Parse(k[0]);
            //int b = int.Parse(k[1]);
            //int c = int.Parse(k[3]);

            int a = 0;
            int b = 1;
            c = 5;
            Recursiya(a, b);


            //int summ = 0;
            //int counter = 0;
            //while (summ!=c)
            //{
            //    summ = a + b;
            //    a = b;
            //    b = summ;
            //    counter++;
            //}


        }
    }
}

//84266613096281243382112
//0 1 10
