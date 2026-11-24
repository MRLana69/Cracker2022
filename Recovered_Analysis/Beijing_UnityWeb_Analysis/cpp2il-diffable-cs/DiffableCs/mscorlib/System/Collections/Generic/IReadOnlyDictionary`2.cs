namespace System.Collections.Generic;

public interface IReadOnlyDictionary`2 : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{

	public bool TryGetValue(TKey key, out TValue value) { }

}

