using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelenieBigNumbers
{
    class Program
    {

        public static int[] ToNumber(string data)
        {
            int k = int.Parse(data);
            int[] myMas = new int[k];

            int j = 1;
            for (var i = 0; i <= myMas.Length - 1; i++)
            {
                myMas[i] = j;
                j = j + 1;
            }
            return (myMas);
        }

        public static int Poisk(int[] x, int k)
        {
            int min;
            int max = x.Length - 1;

            for (var i = min; i <= (min+max)/2; i++)
            {
                
            }
        }

        static void Main(string[] args)
        {
            string x = (Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[] p = ToNumber(x);

            Console.ReadLine();
        }
    }
}
