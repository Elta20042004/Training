using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_GemstonesII
{
    class Program
    {
        


        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] mather = new string[t];
            int[] numbers = new int[26];
            for (int i = 0; i < mather.Length; i++)
            {
                mather[i] = Console.ReadLine();

                for (int j = 0; j < mather[i].Length; j++)
                {
                    int k = mather[i][j] - 'a';
                    if (numbers[k] == i)
                    {
                        numbers[k] = numbers[k]+1;
                    }
                }
            }
            int points = numbers.Count(s=>s==t);
            Console.WriteLine(points);
            Console.ReadLine();
        }
    }
}
