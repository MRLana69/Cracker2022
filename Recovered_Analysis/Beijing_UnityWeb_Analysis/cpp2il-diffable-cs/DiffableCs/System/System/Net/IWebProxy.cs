namespace System.Net;

public interface IWebProxy
{

	public Uri GetProxy(Uri destination) { }

	public bool IsBypassed(Uri host) { }

}

