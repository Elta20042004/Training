using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRU
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    public class LRU<T>
    {
        private Dictionary<int, LinkedListNode<Tuple<T, int>>> _dictinaryQueckMemory;
        private LinkedList<Tuple<T, int>> _myQueckMemory;
        private int counter;
        public LRU(int length)
        {
            counter = length;
            _dictinaryQueckMemory = new Dictionary<int, LinkedListNode<Tuple<T, int>>>(counter);
            _myQueckMemory = new LinkedList<Tuple<T, int>>();
        }

        public T Get(int id)
        {

            if (_dictinaryQueckMemory.ContainsKey(id))
            {
                _myQueckMemory.AddFirst(_dictinaryQueckMemory[id].Value);
                _myQueckMemory.Remove(_dictinaryQueckMemory[id]);
                _dictinaryQueckMemory[id] = _myQueckMemory.First;
                return _dictinaryQueckMemory[id].Value.Item1;
            }
            else
            {
                return default(T);
            }
        }

        public void Push(int id, T value)   //dobavit' dannye po indexu
        {


            if (!_dictinaryQueckMemory.ContainsKey(id))
            {
                var newTuple = new Tuple<T, int>(value, id);
                _myQueckMemory.AddFirst(newTuple);
                LinkedListNode<Tuple<T, int>> node = _myQueckMemory.First;
                _dictinaryQueckMemory.Add(id, node);
            }
            else
            {


                LinkedListNode<Tuple<T, int>> node = _dictinaryQueckMemory[id];
                _myQueckMemory.AddFirst(node.Value); 
                _myQueckMemory.Remove(node);
                _dictinaryQueckMemory[id] = _myQueckMemory.First; //ukazyvaet na pervyj
            }

            if (_dictinaryQueckMemory.Count >= counter)  // get from constructor
            {
                int k = _myQueckMemory.Last.Value.Item2;
                _myQueckMemory.Remove(_myQueckMemory.Last);
                _dictinaryQueckMemory.Remove(k);
            }
        }
    }

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
