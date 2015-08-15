using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steckLinkedList
{
    internal class Program
    {
        
        public class Stack
        {
            private Node temp;

           
            public class Node
            {
                public int Data;
                public Node Next;
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

            public Node Remove()
            {                
                temp = temp.Next;
                return temp;
            }

            public Node Add(int i)
            {
                Node k = new Node();
                k.Data = i;
       
                k.Next = temp;
                temp = k;
                return k;
            }
        }




        static void Main(string[] args)
        {
            Stack s = new Stack();           

           s.Add(10);
           s.Add(5);
           s.Remove();

        }

    }
}
