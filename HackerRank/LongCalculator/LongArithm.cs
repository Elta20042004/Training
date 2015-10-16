using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LongCalculator
{
    public class LongArithm : ILongArithm
    {
        public List<int> MultiplicationByOneInteger(List<int> one, int integer)
        {
            List<int> intermediateResult = new List<int>();
            int u = 0;
            for (int i = 0; i < one.Count; i++)
            {
                int temp = (one[i] * integer) + u;

                intermediateResult.Add(temp % 10);
                u = temp / 10;
            }

            if (u > 0)
            {
                intermediateResult.Add(u);
            }

            return intermediateResult;
        }

        //   *
        public List<int> Multiplication(List<int> one, List<int> two)
        {
            List<int> resList = new List<int>();
            List<int> intermediateResult = new List<int>();
            int shift = 0;
            for (int i = 0; i < two.Count; i++)
            {
                intermediateResult = MultiplicationByOneInteger(one, two[i]);

                if (shift > 0)
                {
                    int p = shift;
                    List<int> pip = new List<int>();
                    while (p != 0)
                    {
                        pip.Add(0);
                        p--;
                    }
                    foreach (var m in intermediateResult)
                    {
                        pip.Add(m);
                    }
                    intermediateResult = pip;
                }
                resList = Summ(intermediateResult, resList);
                shift++;

            }
            return resList;
        }


        // -
        public List<int> Subtraction(List<int> one, List<int> two)
        {
            List<int> resList = new List<int>();

            int t = Compare(one, two);

            if (t == -1)
            {
                var temp = one;
                one = two;
                two = temp;
                //znak -
            }

            int k = 0;

            for (int i = 0; i < one.Count; i++)
            {
                int temp = 0;
                if (two.Count > i)
                {
                    temp = one[i] - two[i] - k;
                }
                else
                {
                    temp = one[i] - k;
                }

                if (temp < 0)
                {
                    temp = temp + 10;
                    k = 1;
                }
                resList.Add(temp % 10);
            }

            while (resList[resList.Count - 1] == 0)
            {
                resList.RemoveAt(resList.Count - 1);
            }

            return resList;
        }

        public int Compare(List<int> one, List<int> two)
        {
            if (one.Count != two.Count)
            {
                if (one.Count < two.Count)
                {
                    return -1;
                }
                if (one.Count > two.Count)
                {
                    return 1;
                }
            }

            for (int i = one.Count - 1; i >= 0; i--)
            {
                if (one[i] < two[i])
                {
                    return -1;
                }
                if (one[i] > two[i])
                {
                    return 1;
                }
            }

            return 0;
        }

        // +
        public List<int> Summ(List<int> one, List<int> two)
        {
            List<int> resList = new List<int>();
            if (one.Count < two.Count)
            {
                var temp = one;
                one = two;
                two = temp;
            }
            int k = 0;

            for (int i = 0; i < one.Count; i++)
            {
                int temp = one[i] + k;

                if (two.Count > i)
                {
                    temp += two[i];
                }

                resList.Add(temp % 10);
                k = temp / 10;
            }
            if (k > 0)
            {
                resList.Add(k);
            }
            return resList;
        }

        public List<int> ConvertStringToLongNumber(string text)
        {
            var result = text
                .Select(t => t - '0')
                .ToList();
            return result;
        }
    }
}