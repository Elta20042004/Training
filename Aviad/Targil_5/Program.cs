using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Targil_5
{
    public abstract class Figura
    {
        public abstract void PrintArea();
        public abstract void ReadProperties();
    }

    public class Square : Figura
    {
        private int _length;//dlina bokov

        public override void PrintArea() // ploshad' kvadrata
        {         
            int area = _length*_length;
            Console.WriteLine("I'm square. My area is {0}",area);
        }

        public override void ReadProperties()
        {
            Console.WriteLine("Enter the length of the edge of a square:");
            _length = int.Parse(Console.ReadLine());
        }
    }

    public class Rectangle : Figura //pryamougol'nik
    {
        private int _length;
        private int _width;

        public override void PrintArea() // ploshad' pryamougol'nika
        {
            int area = _length * _width;
            Console.WriteLine("I'm rectangle. My area is {0}", area);
        }

        public override void ReadProperties()
        {
            Console.WriteLine("Enter the length of the edge of the rectangle:");
            _length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the base of the rectangle:");
            _width = int.Parse(Console.ReadLine());
        }
    }

    public class Round : Figura
    {
        private int _radius;

        public override void PrintArea() // ploshad' krug
        {
            double area = (_radius * _radius) * 3.14;
            Console.WriteLine("I'm round. My area is {0}", area);
        }

        public override void ReadProperties()
        {
            Console.WriteLine("Enter the radius of the circle:");
            _radius = int.Parse(Console.ReadLine());        
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> myMass = new List<Figura>();
            Square sq = new Square();           
            myMass[0] = sq;        
            Rectangle rec1 = new Rectangle();
            myMass[1] = rec1;
            Rectangle rec2 = new Rectangle();
            myMass[2] = rec2;
            Round round1 = new Round();
            myMass[3] = round1;
            Round round2 = new Round();
            myMass[4] = round2;

            for (int i = 0; i < myMass.Count; i++)
            {
                myMass[i].ReadProperties();
                myMass[i].PrintArea();
            }
        }
    }
}
