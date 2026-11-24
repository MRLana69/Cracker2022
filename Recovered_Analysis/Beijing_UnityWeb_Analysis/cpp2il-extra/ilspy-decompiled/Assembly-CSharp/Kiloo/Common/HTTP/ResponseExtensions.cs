using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.HTTP;

public static class ResponseExtensions
{
	public static bool IsJson(IResponse response)
	{
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_02bc: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_005b: Expected I4, but got Obj
		//IL_02ca: Expected I4, but got Obj
		//IL_0069: Expected I4, but got Obj
		//IL_02d8: Expected I4, but got Obj
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_02e6: Expected I4, but got Obj
		//IL_0155: Expected I4, but got Obj
		//IL_02f4: Expected I4, but got Obj
		//IL_0163: Expected I4, but got Obj
		//IL_0302: Expected I4, but got Obj
		//IL_0171: Expected I4, but got Obj
		//IL_017f: Expected I4, but got Obj
		//IL_079c: Expected I4, but got Obj
		//IL_0310: Expected I4, but got Obj
		//IL_018d: Expected I4, but got Obj
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_019b: Expected I4, but got Obj
		//IL_053b: Expected I4, but got Obj
		//IL_01a9: Expected I4, but got Obj
		//IL_0549: Expected I4, but got Obj
		//IL_0557: Expected I4, but got Obj
		//IL_0565: Expected I4, but got Obj
		//IL_0573: Expected I4, but got Obj
		//IL_0581: Expected I4, but got Obj
		//IL_058f: Expected I4, but got Obj
		//IL_059d: Expected I4, but got Obj
		//IL_05ab: Expected I4, but got Obj
		//IL_05b9: Expected I4, but got Obj
		//IL_05c7: Expected I4, but got Obj
		//IL_05d5: Expected I4, but got Obj
		//IL_05e3: Expected I4, but got Obj
		//IL_05f1: Expected I4, but got Obj
		//IL_05ff: Expected I4, but got Obj
		//IL_060d: Expected I4, but got Obj
		//IL_061b: Expected I4, but got Obj
		//IL_0629: Expected I4, but got Obj
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_06f8: Expected I4, but got Obj
		//IL_0706: Expected I4, but got Obj
		//IL_0714: Expected I4, but got Obj
		//IL_0722: Expected I4, but got Obj
		//IL_0730: Expected I4, but got Obj
		//IL_073e: Expected I4, but got Obj
		if ((nint)response < 207)
		{
			object obj = response - 100;
			if ((nint)response == 100)
			{
				return (byte)(int)"Continue" != 0;
			}
			if ((nint)obj == 1)
			{
				return (byte)(int)"Switching Protocols" != 0;
			}
			object obj2 = response - 200;
			if ((nint)response == 200)
			{
				return (byte)(int)"OK" != 0;
			}
			if ((nint)obj2 == 1)
			{
				return (byte)(int)"Created" != 0;
			}
			if ((nint)obj2 == 2)
			{
				return (byte)(int)"Accepted" != 0;
			}
			if ((nint)obj2 == 3)
			{
				return (byte)(int)"Non-Authoritative Information" != 0;
			}
			if ((nint)obj2 == 4)
			{
				return (byte)(int)"No Content" != 0;
			}
			if ((nint)obj2 == 5)
			{
				return (byte)(int)"Reset Content" != 0;
			}
			if ((nint)obj2 == 6)
			{
				return (byte)(int)"Partial Content" != 0;
			}
		}
		else
		{
			object obj3 = response - 300;
			if ((nint)response == 300)
			{
				return (byte)(int)"Multiple Choices" != 0;
			}
			if ((nint)obj3 == 1)
			{
				return (byte)(int)"Moved Permanently" != 0;
			}
			if ((nint)obj3 == 2)
			{
				return (byte)(int)"Found" != 0;
			}
			if ((nint)obj3 == 3)
			{
				return (byte)(int)"See Other" != 0;
			}
			if ((nint)obj3 == 4)
			{
				return (byte)(int)"Not Modified" != 0;
			}
			if ((nint)obj3 == 5)
			{
				return (byte)(int)"Use Proxy" != 0;
			}
			if ((nint)obj3 != 6)
			{
				if ((nint)obj3 == 7)
				{
					return (byte)(int)"Temporary Redirect" != 0;
				}
				object obj4 = response - 400;
				if ((nint)response == 400)
				{
					return (byte)(int)"Bad Request" != 0;
				}
				if ((nint)obj4 == 1)
				{
					return (byte)(int)"Unauthorized" != 0;
				}
				if ((nint)obj4 == 2)
				{
					return (byte)(int)"Payment Required" != 0;
				}
				if ((nint)obj4 == 3)
				{
					return (byte)(int)"Forbidden" != 0;
				}
				if ((nint)obj4 == 4)
				{
					return (byte)(int)"Not Found" != 0;
				}
				if ((nint)obj4 == 5)
				{
					return (byte)(int)"Method Not Allowed" != 0;
				}
				if ((nint)obj4 == 6)
				{
					return (byte)(int)"Not Acceptable" != 0;
				}
				if ((nint)obj4 == 7)
				{
					return (byte)(int)"Proxy Authentication Required" != 0;
				}
				if ((nint)obj4 == 8)
				{
					return (byte)(int)"Request Time-out" != 0;
				}
				if ((nint)obj4 == 9)
				{
					return (byte)(int)"Conflict" != 0;
				}
				if ((nint)obj4 == 10)
				{
					return (byte)(int)"Gone" != 0;
				}
				if ((nint)obj4 == 11)
				{
					return (byte)(int)"Length Required" != 0;
				}
				if ((nint)obj4 == 12)
				{
					return (byte)(int)"Precondition Failed" != 0;
				}
				if ((nint)obj4 == 13)
				{
					return (byte)(int)"Request Entity Too Large" != 0;
				}
				if ((nint)obj4 == 14)
				{
					return (byte)(int)"Request-URI Too Long" != 0;
				}
				if ((nint)obj4 == 15)
				{
					return (byte)(int)"Unsupported Media Type" != 0;
				}
				if ((nint)obj4 == 16)
				{
					return (byte)(int)"Requested range not satisfiable" != 0;
				}
				if ((nint)obj4 == 17)
				{
					return (byte)(int)"Expectation Failed" != 0;
				}
				object obj5 = response - 500;
				if ((nint)response == 500)
				{
					return (byte)(int)"Internal Server Error" != 0;
				}
				if ((nint)obj5 == 1)
				{
					return (byte)(int)"Not Implemented" != 0;
				}
				if ((nint)obj5 == 2)
				{
					return (byte)(int)"Bad Gateway" != 0;
				}
				if ((nint)obj5 == 3)
				{
					return (byte)(int)"Service Unavailable" != 0;
				}
				if ((nint)obj5 == 4)
				{
					return (byte)(int)"Gateway Time-out" != 0;
				}
				if ((nint)obj5 == 5)
				{
					return (byte)(int)"HTTP Version not supported" != 0;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "Unknown " + text2;
		return (byte)(int)text != 0;
	}

	public static bool IsBson(IResponse response)
	{
		//IL_0072: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Headers headers = default;
		bool flag = headers.Contains("Content-Type");
		if (((string)flag).EndsWith("json"))
		{
			return true;
		}
		return ((string)flag).EndsWith("javascript");
	}

	public static bool IsTexture(IResponse response)
	{
		//IL_0034: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Headers headers = default;
		bool flag = headers.Contains("Content-Type");
		return ((string)flag).EndsWith("application/bson");
	}

	public static Texture2D AsTexture(IResponse response)
	{
		//IL_007a: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Headers headers = default;
		bool flag = headers.Contains("Content-Type");
		if (string.Equals((string)flag, "image/jpeg"))
		{
			return (Texture2D)1;
		}
		bool flag2 = string.Equals((string)flag, "image/png");
		return (Texture2D)flag2;
	}

	public static string AsString(IResponse response)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Texture2D texture2D = default;
				texture2D.ApplyImpl(true, true);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A61");
				object obj2 = default;
				if (obj2 != null)
				{
					return (string)(object)texture2D;
				}
			}
		}
		return null;
	}

