namespace System.Net.NetworkInformation;

internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties
{

	public override string DomainName
	{
		 get { } //Length: 6
	}

	protected CommonUnixIPGlobalProperties() { }

	public override string get_DomainName() { }

	private static int getdomainname(byte[] name, int len) { }

}

