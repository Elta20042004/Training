using System;
using System.Collections;
using System.Collections.Generic;

namespace Trees
{
    public class Tree<TKey, TData> : IEnumerable<TKey>
        where TKey : IComparable<TKey>
    {
        private class Node<TKey, TData> where TKey : IComparable<TKey>
        {
            public Node(TKey key, TData data, Node<TKey,TData> parent)
            {
                Key = key;
                Data = data;
                Parent = parent;
            }

            public TKey Key { get; }

            public TData Data { get; }

            public Node<TKey, TData> Parent { get; }

            public Node<TKey, TData> Right { get; set; }

            public Node<TKey, TData> Left { get; set; }
        }

        private class TreeEnumerator : IEnumerator<TKey>
        {
            private readonly Node<TKey, TData> _head;
            private Node<TKey, TData> _current;

            public TreeEnumerator(Node<TKey, TData> head)
            {
                _head = head;
            }

            public TKey Current => _current.Key;

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (_current ==null)
                {
                    Reset();
                    return true;
                }

                if (_current.Right != null)
                {
                    _current = _current.Right;

                    while (_current.Left != null)
                    {
                        _current = _current.Left;
                    }
                }
                else
                {
                    if (_current.Parent == null)
                    {
                        return false;
                    }

                    while (_current.Key.CompareTo(_current.Parent.Key) >= 0)
                    {
                        _current = _current.Parent;

                        if (_current.Parent == null)
                        {
                            return false;
                        }
                    }

                    _current = _current.Parent;
                }

                return true;
            }

            public void Reset()
            {
                _current = _head;
                while (_current.Left != null)
                {
                    _current = _current.Left;
                }
            }

            public void Dispose()
            {
            }
        }

        private Node<TKey, TData> _head;

        public TData Get(TKey myKey)
        {
            var node = _head;
            while (node.Key.CompareTo(myKey) != 0)
            {
                node = node.Key.CompareTo(myKey) <= 0 
                    ? node.Right 
                    : node.Left;
            }

            var rezult = node.Data;
            return rezult;
        }

        public void Add(TKey myKey, TData myData)
        {
            if (_head == null)
            {
                _head = new Node<TKey, TData>(myKey, myData, null);
                return;
            }
            var node = _head;
            var parent = node;

            while (node != null)
            {
                if (node.Key.CompareTo(myKey) <= 0)
                {
                    parent = node;
                    node = node.Right;
                }
                else
                {
                    parent = node;
                    node = node.Left;
                }
            }

            var newNode = new Node<TKey, TData>(myKey, myData, parent);
            if (parent.Key.CompareTo(myKey) <= 0)
            {
                parent.Right = newNode;
            }
            else
            {
                parent.Left = newNode;
            }
        }

        public void Rec()
        {
            Rec(_head);
        }

        private void Rec(Node<TKey, TData> node)
        {
            while (true)
            {
                if (node == null)
                {
                    return;
                }

                Rec(node.Left);
                Console.Write("{0} ", node.Key.ToString());
                node = node.Right;
            }
        }

        public void Remove(TKey myKey)
        {
            var node = _head;
            var parent = node;

            while (node.Key.CompareTo(myKey) != 0)
            {
                parent = node;
                node = node.Key.CompareTo(myKey) <= 0
                    ? node.Right
                    : node.Left;
            }

            if (parent.Key.CompareTo(node.Key) == 0)
            {
                _head = null;
            }
            else if (node.Left != null && node.Right != null)
            {
                var current = node.Left;
                var next = current;
                var father = current;

                while (current != null)
                {
                    father = next;
                    next = current;
                    current = current.Right;
                }

                if (parent.Key.CompareTo(node.Key) < 0)
                {
                    parent.Right = next;
                    next.Left = node.Left;
                    father.Right = null;
                }
                else
                {
                    parent.Left = next;
                    next.Left = node.Left;
                    father.Left = null;
                }

                if (node.Right != null)
                {
                    next.Right = node.Right;
                }

            }
            else if (node.Right == null && node.Left == null)
            {
                if (parent.Key.CompareTo(node.Key) < 0)
                {
                    parent.Right = null;
                }
                else
                {
                    parent.Left = null;
                }
            }
            else if (node.Right == null || node.Left == null)
            {
                var notnull = node.Right ?? node.Left;

                if (parent.Key.CompareTo(node.Key) < 0)
                {
                    parent.Right = notnull;
                }
                else
                {
                    parent.Left = notnull;
                }
            }
        }

        public IEnumerator<TKey> GetEnumerator()
        {
            return new TreeEnumerator(_head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //private IEnumerator<TKey> GetEnumerator(Node<TKey, TData> node)
        //{
        //    if (node == null)
        //    {
        //        yield break;
        //    }

        //    var enumerator = GetEnumerator(node.Left);
        //    while (enumerator.Current != null)
        //    {
        //        yield return enumerator.Current;
        //        enumerator.MoveNext();
        //    }

        //    yield return node.Key;
        //    enumerator = GetEnumerator(node.Right);
        //    while (enumerator.Current != null)
        //    {
        //        yield return enumerator.Current;
        //        enumerator.MoveNext();
        //    }
        //}
    }
}