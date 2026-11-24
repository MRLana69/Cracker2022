//Type is in global namespace

public class ReadOnlyDictionary`2 : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	private readonly IDictionary<TKey, TValue> _dictionary; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 31
	}

	public bool IsReadOnly
	{
		 get { } //Length: 31
	}

	public TValue Item
	{
		 get { } //Length: 32
	}

	public ICollection<TKey> Keys
	{
		 get { } //Length: 6
	}

	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item
	{
		 get { } //Length: 33
		 set { } //Length: 28
	}

	public ICollection<TValue> Values
	{
		 get { } //Length: 31
	}

	public ReadOnlyDictionary`2(IDictionary<TKey, TValue> dictionary) { }

	public bool Contains(KeyValuePair<TKey, TValue> item) { }

	public bool ContainsKey(TKey key) { }

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

	public int get_Count() { }

	public bool get_IsReadOnly() { }

	public TValue get_Item(TKey key) { }

	public ICollection<TKey> get_Keys() { }

	public ICollection<TValue> get_Values() { }

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }

	private static Exception ReadOnlyException() { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }

	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }

	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	private void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetValue(TKey key, out TValue value) { }

}

