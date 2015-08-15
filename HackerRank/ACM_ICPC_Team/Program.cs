using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_ICPC_Team
{
    class Program
    {
        //4 5
        //10101
        //11100
        //11010
        //00101

        private static void Main(string[] args)
        {
            string[] k = Console.ReadLine().Split(' ');
            int chelovek = int.Parse(k[0]);
            int temy = int.Parse(k[1]);
            //int chelovek = 4;
            List<string> klass = new List<string>();
            int[] count = new int[chelovek * chelovek];
            int komanda = 0;
            int temp = 0;
            for (int i = 0; i < chelovek; i++)
            {
                string st = Console.ReadLine();
                //string st = "10101";
                klass.Add(st);
            }
            int f;
            int j = 0;
            int s = 0;
            while (j < klass.Count)
            {
                f = 0;
                while (f < klass.Count)
                {
                    if (f != j)
                    {

                        string one = klass[j];
                        string two = klass[f];
                        for (int i = 0; i < one.Length; i++)
                        {
                            int m = one[i] - '0';
                            int n = two[i] - '0';
                            if ((m == 1) && (n == 0))
                            {
                                temp++;
                            }
                            else if ((m == 0) && (n == 1))
                            {
                                temp++;
                            }
                        }

                        count[s] = temp;
                        s++;
                        if (temp > komanda)
                        {
                            komanda = temp;
                        }
                        temp = 0;
                      
                    }
                    f++;
                }
                j++;
            }

            int kom = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    if (count[i] == komanda)
                    {
                        kom++;
                    }
                }
            }

            Console.WriteLine(komanda);
            Console.WriteLine(kom);
        }
    }
}
