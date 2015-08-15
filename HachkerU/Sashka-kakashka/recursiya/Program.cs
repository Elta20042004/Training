using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursiya
{
    class Program
    {
        static Random rand = new Random();

        private static void Sort(int[] myMas,int median, int startIndex, int endIndex)
        {
            if (endIndex - startIndex < 1)
            {
                return;
            }

            //int index = rand.Next(startIndex, endIndex);
            //int median = myMas[index];

            int j = endIndex;
            int i = startIndex;
            while (i < j)
            {
                if ((myMas[i] >= median) && (myMas[j] <= median))
                {
                    int temp = myMas[j];
                    myMas[j] = myMas[i];
                    myMas[i] = temp;
                }

                if (myMas[j] > median)
                {
                    j--;
                }
                else if (myMas[i] <= median)
                {
                    i++;
                }
            }

            Sort(myMas,myMas[i-1], startIndex, i - 1);
            Sort(myMas,myMas[endIndex], i + 1, endIndex);
        }


        private static void Main(string[] args)
        {
            int[] mass = new int[]{1,3,9,8,2,7,5};

            //for (int i = 0; i < mass.Length; i++)
            //{
            //    mass[i] = rand.Next(200000);
            //}

            int seredina = mass[mass.Length - 1];
            Sort(mass,seredina, 0, mass.Length - 1);







        }


    }
}
