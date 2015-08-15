using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IEnumerable_IEnumerator_2
{
    public class MyData
    {
        public string Name;
        public int Age;


        public MyData(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class MyPeople : IEnumerable
    {
        private MyData[] _myList;

        public MyPeople(MyData[] myList)
        {
            _myList = new MyData[myList.Length];

            for (int i = 0; i < _myList.Length; i++)
            {
                _myList[i] = myList[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new Em(_myList);
        }
    }

    public class Em : IEnumerator
    {
        private MyData[] _myList;
        int position = -1;
        public Em(MyData[] myEm)
        {
            _myList = myEm;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _myList.Length);
        }

        public void Reset()
        {
            position = -1;
        }


        //public object Current { get; private set; }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public MyData Current
        {
            get
            {
                try
                {
                    return _myList[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            MyData[] peopleArray = new MyData[3]
        {
            new MyData("John",14),
            new MyData("Jim", 15),
            new MyData("Sue",16),
        };

            MyPeople myP = new MyPeople(peopleArray);
            foreach (MyData p in myP)
                Console.WriteLine(p.Name + " " + p.Age);
        }
    }
}
