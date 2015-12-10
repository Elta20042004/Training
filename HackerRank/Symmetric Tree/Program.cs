using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symmetric_Tree
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
        public bool IsSymmetric(TreeNode root)
        {
            bool ok;
            if (root == null)
            {
                return true;
            }

            ok = Rec(root.left, root.right);

            return ok;
        }

        public static bool Rec(TreeNode one, TreeNode two)
        {
            if (one == null && two == null)
            {
                return true;
            }
            else if (one == null || two == null)
            {
                return false;
            }
            else if (one.val != two.val)
            {
                return false;
            }

            bool ok = Rec(one.left, two.right)
                && Rec(one.right, two.left);

            return ok;
        }

        private static void Main(string[] args)
        {


        }
    }
}
