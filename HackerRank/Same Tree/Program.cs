using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Same_Tree
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
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {

            if (p == null && q == null)
            {
                return true;
            }
            else if (p == null || q == null)
            {
                return false;
            }
            else if (p.val != q.val)
            {
                return false;
            }

            bool ok = IsSameTree(p.right, q.right)
                && IsSameTree(p.left, q.left);

            return ok;
        }

        static void Main(string[] args)
        {
            TreeNode one = new TreeNode(2);
            one.left = new TreeNode(1);
            one.right = new TreeNode(3);

            TreeNode two = new TreeNode(2);
            two.left = new TreeNode(1);
            two.right = new TreeNode(3);

            bool ok = IsSameTree(one, two);
        }
    }
}
