namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ExtensionCollection : ICollection, IEnumerable
{
	private static byte[] Empty; //Field offset: 0x0
	private ArrayList _list; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 9
	}

	public X509Extension Item
	{
		 get { } //Length: 161
	}

	private static X509ExtensionCollection() { }

	internal X509ExtensionCollection(X509Certificate cert) { }

	public int get_Count() { }

	public X509Extension get_Item(string oid) { }

	public X509ExtensionEnumerator GetEnumerator() { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

