using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.HTTP.Internal;
using MiniJSON;
using UnityEngine;

namespace Kiloo.Common.HTTP;

public static class RequestExtensions
{
	public const int DUMP_MAX_BODY_CHARS = 1000;

	public static IRequest WithContent(IRequest request, byte[] content, string contentType)
	{
		//IL_0051: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		if (content == null)
		{
			goto IL_0077;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		object obj;
		if (contentType != null)
		{
			obj = 0;
			if (contentType._stringLength != 0)
			{
				goto IL_0099;
			}
		}
		obj = 1;
		goto IL_0099;
		IL_0099:
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Headers headers = default;
			headers.set_Item("Content-Type", contentType);
		}
		goto IL_0077;
		IL_0077:
		return request;
	}

	public static IRequest WithContent(IRequest request, string content, string contentType = "text/plain; charset=utf-8", Encoding encoding = null)
	{
		//IL_003e: Expected I, but got Obj
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Encoding encoding2 = default;
		Encoding uTF = default;
		if (encoding2 == null)
		{
			uTF = Encoding.UTF8;
		}
		nint num = (nint)uTF;
		object obj = uTF + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S3_v2 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		byte[] content2 = default;
		return WithContent(request, content2, contentType);
	}

	public static IRequest WithJsonContent(IRequest request, object jsonData)
	{
		//IL_0028: Expected I, but got Obj
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Encoding uTF = Encoding.UTF8;
		string text = Json.Serialize(jsonData);
		nint num = (nint)uTF;
		object obj = uTF + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S3_v3 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		byte[] content = default;
		return WithContent(request, content, "application/json");
	}

