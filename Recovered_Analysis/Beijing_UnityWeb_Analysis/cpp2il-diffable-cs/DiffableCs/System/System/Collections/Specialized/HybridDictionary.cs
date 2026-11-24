namespace System.Collections.Specialized;

public class HybridDictionary : IDictionary, ICollection, IEnumerable
{
	private ListDictionary list; //Field offset: 0x8
	private Hashtable hashtable; //Field offset: 0xC
	private bool caseInsensitive; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 136
	}

	public object Item
	{
		 get { } //Length: 100
		 set { } //Length: 100
	}

	public ICollection Keys
	{
		 get { } //Length: 41
	}

	private ListDictionary List
	{
		 get { } //Length: 3
	}

	public HybridDictionary() { }

	public void Add(object key, object value) { }

	private void ChangeOver() { }

	public bool Contains(object key) { }

	public void CopyTo(Array array, int index) { }

	public int get_Count() { }

	public object get_Item(object key) { }

	public ICollection get_Keys() { }

	private ListDictionary get_List() { }

	public IDictionaryEnumerator GetEnumerator() { }

	public void Remove(object key) { }

	public void set_Item(object key, object value) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

