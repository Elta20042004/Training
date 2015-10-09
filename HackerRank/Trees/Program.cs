using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tree = new Tree<int, int> {{10, 1}, {14, 1}, {7, 1}, {16, 1}, {12, 1}, {13, 1}, {11, 1}};


           // tree.Rec();

            //tree.Remove(12);
            //tree.Remove(16);
            //tree.Remove(13);
            //tree.Remove(11);
            //tree.Remove(14);
            //tree.Remove(7);
            //tree.Remove(10);
            //Console.WriteLine();
            //tree.Rec();
            //tree.GetAllKeys();
            foreach (var key in tree)
            {
                Console.Write(key + " ");
            }
        }
    }
}
