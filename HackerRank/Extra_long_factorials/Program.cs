using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Extra_long_factorials
{
    internal class Program
    {
        public static List<int> perevod(int chislo)
        {
            string k = chislo.ToString();
            List<int> rez = new List<int>();
            int j = 0;
            for (int i = k.Length - 1; i >= 0; i--)
            {
                rez.Add(k[i] - '0');
            }
            return rez;
        }

        public static int p = 0;
        public static List<int> otvet = new List<int>();

        public static void summa(List<int> umnozhenie)
        {
            int j = p;
            int ostatok = 0;
            if (p == 0)
            {
                otvet = new List<int>();
                otvet = umnozhenie;
            }
            else
            {             
                for (int i = 0; i < umnozhenie.Count; i++)
                {
                    int rezult = otvet[j] + umnozhenie[i] + ostatok;
                    if (i <= umnozhenie.Count - 1)
                    {
                        if (rezult >= 10)
                        {
                            otvet[j] = rezult % 10;
                            ostatok = rezult / 10;
                        }
                        else
                        {
                            otvet[j] = rezult;
                            ostatok = 0;
                        }
                        j++;
                        if (otvet.Count == j)
                        {
                            otvet.Add(0);
                        }
                    }
                    else
                    {
                        
                        otvet[j] = rezult % 10;
                        j++;
                        if (otvet.Count == j)
                        {
                            otvet.Add(0);
                        }
                        otvet[j] = rezult / 10;
                    }
                }
                //otvet.RemoveAt(otvet.Count-1);
            }
            
            p++;
        }



        public static List<int> Umn(List<int> B, List<int> A)
        {
            List<int> umnozhenie = new List<int>();
            int ostatok = 0;
            if (B.Count < A.Count)
            {
                List<int> temp = B;
                B = A;
                A = temp;
            }


            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < B.Count; j++)
                {
                    int k = (B[j] * A[i]) + ostatok;

                    if (j < B.Count - 1)
                    {
                        if (k >= 10)
                        {
                            umnozhenie.Add(k % 10);
                            ostatok = k / 10;
                        }
                        else
                        {
                            umnozhenie.Add(k);
                            ostatok = 0;
                        }
                    }
                    else
                    {
                        if (k >= 10)
                        {
                            umnozhenie.Add(k % 10);
                            umnozhenie.Add(k / 10);
                        }
                        else
                        {
                            umnozhenie.Add(k);
                        }
                    }
                }
                if (A.Count == 1)
                {
                    otvet = umnozhenie;
                }
                else
                {
                    summa(umnozhenie);
                    umnozhenie = new List<int>();                
                    ostatok = 0;

                }
            }

            return otvet;
        }

        public static List<int> myFaktorial(int k)
        {
            List<int> a = new List<int>(new int[] { 1 });
            for (int i = 2; i <= k; i++)
            {
                List<int> b = perevod(i);
                a = Umn(a, b);
            }

            return a;
        }

        public static long PerehodToLong(List<int> B)
        {
            long p = 0;
            for (int i = B.Count - 1; i >= 0; i--)
            {
                p = B[i] + (p * 10);
            }
            return p;
        }



        static void Main(string[] args)
        {
            //int k = int.Parse(Console.ReadLine());
            int k = 10;
            List<int> b = new List<int>();
            List<int> a = new List<int>(new int[] { 1 });
           // a = perevod(a);
           // a = Umn(a, b);


            //long second = 1;
            for (int i = 2; i <= k; i++)
            {
                p = 0;
                b = perevod(i);
                a = Umn(a, b);
            }

            int m = a.Count - 1;
            while (a[m]==0)
            {
                m--;
            }
            int j = m;
            for (int h = j; h >=0; h--)
            {
                Console.Write(a[h]);
            }           
        }
    }
}


//1! = 1
//2! = 2
//3! = 6
//4! = 24
//5! = 120
//6! = 720
//7! = 5040
//8! = 40320
//9! = 362880
//10! = 3628800
//11! = 39916800
//12! = 479001600
//13! = 6227020800
//14! = 87178291200
//15! = 1307674368000
//16! = 20922789888000
//17! = 355687428096000
//18! = 6402373705728000
//19! = 121645100408832000
//20! = 2432902008176640000
//21! = 51090942171709440000
//22! = 1124000727777607680000
//23! = 25852016738884976640000
//24! = 620448401733239439360000
//25! = 15511210043330985984000000