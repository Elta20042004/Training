using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    internal class Program
    {
        //     10
        //www.abc.xy
        //87

        //fff.jkl.gh


//        10
//159357lcfd
//98

        //159357fwzx
        private static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string f = Console.ReadLine();
            //string f = "159357lcfd";
            char[] text = new char[t];
            text = f.ToCharArray();
            int Shag = int.Parse(Console.ReadLine());
            //int Shag = 98;

            int[] Up = new int[26];
            int counter = 0;
            for (int u = 0; u < 26; u++)
            {
                Up[u] = 17 + counter;
                counter++;
            }
            counter = 0;
            int[] Down = new int[26];
            for (int u = 0; u < 26; u++)
            {
                Down[u] = 49 + counter;
                counter++;
            }
            char simbol = ' ';
            string k = "";
            int shag = Shag;
            int p = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] != '-') && (text[i] != '_') &&
                    (text[i] != '.') && (text[i] != ',') &&
                    (text[i] != ':') && (text[i] != '!') &&
                    (text[i] != '?') && (text[i] != '1') &&
                    (text[i] != '2') && (text[i] != '3') &&
                    (text[i] != '4') && (text[i] != '5') &&
                    (text[i] != '6') && (text[i] != '7') &&
                    (text[i] != '8') && (text[i] != '9') &&
                    (text[i] != '0') && (text[i] != '`') && 
                    (text[i] != '\\') && (text[i] != '/')&&
                    (text[i] != '*') && (text[i] != '+') &&
                    (text[i] != '=') && (text[i] != '#') && 
                    (text[i] != '*') && (text[i] != '@') &&
                    (text[i] != '<') && (text[i] != '>') &&
                    (text[i] != '(') && (text[i] != ')') &&
                    (text[i] != '{') && (text[i] != '}') &&
                    (text[i] != '[') && (text[i] != ']'))
                {
                    if (char.IsUpper(text[i]))
                    {
                        p = text[i] - '0';
                        while (shag != 0)
                        {
                            if (p == Up[Up.Length - 1])
                            {
                                p = Up[0];                           
                            }
                            else
                            {
                                p++;
                            }
                            shag--;
                        }                     
                    }
                    else
                    {
                        p = text[i] - '0';
                        while (shag != 0)
                        {
                            if (p == Down[Down.Length - 1])
                            {
                                p = Down[0];
                            }
                            else
                            {
                                p++;
                            }
                            shag--;
                        }
                    }


                    simbol = (char)(p + '0');
                    shag = Shag;
                    k = k + simbol;

                }
                else
                {
                    k = k + text[i];
                }
            }
            Console.WriteLine(k);
        }
    }
}