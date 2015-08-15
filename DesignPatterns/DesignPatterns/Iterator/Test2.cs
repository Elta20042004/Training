using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator;

namespace DesignPatterns.Iterator2
{
    public class MyCollection : IEnumerable<int>
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

        public IEnumerator<int> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class Enumerator : IEnumerator<int>
        {
            private readonly MyCollection _myCollection;
            private int _arrayNumber;
            private int _indexInArray;

            public Enumerator(MyCollection myCollection)
            {
                _myCollection = myCollection;
            }

            public void Dispose()
            {
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public int Current
            {
                get
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
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public bool  MoveNext()
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
            var iterator1 = mycoll.GetEnumerator();
            var iterator2 = mycoll.GetEnumerator();

            iterator1.MoveNext();
            iterator1.MoveNext();
            iterator1.MoveNext();

            iterator2.MoveNext();
            iterator2.MoveNext();

            var curr1 = iterator1.Current; //12
            var curr2 = iterator2.Current; //3


        }
    }
}
