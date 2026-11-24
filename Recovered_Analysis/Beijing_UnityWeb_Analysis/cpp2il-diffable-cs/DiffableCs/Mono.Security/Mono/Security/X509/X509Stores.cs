namespace Mono.Security.X509;

public class X509Stores
{
	private string _storePath; //Field offset: 0x8
	private bool _newFormat; //Field offset: 0xC

	internal X509Stores(string path, bool newFormat) { }

	public X509Store Open(string storeName, bool create) { }

}

