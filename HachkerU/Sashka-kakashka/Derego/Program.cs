using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derego
{
    class Program
    {
        static int i = 1;
        static int j = 2;
        private static int depth = 1;
        public static void Recursiya(string papka, int depth)
        {
            string temp = "";
            string temp1 = "";
            if (depth > 3)
            {
                return;
            }

            temp = papka + "\\" + i;
            Directory.CreateDirectory(temp);
            i++;
            temp1 = papka + "\\" + i;
            Directory.CreateDirectory(temp1);
            i++;
            depth++;


            Recursiya(temp, depth);
            Recursiya(temp1, depth);






        }

        static void Main(string[] args)
        {
            string popka = @"E:\Lena\Recursia";
            Recursiya(popka, depth);
        }
    }
}
