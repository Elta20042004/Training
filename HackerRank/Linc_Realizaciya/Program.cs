using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linc_Realizaciya
{
    static class Program
    {
        public static List<int> Where(this List<int> m , Func<int, bool> temp)
        {
            bool test;
            List<int> k = new List<int>();
            foreach (var i in m)
            {
                test = temp(i);

                if (test)
                {
                    k.Add(i);
                }
            }
            return k;
        }

        static void Main(string[] args)
        {
            List<int> mylist = new List<int>(new[] { 1, 54, 2, 23, -5, 2, -3, -5, -6 });
            List<int> odd = mylist.Where(i => i % 2 > 0 );
            List<int> even = mylist.Where(i => i % 2 == 0);
            List<int> positive = mylist.Where(i => i >= 0);

        }
    }
}
