using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutTheCticks
{
    class Program
    {

        public static void sticks(int[] k)
        {
            int min;
            int count = k.Length;
            int j;
            do
            {
                min = k[count - 1];
                j = count;
                for (int i = 0; i <= j - 1; i++)
                {
                    k[i] = k[i] - min;
                    if (k[i] == 0)
                    {
                        count--;
                    }
                }

                Console.WriteLine(j);
            } while (count > 0);

        }

        static void Main(string[] args)
        {
            int result;
            int t = Convert.ToInt32(Console.ReadLine());

            //int[] temp = new int[t];
            //int i;

            //String move = Console.ReadLine();
            //String[] move_split = move.Split(' ');
            //for (int j = 0; j < move_split.Length; j++)
            //{
            //    i = Convert.ToInt32(move_split[j]);
            //    temp[j] = i;
            //}
            //Array.Sort(temp);
            //Array.Reverse(temp);
            var temp = Console.ReadLine()
                .Split(' ')
                .Select(str => int.Parse(str))
                .OrderBy(e => e)
                .Reverse()
                .ToArray();
            sticks(temp);
        }
    }
}
