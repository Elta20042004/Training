package Dictinary;

import java.util.*;

public class MyDictionary<TKey, TValue>
{
	public LinkedList<Map.Entry<TKey, TValue>>[] dic;

	public MyDictionary()
	{
		dic = new LinkedList<Map.Entry<TKey, TValue>>[10];
	}

	public final int GetIndex(TKey key) // Index
	{
		int hashCode = key.hashCode();
		int index = hashCode % dic.length;
		return index;
	}

	public final void Add(TKey key, TValue value)
	{
		Map.Entry<TKey, TValue> myNode = new Map.Entry<TKey, TValue>(key, value);
		int index = GetIndex(key);

		if (dic[index] == null)
		{
			dic[index] = new LinkedList<Map.Entry<TKey, TValue>>();
		}

//C# TO JAVA CONVERTER TODO TASK: There is no equivalent to implicit typing in Java:
		var node = dic[index].First;

		while (node != null && !node.Value.Key.equals(key)) //!!!!!!!!!!!!!
		{
//C# TO JAVA CONVERTER TODO TASK: There is no equivalent to implicit typing in Java:
			var next = node.Next;
			node = next;
		}
		if (node == null)
		{
			dic[index].addFirst(myNode);
		}
		else
		{
			node.Value = myNode;
		}
	}
	public final TValue Get(TKey key) //po klyuchu poluchit' znachenie
	{
		int index = GetIndex(key);

//C# TO JAVA CONVERTER TODO TASK: There is no equivalent to implicit typing in Java:
		var node = dic[index].First;
		while (!node.Value.Key.equals(key))
		{
//C# TO JAVA CONVERTER TODO TASK: There is no equivalent to implicit typing in Java:
			var next = node.Next;
			node = next;
		}

		return node.Value.Value;
	}

	public final void Remove(TKey key) //udalyaet po klychu
	{
		int index = GetIndex(key);

//C# TO JAVA CONVERTER TODO TASK: There is no equivalent to implicit typing in Java:
		var node = dic[index].First;
		while (!node.Value.Key.equals(key))
		{
//C# TO JAVA CONVERTER TODO TASK: There is no equivalent to implicit typing in Java:
			var next = node.Next;
			node = next;
		}
		dic[index].remove(node);
	}
}