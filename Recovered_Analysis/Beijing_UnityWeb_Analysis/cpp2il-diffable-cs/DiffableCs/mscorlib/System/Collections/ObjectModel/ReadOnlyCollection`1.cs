namespace System.Collections.ObjectModel;

public class ReadOnlyCollection`1 : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	private IList<T> list; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 117
	}

	public T Item
	{
		 get { } //Length: 89
	}

	private bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		 get { } //Length: 31
	}

	private T System.Collections.Generic.IList<T>.Item
	{
		 get { } //Length: 38
		 set { } //Length: 35
	}

	private bool System.Collections.IList.IsReadOnly
	{
		 get { } //Length: 54
	}

	private object System.Collections.IList.Item
	{
		 get { } //Length: 11
		 set { } //Length: 929
	}

	public ReadOnlyCollection`1(IList<T> list) { }

	public bool Contains(T value) { }

	public void CopyTo(T[] array, int index) { }

	public int get_Count() { }

	public T get_Item(int index) { }

	public IEnumerator<T> GetEnumerator() { }

	public int IndexOf(T value) { }

	private static bool IsCompatibleObject(object value) { }

	private void System.Collections.Generic.ICollection<T>.Add(T value) { }

	private void System.Collections.Generic.ICollection<T>.Clear() { }

	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private bool System.Collections.Generic.ICollection<T>.Remove(T value) { }

	private T System.Collections.Generic.IList<T>.get_Item(int index) { }

	private void System.Collections.Generic.IList<T>.Insert(int index, T value) { }

	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }

	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private int System.Collections.IList.Add(object value) { }

	private void System.Collections.IList.Clear() { }

	private bool System.Collections.IList.Contains(object value) { }

	private bool System.Collections.IList.get_IsReadOnly() { }

	private object System.Collections.IList.get_Item(int index) { }

	private int System.Collections.IList.IndexOf(object value) { }

	private void System.Collections.IList.Insert(int index, object value) { }

	private void System.Collections.IList.Remove(object value) { }

	private void System.Collections.IList.RemoveAt(int index) { }

	private void System.Collections.IList.set_Item(int index, object value) { }

}

