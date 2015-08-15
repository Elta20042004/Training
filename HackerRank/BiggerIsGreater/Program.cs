using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerIsGreater
{
    class Program
    {
        public static void problem(string k)
        {
             
        }

        static void Main(string[] args)
        {
            // Slovar: А < АА < ААА < ААБ < ААВ < АБ < Б < … < ЯЯЯ.
            
            //int t = int.Parse(Console.ReadLine());
            //for (int i = 0; i < t; i++)
            //{
            //    string k = Console.ReadLine();            
            //    problem(k);
            //}

            //int[] A = massivA.Select(ch => int.Parse(ch.ToString())).ToArray();
            string slovo = "ab";       //hegf
            int[] numbers = slovo.Select(t => t - 'a').ToArray();
            problem(slovo);
            
        }
    }
}

//ab (0 1)             ba             (1 0)
//bb                   no answer
//hefg (7 4 5 6)       hegf           (7 4 6 5)
//dhck (3 7 2 10)      dhkc           (3 7 10 2)
//dkhc (3 10 7 2)      hcdk           (7 2 3 10)