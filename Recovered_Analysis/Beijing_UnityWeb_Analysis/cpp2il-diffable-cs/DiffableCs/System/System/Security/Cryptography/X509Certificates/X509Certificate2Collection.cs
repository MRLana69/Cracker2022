namespace System.Security.Cryptography.X509Certificates;

public class X509Certificate2Collection : X509CertificateCollection
{
	private static string[] newline_split; //Field offset: 0x0

	public X509Certificate2 Item
	{
		 get { } //Length: 751
	}

	private static X509Certificate2Collection() { }

	public X509Certificate2Collection() { }

	public X509Certificate2Collection(X509Certificate2Collection certificates) { }

	public int Add(X509Certificate2 certificate) { }

	public void AddRange(X509Certificate2Collection certificates) { }

	public bool Contains(X509Certificate2 certificate) { }

	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	public X509Certificate2 get_Item(int index) { }

	public X509Certificate2Enumerator GetEnumerator() { }

	public void Import(byte[] rawData) { }

}

