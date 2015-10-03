using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Crush
{
    class Program
    {
        public class Segment
        {
            public long Start, End, Value;
        }

        private static List<Segment> _segmentList = new List<Segment>();

        private static void CalculateCrush(List<Segment> mass)
        {
            long sum = 0;
            long maxSum = 0;
            var endValue = new SortedDictionary<long, long>();

            for (int i = 0; i < mass.Count; i++)
            {
                if (!endValue.ContainsKey(mass[i].End))
                {
                    endValue.Add(mass[i].End, 0);
                }
                endValue[mass[i].End] += mass[i].Value;
                sum = sum + mass[i].Value;
                var forremove = new LinkedList<long>();
                foreach (var l in endValue.Keys)
                {
                    if (l < mass[i].Start)
                    {
                        sum -= endValue[l];
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

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            Console.WriteLine(maxSum);

        }

        private static void CalculateCrush2(List<Segment> mass)
        {
            long summa = 0;
            long maxSumma = 0;
            var endValue = new LinkedList<Segment>();

            for (int i = 0; i < mass.Count; i++)
            {
                endValue.AddFirst(mass[i]);
                summa = summa + mass[i].Value;
                var current = endValue.First.Next;
                while (current != null)
                {
                    var next= current.Next;
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

        private static void AddSegment(long startIndex, long endIndex, long summa)
        {
            _segmentList.Add(new Segment()
            {
                Start = startIndex,
                End = endIndex,
                Value = summa
            });
        }

        private static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' ');
            long length = int.Parse(temp[0]);
            int n = int.Parse(temp[1]);

            for (int i = 0; i < n; i++)
            {
                string[] m = Console.ReadLine().Split(' ');
                long startIndex = long.Parse(m[0]);
                long endIndex = long.Parse(m[1]);
                long summa = long.Parse(m[2]);

                AddSegment(startIndex, endIndex, summa);
            }

            _segmentList = _segmentList.OrderBy(t => t.Start).ToList();  //sort list by .Start
            CalculateCrush(_segmentList);
        }
    }

    public class DescComparer : IComparer<long>
    {
        public int Compare(long x, long y)
        {
            return y.CompareTo(x);
        }
    }
}
