namespace System.Collections.Generic;

public class Dictionary`2 : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback
{
	private struct Entry
	{
		public int hashCode; //Field offset: 0x0
		public int next; //Field offset: 0x0
		public TKey key; //Field offset: 0x0
		public TValue value; //Field offset: 0x0

	}

	public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		private Dictionary<TKey, TValue> dictionary; //Field offset: 0x0
		private int version; //Field offset: 0x0
		private int index; //Field offset: 0x0
		private KeyValuePair<TKey, TValue> current; //Field offset: 0x0
		private int getEnumeratorRetType; //Field offset: 0x0

		public KeyValuePair<TKey, TValue> Current
		{
			 get { } //Length: 43
		}

		private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			 get { } //Length: 36
		}

		private object System.Collections.IDictionaryEnumerator.Key
		{
			 get { } //Length: 12
		}

		private object System.Collections.IDictionaryEnumerator.Value
		{
			 get { } //Length: 12
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 12
		}

		internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }

		public void Dispose() { }

		public KeyValuePair<TKey, TValue> get_Current() { }

		public bool MoveNext() { }

		private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		private object System.Collections.IDictionaryEnumerator.get_Key() { }

		private object System.Collections.IDictionaryEnumerator.get_Value() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

	}

	public sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		public struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			private Dictionary<TKey, TValue> dictionary; //Field offset: 0x0
			private int index; //Field offset: 0x0
			private int version; //Field offset: 0x0
			private TKey currentKey; //Field offset: 0x0

			public TKey Current
			{
				 get { } //Length: 84
			}

			private object System.Collections.IEnumerator.Current
			{
				 get { } //Length: 12
			}

			internal Enumerator(Dictionary<TKey, TValue> dictionary) { }

			public void Dispose() { }

			public TKey get_Current() { }

			public bool MoveNext() { }

			private object System.Collections.IEnumerator.get_Current() { }

			private void System.Collections.IEnumerator.Reset() { }

		}

		private Dictionary<TKey, TValue> dictionary; //Field offset: 0x0

		public int Count
		{
			 get { } //Length: 12
		}

		private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
		{
			 get { } //Length: 36
		}

		public KeyCollection(Dictionary<TKey, TValue> dictionary) { }

		public void CopyTo(TKey[] array, int index) { }

		public int get_Count() { }

		public Enumerator<TKey, TValue> GetEnumerator() { }

		private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		private void System.Collections.Generic.ICollection<TKey>.Clear() { }

		private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

		private void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		public struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			private Dictionary<TKey, TValue> dictionary; //Field offset: 0x0
			private int index; //Field offset: 0x0
			private int version; //Field offset: 0x0
			private TValue currentValue; //Field offset: 0x0

			public TValue Current
			{
				 get { } //Length: 87
			}

			private object System.Collections.IEnumerator.Current
			{
				 get { } //Length: 9
			}

			internal Enumerator(Dictionary<TKey, TValue> dictionary) { }

			public void Dispose() { }

			public TValue get_Current() { }

			public bool MoveNext() { }

			private object System.Collections.IEnumerator.get_Current() { }

			private void System.Collections.IEnumerator.Reset() { }

		}

		private Dictionary<TKey, TValue> dictionary; //Field offset: 0x0

		public int Count
		{
			 get { } //Length: 12
		}

		private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
		{
			 get { } //Length: 36
		}

		public ValueCollection(Dictionary<TKey, TValue> dictionary) { }

		public void CopyTo(TValue[] array, int index) { }

		public int get_Count() { }

		public Enumerator<TKey, TValue> GetEnumerator() { }

		private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		private void System.Collections.Generic.ICollection<TValue>.Clear() { }

		private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		private void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private const string VersionName = "Version"; //Field offset: 0x0
	private const string HashSizeName = "HashSize"; //Field offset: 0x0
	private const string KeyValuePairsName = "KeyValuePairs"; //Field offset: 0x0
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	private int[] buckets; //Field offset: 0x0
	private Entry<TKey, TValue>[] entries; //Field offset: 0x0
	private int count; //Field offset: 0x0
	private int version; //Field offset: 0x0
	private int freeList; //Field offset: 0x0
	private int freeCount; //Field offset: 0x0
	private IEqualityComparer<TKey> comparer; //Field offset: 0x0
	private KeyCollection<TKey, TValue> keys; //Field offset: 0x0
	private ValueCollection<TKey, TValue> values; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 166
	}

	public TValue Item
	{
		 get { } //Length: 38
		 set { } //Length: 40
	}

	public KeyCollection<TKey, TValue> Keys
	{
		 get { } //Length: 12
	}

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		 get { } //Length: 154
	}

	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		 get { } //Length: 84
	}

	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		 get { } //Length: 87
	}

	private object System.Collections.IDictionary.Item
	{
		 get { } //Length: 592
		 set { } //Length: 1495
	}

	private ICollection System.Collections.IDictionary.Keys
	{
		 get { } //Length: 154
	}

	public ValueCollection<TKey, TValue> Values
	{
		 get { } //Length: 93
	}

	public Dictionary`2() { }

	public Dictionary`2(int capacity) { }

	public Dictionary`2(IEqualityComparer<TKey> comparer) { }

	public Dictionary`2(int capacity, IEqualityComparer<TKey> comparer) { }

	public Dictionary`2(IDictionary<TKey, TValue> dictionary) { }

	public Dictionary`2(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) { }

	protected Dictionary`2(SerializationInfo info, StreamingContext context) { }

	public void Add(TKey key, TValue value) { }

	public void Clear() { }

	public bool ContainsKey(TKey key) { }

	public bool ContainsValue(TValue value) { }

	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	private int FindEntry(TKey key) { }

	public int get_Count() { }

	public TValue get_Item(TKey key) { }

	public KeyCollection<TKey, TValue> get_Keys() { }

	public ValueCollection<TKey, TValue> get_Values() { }

	public Enumerator<TKey, TValue> GetEnumerator() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void Initialize(int capacity) { }

	private static bool IsCompatibleKey(object key) { }

	public virtual void OnDeserialization(object sender) { }

	public bool Remove(TKey key) { }

	private void Resize(int newSize, bool forceNewHashCodes) { }

	private void Resize() { }

	public void set_Item(TKey key, TValue value) { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private bool System.Collections.IDictionary.Contains(object key) { }

	private object System.Collections.IDictionary.get_Item(object key) { }

	private ICollection System.Collections.IDictionary.get_Keys() { }

	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private void System.Collections.IDictionary.Remove(object key) { }

	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetValue(TKey key, out TValue value) { }

	private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior) { }

}

