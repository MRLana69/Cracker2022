namespace Mono.Security.X509;

internal class X509Extension
{
	protected string extnOid; //Field offset: 0x8
	protected bool extnCritical; //Field offset: 0xC
	protected ASN1 extnValue; //Field offset: 0x10

	public X509Extension(ASN1 asn1) { }

	protected virtual void Decode() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	private void WriteLine(StringBuilder sb, int n, int pos) { }

}

