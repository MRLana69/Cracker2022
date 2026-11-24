namespace System.Collections.Generic;

public static class CollectionExtensions
{

	public static TValue GetValueOrDefault(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key) { }

	public static TValue GetValueOrDefault(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue) { }

}

