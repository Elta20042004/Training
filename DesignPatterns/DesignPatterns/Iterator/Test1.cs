using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    interface IAggregate
    {
        IIterator GetIterator();
    }

    public interface IIterator
    {
        object Current();
        bool Next();
        void First();
    }

    public class MyCollection : IAggregate
    {
        private readonly int[] _a;
        private readonly int[] _b;
        private readonly int[] _c;

        public MyCollection(int[] a, int[] b, int[] c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public int[] A
        {
            get { return _a; }
        }

        public int[] B
        {
            get { return _b; }
        }

        public int[] C
        {
            get { return _c; }
        }

        //  public void
        public IIterator GetIterator()
        {
            var result = new Iterator(this);
            return result;
        }


        public class Iterator : IIterator
        {
            private readonly MyCollection _myCollection;
            private int _arrayNumber;
            private int _indexInArray;

            public Iterator(MyCollection myCollection)
            {
                _myCollection = myCollection;
            }

            public object Current()
            {
                var rez = 0;
                switch (_arrayNumber)
                {
                    case 1:
                        rez = _myCollection._a[_indexInArray];
                        break;
                    case 2:
                        rez = _myCollection._b[_indexInArray];
                        break;
                    case 3:
                        rez = _myCollection._c[_indexInArray];
                        break;
                }

                return rez;
            }

            public bool Next()
            {
                switch (_arrayNumber)
                {
                    case 1:
                        if (_indexInArray <= _myCollection._a.Length - 1)
                        {
                            _indexInArray = _indexInArray + 1;
                        }
                        else
                        {
                            _arrayNumber = 2;
                            _indexInArray = 0;
                        }              
                        break;
                    case 2:
                        if (_indexInArray <= _myCollection._b.Length - 1)
                        {
                            _indexInArray = _indexInArray + 1;
                        }
                        else
                        {
                            _arrayNumber = 3;
                            _indexInArray = 0;
                        }                   
                        break;
                    case 3:
                        if (_indexInArray <= _myCollection._c.Length - 1)
                        {
                            _indexInArray = _indexInArray + 1;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                }
                return true;
            }

            public void First()
            {
                _arrayNumber = 1;
                _indexInArray = 0;
            }
        }
    }

    class Test1
    {


        public void TestA()
        {
            var mycoll = new MyCollection(new[] { 1, 2, 3 }, new[] { 12, 13, 14 }, new[] { 23, 24, 25 });
            var iterator1 = mycoll.GetIterator();
            var iterator2 = mycoll.GetIterator();

            iterator1.Next();
            iterator1.Next();
            iterator1.Next();

            iterator2.Next();
            iterator2.Next();

            var curr1 = iterator1.Current(); //12
            var curr2 = iterator2.Current(); //3


        }
    }
}
