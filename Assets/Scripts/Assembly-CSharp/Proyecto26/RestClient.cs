using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using RSG;
using UnityEngine;

namespace Proyecto26;

public static class RestClient
{
	private static Dictionary<string, string> _defaultRequestParams;

	private static Dictionary<string, string> _defaultRequestHeaders;

	public static Version Version
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			//IL_0020: Expected I, but got Obj
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected Obj, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected Obj, but got Unknown
			//IL_0065: Expected Obj, but got I
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(RestClient));
			nint num = (nint)typeFromHandle;
			object obj = typeFromHandle + 216;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S1_v4 (Il2CppClass<System.Type>)+194] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3;
			object obj4 = obj3 + 160;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S1_v8+15C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v12+3C]");
			return (Version)0;
		}
	}

	public static Dictionary<string, string> DefaultRequestParams
	{
		get
		{
			if (_defaultRequestParams == null)
			{
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
				Dictionary<string, string> defaultRequestParams = default;
				_defaultRequestParams = defaultRequestParams;
			}
			return _defaultRequestParams;
		}
		set
		{
			_defaultRequestParams = value;
		}
	}

	public static Dictionary<string, string> DefaultRequestHeaders
	{
		get
		{
			if (_defaultRequestHeaders == null)
			{
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
				Dictionary<string, string> defaultRequestHeaders = default;
				_defaultRequestHeaders = defaultRequestHeaders;
			}
			return _defaultRequestHeaders;
		}
		set
		{
			_defaultRequestHeaders = value;
		}
	}

	public static void ClearDefaultParams()
	{
		Dictionary<string, string> defaultRequestParams = DefaultRequestParams;
		throw new IndexOutOfRangeException();
	}

	public static void ClearDefaultHeaders()
	{
		Dictionary<string, string> defaultRequestHeaders = DefaultRequestHeaders;
		throw new IndexOutOfRangeException();
	}

	public static void Request(RequestHelper options, Action<RequestException, ResponseHelper> callback)
	{
		IEnumerator coroutine = HttpBase.DefaultUnityWebRequest(options, callback);
		Coroutine coroutine2 = StaticCoroutine.StartCoroutine(coroutine);
	}

	public static void Request<T>(RequestHelper options, Action<RequestException, ResponseHelper, T> callback)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Request>>)+4] (should have been resolved before IL gen)");
		IEnumerator coroutine2 = default;
		Coroutine coroutine = StaticCoroutine.StartCoroutine(coroutine2);
	}

	public static void Get(string url, Action<RequestException, ResponseHelper> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		Get(requestHelper, callback);
	}

	public static void Get(RequestHelper options, Action<RequestException, ResponseHelper> callback)
	{
		options._method = "GET";
		Request(options, callback);
	}

	public static void Get<T>(string url, Action<RequestException, ResponseHelper, T> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Get>>)+4] (should have been resolved before IL gen)");
	}

	public static void Get<T>(RequestHelper options, Action<RequestException, ResponseHelper, T> callback)
	{
		options._method = "GET";
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Get>>)+4] (should have been resolved before IL gen)");
	}

	public static void GetArray<T>(string url, Action<RequestException, ResponseHelper, T[]> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::GetArray>>)+4] (should have been resolved before IL gen)");
	}

	public static void GetArray<T>(RequestHelper options, Action<RequestException, ResponseHelper, T[]> callback)
	{
		options._method = "GET";
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::GetArray>>)+4] (should have been resolved before IL gen)");
		IEnumerator coroutine2 = default;
		Coroutine coroutine = StaticCoroutine.StartCoroutine(coroutine2);
	}

	public static void Post(string url, object body, Action<RequestException, ResponseHelper> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._body = body;
		Post(requestHelper, callback);
	}

	public static void Post(string url, string bodyString, Action<RequestException, ResponseHelper> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._bodyString = bodyString;
		Post(requestHelper, callback);
	}

	public static void Post(RequestHelper options, Action<RequestException, ResponseHelper> callback)
	{
		options._method = "POST";
		Request(options, callback);
	}

	public static void Post<T>(string url, object body, Action<RequestException, ResponseHelper, T> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._body = body;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Post>>)+4] (should have been resolved before IL gen)");
	}

	public static void Post<T>(string url, string bodyString, Action<RequestException, ResponseHelper, T> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._bodyString = bodyString;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Post>>)+4] (should have been resolved before IL gen)");
	}

	public static void Post<T>(RequestHelper options, Action<RequestException, ResponseHelper, T> callback)
	{
		options._method = "POST";
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Post>>)+4] (should have been resolved before IL gen)");
	}

	public static void PostArray<T>(string url, object body, Action<RequestException, ResponseHelper, T[]> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._body = body;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::PostArray>>)+4] (should have been resolved before IL gen)");
	}

	public static void PostArray<T>(string url, string bodyString, Action<RequestException, ResponseHelper, T[]> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._bodyString = bodyString;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::PostArray>>)+4] (should have been resolved before IL gen)");
	}

	public static void PostArray<T>(RequestHelper options, Action<RequestException, ResponseHelper, T[]> callback)
	{
		options._method = "POST";
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::PostArray>>)+4] (should have been resolved before IL gen)");
		IEnumerator coroutine2 = default;
		Coroutine coroutine = StaticCoroutine.StartCoroutine(coroutine2);
	}

	public static void Put(string url, object body, Action<RequestException, ResponseHelper> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._body = body;
		Put(requestHelper, callback);
	}

	public static void Put(string url, string bodyString, Action<RequestException, ResponseHelper> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._bodyString = bodyString;
		Put(requestHelper, callback);
	}

	public static void Put(RequestHelper options, Action<RequestException, ResponseHelper> callback)
	{
		options._method = "PUT";
		Request(options, callback);
	}

	public static void Put<T>(string url, object body, Action<RequestException, ResponseHelper, T> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._body = body;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Put>>)+4] (should have been resolved before IL gen)");
	}

	public static void Put<T>(string url, string bodyString, Action<RequestException, ResponseHelper, T> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._bodyString = bodyString;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Put>>)+4] (should have been resolved before IL gen)");
	}

	public static void Put<T>(RequestHelper options, Action<RequestException, ResponseHelper, T> callback)
	{
		options._method = "PUT";
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Put>>)+4] (should have been resolved before IL gen)");
	}

	public static void Delete(string url, Action<RequestException, ResponseHelper> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		Delete(requestHelper, callback);
	}

	public static void Delete(RequestHelper options, Action<RequestException, ResponseHelper> callback)
	{
		options._method = "DELETE";
		Request(options, callback);
	}

	public static void Head(string url, Action<RequestException, ResponseHelper> callback)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		Head(requestHelper, callback);
	}

	public static void Head(RequestHelper options, Action<RequestException, ResponseHelper> callback)
	{
		options._method = "HEAD";
		Request(options, callback);
	}

	public static IPromise<ResponseHelper> Request(RequestHelper options)
	{
		Promise<ResponseHelper> promise = default;
		promise._002Ector();
		throw new ArgumentException();
	}

	public static IPromise<T> Request<T>(RequestHelper options)
	{
		//IL_002b: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::Request>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num3 = 0;
		nint num4 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S4_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::Request>)+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S4_v3+4] (should have been resolved before IL gen)");
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v5 (Il2CppMethodRgctx<Proyecto26.RestClient::Request>)+14]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S3_v6+4] (should have been resolved before IL gen)");
		IPromise<T> result = default;
		return result;
	}

	public static IPromise<ResponseHelper> Get(string url)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		return Get(requestHelper);
	}

	public static IPromise<ResponseHelper> Get(RequestHelper options)
	{
		Promise<ResponseHelper> promise = default;
		promise._002Ector();
		throw new ArgumentException();
	}

	public static IPromise<T> Get<T>(string url)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Get>>)+4] (should have been resolved before IL gen)");
		IPromise<T> result = default;
		return result;
	}

	public static IPromise<T> Get<T>(RequestHelper options)
	{
		//IL_002b: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::Get>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num3 = 0;
		nint num4 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S4_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::Get>)+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S4_v3+4] (should have been resolved before IL gen)");
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v5 (Il2CppMethodRgctx<Proyecto26.RestClient::Get>)+14]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S3_v6+4] (should have been resolved before IL gen)");
		IPromise<T> result = default;
		return result;
	}

	public static IPromise<T[]> GetArray<T>(string url)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::GetArray>>)+4] (should have been resolved before IL gen)");
		IPromise<T[]> result = default;
		return result;
	}

	public static IPromise<T[]> GetArray<T>(RequestHelper options)
	{
		//IL_002b: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::GetArray>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num3 = 0;
		nint num4 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S4_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::GetArray>)+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S4_v3+4] (should have been resolved before IL gen)");
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v5 (Il2CppMethodRgctx<Proyecto26.RestClient::GetArray>)+14]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S3_v6+4] (should have been resolved before IL gen)");
		IPromise<T[]> result = default;
		return result;
	}

	public static IPromise<ResponseHelper> Post(string url, object body)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._body = body;
		return Post(requestHelper);
	}

	public static IPromise<ResponseHelper> Post(string url, string bodyString)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._bodyString = bodyString;
		return Post(requestHelper);
	}

	public static IPromise<ResponseHelper> Post(RequestHelper options)
	{
		Promise<ResponseHelper> promise = default;
		promise._002Ector();
		throw new ArgumentException();
	}

	public static IPromise<T> Post<T>(string url, object body)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._body = body;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Post>>)+4] (should have been resolved before IL gen)");
		IPromise<T> result = default;
		return result;
	}

	public static IPromise<T> Post<T>(string url, string bodyString)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._bodyString = bodyString;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Post>>)+4] (should have been resolved before IL gen)");
		IPromise<T> result = default;
		return result;
	}

	public static IPromise<T> Post<T>(RequestHelper options)
	{
		//IL_002b: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::Post>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num3 = 0;
		nint num4 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S4_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::Post>)+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S4_v3+4] (should have been resolved before IL gen)");
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v5 (Il2CppMethodRgctx<Proyecto26.RestClient::Post>)+14]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S3_v6+4] (should have been resolved before IL gen)");
		IPromise<T> result = default;
		return result;
	}

	public static IPromise<T[]> PostArray<T>(string url, object body)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._body = body;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::PostArray>>)+4] (should have been resolved before IL gen)");
		IPromise<T[]> result = default;
		return result;
	}

	public static IPromise<T[]> PostArray<T>(string url, string bodyString)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._bodyString = bodyString;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::PostArray>>)+4] (should have been resolved before IL gen)");
		IPromise<T[]> result = default;
		return result;
	}

	public static IPromise<T[]> PostArray<T>(RequestHelper options)
	{
		//IL_002b: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::PostArray>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num3 = 0;
		nint num4 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S4_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::PostArray>)+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S4_v3+4] (should have been resolved before IL gen)");
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v5 (Il2CppMethodRgctx<Proyecto26.RestClient::PostArray>)+14]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S3_v6+4] (should have been resolved before IL gen)");
		IPromise<T[]> result = default;
		return result;
	}

	public static IPromise<ResponseHelper> Put(string url, object body)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._body = body;
		return Put(requestHelper);
	}

	public static IPromise<ResponseHelper> Put(string url, string bodyString)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._bodyString = bodyString;
		return Put(requestHelper);
	}

	public static IPromise<ResponseHelper> Put(RequestHelper options)
	{
		Promise<ResponseHelper> promise = default;
		promise._002Ector();
		throw new ArgumentException();
	}

	public static IPromise<T> Put<T>(string url, object body)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._body = body;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Put>>)+4] (should have been resolved before IL gen)");
		IPromise<T> result = default;
		return result;
	}

	public static IPromise<T> Put<T>(string url, string bodyString)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		requestHelper._bodyString = bodyString;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Put>>)+4] (should have been resolved before IL gen)");
		IPromise<T> result = default;
		return result;
	}

	public static IPromise<T> Put<T>(RequestHelper options)
	{
		//IL_002b: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::Put>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num3 = 0;
		nint num4 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S4_v2 (Il2CppMethodRgctx<Proyecto26.RestClient::Put>)+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S4_v3+4] (should have been resolved before IL gen)");
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v5 (Il2CppMethodRgctx<Proyecto26.RestClient::Put>)+14]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S3_v6+4] (should have been resolved before IL gen)");
		IPromise<T> result = default;
		return result;
	}

	public static IPromise<ResponseHelper> Delete(string url)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		return Delete(requestHelper);
	}

	public static IPromise<ResponseHelper> Delete(RequestHelper options)
	{
		Promise<ResponseHelper> promise = default;
		promise._002Ector();
		throw new ArgumentException();
	}

	public static IPromise<ResponseHelper> Head(string url)
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = url;
		return Delete(requestHelper);
	}

	public static IPromise<ResponseHelper> Head(RequestHelper options)
	{
		Promise<ResponseHelper> promise = default;
		promise._002Ector();
		throw new ArgumentException();
	}

	private static void Promisify<T>(Promise<T> promise, RequestException error, T response)
	{
		//IL_0060: Expected Obj, but got I
		//IL_0039: Expected Obj, but got I
		if (error != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S3_v4 (Il2CppMethodRgctx<Proyecto26.RestClient::Promisify>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S3_v5+4] (should have been resolved before IL gen)");
		}
		else
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v1 (Il2CppMethodRgctx<Proyecto26.RestClient::Promisify>)+8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v2+4] (should have been resolved before IL gen)");
		}
	}

	private static void Promisify<T>(Promise<T> promise, RequestException error, ResponseHelper response, T body)
	{
		//IL_0071: Expected I, but got Obj
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		if (error != null && response != null)
		{
			string error2 = response.Error;
			if (error2 == null)
			{
				nint num = (nint)error;
				object obj = error + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S2_v6 (Il2CppClass<Proyecto26.RequestException>)+E4] (should have been resolved before IL gen)");
			}
			error._serverMessage = error2;
		}
		nint num2 = 0;
		nint num3 = 0;
		IntPtr intPtr = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.RestClient::Promisify>>)+4] (should have been resolved before IL gen)");
	}
}
