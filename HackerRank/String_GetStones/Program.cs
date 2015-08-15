using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_GetStones
{
    class Program
    {
        public static int[] numbers = new int[26];
        public static void temp(char[] text, int t)
        {

            int count = 1;

            int predydushee = text[0] - 'a';

            for (int i = 1; i < text.Length; i++)
            {
                int New = text[i] - 'a';
                if (New != predydushee)
                {
                    numbers[predydushee] = numbers[predydushee] + count;
                    predydushee = New;
                }
                if (i == text.Length - 1)
                {
                    numbers[predydushee] = numbers[predydushee] + count;
                }


            }
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());


            for (int i = 0; i < t; i++)
            {
                string text = Console.ReadLine();
                char[] myRes;
                myRes = text.ToCharArray();
                Array.Sort(myRes);
                temp(myRes, t);

            }


            int p = numbers.Count(s => s == t);

            Console.WriteLine(p);




        }
    }
}
