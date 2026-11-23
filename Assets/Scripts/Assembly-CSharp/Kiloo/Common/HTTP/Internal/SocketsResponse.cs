using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Utility;

namespace Kiloo.Common.HTTP.Internal;

internal class SocketsResponse : Response
{
	private readonly object _chunksLock;

	private List<byte[]> _chunks;

	public SocketsResponse()
	{
		object chunksLock = default;
		_chunksLock = chunksLock;
		Headers headers = default;
		headers._002Ector();
		base._002Ector(headers, null);
	}

	private string ReadHeaderLine(Stream stream)
	{
		//IL_000d: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_00da: Expected I, but got Obj
		//IL_00ec: Expected I, but got Obj
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a8: Expected I, but got Obj
		MemoryStream memoryStream = default;
		memoryStream._002Ector();
		object obj = default;
		while (true)
		{
			nint num = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S1_v5 (Il2CppClass<System.IO.Stream>)+1C4] (should have been resolved before IL gen)");
			if ((nint)obj < 0)
			{
				break;
			}
			char c = "\r\n".get_Chars(1);
			if ((int)c == (nint)obj)
			{
				break;
			}
			char c2 = "\r\n".get_Chars(0);
			if ((int)c2 != (nint)obj)
			{
				object obj2 = obj & 0xFF;
				nint num2 = (nint)memoryStream;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S2_v13 (Il2CppClass<System.IO.MemoryStream>)+1DC] (should have been resolved before IL gen)");
			}
		}
		Encoding aSCII = ASCIIEncoding.ASCII;
		nint num3 = (nint)memoryStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S2_v6 (Il2CppClass<System.IO.MemoryStream>)+1E4] (should have been resolved before IL gen)");
		nint num4 = (nint)memoryStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S4_v2 (Il2CppClass<System.IO.MemoryStream>)+114] (should have been resolved before IL gen)");
		nint num5 = (nint)aSCII;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S4_v5 (Il2CppClass<System.Text.Encoding>)+1F4] (should have been resolved before IL gen)");
		string text = default;
		return text.Trim();
	}

	private unsafe bool ReadHeader(Stream stream, out string key, out string value)
	{
		//IL_0107: Expected Obj, but got Ref
		//IL_00fa: Expected I4, but got Obj
		string text = ((SocketsResponse)System.Runtime.CompilerServices.Unsafe.AsPointer(ref key)).ReadHeaderLine(stream);
		bool flag = text == string.Empty;
		if (flag)
		{
			ref string reference = ref *(string*)null;
			ref string reference2 = ref *(string*)null;
		}
		else
		{
			int num = text.IndexOf(':');
			if (num == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				HTTPException ex = default;
				ex._002Ector("Invalid header in response");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
				return (byte)(int)ex != 0;
			}
			string text2 = text.Substring(0, num);
			string text3 = text2.Trim();
			ref string reference = ref *(string*)text3;
			int startIndex = num + 1;
			string text4 = text.Substring(startIndex);
			string text5 = text4.Trim();
			ref string reference2 = ref *(string*)text5;
		}
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}

	public new byte[] TakeChunk()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		string text = base.headers__BackingField.get_Item("Content-Encoding");
		byte[] array = default;
		if (!text.Contains("gzip"))
		{
			_ = 0;
			_ = _chunksLock;
			object obj3 = obj + 28;
			object obj4 = obj + 27;
			obj = obj4;
			_ = 0;
			_ = 0;
			object obj5 = obj + 27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				List<byte[]> list = _chunks;
				if (_chunks == null)
				{
					goto IL_027b;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (list._size <= 0)
					{
						goto IL_027b;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag = (nint)0 != 1;
						byte[] array2 = default;
						array = array2;
						if (flag)
						{
							goto IL_027b;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj6 = default;
			object obj7 = default;
			bool flag2 = obj6 != obj7;
			byte[] array3 = default;
			byte[] result = array3;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag3 = (nint)0 == 1;
				array = null;
				if (!flag3)
				{
					goto IL_027b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				byte[] array4 = default;
				result = array4;
			}
			_ = 0;
			object obj8 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		return array;
		IL_027b:
		throw new ArgumentNullException();
	}

	public new unsafe void ReadFromStream(Stream inputStream, bool ignoreContentMd5 = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1c: Expected Ref, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Ref, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Ref, but got Unknown
		//IL_00f4: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_09a4: Expected I8, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Expected Obj, but got Unknown
		//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d69: Expected Obj, but got Unknown
		//IL_0a73: Expected Obj, but got I4
		//IL_0a57: Expected Obj, but got I4
		object obj = default;
		SocketsResponse socketsResponse = (SocketsResponse)(obj - 96);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		string text = socketsResponse.ReadHeaderLine(inputStream);
		string[] array = text.Split(' ');
		byte[] array4 = default;
		string text4;
		object obj11;
		object obj6;
		if (int.TryParse(array[1], out *(int*)(socketsResponse + 92)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.Internal.SocketsResponse)+5C]");
			base.status__BackingField = 0;
			int count = array.Length - 2;
			string text2 = string.Join(" ", array, 2, count);
			base.message__BackingField = text2;
			base.headers__BackingField.Clear();
			while (socketsResponse.ReadHeader(inputStream, out *(string*)(socketsResponse + 88), out *(string*)(socketsResponse + 84)))
			{
				Headers headers = base.headers__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.Internal.SocketsResponse)+58]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.Internal.SocketsResponse)+54]");
				Headers headers2 = headers.Add((string)num, 0);
			}
			string text3 = base.headers__BackingField.get_Item("Transfer-Encoding");
			if (text3 == "chunked")
			{
				_ = 0;
				_ = _chunksLock;
				object obj2 = socketsResponse + 72;
				List<byte[]> list = (List<byte[]>)(socketsResponse + 71);
				socketsResponse._chunks = list;
				((Response)socketsResponse).message__BackingField = null;
				((Response)socketsResponse).bytes__BackingField = (byte[])(object)socketsResponse._chunks;
				_ = 0;
				object obj3 = socketsResponse + 71;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							List<byte[]> list2 = default;
							_chunks = list2;
							goto IL_0329;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj4 = default;
				object obj5 = default;
				bool flag = obj4 != obj5;
				object obj7 = default;
				obj6 = obj7;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					object obj8 = default;
					((Response)socketsResponse).message__BackingField = (string)obj8;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_0329;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj9 = default;
					obj6 = obj9;
				}
				_ = 0;
				object obj10 = socketsResponse + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0d9e;
				}
				goto IL_0e7c;
			}
			long num2 = base.headers__BackingField.Get("Content-Length", 0L);
			if (num2 < 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				byte[] array2 = default;
				base.bytes__BackingField = array2;
				return;
			}
			bool flag2 = num2 >= 2147483648L;
			string[] array3 = (string[])(object)base.headers__BackingField;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				FileUtil.ReadFully(inputStream, array4);
				text4 = base.headers__BackingField.Get("Content-MD5");
				if (text4 != null)
				{
					obj11 = 0;
					if (text4._stringLength != 0)
					{
						goto IL_0fea;
					}
				}
				obj11 = 1;
				goto IL_0fea;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			HTTPException ex = default;
			ex._002Ector("Bad Status Code in response");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			string[] array3 = array;
		}
		OverflowException ex2 = new OverflowException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		goto IL_0ff8;
		IL_0e7c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		return;
		IL_0d9e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0e7c;
		IL_0ff8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		HTTPException ex3 = default;
		ex3._002Ector("Content-MD5 digest mismatch. Data is corrupted.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		HTTPException ex4 = ex3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj13 = default;
		object obj12 = obj13;
		object obj14 = default;
		obj6 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj15 = default;
		if (obj15 == obj12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			object obj16 = default;
			socketsResponse._chunks = (List<byte[]>)obj16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				throw new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj17 = default;
			obj6 = obj17;
		}
		_ = 0;
		object obj18 = socketsResponse + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			goto IL_0d9e;
		}
		goto IL_0e7c;
		IL_0329:
		throw new ArgumentNullException();
		IL_0fea:
		if (obj11 == null)
		{
			byte[] inArray = Checksum.ComputeMD5(array4);
			string text5 = Convert.ToBase64String(inArray);
			if (text5 != text4)
			{
				bool flag3 = !ignoreContentMd5;
				string[] array3 = (string[])(object)text4;
				if (flag3)
				{
					goto IL_0ff8;
				}
			}
		}
		string text6 = base.headers__BackingField.get_Item("Content-Encoding");
		if (text6.Contains("gzip"))
		{
			byte[] array5 = Util.UnZip(array4);
			base.bytes__BackingField = array5;
		}
		else
		{
			base.bytes__BackingField = array4;
		}
	}

	private static void LogWarning(string msg)
	{
	}

	private static void LogVerbose(string msg)
	{
	}
}
