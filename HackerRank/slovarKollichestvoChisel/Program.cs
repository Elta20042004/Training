using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slovarKollichestvoChisel
{
    class Program
    {

        static void Main_Polindrom(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int f = 1;
            while (f != t + 1)
            {
                Console.Write("{0} ", f);
                Console.Write("{0} ", t - f + 1);
                f++;
            }
        }

        static void Print(char k, int count)
        {
            int i = 0;
            while (i < count)
            {
                i++;
                for (var j = 0; j < i; j++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }

        static void Main_kohavRight(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            char k = '*';
            Print(k, t);
        }

        static void treugolnik(string k)
        {
            int seredina = k.Length / 2;
            int i = 0;
            int j = k.Length - 1;
            while (seredina != i)
            {
                Console.WriteLine();
                while ((i < seredina) && (j > seredina))
                {
                    Console.Write(' ');
                    i++;
                    j--;
                }
                Console.Write('*');
                seredina = seredina - 1;
                i = 0;
                j = k.Length - 1;
            }
        }

        static void Main_Romb(string[] args)
        {
            int N = 5;
            char[] myMas = new char[N];
            int seredina = myMas.Length / 2;
            myMas[seredina] = '*';
            Console.WriteLine(myMas);
            int i = seredina - 1;
            int j = seredina + 1;

            while ((i >= 0) && (j <= myMas.Length - 1))
            {
                myMas[i] = '*';
                myMas[j] = '*';
                Console.WriteLine(myMas);
                i--;
                j++;
            }
            i = 0;
            j = myMas.Length - 1;
            while (i < j)
            {
                myMas[i] = ' ';
                myMas[j] = ' ';
                Console.WriteLine(myMas);
                i++;
                j--;
            }
        }

        static void Main_Linq(string[] args)
        {
            var k = Console.ReadLine()
                .Split(' ')
                .GroupBy(t => t) //{1,1,1} {a,a,a}
                .ToDictionary(f => f.Key, f => f.Count());

            foreach (var i in k)
            {
                Console.WriteLine("{0} - {1}", i.Key, i.Value);
            }

        }

        static Dictionary<T, int> ToDictionary<T>(T[] a)
        {
            Dictionary<T, int> k = new Dictionary<T, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!k.ContainsKey(a[i]))
                {
                    k.Add(a[i], 1);
                }
                else
                {
                    k[a[i]]++;
                }
            }

            return k;
        }

        static void Main(string[] args)
        {
            string[] a = "1 2 4 y a b c".Split(' ');
            var dict = ToDictionary(a);

            int[] b = new[] { 1, 2, 1, 1, 4, 2, 2, 3, 1, 4, 2, 2, 1, 12, 3, 4, 22 };
            var dictInt = ToDictionary(b);

            char[] c = new[] { '1', '2', '1', '1' };
            var dictChar = ToDictionary(c);
        }

    }
}
