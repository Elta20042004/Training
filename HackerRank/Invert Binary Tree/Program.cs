using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace Invert_Binary_Tree
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
        public static void Rec(TreeNode Left, TreeNode Right)
        {
            if (Left == null && Right == null)
            {
                return;
            }

            var temp = Left.val;
            Left.val = Right.val;
            Right.val = temp;

            Rec(Left.left, Right.right);
            Rec(Left.right, Right.left);
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            Rec(root.left, root.right);
            return root;
        }

        static void Main(string[] args)
        {
            TreeNode tN = new TreeNode(4);
            tN.left = new TreeNode(2);
           
            TreeNode n = InvertTree(tN);
        }
    }
}
