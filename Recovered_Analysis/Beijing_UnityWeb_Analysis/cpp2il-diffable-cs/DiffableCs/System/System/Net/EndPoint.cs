namespace System.Net;

public abstract class EndPoint
{

	public virtual AddressFamily AddressFamily
	{
		 get { } //Length: 81
	}

	protected EndPoint() { }

	public virtual EndPoint Create(SocketAddress socketAddress) { }

	public virtual AddressFamily get_AddressFamily() { }

	public virtual SocketAddress Serialize() { }

}

