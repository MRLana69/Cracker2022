namespace Kiloo.Common.HTTP;

public static class HTTPFactory
{

	public static IRequest CreateDelete(Uri uri) { }

	public static IRequest CreateGet(Uri uri) { }

	public static IRequest CreatePost(Uri uri) { }

	public static IRequest CreatePut(Uri uri) { }

	public static IRequest CreateRequest(string method, Uri uri, byte[] bytes = null) { }

	public static IRequest CreateRequest(string method, string uri, byte[] bytes = null) { }

	public static IResponse CreateResponse(Headers headers, byte[] bytes) { }

	public static IResponse CreateResponse(int status, string message, Headers headers, byte[] bytes) { }

}

