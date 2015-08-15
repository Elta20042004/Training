using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    internal class Program
    {
        //Concrete type !
        //public class Programmer : People
        //{
        //    public override void DoWork()
        //    {
        //        Console.WriteLine("Start");
        //        //Do some work
        //        Console.WriteLine("End");
        //    }
        //}


        // Abstract type !
        public abstract class People
        {
            public int Age;

            public abstract void DoWork();
        }

        public static void MyProgrammMethod(People a)
        {
            a.DoWork();
        }

        static void Main(string[] args)
        {
            
            //polimorfizm - vozmozhnost' zapuska abstraktnyh metodov, kogda esho net realizacii.
        }
    }
}
