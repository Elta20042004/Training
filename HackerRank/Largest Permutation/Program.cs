using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Permutation
{
    class Program
    {
        public static void Perebor(int[] numbers, int k)
        {
            int[] sort = new int[numbers.Length];
            int t = 0;
            while (t<numbers.Length)
            {
                sort[t] = numbers[t];
                t++;
            }

            Array.Sort(sort);

            int i = 0;
            int index = 0;
            int j = sort.Length - 1;
            while(k!=0)
            {
                while(sort[j]!=numbers[index])
                {
                    index++;
                }

                int temp = numbers[index];
                numbers[index] = numbers[i];
                numbers[i] = temp;

                k--;
                index = 0;
                i++;
                j--;
            }

            for(int p=0; p<numbers.Length; p++)
            {
                Console.Write("{0} ", numbers[p]);
            }
            
        }

        static void Main(string[] args)
        {
            string[] f1 = Console.ReadLine().Split(' ');           
            int hody = int.Parse(f1[1]);
            string[] f2 = Console.ReadLine().Split(' ');
            int[] numbers = f2.Select(ch => int.Parse(ch.ToString())).ToArray();
            Perebor(numbers, hody);
        }
    }
}
