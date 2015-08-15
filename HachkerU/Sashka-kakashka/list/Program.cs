using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Programm
    {
        public class Node
        {
            public Node Next;
            public int Data;
        }

        public static void PrintNode(Node root)
        {
            var node = root;
            while (node != null)
            {
                Console.Write("\"{0}\" --> ", node.Data);
                node = node.Next;
            }
            Console.WriteLine("null");
        }

        private static void Main(string[] args)
        {
            var temp = new Node() { Data = 4 };
            temp = new Node() { Data = 3, Next = temp };
            temp = new Node() { Data = 2, Next = temp };
            temp = new Node() { Data = 1, Next = temp };
            temp = new Node() { Data = 0, Next = temp };
            PrintNode(temp);

            temp = ReverseNode(temp);

            PrintNode(temp);

            temp = Remove(temp, 4);
            PrintNode(temp);

            temp = AddFirst(temp, 10);
            PrintNode(temp);

            temp = AddAfter(temp, 2, 10);
            PrintNode(temp);


            var temp1 = new Node() {Data = 4};
            var temp2 = new Node() {Data = 3};
            var temp3 = new Node() {Data = 2};
            var temp4 = new Node() {Data = 1};
            temp1.Next = temp2;
            temp2.Next = temp3;
            temp3.Next = temp4;
            temp4.Next = temp2;

            bool ok = HasPeriod(temp1);
            Console.WriteLine(ok);

         }

        private static Node AddFirst(Node first, int i)
        {
            Node k = new Node();
            k.Data = i;
            k.Next = first;

            return k;
        }

        private static Node AddAfter(Node first, int element, int newElement)
        {
            Node prev = first;
            while (prev.Data != element)
            {
                prev = prev.Next;
            }

            Node m = new Node();
            m.Data = newElement;

            m.Next = prev.Next;
            prev.Next = m;

            return first;
        }

        private static bool HasPeriod(Node first)
        {
            Node prev = first;
            Node k = first.Next;


            while ((k != prev) && (k.Next != null))
            {
                prev = prev.Next;
                k = k.Next.Next;
            }
            
            return k == prev;
        }


        private static Node Remove(Node first, int i)
        {
            Node prev = null;
            if (first.Data == i)
            {
                prev = first.Next;
                first.Next = null;
                return prev;
            }


            Node k = first;
            while (k.Data != i)
            {
                prev = k;
                k = k.Next;
            }

            prev.Next = k.Next;
            return prev;
        }

        private static Node ReverseNode(Node first)
        {
            Node prev = null;
            Node temp;
            while (first != null)
            {
                temp = first.Next;
                first.Next = prev;
                prev = first;
                first = temp;
            }

            return prev;
        }
    }






    class Program2
    {

        public static int i = 0;
        public static int Ukarachivatel(double j)
        {
            int k = (int)j;
            return k;
        }

        public static void Add(double key, int value)
        {

        }

        static void Main2(string[] args)
        {
            LinkedList<double>[] link = new LinkedList<double>[100];
            int[] key = new int[link.Length];
        }
    }
}
