using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polnyj_perebor
{
    class Program
    {
        public static int[] Arr;

        public static void See()
        {
            for(int i=0; i<5; i++)
            {
                Console.Write(Arr[i]);
            }
            Console.WriteLine();
        }

        public static void Rec(int i)
        {
            if (i==5)
            {
                See();               
            }
            else
            {
                for (int j=0; j<9; j++)
                {
                    Arr[i] = j;
                    Rec(i + 1);
                }
            }
        }

        static void Main(string[] args)
        {
            Arr = new int[5];
            Rec(0);
        }
    }
}
