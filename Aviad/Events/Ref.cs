namespace Events
{
    internal class MyClass
    {
        public int a;
    }

    public class Ref
    {
        public static void SomeTest()
        {
            int x = 5;
            SomeTest1(x);

            x = 5;
            SomeTest2(ref x);

            var myC = new MyClass();
            myC.a = 5;
            SomeTest3(myC);

            var myCD = new MyClass();
            myCD.a = 5;
            SomeTest4(ref myCD);

            var myCDE = new MyClass();
            myCDE.a = 5;
            SomeTest5(myCDE);

            var myCDEF = new MyClass();
            myCDEF.a = 5;
            SomeTest6(ref myCDEF);

        }

        static void SomeTest1(int a)
        {
            a = a + 1;
        }

        static void SomeTest2(ref int a)
        {
            a = a + 1;
        }

        static void SomeTest3(MyClass A)
        {
            A.a = A.a + 1;
        }

        static void SomeTest4(ref MyClass A)
        {
            A.a = A.a + 1;
        }

        static void SomeTest5(MyClass A)
        {
            var myC = new MyClass();
            myC.a = 100500;
            A = myC;
        }

        static void SomeTest6(ref MyClass A)
        {
            var myC = new MyClass();
            myC.a = 100500;
            A = myC;
        }
    }
}