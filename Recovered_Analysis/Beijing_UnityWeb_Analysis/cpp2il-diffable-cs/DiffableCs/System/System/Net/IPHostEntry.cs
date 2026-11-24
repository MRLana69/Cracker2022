namespace System.Net;

public class IPHostEntry
{
	private string hostName; //Field offset: 0x8
	private string[] aliases; //Field offset: 0xC
	private IPAddress[] addressList; //Field offset: 0x10
	internal bool isTrustedHost; //Field offset: 0x14

	public IPAddress[] AddressList
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string[] Aliases
	{
		 set { } //Length: 11
	}

	public string HostName
	{
		 get { } //Length: 22
		 set { } //Length: 72
	}

	public IPHostEntry() { }

	public IPAddress[] get_AddressList() { }

	public string get_HostName() { }

	public void set_AddressList(IPAddress[] value) { }

	public void set_Aliases(string[] value) { }

	public void set_HostName(string value) { }

}

