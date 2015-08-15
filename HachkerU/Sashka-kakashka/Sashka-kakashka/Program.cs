using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sashka_kakashka
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] signal = new[] { 1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1 };
            string rezult = " ";
            int sum = 0;

            for (int i = 0; i <= signal.Length - 1; i++)
            {
                sum = sum + signal[i];
                int p = i % 3;

                if (p == 2)
                {
                    rezult += (sum / 2).ToString();
                    sum = 0;
                }
            }
            Console.WriteLine(rezult);
            Console.ReadLine();
    


        }

 static void Main3(string[] args)
        {
            int[] signal = new[] { 1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1 };
            string rezult = " ";
            int sum=0;

            for (int i = 0; i <= signal.Length-1; i++)
            {
                int p  = (signal.Length-i)%3;
                if (p > 0)
                {
                     sum = sum + signal[i];
                }

                if (p == 1)
                {
                    if (sum > 1)
                    {
                        rezult = rezult + '1';
                    }
                    else
                    {
                        rezult = rezult + '0';
                    }
                    sum = 0;
                }
                if (p==0)
                {
                    sum = signal[i];
                }
              
            }
            Console.WriteLine(rezult);
            Console.ReadLine();


        }
        static void Main2(string[] args)
        {
            int[] signal = new[] { 1, 1, 0 };
            string rezukt = " ";
            int counter = 0;
            int j = 0;

            for (var i = 2; i <= signal.Length - 1; i = i + 3)
            {

                while (j <= i)
                {
                    if (signal[j] == 1)
                    {
                        counter++;
                    }

                    j++;
                }
                if (counter > 1)
                {
                    rezukt = rezukt + '1';
                }
                else
                {
                    rezukt = rezukt + '0';
                }
                counter = 0;
            }
            Console.WriteLine(rezukt);
            Console.ReadLine();
        }
    }
}
