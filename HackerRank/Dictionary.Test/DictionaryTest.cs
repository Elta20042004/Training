using System;
using System.Text;
using System.Collections.Generic;
using Dictinary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dictionary.Test
{
    /// <summary>
    /// Summary description for DictionaryTest
    /// </summary>
    [TestClass]
    public class DictionaryTest
    {
        
            [TestMethod]
            public void CtorSuccess()
            {
                MyDictionary<int, int> di = new MyDictionary<int, int>();
            }

            [TestMethod]
            public void AddElementSuccess()
            {
                MyDictionary<int, int> di = new MyDictionary<int, int>();
                di.Add(2, 5);
            }

            [TestMethod]
            public void AddGetEquals()
            {
                int expected = 5;
                MyDictionary<int, int> di = new MyDictionary<int, int>();
                di.Add(2, expected);
                int actual = di.Get(2);
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void TestMethod3()
            {
              
            }

            [TestMethod]
            public void TestMethod4()
            {
                MyDictionary<int, int> di = new MyDictionary<int, int>();
                di.Add(3, 5);
                di.Add(33, 10);
                di.Add(3, 6);
                di.Add(4, 6);
                di.Add(5, 7);
                di.Add(4, 8);

                var p = di.Get(33);
                var k = di.Get(5);

                di.Remove(3);
            }
        
    }
}
