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
        private static int m;
        static void ZapolnenieMatrixRez( List<int> odinKrug, int a)
        {
            int i = a;
            int j = a;  //0,0  1,1   2,2..........         
            int pi = 0; // begunok po list
            while (j < (n - a))  // j<kollichestva stolbcov
            {
                matrixRez[i, j] = odinKrug[pi];
                j++;
                pi++;
            }
            i = i + 1;
            j = j - 1;
            while (i < (m - a))
            {
                matrixRez[i, j] = odinKrug[pi];
                i++;
                pi++;
            }
            i = i - 1;
            j = j - 1;
            while (j >= a)
            {
                matrixRez[i, j] = odinKrug[pi];
                j--;
                pi++;
            }
            i = i - 1;
            j = j + 1;
            while (i > a)
            {
                matrixRez[i, j] = odinKrug[pi];
                i--;
                pi++;
            }
        }
        static void SdvigLista(List<int> odinKrug, int a)
        {
            if(odinKrug.Count==0)
                return;
            List<int> copyOpinKrug = new List<int>();
            int k = 0;  // index s pravel'nogo mesta s uchotom shaga
            k = sdvig%odinKrug.Count;

            if (k > 0)
            {
                for (int i = k; i < odinKrug.Count; i++)
                {
                    copyOpinKrug.Add(odinKrug[i]);
                }
                for (int i = 0; i < k; i++)
                {
                    copyOpinKrug.Add(odinKrug[i]);
                }
            }
            else
            {
                copyOpinKrug = odinKrug;
            }


            ZapolnenieMatrixRez(copyOpinKrug, a);
        }

        static void Krug(int a)
        {
            List<int> odinKrug = new List<int>();
            int i = a;
            int j = a;  //0,0  1,1   2,2..........         
            while (j < (n - a))  // j<kollichestva stolbcov
            {
                odinKrug.Add(matrix[i, j]);
                j++;
            }
            i = i + 1;
            j = j - 1;
            while (i < (m - a))
            {
                odinKrug.Add(matrix[i, j]);
                i++;
            }
            i = i - 1;
            j = j - 1;
            while (j >= a)
            {
                odinKrug.Add(matrix[i, j]);
                j--;
            }
            i = i - 1;
            j = j + 1;
            while (i > a)
            {
                odinKrug.Add(matrix[i, j]);
                i--;
            }

            SdvigLista(odinKrug, a);
        }
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            m = int.Parse(str[0]);
            n = int.Parse(str[1]);
            sdvig = int.Parse(str[2]);
            matrix = new int[m, n];
            matrixRez = new int[m, n];
            int kollichestvoKrugov;
            if (m < n)
            {
                kollichestvoKrugov = m/2;
            }
            else
            {
                kollichestvoKrugov = n / 2;
            }
           
                      
            for (int i = 0; i < m; i++)
            {
                string[] r = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(r[j]);
                }
            }
            int a = 0;

            while (kollichestvoKrugov != 0)
            {

                Krug(a);
                a++;
                kollichestvoKrugov--;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrixRez[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}


