using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanyRekursiya
{
    class Program
    {
        static int j;
        private static int counte = 0;
        private static List<int> temp;

        static void Rec(int[] numbers, int summa, int i)
        {
           
            if (i >= numbers.Length - 1)
            {
                Console.WriteLine(string.Join(" ", temp.Select(t => numbers[t].ToString())));

                var summaTemp = temp
                    .Sum(t=>numbers[t]);
                if (summa == summaTemp)
                {
                    //Console.WriteLine("Success -->" + string.Join(" ",temp.Select(t=> numbers[t].ToString())));
                }
                return;
            }

            for (int k = i+1; k < numbers.Length; k++)
            {
                temp.Add(k);
                Rec(numbers,summa,k);
                temp.Remove(k);
            }

           Rec(numbers,summa,numbers.Length);
        }

        static void Recursiya(int[] numbers, int summa, int i)
        {
            if (i >= numbers.Length - 1)
            {                
                return;
            }


        }

        static void Main(string[] args)
        {
            //int[] k = new[] { 3,5,1,15,7,6 };
            int[] k = new[] { 3, 5 };
            int x = 5;
            temp = new List<int>();

            Rec(k, x, -1);
        }
    }
}
