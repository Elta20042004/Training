using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_Node_in_a_Linked_List
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }

    class Program
    {
        public static void DeleteNode(ListNode node)
        {          
            node.val = node.next.val;
            if (node.next.next == null)
            {
                node.next = null;
            }
            else
            {
                node.next = node.next.next;
            }
        }


        static void Main(string[] args)
        {
            ListNode lN = new ListNode(1);
            lN.next = new ListNode(2);
            lN.next.next = new ListNode(3);
            lN.next.next.next = new ListNode(4);

            DeleteNode(lN.next.next);
        }
    }
}
