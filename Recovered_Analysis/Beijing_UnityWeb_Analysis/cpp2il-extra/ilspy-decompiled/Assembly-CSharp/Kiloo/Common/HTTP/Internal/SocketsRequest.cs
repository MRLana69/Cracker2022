using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UnityEngine;

namespace Kiloo.Common.HTTP.Internal;

internal class SocketsRequest : Request
{
	public const string PROTOCOL = "HTTP/1.1";

	private const string EOL = "\r\n";

	private bool useSsl
	{
		get
		{
			//IL_000b: Expected VT, but got Obj
			return (byte)BoundsExtensions.GetWidth((Bounds)base.method__BackingField) != 0;
		}
	}

	public SocketsRequest(string method, Uri uri, byte[] bytes)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		RequestExtensions.LogError(text);
		object obj = this + 60;
		obj = text;
		base.maxRedirectCount__BackingField = 8u;
		base.acceptGzip__BackingField = true;
		base.ignoreCertificateErrors__BackingField = false;
		base.minBackOffTime__BackingField = 1f;
		base.keepAlive__BackingField = 5f;
		base.ignoreContentMD5__BackingField = true;
		object obj2 = this + 8;
		string text2 = method.ToString();
		obj2 = text2;
		object obj3 = this + 48;
		obj3 = uri;
		object obj4 = this + 52;
		obj4 = bytes;
	}

	public override void PrepareFetchResponse()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[Request] ", (int)this);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(message);
	}

	public override void FetchResponseAsync()
	{
		//IL_0168: Expected VT, but got Obj
		//IL_0028: Expected Obj, but got I4
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I8
		//IL_00ff: Expected I, but got Obj
		Headers headers = base.headers__BackingField.Add((KeyValuePair<string, string>)"Host");
		if (headers != null)
		{
			return;
		}
		bool flag = Uri.StaticIsFile((UriParser)(object)base.uri__BackingField);
		Headers headers2 = base.headers__BackingField.SetAll("Host", (IEnumerable<string>)flag);
		if (~(base.acceptGzip__BackingField ? 1u : 0u) == 0)
		{
			string text = base.headers__BackingField.Get("Accept-Encoding", "gzip");
		}
		if (base.bytes__BackingField != null)
		{
			byte[] array = base.bytes__BackingField;
			if (array.Length != 0)
			{
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v17 (Il2CppClass<System.DateTime>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v27 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
				object obj2 = systemTimeAsFileTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				IEnumerable<string> values = default;
				Headers headers3 = base.headers__BackingField.SetAll("Date", values);
			}
		}
		if (!(base.keepAlive__BackingField > 0.001f))
		{
			((HTTPBackOffException)(object)base.headers__BackingField)._002Ector("Connection", (Exception)(object)"close");
		}
	}

	public override void FetchResponse()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (base.state__BackingField != RequestState.None)
		{
			object obj3 = base.state__BackingField - 3;
			bool flag;
			if (base.state__BackingField == RequestState.Done || ((nint)obj3 != 1 && (nint)obj3 != 2 && (nint)obj3 == 3))
			{
				flag = true;
			}
			else
			{
				object obj4 = base.state__BackingField | RequestState.Waiting;
				flag = (nint)obj4 == 5;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InvalidProgramException ex = default;
				ex._002Ector("Request.FetchResponseAsync called while already in process");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		base.state__BackingField = RequestState.Waiting;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		nint num = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj7 = default;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj8 = default;
			object obj9 = default;
			if (obj8 == obj9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj11 = default;
				object obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj13 = default;
				object obj12 = obj13;
			}
			else
			{
				object obj14 = default;
				object obj12 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}

	private bool RedirectCheck(IResponse response)
	{
		//IL_0569: Expected I, but got Obj
		//IL_057f: Expected Obj, but got I
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_00b4: Expected I, but got Obj
		//IL_05e7: Invalid comparison between Obj and F4
		//IL_0101: Invalid comparison between VT and I4
		//IL_015e: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I
		//IL_0242: Expected I, but got Obj
		//IL_0258: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I4
		//IL_0551: Expected I4, but got Obj
		//IL_0657: Expected Obj, but got I4
		//IL_019f: Expected I, but got Obj
		//IL_02fa: Expected I, but got Obj
		//IL_0310: Expected Obj, but got I
		//IL_0283: Expected I, but got Obj
		//IL_06b8: Expected Obj, but got I
		//IL_06cd: Expected Obj, but got I
		//IL_033b: Expected I, but got Obj
		//IL_04b0: Expected I4, but got Obj
		//IL_04b0: Expected I4, but got Obj
		//IL_04bc: Expected Obj, but got I4
		//IL_04cf: Expected I, but got Obj
		//IL_04e5: Expected Obj, but got I
		//IL_0510: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v99 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WebClient.CloseIdleConnectionsToHost((string)(object)this);
		object obj2 = response;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ L1 (Kiloo.Common.HTTP.IResponse)+8]");
		_ = 0;
		Headers headers;
		object obj3;
		WebClient.CacheMetaData cacheMetaData2;
		if (obj2 != null)
		{
			headers = null;
			obj3 = 0;
		}
		else
		{
			nint num3 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v82 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v93 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WebClient.CacheMetaData cacheMetaData = WebClient.LoadCacheMetaData((string)(object)this);
			if (cacheMetaData != null)
			{
				if (cacheMetaData.timestamp == (DateTime)(object)0)
				{
					cacheMetaData2 = cacheMetaData;
					goto IL_02c7;
				}
				headers = (Headers)(object)cacheMetaData;
				obj3 = 1;
			}
			else
			{
				headers = null;
				obj3 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8685");
		object obj5 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
		{
			nint num5 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v69 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v76 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4DE");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		if (obj3 != null)
		{
			obj2 = response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ L1 (Kiloo.Common.HTTP.IResponse)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+1]");
			bool flag = (nint)0 != 0;
			nint num7 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v60 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v65 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Response)(object)this)._002Ector(headers, (byte[])flag);
			cacheMetaData2 = (WebClient.CacheMetaData)(object)headers;
			goto IL_02c7;
		}
		goto IL_0664;
		IL_02c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ L2_v9 (Kiloo.Common.HTTP.WebClient+CacheMetaData)+C]");
		if ((nint)0 != 0)
		{
			nint num9 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v82 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num10 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v92 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SimulatedRequestResult randomSimulatedRequestResult = WebClient.GetRandomSimulatedRequestResult((IList<SimulatedRequestResult>)cacheMetaData2.requestHeaders);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ L2_v9 (Kiloo.Common.HTTP.WebClient+CacheMetaData)+C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v76+14]");
			IRequest request = RequestExtensions.WithHeaders((IRequest)0, (IDictionary<string, string>)randomSimulatedRequestResult);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
		goto IL_0664;
		IL_0664:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj10 = default;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj11 = default;
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Uri uri = default;
			string localPath = uri.LocalPath;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			int count = default;
			int num11 = "SendRequest Failed: \"".IndexOf((char)(int)localPath, (int)"\" status: ", count);
			string msg = (string)num11;
			nint num12 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S1_v19 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num13 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v24 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WebClient.LogWarning(msg);
		}
		return (byte)(int)this != 0;
	}

	private IResponse InternalFetchResponse()
	{
		//IL_0022: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		bool originalStringSwitched = base.uri__BackingField.OriginalStringSwitched;
		string text = ((string)originalStringSwitched).ToLowerInvariant();
		return (IResponse)(text != "https");
	}

	private void WriteToStream(Stream outputStream)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = outputStream;
	}

	private static void LogError(string msg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Request.Log(msg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		object obj3 = msg + 12;
		object obj4 = default;
		obj3 = obj4;
		_ = 3;
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string text = string.ConcatArray((string[])(object)"[SocketsRequest] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)text);
	}

	private void _003CFetchResponseAsync_003Eb__3_0(object _003Cp0_003E)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_043a: Expected Obj, but got I4
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected Obj, but got Unknown
		//IL_0464: Expected I, but got Obj
		//IL_047a: Expected Obj, but got I
		//IL_056a: Expected I4, but got Obj
		//IL_056a: Expected I4, but got Obj
		//IL_0021: Expected I, but got Obj
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01dc: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I
		//IL_036c: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I4
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(ASCIIEncoding);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<ASCIIEncoding>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(ASCIIEncoding);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v167 (Il2CppClass<ASCIIEncoding>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StreamWriter streamWriter = default;
		streamWriter.Flush((byte)(int)_003Cp0_003E != 0, (byte)(int)ASCIIEncoding.ASCII != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		bool isUnc = base.uri__BackingField.IsUnc;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		IEnumerator enumerator = base.headers__BackingField.System_002ECollections_002EIEnumerable_002EGetEnumerator();
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 175;
		if (enumerator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 175)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0579;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0579;
		IL_051b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		if (base.bytes__BackingField != null)
		{
			byte[] array = base.bytes__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
		}
		return;
		IL_0398:
		Headers headers = base.headers__BackingField.Set("Content-Length", "");
		if ((string)(object)headers != "")
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		goto IL_051b;
		IL_0579:
		if (base.bytes__BackingField != null)
		{
			byte[] array2 = base.bytes__BackingField;
			bool flag = array2.Length > 0;
			object obj16 = array2.Length;
			if (flag)
			{
				goto IL_0398;
			}
			obj16 = array2.Length;
		}
		else
		{
			object obj16 = 0;
		}
		if (!(base.method__BackingField == "POST") || base.method__BackingField != "PUT")
		{
			goto IL_0398;
		}
		goto IL_051b;
	}
}
