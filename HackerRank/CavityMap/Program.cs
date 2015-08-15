using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavityMap
{
    class Program
    {
        public static void Glubina(int t, int[,] temp)
        {
            char[,] myChar = new char[t,t];
            string k = "m";

            for (var i = 1; i <= t - 2; i++)
            {
                for (int j = 1; j <= t - 2; j++)
                {
                    if ((temp[i, j] > temp[i, j + 1]) && (temp[i, j] > temp[i, j - 1])&&(temp[i,j]>temp[i-1,j])&&(temp[i,j]>temp[i+1,j]))
                    {
                        temp[i, j] = 10;
                    }
                }

            }


            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    if (temp[i,j] == 10)
                    {
                        myChar[i,j] = 'X';
                    }
                    else
                    {
                        myChar[i,j] = (char)(temp[i,j] + '0');
                    }
                }
            }

            string otvet ="";
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    
                    otvet = otvet + myChar[i,j].ToString();
                   
                } 
                Console.WriteLine(otvet);
                otvet ="";
            }

        }

        static void Main(string[] args)
        {
            
            int t = int.Parse(Console.ReadLine());
            string[] str = new string[t];



            for (var i = 0; i < str.Length; i++)
            {
                string k = Console.ReadLine();
                str[i] = k;

            }

            int[,] matrica = new int[t, t];

            for (var i = 0; i < str.Length; i++)
            {
                string p = str[i];
                char[] myChar = new char[p.Length];
                myChar = p.ToCharArray();
                int[] Aint = Array.ConvertAll(myChar, c => (int)Char.GetNumericValue(c));

                for (int j = 0; j < Aint.Length; j++)
                {
                    matrica[i, j] = Aint[j];
                }

            }

    
            Glubina(t, matrica);


            Console.ReadLine();
        }
    }
}
