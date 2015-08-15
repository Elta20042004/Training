using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ListSome
{
    interface IMyList
    {
        void Add(int element);

        int Get(int index);
    }

    class MyList : IMyList
    {
        private int[] myMas;
        int count = 0;

        public MyList()
        {
            myMas = new int[1];
        }

        public void Add(int element)
        {

            myMas[count] = element;
            count++;

            if (count >= myMas.Length)
            {
              
                var k = count * 2;
                int[] myBagMas = new int[k];

                myMas.CopyTo(myBagMas, 0);

                myMas = myBagMas;
            }
        }

        public int Get(int index)
        {
            return myMas[index];
        }
    }

    class Program
    {
        static void Main2(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            ArrayList myList = new ArrayList();
            for (int i = 0; i < 100000000; i++)
            {
                myList.Add(i);
            }
            Console.WriteLine(s.Elapsed);
        } 

        static void Main3(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            List<int> myList = new List<int>();
            for (int i = 0; i < 100000000; i++)
            {
                myList.Add(i);
            }
            Console.WriteLine(s.Elapsed);
        } 

        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            IMyList myList = new MyList();
            for (int i = 0; i < 100000000; i++)
            {
                myList.Add(i);
            }
            Console.WriteLine(s.Elapsed);
        }


        static void Main1(string[] args)
        {
            IMyList myList = new MyList();
            string a;
            do
            {
                a = Console.ReadLine();
                int b = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case "a":
                        myList.Add(b);
                        break;
                    case "g":
                        Console.WriteLine(myList.Get(b));
                        break;
                }
            } while (a!= "q");

        }
    }
}
