using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UKandUSPart2
{
    class Program
    {
        public static List<string> k;

        public static void test(string slovo)
        {
            string temp = @"[u]{0,1}";
            var regex = new Regex(temp);
            int i = 0;
            int j = slovo.Length - 1;
            string first = "";
            string second = "";
            while (i<j)
            {
                
            }
           

           
      //      var regexRez = new Regex();
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            k = new List<string>(t);

            string slovo = "";
            for (int i = 0; i < t; i++)
            {
                string p = Console.ReadLine();
                k.Add(p);
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                slovo = Console.ReadLine();
                test(slovo);
            }


        }
    }
}
//3
//labour however salty access stream strange odor favorite dancing milligram
//anxious spoon formal lesson vapor close soft drunk odour pt
//text labor instead knit shop flavor find humor critical driving
//9
//armour
//humour
//behaviour
//labour
//favourite
//flavour
//clamour
//odour
//vapour

//0
//1
//0
//2
//1
//1
//0
//2
//1


//2
//3
//4
//2
//0
//5
//4
//1
//1

//10
//splendour wealth piece recognition savoury endeavour oil cannot reality fish
//sincere savor argument vigour chain awake cap surprising savoury jump
//natural study process immoral flag vigour habit assist candy pet
//shoulder aside slightly onto crash later disagreement savour rumour entrance
//splendour petrol unable inevitably crowd growth fasten leading responsibility artificially
//equally alarmed also knowledge ok splendor armory pick sale be
//activity rumour ending alcoholic savory curve splendour honestly enjoyable rumour
//determined used rumor union affair odor granddaughter elect endeavor alter
//savor hour enjoyable waiter divorce at mental prepared folding primary
//cheaply vegetable upon splendor disease savor it cast hear cardboard
//9
//endeavour
//savoury
//savour
//vigour
//valour
//splendour
//rumour
//odour
//armoury