namespace System.Collections.Concurrent;

public class ConcurrentDictionary`2 : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
	private sealed class <GetEnumerator>d__32 : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private KeyValuePair<TKey, TValue> <>2__current; //Field offset: 0x0
		public ConcurrentDictionary<TKey, TValue> <>4__this; //Field offset: 0x0
		private Node<TKey, TValue>[] <buckets>5__1; //Field offset: 0x0
		private Node<TKey, TValue> <current>5__2; //Field offset: 0x0
		private int <i>5__3; //Field offset: 0x0

		private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
		{
			 get { } //Length: 41
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 54
		}

		public <GetEnumerator>d__32(int <>1__state) { }

		private bool MoveNext() { }

		private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator; //Field offset: 0x0

		public object Current
		{
			 get { } //Length: 77
		}

		public DictionaryEntry Entry
		{
			 get { } //Length: 254
		}

		public object Key
		{
			 get { } //Length: 1030
		}

		public object Value
		{
			 get { } //Length: 77
		}

		internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary) { }

		public object get_Current() { }

		public DictionaryEntry get_Entry() { }

		public object get_Key() { }

		public object get_Value() { }

		public bool MoveNext() { }

		public void Reset() { }

	}

	private sealed class Node
	{
		internal readonly TKey _key; //Field offset: 0x0
		internal TValue _value; //Field offset: 0x0
		internal Node<TKey, TValue> _next; //Field offset: 0x0
		internal readonly int _hashcode; //Field offset: 0x0

		internal Node(TKey key, TValue value, int hashcode, Node<TKey, TValue> next) { }

	}

	private sealed class Tables
	{
		internal readonly Node<TKey, TValue>[] _buckets; //Field offset: 0x0
		internal readonly object[] _locks; //Field offset: 0x0
		internal int[] _countPerLock; //Field offset: 0x0

		internal Tables(Node<TKey, TValue>[] buckets, object[] locks, int[] countPerLock) { }

	}

	private static readonly bool s_isValueWriteAtomic; //Field offset: 0x0
	private Tables<TKey, TValue> _tables; //Field offset: 0x0
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0
	private readonly bool _growLockArray; //Field offset: 0x0
	private int _budget; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 75
	}

	private static int DefaultConcurrencyLevel
	{
		 get { } //Length: 235
	}

	public TValue Item
	{
		 get { } //Length: 106
		 set { } //Length: 9
	}

	public ICollection<TKey> Keys
	{
		 get { } //Length: 350
	}

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		 get { } //Length: 34
	}

	private object System.Collections.IDictionary.Item
	{
		 get { } //Length: 172
		 set { } //Length: 209
	}

	private ICollection System.Collections.IDictionary.Keys
	{
		 get { } //Length: 3
	}

	public ICollection<TValue> Values
	{
		 get { } //Length: 34
	}

	private static ConcurrentDictionary`2() { }

	public ConcurrentDictionary`2() { }

	internal ConcurrentDictionary`2(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }

	private void AcquireAllLocks(ref int locksAcquired) { }

	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }

	public void Clear() { }

	public bool ContainsKey(TKey key) { }

	private void CopyToEntries(DictionaryEntry[] array, int index) { }

	private void CopyToObjects(object[] array, int index) { }

	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }

	public int get_Count() { }

	private static int get_DefaultConcurrencyLevel() { }

	public TValue get_Item(TKey key) { }

	public ICollection<TKey> get_Keys() { }

	public ICollection<TValue> get_Values() { }

	private static int GetBucket(int hashcode, int bucketCount) { }

	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }

	private int GetCountInternal() { }

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }

	private ReadOnlyCollection<TKey> GetKeys() { }

	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }

	private ReadOnlyCollection<TValue> GetValues() { }

	private void GrowTable(Tables<TKey, TValue> tables) { }

	private static bool IsValueWriteAtomic() { }

	private void ReleaseLocks(int fromInclusive, int toExclusive) { }

	public void set_Item(TKey key, TValue value) { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private bool System.Collections.IDictionary.Contains(object key) { }

	private object System.Collections.IDictionary.get_Item(object key) { }

	private ICollection System.Collections.IDictionary.get_Keys() { }

	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private void System.Collections.IDictionary.Remove(object key) { }

	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private static void ThrowKeyNotFoundException() { }

	private static void ThrowKeyNullException() { }

	public bool TryAdd(TKey key, TValue value) { }

	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }

	public bool TryGetValue(TKey key, out TValue value) { }

	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }

	public bool TryRemove(TKey key, out TValue value) { }

	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }

}

