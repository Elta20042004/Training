using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Linked_List
{
    public class ListNode
    {
     public int val;
     public ListNode next;
     public ListNode(int x) { val = x; }
 }

    class Program
    {


       

        static void Main(string[] args)
        {
            ListNode k = new ListNode(1);
            k.next = new ListNode(2);
            k.next.next = new ListNode(3);

        }
    }
}
