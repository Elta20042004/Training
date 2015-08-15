using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kon_
{
    class Program
    {
        public static void Proverka(int a, int b, int x, int y)
        {
            List<int[]> tekushiList = new List<int[]>();
            List<int[]> varianty = new List<int[]>();

            tekushiList.Add(new int[] { a, b });

        }
        static void Main(string[] args)
        {
            string[] k = Console.ReadLine().Split(' ');
            int a = int.Parse(k[0]);
            int b = int.Parse(k[1]);
            int x = int.Parse(k[2]);
            int y = int.Parse(k[3]);

            Proverka(a, b, x, y);
        }
    }
}
