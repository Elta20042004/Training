﻿using System;
using System.Collections.Generic;
using LRU;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dictionary.Test
{
    [TestClass]
    public class LruTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var MyPeople = new List<Person>();  // moya bol'shaya pamyat'
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
