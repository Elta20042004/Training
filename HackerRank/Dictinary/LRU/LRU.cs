using System;
using System.Collections.Generic;

namespace LRU
{
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
}