using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelenieNaDva
{
    class Program
    {
        public static int[] ToNumber(string data)
        {
            int[] myMas = new int[data.Length];

            for (var i = 0; i <= data.Length-1; i++)
            {
                myMas[i] = (data[i] - '0');
            }
            return (myMas);
        }

        public static int Del(int[] x, int y)
        {
            
            int[] myMas = new int[x.Length+2];
            int sum = 0;
            for (var i = 0; i <= x.Length - 1; i++)
            {
                int rez = y*x[i];
                y = y/10;
                myMas[i] = rez/2;
            }
            for (var j = 0; j <= myMas.Length - 1; j++)
            {
                sum = sum + myMas[j];
            }
            return sum;
        }

        public static int Proverka(int[] x)
        {
            int[] Result = new int[x.Length + 1];  
            int counter = 0;
            
            for (var i = 0; i <= x.Length - 1; i++)
            {
                counter++;
            }
            
            char[] y = new char[counter];
            int j;
            for (j = 1; j <= y.Length - 1; j++)
            {
                y[j] = '0';
            }
            y[0] = '1';
            string k = new string(y);
            int Number = int.Parse(k);

            return (Number);
        }
          


        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int[] p = ToNumber(x);
            int k = Proverka(p);
            Del(p, k);


            Console.ReadLine();
        }
    }
}
