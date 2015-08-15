using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndAnagrams
{
    class Program
    {
        public static void Sherlock(string k)
        {
            int counter = 1;
            int summ = 0;
            char[] myMass = k.ToCharArray();
            Dictionary<char, List<int>> pips = new Dictionary<char, List<int>>();

            for (int i = 0; i < myMass.Length; i++)
            {
                if (!pips.ContainsKey(myMass[i]))
                {
                    pips.Add(myMass[i], new List<int>());
                }

                pips[myMass[i]].Add(i);
            }
            char[] loktik = new char[k.Length];
            foreach (KeyValuePair<char, List<int>> m in pips)
            {
                if (m.Value.Count > 1)
                {
                    for (int i = 0; i < m.Value.Count; i++)
                    {
                        int popa = m.Value[i];
                        loktik[popa] = m.Key;
                    }
                }
            }



            Console.WriteLine(summ);
        }

        static void Main(string[] args)
        {
            //int t = int.Parse(Console.ReadLine());

            //for (int i = 0; i < t; i++)
            //{
            //    string k = Console.ReadLine();
            //    Sherlock(k);
            //}
string k = "abba";
            //            5
            //string k = "ifailuhkqq";  iiqq - 3          
            //hucpoltgty - tt - 2
            //ovarjsnrbf - rr - 2
            //pvmupwjjjf - ppjjj - 6
            //iwwhrlkpek - wwkk - 3

            //3
            //2
            //2
            //6
            //3

            Sherlock(k);
        }
    }
}
