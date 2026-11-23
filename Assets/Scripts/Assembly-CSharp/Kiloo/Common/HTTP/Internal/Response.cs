using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Ionic.Zlib;
using Kiloo.Common.Utility;

namespace Kiloo.Common.HTTP.Internal;

internal class Response : IResponse
{
	private const string EOL = "\r\n";

	private List<byte[]> chunks;

	private int status__BackingField;

	private string message__BackingField;

	private byte[] bytes__BackingField;

	private Headers headers__BackingField;

	public int status
	{
		get
		{
			return status__BackingField;
		}
		internal set
		{
			status__BackingField = value;
		}
	}

	public string message
	{
		get
		{
			return message__BackingField;
		}
		internal set
		{
			message__BackingField = value;
		}
	}

	public byte[] bytes
	{
		get
		{
			return bytes__BackingField;
		}
		internal set
		{
			bytes__BackingField = value;
		}
	}

	public Headers headers
	{
		get
		{
			return headers__BackingField;
		}
		internal set
		{
			headers__BackingField = value;
		}
	}

	public ResponseCategory category
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_005c: Expected VT, but got Obj
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ResponseCategory));
			int num = status__BackingField / 100;
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value = default;
			bool flag = Enum.IsDefined(typeFromHandle, value);
			ResponseCategory result = (ResponseCategory)num;
			if (!flag)
			{
				result = ResponseCategory.Unknown;
			}
			return result;
		}
	}

	public Response(int status, string message, Headers headers, byte[] bytes)
	{
		this.message__BackingField = message;
		this.status__BackingField = status;
		this.headers__BackingField = headers;
		this.bytes__BackingField = bytes;
	}

	public Response(Headers headers, byte[] bytes)
	{
		message__BackingField = "OK";
		status__BackingField = 200;
		this.headers__BackingField = headers;
		this.bytes__BackingField = bytes;
	}

	public Response()
	{
		Headers headers = default;
		headers._002Ector();
		this._002Ector(headers, null);
	}

	public static string ContentAsString(byte[] bytes, Headers headers)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I
		//IL_03fa: Expected I, but got Obj
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		//IL_03df: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I4
		//IL_021c: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		byte[] array = default;
		bool flag = array == null;
		string result = null;
		object obj6;
		if (!flag)
		{
			IDictionary<string, string> contentType = headers.contentType;
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
			object obj4 = default;
			if (obj4 == null)
			{
				goto IL_033f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != 0)
			{
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v28+8]");
				if ((nint)0 != 0)
				{
					goto IL_03c1;
				}
			}
			obj6 = 1;
			goto IL_03c1;
		}
		goto IL_03ed;
		IL_033f:
		Encoding uTF = Encoding.UTF8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		byte[] array2 = (byte[])0;
		Encoding encoding = uTF;
		goto IL_03f2;
		IL_03ed:
		return result;
		IL_03f2:
		nint num = (nint)encoding;
		object obj7 = encoding + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ S4_v5 (Il2CppClass<System.Text.Encoding>)+1F4] (should have been resolved before IL gen)");
		string text = default;
		result = text;
		goto IL_03ed;
		IL_038d:
		string result2 = default;
		return result2;
		IL_03c1:
		if (obj6 == null)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 == 1;
			bool flag3 = !flag2;
			Encoding encoding2 = default;
			encoding = encoding2;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj8 = default;
				object obj9 = default;
				bool flag4 = obj8 == obj9;
				bool flag5 = !flag4;
				Encoding encoding3 = default;
				encoding = encoding3;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj11 = default;
						object obj10 = obj11;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj12 = default;
							if (obj12 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj13 = (nint)0 << 2;
								object obj14 = obj + obj13;
								obj14 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj15 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj16 = -1;
								goto IL_033f;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj17 = obj11;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag6 = (nint)0 != 1;
							result2 = (string)flag6;
							if (flag6)
							{
								goto IL_038d;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag7 = (nint)0 == 1;
					Encoding encoding4 = default;
					encoding = encoding4;
					if (flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						goto IL_038d;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			array2 = (byte[])0;
			if (encoding != null)
			{
				goto IL_03f2;
			}
		}
		goto IL_033f;
	}

	public override string ToString()
	{
		string text = ContentAsString(bytes__BackingField, headers__BackingField);
		if (text == null)
		{
			text = string.Empty;
		}
		return text;
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
		string text = ((Response)System.Runtime.CompilerServices.Unsafe.AsPointer(ref key)).ReadHeaderLine(stream);
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

	public byte[] TakeChunk()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = chunks;
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
			List<byte[]> list = chunks;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (list._size <= 0)
				{
					byte[] array = null;
					goto IL_0344;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				byte[] array2 = default;
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 != 1;
					byte[] array = array2;
					if (flag)
					{
						goto IL_0344;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					array = array2;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					byte[] array = array2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				byte[] array = null;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			byte[] array = (byte[])0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag2 = obj6 == obj7;
		bool flag3 = !flag2;
		object obj9 = default;
		object obj8 = obj9;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			byte[] array = null;
			if (flag4)
			{
				goto IL_0344;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj10 = default;
			obj8 = obj10;
			array = null;
		}
		_ = 0;
		object obj11 = obj + 8;
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
		goto IL_0344;
		IL_0344:
		throw new ArgumentNullException();
	}

	public unsafe void ReadFromStream(Stream inputStream, bool ignoreContentMD5 = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Expected Ref, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Ref, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Ref, but got Unknown
		//IL_00f4: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_07e7: Expected I8, but got I4
		//IL_0e1e: Expected Obj, but got I4
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected Obj, but got Unknown
		//IL_059f: Expected I4, but got Obj
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected Obj, but got Unknown
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected Ref, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected Ref, but got Unknown
		//IL_08ac: Expected Obj, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01eb: Expected I4, but got Obj
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0a3c: Expected Obj, but got I
		//IL_0a3c: Expected Obj, but got I
		//IL_0a49: Expected Obj, but got I4
		//IL_0890: Expected Obj, but got I4
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected Obj, but got Unknown
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Expected Obj, but got Unknown
		//IL_0b1b: Expected I4, but got Obj
		//IL_0aa5: Expected Obj, but got I4
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected Obj, but got Unknown
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea3: Expected Obj, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c83: Expected Obj, but got Unknown
		//IL_0ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce6: Expected Obj, but got Unknown
		object obj = default;
		Response response = (Response)(obj - 80);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Stream stream = default;
		string text = response.ReadHeaderLine(stream);
		string[] array = text.Split(' ');
		byte[] array3 = default;
		string text5;
		object obj19;
		if (int.TryParse(array[1], out *(int*)(response + 76)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.Internal.Response)+4C]");
			status__BackingField = 0;
			int count = array.Length - 2;
			string text2 = string.Join(" ", array, 2, count);
			message__BackingField = text2;
			this.headers__BackingField.Clear();
			bool flag;
			while (true)
			{
				flag = response.ReadHeader(stream, out *(string*)(response + 72), out *(string*)(response + 68));
				if (!flag)
				{
					break;
				}
				Headers headers = this.headers__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.Internal.Response)+48]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.Internal.Response)+44]");
				Headers headers2 = headers.Add((string)num, 0);
			}
			string text3 = this.headers__BackingField.get_Item("Transfer-Encoding");
			bool flag2 = text3 == "chunked";
			bool flag3 = !flag2;
			if (!flag3)
			{
				List<byte[]> list = default;
				list._002Ector();
				chunks = list;
				bool flag4 = flag;
				string text4 = response.ReadHeaderLine(stream);
				if (!(text4 == "0"))
				{
					int num2 = int.Parse(text4, NumberStyles.AllowHexSpecifier);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					byte[] buffer = default;
					FileUtil.ReadFully(stream, buffer);
					_ = 0;
					_ = chunks;
					object obj2 = response + 56;
					Headers headers3 = (Headers)(response + 55);
					response.headers__BackingField = headers3;
					response.chunks = null;
					response.status__BackingField = (int)response.headers__BackingField;
					_ = 0;
					object obj3 = response + 55;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag5 = (nint)0 == 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						flag4 = false;
						if (!flag5)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag6 = (nint)0 == 1;
							bool flag7 = default;
							flag4 = flag7;
							if (!flag6)
							{
								flag3 = !flag7;
								if (!flag3)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag8 = (nint)0 == 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									flag4 = false;
									if (!flag8)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag9 = (nint)0 == 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										flag4 = false;
										if (!flag9)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag10 = false;
											bool flag11 = flag3;
											goto IL_049a;
										}
									}
								}
								else
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag12 = (nint)0 != 1;
									flag4 = flag7;
									bool flag10 = flag7;
									bool flag11 = flag3;
									if (flag12)
									{
										goto IL_049a;
									}
								}
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					object obj4 = default;
					object obj5 = default;
					bool flag13 = obj4 != obj5;
					object obj7 = default;
					object obj6 = obj7;
					if (!flag13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						object obj8 = default;
						response.chunks = (List<byte[]>)obj8;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag14 = (nint)0 == 1;
						bool flag10 = flag4;
						bool flag11 = flag3;
						if (!flag14)
						{
							goto IL_049a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						object obj9 = default;
						obj6 = obj9;
					}
					_ = 0;
					object obj10 = response + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_0d23;
					}
				}
				else
				{
					_ = 0;
					_ = chunks;
					object obj11 = response + 56;
					Headers headers4 = (Headers)(response + 55);
					response.headers__BackingField = headers4;
					response.chunks = null;
					response.status__BackingField = (int)response.headers__BackingField;
					_ = 0;
					object obj12 = response + 55;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								throw new ArgumentNullException();
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
					object obj13 = default;
					object obj14 = default;
					bool flag15 = obj13 == obj14;
					bool flag16 = !flag15;
					object obj15 = default;
					object obj6 = obj15;
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						object obj16 = default;
						response.chunks = (List<byte[]>)obj16;
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
					object obj18 = response + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_0d23;
					}
				}
				goto IL_0e09;
			}
			long num3 = this.headers__BackingField.Get("Content-Length", 0L);
			if (num3 < 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				byte[] array2 = default;
				bytes__BackingField = array2;
				return;
			}
			if (num3 < 2147483648L)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				FileUtil.ReadFully(stream, array3);
				text5 = this.headers__BackingField.Get("Content-MD5");
				if (text5 != null)
				{
					obj19 = 0;
					if (text5._stringLength != 0)
					{
						goto IL_0e49;
					}
				}
				obj19 = 1;
				goto IL_0e49;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			HTTPException ex = default;
			ex._002Ector("Bad Status Code in response");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		OverflowException ex2 = new OverflowException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		goto IL_0e57;
		IL_0e09:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_049a:
		throw new ArgumentNullException();
		IL_0d23:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_0e09;
		IL_0e57:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		HTTPException ex3 = default;
		ex3._002Ector("Content-MD5 digest mismatch. Data is corrupted.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		HTTPException ex4 = ex3;
		object obj20 = 1;
		object obj21 = obj20;
		while (true)
		{
			if (obj21 == null)
			{
				string helpURL = ((Exception)ex4)._helpURL;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.Internal.Response)+40]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.Internal.Response)+3C]");
				Headers headers5 = ((Headers)(object)helpURL).Add((string)num4, (object)0);
				obj21 = 1;
			}
			else
			{
				if (!response.ReadHeader((Stream)(object)array3, out *(string*)(response - -64), out *(string*)(response + 60)))
				{
					break;
				}
				obj21 = 0;
			}
		}
		List<byte> list2 = default;
		list2._002Ector();
		object obj22 = response + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		_ = response.message__BackingField;
		_ = response.chunks;
		Headers headers6 = (Headers)(response + 32);
		response.headers__BackingField = headers6;
		response.chunks = null;
		response.status__BackingField = (int)response.headers__BackingField;
		object obj24 = default;
		object obj25 = default;
		object obj26 = default;
		object obj27 = default;
		object obj28 = default;
		object obj29 = default;
		while (true)
		{
			_ = 0;
			object obj23 = response + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj24 == null)
				{
					goto IL_0c75;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag17 = obj25 != obj26;
			object obj6 = obj27;
			if (flag17)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			response.chunks = (List<byte[]>)obj28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0c75;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj6 = obj29;
			break;
			IL_0c75:
			object obj30 = response + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @57D5");
			byte[] innerException = list2.ToArray();
			((Exception)ex4)._innerException = (Exception)(object)innerException;
			return;
		}
		_ = 0;
		object obj31 = response + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			goto IL_0d23;
		}
		goto IL_0e09;
		IL_0e49:
		if (obj19 == null)
		{
			byte[] inArray = Checksum.ComputeMD5(array3);
			string text6 = Convert.ToBase64String(inArray);
			if (text6 != text5 && !ignoreContentMD5)
			{
				goto IL_0e57;
			}
		}
		string text7 = this.headers__BackingField.get_Item("Content-Encoding");
		if (text7.Contains("gzip"))
		{
			byte[] array4 = UnZip(array3);
			bytes__BackingField = array4;
		}
		else
		{
			bytes__BackingField = array3;
		}
	}

	private static byte[] UnZip(byte[] data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_02b3: Expected I, but got Obj
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0318: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		MemoryStream memoryStream = default;
		memoryStream._002Ector();
		MemoryStream memoryStream2 = default;
		memoryStream2._002Ector(data, writable: false);
		GZipStream gZipStream = default;
		gZipStream._002Ector(memoryStream2, CompressionMode.Decompress);
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj5;
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			object obj4 = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					break;
				}
				bool flag = (nint)obj4 <= 0;
				obj5 = obj;
				if (!flag)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					goto IL_0127;
				}
				goto IL_0293;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_0145;
		IL_0127:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0145;
		IL_0145:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag2 = obj6 == obj7;
		bool flag3 = !flag2;
		object obj9 = default;
		object obj8 = obj9;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			obj5 = obj;
			if (flag4)
			{
				goto IL_0293;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj10 = default;
			obj8 = obj10;
		}
		_ = 0;
		object obj11 = obj + 16;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		obj5 = 0;
		goto IL_0293;
		IL_0293:
		object obj12 = obj5 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		nint num = (nint)memoryStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ S1_v30 (Il2CppClass<System.IO.MemoryStream>)+1FC] (should have been resolved before IL gen)");
		byte[] result = default;
		return result;
	}

	private static void LogWarning(string msg)
	{
	}
}
