namespace Mono.Security.X509;

internal sealed class X509ExtensionCollection : CollectionBase, IEnumerable
{
	private bool readOnly; //Field offset: 0xC

	public X509ExtensionCollection() { }

	public X509ExtensionCollection(ASN1 asn1) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

