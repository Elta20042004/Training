using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulyator
{
    class Program
    {
        private class Stack
        {

            private object[] _data;
            private int _counter;

            public Stack()
            {
                _data = new object[10000];
                _counter = 0;
            }


            public void Add(object data)
            {
                _data[_counter] = data;
                _counter++;
            }

            public void Remove()
            {
                _data[_counter - 1] = null;
                _counter--;
            }

            public object Last()
            {
                return _data[_counter - 1];
            }

            public int Count()
            {
                return _counter;
            }
        }

        public static int Solve(int a, int b, char x)
        {
            int rezult = 0;

            switch (x)
            {
                case '+':
                    rezult = a + b;
                    break;
                case '-':
                    rezult = a - b;
                    break;
                case '*':
                    rezult = a * b;
                    break;
                case '/':
                    rezult = a / b;
                    break;
            }
            return rezult;
        }

        static void Main(string[] args)
        {
            Stack s = new Stack();

            string temp = Console.ReadLine();
            int a;
            int b;
            char x;

            for (var i = 0; i <= temp.Length - 1; i++)
            {
                if ((temp[i] >= '0') && (temp[i] <= '9'))
                {
                    int j = 0;
                    while ((temp[i + j] >= '0') && (temp[i + j] <= '9'))
                    {
                        j++;
                    }

                    string str = temp.Substring(i, j);
                    int k = int.Parse(str);
                    s.Add(k);
                    i = i + j-1;
                }
                else if (temp[i] == ')')
                {
                    b = (int)s.Last();
                    s.Remove();
                    x = (char)s.Last();
                    s.Remove();
                    a = (int)s.Last();
                    s.Remove();
                    s.Remove();
                    int Rez = Solve(a, b, x);
                    s.Add((object)Rez);
                }
                else
                {
                    s.Add(temp[i]);
                }
                
            }
                Console.WriteLine(s.Last());
        }
    }
}
