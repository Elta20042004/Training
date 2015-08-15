using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsulyaciya
{
    class EncapsulationExample
    {
        private double valueDouble;
        private string valueString;

        public double ValueDouble
        {
            get { return valueDouble; }
            set
            {
                valueDouble = value;
                valueString = value.ToString();
            }
        }

        public string ValueString
        {
            get { return valueString; }
            set
            {
                double tmp_value = Convert.ToDouble(value); //здесь может возникнуть исключение
                valueDouble = tmp_value;
                valueString = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
