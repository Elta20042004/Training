using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 25;
            int d = 25;
            int temp;

            temp = a + b;
            Console.WriteLine("a + b = {0}", temp);
            temp = a - b;
            Console.WriteLine("a - b = {0}", temp);
            temp = a*b;
            Console.WriteLine("a * b = {0}", temp);
            temp = b/a;
            Console.WriteLine("b / a = {0}", temp);
            temp = b%a;
            Console.WriteLine("b % a = {0}", temp);
            temp = c%a;
            Console.WriteLine("a % a = {0}", temp);
            a++;
            Console.WriteLine("a++ = {0}", a);
            b--;
            Console.WriteLine("b--  = {0}", b);
            d++;
            Console.WriteLine("d++ = {0}", d);
            ++d;
            Console.WriteLine("++d = {0}", d);
            Console.ReadLine();
        }
    }
}
