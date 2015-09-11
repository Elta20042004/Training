using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LincedList
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next;
        public T Data;
    }

    class LinkedList<T> where T :class
    {
        private LinkedListNode<T> _head;
        private LinkedListNode<T> _tail;  //hvost
        public void Add(T data)
        {
            if (_head == null)
            {
                _head = new LinkedListNode<T>();
                _head.Data = data;
                _tail = _head;
            }
            else
            {
                LinkedListNode<T> t = new LinkedListNode<T>();
                t.Data = data;
                _tail.Next = t;
                _tail = t;
            }
        }

        public void Remove(T data)
        {
            LinkedListNode<T> previous = null;

            LinkedListNode<T> k = _head;
            while (k.Data != data)
            {
                previous = k;
                k = k.Next;
            }

            previous.Next = k.Next;
        }


        public void Reverse()
        {
            LinkedListNode<T> previous = _head;                  //predydushij
            LinkedListNode<T> real = _head.Next;                 //nastoyashij
            LinkedListNode<T> next = _head.Next.Next;            //sleduyushij

            previous.Next = null;
            real.Next = previous;

            while (next != null)
            {
                previous = real;
                real = next;
                next = next.Next;
                real.Next = previous;
            }
        }
    }

    class Program
    {

        static bool HasLoop<T>(LinkedListNode<T> head)
        {
            var first = head;
            bool found = true;

            if (first.Next == null)
            {
                return false;
            }

            var second = head.Next.Next;


            while (first != second && second != null && second.Next != null)
            {
                first = first.Next;
                second = second.Next.Next;
            }

            if (second == null || second.Next == null)
            {
                found = false;
            }
            return found;
        }

        static void Main(string[] args)
        {
            //LinkedList test = new LinkedList();
            //test.Add(4);
            //test.Add(5);
            //test.Add(6);
            //test.Add(7);
            //test.Remove(6);
            //test.Add(8);
            //test.Add(9);
            //test.Reverse();

            LinkedListNode<int> one = new LinkedListNode<int>();
            one.Data = 1;
            //LinkedListNode two = new LinkedListNode();
            //two.Data = 2;
            //LinkedListNode three = new LinkedListNode();
            //three.Data = 3;
            //LinkedListNode four = new LinkedListNode();
            //four.Data = 4;
            //LinkedListNode five = new LinkedListNode();

            one.Next = one;

            bool found = HasLoop(one);

        }
    }
}
