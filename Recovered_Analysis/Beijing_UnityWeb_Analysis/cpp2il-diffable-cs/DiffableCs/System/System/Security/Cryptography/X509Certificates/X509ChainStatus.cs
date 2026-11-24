namespace System.Security.Cryptography.X509Certificates;

public struct X509ChainStatus
{
	private X509ChainStatusFlags status; //Field offset: 0x0
	private string info; //Field offset: 0x4

	public X509ChainStatusFlags Status
	{
		 get { } //Length: 6
		 set { } //Length: 14
	}

	public string StatusInformation
	{
		 set { } //Length: 11
	}

	internal X509ChainStatus(X509ChainStatusFlags flag) { }

	public X509ChainStatusFlags get_Status() { }

	internal static string GetInformation(X509ChainStatusFlags flags) { }

	public void set_Status(X509ChainStatusFlags value) { }

	public void set_StatusInformation(string value) { }

}

