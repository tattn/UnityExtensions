using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniExt
{
    public static class DictionaryExtension {
		public static IDictionary Merge(this IDictionary destination, IDictionary source)
		{
			var sourceEnumerator = source.GetEnumerator();

			while (sourceEnumerator.MoveNext())
			{
				if (!destination.Contains(sourceEnumerator.Key))
				{
					destination.Add(sourceEnumerator.Key, sourceEnumerator.Value);
				}
			}

			return destination;
		}

		public static IDictionary Merge(this IDictionary destination, params IDictionary[] sources)
		{
			foreach (var source in sources)
			{
				destination.Merge(source);
			}

			return destination;
		}

		public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
		{
			dictionary.TryGetValue(key, out var value);
			return value;
		}
    }
}
