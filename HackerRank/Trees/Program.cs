using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{



    public class Tree
    {
        private class Node
        {
            public int Key { get; set; }
            public int Data { get; set; }
            public Node Right;
            public Node Left;
            public Node Next;

            public Node(int key, int data)
            {
                Key = key;
                Data = data;
            }
        }

        private Node _head;

        public int Get(int myKey)
        {
            Node node = null;
            node = _head;
            while (node.Key != myKey)
            {
                if (node.Key <= myKey)
                {
                    node = node.Right;
                }
                else
                {
                    node = node.Left;
                }
            }

            int rezult = node.Data;
            return rezult;
        }

        public void Add(int myKey, int myData)
        {
            if (_head == null)
            {
                _head = new Node(myKey, myData);
                return;
            }
            Node node = null;
            node = _head;
            Node newNode = new Node(myKey, myData);
            Node parent = null;
            parent = node;

            while (node != null)
            {
                if (node.Key <= myKey)
                {
                    parent = node;
                    node = node.Right;
                }
                else
                {
                    parent = node;
                    node = node.Left;
                }
            }

            if (parent.Key <= myKey)
            {
                parent.Right = newNode;
            }
            else
            {
                parent.Left = newNode;
            }
        }

        public void Rec()
        {
            Rec(_head);
        }

        private void Rec(Node node)
        {
            if (node == null)
            {
                return;
            }
             Rec(node.Left);
Console.Write("{0} ",node.Key.ToString());
            Rec(node.Right);

           
        }

        public void Remove(int myKey)
        {
            Node node = null;
            node = _head;
            Node parent = null;
            parent = node;

            while (node.Key != myKey)
            {
                if (node.Key <= myKey)
                {
                    parent = node;
                    node = node.Right;
                }
                else
                {
                    parent = node;
                    node = node.Left;
                }
            }

            if (node.Left != null && parent.Key < node.Key)
            {
                Node left = null;
                left = node.Left;
                Node last = null;
                last = left;
                Node father = null;
                father = left;

                while (left != null)
                {
                    father = last;
                    last = left;
                    left = left.Right;
                }
                parent.Right = last;
                last.Right = node.Right;
                last.Left = node.Left;
                father.Right = null;
            }
            else if (node.Left == null && parent.Key < node.Key)
            {
                parent.Right = node.Right;
            }


            if (node.Right != null && parent.Key > node.Key)
            {
                Node right = null;
                right = node.Right;
                Node last = null;
                last = right;
                Node father = null;
                father = right;

                while (right != null)
                {
                    father = last;
                    last = right;
                    right = right.Left;
                }
                parent.Left = last;
                last.Right = node.Right;
                last.Left = node.Left;
                father.Left = null;
            }
            else if (node.Right == null && parent.Key > node.Key)
            {
                parent.Left = node.Left;
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.Add(10, 1);
            tree.Add(14, 1);
            tree.Add(7, 1);
            tree.Add(16, 1);
            tree.Add(12, 1);
            tree.Add(13, 1);
            tree.Add(11, 1);

            tree.Rec();

           // tree.Remove(12);
            tree.Remove(16);
            Console.WriteLine();
            tree.Rec();
        }
    }
}
