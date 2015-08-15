﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly Random _rng = new Random();

        private static string RandomString(int size)
        {
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = _chars[_rng.Next(_chars.Length)];
            }
            return new string(buffer);
        }

        static void Main(string[] args)
        {
            int N = 50000;
            List<string> str = new List<string>();
            for (int i = 0; i < 10000; i++)
            {
                str.Add(RandomString(20));
            }
            Random r =new Random();

            using (var sw = new StreamWriter("d:\\input.txt",false))
            {
                sw.WriteLine(N);
                for (int i = 0; i < N; i++)
                {
                    int next = r.Next(str.Count - 1);
                    sw.WriteLine("{0} {1}", str[next], r.Next(10));
                }
            }
        }
    }
}
