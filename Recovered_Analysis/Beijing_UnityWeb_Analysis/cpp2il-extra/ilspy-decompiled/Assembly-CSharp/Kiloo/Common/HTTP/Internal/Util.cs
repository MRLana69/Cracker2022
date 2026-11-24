using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Ionic.Zlib;
using UnityEngine;
using UnityEngine.Networking;

namespace Kiloo.Common.HTTP.Internal;

internal class Util
{
	public const string EOL = "\r\n";

	public static int ConvertTimeoutToMilliseconds(float seconds)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D785");
		int result = default;
		return result;
	}

	public unsafe static bool IsTextContentType(Headers headers)
	{
		//IL_026a: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I4
		//IL_02df: Expected Obj, but got I4
		//IL_02e7: Expected Obj, but got I4
		//IL_02f5: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_0230: Expected I4, but got Obj
		//IL_023c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1137D");
		object obj = default;
		bool flag = obj == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [headers @ L0 (Kiloo.Common.HTTP.Headers)+4C]");
		UnityWebRequest unityWebRequest = (UnityWebRequest)0;
		if (flag)
		{
			string url = unityWebRequest.url;
			bool flag2 = url == null || url.m_stringLength == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string msg = ((!flag2) ? url : "Unknown error");
			HTTPRequestCanceledException ex = default;
			ex._002Ector(msg);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		string text = unityWebRequest.m_DownloadHandler.text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1137D");
		IResponse response = default;
		bool flag3 = ResponseExtensions.IsJson(response);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text2 = default;
		RequestExtensions.LogError(text2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [headers @ L0 (Kiloo.Common.HTTP.Headers)+4C]");
		UploadHandler uploadHandler = ((UnityWebRequest)0).uploadHandler;
		if (uploadHandler != null)
		{
			string text3 = ((Headers)(object)text2).Get((string)(object)uploadHandler);
		}
		bool flag4 = ((Headers)(object)text2).Contains("Content-Encoding");
		bool flag5 = string.Equals("gzip", (string)flag4, StringComparison.OrdinalIgnoreCase);
		bool flag6 = !flag5;
		string text4 = text;
		if (!flag6)
		{
			object obj2 = text + 16;
			bool flag7 = (nint)obj2 == 31;
			bool flag8 = !flag7;
			text4 = text;
			if (!flag8)
			{
				object obj3 = text + 17;
				bool flag9 = (nint)obj3 == 139;
				bool flag10 = !flag9;
				text4 = text;
				if (!flag10)
				{
					bool flag11 = ((Headers)(object)text2).Contains("Content-Length");
					TypeCode typeCode = (flag11 ? ((int*)1) : ((int*)null))->GetTypeCode();
					bool flag12 = (TypeCode)text.m_firstChar == typeCode;
					bool flag13 = !flag12;
					text4 = text;
					if (!flag13)
					{
						ResponseCategory responseCategory = GetResponseCategory((int)text);
						text4 = (string)responseCategory;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		bool flag14 = default;
		object obj4 = (flag14 ? 1 : 0) + 12;
		obj4 = flag3;
		object obj5 = (flag14 ? 1 : 0) + 20;
		obj5 = text2;
		object obj6 = (flag14 ? 1 : 0) + 16;
		obj6 = text4;
		return flag14;
	}

	public static bool IsPrintable(byte[] bytes, int maxScan = 256)
	{
		//IL_00e0: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_016d: Expected I4, but got Obj
		//IL_0121: Expected I, but got Obj
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		object obj = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			if ((nint)obj < 0)
			{
				break;
			}
			string[] array = "\r\n".Split((char[])1);
			object obj2 = array & 0xFFFF;
			if (obj == obj2)
			{
				break;
			}
			string[] array2 = "\r\n".Split(null);
			object obj3 = array2 & 0xFFFF;
			if (obj != obj3)
			{
				object obj4 = obj & 0xFF;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
		}
		nint num = (nint)typeof(ASCIIEncoding);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v14 (Il2CppClass<ASCIIEncoding>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(ASCIIEncoding);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v21 (Il2CppClass<ASCIIEncoding>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		string str = default;
		return (byte)(int)string.Copy(str) != 0;
	}

	public unsafe static string ContentAsString(byte[] bytes, Headers headers, int maxChars = int.MaxValue)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = bytes;
		object obj2 = text + 36;
		obj2 = headers;
		object obj3 = ((int*)maxChars)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [maxChars @ L2 (System.Int32)+8]");
		_ = 0;
		object obj4 = text + 20;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return text;
	}

	public static string ContentAsString(byte[] bytes, Headers headers, int maxChars, out int totalCharCount)
	{
		//IL_0104: Expected I4, but got Obj
		//IL_0116: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		//IL_00f5: Expected I4, but got Obj
		bool flag = IsPrintable(null, (int)headers);
		if ((string)flag != "")
		{
			Headers headers2 = (Headers)0;
			totalCharCount.m_value = 0;
		}
		else
		{
			int num = ((string)flag).IndexOfAny((char[])58);
			if (num == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				HTTPRequestCanceledException ex = default;
				ex._002Ector("Invalid header in response");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			else
			{
				string str = ((string)flag).InternalSubString(0, num);
				string text = string.Copy(str);
				Headers headers2 = (Headers)(object)text;
				char[] trimChars = (char[])(num + 1);
				string str2 = ((string)flag).Trim(trimChars);
				string text2 = string.Copy(str2);
				totalCharCount.m_value = (int)text2;
			}
		}
		return (string)1;
	}

	public unsafe static string ContentAsHex(byte[] bytes, Headers headers, int bytesPerLine, int maxLines = 0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (bytes != null)
		{
			string text = headers.ToString();
			string text2 = ((Headers)(object)text).get_Item("charset");
			if (text2 != null && text2.m_stringLength != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj3 = default;
				object obj4 = default;
				if (obj3 == obj4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj6 = default;
					object obj5 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj8 = default;
					object obj7 = obj8;
				}
				else
				{
					object obj9 = default;
					object obj7 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			else
			{
				Encoding uTF = Encoding.UTF32;
				Encoding encoding = uTF;
			}
			if (bytesPerLine == int.MaxValue)
			{
				object obj10 = bytes + 12;
				object obj11 = obj10;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj12 = bytes + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
				int num = default;
				((int*)maxLines)->m_value = num;
				bool flag = num > bytesPerLine;
				bool flag2 = !flag;
				object obj11 = obj12;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					object obj13 = default;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
					{
						obj13 = obj12;
						object obj14 = obj12;
					}
					else
					{
						object obj14 = obj13;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A626");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D975");
					string result = default;
					return result;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			string text3 = default;
			((int*)maxLines)->m_value = text3.m_stringLength;
			return text3;
		}
		((int*)maxLines)->m_value = 0;
		return null;
	}

	public static string PrintableContent(byte[] bytes, Headers headers, int maxChars, int maxHexLines)
	{
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_0410: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I4
		//IL_0303: Expected Obj, but got I4
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0334: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected I4, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected I4, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_01b0: Expected Obj, but got I4
		object obj = bytes + 12;
		object obj2 = maxChars + obj;
		object obj3 = obj2 - 1;
		bool flag = maxHexLines == 0;
		int num;
		if (maxChars != 0)
		{
			bool flag2 = (nint)obj3 == int.MinValue;
			bool flag3 = maxChars == -1;
			object obj4 = flag2 & flag3;
			num = ((obj4 == null) ? (obj3 / maxChars) : 0);
		}
		else
		{
			num = 0;
		}
		bool flag4 = num < maxHexLines;
		object obj5 = flag | flag4;
		bool flag5 = obj5 == null;
		bool flag6 = !flag5;
		int num2 = num;
		if (!flag6)
		{
			num2 = maxHexLines;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj6 = maxChars << 2;
		object obj7 = obj6 + 10;
		string value = (string)(num2 * obj7);
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(value);
		object obj8 = 0;
		object obj9 = default;
		object[] args = default;
		object[] args2 = default;
		object obj23 = default;
		while ((nint)obj9 < num2)
		{
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			StringBuilder stringBuilder2 = stringBuilder.AppendFormat("{0:X8} ", args);
			object obj11 = maxChars + obj8;
			bool flag7 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			bool flag8 = !flag7;
			object obj12 = obj;
			if (!flag8)
			{
				obj12 = obj11;
			}
			object obj13 = obj8;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				object obj14 = bytes + 16;
				object obj15 = obj14 + obj13;
				obj10 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				StringBuilder stringBuilder3 = stringBuilder.AppendFormat("{0:X2} ", args2);
				object obj16 = obj13 + 1;
				obj13 = obj16;
			}
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				object obj17 = bytes + 16;
				object obj18 = obj17 + obj8;
				object obj19;
				if ((nint)obj18 < 32)
				{
					obj19 = 46;
				}
				else
				{
					object obj20 = bytes + 16;
					object obj21 = obj20 + obj8;
					obj19 = obj21;
				}
				int value2 = obj19 & 0xFFFF;
				StringBuilder stringBuilder4 = stringBuilder.Append(value2);
				object obj22 = obj8 + 1;
				obj8 = obj22;
			}
			StringBuilder stringBuilder5 = stringBuilder.Append(10);
			obj9 = obj23 + 1;
			obj8 = obj12;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj24 = obj - obj8;
			object obj10 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string value3 = "\n--truncated " + text + " more bytes--";
			StringBuilder stringBuilder6 = stringBuilder.AppendLine(value3);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string result = default;
		return result;
	}

	public static byte[] UnZip(byte[] data)
	{
		//IL_00ff: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		string text = ((Headers)(object)data).ToString();
		byte[] result;
		if ((string)text.m_stringLength != "text")
		{
			result = (byte[])1;
		}
		else
		{
			string text2 = ((Headers)(object)data).ToString();
			if (!((string)text2.m_stringLength != "application"))
			{
				goto IL_00d5;
			}
			string text3 = ((Headers)(object)data).ToString();
			bool flag = ((string)text3.m_firstChar).EndsWith("json");
			result = (byte[])1;
			if (!flag)
			{
				string text4 = ((Headers)(object)data).ToString();
				bool flag2 = ((string)text4.m_firstChar).EndsWith("javascript");
				result = (byte[])1;
				if (!flag2)
				{
					goto IL_00d5;
				}
			}
		}
		goto IL_011c;
		IL_00d5:
		result = null;
		goto IL_011c;
		IL_011c:
		return result;
	}

	public static ResponseCategory GetResponseCategory(int status)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0025: Expected VT, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		//IL_0046: Expected I4, but got Obj
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00e6: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PathTooLongException ex = default;
		ex._002Ector((SerializationInfo)status, (StreamingContext)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		short[] array = default;
		Tree.gen_codes(array, (int)ex, (short[])1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj4 = default;
		object obj3 = obj4 + 12;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			if ((nint)obj5 < 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		}
		object obj6 = obj2 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj2 + obj8;
		obj9 = 70;
		if (array != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj2 + obj10;
			if ((nint)obj11 == 70)
			{
				object obj12 = obj2 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_02ad;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_02ad;
		IL_02ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		ResponseCategory result = default;
		return result;
	}

	public Util()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[UnityRequest] ", (int)this);
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
}
