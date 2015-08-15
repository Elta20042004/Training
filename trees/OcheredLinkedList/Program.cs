using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OcheredLinkedList
{
    class Program
    {
        public class Stack
        {
            private Node head;
            private Node tail;
            public class Node
            {
                public int Data;
                public Node Next;
                public Node Prev;
            }


            public void PrintNode(Node root)
            {
                var node = root;
                while (node != null)
                {
                    Console.Write("\"{0}\" --> ", node.Data);
                    node = node.Next;
                }
                Console.WriteLine("null");
            }

            public void Remove()
            {
                tail=tail.Prev;
                tail.Next = null;               
            }

            public Node Add(int i)
            {
                Node k = new Node();
                k.Data = i;                
                k.Next = head;
                if (head != null)
                {
                    head.Prev = k;
                }
                else
                {
                    tail = k;
                }
                head = k;
             
                return k;
            }
        }


        static void Main(string[] args)
        {
            Stack s = new Stack();

            s.Add(1);
            s.Add(2);
            s.Add(3);
            s.Add(4);
            s.Remove();
            s.Add(5);
            s.Add(6);
            s.Remove();
        }
    }
}
