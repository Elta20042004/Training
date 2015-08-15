using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees
{
    class Program
    {
        public class Node
        {
            public int Data;

            public Node Left, Right;
        }

        public static Node Find(Node root, int i)
        {
            while (root.Data != i)
            {
                if (root.Data < i)
                {
                    root = root.Right;
                }
                else if (root.Data > i)
                {
                    root = root.Left;
                }
            }

            return root;
        }



        public static Node Add(Node root, int i)
        {
            Node k=null;
            if (root.Data > i)
            {
                if (root.Left != null)
                {
                    k = Add(root.Left, i);
                }
                else
                {
                    k = new Node();
                    k.Data = i;
                    root.Left = k;
                }
            }
            else if (root.Data < i)
            {
                if (root.Right != null)
                {
                    k = Add(root.Right, i);
                }
                else
                {
                    k = new Node();
                    k.Data = i;
                    root.Right = k;
                }
            }

            return k;
        }

        public static void Print(Node n)
        {
            Print("", true, n);
        }

        private static void Print(string prefix, bool isTail, Node n)
        {
            if (n == null)
                return;

            Console.WriteLine(prefix + (isTail ? "└── " : "├── ") + n.Data);

            if (n.Left != null && n.Right == null)
            {
                Print(prefix + (isTail ? "    " : "│   "), true, n.Left);
            }
            else if (n.Right != null)
            {
                Print(prefix + (isTail ? "    " : "│   "), false, n.Left);
                Print(prefix + (isTail ? "    " : "│   "), true, n.Right);
            }
        }


        static void Main(string[] args)
        {
            Node root = new Node()
            {
                Data = 6,
                Left = new Node()
                {
                    Data = 3,
                    Left = new Node()
                    {
                        Data = 2,
                        Left = new Node()
                        {
                            Data = 1
                        }
                    },
                    Right = new Node()
                    {
                        Data = 4
                    }
                },
                Right = new Node()
                {
                    Data = 8,
                    Left = new Node()
                    {
                        Data = 7
                    },
                    Right = new Node()
                    {
                        Data = 10,
                        Right = new Node()
                        {
                            Data = 15
                        }
                    }
                }
            };
            //Find(root,15);
            Add(root, 5);
            Print(root);
        }
    }
}
