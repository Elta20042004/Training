using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculator
    {
        void Add();
        int Sub();
        int Multiple();
        int Divide();
    }

    interface ICalc2
    {
        int Multiple();
        int Sum();
    }
}
