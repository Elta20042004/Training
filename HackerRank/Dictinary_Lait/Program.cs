using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictinary_Lait
{
    class DictinaryLait<TKey, TValue>
    {
        private KeyValuePair<TKey, TValue>?[] dic;

        public DictinaryLait()
        {
            dic = new KeyValuePair<TKey, TValue>?[5];
        }
        public int GetIndex(TKey key)           // Index
        {
            int hashCode = key.GetHashCode();
            int index = (hashCode % 25) * 2;
            return index;
        }
        public void Add(TKey key, TValue value)
        {
            var myNode = new KeyValuePair<TKey, TValue>(key, value);
            int index = GetIndex(key);
            int indexLast = index;

            index = myIndex(index, key, dic.Length); //while

            if (index == dic.Length)
            {
                index = 0;
                index = myIndex(index, key, indexLast); //while
                if (index == indexLast)
                {
                    //novyj dictinary
                }
            }

            dic[index] = myNode;
        }

        public int myIndex(int index, TKey key, int granica)
        {
            while (dic[index] != null
                && !dic[index].Value.Key.Equals(key)
                && index < granica)
            {
                index++;

                if (index == granica)
                {
                    break;
                }
            }
            return index;
        }

        public TValue Get(TKey key)
        {
            int index = GetIndex(key);
            int indexLast = index;
            while (index<dic.Length
                &&!dic[index].Value.Key.Equals(key))
              
            {
                index++;
            }
            if (index == dic.Length)
            {
                index = 0;
                while (!dic[index].Value.Key.Equals (key)
                    && index<indexLast)
                {
                    index++;
                }
            }
            return dic[index].Value.Value;
        }

        public void Remove(TKey key)
        {
            int index = GetIndex(key);
            int indexLast = index;
            while (index < dic.Length
                && !dic[index].Value.Key.Equals(key))
            {
                index++;
            }
            if (index == dic.Length)
            {
                index = 0;
                while (!dic[index].Value.Key.Equals(key)
                    && index < indexLast)
                {
                    index++;
                }
            }

            dic[index] = null;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DictinaryLait<int, int> di = new DictinaryLait<int, int>();
            di.Add(2, 5);
            di.Add(27, 7);
            di.Add(2, 6);
            di.Add(27, 10);
            var k = di.Get(27);

            DictinaryLait<int, int> di2 = new DictinaryLait<int, int>();
            di.Add(1, 5);
            di.Add(1, 7);
           // var k2 = di2.Get(27);

            k = di.Get(27);

            di.Remove(2);
        }
    }
}
