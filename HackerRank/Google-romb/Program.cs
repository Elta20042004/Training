using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_romb
{
    class Program
    {

        static void Main(string[] args)
        {
            int N = 5;
            int seredina = N / 2;
            int k = 0;
            for (int i = 0; i < N; i++)
            {
                k = i;
                if (k > seredina)
                {
                    k--;
                }
                for (int j = 0; j <= seredina + k; j++)
                {
                    if (j < seredina - k)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('*');
                    }

                }
                Console.WriteLine();

            }
        }



        static void Main2(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            int N = 81;
            char[] myMas = new char[N];
            int seredina = myMas.Length / 2;
            myMas[seredina] = '*';
            Console.WriteLine(myMas);
            int i = seredina - 1;
            int j = seredina + 1;

            while ((i >= 0) && (j <= myMas.Length - 1))
            {
                myMas[i] = '*';
                myMas[j] = '*';
                Console.WriteLine(myMas);
                i--;
                j++;
            }
            i = 0;
            j = myMas.Length - 1;
            while (i < j)
            {
                myMas[i] = ' ';
                myMas[j] = ' ';
                Console.WriteLine(myMas);
                i++;
                j--;
            }

        }
    }
}
