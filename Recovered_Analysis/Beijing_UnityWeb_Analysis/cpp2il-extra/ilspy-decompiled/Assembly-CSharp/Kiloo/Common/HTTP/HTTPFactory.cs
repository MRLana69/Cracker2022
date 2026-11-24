using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kiloo.Common.HTTP;

public static class HTTPFactory
{
	public static IRequest CreateGet(Uri uri)
	{
		return (IRequest)(object)uri.m_String;
	}

	public static IRequest CreatePost(Uri uri)
	{
		return CreateRequest("GET", (string)(object)uri);
	}

	public static IRequest CreatePut(Uri uri)
	{
		return CreateRequest("POST", (string)(object)uri);
	}

	public static IRequest CreateDelete(Uri uri)
	{
		return CreateRequest("PUT", (string)(object)uri);
	}

	public static IRequest CreateRequest(string method, Uri uri, byte[] bytes = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0279: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I
		//IL_0328: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(Headers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Kiloo.Common.HTTP.Headers>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Headers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v90 (Il2CppClass<Kiloo.Common.HTTP.Headers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ContentType contentType = ((Headers)(object)uri).contentType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj4 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj5 = obj2 + 4;
		object obj6 = obj5 + 1;
		obj5 = obj6;
		object obj7 = obj6 << 2;
		object obj8 = obj2 + obj7;
		obj8 = 57;
		object obj9 = default;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj2 + obj10;
			if ((nint)obj11 == 57)
			{
				object obj12 = obj2 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_0302;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0302;
		IL_0302:
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S4_v3+60]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S4_v4+48]");
		object obj17 = 0;
		object obj18 = obj17 & 0x7FF;
		object obj19 = obj18 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v229 @ S5_v4 (should have been resolved before IL gen)");
		return (IRequest)(object)method;
	}

	public static IRequest CreateRequest(string method, string uri, byte[] bytes = null)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A508");
		IRequest result = default;
		return result;
	}

	public static IResponse CreateResponse(Headers headers, byte[] bytes)
	{
		//IL_012d: Expected Obj, but got I4
		object obj = 0;
		Headers headers2;
		if (bytes == null)
		{
			headers2 = null;
		}
		else
		{
			headers2 = (Headers)(object)(((object)bytes.GetType() != typeof(DateTime)) ? null : bytes);
		}
		if (headers2 != null)
		{
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		IResponse result = default;
		return result;
	}

	public static IResponse CreateResponse(int status, string message, Headers headers, byte[] bytes)
	{
		//IL_0024: Expected I4, but got Obj
		//IL_0024: Expected VT, but got Obj
		//IL_0024: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DateTime? dateTime = ((Headers)status).Get(message, (DateTime?)(object)headers, (byte)(int)bytes != 0);
		IResponse result = default;
		return result;
	}
}
