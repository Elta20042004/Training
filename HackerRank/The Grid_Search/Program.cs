using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Grid_Search
{
    class Program
    {
        static int[,] matrixBig;
        static int[,] matrixSmall;
        static int mSmall;
        static int nSmall;
        static int m;
        static int n;

        static bool Test(int iT, int jT)
        {
            int a = iT;
            int b = jT;
            bool rez = true;
            for (int i=iT; i < iT + mSmall; i++)
            {
                for (int j=jT; j < jT + nSmall; j++)
                {
                    if (matrixBig[i,j]!=matrixSmall[i-a,j-b])
                    {
                        i = iT + mSmall;
                        j = jT + nSmall;
                            rez = false;
                    }
                }
            }
            return rez;
        }
        static void Test()
        {
            int iI = mSmall-1;
            int jJ = nSmall-1;
            string rezult = "NO";
            for (int i=0; i<m; i++)
            {
                for (int j=0; j<n;j++)
                {
                    if (matrixBig[i,j]==matrixSmall[0,0]
                        && i+iI<m
                        && j+jJ<n
                        && matrixBig[i+iI,j+jJ]==matrixSmall[iI,jJ])
                    {
                       bool rez = Test(i, j);
                        if (rez==true)
                        {
                            rezult = "YES";
                            i = m;
                            j = n;
                        }
                    }
                }
            }
            Console.WriteLine(rezult);
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int k=0; k<t; k++)
            {
                string[] str = Console.ReadLine().Split(' ');
                m = int.Parse(str[0]);
                n = int.Parse(str[1]);
                matrixBig = new int[m, n];

                for (int i=0; i<m; i++)
                {
                    string str1 = Console.ReadLine();
                    
                    for(int j=0;j<n;j++)
                    {
                        matrixBig[i, j] = str1[j]-'0';
                    }                                   }

                string[] strSmall = Console.ReadLine().Split(' ');
                mSmall = int.Parse(strSmall[0]);
                nSmall = int.Parse(strSmall[1]);
                matrixSmall = new int[mSmall, nSmall];

                for (int iS = 0; iS < mSmall; iS++)
                {
                    string strokaSmall = Console.ReadLine();

                    for (int jS = 0; jS < nSmall; jS++)
                    {
                        matrixSmall[iS, jS] = strokaSmall[jS]-'0';
                    }
                 
                }

                Test();

            }
        }
    }
}
