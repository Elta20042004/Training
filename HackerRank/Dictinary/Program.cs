using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dictinary
{  
    public class Dictinary<TKey, TValue>
    {
        public LinkedList<KeyValuePair<TKey,TValue>>[] dic;

        public Dictinary()
        {
            dic = new LinkedList<KeyValuePair<TKey, TValue>>[10];
        }
        public int GetIndex(TKey key)           // Index
        {
            int hashCode = key.GetHashCode();
            int index = hashCode % dic.Length;
            return index;
        }
        public void Add(TKey key, TValue value)
        {
            var myNode = new KeyValuePair<TKey, TValue>(key, value);
            int index = GetIndex(key);

            if (dic[index] == null)
            {
                dic[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
            }

            var node = dic[index].First;

            while (node != null && !node.Value.Key.Equals(key))   //!!!!!!!!!!!!!
            {
                var next = node.Next;
                node = next;
            }
            if (node == null)
            {
                dic[index].AddFirst(myNode);
            }
            else
            {
                node.Value = myNode;
            }
        }
        public TValue Get(TKey key)       //po klyuchu poluchit' znachenie
        {
            int index = GetIndex(key);

            var node = dic[index].First;
            while (!node.Value.Key.Equals(key))      //!!!!!!!!!!!!!
            {
                var next = node.Next;
                node = next;
            }

            return node.Value.Value;
        }

        public void Remove(TKey key)     //udalyaet po klychu
        {
            int index = GetIndex(key);

            var node = dic[index].First;
            while (!node.Value.Key.Equals(key))         //!!!!!!!!!!!!!
            {
                var next = node.Next;
                node = next;
            }
            dic[index].Remove(node);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictinary<int,int> di = new Dictinary<int,int>();
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

