using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insetion_Sort_AA
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int length = int.Parse(Console.ReadLine());
                string[] str = Console.ReadLine().Split(' ');
                int[] numbers = str.Select(ch => int.Parse(ch.ToString())).ToArray();
                int[] sortArray = numbers; //otsortirovannyj massiv
                Array.Sort(sortArray);
                //Dictionary<int, int> Dic = new Dictionary<int, int>();
                
                for (int j = 0; j < str.Length; j++)
                {
                  
                }

               




            }
        }
    }
}
