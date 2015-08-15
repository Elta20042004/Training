using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil_3
{
    public class Car
    {
        public int NumberCar { get; private set; }
        public string Name { get; private set; }
        public double RentPrice { get; private set; }
        public int NumberOfDays { get; private set; }

        public double Summa
        {
            get { return RentPrice*NumberOfDays; }
        }

        public Car()
        {

        }

        public Car(int numberCar, string name, double rentPrice)
        {
            NumberCar = numberCar;
            Name = name;
            RentPrice = rentPrice;
        }

        public Car(int numberCar, string name)
        {
            NumberCar = numberCar;
            Name = name;
        }

        public Car(int numberCar)
        {
            NumberCar = numberCar;
        }

        public double Counter(int number)
        {
            NumberOfDays += number;
            double rezult = (double)number * RentPrice;
            return rezult;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car(353662, "audi", 45.5);
            double i = car.Counter(15);

        }
    }
}
