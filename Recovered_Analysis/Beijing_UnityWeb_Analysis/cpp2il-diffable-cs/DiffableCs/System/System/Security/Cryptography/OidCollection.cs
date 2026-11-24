namespace System.Security.Cryptography;

public sealed class OidCollection : ICollection, IEnumerable
{
	private ArrayList m_list; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 49
	}

	public bool IsSynchronized
	{
		 get { } //Length: 68
	}

	public Oid Item
	{
		 get { } //Length: 14
	}

	public Oid Item
	{
		 get { } //Length: 84
	}

	public object SyncRoot
	{
		 get { } //Length: 3
	}

	public OidCollection() { }

	public int Add(Oid oid) { }

	public void CopyTo(Oid[] array, int index) { }

	public int get_Count() { }

	public bool get_IsSynchronized() { }

	public Oid get_Item(int index) { }

	public Oid get_Item(string oid) { }

	public object get_SyncRoot() { }

	public OidEnumerator GetEnumerator() { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

