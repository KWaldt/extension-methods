using System.Collections.Generic;

namespace KristinaWaldt
{
	public static class DictionaryExtensions
	{
		public static void AddOrReplace<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
			if (dictionary.ContainsKey(key))
			{
				dictionary[key] = value;
			}
			else
			{
				dictionary.Add(key, value);
			}
		}
		
		public static void RemoveIfPossible<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
		{
			if (!dictionary.ContainsKey(key))
				return;
			dictionary.Remove(key);
		}
	}
}
