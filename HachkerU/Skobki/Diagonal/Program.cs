using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Mama lyubit kashu, a papa net";

            char p = ' ';
            for (var i = 0; i <= x.Length - 1; i++)
            {
                Console.WriteLine(x[i]);
                i++;
                
                for (var j = 0; j <= i; j++)
                {
                    Console.Write("{0}",p);
                }
                i--;
            }
        }

    }
}
