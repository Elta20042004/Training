using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Crush
{//public static long[] numbers;
    //public static void test(long startIndex, long endIndex, long summa)
    //{          
    //    for (var i = startIndex - 1; i <= endIndex - 1; i++)
    //    {
    //        numbers[i] = numbers[i] + summa;               
    //    }          
    //}

    class Program
    {

        public class Otrezus
        {
            public long Start, End, Value;
        }

        public static List<Otrezus> mass = new List<Otrezus>();

        public static void pips(List<Otrezus> mass)
        {
            long summa = 0;
            long maxSumma = 0;
            SortedDictionary<long, long> endValue = new SortedDictionary<long, long>();

            for (int i = 0; i < mass.Count; i++)
            {
                if (!endValue.ContainsKey(mass[i].End))
                {
                    endValue.Add(mass[i].End, 0);
                }
                endValue[mass[i].End] += mass[i].Value;
                summa = summa + mass[i].Value;
                LinkedList<long> forremove = new LinkedList<long>();
                foreach (var l in endValue.Keys)
                {
                    if (l < mass[i].Start)
                    {
                        summa -= endValue[l];
                        forremove.AddLast(l);
                    }
                    else
                    {
                        break;
                    }
                }

                foreach (var l in forremove)
                {
                    endValue.Remove(l);
                }

                if (summa > maxSumma)
                {
                    maxSumma = summa;
                }
            }
            Console.WriteLine(maxSumma);

        }

        public static void pips2(List<Otrezus> mass)
        {
            long summa = 0;
            long maxSumma = 0;
            LinkedList<Otrezus> endValue = new LinkedList<Otrezus>();

            for (int i = 0; i < mass.Count; i++)
            {
                endValue.AddFirst(mass[i]);
                summa = summa + mass[i].Value;
                var current = endValue.First.Next;
                while (current != null)
                {
                    LinkedListNode<Otrezus> next= current.Next;
                    if (mass[i].Start > current.Value.End)
                    {
                        summa = summa - current.Value.Value;
                        endValue.Remove(current);
                    }

                    current = next;
                }

                if (summa > maxSumma)
                {
                    maxSumma = summa;
                }

            }
            Console.WriteLine(maxSumma);

        }

        public static void test(long startIndex, long endIndex, long summa)
        {
            mass.Add(new Otrezus()
            {
                Start = startIndex,
                End = endIndex,
                Value = summa
            });



        }

        static void Main(string[] args)
        {
            string[] k = Console.ReadLine().Split(' ');
            long length = int.Parse(k[0]);
            int n = int.Parse(k[1]);

            for (int i = 0; i < n; i++)
            {
                string[] m = Console.ReadLine().Split(' ');
                long startIndex = long.Parse(m[0]);
                long endIndex = long.Parse(m[1]);
                long summa = long.Parse(m[2]);

                test(startIndex, endIndex, summa);
            }

            mass = mass.OrderBy(t => t.Start).ToList();  //otsortirovat' list po start
            pips(mass);


        }
    }

    internal class DescComparer : IComparer<long>
    {
        public int Compare(long x, long y)
        {
            return y.CompareTo(x);
        }
    }
}
