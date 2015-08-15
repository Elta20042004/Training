using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{
    class Program
    {
        //12:40:22AM
        //00:40:22
        //12:45:54
        //12:45:54PM
        static void Main(string[] args)
        {
            string[] k = Console.ReadLine().Split(':');
            int chas = int.Parse(k[0]);
            int min = int.Parse(k[1]);
            string p = " ";
            p = p + k[2][0] + k[2][1];
            int sek = int.Parse(p);

            if (k[2][2] == 'P')
            {
                chas = chas + 12;
                if (chas == 24)
                {
                    chas = 12;
                }
            }
            else if (k[2][2] == 'A')
            {
                if (chas == 12)
                {
                    chas = 0;
                }
            }

            string otvet = " ";

            if (chas < 10)
            {
                otvet = "0" + chas.ToString() + ":";
            }
            else
            {
                otvet = chas.ToString() + ":";
            }

            if (min < 10)
            {
                otvet = otvet + "0" + min.ToString() + ":";
            }
            else
            {
                otvet = otvet + min.ToString() + ":";
            }

            if (sek < 10)
            {
                otvet = otvet + "0" + sek.ToString();
            }
            else
            {
                otvet = otvet + sek.ToString();
            }

            Console.WriteLine(otvet);
        }
    }
}
