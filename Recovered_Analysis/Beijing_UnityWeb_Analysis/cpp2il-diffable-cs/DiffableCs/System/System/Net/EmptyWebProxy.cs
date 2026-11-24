namespace System.Net;

internal sealed class EmptyWebProxy : IWebProxy
{

	public EmptyWebProxy() { }

	public Uri GetProxy(Uri uri) { }

	public bool IsBypassed(Uri uri) { }

}

