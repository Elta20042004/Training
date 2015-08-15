using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LincedList
{
    public class LincLictNode
    {
        public LincLictNode Next;
        public int Data;
    }

    class LincedList
    {
        private LincLictNode _root;
        private LincLictNode temp;
        public void Add(int data)
        {
            if (_root == null)
            {
                _root = new LincLictNode();
                _root.Data = data;
                temp = _root;
            }
            else
            {
                LincLictNode t = new LincLictNode();
                t.Data = data;
                temp.Next = t;
                temp = t;
            }

        }

        public void Remove(int data)
        {
            LincLictNode predydushij = null;
            //if (_root.Data==data)
            //{
            //    predydushij = _root.Next;
            //    _root.Next = null;
            //}        
            LincLictNode k = _root;
            while (k.Data != data)
            {
                predydushij = k;
                k = k.Next;
            }

            predydushij.Next = k.Next;
        }

        public void AddAfter(int data)
        {

        }

        public void Reverse()
        {
            LincLictNode predydushij = null;
            LincLictNode nastoyashij = _root.Next;
            LincLictNode sleduyushij = _root.Next.Next;

            _root.Next = null;
            nastoyashij.Next = predydushij;
            while (_root.Next!=null)
            {
                predydushij = nastoyashij;
                nastoyashij = sleduyushij;
                sleduyushij = nastoyashij.Next;
                nastoyashij.Next = predydushij;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LincedList test = new LincedList();
            test.Add(4);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Remove(6);
            //test.AddAfter(6);
            test.Add(9);
            test.Reverse();
        }
    }
}
