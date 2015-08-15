using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndPairs
{
    class Program
    {            //var k = numbers
            //    .GroupBy(t => t)
            //    .Select(t => t.Count())
            //    .ToList();
           
            //while (m < k.Count)
            //{
            //    if (k[m] > 1)
            //    {
            //        otvet = otvet + (k[m] * (k[m] - 1));
            //    }
            //    m++;
            //}
        public static void Test(long[] numbers)
        {

            long otvet = 0;
            Dictionary<long, long> dic = new Dictionary<long, long>();
            for (long i = 0; i < numbers.Length; i++)
            {
                if (!dic.ContainsKey(numbers[i]))
                {
                    dic.Add(numbers[i],1);
                }
                else
                {
                    dic[numbers[i]]++;
                }
            }

            foreach (var i in dic)
            {
                if (i.Value > 1)
                {
                    otvet = otvet + (i.Value * (i.Value - 1));
                }
            }

            Console.WriteLine(otvet);


        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int k = int.Parse(Console.ReadLine());
                string[] p = new string[k];
                p = Console.ReadLine().Split(' ');
                long[] numbers = p.Select(ch => long.Parse(ch.ToString())).ToArray();
                Test(numbers);
            }
        }
    }
}

//10
//1
//84
//10
//363 916 794 363 650 387 887 336 422 363
//10
//927 737 60 427 427 173 764 691 212 541
//10
//863 531 369 783 136 430 124 930 568 863
//10
//803 43 168 70 457 394 23 12 230 59
//10
//371 422 414 325 316 785 538 920 374 199
//10
//306 92 863 957 997 306 981 171 527 282
//10
//506 314 125 926 337 858 328 85 730 847