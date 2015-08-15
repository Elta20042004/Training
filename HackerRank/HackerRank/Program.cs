using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class Program
    {
        public static void solve()
        {
            int k = int.Parse(Console.ReadLine());
            int tree = 1;
            while (k != 0)
            {
                if (k == 1)
                {
                    tree = tree*2;
                    k = 0;
                }
                else
                {
                    tree = tree*2;
                    k--;
                    tree = tree + 1;
                    k--;
                }
                
            }
            string rezult = Convert.ToString(tree);
            Console.WriteLine(rezult);
        }
        
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < t; i++)
            {
                solve();
            }
        }
    }
}
