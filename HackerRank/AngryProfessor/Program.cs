using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryProfessor
{
    class Program
    {
        public static string lekciya(int hochetStudenty, int[] vremya)
        {
            string otvet = " ";
            int t = vremya.Count(f => f <= 0);

            if (hochetStudenty > t)
            {
                otvet = "YES";
            }
            else
            {
                otvet = "NO";
            }

            return otvet;
        }

        public static string lekciya2(int hochetStudenty, int[] vremya)
        {
            string otvet = " ";
            int count = vremya.Length;

            for (int i = 0; i < vremya.Length; i++)
            {
                if (vremya[i] > 0)
                {
                    count--;
                }
            }

            if (hochetStudenty > count)
            {
                otvet = "YES";
            }
            else
            {
                otvet = "NO";
            }

            return otvet;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] pozhelaniya = Console.ReadLine().Split(' ');
                int vsegoStudentov = Convert.ToInt32(pozhelaniya[0]);
                int hochetStudenty = Convert.ToInt32(pozhelaniya[1]);

                string[] real;
                real = Console.ReadLine().Split(' ');
                int[] f1 = real.Select(ch => int.Parse(ch.ToString())).ToArray();

                string k = lekciya(hochetStudenty, f1);
                Console.WriteLine(k);
            }


            Console.ReadLine();
        }
    }
}
