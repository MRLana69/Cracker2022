namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ChainElementCollection : ICollection, IEnumerable
{
	private ArrayList _list; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 6
	}

	public X509ChainElement Item
	{
		 get { } //Length: 62
	}

	internal X509ChainElementCollection() { }

	internal void Add(X509Certificate2 certificate) { }

	internal void Clear() { }

	internal bool Contains(X509Certificate2 certificate) { }

	public int get_Count() { }

	public X509ChainElement get_Item(int index) { }

	public X509ChainElementEnumerator GetEnumerator() { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

