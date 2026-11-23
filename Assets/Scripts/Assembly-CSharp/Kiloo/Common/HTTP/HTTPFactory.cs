using System;
using Kiloo.Common.HTTP.Internal;

namespace Kiloo.Common.HTTP;

public static class HTTPFactory
{
	public static IRequest CreateGet(Uri uri)
	{
		return CreateRequest("GET", uri);
	}

	public static IRequest CreatePost(Uri uri)
	{
		return CreateRequest("POST", uri);
	}

	public static IRequest CreatePut(Uri uri)
	{
		return CreateRequest("PUT", uri);
	}

	public static IRequest CreateDelete(Uri uri)
	{
		return CreateRequest("DELETE", uri);
	}

	public static IRequest CreateRequest(string method, Uri uri, byte[] bytes = null)
	{
		UnityRequest unityRequest = default;
		unityRequest._002Ector(method, uri, bytes);
		return unityRequest;
	}

	public static IRequest CreateRequest(string method, string uri, byte[] bytes = null)
	{
		Uri uri2 = default;
		uri2._002Ector(uri);
		return CreateRequest(method, uri2, bytes);
	}

	public static IResponse CreateResponse(Headers headers, byte[] bytes)
	{
		Response response = default;
		response._002Ector(headers, bytes);
		return response;
	}

	public static IResponse CreateResponse(int status, string message, Headers headers, byte[] bytes)
	{
		IResponse result = default;
		return result;
	}
}
