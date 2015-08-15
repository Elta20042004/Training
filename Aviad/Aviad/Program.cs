using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviad
{
    public abstract class ShapeClass
    {
        public abstract int Area();
    }

    class Square : ShapeClass
    {
        int side;

        public Square(int n)
        {
            side = n;
        }

        public override int Area()
        {
            return side * side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(12);
            Console.WriteLine("Area of the square = {0}", sq.Area());
        }
    }
}
