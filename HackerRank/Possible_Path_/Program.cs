using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Possible_Path_
{
    class Program
    {

        public static List<int[]> test(List<int[]> k)
        {
            List<int[]> budet = new List<int[]>();

            foreach (var c in k)
            {
                budet.Add(new int[] { c[0] + c[1], c[1] });
                budet.Add(new int[] { c[0], c[0] + c[1] });
                budet.Add(new int[] { c[0] - c[1], c[1] });
                budet.Add(new int[] { c[0], c[0] - c[1] });

            }


            return budet;
        }
        public static void proverka(int a, int b, int x, int y)
        {
            List<int[]> sejchas = new List<int[]>();

            sejchas.Add(new int[] { a, b });

            var rez = test(sejchas);
            int p = 0;
            string otvet = "NO";
            while (p != 1)
            {
                sejchas.Clear();
                foreach (var i in rez)
                {
                    if ((i[0] == x) && (i[1] == y))
                    {
                        p = 1;
                        otvet = "YES";
                        break;
                    }
                    else
                    {
                        sejchas.Add(i);
                    }
                }
                rez = test(sejchas);
            }

            Console.WriteLine(otvet);

        }

        static void Main(string[] args)
        {
            //string[] k = Console.ReadLine().Split(' ');
            //int a = int.Parse(k[0]);
            //int b = int.Parse(k[1]);
            //int x = int.Parse(k[2]);
            //int y = int.Parse(k[3]);
            int a = 1;
            int b = 1;
            int x = 2;
            int y = 3;
            proverka(a, b, x, y);
        }
    }
}
