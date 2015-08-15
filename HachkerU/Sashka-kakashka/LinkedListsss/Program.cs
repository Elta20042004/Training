using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsss
{
    class Program
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


        static void Main(string[] args)
        {
            var temp = new Node() { Data = 1 };
            temp = new Node() { Data = 5, Next = temp };
            temp = new Node() { Data = 10, Next = temp };
            temp = new Node() { Data = 14, Next = temp };
            temp = new Node() { Data = 18, Next = temp };
            PrintNode(temp);

            var temp2 = new Node() { Data = 2 };
            temp2 = new Node() { Data = 7, Next = temp2 };
            temp2 = new Node() { Data = 12, Next = temp2 };
            temp2 = new Node() { Data = 19, Next = temp2 };
            temp2 = new Node() { Data = 23, Next = temp2 };
            PrintNode(temp2);

            


            var reuslt = Combine(temp, temp2);
            PrintNode(reuslt);
        }

        private static Node Combine(Node a, Node b)
        {
            Node firstA = a;
            Node firstB = b;            
            Node result = new Node() { Data = int.MaxValue };
            Node resultHead = result;
            while ((firstA != null) && (firstB != null))
            {
                if (firstB.Data > firstA.Data)
                {
                    result.Next = firstB;
                    firstB = firstB.Next;
                }
                else
                {
                    result.Next = firstA;
                    firstA = firstA.Next;
                }

                result = result.Next;
            }

            return resultHead;
        }
    }
}
