using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimskieCifry
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = "DCXXI";

            Dictionary<char, int> znachenie = new Dictionary<char, int>();
            znachenie.Add('I', 1);
            znachenie.Add('V', 5);
            znachenie.Add('X', 10);
            znachenie.Add('L', 50);
            znachenie.Add('C', 100);

            int[] l = new int[p.Length];
            for (int i = 0; i < p.Length; i++)
            {
                if (znachenie.ContainsKey(p[i]))
                {
                    l[i] = znachenie[p[i]];
                }
            }

            int summa = 0;
            for (int i = 0; i < l.Length; i++)
            {
                if ((l[i] != 1) && (l[i] != 50) && (l[i] != 100))
                {
                    summa = summa + l[i];
                }
                else
                {
                    if (l[i] == 1)
                    {
                        if (i == l.Length - 1)
                        {
                            summa = summa + l[i];
                        }
                        else
                        {
                            if (l[i + 1] != 1)
                            {
                                summa = summa - l[i];
                            }
                            else
                            {
                                summa = summa + l[i];
                            }
                        }
                    }
                    else if (l[i] == 50)
                    {
                        summa = l[i] - summa;
                    }
                    else if (l[i] == 100)
                    {
                        summa = l[i] - summa;
                    }
                }
            }

            Console.WriteLine(summa);
        }

        static void Main1(string[] args)
        {
            string p = "DCXXI";

            Dictionary<char, int> znachenie = new Dictionary<char, int>();
            znachenie.Add('I', 1);
            znachenie.Add('V', 5);
            znachenie.Add('X', 10);
            znachenie.Add('L', 50);
            znachenie.Add('C', 100);

            int summa = 0;
            bool flagI = false;
            bool flagX = false;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == 'I' && flagI)
                {
                    flagI = false;
                }
                else if (p[i] != 'I' && flagI)
                {
                    summa -= 2;
                }
                else if (p[i] == 'I')
                {
                    flagI = true;
                }

                if (p[i] == 'X' && flagX)
                {
                    flagI = false;
                }
                else if (p[i] != 'X' && flagX)
                {
                    summa -= 2;
                }
                else if (p[i] == 'X')
                {
                    flagI = true;
                }

                summa += znachenie[p[i]];
            }

            Console.WriteLine(summa);
        }
    }
}
