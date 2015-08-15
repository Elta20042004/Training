using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            string myInput;
            int myInt;

            Console.WriteLine("Vvidete chislo ot 1 do 3:");
            
            //myInt = int.Parse(Console.ReadLine());

            myInput = Console.ReadLine();
            myInt = int.Parse(myInput);


            switch (myInt)
        
            {
                case 1:
                    Console.WriteLine("Good");
                    break;
                case 2:
                    Console.WriteLine("Good");
                    break;
                case 3:
                    Console.WriteLine("Good");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }                                                              
        }
    }
}
