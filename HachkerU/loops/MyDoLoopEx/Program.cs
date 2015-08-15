using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoLoopEx
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string myChoice;

            Console.WriteLine("My Address Book\n");

            Console.WriteLine("A - Add New Address");
            Console.WriteLine("D - Delete Address");
            Console.WriteLine("M - Modify Address");
            Console.WriteLine("V - View Address");
            Console.WriteLine("Q - Quite\n");
            Console.WriteLine("Choice(A,D,M,V or Q):");


            do
            {

                myChoice = Console.ReadLine();

                switch (myChoice)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("Add New Address");
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("Delete Address");
                        break;
                    case "M":
                    case "m":
                        Console.WriteLine("Modify Address");
                        break;
                    case "V":
                    case "v":
                        Console.WriteLine("View Address");
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Quite\n");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }


            } while ((myChoice != "Q") && (myChoice != "q"));
        }
    }
}