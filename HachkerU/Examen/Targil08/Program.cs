using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil08
{
    class Program
    {
        static void Main(string[] args)
        {
            float quiz_score = float.Parse(Console.ReadLine());

            float mid_score = float.Parse(Console.ReadLine());
            float final_score = float.Parse(Console.ReadLine());
            float avg = (quiz_score+mid_score+final_score)/3;

            if (avg == 90)
            {
                Console.WriteLine("A");
            }

            if ((avg >= 70) && (avg < 90))
            {              
                Console.WriteLine("B");
            }

            if ((avg >= 50) && (avg < 70))
            {              
                Console.WriteLine("C");
            }

            if (avg < 50)
            {              
                Console.WriteLine("F");
            }
        }
    }
}
