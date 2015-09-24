using System.Collections.Generic;

namespace Dictinary
{
    public class MyDictionary<TKey, TValue>
    {
        public LinkedList<KeyValuePair<TKey, TValue>>[] dic;

        public MyDictionary()
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
            while (!node.Value.Key.Equals(key))     
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
            while (!node.Value.Key.Equals(key))       
            {
                var next = node.Next;
                node = next;
            }
            dic[index].Remove(node);
        }
    }
}