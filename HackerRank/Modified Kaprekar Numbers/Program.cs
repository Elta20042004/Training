using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modified_Kaprekar_Numbers
{
    class Program
    {
        //1 9 45 55 99 297 703 999 2223 2728 4950 5050 7272 7777 9999 17344 22222 77778 82656 95121 99999
        //1
        //99999
        
        static void Main(string[] args)
        {
            int verh = int.Parse(Console.ReadLine());
            int niz = int.Parse(Console.ReadLine());
            //int verh = 1;
            //int niz = 99999;
            string otvet = " ";
            string razdelitel;
            string first = " ";
            string second = " ";
            int summ = 0;
            for (long i = verh; i <= niz; i++)
            {
                long kvadrat = i * i;
                razdelitel = kvadrat.ToString();
                if (kvadrat > 10)
                {

                    int j = 0;
                    int f = 0;
                    int s = 0;
                    int k = razdelitel.Length - 1;
                    if (razdelitel.Length % 2 == 0)
                    {
                        while (j < k)
                        {
                            first = first + razdelitel[j];
                            second = razdelitel[k] + second;
                            j++;
                            k--;
                        }
                        f = int.Parse(first);
                        s = int.Parse(second);
                    }
                    else
                    {
                        while (j<k)
                        {
                            first = first + razdelitel[j];
                            second = razdelitel[k] + second;
                            j++;
                            k--;
                        }
                        int seredina = razdelitel.Length/2;
                        second = razdelitel[seredina] + second;
                        f = int.Parse(first);
                        s = int.Parse(second);
                    }
                    summ = f + s;

                    if (summ == i)
                    {
                        otvet = otvet + ' ' + summ.ToString();
                    }
                }
                else if (i < 10)
                {
                    if (i == 1)
                    {
                        otvet = otvet + ' ' + i.ToString();
                    }
                }
                razdelitel = " ";
                first = " ";
                second = " ";
            }

            if (otvet == " ")
            {
                Console.WriteLine("INVALID RANGE");
            }
            else
            {
                Console.Write(otvet.Substring(2, otvet.Length - 2));
            }
        }
    }
}
