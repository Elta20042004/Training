using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ochered
{
    class Program
    {
        public class Stack
        {
            private int startIndex;
            private int endIndex;
            private int[] _array;

            public Stack()
            {
                startIndex = 0;
                endIndex = 0;
                _array = new int[10];
            }

            public void Remove()
            {
                endIndex++;
                if (endIndex == _array.Length)
                {
                    endIndex = 0;
                }
            }

            public void Add(int k)
            {
                _array[startIndex] = k;
                startIndex++;

                if (startIndex == _array.Length)
                {
                     _array[endIndex] = k;
                }


            }
        }

        static void Main(string[] args)
        {
            Stack s = new Stack();

            Random r = new Random();
            int number = r.Next(1, 9);

            s.Add(number); s.Add(5); s.Add(4); s.Add(9); s.Add(0); s.Add(0);

        }


      
    }
}
