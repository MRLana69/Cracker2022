namespace Kiloo.Common.HTTP.Internal;

internal class SocketsRequest : Request
{
	public const string PROTOCOL = "HTTP/1.1"; //Field offset: 0x0
	private const string EOL = "
"; //Field offset: 0x0

	private bool useSsl
	{
		 get { } //Length: 12
	}

	public SocketsRequest(string method, Uri uri, byte[] bytes) { }

	private void <FetchResponseAsync>b__3_0(object <p0>) { }

	public override void FetchResponse() { }

	public override void FetchResponseAsync() { }

	private bool get_useSsl() { }

	private IResponse InternalFetchResponse() { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	public override void PrepareFetchResponse() { }

	private bool RedirectCheck(IResponse response) { }

	private void WriteToStream(Stream outputStream) { }

}

