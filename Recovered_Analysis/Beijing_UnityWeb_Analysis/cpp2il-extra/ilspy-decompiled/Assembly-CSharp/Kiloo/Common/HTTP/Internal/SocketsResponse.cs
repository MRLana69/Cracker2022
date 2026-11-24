using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.Extensions;
using UnityEngine;

namespace Kiloo.Common.HTTP.Internal;

internal class SocketsResponse : Response
{
	private readonly object _chunksLock;

	private List<byte[]> _chunks;

	public SocketsResponse()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string text = string.ConcatArray((string[])(object)"[SocketsRequest] ", (int)this);
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
		Debug.LogError(text);
	}

	private string ReadHeaderLine(Stream stream)
	{
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_0096: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		bool flag = (nint)obj == 307;
		object obj2 = obj - 301;
		bool flag2 = (nint)obj2 < 2;
		object obj3 = flag | flag2;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Headers headers = default;
			IEnumerable<string> all = headers.GetAll("Location");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Uri uri = default;
			uri.CreateThisFromUri((Uri)all);
			IResponse response = ((SocketsRequest)(object)this).InternalFetchResponse();
			if (response != null)
			{
				bool originalStringSwitched = uri.OriginalStringSwitched;
				string text = ((string)originalStringSwitched).ToLowerInvariant();
				if (text.get_Chars((int)"https") != '\0')
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A5C0");
					SocketsRequest socketsRequest = default;
					socketsRequest.RedirectCheck((IResponse)null);
				}
			}
			object obj4 = this + 48;
			obj4 = uri;
			return (string)1;
		}
		return null;
	}

	private unsafe bool ReadHeader(Stream stream, out string key, out string value)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_019a: Expected Obj, but got I4
		//IL_019a: Expected Obj, but got I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_02c7: Expected Obj, but got I4
		//IL_02c7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		int length = default;
		stringBuilder.Length = length;
		StringBuilder stringBuilder2 = stringBuilder.Append(32);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Uri uri = default;
		string localPath = uri.LocalPath;
		StringBuilder stringBuilder3 = stringBuilder.AppendLine(localPath);
		object obj = stream & 1;
		if (obj != null)
		{
			StringBuilder stringBuilder4 = stringBuilder.AppendLine("\n\nStatus: ");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string value2 = default;
			StringBuilder stringBuilder5 = stringBuilder4.AppendLine(value2);
		}
		object obj2 = stream & 2;
		if (obj2 != null)
		{
			StringBuilder stringBuilder6 = stringBuilder.AppendLine("\n\nRequest headers:\n");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			int index = default;
			StringBuilder stringBuilder7 = stringBuilder6.FindChunkForIndex(index);
		}
		ref string reference = default;
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != null)
		{
			ref string reference2 = default;
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) == null)
			{
				goto IL_038d;
			}
			object obj3 = stream & 4;
			if (obj3 == null)
			{
				goto IL_03a4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		CloudServer2 cloudServer = default;
		if (cloudServer == null || cloudServer.kilooAuth__BackingField == null)
		{
			goto IL_038d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		string forKilooTag = default;
		Coroutine value3 = cloudServer.UpdateItemsAsync(forKilooTag, (IEnumerable<ICloudItem>)1000, (CloudServerRequestCompleteHandler)50);
		StringBuilder stringBuilder8 = stringBuilder.AppendLine("\n\nRequest body:\n");
		StringBuilder stringBuilder9 = stringBuilder8.AppendLine((string)(object)value3);
		goto IL_03a4;
		IL_03a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj4 = default;
		if (obj4 != null)
		{
			object obj5 = stream & 8;
			if (obj5 != null)
			{
				StringBuilder stringBuilder10 = stringBuilder.AppendLine("\n\nResponse headers:\n");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				int index2 = default;
				StringBuilder stringBuilder11 = stringBuilder10.FindChunkForIndex(index2);
			}
			object obj6 = stream & 0x10;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				CloudServer2 cloudServer2 = default;
				if (cloudServer2 != null && cloudServer2.kilooAuth__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					string forKilooTag2 = default;
					Coroutine value4 = cloudServer2.UpdateItemsAsync(forKilooTag2, (IEnumerable<ICloudItem>)1000, (CloudServerRequestCompleteHandler)50);
					StringBuilder stringBuilder12 = stringBuilder.AppendLine("\n\nResponse body:\n");
					StringBuilder stringBuilder13 = stringBuilder12.AppendLine((string)(object)value4);
				}
				else
				{
					StringBuilder stringBuilder14 = stringBuilder.AppendLine("\n\nResponse has no body");
				}
			}
		}
		else
		{
			object obj7 = stream & 0x18;
			if (obj7 != null)
			{
				StringBuilder stringBuilder15 = stringBuilder.AppendLine("\n\nNo response (NULL)");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
		IL_038d:
		StringBuilder stringBuilder16 = stringBuilder.AppendLine("\n\nRequest has no body");
		goto IL_03a4;
	}

	public byte[] TakeChunk()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06d2: Expected Obj, but got I
		//IL_06e4: Expected I4, but got Obj
		//IL_06e4: Expected Obj, but got I4
		//IL_06f9: Expected F4, but got I
		//IL_001c: Expected Obj, but got I4
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_00f4: Expected I, but got Obj
		//IL_0614: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.SocketsResponse)+3C]");
		bool flag = ((Headers)0).Contains("Connection");
		char c = ((string)flag).get_Chars((int)"close");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.SocketsResponse)+20]");
		bool flag2 = NumberExtensions.Chance(0f);
		object obj3 = 0;
		Connection connection2 = default;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		byte[] result = default;
		object obj16 = default;
		while (true)
		{
			((Request)(object)this).UpdateBackOffError();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			bool flag3 = _chunks != null;
			nint num = (nint)typeof(Connection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v95 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Connection);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v273 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @19");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Connection connection = connection2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj5 = obj6;
			object obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			if (obj7 == obj9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					if (connection != null)
					{
						Stream stream = connection.GetStream();
						connection.Dispose();
						if (stream != null)
						{
							object obj13 = 0;
							if (obj13 != null)
							{
								return result;
							}
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
					object obj14 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj15 = obj16;
				}
			}
			else
			{
				object obj15 = obj5;
			}
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		return null;
	}

	public void ReadFromStream(Stream inputStream, bool ignoreContentMd5 = false)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_004a: Expected Obj, but got I4
		base.status__BackingField = 200;
		object obj = this + 12;
		obj = "OK";
		object obj2 = this + 20;
		obj2 = inputStream;
		object obj3 = this + 16;
		obj3 = ignoreContentMd5;
	}

	private static void LogWarning(string msg)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		object obj = msg + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		RequestExtensions.LogError(text);
		((SocketsResponse)(object)msg).ReadFromStream((Stream)(object)text, false);
	}

	private static void LogVerbose(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string text = string.ConcatArray((string[])(object)"[SocketsResponse] ", (int)msg);
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
		Debug.LogAssertion(text);
	}
}
