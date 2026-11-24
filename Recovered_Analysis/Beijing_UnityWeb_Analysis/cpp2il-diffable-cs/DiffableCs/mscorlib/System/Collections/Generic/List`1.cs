namespace System.Collections.Generic;

public class List`1 : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private List<T> list; //Field offset: 0x0
		private int index; //Field offset: 0x0
		private int version; //Field offset: 0x0
		private T current; //Field offset: 0x0

		public T Current
		{
			 get { } //Length: 55
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 12
		}

		internal Enumerator(List<T> list) { }

		public void Dispose() { }

		public T get_Current() { }

		public bool MoveNext() { }

		private bool MoveNextRare() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

	}

	private const int _defaultCapacity = 4; //Field offset: 0x0
	private static readonly T[] _emptyArray; //Field offset: 0x0
	private T[] _items; //Field offset: 0x0
	private int _size; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 12
		 set { } //Length: 890
	}

	public int Count
	{
		 get { } //Length: 9
	}

	public T Item
	{
		 get { } //Length: 25
		 set { } //Length: 982
	}

	private bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		 get { } //Length: 9
	}

	private bool System.Collections.IList.IsReadOnly
	{
		 get { } //Length: 3
	}

	private object System.Collections.IList.Item
	{
		 get { } //Length: 139
		 set { } //Length: 121
	}

	private static List`1() { }

	public List`1(IEnumerable<T> collection) { }

	public List`1() { }

	public List`1(int capacity) { }

	public void Add(T item) { }

	public void AddRange(IEnumerable<T> collection) { }

	public ReadOnlyCollection<T> AsReadOnly() { }

	public int BinarySearch(T item) { }

	public int BinarySearch(int index, int count, T item, IComparer<T> comparer) { }

	public void Clear() { }

	public bool Contains(T item) { }

	public List<TOutput> ConvertAll(Converter<T, TOutput> converter) { }

	public void CopyTo(T[] array, int arrayIndex) { }

	public void CopyTo(int index, T[] array, int arrayIndex, int count) { }

	public void CopyTo(T[] array) { }

	private void EnsureCapacity(int min) { }

	public bool Exists(Predicate<T> match) { }

	public T Find(Predicate<T> match) { }

	public List<T> FindAll(Predicate<T> match) { }

	public int FindIndex(int startIndex, int count, Predicate<T> match) { }

	public int FindIndex(Predicate<T> match) { }

	public void ForEach(Action<T> action) { }

	public int get_Capacity() { }

	public int get_Count() { }

	public T get_Item(int index) { }

	public Enumerator<T> GetEnumerator() { }

	public List<T> GetRange(int index, int count) { }

	public int IndexOf(T item) { }

	public void Insert(int index, T item) { }

	public void InsertRange(int index, IEnumerable<T> collection) { }

	private static bool IsCompatibleObject(object value) { }

	public int LastIndexOf(T item, int index, int count) { }

	public int LastIndexOf(T item) { }

	public bool Remove(T item) { }

	public int RemoveAll(Predicate<T> match) { }

	public void RemoveAt(int index) { }

	public void RemoveRange(int index, int count) { }

	public void Reverse(int index, int count) { }

	public void Reverse() { }

	public void set_Capacity(int value) { }

	public void set_Item(int index, T value) { }

	public void Sort(IComparer<T> comparer) { }

	public void Sort() { }

	public void Sort(Comparison<T> comparison) { }

	public void Sort(int index, int count, IComparer<T> comparer) { }

	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private int System.Collections.IList.Add(object item) { }

	private bool System.Collections.IList.Contains(object item) { }

	private bool System.Collections.IList.get_IsReadOnly() { }

	private object System.Collections.IList.get_Item(int index) { }

	private int System.Collections.IList.IndexOf(object item) { }

	private void System.Collections.IList.Insert(int index, object item) { }

	private void System.Collections.IList.Remove(object item) { }

	private void System.Collections.IList.set_Item(int index, object value) { }

	public T[] ToArray() { }

}

