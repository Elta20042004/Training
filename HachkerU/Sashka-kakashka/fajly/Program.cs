using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace fajly
{
    class Program
    {
        static int i = 1;
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
            
            Recursiya(temp, depth+1);



            temp1 = papka + "\\" + i;
            Directory.CreateDirectory(temp1);
            i++;
            Recursiya(temp1, depth+1);

        }

        static void Main(string[] args)
        {
            int depth = 1;
            
            string popka = @"E:\Lena\Recursia";
            Recursiya(popka, depth);
        }
    }
}
