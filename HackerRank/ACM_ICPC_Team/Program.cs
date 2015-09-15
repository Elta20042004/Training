using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_ICPC_Team
{
    class Program
    {
        private static int people;
        private static int maxTopic;
        private static List<int> stock;
        static void ComparisonOfTwoArrays(int[] a, int[] b)
        {
            int temp = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 1 || b[i] == 1)
                {
                    temp++;
                }
            }

            if (temp > maxTopic)
            {
                maxTopic = temp;
            }

            stock.Add(temp);
        }
        static void Test(List<int[]> allPreople)
        {
            for (int i = 0; i < people; i++)
            {
                for (int j = i; j < people; j++)
                {
                    if (i != j)
                    {
                        ComparisonOfTwoArrays(allPreople[i], allPreople[j]);
                    }
                }
            }
        }
        private static void Main(string[] args)
        {
            string[] k = Console.ReadLine().Split(' ');
            people = int.Parse(k[0]);          
            maxTopic = 0;

            List<int[]> allPreople = new List<int[]>();
            stock = new List<int>();
            for (int i = 0; i < people; i++)
            {
                string str = Console.ReadLine();
                int[] num = str.Select(t => int.Parse(t.ToString())).ToArray();
                allPreople.Add(num);
            }

            Test(allPreople);

            int comands = 0;
            for (int i = 0; i < stock.Count; i++)
            {
                if (stock[i] == maxTopic)
                {
                    comands++;
                }
            }
            Console.WriteLine(maxTopic);
            Console.WriteLine(comands);
        }
    }
}
