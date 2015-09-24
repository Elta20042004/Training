using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Progam
    {
        static void Test()
        {
            Animal runnable =null;

            //runnable = new Cat();
            //runnable = new Dog();
            //runnable = new People();

            RunSome(runnable);
        }

        static void RunSome(IRunnable runner)
        {
            runner.Run();
        }
    }

    abstract class Animal : IRunnable
    {
        public abstract void Run();
    }

    interface IRunnable
    {
        void Run();
    }

    class People : IRunnable
    {
        private int currentSpeed;
        public void Run()
        {
            currentSpeed = 7;
        }
    }

    class Dog : IRunnable
    {
        private int currentSpeed;
        public void Run()
        {
            currentSpeed = 17;
        }
    }

    class Cat : Animal
    {
        private int currentSpeed;
        public override void Run()
        {
            currentSpeed = 10;
        }
    }
}
