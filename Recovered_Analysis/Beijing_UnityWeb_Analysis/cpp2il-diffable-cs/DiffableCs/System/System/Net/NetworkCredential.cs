namespace System.Net;

public class NetworkCredential : ICredentials
{
	private string m_domain; //Field offset: 0x8
	private string m_userName; //Field offset: 0xC
	private SecureString m_password; //Field offset: 0x10

	public string Domain
	{
		 set { } //Length: 17
	}

	public string Password
	{
		 set { } //Length: 73
	}

	public string UserName
	{
		 set { } //Length: 11
	}

	public NetworkCredential(string userName, string password) { }

	public NetworkCredential(string userName, string password, string domain) { }

	public void set_Domain(string value) { }

	public void set_Password(string value) { }

	public void set_UserName(string value) { }

}

