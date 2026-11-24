namespace Mono.Security.X509;

public class X509Extension
{
	protected string extnOid; //Field offset: 0x8
	protected bool extnCritical; //Field offset: 0xC
	protected ASN1 extnValue; //Field offset: 0x10

	public bool Critical
	{
		 get { } //Length: 6
	}

	public string Oid
	{
		 get { } //Length: 54
	}

	public ASN1 Value
	{
		 get { } //Length: 9
	}

	public X509Extension(ASN1 asn1) { }

	public X509Extension(X509Extension extension) { }

	protected virtual void Decode() { }

	protected virtual void Encode() { }

	public override bool Equals(object obj) { }

	public bool get_Critical() { }

	public string get_Oid() { }

	public ASN1 get_Value() { }

	public override int GetHashCode() { }

	public override string ToString() { }

	private void WriteLine(StringBuilder sb, int n, int pos) { }

}

