using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Skobki
{
    class Program
    {
        private class Stec
        {

            private int[] _Data;
            private int _counter;
            
            public Stec()
            {
                _Data = new int[10000];
                _counter = 0;
            }
            
            
            public void Add(int data)
            {
                _Data[_counter] = data;
                _counter++;
            }

            public void Remove()
            {
                _counter--;
            }
            
            public int Last()
            {
                 return _Data[_counter-1];             
            }

            public int Count()
            {
                return _counter;
            }
        }

        static void Main(string[] args)
        {
            Stec test = new Stec();
            int x = 0;

            string elements = Console.ReadLine();

            for (int i = 0; i <= elements.Length-1; i++)
            {
                switch (elements[i])
                {
                    case '(':
                        x = 1;
                        break;
                    case '{':
                        x = 2;
                        break;
                    case '[':
                        x = 3;
                        break;
                    case ')':
                        x = -1;
                        break;
                    case '}':
                        x = -2;
                        break;
                    case ']':
                        x = -3;
                        break;
                }

                if (x > 0)
                {
                    test.Add(x);
                }
                else
                {
                    
                    if ((test.Count()>0)&&(test.Last() + x == 0))
                    {
                        test.Remove();
                    }
          
                    else
                    {
                        Console.WriteLine("Invalid");
                        return;                       
                    }
                }

            }

            if (test.Count() > 0)
            {
                Console.WriteLine("Invalid");
            }
            else
            { 
                Console.WriteLine("Valid");
            }
            
        }
    }
}