	public static IRequest WithHeaders(IRequest request, IDictionary<string, string> headers)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		if (headers != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = obj + 28;
			obj = obj3;
			_ = 0;
			object obj4 = default;
			object obj5 = default;
			object obj6 = default;
			object obj8 = default;
			object obj9 = default;
			IRequest result = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj4 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj5 != obj6;
				object obj7 = obj8;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj7 = obj9;
				}
				_ = 0;
				object obj10 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return result;
			}
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		}
		return request;
	}

	public static IRequest WithHeader(IRequest request, string key, string value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Headers headers = default;
		headers.set_Item(key, value);
		return request;
	}

	public static IRequest WithTimeout(IRequest request, float timeout)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F46");
		return request;
	}

	public static IRequest WithKeepAlive(IRequest request, float keepAlive)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F46");
		return request;
	}

	public static IRequest WithMinBackOffTime(IRequest request, float minBackOffTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F46");
		return request;
	}

	public static IRequest WithMaxBackOffTime(IRequest request, float maxBackOffTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F46");
		return request;
	}

	public static IRequest WithIgnoreCertificateErrors(IRequest request, bool ignoreCertificateErrors)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		return request;
	}

	public static IRequest WithIgnoreContentMD5(IRequest request, bool ignoreContentMD5)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		return request;
	}

	public static IRequest WithSimulatedRequestLatency(IRequest request, float simulatedRequestLatency)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F46");
		return request;
	}

	public static IRequest WithSimulatedRequestResults(IRequest request, IEnumerable<SimulatedRequestResult> simulatedRequestResults)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		return request;
	}

	public unsafe static IRequest ThenMakeTheRequest(IRequest request, WebClient.SendOptions options = default(WebClient.SendOptions))
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		object obj = default;
		WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj - 16);
		System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, options.simulatedRequestResults);
		((WebClient.SendOptions*)(nint)sendOptions)->disableCache = options.disableCache;
		return WebClient.SendRequest(request, sendOptions);
	}

	public unsafe static IRequest Send(IRequest request, WebClient.SendOptions options = default(WebClient.SendOptions))
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		object obj = default;
		WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj - 16);
		System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, options.simulatedRequestResults);
		((WebClient.SendOptions*)(nint)sendOptions)->disableCache = options.disableCache;
		return WebClient.SendRequest(request, sendOptions);
	}

	public unsafe static Coroutine ThenMakeTheRequestAsync(IRequest request, WebClient.RequestCompleteHandler onComplete = null, WebClient.SendOptions options = default(WebClient.SendOptions))
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		object obj = default;
		WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj - 16);
		System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, options.simulatedRequestResults);
		((WebClient.SendOptions*)(nint)sendOptions)->disableCache = options.disableCache;
		return WebClient.SendRequestAsync(request, onComplete, sendOptions);
	}

	public unsafe static Coroutine SendAsync(IRequest request, WebClient.RequestCompleteHandler onComplete = null, WebClient.SendOptions options = default(WebClient.SendOptions))
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		object obj = default;
		WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj - 16);
		System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, options.simulatedRequestResults);
		((WebClient.SendOptions*)(nint)sendOptions)->disableCache = options.disableCache;
		return WebClient.SendRequestAsync(request, onComplete, sendOptions);
	}

	public static IRequest WithKilooAuth(IRequest request, string authentication)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		object obj;
		if (authentication != null)
		{
			obj = 0;
			if (authentication._stringLength != 0)
			{
				goto IL_00b9;
			}
		}
		obj = 1;
		goto IL_00b9;
		IL_00b9:
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Uri uri = default;
			string scheme = uri.Scheme;
			if (scheme == "https")
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Headers headers = default;
				headers.set_Item("Kiloo-Auth", authentication);
			}
		}
		return request;
	}

	public unsafe static string CreateDump(IRequest request, RequestDumpOption options = RequestDumpOption.ALL, int maxBodyChars = 1000)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I4
		//IL_0494: Expected Obj, but got I4
		//IL_04c7: Expected I, but got Obj
		//IL_02ce: Expected Obj, but got I4
		//IL_0330: Expected Obj, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Ref, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Ref, but got Unknown
		//IL_0230: Expected Obj, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected I4, but got Unknown
		//IL_0437: Expected Obj, but got I
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		StringBuilder stringBuilder = default;
		string value = default;
		stringBuilder._002Ector(value);
		StringBuilder stringBuilder2 = stringBuilder.Append(' ');
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Uri uri = default;
		string absoluteUri = uri.AbsoluteUri;
		StringBuilder stringBuilder3 = stringBuilder.Append(absoluteUri);
		object obj3 = options & RequestDumpOption.STATUS;
		if (obj3 != null)
		{
			StringBuilder stringBuilder4 = stringBuilder.Append("\n\nStatus: ");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string value2 = default;
			StringBuilder stringBuilder5 = stringBuilder4.Append(value2);
		}
		object obj4 = options & RequestDumpOption.REQUEST_HEADERS;
		if (obj4 != null)
		{
			StringBuilder stringBuilder6 = stringBuilder.Append("\n\nRequest headers:\n");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object value3 = default;
			StringBuilder stringBuilder7 = stringBuilder6.Append(value3);
		}
		object obj5 = options & RequestDumpOption.REQUEST_BODY;
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			byte[] array = default;
			if (array != null && array.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Headers headers = default;
				string text = Util.ContentAsString(array, headers, maxBodyChars, out *(int*)(obj + 12));
				StringBuilder stringBuilder8 = stringBuilder.Append("\n\nRequest body:\n");
				StringBuilder stringBuilder9 = stringBuilder8.Append(text);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				if ((nint)0 > (nint)text._stringLength)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					object obj6 = -text._stringLength;
					int num = obj + 8;
					string text2 = ((int*)num)->ToString();
					string value4 = "\n--truncated " + text2 + " more chars--";
					StringBuilder stringBuilder10 = stringBuilder.Append(value4);
				}
			}
			else
			{
				StringBuilder stringBuilder11 = stringBuilder.Append("\n\nRequest has no body");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj7 = default;
		string value6;
		if (obj7 != null)
		{
			object obj8 = options & RequestDumpOption.RESPONSE_HEADERS;
			if (obj8 != null)
			{
				StringBuilder stringBuilder12 = stringBuilder.Append("\n\nResponse headers:\n");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object value5 = default;
				StringBuilder stringBuilder13 = stringBuilder12.Append(value5);
			}
			object obj9 = options & RequestDumpOption.RESPONSE_BODY;
			if (obj9 == null)
			{
				goto IL_04bf;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			byte[] array2 = default;
			if (array2 != null && array2.Length != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Headers headers2 = default;
				string text3 = Util.ContentAsString(array2, headers2, maxBodyChars, out *(int*)(obj + 4));
				StringBuilder stringBuilder14 = stringBuilder.Append("\n\nResponse body:\n");
				StringBuilder stringBuilder15 = stringBuilder14.Append(text3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				if ((nint)0 <= (nint)text3._stringLength)
				{
					goto IL_04bf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				object obj10 = -text3._stringLength;
				int num2 = obj + 8;
				string text4 = ((int*)num2)->ToString();
				value6 = "\n--truncated " + text4 + " more chars--";
			}
			else
			{
				value6 = "\n\nResponse has no body";
			}
		}
		else
		{
			object obj11 = options & RequestDumpOption.ALL_RESPONSE;
			if (obj11 == null)
			{
				goto IL_04bf;
			}
			value6 = "\n\nNo response (NULL)";
		}
		StringBuilder stringBuilder16 = stringBuilder.Append(value6);
		goto IL_04bf;
		IL_04bf:
		nint num3 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v212 @ S1_v24 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private static void LogError(string msg)
	{
	}
}
