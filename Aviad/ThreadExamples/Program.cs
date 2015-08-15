using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExamples
{
    class Program
    {
        static double BlaBlu(int a, double c)
        {
            Thread.Sleep(3000);
            Console.WriteLine("current threadid = " 
                + Thread.CurrentThread.ManagedThreadId); //nomer sreda
            return a * c;
        }

        static void SingleThreaded()
        {
            Console.WriteLine("-----------SingleThreaded-----------");
            var f = BlaBlu(100, 5);
        }

        static void Example1()
        {
            Console.WriteLine("-----------Example1-----------");
            Thread th = new Thread(SingleThreaded);

            th = new Thread(() =>
            {
                var f = BlaBlu(100, 5);
            });

            th.Start();
            Thread.Sleep(3020);
        }

        private delegate double MyDelegate(int a, double c);

        static void Example2()
        {
            Console.WriteLine("-----------Example2-----------");
            MyDelegate myDelegate = BlaBlu;
            var result =myDelegate.Invoke(5,100);   //prostoj zapusk

            var asyncResult = myDelegate.BeginInvoke(5, 101, null, null); 
            // AsyncResult otslezhivanie vypolnenija
            Console.WriteLine("Is completed ? -" +asyncResult.IsCompleted);

            asyncResult.AsyncWaitHandle.WaitOne();   
            // asynchronnaya ruchka ozhidaniya
            Console.WriteLine("Is completed ? -" + asyncResult.IsCompleted);

            result = myDelegate.EndInvoke(asyncResult); // vydat' resultat
        }

        static void Example3()
        {
            Console.WriteLine("-----------Example3-----------");
            MyDelegate myDelegate = BlaBlu;
            var asyncResult1 = myDelegate.BeginInvoke(5, 101, null, null); // AsyncResult otslezhivanie vypolnenija
            var asyncResult2 = myDelegate.BeginInvoke(5, 102, null, null); // AsyncResult otslezhivanie vypolnenija
            var asyncResult3 = myDelegate.BeginInvoke(5, 103, null, null); // AsyncResult otslezhivanie vypolnenija
            var asyncResult4 = myDelegate.BeginInvoke(5, 104, null, null); // AsyncResult otslezhivanie vypolnenija
            var asyncResult5 = myDelegate.BeginInvoke(5, 105, null, null); // AsyncResult otslezhivanie vypolnenija

            asyncResult1.AsyncWaitHandle.WaitOne();   // asynchronnaya ruchka ozhidaniya
            asyncResult2.AsyncWaitHandle.WaitOne();   // asynchronnaya ruchka ozhidaniya
            asyncResult3.AsyncWaitHandle.WaitOne();   // asynchronnaya ruchka ozhidaniya
            asyncResult4.AsyncWaitHandle.WaitOne();   // asynchronnaya ruchka ozhidaniya
            asyncResult5.AsyncWaitHandle.WaitOne();   // asynchronnaya ruchka ozhidaniya

            var result1 = myDelegate.EndInvoke(asyncResult1); // vydat' resultat
            var result2 = myDelegate.EndInvoke(asyncResult2); // vydat' resultat
            var result3 = myDelegate.EndInvoke(asyncResult3); // vydat' resultat
            var result4 = myDelegate.EndInvoke(asyncResult4); // vydat' resultat
            var result5 = myDelegate.EndInvoke(asyncResult5); // vydat' resultat
        }

        private static void Example4()
        {
            Console.WriteLine("-----------Example4-----------");
            Func<int, double, double> func = BlaBlu;

            var result = func.Invoke(5, 100);   //prostoj zapusk

            var asyncResult = func.BeginInvoke(5, 101, null, null); // AsyncResult otslezhivanie vypolnenija
            Console.WriteLine("Is completed ? -" + asyncResult.IsCompleted);

            asyncResult.AsyncWaitHandle.WaitOne();   // asynchronnaya ruchka ozhidaniya
            Console.WriteLine("Is completed ? -" + asyncResult.IsCompleted);

            result = func.EndInvoke(asyncResult); // vydat' resultat
        }

        private static void Example5()
        {
            Console.WriteLine("-----------Example5-----------");
            Func<int, double, double> func = (a ,c) =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("current threadid = " 
                    + Thread.CurrentThread.ManagedThreadId);
                return a * c;
            };

            var result = func.Invoke(5, 100);   //prostoj zapusk

            var asyncResult = func.BeginInvoke(5, 101, null, null); // AsyncResult otslezhivanie vypolnenija
            Console.WriteLine("Is completed ? -" + asyncResult.IsCompleted);

            asyncResult.AsyncWaitHandle.WaitOne();   // asynchronnaya ruchka ozhidaniya
            Console.WriteLine("Is completed ? -" + asyncResult.IsCompleted);

            result = func.EndInvoke(asyncResult); // vydat' resultat
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main threadid = " 
                + Thread.CurrentThread.ManagedThreadId);
            SingleThreaded();
            Example1();
            Example2();
            Example3();
            Example4();
            Example5();
            Thread.Sleep(300000);
        }
    }
}
