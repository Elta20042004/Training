using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Marge_Sort
{
    class Program
    {

      public static int[] merge_sort(int[] up, int[] down, int start, int end)
    {
        if (start == end)
        {
            down[start] = up[start];
            return down;
        }


        int middle = (start + end)/2;

        int[] leftArray = merge_sort(up, down, start, middle);
        int[] rightArray = merge_sort(up, down, middle + 1, end);

        // слияние двух отсортированных половин
        int[] target = leftArray == up ? down : up;

        int i = start; 
        int j = middle + 1;
        for (int k = start; k <= end; k++)
        {
            if (i <= middle && j <= end)
            {
                if (leftArray[i] < rightArray[j])
                {
                    target[k] = leftArray[i];
                    i++;
                }
                else
                {
                    target[k] = rightArray[j];
                    j++;
                }
            }
            else if (i <= middle)
            {
                target[k] = leftArray[i];
                i++;
            }
            else
            {
                target[k] = rightArray[j];
                j++;
            }
        }
        return target;
    }

        static void Main(string[] args)
        {
            int[] myNum = new[] { 5, 4, 7, 11, 2, 10, 1, 6, 3, 9, 8 };
            int[] second = new int[myNum.Length];
            int[] k = merge_sort(myNum, second, 0, myNum.Length - 1);
        }
    }
}
