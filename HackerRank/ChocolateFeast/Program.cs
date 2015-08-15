using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFeast
{
    class Program
    {

        public static int chocolate(int vsego, int cena, int skidka)
        {
            int summa = vsego / cena;
            if (summa < skidka)
            {
                return summa;
            }

            if (summa == skidka)
            {
                return summa + 1;
            }

            int fantik = 0;
            fantik = summa;
            int ostatok = 0;
            do
            {
                ostatok = fantik / skidka;
                summa = summa + ostatok;
                fantik = (fantik % skidka) + ostatok;
            } while (fantik != 1 && ostatok > 0);

            return summa;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (var i = 0; i < t; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                int vsego = Convert.ToInt32(temp[0]);
                int cena = Convert.ToInt32(temp[1]);
                int skidka = Convert.ToInt32(temp[2]);

                int m = chocolate(vsego, cena, skidka);
                Console.WriteLine(m);
            }
            Console.ReadLine();
        }
    }
}
