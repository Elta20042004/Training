using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Modified
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] k = Console.ReadLine().Split(' ');
            decimal first = int.Parse(k[0]);
            decimal second = int.Parse(k[1]);
            int counter = int.Parse(k[3]);


            //decimal first = 1;
            //decimal second = 0;
            //int counter = 10;


            int i = 1;
            decimal sum = 0;
            while (i<counter)
            {               
                sum= first + (second*second) ;
                first=second;
                second=sum;
                i++;
            }

            //sum= Math.Round(sum,)
            Console.WriteLine(sum);
        }
    }
}

//84266613096281243382112
//0 1 10
