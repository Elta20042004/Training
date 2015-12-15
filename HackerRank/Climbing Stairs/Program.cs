using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climbing_Stairs
{
    class Program
    {
        public static int[] myMass; 

        public static int Rec(int n)
        {
            if (n == 0 )
            {
                return 1;
            }
            else if ( n < 0)
            {
                return 0;
            }
         
            int k = Rec(n - 1) + Rec(n - 2);

      
            return k;
        }

        public static int ClimbStairs(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            myMass = new int[n];
            for (int i = 0; i < myMass.Length; i++)
            {
                myMass[i] = -1;
            }

            int k = Rec(n);

            return k;

        }

        static void Main(string[] args)
        {
            ClimbStairs(7);
        }
    }
}
