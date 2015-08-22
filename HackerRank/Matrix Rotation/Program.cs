using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Rotation
{
    class Program
    {
        static int[,] matrix;
        static int[,] matrixRez;
        private static int sdvig;
        private static int n;
        private static int a;
        private static int lengthStolbca;
        private static int lengthStroki;
        private static int t;
        static void ZapolnenieMatrixRez(List<int> odinKrug, int i)
        {
            int counter = 0;
            int k = t;

            if (odinKrug.Count != 4)
            {
                while (counter < odinKrug.Count)
                {
                    while (k < lengthStolbca - 1)
                    {
                        if (i == odinKrug.Count)
                        {
                            i = 0;
                        }
                        matrixRez[a, k] = odinKrug[i];
                        k++;
                        i++;
                        counter++;
                    }
                    k = t;
                    while (k < lengthStroki - 1)
                    {
                        if (i == odinKrug.Count)
                        {
                            i = 0;
                        }
                        matrixRez[k, lengthStroki - 1] = odinKrug[i];
                        k++;
                        i++;
                        counter++;
                    }
                    k = lengthStolbca - 1;
                    while (k > 0)
                    {
                        if (i == odinKrug.Count)
                        {
                            i = 0;
                        }
                        matrixRez[lengthStolbca - 1, k] = odinKrug[i];
                        k--;
                        i++;
                        counter++;
                    }
                    k = lengthStroki - 1;
                    while (k > 0)
                    {
                        if (i == odinKrug.Count)
                        {
                            i = 0;
                        }
                        matrixRez[k, a] = odinKrug[i];
                        k--;
                        i++;
                        counter++;
                    }

                }
            }
            else
            {
                while (counter < odinKrug.Count)
                {

                    if (i == odinKrug.Count)
                    {
                        i = 0;
                    }
                    matrixRez[a, k] = odinKrug[i];
          
                    i++;
                    counter++;
                    if (i == odinKrug.Count)
                    {
                        i = 0;
                    }
                    matrixRez[k, lengthStroki] = odinKrug[i];
  
                    i++;
                    counter++;

                    k = lengthStolbca;

                    if (i == odinKrug.Count)
                    {
                        i = 0;
                    }
                    matrixRez[lengthStroki, k] = odinKrug[i];
                    k--;
                    i++;
                    counter++;

                    k = lengthStolbca;

                    if (i == odinKrug.Count)
                    {
                        i = 0;
                    }
                    matrixRez[k, a] = odinKrug[i];
                    k--;
                    i++;
                    counter++;


                }
            }

        }
        static void SdvigMatrix(List<int> odinKrug)
        {
            int counter = 0;
            int i = 0;

            while (counter != sdvig)
            {
                if (i == odinKrug.Count)
                {
                    i = 0;
                }

                counter++;
                i++;
            }

            ZapolnenieMatrixRez(odinKrug, i);
        }

        static void Krug()
        {
            List<int> odinKrug = new List<int>();
            int k = t; //uvelichivaetsya na kazhdom kruge
            if (lengthStolbca != 2)
            {
                while (k < lengthStolbca - 1)
                {
                    odinKrug.Add(matrix[a, k]);
                    k++;
                }
                k = t;
                while (k < lengthStolbca - 1)
                {
                    odinKrug.Add(matrix[k, lengthStolbca - 1]);
                    k++;
                }
                k = lengthStroki - 1;
                while (k > 0)
                {
                    odinKrug.Add(matrix[lengthStolbca - 1, k]);
                    k--;
                }
                k = lengthStroki - 1;
                while (k > 0)
                {
                    odinKrug.Add(matrix[k, a]);
                    k--;
                }
            }
            else
            {

                odinKrug.Add(matrix[a, k]);
                odinKrug.Add(matrix[k, lengthStroki]);

                k = lengthStolbca;

                odinKrug.Add(matrix[lengthStolbca, k]);
                odinKrug.Add(matrix[k, a]);

            }


            SdvigMatrix(odinKrug);

        }
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int m = int.Parse(str[0]);
            n = int.Parse(str[1]);
            sdvig = int.Parse(str[2]);
            matrix = new int[m, n];
            matrixRez = new int[m, n];
            int kollichestvoKrugov = n / 2;

            for (int i = 0; i < m; i++)
            {
                string[] r = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(r[j]);
                }
            }
            a = 0;
            lengthStolbca = n;
            lengthStroki = m;
            t = 0;
            while (kollichestvoKrugov != 0)
            {

                Krug();
                t++;
                lengthStolbca = lengthStolbca - 2;
                lengthStroki = lengthStroki - 2;
                a++;
                kollichestvoKrugov--;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ",matrixRez[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
