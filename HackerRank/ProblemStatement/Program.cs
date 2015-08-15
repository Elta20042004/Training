using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProblemStatement
{
    class Program
    {
        public static void myReshenie(string k)
        {
            Dictionary<char, int> left = new Dictionary<char, int>();
            Dictionary<char, int> right = new Dictionary<char, int>();
            char[] mersi = k.ToCharArray();
            //int otvet = k.Length;
            int otvet = 0;
            int counterLeft = 1;
            int counterRight = 1;
            if (k.Length % 2 != 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                int i = 0;
                int j = mersi.Length - 1;
                while (i < j)
                {
                    if (!left.ContainsKey(mersi[i]))
                    {
                        left.Add(mersi[i], counterLeft);

                    }
                    else
                    {
                        left[mersi[i]] = left[mersi[i]] + counterLeft;
                    }


                    i++;

                    if (!right.ContainsKey(mersi[j]))
                    {
                        right.Add(mersi[j], counterRight);

                    }
                    else
                    {
                        right[mersi[j]] = right[mersi[j]] + counterRight;
                    }
                    j--;
                }

                foreach (KeyValuePair<char, int> m in left)
                {
                    if (!right.ContainsKey(m.Key))
                    {
                        otvet = otvet + m.Value;
                    }
                    else
                    {
                        if (m.Value > right[m.Key])
                        {
                            int raznica = m.Value - right[m.Key];
                            otvet = otvet + raznica;
                        }
                    }


                }



                Console.WriteLine(otvet);
            }


        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string k = Console.ReadLine();
                myReshenie(k);
            }
        }
    }
}
