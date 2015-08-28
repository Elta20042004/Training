using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int num = str.Select(s => int.Parse(s.ToString()))
                .Sum();
            Console.WriteLine(num);


        }
    }
}
