using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Depth_of_Binary_Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    class Program
    {
        public static int Counter = 0;
        public static int Max= 0;

        public static void Rec(TreeNode root)
        {          
            if (root == null)
            {
                if (Max < Counter)
                {
                    Max = Counter;
                }         
                return;
            }
            Counter++;
            Rec(root.left);
            Rec(root.right);
            Counter--;
        }

       

        public static int MaxDepth(TreeNode root)
        {
            Rec(root);                  
                return Max;          
        }

        static void Main(string[] args)
        {
            var t = new TreeNode(1);
            t.right = new TreeNode(2);           
            t.right.right = new TreeNode(3);
            t.right.right.right = new TreeNode(4);
            MaxDepth(t);

        }
    }
}
