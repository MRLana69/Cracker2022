namespace System.Security.Cryptography.X509Certificates;

public class X509Extension : AsnEncodedData
{
	private bool _critical; //Field offset: 0x10

	public bool Critical
	{
		 get { } //Length: 2017
		 set { } //Length: 319
	}

	protected X509Extension() { }

	public X509Extension(string oid, byte[] rawData, bool critical) { }

	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	internal string FormatUnkownData(byte[] data) { }

	public bool get_Critical() { }

	public void set_Critical(bool value) { }

}

