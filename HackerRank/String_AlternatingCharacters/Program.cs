using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_AlternatingCharacters
{
    class Program
    {
        public static void proverka(string text)
        {
            char temp = text[0];
            int counter = 0;
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == temp)
                {
                    counter++;
                }
                temp = text[i];
            }
            Console.WriteLine(counter);
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string text = Console.ReadLine();
                proverka(text);
            }
        }
    }
}
