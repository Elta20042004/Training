using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taum_and_B_day
{
    class Program
    {
//2000000
//0
//0
        public static void Sravnenie(long B, long W, long xB, long yW, long obmen, long vsego)
        {
            long rez = 0;
            long proba1;
            long proba2;

            if ((obmen > xB) && (obmen > yW))
            {
                rez = (B*xB) + (W*yW);
            }
            else
            {
                if ((yW > obmen)&&(yW>xB))
                {
                    proba1 = (B*xB) + (W*yW);
                    proba2 = (vsego*xB) + (W*obmen);
                    if (proba1 > proba2)
                    {
                        rez = proba2;
                    }
                    else
                    {
                        rez = proba1;
                    }
                }
                else if ((xB > obmen)&&(xB>yW))
                {
                    proba1 = (B * xB) + (W * yW);
                    proba2 = (vsego*yW) + (B*obmen);
                    if (proba1 > proba2)
                    {
                        rez = proba2;
                    }
                    else
                    {
                        rez = proba1;
                    }
                }
                else
                {
                    if (xB < yW)
                    {
                        rez = vsego*xB;
                    }
                    else
                    {
                        rez = vsego * yW;
                    }
                }
            }



            Console.WriteLine(rez);
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());         
            for (int i = 0; i < t; i++)
            {
                string[] kollichestvoPadarkov = Console.ReadLine().Split(' ');
                long B = long.Parse(kollichestvoPadarkov[0]);
                long W = long.Parse(kollichestvoPadarkov[1]);               
                long vsego = B + W;
                string[] cenaObmen = Console.ReadLine().Split(' ');
                long xB = long.Parse(cenaObmen[0]);
                long yW = long.Parse(cenaObmen[1]);             
                long obmen = long.Parse(cenaObmen[2]);
                Sravnenie(B, W, xB, yW, obmen, vsego);
            }
        }
    }
}