	public static bool TryParseJson<T>(IResponse response, out T result, IJsonSerializer jsonSerializer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0041: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj4 = default;
		IJsonSerializer jsonSerializer2 = (IJsonSerializer)obj4;
		return true;
	}

	public static T ParseJson<T>(IResponse response, IJsonSerializer jsonSerializer)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0079: Expected I4, but got Obj
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		object obj = response + 12;
		object obj2 = 1;
		object obj3 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj4 = response + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			if (obj2 == null)
			{
				StringBuilder stringBuilder2 = stringBuilder.AppendLine((string)(object)jsonSerializer);
			}
			StringBuilder stringBuilder3 = stringBuilder.FindChunkForIndex((int)obj6);
			object obj7 = obj3 + 1;
			obj2 = 0;
			obj3 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		T result = default;
		return result;
	}

	public unsafe static bool TryParseBson<T>(IResponse response, out T result, IBsonSerializer bsonSerializer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0138: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj5 = default;
		ref T reference = ref *(T*)obj5;
		return true;
	}

	public static T ParseBson<T>(IResponse response, IBsonSerializer bsonSerializer)
	{
		//IL_006c: Expected Obj, but got I
		//IL_0047: Expected I4, but got Obj
		//IL_007d: Expected VT, but got Obj
		bool flag;
		if (TrustedRoots.VerifyTrust((X509Certificate2)response))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder stringBuilder = default;
			System.DateTimeFormat.HebrewFormatDigits(stringBuilder, (int)"Response data is null or empty.");
			ParseJson<object>((IResponse)(object)stringBuilder, null);
			return (T)null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
		T result = default;
		return result;
	}
}
