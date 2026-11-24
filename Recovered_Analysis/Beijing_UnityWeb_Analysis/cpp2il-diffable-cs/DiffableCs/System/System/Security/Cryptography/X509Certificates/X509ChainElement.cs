namespace System.Security.Cryptography.X509Certificates;

public class X509ChainElement
{
	private X509Certificate2 certificate; //Field offset: 0x8
	private X509ChainStatus[] status; //Field offset: 0xC
	private string info; //Field offset: 0x10
	private X509ChainStatusFlags compressed_status_flags; //Field offset: 0x14

	public X509Certificate2 Certificate
	{
		 get { } //Length: 15
	}

	public X509ChainStatus[] ChainElementStatus
	{
		 get { } //Length: 6
	}

	internal X509ChainStatusFlags StatusFlags
	{
		 get { } //Length: 6
		 set { } //Length: 67
	}

	internal X509ChainElement(X509Certificate2 certificate) { }

	private int Count(X509ChainStatusFlags flags) { }

	public X509Certificate2 get_Certificate() { }

	public X509ChainStatus[] get_ChainElementStatus() { }

	internal X509ChainStatusFlags get_StatusFlags() { }

	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	internal void UncompressFlags() { }

}

