using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_GameOfThrones_1
{
    class Program
    {

        public static string temp(string text)
        {
            int[] numbers = new int[26];
            string otvet = "";
            int counter = 1;
            for (int i = 0; i < text.Length; i++)
            {
                int k = text[i] - 'a';
                numbers[k] = numbers[k] + counter;
            }

            int point = numbers.Count(t => t > 0 && t % 2 != 0);  


            if (point > 1)
            {
                otvet = "NO";
            }
            else
            {
                otvet = "YES";
            }
            return otvet;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string ttt = temp(text);

            Console.WriteLine(ttt);

        }
    }
}
