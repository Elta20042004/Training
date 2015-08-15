using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dihatamiya
{
    class Program
    {

        public static bool Dihatamiya(int[] numbers, int k, int start, int end)
        {
            bool otvet = true;
            int seredina = (start + end) / 2;
            while ((numbers[seredina] != k) && (numbers[start] != k) && (numbers[end] != k))
            {
                if (numbers[seredina] > k)
                {
                    end = seredina;
                }
                else
                {
                    start = seredina;
                }
                seredina = (start + end) / 2;
            }
            return otvet;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            Array.Sort(numbers);
            int lehapes = 5;
            bool otvet;
            int start = 0;
            int end = numbers.Length - 1;
            otvet = Dihatamiya(numbers, lehapes, start, end);
            Console.WriteLine(otvet);
        }
    }
}
