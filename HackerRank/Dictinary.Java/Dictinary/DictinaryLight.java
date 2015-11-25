package Dictinary;

import java.util.*;

public class DictinaryLight<TKey, TValue>
{
	private Map.Entry<TKey, TValue> == null ? null : Map.Entry<TKey, TValue>[] dic;
	public DictinaryLight()
	{
		dic = new Map.Entry<TKey, TValue> == null ? null : new Map.Entry<TKey, TValue>[5];
	}
	private int GetIndex(TKey key) // Index
	{
		int hashCode = key.hashCode();
		int index = (hashCode % 25) * 2;
		return index;
	}
	public final void Add(TKey key, TValue value)
	{
		Map.Entry<TKey, TValue> myNode = new Map.Entry<TKey, TValue>(key, value);
		int index = GetIndex(key);
		int indexLast = index;
		index = myIndex(index, key, dic.getLength()); //while
		if (index == dic.getLength())
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

	public final int myIndex(int index, TKey key, int granica)
	{
		while (dic[index] != null && !dic[index].Value.Key.equals(key) && index < granica)
		{
			index++;

			if (index == granica)
			{
				break;
			}
		}
		return index;
	}
	public final TValue Get(TKey key)
	{
		int index = GetIndex(key);
		int indexLast = index;
		while (index < dic.getLength() && !dic[index].Value.Key.equals(key))
		{
			index++;
		}
		if (index == dic.getLength())
		{
			index = 0;
			while (!dic[index].Value.Key.equals(key) && index < indexLast)
			{
				index++;
			}
		}
		return dic[index].Value.Value;
	}
	public final void Remove(TKey key)
	{
		int index = GetIndex(key);
		int indexLast = index;
		while (index < dic.getLength() && !dic[index].Value.Key.equals(key))
		{
			index++;
		}
		if (index == dic.getLength())
		{
			index = 0;
			while (!dic[index].Value.Key.equals(key) && index < indexLast)
			{
				index++;
			}
		}
		dic[index] = null;
	}
}