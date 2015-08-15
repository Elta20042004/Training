using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil_7
{
    class Temp : IComparable<Temp>, ICloneable
    {
        private int t;

        public Temp(int _t)
        {
            t = _t;
        }

        public object Clone()
        {
            Temp temp = new Temp(t);
            temp.t = this.t;
            return temp;
        }

        public int CompareTo(Temp other)
        {                    
            return this.t.CompareTo(other.t);
        }

        public override string ToString()
        {
            return this.t.ToString();
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
            foreach (var i in k)
            {
                MyList.Add(i);
            }
            MyList.Sort();
        }

        public IEnumerable<T> CloneObjects()
        {
            MyClass<T> test = new MyClass<T>();
            foreach (var i in MyList)
            {
                test.Add((T)i.Clone());
            }
            return test.MyList;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            MyClass<Temp> myClass = new MyClass<Temp>();
            myClass.Add(new Temp(15));
            myClass.Add(new Temp(6));
            myClass.Add(new Temp(7));

            var myClass1=myClass.CloneObjects();
        }
    }
}
