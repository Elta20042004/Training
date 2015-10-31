using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{

    public class A
    {
        private static A _instance;

        private A()
        {

        }

        public static A Instance2
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new A();
                }

                return _instance;
            }
        }

        public static A getInstance()
        {
            if (_instance == null)
            {
                _instance = new A();
            }

            return _instance;
        }
    }

    public class C
    {
        void someProcess()
        {
            A b = A.getInstance();
            A e = A.Instance2;
        }
    }

















    public class Singleton<T> where T : class
    {
        protected Singleton() { }

        private sealed class SingletonCreator<S> where S : class
        {
            //Используется Reflection для создания экземпляра класса без публичного конструктора
            private static readonly S instance = (S)typeof(S).GetConstructor(
                        BindingFlags.Instance | BindingFlags.NonPublic,
                        null,
                        new Type[0],
                        new ParameterModifier[0]).Invoke(null);

            public static S CreatorInstance
            {
                get { return instance; }
            }
        }

        public static T Instance
        {
            get { return SingletonCreator<T>.CreatorInstance; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
