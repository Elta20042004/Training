using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortr_Part_II
{
    class Program
    {

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            string[] k = new string[t];
            k = Console.ReadLine().Split(' ');
            int[] numbers = k.Select(ch => int.Parse(ch.ToString())).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                
                int j = i;
                j++;
                if (j > numbers.Length - 1)
                {
                    break;
                }
                    while (numbers[j] < numbers[j-1])
                    {
                        
                        int temp = numbers[j-1];
                        numbers[j-1] = numbers[j];
                        numbers[j] = temp;        
                        j--;
                        if (j == 0)
                        {
                            break;
                        }
                    }
                   
                    
                string[] result1 = numbers.Select(x => x.ToString()).ToArray();
                Console.WriteLine(String.Join(" ", result1));



            }


        }
    }
}
