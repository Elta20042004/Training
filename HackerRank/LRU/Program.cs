using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRU
{
    public class Program
    {
        public static List<Person> MyPeople;

        static void Main(string[] args)
        {
            MyPeople = new List<Person>();  // moya bol'shaya pamyat'
            MyPeople.Add(new Person(321, "Alex"));
            MyPeople.Add(new Person(324, "Avi"));
            MyPeople.Add(new Person(345, "Fillip"));
            MyPeople.Add(new Person(348, "Grisha"));

            LRU<Person> lru = new LRU<Person>(3);
            lru.Push(MyPeople[0].Id, new Person(MyPeople[0].Id, MyPeople[0].Name));
            lru.Push(MyPeople[1].Id, new Person(MyPeople[1].Id, MyPeople[1].Name));
            lru.Push(MyPeople[2].Id, new Person(MyPeople[2].Id, MyPeople[2].Name));
            lru.Push(MyPeople[3].Id, new Person(MyPeople[3].Id, MyPeople[3].Name));
            lru.Push(MyPeople[2].Id, new Person(MyPeople[2].Id, MyPeople[2].Name));  // dobavit' Fillipa

            var t = lru.Get(345);
        }
    }
}
