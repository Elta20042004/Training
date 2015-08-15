using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umnozhenie
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

        public static int[] UmnozhenieToKey(int[] m, int k)
        {
            int[] n = new int[m.Length + 2];
            int temp = 0;
            int i ;
            for (i = 0; i <= m.Length - 1; i++)
            {
                n[i] = ((m[i] * k) + temp) % 10;
                temp = (m[i] * k) / 10;
            }
            if (temp>0)
            {
                n[i] = temp;
            }
            return n;
        }

        public static int[] Summa(int[] m, int[] n)
        {
            int[] sum = new int[m.Length + 1];
            int[] summa = new int[sum.Length];
            int temp = 0;
            int i;
            for (var j = 0; j <= n.Length-1; j++)
            {
                summa[j] = n[j];
            }
            for (i = 0; i <= m.Length - 1; i++)
            {
                sum[i] = (m[i] + summa[i] + temp) % 10;
                temp = (m[i] + summa[i]) / 10;
            }
            if (temp != 0)
            {
                sum[i] = temp;
            }
            return (sum);
        }

        public static int[] Sdvig(int[] m, int k)
        {
            int[] sdvig = new int[m.Length + k];

            int temp = 0;
            for (var i = m.Length - 1; i >= 0; i--)
            {
                sdvig[i + k] = m[i];
            }
            return (sdvig);
        }
        // result = Summa(mnozhenie, result)

        public static int[] Umnozhenie(int[] m, int[] n)
        {
            int[] temp = new int[m.Length + m.Length + n.Length];
            int[] umnozhenie = new int[m.Length + m.Length + n.Length];
            
            for (var i = 0; i <= n.Length - 1; i++)
            {
                temp = UmnozhenieToKey(m, n[i]);
                temp=Sdvig(temp, i);
                umnozhenie = Summa(umnozhenie, temp);
            }
            umnozhenie = Zerro(umnozhenie);
            return umnozhenie;
        }

        public static int[] Zerro(int[] m)
        {
           // int[] temp = new int[m.Length];
            int i = m.Length-1;
            while (m[i] == 0)
            {
                i--;
            }
            int[] temp = new int[i+1];
            int q = 0;
            Array.Copy(m,temp,i+1);
            return temp;
        }
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();           
            int[] p = ToNumber(x);
            int[] v = ToNumber(y);
            var result = Umnozhenie(p, v);
            string resultStr = ToString(result);
            Console.WriteLine(resultStr);
                
               
            Console.ReadLine();

        }
    }
}
