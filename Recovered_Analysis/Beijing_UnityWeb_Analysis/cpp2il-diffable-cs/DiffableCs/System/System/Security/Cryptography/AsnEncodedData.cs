namespace System.Security.Cryptography;

public class AsnEncodedData
{
	internal Oid _oid; //Field offset: 0x8
	internal byte[] _raw; //Field offset: 0xC

	public Oid Oid
	{
		 get { } //Length: 42
		 set { } //Length: 11
	}

	public byte[] RawData
	{
		 get { } //Length: 6
		 set { } //Length: 83
	}

	protected AsnEncodedData() { }

	public AsnEncodedData(string oid, byte[] rawData) { }

	public AsnEncodedData(Oid oid, byte[] rawData) { }

	public AsnEncodedData(AsnEncodedData asnEncodedData) { }

	public AsnEncodedData(byte[] rawData) { }

	internal string BasicConstraintsExtension(bool multiLine) { }

	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal string Default(bool multiLine) { }

	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	public virtual string Format(bool multiLine) { }

	public Oid get_Oid() { }

	public byte[] get_RawData() { }

	internal string KeyUsageExtension(bool multiLine) { }

	internal string NetscapeCertType(bool multiLine) { }

	public void set_Oid(Oid value) { }

	public void set_RawData(byte[] value) { }

	internal string SubjectAltName(bool multiLine) { }

	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	internal virtual string ToString(bool multiLine) { }

}

