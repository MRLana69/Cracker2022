namespace UnityEngine.UI.Collections;

internal class IndexedSet`1 : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	private readonly List<T> m_List; //Field offset: 0x0
	private Dictionary<T, int> m_Dictionary; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 236
	}

	public bool IsReadOnly
	{
		 get { } //Length: 36
	}

	public T Item
	{
		 get { } //Length: 54
		 set { } //Length: 88
	}

	public IndexedSet`1() { }

	public void Add(T item) { }

	public bool AddUnique(T item) { }

	public void Clear() { }

	public bool Contains(T item) { }

	public void CopyTo(T[] array, int arrayIndex) { }

	public int get_Count() { }

	public bool get_IsReadOnly() { }

	public T get_Item(int index) { }

	public IEnumerator<T> GetEnumerator() { }

	public int IndexOf(T item) { }

	public void Insert(int index, T item) { }

	public bool Remove(T item) { }

	public void RemoveAll(Predicate<T> match) { }

	public void RemoveAt(int index) { }

	public void set_Item(int index, T value) { }

	public void Sort(Comparison<T> sortLayoutFunction) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

