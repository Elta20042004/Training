using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // Observer pattern
    public class Program
    {
        private static void Main(string[] args)
        {
            Ref.SomeTest();
            Calculator c = new Calculator();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            c.Calculate += MyCalculate;
            c.ShowCalculate(a,b);
        }

        private static void MyCalculate(int a, int b)
        {
            Console.WriteLine("a^b = {0}", Math.Pow(a,b));
        }
    }

    public class Calculator
    {
        public delegate void MyDelegate(int a, int b);

        public event MyDelegate Calculate;

        public Calculator()
        {
            Calculate += ShowSumm;
            Calculate += ShowSubstr;
            Calculate += (a, b) => Console.WriteLine("a * b = {0}", a * b);
            Calculate += (a, b) => Console.WriteLine("a / b = {0}", a / b);
        }

        public void ShowCalculate(int a, int b)
        {
            Calculate.Invoke(a,b);
        }

        private static void ShowSubstr(int a, int b)
        {
            Console.WriteLine("a - b = {0}", a - b);
        }

        private static void ShowSumm(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }
    }
}
