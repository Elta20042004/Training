using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MyCalculator : ICalculator, ICalc2
    {
        public void Add()
        {
            int x = 3;
            int y = 5;
        }

        public int Sub()
        {
            int x = 3;
            int y = 5;
            return x - y;
        }

        int ICalculator.Multiple()
        {
            int x = 3;
            int y = 5;
            return x * y;
        }

        public int Divide()
        {
            int x = 3;
            int y = 5;
            return x / y;
        }

        int ICalc2.Multiple()
        {
            int x = 8;
            int y = 2;
            return x * y;
        }

        public int Sum()
        {
            int x = 8;
            int y = 2;
            return x + y;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ICalc2 mu= new MyCalculator();
            Console.WriteLine(mu.Sum());
        }
    }
}
