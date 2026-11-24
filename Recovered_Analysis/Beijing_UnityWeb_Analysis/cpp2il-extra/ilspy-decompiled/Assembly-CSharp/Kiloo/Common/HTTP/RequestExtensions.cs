using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.HTTP;

public static class RequestExtensions
{
	public const int DEFAULT_DUMP_MAX_BODY_CHARS = 1000;

	public const int DEFAULT_DUMP_MAX_HEX_LINES = 50;

	public static IRequest WithContent(IRequest request, byte[] content, string contentType)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri.CreateThisFromUri((Uri)(object)content);
		return HTTPFactory.CreateRequest((string)(object)request, (string)(object)uri, (byte[])(object)contentType);
	}

	public static IRequest WithContent(IRequest request, string content, string contentType = "text/plain; charset=utf-8", Encoding encoding = null)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IRequest request2 = default;
		object obj = request2 + 12;
		obj = content;
		object obj2 = request2 + 20;
		obj2 = contentType;
		object obj3 = request2 + 16;
		obj3 = encoding;
		return request2;
	}

	public static IRequest WithJsonContent(IRequest request, object jsonData, IJsonSerializer jsonSerializer)
	{
		if (jsonData != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			bool flag;
			if (jsonSerializer != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [jsonSerializer @ L2 (Kiloo.Common.Utility.IJsonSerializer)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				HTTPBackOffException ex = default;
				ex._002Ector("Content-Type", (Exception)jsonSerializer);
			}
		}
		return request;
	}

	public static IRequest WithBsonContent(IRequest request, object jsonData, IBsonSerializer bsonSerializer)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object jsonData2 = default;
		return WithJsonContent(request, jsonData2, (IJsonSerializer)(object)"application/json");
	}

	public static IRequest WithHeaders(IRequest request, IDictionary<string, string> headers)
	{
		//IL_0020: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SocketsResponse socketsResponse = default;
		socketsResponse.ReadFromStream((Stream)request, (byte)(int)headers != 0);
		return (IRequest)socketsResponse;
	}

	public static IRequest WithHeader(IRequest request, string key, string value)
	{
		//IL_0012: Expected I4, but got Obj
		//IL_0012: Expected I4, but got Obj
		//IL_0028: Expected Obj, but got I4
		int num = KRandom.Range((int)value, (int)key);
		return WithJsonContent(request, num, (IJsonSerializer)(object)"application/bson");
	}

	public static IRequest WithTimeout(IRequest request, float timeout)
	{
		//IL_0104: Expected Obj, but got F4
		//IL_0184: Expected Obj, but got F4
		//IL_01d5: Expected Obj, but got F4
		//IL_0255: Expected Obj, but got F4
		//IL_02d5: Expected Obj, but got F4
		//IL_0355: Expected Obj, but got F4
		//IL_03d5: Expected Obj, but got F4
		//IL_0455: Expected Obj, but got F4
		//IL_04d5: Expected Obj, but got F4
		object obj;
		if (request != null)
		{
			if ((nint)request != 1)
			{
				if ((nint)request != 2)
				{
					if ((nint)request != 3)
					{
						if ((nint)request != 4)
						{
							if ((nint)request != 5)
							{
								if ((nint)request != 6)
								{
									if ((nint)request != 7)
									{
										if ((nint)request == 8)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
											obj = timeout;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
											throw new ArrayTypeMismatchException();
										}
										return (IRequest)(object)string.Empty;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
									obj = timeout;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
									throw new ArrayTypeMismatchException();
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
								obj = timeout;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
								throw new ArrayTypeMismatchException();
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
							obj = timeout;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							throw new ArrayTypeMismatchException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						obj = timeout;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					obj = timeout;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					throw new ArrayTypeMismatchException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				obj = timeout;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			obj = timeout;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		obj = timeout;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	public static IRequest WithKeepAlive(IRequest request, float keepAlive)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
		return request;
	}

	public static IRequest WithMinBackOffTime(IRequest request, float minBackOffTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
		return request;
	}

	public static IRequest WithMaxBackOffTime(IRequest request, float maxBackOffTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
		return request;
	}

	public static IRequest WithIgnoreCertificateErrors(IRequest request, bool ignoreCertificateErrors)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got I4
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00fe: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (ignoreCertificateErrors)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 64;
			object obj10 = default;
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v7+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj4 + obj11;
				if ((nint)obj12 == 64)
				{
					object obj13 = obj4 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					goto IL_0307;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_0307;
		IL_0307:
		return request;
	}

	public static IRequest WithIgnoreContentMD5(IRequest request, bool ignoreContentMD5)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		return request;
	}

	public static IRequest WithAcceptGzip(IRequest request, bool acceptGzip)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		return request;
	}

	public static IRequest WithQueryParameter(IRequest request, string name, string value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		HTTPBackOffException ex = default;
		ex._002Ector(name, (Exception)(object)value);
		return request;
	}

	public static IRequest ThenMakeTheRequest(IRequest request, WebClient.SendOptions options = default(WebClient.SendOptions))
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		return request;
	}

	public static IRequest Send(IRequest request, WebClient.SendOptions options = default(WebClient.SendOptions))
	{
		//IL_005f: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = options.disableCache;
		_ = options.simulatedRequestResults;
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IResponse response = (IResponse)(obj + 16);
		response = (IResponse)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return (IRequest)((SocketsRequest)request).RedirectCheck(response);
	}

	public unsafe static Coroutine ThenMakeTheRequestAsync(IRequest request, WebClient.RequestCompleteHandler onComplete = null, WebClient.SendOptions options = default(WebClient.SendOptions))
	{
		//IL_0066: Invalid comparison between VT and I4
		//IL_0049: Expected VT, but got Obj
		//IL_0092: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I
		//IL_02d6: Expected I4, but got Obj
		//IL_02e3: Expected I4, but got VT
		//IL_012c: Expected Obj, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_00d3: Expected I, but got Obj
		//IL_01dc: Expected I4, but got Obj
		//IL_020d: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got I4
		if (onComplete == null || ((Delegate)onComplete).method_ptr == (IntPtr)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentException ex = default;
			ex._002Ector((SerializationInfo)(object)"Value cannot be null or empty.", (StreamingContext)"name");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		if (options != (WebClient.SendOptions)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			nint num = (nint)typeof(Uri);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v14 (Il2CppClass<System.Uri>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Uri);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v55 (Il2CppClass<System.Uri>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = System.UriHelper.IsNotSafeForUnescape((char)(int)onComplete);
			bool flag2 = System.UriHelper.IsNotSafeForUnescape((char)(int)options);
			Uri uri = default;
			string fragment = uri.Fragment;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v19 (System.Boolean)+8]");
			object obj2 = (nint)0 + (nint)fragment.m_stringLength;
			object obj3 = obj2 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v21 (System.Boolean)+8]");
			string text = (string)(0 + obj3);
			StringBuilder stringBuilder2;
			if (fragment.m_stringLength < 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				StringBuilder stringBuilder = default;
				stringBuilder._002Ector(text);
				stringBuilder2 = stringBuilder;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				char* value = (char*)(fragment.m_stringLength - 1);
				StringBuilder stringBuilder3 = default;
				stringBuilder3.ReplaceInPlaceAtChunk(ref *(StringBuilder*)fragment, ref *(int*)1, value, (int)text);
				StringBuilder stringBuilder4 = stringBuilder3.Append(38);
				stringBuilder2 = stringBuilder3;
			}
			StringBuilder stringBuilder5 = stringBuilder2.AppendLine((string)flag);
			StringBuilder stringBuilder6 = stringBuilder2.Append(61);
			StringBuilder stringBuilder7 = stringBuilder2.AppendLine((string)flag2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			UriBuilder uriBuilder = default;
			uriBuilder.Init(uri);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Uri fieldsFromUri = default;
			uriBuilder.SetFieldsFromUri(fieldsFromUri);
			int hashCode = uriBuilder.GetHashCode();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
		return (Coroutine)(object)request;
	}

	public unsafe static Coroutine SendAsync(IRequest request, WebClient.RequestCompleteHandler onComplete = null, WebClient.SendOptions options = default(WebClient.SendOptions))
	{
		//IL_005f: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected VT, but got Unknown
		//IL_00c5: Expected I4, but got Obj
		//IL_00c0: Expected native int or pointer, but got VT
		//IL_00da: Expected Obj, but got I
		//IL_00d5: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj = options.disableCache;
		_ = options.simulatedRequestResults;
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 16);
		((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
		return (Coroutine)(object)WebClient.SendRequestCoroutine(request, onComplete, sendOptions);
	}

	public static string CreateDump(IRequest request, RequestDumpOption options = RequestDumpOption.All, int maxBodyChars = 0, int maxHexLines = 0)
	{
		//IL_0053: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		if (maxHexLines != 0)
		{
			Encoding encoding = (Encoding)maxHexLines;
		}
		else
		{
			Encoding encoding = Encoding.UTF32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object jsonData = default;
		return (string)(object)WithJsonContent(request, jsonData, (IJsonSerializer)maxBodyChars);
	}

	private static void LogError(string msg)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(StringComparer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.StringComparer>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(StringComparer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<System.StringComparer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4FA");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S3_v3+60]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S4_v4 (should have been resolved before IL gen)");
		object obj7 = msg + 8;
		object obj8 = default;
		obj7 = obj8;
	}
}
