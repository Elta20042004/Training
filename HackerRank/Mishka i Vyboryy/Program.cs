using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishkaAndVyboryy
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = Console.ReadLine();
            int k = int.Parse(str1);
            string[] str = Console.ReadLine().Split(' ');
            int[] numbers = str.Select(t => int.Parse(t.ToString())).ToArray();



        }
    }
}
