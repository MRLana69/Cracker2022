namespace System.Collections.Generic;

public class HashSet`1 : ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private HashSet<T> _set; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private T _current; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 100
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 9
		}

		internal Enumerator(HashSet<T> set) { }

		public void Dispose() { }

		public T get_Current() { }

		public bool MoveNext() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

	}

	internal struct Slot
	{
		internal int hashCode; //Field offset: 0x0
		internal int next; //Field offset: 0x0
		internal T value; //Field offset: 0x0

	}

	private const int Lower31BitMask = 2147483647; //Field offset: 0x0
	private const int StackAllocThreshold = 100; //Field offset: 0x0
	private const int ShrinkThreshold = 3; //Field offset: 0x0
	private const string CapacityName = "Capacity"; //Field offset: 0x0
	private const string ElementsName = "Elements"; //Field offset: 0x0
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	private const string VersionName = "Version"; //Field offset: 0x0
	private int[] _buckets; //Field offset: 0x0
	private Slot<T>[] _slots; //Field offset: 0x0
	private int _count; //Field offset: 0x0
	private int _lastIndex; //Field offset: 0x0
	private int _freeList; //Field offset: 0x0
	private IEqualityComparer<T> _comparer; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private SerializationInfo _siInfo; //Field offset: 0x0

	public IEqualityComparer<T> Comparer
	{
		 get { } //Length: 100
	}

	public int Count
	{
		 get { } //Length: 12
	}

	private bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		 get { } //Length: 6
	}

	public HashSet`1() { }

	public HashSet`1(IEqualityComparer<T> comparer) { }

	public HashSet`1(IEnumerable<T> collection) { }

	public HashSet`1(IEnumerable<T> collection, IEqualityComparer<T> comparer) { }

	protected HashSet`1(SerializationInfo info, StreamingContext context) { }

	public bool Add(T item) { }

	private bool AddIfNotPresent(T value) { }

	private void AddValue(int index, int hashCode, T value) { }

	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2) { }

	public void Clear() { }

	public bool Contains(T item) { }

	private void CopyFrom(HashSet<T> source) { }

	public void CopyTo(T[] array, int arrayIndex) { }

	public void CopyTo(T[] array, int arrayIndex, int count) { }

	public void CopyTo(T[] array) { }

	public IEqualityComparer<T> get_Comparer() { }

	public int get_Count() { }

	public Enumerator<T> GetEnumerator() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void IncreaseCapacity() { }

	private void Initialize(int capacity) { }

	private int InternalGetHashCode(T item) { }

	public virtual void OnDeserialization(object sender) { }

	public bool Remove(T item) { }

	private void SetCapacity(int newSize) { }

	private void System.Collections.Generic.ICollection<T>.Add(T item) { }

	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void TrimExcess() { }

	public void UnionWith(IEnumerable<T> other) { }

}

