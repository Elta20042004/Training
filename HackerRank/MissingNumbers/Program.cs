using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            string[] A = new string[m];
            A = Console.ReadLine().Split(' ');

            int n = int.Parse(Console.ReadLine());
            string[] B = new string[n];
            B = Console.ReadLine().Split(' ');          

            int[] intA = A.Select(ch => int.Parse(ch.ToString())).ToArray();
            int[] intOriginal = B.Select(ch => int.Parse(ch.ToString())).ToArray();

            var numbers = intOriginal
                .GroupBy(t => t)
                .ToDictionary(group => group.Key, group => group.Count());
            // {1,1,1} {2,2,2,2} {3,3}

            for (int i = 0; i < intA.Length; i++)
            { 
                numbers[intA[i]] = numbers[intA[i]] - 1;                          
            }


            var listOtvet = numbers
                .Where(t => t.Value > 0)
                .Select(p => p.Key)
                .OrderBy(s => s);
            foreach (var i in listOtvet)
            {
                Console.Write("{0} ",i);
            }
        }
    }
}
