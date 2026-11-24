namespace System.Net;

public class IPEndPoint : EndPoint
{
	internal static IPEndPoint Any; //Field offset: 0x0
	internal static IPEndPoint IPv6Any; //Field offset: 0x4
	private IPAddress m_Address; //Field offset: 0x8
	private int m_Port; //Field offset: 0xC

	public IPAddress Address
	{
		 get { } //Length: 9
	}

	public override AddressFamily AddressFamily
	{
		 get { } //Length: 159
	}

	public int Port
	{
		 get { } //Length: 6
	}

	private static IPEndPoint() { }

	public IPEndPoint(IPAddress address, int port) { }

	public override EndPoint Create(SocketAddress socketAddress) { }

	public override bool Equals(object comparand) { }

	public IPAddress get_Address() { }

	public override AddressFamily get_AddressFamily() { }

	public int get_Port() { }

	public override int GetHashCode() { }

	public override SocketAddress Serialize() { }

	public override string ToString() { }

}

