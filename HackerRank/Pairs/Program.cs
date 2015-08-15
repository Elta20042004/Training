using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs
{
    class Program
    {
        public static void problem(int[] numbers, int raznica)
        {
            HashSet<int> lilu = new HashSet<int>(numbers);
            int counter = lilu
                .Count(p => lilu.Contains(p + raznica));
            Console.WriteLine(counter);
        }

        static void Main(string[] args)
        {
            string[] t = Console.ReadLine().Split(' ');
            int leng = int.Parse(t[0]);
            int raznica = int.Parse(t[1]);
            string[] myMass = new string[leng];
            myMass = Console.ReadLine().Split(' ');
            int[] numbers = myMass.Select(ch => int.Parse(ch.ToString())).ToArray();
            //Array.Sort(numbers);
            problem(numbers, raznica);
        }
    }
}
