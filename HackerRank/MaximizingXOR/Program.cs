using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximizingXOR
{
    class Program
    {
        static int maxXor(int l, int r)
        {

            int res = 0;
            for (var i = l; i <= r; i++)
            {
                for (int j = i; j <= r; j++)
                {
                    int binary = i ^ j;
                    if (res < binary)
                    {
                        res = binary;
                    }
                }
            }

            return res;
        }


        static void Main(string[] args)
        {


            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);

        }
    }
}
