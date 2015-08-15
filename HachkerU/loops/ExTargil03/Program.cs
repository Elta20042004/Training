using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTargil03
{
    class Program
    {
        static void Main(string[] args)
        {

            string myChoice;
            Console.WriteLine("What is the command keyword to exit a loop in C#?");
            Console.WriteLine("a. int");
            Console.WriteLine("b. continue");
            Console.WriteLine("c. break");
            Console.WriteLine("d. exit");

            do
            {

                myChoice = Console.ReadLine();


                switch (myChoice)
                {
                    case "a":
                        Console.WriteLine("Incorrect");
                        break;
                    case "b":
                        Console.WriteLine("Incorrect");
                        break;
                    case "c":
                        Console.WriteLine("Correct");
                        break;
                    case "d":
                        Console.WriteLine("Incorrect");
                        break;
                    case "y":
                        Console.WriteLine("What is the command keyword to exit a loop in C#?");
                        Console.WriteLine("a. int");
                        Console.WriteLine("b. continue");
                        Console.WriteLine("c. break");
                        Console.WriteLine("d. exit");
                        break;

                }

                if ((myChoice == "a") || (myChoice == "b") || (myChoice == "d"))
                {
                    Console.WriteLine("Again? press y to continue");
                }

            } while ((myChoice != "n") && (myChoice != "N"));




        }
    }
}
