using System;


namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string k = Console.ReadLine();
            int length = k.Length;
            int stolbcy;
            int strochki;

            int nizhnijIndex = (int)Math.Sqrt(length);
            int verhnijIndex = nizhnijIndex + 1;

            if (nizhnijIndex * verhnijIndex < length)
            {
                stolbcy = verhnijIndex;
                strochki = verhnijIndex;
            }
            else if (nizhnijIndex * nizhnijIndex == length)
            {
                stolbcy = nizhnijIndex;
                strochki = nizhnijIndex;
            }
            else
            {
                strochki = nizhnijIndex;
                stolbcy = verhnijIndex;
            }
         
            char[,] numbers = new char[strochki,stolbcy];
           


            for (int m = 0; m < k.Length; m++)
            {
               int i = m/stolbcy;
               int j = m%stolbcy;                
                numbers[i, j] = k[m];
            }

            for (int i = 0; i < stolbcy; i++)
            {
                for (int j = 0; j < strochki; j++)
                {
                    if (numbers[j, i] > 0)
                    {
                        Console.Write(numbers[j,i]);
                    }                 
                }

                Console.Write(' ');
            }

        }
    }
}
