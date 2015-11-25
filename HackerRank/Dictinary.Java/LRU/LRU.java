package LRU;

import java.util.*;

public class LRU<T>
{
	private HashMap<Integer, LinkedListNode<Tuple<T, Integer>>> _dictinaryQueckMemory;
	private LinkedList<Tuple<T, Integer>> _myQueckMemory;
	private int counter;
	public LRU(int length)
	{
		counter = length;
		_dictinaryQueckMemory = new HashMap<Integer, LinkedListNode<Tuple<T, Integer>>>();
		_myQueckMemory = new LinkedList<Tuple<T, Integer>>();
	}

	public final T Get(int id)
	{
		if (_dictinaryQueckMemory.containsKey(id))
		{
			_myQueckMemory.addFirst(_dictinaryQueckMemory.get(id).Value);
			_myQueckMemory.remove(_dictinaryQueckMemory.get(id));
			_dictinaryQueckMemory.put(id, _myQueckMemory.First);
			return _dictinaryQueckMemory.get(id).Value.Item1;
		}
		else
		{
			return null;
		}
	}

	public final void Push(int id, T value) //dobavit' dannye po indexu
	{
		if (!_dictinaryQueckMemory.containsKey(id))
		{
			Tuple<T, Integer> newTuple = new Tuple<T, Integer>(value, id);
			_myQueckMemory.addFirst(newTuple);
			LinkedListNode<Tuple<T, Integer>> node = _myQueckMemory.First;
			_dictinaryQueckMemory.put(id, node);
		}
		else
		{
			LinkedListNode<Tuple<T, Integer>> node = _dictinaryQueckMemory.get(id);
			_myQueckMemory.addFirst(node.Value);
			_myQueckMemory.remove(node);
			_dictinaryQueckMemory.put(id, _myQueckMemory.First); //ukazyvaet na pervyj
		}

		if (_dictinaryQueckMemory.size() >= counter) // get from constructor
		{
			int k = _myQueckMemory.getLast().Item2;
			_myQueckMemory.remove(_myQueckMemory.Last);
			_dictinaryQueckMemory.remove(k);
		}
	}
}