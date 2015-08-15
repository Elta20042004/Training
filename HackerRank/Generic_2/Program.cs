using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_2
{
    class Temp : ICloneable, IComparable<Temp>
    {
        private int k;

        public Temp(int _k)
        {
            k = _k;
        }

        public object Clone()
        {
            Temp temp = new Temp(k);
            this.k = temp.k;
            return temp;
        }

        public int CompareTo(Temp other)
        {
            return this.k.CompareTo(other.k);
        }

        public override string ToString()
        {
            return this.k.ToString();
        }
    }

    class MyClass<T> where T : IComparable<T>, ICloneable
    {
        private List<T> MyList;

        public MyClass()
        {
            MyList = new List<T>();
        }

        public void Remove(T item)
        {
            MyList.Remove(item);
        }

        public void Add(T item)
        {
            MyList.Add(item);
            MyList.Sort();
        }

        public void AddRange(IEnumerable<T> k)
        {
            MyList.AddRange(k);
            MyList.Sort();
        }

        public IEnumerable<T> CloneObject()
        {
            MyClass<T> my = new MyClass<T>();
            foreach (var i in MyList)
            {
                my.Add((T)i.Clone());
            }

            return my.MyList;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass<Temp> myMy = new MyClass<Temp>();
            myMy.Add(new Temp(4));
            myMy.Add(new Temp(1));
            myMy.Add(new Temp(3));

               
        }
    }
}
