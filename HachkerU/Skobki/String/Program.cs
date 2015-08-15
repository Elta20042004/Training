using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        private static void Main(string[] args)
        {
            string x = "Mama lyubit kashu, a papa net.";
            //int n = int.Parse(Console.ReadLine());
            int n = 4;
            //char[] y = new char[n + 10];
            int counter;
            char p = ' ';
            char z = ',';
            char t = '.';

            int j=0;
            int i=0;

            do
            {
                counter = 0;
                j = i;
                while ((x[i] != p) && (x[i] != z)&&(x[i] != t))
                {
                    counter++;
                    i++;
                    

                }
                    
                if (counter == n)
                {
                    i++;
                    counter = 0;
                }
                else
                {
                    for (int k = j; k <= i; k++)
                    {
                        Console.Write(x[k]);
                    }
                    i++;
                }
                
            }

            while (i <= x.Length-1);

        }

    }
}
