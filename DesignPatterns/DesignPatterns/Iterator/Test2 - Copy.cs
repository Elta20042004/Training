using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator;

namespace DesignPatterns.Iterator3
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
            foreach (var i in _a)
            {
                yield return i;
            }

            foreach (var i in _b)
            {
                yield return i;
            }

            foreach (var i in _c)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
