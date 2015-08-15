using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace arrayStack
{
    class Program
    {
        public class Stack
        {
            private int _count;
            private int[] _array;

            public Stack()
            {
                _count = 0;
                _array = new int[10];
            }

            public void Remove()
            {
                _count--;
            }

            public void Add(int k)
            {
                _array[_count] = k;
                _count++;               
            }
        }

        static void Main(string[] args)
        {
            Stack s =new Stack();

            Random r = new Random();
            int number = r.Next(1, 9);

            s.Add(number);
            
        }
    }
}
