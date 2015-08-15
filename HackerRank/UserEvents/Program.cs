using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace UserEvents
{
    internal class Program
    {
        private static List<User> users;
        private static List<Item> items;
        private static List<Event> events;

        private enum Gender
        {
            Male,
            Female
        }

        private enum EventKind
        {
            Click,
            Buy,
            View
        }

        private class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string FamilyName { get; set; }
            public int Age { get; set; }
            public Gender Gender { get; set; }
            public string Job { get; set; }
        }

        private class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
        }

        private class Event
        {
            public int UserId { get; set; }
            public int ItemId { get; set; }
            public EventKind EventKind { get; set; }
        }


        private static IEnumerable<int> AllMaleYanger22()
        {
            var k = users
                .Where(t => t.Gender == Gender.Male && t.Age < 22)
                .Select(s => s.Id);
            return k;
        }

        private static IEnumerable<int> AllProgrammersFemale()
        {
            var temp = users
                .Where(t => t.Gender == Gender.Female && t.Job == "Programmer")
                .Select(s => s.Id);
            return temp;
        }

        private static void ReadUsers()
        {
            int t = int.Parse(Console.ReadLine());
            users = new List<User>();
            for (int i = 0; i < t; i++)
            {
                string[] p = Console.ReadLine().Split(' ');
                User u = new User()
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    FamilyName = p[2],
                    Age = int.Parse(p[3]),
                    Gender = (Gender)Enum.Parse(typeof(Gender), p[4]),
                    Job = p[5]
                };
                users.Add(u);
            }
        }

        private static void ReadEvents()
        {
            int t = int.Parse(Console.ReadLine());
            events = new List<Event>();
            for (int i = 0; i < t; i++)
            {
                string[] p = Console.ReadLine().Split(' ');
                Event u = new Event()
                {
                    UserId = int.Parse(p[0]),
                    ItemId = int.Parse(p[1]),
                    EventKind = (EventKind)Enum.Parse(typeof(EventKind), p[2])
                };
                events.Add(u);
            }

        }

        private static Dictionary<int, List<EventKind>> GetUsersEventsKind()
        {
            var k = events
                .GroupBy(s => s.UserId)
                .ToDictionary(t => t.Key, t => t.Select(s => s.EventKind).ToList());
            return k;
        }



        private static void ReadItems()
        {
            int t = int.Parse(Console.ReadLine());
            items = new List<Item>();
            for (int i = 0; i < t; i++)
            {
                string[] p = Console.ReadLine().Split(' ');
                Item u = new Item()
                {
                    Id = int.Parse(p[0]),
                    Price = int.Parse(p[1]),
                    Name = p[2]
                };
                items.Add(u);
            }
            AllMaleYanger22();
            AllProgrammersFemale();
        }


        private static void PrintUserAgeDidBuy()
        {
            var k = events
                .Where(t => t.EventKind == EventKind.Buy)
                .Select(s => s.UserId)
                .Distinct() //shtob ne bylo povtorenij
                .Join(users, t => t, f => f.Id, (s, m) => m.Age);
            foreach (var i in k)
            {
                Console.WriteLine(i);
            }
        }

        private static void PrintItemsDidBuy()
        {
            var k = events
                .Where(t => t.EventKind == EventKind.Buy)
                .Select(s => s.ItemId)
                .Distinct()
                .Join(items, t => t, f => f.Id, (s, m) => m.Name);
            foreach (var i in k)
            {
                Console.WriteLine(i);
            }
        }

        //вывести на экран все предметы которые смотрели "View" программисты

        private static void PrintEventsDidViewProgrammer()
        {
            var k = users
                .Where(t => t.Job == "Carpenter")
                .Select(s => s.Id)
                .Distinct()
                .Join(events, t => t, f => f.UserId, (s, m) => m)
                .Where(m => m.EventKind == EventKind.View)
                .Join(items, t => t.ItemId, f => f.Id, (s, m) => m.Name);
            foreach (var i in k)
            {
                Console.WriteLine(i);
            }
        }

        // vyvesti imena i familii lyudej, kotorye kupili mashinu
        private static void PrintNamasFamilyDidBuyCar()
        {
            var k = items
                .Where(t => t.Name == "Car")
                .Select(s => s.Id)
                .Join(events, t => t, s => s.ItemId, (s, m) => m)
                .Where(m => m.EventKind == EventKind.Buy)
                .Select(p => p.UserId)
                .Join(users, t => t, s => s.Id, (s, m) => m)
                .Select(t => t.Name + " " + t.FamilyName);

            foreach (var i in k)
            {
                Console.Write(i);
            }
        }

        private static void PrintPriceIphoneOrBycircle(Func<Item, bool> item1, Func<Item, bool> item2)
        {
            var k = events
                .Where(t => t.EventKind == EventKind.Buy)
                .Select(s => s.ItemId)
                .Join(items, t => t, s => s.Id, (s, m) => m)
                .Where(item1)
                .Sum(s => s.Price);

            var k2 = events
                .Where(t => t.EventKind == EventKind.Buy)
                .Select(s => s.ItemId)
                .Join(items, t => t, s => s.Id, (s, m) => m)
                .Where(item2)
                .Sum(s => s.Price);

            if (k > k2)
            {
                Console.WriteLine("{0}>{1}", k, k2);
            }
            else
            {
                Console.WriteLine("{0}<{1}", k, k2);
            }
        }

        static bool Anonim(Item item)
        {

            return item.Name == "Stool";
        }

        static void Main(string[] args)
        {
            ReadUsers();
            ReadItems();
            ReadEvents();
            //GetUsersEventsKind();
            //PrintUserAgeDidBuy();
            //PrintItemsDidBuy();
            //PrintEventsDidViewProgrammer();
            //PrintNamasFamilyDidBuyCar();
            //PrintPriceIphoneOrBycircle(item =>  item.Name=="Iphone" , item => item.Name=="Bycircle");
            PrintPriceIphoneOrBycircle(item => item.Name == "Stool", item => item.Price > 100);
            PrintPriceIphoneOrBycircle(Anonim, item => item.Price > 100);
        }
    }
}
