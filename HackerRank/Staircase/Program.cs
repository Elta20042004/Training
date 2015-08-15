using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            char[] treugolnik = new char[t];
            int j = treugolnik.Length - 1;
            treugolnik[j] = '#';
            for (int i = 0; i < treugolnik.Length; i++)
            {
                if (i < j)
                {
                    treugolnik[i] = ' ';
                }
            }
            Console.WriteLine(treugolnik);
            
            while (j!=0)
            {
                j--;
                treugolnik[j] = '#';
                Console.WriteLine(treugolnik);
            }
        }
    }
}
