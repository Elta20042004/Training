using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_and_Deserialize_Binary_Tree
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
        public static void Rec(TreeNode root)
        {
            if (root == null)
            {
                sklad.Add("n");
                return;
            }
            sklad.Add("t");
            sklad.Add(root.val.ToString());
            Rec(root.left);
            Rec(root.right);

        }

        public static List<string> sklad;

        public static string serialize(TreeNode root)
        {
            if (root == null)
            {
                return "";
            }
            sklad = new List<string>();
            Rec(root);
            StringBuilder builder = new StringBuilder();

            for (int i = 1; i < sklad.Count; i++)
            {
                builder.Append(sklad[i]);
            }
            return builder.ToString();
        }

        // Decodes your encoded data to tree.
        public static TreeNode deserialize(string data)
        {
            if (data.Length == 0)
            {
                return null;
            }
            i = 0;
            global = data;
             AddToTree();
            return tn;
        }

        public static int i;
        public static string global;
        public static TreeNode head;

        public static TreeNode AddToTree()
        {
          
            if (i >= global.Length - 1)
            {
                return null;
            }

            if (global[i] == 'n' || global[i] == 't')
            {
                i++;
                return null;
            }

            string k = "";

            while (global[i]!='t' && global[i] != 'n')
            {
                k = k + global[i];
                i++;
            }

            head = new TreeNode(int.Parse(k));   
            i++;
            head.left = AddToTree();
            head.right = AddToTree();
            return head;
        }



        static void Main(string[] args)
        {
            TreeNode tN = new TreeNode(1);
            tN.right = new TreeNode(3);
            tN.left = new TreeNode(2);
            tN.right.right = new TreeNode(5);
            tN.right.left = new TreeNode(4);

            string k = serialize(tN);
            deserialize(k);
        }
    }
    //[1,2,3,null,null,4,5]
}
