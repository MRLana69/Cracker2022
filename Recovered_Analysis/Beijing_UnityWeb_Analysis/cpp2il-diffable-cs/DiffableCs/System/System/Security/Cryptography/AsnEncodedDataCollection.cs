namespace System.Security.Cryptography;

public sealed class AsnEncodedDataCollection : ICollection, IEnumerable
{
	private ArrayList _list; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 6
	}

	public bool IsSynchronized
	{
		 get { } //Length: 12
	}

	public AsnEncodedData Item
	{
		 get { } //Length: 671
	}

	public object SyncRoot
	{
		 get { } //Length: 12
	}

	public AsnEncodedDataCollection() { }

	public AsnEncodedDataCollection(AsnEncodedData asnEncodedData) { }

	public int Add(AsnEncodedData asnEncodedData) { }

	public void CopyTo(AsnEncodedData[] array, int index) { }

	public int get_Count() { }

	public bool get_IsSynchronized() { }

	public AsnEncodedData get_Item(int index) { }

	public object get_SyncRoot() { }

	public AsnEncodedDataEnumerator GetEnumerator() { }

	public void Remove(AsnEncodedData asnEncodedData) { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

