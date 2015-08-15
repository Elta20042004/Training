using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil_4
{
    public abstract class Place
    {
        public string Name { get; set; }
        public double Area { get; set; } //ploshad'
        public string Phone { get; set; }
        public int NumberRoom { get; set; } //nomer

        public Place(string name, double area, string phone, int numberRoom)
        {
            Name =name ;
            Area = area;
            Phone = phone;
            NumberRoom = numberRoom;
        }
    }

    class DiningRoom : Place
    {
        protected int NumberOfPeople;

        public DiningRoom(int numberOfPeople, string name, double area, string phone, int numberRoom)
            : base(name, area, phone, numberRoom)
        {
            NumberOfPeople = numberOfPeople;       
        }
    }

    internal enum BedType
    {
        Senegal, Double, Triple, KingSize 
    }

    internal enum Direction
    {
        North, South, West, East, OrientSea
    }

    class RegularRoom : Place
    {
        public BedType BedType { get; set; }
        public int NumberOfBeds { get; set; }
        public Direction Direction { get; set; } //napravlenie komnaty: sever, yug, vostok, zapad

        public RegularRoom( BedType bedType,Direction direction, int numberOfBeds, string name, double area, string phone, int numberRoom) 
            : base(name, area, phone, numberRoom)
        {
            Direction = direction;
            BedType = bedType;
            NumberOfBeds = numberOfBeds;
        }
        
    }



    class SweetRoom : RegularRoom
    {

        public int Rating { get; set; }


        public SweetRoom(BedType bedType,int rating, Direction direction, int numberOfBeds, string name, double area, string phone, int numberRoom)
            : base(bedType,direction, numberOfBeds, name, area, phone, numberRoom)
        {
            Rating = rating;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Place a = new DiningRoom(454, "kgg", 56.7, "4546", 65);
            a.Phone = "565";

          
        }
    }
}
