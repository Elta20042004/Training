using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kubPrChisel
{
    class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int temp = 0;
            int j;
            int k=0;
            int i = 1;
            int Summa = 0;
            while (Summa <= n)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if ((counter == 2) || (counter == 1))
                {
                    k = i * i * i;
                  
                    if (k < 9)
                    {
                        Summa++;
                    }
                    if ((k > 10) && (k < 100))
                    {
                        Summa = Summa + 2;
                    }
                    if ((k > 100) && (k < 1000))
                    {
                        Summa = Summa + 3;
                    }
                    if ((k > 1000) && (k < 10000))
                    {
                        Summa = Summa + 4;
                    }

                    
                    temp++;

                   
                }

                counter = 0;
                i++;
             
            }

            if (Summa >= n)
            {
                string P = k.ToString();
                int index = n - (Summa - P.Length);
                Console.WriteLine(P[index]);
            }
            Console.ReadLine();
        }

        private static void Main2(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string Temp = "";
            int counter = 0;
            int j;
            int k;
            int i = 1;
            while (Temp.Length < n+1)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if ((counter == 2) || (counter == 1))
                {
                    k = i * i * i;
                    Temp = Temp + k.ToString();
                }
                k = 0;
                counter = 0;
                i++;

            }

            Console.WriteLine(Temp[n]);
            Console.WriteLine(Temp);
            Console.ReadLine();
        }
    }
}
