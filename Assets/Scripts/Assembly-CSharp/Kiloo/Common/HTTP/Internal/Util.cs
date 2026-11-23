using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Ionic.Zlib;

namespace Kiloo.Common.HTTP.Internal;

internal class Util
{
	public const string EOL = "\r\n";

	public static int ConvertTimeoutToMilliseconds(float seconds)
	{
		//IL_007f: Expected F8, but got I4
		//IL_00a0: Expected I4, but got F8
		if (seconds > 0f)
		{
			double num = (double)seconds * 1000.0;
			double num2 = Math.Abs(num);
			if (!(num2 < 2147483648.0))
			{
				num = -2147483648.0;
			}
			int result = (int)num;
			if ((int)num == 0)
			{
				result = 1;
			}
			return result;
		}
		return 0;
	}

	public unsafe static string ContentAsString(byte[] bytes, Headers headers, int maxChars = 0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		return ContentAsString(bytes, headers, maxChars, out *(int*)(obj + 12));
	}

	public unsafe static string ContentAsString(byte[] bytes, Headers headers, int maxChars, out int totalCharCount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0373: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		//IL_043c: Expected I, but got Obj
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		//IL_0380: Expected I, but got Obj
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I4
		//IL_03e7: Expected I, but got Obj
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_0409: Expected Obj, but got I4
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected Obj, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected Obj, but got Unknown
		//IL_04f3: Expected Obj, but got I
		//IL_02d8: Expected Obj, but got I4
		//IL_022f: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		byte[] array = default;
		ref int reference;
		if (array == null)
		{
			reference = ref *(int*)null;
			return null;
		}
		IDictionary<string, string> contentType = headers.contentType;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		object obj4 = default;
		if (obj4 == null)
		{
			goto IL_0352;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj6;
		if ((nint)0 != 0)
		{
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v41+8]");
			if ((nint)0 != 0)
			{
				goto IL_04d5;
			}
		}
		obj6 = 1;
		goto IL_04d5;
		IL_0352:
		Encoding uTF = Encoding.UTF8;
		Encoding encoding = uTF;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		byte[] array2 = (byte[])0;
		goto IL_0567;
		IL_04d5:
		string result = default;
		if (obj6 == null)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag = (nint)0 == 1;
			bool flag2 = !flag;
			Encoding encoding2 = default;
			encoding = encoding2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj7 = default;
				object obj8 = default;
				bool flag3 = obj7 == obj8;
				bool flag4 = !flag3;
				Encoding encoding3 = default;
				encoding = encoding3;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj10 = default;
						object obj9 = obj10;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj11 = default;
							if (obj11 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj12 = (nint)0 << 2;
								object obj13 = obj + obj12;
								obj13 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj14 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj15 = -1;
								goto IL_0352;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj16 = obj10;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag5 = (nint)0 != 1;
							result = (string)flag5;
							if (flag5)
							{
								goto IL_0496;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 == 1;
					Encoding encoding4 = default;
					encoding = encoding4;
					if (flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						goto IL_0496;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			array2 = (byte[])0;
			if (encoding != null)
			{
				goto IL_0567;
			}
		}
		goto IL_0352;
		IL_0567:
		if (maxChars >= 1)
		{
			nint num = (nint)encoding;
			object obj17 = encoding + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ S2_v7 (Il2CppClass<System.Text.Encoding>)+1CC] (should have been resolved before IL gen)");
			object obj19 = default;
			object obj18 = obj19;
			object obj20 = obj19 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ S5_v9+E4] (should have been resolved before IL gen)");
			object obj21 = default;
			reference = ref *(int*)obj21;
			if (maxChars < (nint)obj21)
			{
				nint num2 = (nint)encoding;
				object obj22 = encoding + 288;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v241 @ S2_v12 (Il2CppClass<System.Text.Encoding>)+1DC] (should have been resolved before IL gen)");
				object obj23 = array2.Length;
				object obj24 = default;
				if ((nint)obj24 <= array2.Length)
				{
					obj23 = obj24;
				}
				object obj25 = obj19;
				object obj26 = obj19 + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v276 @ S4_v11+E4] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				object obj27 = obj19 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v298 @ S6_v12+BC] (should have been resolved before IL gen)");
				char[] val = default;
				return ((string)null).CreateString(val, 0, maxChars);
			}
		}
		nint num3 = (nint)encoding;
		object obj28 = encoding + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v222 @ S5_v5 (Il2CppClass<System.Text.Encoding>)+1F4] (should have been resolved before IL gen)");
		string text = default;
		reference = ref *(int*)text._stringLength;
		return text;
		IL_0496:
		return result;
	}

	public static byte[] UnZip(byte[] data)
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

	public static ResponseCategory GetResponseCategory(int status)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected I4, but got Unknown
		int num = status / 100;
		object obj = num - 1;
		if ((nint)obj <= 4)
		{
			return (ResponseCategory)(obj + 1);
		}
		return ResponseCategory.Unknown;
	}
}
