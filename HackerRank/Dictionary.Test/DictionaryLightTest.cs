using System;
using Dictinary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dictionary.Test
{
    [TestClass]
    public class DictionaryLightTest
    {
        [TestMethod]
        public void CtorSuccess()
        {
            DictinaryLight<int, int> di = new DictinaryLight<int, int>();
        }

        [TestMethod]
        public void AddElementSuccess()
        {
            DictinaryLight<int, int> di = new DictinaryLight<int, int>();
            di.Add(2, 5);
        }

        [TestMethod]
        public void AddGetEquals()
        {
            int expected = 5;
            DictinaryLight<int, int> di = new DictinaryLight<int, int>();
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
            DictinaryLight<int, int> di = new DictinaryLight<int, int>();
            di.Add(2, 5);
            di.Add(27, 7);
            di.Add(2, 6);
            di.Add(27, 10);
            var k = di.Get(27);

            DictinaryLight<int, int> di2 = new DictinaryLight<int, int>();
            di.Add(1, 5);
            di.Add(1, 7);
            // var k2 = di2.Get(27);

            k = di.Get(27);

            di.Remove(2);
        }
    }
}
