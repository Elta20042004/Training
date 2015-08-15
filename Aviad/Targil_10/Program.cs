using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace Targil_10
{
    public delegate void MyDelegate(int i, double d);
    public delegate void MyDelegate2();

    public delegate int MyDelegate3(int x);

    class MyClass
    {
        public int MyMethod(int x)
        {
            Thread.Sleep(3000);
            return x*x;
        }
    }

    public class MyDelMethods   
    {
        public void InstanceMethod()
        {
            
        }

        public static void StaticMethod()
        {
            
        }

    }

    class Program
    {
        public static void MultipleNum(int i, double d)
        {
            double rez = i*d;
            Console.WriteLine(rez);
        }

        static void Main(string[] args)
        {
            //...........1
            MyDelegate myMathObj = MultipleNum;
            myMathObj.Invoke(2,6);

            //...........2
            MyDelMethods my = new MyDelMethods();
            MyDelegate2 myDel2 = my.InstanceMethod;           
            MyDelMethods.StaticMethod();

            //...........3
            MyClass myClass= new MyClass();
            MyDelegate3 myDel3 = myClass.MyMethod;
            
            var result = myDel3.Invoke(5);
            var asyncResult = myDel3.BeginInvoke(5, null, null);
            asyncResult.AsyncWaitHandle.WaitOne();
            result = myDel3.EndInvoke(asyncResult);
        }
    }
}
