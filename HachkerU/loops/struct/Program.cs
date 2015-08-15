using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    class Program
    {
        struct Car
        {
            public int carID;
            public string carName;
            public string carColor;
            public string carMake;
        }
        
        static void Main(string[] args)
        {
            Car carVar1 = new Car();
            Car carVar2 = new Car();

            carVar1.carID = 1234;
            carVar1.carName = "Audi";
            carVar1.carColor = "navy";
            carVar1.carMake = "bebebe";

            carVar2.carID = 5678;
            carVar2.carName = "Mazda";
            carVar2.carColor = "navy";
            carVar2.carMake = "mememe";

            Console.WriteLine("{0}: {1},{2},{3};", carVar1.carName, carVar1.carID, carVar1.carColor, carVar1.carMake);
            Console.WriteLine("{0}: {1},{2},{3};", carVar2.carName, carVar2.carID, carVar2.carColor, carVar2.carMake);
            Console.ReadLine();
        }
    }
}
