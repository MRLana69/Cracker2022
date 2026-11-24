namespace System.Net;

internal delegate HeaderParser
{

	public HeaderParser(object object, nint method) { }

	public virtual IAsyncResult BeginInvoke(string value, AsyncCallback callback, object object) { }

	public virtual string[] EndInvoke(IAsyncResult result) { }

	public virtual string[] Invoke(string value) { }

}

