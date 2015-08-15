using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_the_elements_of_a_linked_list
{
    public class Node
    {
        public Node Next;
        public int Data;
    }


    class Program
    {
        public static void Print(Node k, int end)
        {
            var p = k;
            while (p.Data != end)
            {
                Console.WriteLine(p.Data);
                p = p.Next;
            }
            Console.WriteLine(p.Data);
        }

        public static void Add(Node k, int after, int element)
        {
            var p = k;
            while (p.Data != after)
            {
                p = p.Next;
            }

            var t = p.Next;
            Node novyj = new Node();
            novyj.Data = element;
            p.Next = novyj;
            novyj.Next = t;
        }


        public static void AddHead(Node k, int element)
        {
            Node novyj = new Node();
            novyj.Data = element;
            novyj.Next = k;
        }

        public static void AddPosition(Node k, int position, int element)
        {
            int counter = 0;
            while (counter != position)
            {
                k = k.Next;
                counter++;
            }

            Node novyj = new Node();
            novyj.Data = element;

            var t = k.Next;
            k.Next = novyj;
            novyj.Next = t;
        }

        public static void DeletePosition(Node k, int positiont)
        {
            int counter = 0;
            while (counter != positiont - 1)
            {
                k = k.Next;
                counter++;
            }
            k.Next = k.Next.Next;
        }


        public static void Reverse(Node k)
        {
            var predydushij = k;
            var nastoyashij = k.Next;
            var sleduyushij = k.Next.Next;

            predydushij.Next = null;
            nastoyashij.Next = predydushij;

            while (sleduyushij != null)
            {
                predydushij = nastoyashij;
                nastoyashij = sleduyushij;
                sleduyushij = nastoyashij.Next;
                nastoyashij.Next = predydushij;
            }
        }

        public static Node MergeTwoSortedLinkedLists(Node k, Node p)
        {
            Node novyj=null;
            Node first=null;
            Node oo = null;
            while ((k.Next != null) || (p.Next != null))
            {
                if (novyj == null)
                {
                    if (k.Data < p.Data)
                    {
                        first = k;
                        novyj = first;
                        oo = novyj;
                        k = k.Next;
                    }
                    else
                    {
                        first = p;
                        novyj = first;
                        oo = novyj;
                        p = p.Next;
                    }
                }
                else
                {
                    if (k.Data < p.Data)
                    {
                        first = k;
                        k = k.Next;
                    }
                    else
                    {
                        first = p;
                        p = p.Next;
                    }
                }
                novyj.Next = first;
                novyj = novyj.Next;
                first = first.Next;
            }
            return oo;
        }


        public static void PositionFromEnd(Node k, int position)
        {
            int counter = 0;
            while (k!=null)
            {
                k = k.Next;
                counter++;
            }


        }

        static void Main(string[] args)
        {
            Node k = new Node();
            k.Data = 1;
            Node k1 = new Node();
            k.Next = k1;
            k1.Data = 3;
            Node k2 = new Node();
            k1.Next = k2;
            k2.Data = 5;
            Node k3 = new Node();
            k2.Next = k3;
            k3.Data = 6;

            Node p = new Node();
            p.Data = 2;
            Node p1 = new Node();
            p.Next = p1;
            p1.Data = 4;
            Node p2 = new Node();
            p1.Next = p2;
            p2.Data = 7;
            PositionFromEnd(k, 0);

            //Node novyj = MergeTwoSortedLinkedLists(k, p);  // sliyanie dvuh otsortirovannyh spiskov
            //Print(k, 3);
            //Add(k,1,4);     //     1->4->2->3->null
            //AddHead(k, 5);  //     5->1->4->2->3->null
            //AddPosition(k, 1, 8);  //v poziciyu 1 add node s dannymi 8
            //DeletePosition(k,2);   
            //Reverse(k);

        }
    }
}
