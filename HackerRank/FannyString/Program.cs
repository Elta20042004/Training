using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FannyString
{
    class Program
    {
        public static void pips(string fiks)
        {
            int i = 0;
            int j = fiks.Length-1;
            string otvet = "Funny";
            while (i<j)
            {
                if (Math.Abs(fiks[i] - fiks[i + 1]) == Math.Abs(fiks[j] - fiks[j - 1]))
                {
                    i++;
                    j--;
                }
                else
                {
                    otvet = "Not Funny";
                    break;
                }
            }
            Console.WriteLine(otvet);
        }        
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string m = Console.ReadLine();
                pips(m);
            }
        }
    }
}
