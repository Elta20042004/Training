using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prostye_Chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            int counter = 0;
            int[] primes = new int[1000000];
            for (int i = 2; i <= 10000000; i++)
            {
                int j = 0;

                while ((j < counter)
                    && (Math.Sqrt(i) >= primes[j])
                    && (i % primes[j] > 0))
                {
                    j++;
                }

                if (j >= counter
                    || Math.Sqrt(i) < primes[j])
                {
                    primes[counter] = i;
                    counter++;
                }
            }

            Console.WriteLine("Prime number count is: {0}, calculated in: {1}", counter, s.Elapsed);
        }




        static void Main5(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            int counter = 0;
            int temp = 0;
            for (int i = 2; i <= 10000000; i++)
            {
                int j = 2;

                while ((j <= Math.Sqrt(i)) && (temp == 0))
                {
                    if (i % j == 0)
                    {
                        temp++;
                    }
                    j++;
                }

                if (temp == 0)
                {
                    counter++;
                }
                temp = 0;
            }

            Console.WriteLine("Prime number count is: {0}, calculated in: {1}", counter, s.Elapsed);
        }


        static void Main4(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            int counter = 0;
            int temp = 0;
            for (int i = 2; i <= 100000; i++)
            {
                int j = 2;

                while ((j <= Math.Sqrt(i)) && (temp == 0))
                {
                    if (i % j == 0)
                    {
                        temp++;
                    }
                    j++;
                }

                if (temp == 0)
                {
                    counter++;
                }
                temp = 0;
            }

            Console.WriteLine("Prime number count is: {0}, calculated in: {1}", counter, s.Elapsed);
        }



        static void Main3(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            int counter = 0;
            int temp = 0;
            for (int i = 2; i <= 50000; i++)
            {
                int j = 2;

                while ((j < i) && (temp == 0))
                {
                    if (i % j == 0)
                    {
                        temp++;
                    }
                    j++;
                }

                if (temp == 0)
                {
                    counter++;
                }
                temp = 0;
            }

            Console.WriteLine("Prime number count is: {0}, calculated in: {1}", counter, s.Elapsed);
        }




        static void Main1(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            int counter = 0;
            int temp = 0;
            for (int i = 2; i <= 50000; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        temp++;
                    }
                }
                if (temp == 1)
                {
                    counter++;
                }
                temp = 0;
            }

            Console.WriteLine("Prime number count is: {0}, calculated in: {1}", counter, s.Elapsed);
        }
    }
}
