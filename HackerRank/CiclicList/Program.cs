using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclicList
{
    public class CiklicList
    {
        public int[] k;
        public int i;
        public int j;
        public int counter;

        public CiklicList()
        {
            k = new int[4];
        }

        public void Remove()
        {
            j++;
            counter--;
            if (j >= k.Length)
            {
                j = 0;
            }
        }

        public void Add(int m)
        {

            if (counter < k.Length)
            {
                k[i] = m;
                i++;
                counter++;
            }
            else
            {
                if ((j > 0) && (i < j))
                {
                    k[i] = m;
                    i++;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Perepolnenie steka");
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CiklicList test = new CiklicList();


            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Remove();
            test.Add(5);

        }
    }
}
