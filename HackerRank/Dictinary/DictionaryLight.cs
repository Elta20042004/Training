using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictinary
{
    public class DictinaryLight<TKey, TValue>
    {
        private KeyValuePair<TKey, TValue>?[] dic;
        public DictinaryLight()
        {
            dic = new KeyValuePair<TKey, TValue>?[5];
        }
        private int GetIndex(TKey key)           // Index
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

}
