using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace STRUct
{
    struct MyStruct
    {
        public int x, y;
    }

    class Program
    {
        public static void Test(MyStruct myStr)
        {
            myStr.x += 5;
            myStr.y *= 10;
        }

        static void Main(string[] args)
        {
            MyStruct myStr = new MyStruct();
            myStr.x = 5;
            myStr.y = 3;

            Test(myStr);
        }
    }
}
