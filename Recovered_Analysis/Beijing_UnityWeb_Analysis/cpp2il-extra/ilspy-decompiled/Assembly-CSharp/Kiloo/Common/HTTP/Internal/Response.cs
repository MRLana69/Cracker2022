using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Kiloo.Common.HTTP.Internal;

internal class Response : IResponse
{
	private int status__BackingField;

	private string message__BackingField;

	private byte[] bytes__BackingField;

	private Headers headers__BackingField;

	public unsafe int status
	{
		get
		{
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected Obj, but got Unknown
			//IL_013b: Expected Obj, but got I4
			//IL_00f0: Expected Obj, but got I
			//IL_0015: Expected Obj, but got I
			//IL_015f: Expected I4, but got Obj
			object obj2 = default;
			object obj = obj2 + 4;
			obj = 0;
			string text2;
			if (headers__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Response)+18]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				string format = default;
				object arg = default;
				object arg2 = default;
				string text = string.Format((IFormatProvider)(object)"{0}, {1}: {2}", format, arg, arg2);
				text2 = text;
			}
			else
			{
				if (message__BackingField == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Response)+18]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					throw new NullReferenceException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj3 = default;
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				string format2 = default;
				object arg3 = default;
				string text3 = string.Format((IFormatProvider)(object)"{0}: {1}", format2, arg3);
				text2 = text3;
			}
			return (int)text2;
		}
		internal set
		{
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Expected Obj, but got Unknown
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Expected VT, but got Unknown
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Expected Obj, but got Unknown
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Expected Obj, but got Unknown
			//IL_02a1: Expected Obj, but got I4
			//IL_02b2: Invalid comparison between I and F4
			//IL_03a0: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Expected Obj, but got Unknown
			//IL_02ed: Expected Obj, but got I8
			//IL_0302: Expected I8, but got Obj
			//IL_02fd: Expected native int or pointer, but got VT
			//IL_0317: Expected Ref, but got VT
			//IL_0323: Expected Obj, but got I8
			//IL_0347: Invalid comparison between F8 and I
			//IL_011e: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_0228: Expected Obj, but got I4
			//IL_0176: Expected Obj, but got I4
			//IL_01e8: Expected Obj, but got I4
			object obj = default;
			IFormatProvider formatProvider = (IFormatProvider)(obj + 32);
			DateTime dateTime = (DateTime)(obj + 24);
			object obj2 = obj + 8;
			object obj3 = obj + 16;
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Response)+20]");
			if (0f > 0f)
			{
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v60 (Il2CppClass<System.DateTime>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num2 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v79 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
				object obj5 = this - -64;
				obj2 = systemTimeAsFileTime;
				obj = obj5;
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
				formatProvider = (IFormatProvider)obj;
				long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
				obj3 = num3;
				double num4 = (double)obj3 * 1E-07;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Response)+20]");
				if (num4 > 0.0)
				{
					_ = 5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Response)+18]");
			object obj6 = -3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Response)+18]");
			bool flag;
			if ((nint)0 == 3 || ((nint)obj6 != 1 && (nint)obj6 != 2 && (nint)obj6 == 3))
			{
				flag = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Response)+18]");
				object obj7 = (nint)0 | (nint)1;
				flag = (nint)obj7 == 5;
			}
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Response)+18]");
				if ((nint)0 == 4)
				{
					object obj8 = ((IConvertible)"Request was canceled (").ToType((Type)value, (IFormatProvider)(object)")");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					HTTPSecurityException ex = default;
					ex._002Ector((string)obj8);
					((Request)(object)ex).AssertNotCanceled((string)null);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.Internal.Response)+18]");
				HTTPRequestCanceledException ex3;
				if ((nint)0 == 5)
				{
					object obj9 = ((IConvertible)"Request was canceled because it failed to complete in time (").ToType((Type)value, (IFormatProvider)(object)")");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					HTTPSecurityException ex2 = default;
					ex2._002Ector((string)obj9);
					ex3 = (HTTPRequestCanceledException)(object)ex2;
				}
				else
				{
					object msg = ((IConvertible)"Unexpected request state (").ToType((Type)value, (IFormatProvider)(object)")");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					HTTPRequestCanceledException ex4 = default;
					ex4._002Ector((string)msg);
					ex3 = ex4;
				}
				((Request)(object)ex3).AssertNotCanceled((string)null);
			}
		}
	}

	public string message
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)status__BackingField;
		}
		internal set
		{
			//IL_000a: Expected I4, but got Obj
			status__BackingField = (int)value;
		}
	}

	public byte[] bytes
	{
		get
		{
			return (byte[])(object)message__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
		}
	}

	public Headers headers
	{
		get
		{
			return (Headers)(object)bytes__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}

	public ResponseCategory category
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (ResponseCategory)headers__BackingField;
		}
	}

	public unsafe Response(int status, string message, Headers headers, byte[] bytes)
	{
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected VT, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got I4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I4
		//IL_02dd: Expected Obj, but got I4
		//IL_0269: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_033c: Expected Obj, but got I4
		//IL_033c: Expected I4, but got Obj
		//IL_00e2: Expected I, but got Obj
		//IL_012a: Expected Obj, but got I4
		//IL_014a: Expected I8, but got Obj
		//IL_0145: Expected native int or pointer, but got VT
		//IL_014f: Expected native int or pointer, but got Obj
		//IL_0195: Expected Obj, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01cd: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I8
		//IL_0382: Expected Obj, but got I4
		//IL_03a2: Expected I8, but got Obj
		//IL_039d: Expected native int or pointer, but got VT
		//IL_03a7: Expected native int or pointer, but got Obj
		//IL_020e: Expected I, but got Obj
		object obj = default;
		DateTime dateTime = (DateTime)(obj + 40);
		object obj2 = obj + 16;
		CultureInfo cultureInfo = (CultureInfo)(obj + 32);
		cultureInfo = (CultureInfo)0;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 24);
		formatProvider = (IFormatProvider)0;
		object obj3 = obj + 8;
		obj3 = 0;
		Headers headers2 = ((Headers)status).Set(message, null);
		Response response;
		if (headers2 != null)
		{
			nint num = (nint)typeof(DateTimeFormatInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v27 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(DateTimeFormatInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v84 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTimeFormatInfo currentInfo = DateTimeFormatInfo.CurrentInfo;
			string shortDatePattern = currentInfo.ShortDatePattern;
			DateTimeFormatInfo currentInfo2 = DateTimeFormatInfo.CurrentInfo;
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v37 (Il2CppClass<System.DateTime>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v80 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FieldInfo fieldInfo = ((System.DefaultBinder)(object)headers2).BindToField((BindingFlags)shortDatePattern, (FieldInfo[])(object)currentInfo2, (object)16, cultureInfo);
			if ((object)fieldInfo != null)
			{
				response = (Response)0;
				this.status__BackingField = 0;
				obj2 = cultureInfo;
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
				*(DateTime?*)(nint)this = dateTime;
				return;
			}
			if (bytes != null)
			{
				bool flag = ((long*)headers2)->System_002EIConvertible_002EToBoolean(formatProvider);
				object obj6 = (flag ? 1 : 0) ^ 1;
				bool flag2 = (nint)formatProvider < 0;
				object obj7 = flag2 | obj6;
				if (obj7 == null)
				{
					nint num5 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v53 (Il2CppClass<System.DateTime>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num6 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v67 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
					obj3 = systemTimeAsFileTime;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA5");
					response = (Response)0;
					this.status__BackingField = 0;
					object obj9 = default;
					obj = obj9;
					((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj;
					*(DateTime?*)(nint)this = dateTime;
					return;
				}
			}
		}
		response = (Response)(object)headers;
		this.status__BackingField = (int)headers._headers;
	}

	public Response(Headers headers, byte[] bytes)
	{
		//IL_1025: Unknown result type (might be due to invalid IL or missing references)
		//IL_102a: Expected Obj, but got Unknown
		//IL_1033: Unknown result type (might be due to invalid IL or missing references)
		//IL_1038: Expected Obj, but got Unknown
		//IL_1041: Unknown result type (might be due to invalid IL or missing references)
		//IL_1046: Expected Obj, but got Unknown
		//IL_104f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1054: Expected Obj, but got Unknown
		//IL_0f9c: Expected I, but got Obj
		//IL_0fb2: Expected Obj, but got I
		//IL_0f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f80: Expected Obj, but got Unknown
		//IL_0f89: Expected Obj, but got I4
		//IL_0036: Expected I, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_0fdd: Expected I, but got Obj
		//IL_1084: Expected Obj, but got VT
		//IL_10af: Expected Obj, but got I8
		//IL_10cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1: Expected Obj, but got Unknown
		//IL_10de: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e3: Expected Obj, but got Unknown
		//IL_0077: Expected I, but got Obj
		//IL_1143: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Expected Obj, but got Unknown
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Expected Obj, but got Unknown
		//IL_0d4d: Expected Obj, but got I4
		//IL_0d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7e: Expected Obj, but got Unknown
		//IL_0d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Expected Obj, but got Unknown
		//IL_0db9: Expected I, but got Obj
		//IL_0dcf: Expected Obj, but got I
		//IL_117b: Expected Obj, but got I
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Expected Obj, but got Unknown
		//IL_0f45: Expected Obj, but got I4
		//IL_0dfa: Expected I, but got Obj
		//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e73: Expected Obj, but got Unknown
		//IL_0ea0: Expected I, but got Obj
		//IL_0eb6: Expected Obj, but got I
		//IL_11b1: Expected Obj, but got I
		//IL_11cb: Expected Obj, but got I
		//IL_0ee1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj6 = default;
		Headers headers2 = default;
		bool flag6;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v42 (Il2CppClass<System.DateTime>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v110 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = DateTime.MinValue;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4E5");
			long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
			object obj8 = default;
			obj5 = obj8;
			obj2 = systemTimeAsFileTime;
			obj3 = obj5;
			obj = obj2;
			object obj9 = obj3 & 0x3FFFFFFFFFFFFFFFL;
			object obj10 = obj & 0x3FFFFFFFFFFFFFFFL;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
			bool flag2 = headers2.Contains("ETag");
			bool flag3 = headers2.Contains("Last-Modified");
			bool flag4;
			if (flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v66 (System.Boolean)+8]");
				flag4 = (nint)0 == 0;
			}
			else
			{
				flag4 = true;
			}
			if (flag4)
			{
				bool flag5;
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v68 (System.Boolean)+8]");
					flag5 = (nint)0 == 0;
				}
				else
				{
					flag5 = true;
				}
				if (flag5)
				{
					flag6 = flag;
					goto IL_113a;
				}
			}
			flag6 = true;
			goto IL_113a;
		}
		if (bytes == null)
		{
			object obj11 = headers + 12;
			obj11 = 0;
			return;
		}
		nint num3 = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v23 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v29 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WebClient.Log("No response - using cached version");
		return;
		IL_113a:
		object obj14 = default;
		object obj13 = obj14 - 200;
		if ((nint)obj14 != 200)
		{
			if ((nint)obj13 != 1 && (nint)obj13 != 2 && (nint)obj13 != 3 && (nint)obj13 != 4 && (nint)obj13 != 5 && (nint)obj13 != 6 && (nint)obj13 != 7 && (nint)obj13 != 8 && (nint)obj13 != 9 && (nint)obj13 != 10 && (nint)obj13 != 11 && (nint)obj13 != 12 && (nint)obj13 != 13 && (nint)obj13 != 14 && (nint)obj13 != 15 && (nint)obj13 != 16 && (nint)obj13 != 17 && (nint)obj13 != 18 && (nint)obj13 != 19 && (nint)obj13 != 20 && (nint)obj13 != 21 && (nint)obj13 != 22 && (nint)obj13 != 23 && (nint)obj13 != 24 && (nint)obj13 != 25 && (nint)obj13 != 26 && (nint)obj13 != 27 && (nint)obj13 != 28 && (nint)obj13 != 29 && (nint)obj13 != 30 && (nint)obj13 != 31 && (nint)obj13 != 32 && (nint)obj13 != 33 && (nint)obj13 != 34 && (nint)obj13 != 35 && (nint)obj13 != 36 && (nint)obj13 != 37 && (nint)obj13 != 38 && (nint)obj13 != 39 && (nint)obj13 != 40 && (nint)obj13 != 41 && (nint)obj13 != 42 && (nint)obj13 != 43 && (nint)obj13 != 44 && (nint)obj13 != 45 && (nint)obj13 != 46 && (nint)obj13 != 47 && (nint)obj13 != 48 && (nint)obj13 != 49 && (nint)obj13 != 50 && (nint)obj13 != 51 && (nint)obj13 != 52 && (nint)obj13 != 53 && (nint)obj13 != 54 && (nint)obj13 != 55 && (nint)obj13 != 56 && (nint)obj13 != 57 && (nint)obj13 != 58 && (nint)obj13 != 59 && (nint)obj13 != 60 && (nint)obj13 != 61 && (nint)obj13 != 62 && (nint)obj13 != 63 && (nint)obj13 != 64 && (nint)obj13 != 65 && (nint)obj13 != 66 && (nint)obj13 != 67 && (nint)obj13 != 68 && (nint)obj13 != 69 && (nint)obj13 != 70 && (nint)obj13 != 71 && (nint)obj13 != 72 && (nint)obj13 != 73 && (nint)obj13 != 74 && (nint)obj13 != 75 && (nint)obj13 != 76 && (nint)obj13 != 77 && (nint)obj13 != 78 && (nint)obj13 != 79 && (nint)obj13 != 80 && (nint)obj13 != 81 && (nint)obj13 != 82 && (nint)obj13 != 83 && (nint)obj13 != 84 && (nint)obj13 != 85 && (nint)obj13 != 86 && (nint)obj13 != 87 && (nint)obj13 != 88 && (nint)obj13 != 89 && (nint)obj13 != 90 && (nint)obj13 != 91 && (nint)obj13 != 92 && (nint)obj13 != 93 && (nint)obj13 != 94 && (nint)obj13 != 95 && (nint)obj13 != 96 && (nint)obj13 != 97 && (nint)obj13 != 98 && (nint)obj13 != 99 && (nint)obj13 != 100 && (nint)obj13 != 101 && (nint)obj13 != 102 && (nint)obj13 != 103 && (nint)obj13 == 104)
			{
				if (headers._contentType == null)
				{
					return;
				}
				object obj15 = headers._contentType + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj16 = default;
				obj15 = obj16;
				string contentType = headers._contentType;
				nint num5 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S1_v66 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num6 = (nint)typeof(WebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S1_v73 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v93 (System.String)+14]");
				WebClient.SaveCacheMetaData((string)0, (WebClient.CacheMetaData)(object)headers2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [headers @ L1 (Kiloo.Common.HTTP.Headers)+14]");
				WebClient.SaveCacheContents((string)0, (byte[])(object)headers._contentType);
			}
			else if (bytes == null)
			{
				object obj18 = headers + 12;
				obj18 = 0;
			}
			return;
		}
		object obj19 = headers + 12;
		obj19 = 0;
		if (!flag6)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		byte[] array = default;
		object obj20 = array + 20;
		obj20 = headers2;
		object obj21 = array + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj22 = default;
		obj21 = obj22;
		nint num7 = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S1_v49 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num8 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S1_v56 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [headers @ L1 (Kiloo.Common.HTTP.Headers)+14]");
		WebClient.SaveCacheContents((string)0, array);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		string host = default;
		((Connection)(object)headers._parsedContentType).host = host;
	}
}
