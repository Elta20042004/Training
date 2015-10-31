using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{

    //гарантирующий, что в однопоточном приложении будет единственный 
    //экземпляр класса с глобальной точкой доступа.

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
                    lock (_instance)
                    {
                        if (_instance == null)
                        {
                            _instance = new A();
                        }
                    }
                }

                return _instance;
            }
        }

        //public static A getInstance()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new A();
        //    }

        //    return _instance;
        //}
    }

    public class C
    {
        void someProcess()
        {
            //A b = A.getInstance();
            A e = A.Instance2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
