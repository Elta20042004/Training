using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Nodes_in_Pairs
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Program
    {
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            else if (head.next == null)
            {
                return head;
            }

            var prev = head;
            var next = head.next;
            var counter = head.next.next;

            next.next = prev;
            prev.next = counter;
            head = next;
            var temp = prev;
            while (counter != null)
            {
                if (temp.next.next == null)
                {
                    return head;
                }
                else
                {
                    prev = counter;
                    next = counter.next;
                    counter = counter.next.next;

                    next.next = prev;
                    prev.next = counter;
                    temp.next = next;
                }
                temp = prev;
            }


            return head;
        }

        static void Main(string[] args)
        {
            ListNode lN = new ListNode(1);
            lN.next = new ListNode(2);
            lN.next.next = new ListNode(3);
            lN.next.next.next = new ListNode(4);
            lN.next.next.next.next = new ListNode(5);
            SwapPairs(lN);
        }
    }
}
