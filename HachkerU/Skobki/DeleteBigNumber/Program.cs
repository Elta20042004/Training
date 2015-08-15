using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteBigNumber
{
    class Program
    {

        public static int[] ToNumber(string data)
        {
            int[] myMas = new int[data.Length];

            for (var i = data.Length - 1; i >= 0; i--)
            {
                myMas[data.Length - i - 1] = (data[i] - '0');
            }
            return (myMas);
        }

        public static string ToString(int[] myMas)
        {
            char[] x = new char[myMas.Length];
            for (var i = myMas.Length - 1; i >= 0; i--)
            {
                x[myMas.Length - i - 1] = (char)(myMas[i] + '0');
            }
            string m = new string(x);
            return m;
        }

        public static int[] Delenie(int[] m)
        {
            int[] result = new int[m.Length];
            int minus = 0;
            for (var i = m.Length - 1; i >= 0; i--)
            {
                int k = (minus*10) + m[i];
                result[i] = k/2;
                minus = k - (result[i]*2);

            }
            return result;
        }
        
        
        
        
        
        
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int[] p = ToNumber(x);
            var result = Delenie(p);
            
            
            string resultStr = ToString(result);
            Console.WriteLine(resultStr);


            Console.ReadLine();
        }
    }
}
