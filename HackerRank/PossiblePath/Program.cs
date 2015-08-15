using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PossiblePath
{
    class Program
    {
        public static List<int[]> test(List<int[]> k)
        {
            List<int[]> budet = new List<int[]>();

            foreach (var c in k)
            {
                budet.Add(new int[] { c[0] - 2, c[1] + 1 });
                budet.Add(new int[] { c[0] - 1, c[1] + 2 });
                budet.Add(new int[] { c[0] + 1, c[1] + 2 });
                budet.Add(new int[] { c[0] + 2, c[1] + 1 });
                budet.Add(new int[] { c[0] + 2, c[1] - 1 });
                budet.Add(new int[] { c[0] + 1, c[1] - 2 });
                budet.Add(new int[] { c[0] - 1, c[1] - 2 });
                budet.Add(new int[] { c[0] - 2, c[1] - 1 });
            }


            return budet;
        }
        public static void proverka(int a, int b, int x, int y)
        {
            List<int[]> sejchas = new List<int[]>();
            if ((a != x) && (b != y))
            {
                sejchas.Add(new int[] { a, b });
            }
            var rez = test(sejchas);
            int p = 0;
            int count = 1;
            while (p != 1)
            {
                sejchas.Clear();
                count++;
                foreach (var i in rez)
                {
                    if ((i[0] == x) && (i[1] == y))
                    {
                        p = 1;
                        break;
                    }
                    else
                    {
                        sejchas.Add(i);
                    }
                }
                rez = test(sejchas);
            }

            Console.WriteLine(count);

        }

        static void Main(string[] args)
        {
            //string[] k = Console.ReadLine().Split(' ');
            //int a = int.Parse(k[0]);
            //int b = int.Parse(k[1]);
            //int x = int.Parse(k[2]);
            //int y = int.Parse(k[3]);
            int a = 0;
            int b = 0;
            int x = 100;
            int y = 100;
            proverka(a, b, x, y);
        }
    }
}
