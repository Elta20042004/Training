using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuicksortIn_Place
{
    class Program
    {

        //if ((numbers[i] >= seredina) && (numbers[j] <= seredina))
        //{
        //    int temp = numbers[i];
        //    numbers[i] = numbers[j];
        //    numbers[j] = temp;
        //}
        //if (numbers[j] > seredina)
        //{
        //    j--;
        //}
        //else if (numbers[i] <= seredina)
        //{
        //    i++;
        //}
        public static void quecSort(int[] numbers, int startIndex, int endIndex)
        {
            if (endIndex - startIndex < 1)
            {
                return;
            }


            int i = startIndex;
            int p = endIndex;
            int seredina = numbers[p];
            int j=0;
            while (j != p)
            {
                while (numbers[i] < seredina)
                {
                    i++;
                }
                j = i;
                while ((numbers[j] > seredina)&&(j!=numbers.Length-1))
                {
                    j++;
                }
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;                  
            }
            for (int k = 0; k < numbers.Length; k++)
            {
                 Console.Write("{0} ",numbers[k]);
            }
           Console.WriteLine();

            quecSort(numbers, startIndex, i - 1);
            quecSort(numbers, i+1, endIndex);


        }
        //1 3 9 8 2 7 5

        //1 3 2 5 9 7 8
        //1 2 3 5 9 7 8
        //1 2 3 5 7 8 9


        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] k = Console.ReadLine().Split(' ');
            int[] numbers = k.Select(ch => int.Parse(ch.ToString())).ToArray();


            quecSort(numbers, 0,numbers.Length-1);
        }
    }
}
