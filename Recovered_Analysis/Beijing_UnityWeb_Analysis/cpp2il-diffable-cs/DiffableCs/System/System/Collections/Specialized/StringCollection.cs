namespace System.Collections.Specialized;

public class StringCollection : IList, ICollection, IEnumerable
{
	private ArrayList data; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 217
	}

	public string Item
	{
		 get { } //Length: 11
		 set { } //Length: 205
	}

	private bool System.Collections.IList.IsReadOnly
	{
		 get { } //Length: 12
	}

	private object System.Collections.IList.Item
	{
		 get { } //Length: 14
		 set { } //Length: 16
	}

	public StringCollection() { }

	public int Add(string value) { }

	public void Clear() { }

	public bool Contains(string value) { }

	public void CopyTo(string[] array, int index) { }

	public int get_Count() { }

	public string get_Item(int index) { }

	public int IndexOf(string value) { }

	public void Insert(int index, string value) { }

	public void Remove(string value) { }

	public void RemoveAt(int index) { }

	public void set_Item(int index, string value) { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private int System.Collections.IList.Add(object value) { }

	private bool System.Collections.IList.Contains(object value) { }

	private bool System.Collections.IList.get_IsReadOnly() { }

	private object System.Collections.IList.get_Item(int index) { }

	private int System.Collections.IList.IndexOf(object value) { }

	private void System.Collections.IList.Insert(int index, object value) { }

	private void System.Collections.IList.Remove(object value) { }

	private void System.Collections.IList.set_Item(int index, object value) { }

}

