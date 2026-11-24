namespace Kiloo.Common.HTTP;

public static class RequestExtensions
{
	public const int DEFAULT_DUMP_MAX_BODY_CHARS = 1000; //Field offset: 0x0
	public const int DEFAULT_DUMP_MAX_HEX_LINES = 50; //Field offset: 0x0

	public static string CreateDump(IRequest request, RequestDumpOption options = 31, int maxBodyChars = 0, int maxHexLines = 0) { }

	private static void LogError(string msg) { }

	public static IRequest Send(IRequest request, SendOptions options = null) { }

	public static Coroutine SendAsync(IRequest request, RequestCompleteHandler onComplete = null, SendOptions options = null) { }

	public static IRequest ThenMakeTheRequest(IRequest request, SendOptions options = null) { }

	public static Coroutine ThenMakeTheRequestAsync(IRequest request, RequestCompleteHandler onComplete = null, SendOptions options = null) { }

	public static IRequest WithAcceptGzip(IRequest request, bool acceptGzip) { }

	public static IRequest WithBsonContent(IRequest request, object jsonData, IBsonSerializer bsonSerializer) { }

	public static IRequest WithContent(IRequest request, byte[] content, string contentType) { }

	public static IRequest WithContent(IRequest request, string content, string contentType = "text/plain; charset=utf-8", Encoding encoding = null) { }

	public static IRequest WithHeader(IRequest request, string key, string value) { }

	public static IRequest WithHeaders(IRequest request, IDictionary<string, string> headers) { }

	public static IRequest WithIgnoreCertificateErrors(IRequest request, bool ignoreCertificateErrors) { }

	public static IRequest WithIgnoreContentMD5(IRequest request, bool ignoreContentMD5) { }

	public static IRequest WithJsonContent(IRequest request, object jsonData, IJsonSerializer jsonSerializer) { }

	public static IRequest WithKeepAlive(IRequest request, float keepAlive) { }

	public static IRequest WithMaxBackOffTime(IRequest request, float maxBackOffTime) { }

	public static IRequest WithMinBackOffTime(IRequest request, float minBackOffTime) { }

	public static IRequest WithQueryParameter(IRequest request, string name, string value) { }

	public static IRequest WithTimeout(IRequest request, float timeout) { }

}

