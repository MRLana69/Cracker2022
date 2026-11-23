using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected;

namespace FullSerializer;

public static class fsJsonPrinter
{
	private static void InsertSpacing(TextWriter stream, int count)
	{
		//IL_004a: Expected Obj, but got I4
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		object obj = 0;
		while (count > (nint)obj)
		{
			nint num = (nint)stream;
			object obj2 = stream + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S2_v3 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
			object obj3 = obj + 1;
			obj = obj3;
		}
	}

	private static string EscapeString(string str)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0471: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		int num = default;
		string text = default;
		int num5 = default;
		StringBuilder stringBuilder = default;
		int num2 = default;
		int num3 = default;
		object arg = default;
		for (; num < text._stringLength; num = num5 + 1)
		{
			char c = text.get_Chars(num);
			if (c <= '\u007f')
			{
				if (c <= '\r')
				{
					if (c != '\0')
					{
						object obj3 = c - 7;
						if ((nint)obj3 > 6 || (nint)obj3 == 4)
						{
							continue;
						}
					}
				}
				else if (c != '"' && c != '\\')
				{
					continue;
				}
			}
			stringBuilder._002Ector();
			for (; text._stringLength > num2; num2 = num3 + 1)
			{
				char c2 = text.get_Chars(num2);
				if (c2 >= '\u0080')
				{
					object obj4 = obj + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					string text2 = $"\\u{arg:x4} ";
					string value = text2.Trim();
					StringBuilder stringBuilder2 = stringBuilder.Append(value);
					continue;
				}
				if (c2 <= '\r')
				{
					if (c2 == '\0')
					{
						StringBuilder stringBuilder3 = stringBuilder.Append("\\0");
						continue;
					}
					object obj5 = c2 - 7;
					if (c2 == '\a')
					{
						StringBuilder stringBuilder4 = stringBuilder.Append("\\a");
						continue;
					}
					if ((nint)obj5 == 1)
					{
						StringBuilder stringBuilder5 = stringBuilder.Append("\\b");
						continue;
					}
					if ((nint)obj5 == 2)
					{
						StringBuilder stringBuilder6 = stringBuilder.Append("\\t");
						continue;
					}
					if ((nint)obj5 == 3)
					{
						StringBuilder stringBuilder7 = stringBuilder.Append("\\n");
						continue;
					}
					if ((nint)obj5 != 4)
					{
						if ((nint)obj5 == 5)
						{
							StringBuilder stringBuilder8 = stringBuilder.Append("\\f");
							continue;
						}
						if ((nint)obj5 == 6)
						{
							StringBuilder stringBuilder9 = stringBuilder.Append("\\r");
							continue;
						}
					}
				}
				else
				{
					switch (c2)
					{
					case '"':
					{
						StringBuilder stringBuilder11 = stringBuilder.Append("\\\"");
						continue;
					}
					case '\\':
					{
						StringBuilder stringBuilder10 = stringBuilder.Append("\\\\");
						continue;
					}
					}
				}
				StringBuilder stringBuilder12 = stringBuilder.Append(c2);
			}
			nint num4 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S1_v14 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			break;
		}
		string result = default;
		return result;
	}

	private static void BuildCompressedString(fsData data, TextWriter stream)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Expected Obj, but got Unknown
		//IL_0921: Expected Obj, but got I4
		//IL_04ca: Expected I, but got Obj
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected Obj, but got Unknown
		//IL_0542: Expected Obj, but got I4
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Expected Obj, but got Unknown
		//IL_01d6: Expected I, but got Obj
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0227: Expected Obj, but got I
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got I4
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected Obj, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected Obj, but got Unknown
		//IL_073b: Expected I, but got Obj
		//IL_0141: Expected I, but got Obj
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_0165: Expected I, but got Obj
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected Obj, but got Unknown
		//IL_0875: Expected I, but got Obj
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got I
		//IL_0626: Expected Obj, but got I4
		//IL_010b: Expected I, but got Obj
		//IL_00f4: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_01ad: Expected I, but got Obj
		//IL_01bf: Expected I, but got Obj
		//IL_066e: Expected I, but got Obj
		//IL_04a5: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		fsDataType type = data.Type;
		if (type != fsDataType.Array)
		{
			if (type != fsDataType.Object)
			{
				switch (type)
				{
				case fsDataType.Boolean:
					if (data.AsBool)
					{
						nint num7 = (nint)stream;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v310 @ S2_v61 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
					}
					else
					{
						nint num8 = (nint)stream;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ S2_v58 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
					}
					break;
				case fsDataType.Double:
				{
					double asDouble = data.AsDouble;
					string text2 = ConvertDoubleToString(asDouble);
					nint num6 = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ S2_v51 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
					break;
				}
				case fsDataType.Int64:
				{
					long asInt = data.AsInt64;
					nint num5 = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v158 @ S2_v55 (Il2CppClass<System.IO.TextWriter>)+13C] (should have been resolved before IL gen)");
					break;
				}
				case fsDataType.String:
				{
					nint num2 = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ S2_v64 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
					string asString = data.AsString;
					string text = EscapeString(asString);
					nint num3 = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v351 @ S2_v69 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
					nint num4 = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v358 @ S2_v72 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
					break;
				}
				case fsDataType.Null:
				{
					nint num = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v304 @ S2_v75 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
					break;
				}
				}
				return;
			}
			nint num9 = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S2_v25 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
			object obj4 = obj + 8;
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj5 = obj + 56;
			obj = obj5;
			_ = 0;
			object obj6 = 0;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			object obj12 = default;
			object obj13 = default;
			while (true)
			{
				_ = 0;
				object obj7 = obj + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj8 == null)
					{
						goto IL_0855;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
					obj = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj6 != null)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								goto IL_07bc;
							}
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
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
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag = (nint)0 != 1;
												obj6 = 1;
												if (flag)
												{
													continue;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_07bc;
				IL_07bc:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag2 = obj9 != obj10;
				object obj11 = obj12;
				if (flag2)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0855;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj11 = obj13;
				break;
				IL_0855:
				object obj14 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1915");
				nint num10 = (nint)stream;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v452 @ S2_v37 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
				return;
			}
			_ = 0;
			object obj15 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_08ee;
			}
		}
		else
		{
			nint num11 = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S2_v5 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
			object obj16 = obj + 8;
			List<fsData> asList = data.AsList;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj17 = obj + 32;
			obj = obj17;
			_ = 0;
			object obj18 = 0;
			object obj20 = default;
			object obj22 = default;
			object obj23 = default;
			object obj24 = default;
			object obj25 = default;
			while (true)
			{
				_ = 0;
				object obj19 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj20 == null)
					{
						goto IL_071b;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj18 != null)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_068c;
							}
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 != 1;
						obj18 = 1;
						if (flag3)
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
				goto IL_068c;
				IL_071b:
				object obj21 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3650");
				nint num12 = (nint)stream;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v433 @ S2_v17 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
				return;
				IL_068c:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag4 = obj22 != obj23;
				object obj11 = obj24;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_071b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj11 = obj25;
				break;
			}
			_ = 0;
			object obj26 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_08ee;
			}
		}
		goto IL_09f6;
		IL_09f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		return;
		IL_08ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_09f6;
	}

	private static void BuildPrettyString(fsData data, TextWriter stream, int depth)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Expected Obj, but got Unknown
		//IL_0b20: Expected Obj, but got I4
		//IL_05bf: Expected I, but got Obj
		//IL_05d1: Expected I, but got Obj
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected Obj, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_0649: Expected Obj, but got I4
		//IL_05a8: Expected I, but got Obj
		//IL_01d6: Expected I, but got Obj
		//IL_01e8: Expected I, but got Obj
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected Obj, but got Unknown
		//IL_0239: Expected Obj, but got I
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_0270: Expected Obj, but got I4
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected Obj, but got Unknown
		//IL_0141: Expected I, but got Obj
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Expected Obj, but got Unknown
		//IL_08f2: Expected I, but got Obj
		//IL_0165: Expected I, but got Obj
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected Obj, but got Unknown
		//IL_0916: Expected I, but got Obj
		//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected Obj, but got Unknown
		//IL_0a50: Expected I, but got Obj
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Expected Obj, but got Unknown
		//IL_0a74: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I
		//IL_010b: Expected I, but got Obj
		//IL_0743: Expected Obj, but got I4
		//IL_00f4: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_037f: Expected Obj, but got I4
		//IL_01ad: Expected I, but got Obj
		//IL_01bf: Expected I, but got Obj
		//IL_078c: Expected Obj, but got I4
		//IL_07bf: Expected Obj, but got I4
		//IL_0825: Expected I, but got Obj
		//IL_0516: Expected Obj, but got I4
		//IL_0549: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		fsDataType type = data.Type;
		if (type != fsDataType.Array)
		{
			if (type != fsDataType.Object)
			{
				switch (type)
				{
				case fsDataType.Boolean:
					if (data.AsBool)
					{
						nint num7 = (nint)stream;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v344 @ S2_v80 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
					}
					else
					{
						nint num8 = (nint)stream;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v348 @ S2_v77 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
					}
					break;
				case fsDataType.Double:
				{
					double asDouble = data.AsDouble;
					string text2 = ConvertDoubleToString(asDouble);
					nint num6 = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ S2_v70 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
					break;
				}
				case fsDataType.Int64:
				{
					long asInt = data.AsInt64;
					nint num5 = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ S2_v74 (Il2CppClass<System.IO.TextWriter>)+13C] (should have been resolved before IL gen)");
					break;
				}
				case fsDataType.String:
				{
					nint num2 = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v291 @ S2_v83 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
					string asString = data.AsString;
					string text = EscapeString(asString);
					nint num3 = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v363 @ S2_v88 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
					nint num4 = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v370 @ S2_v91 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
					break;
				}
				case fsDataType.Null:
				{
					nint num = (nint)stream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ S2_v94 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
					break;
				}
				}
				return;
			}
			nint num9 = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S2_v36 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
			nint num10 = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S1_v84 (Il2CppClass<System.IO.TextWriter>)+14C] (should have been resolved before IL gen)");
			object obj4 = obj + 8;
			Dictionary<string, fsData> asDictionary = data.AsDictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj5 = obj + 56;
			obj = obj5;
			_ = 0;
			object obj6 = 0;
			object obj8 = default;
			object obj10 = default;
			object obj11 = default;
			object obj13 = default;
			object obj14 = default;
			while (true)
			{
				_ = 0;
				object obj7 = obj + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj8 == null)
					{
						goto IL_0a30;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
					obj = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj6 == null)
						{
							goto IL_036b;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
								goto IL_036b;
							}
						}
					}
				}
				goto IL_0997;
				IL_0a30:
				object obj9 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1915");
				nint num11 = (nint)stream;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v462 @ S1_v109 (Il2CppClass<System.IO.TextWriter>)+14C] (should have been resolved before IL gen)");
				InsertSpacing(stream, depth);
				nint num12 = (nint)stream;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v522 @ S2_v53 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
				return;
				IL_0997:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj10 != obj11;
				object obj12 = obj13;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0a30;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj14;
				break;
				IL_036b:
				_ = 0;
				object obj15 = depth + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											object obj16 = depth + 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag2 = (nint)0 != 1;
											obj6 = 1;
											if (flag2)
											{
												continue;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_0997;
			}
			_ = 0;
			object obj17 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0aed;
			}
		}
		else
		{
			List<fsData> asList = data.AsList;
			if (asList._size == 0)
			{
				nint num13 = (nint)stream;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S2_v33 (Il2CppClass<System.IO.TextWriter>)+144] (should have been resolved before IL gen)");
				return;
			}
			nint num14 = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ S2_v5 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
			nint num15 = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S1_v18 (Il2CppClass<System.IO.TextWriter>)+14C] (should have been resolved before IL gen)");
			object obj18 = obj + 8;
			List<fsData> asList2 = data.AsList;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj19 = obj + 32;
			obj = obj19;
			_ = 0;
			object obj20 = 0;
			object obj22 = default;
			object obj26 = default;
			object obj27 = default;
			object obj28 = default;
			object obj29 = default;
			while (true)
			{
				_ = 0;
				object obj21 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj22 == null)
					{
						goto IL_08d2;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj20 == null)
						{
							goto IL_072f;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
								goto IL_072f;
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
				goto IL_0843;
				IL_08d2:
				object obj23 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3650");
				nint num16 = (nint)stream;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v531 @ S1_v41 (Il2CppClass<System.IO.TextWriter>)+14C] (should have been resolved before IL gen)");
				InsertSpacing(stream, depth);
				nint num17 = (nint)stream;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v589 @ S2_v22 (Il2CppClass<System.IO.TextWriter>)+124] (should have been resolved before IL gen)");
				return;
				IL_072f:
				_ = 0;
				object obj24 = depth + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj25 = depth + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					obj20 = 1;
					if (flag3)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0843;
				IL_0843:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag4 = obj26 != obj27;
				object obj12 = obj28;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_08d2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj29;
				break;
			}
			_ = 0;
			object obj30 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0aed;
			}
		}
		goto IL_0bf5;
		IL_0aed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0bf5;
		IL_0bf5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public static void PrettyJson(fsData data, TextWriter outputStream)
	{
		BuildPrettyString(data, outputStream, 0);
	}

	public static string PrettyJson(fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		StringWriter stringWriter = default;
		stringWriter._002Ector(stringBuilder);
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		string result;
		object obj4;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag = (nint)0 != 1;
			string text = default;
			result = text;
			obj4 = obj;
			if (flag)
			{
				goto IL_0270;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag2 = obj5 == obj6;
		bool flag3 = !flag2;
		string text2 = default;
		result = text2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			result = null;
			obj4 = obj;
			if (flag4)
			{
				goto IL_0270;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			string text3 = default;
			result = text3;
		}
		_ = 0;
		object obj7 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj4 = 0;
			goto IL_0270;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result;
		IL_0270:
		object obj8 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
	}

	public static void CompressedJson(fsData data, StreamWriter outputStream)
	{
		BuildCompressedString(data, outputStream);
	}

	public static string CompressedJson(fsData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		StringWriter stringWriter = default;
		stringWriter._002Ector(stringBuilder);
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		string result;
		object obj4;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag = (nint)0 != 1;
			string text = default;
			result = text;
			obj4 = obj;
			if (flag)
			{
				goto IL_0270;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag2 = obj5 == obj6;
		bool flag3 = !flag2;
		string text2 = default;
		result = text2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			result = null;
			obj4 = obj;
			if (flag4)
			{
				goto IL_0270;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			string text3 = default;
			result = text3;
		}
		_ = 0;
		object obj7 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj4 = 0;
			goto IL_0270;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result;
		IL_0270:
		object obj8 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
	}

	private unsafe static string ConvertDoubleToString(double d)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_0048: Expected Ref, but got F8
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0084: Expected Ref, but got F8
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = d & 0x7FFFFFFFFFFFFFFFL;
		string result;
		if ((long)obj3 != 9218868437227405312L)
		{
			object obj4 = d & 0x7FFFFFFFFFFFFFFFL;
			if ((long)obj4 < 9218868437227405313L)
			{
				double num = (double)obj + 8.0;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				string text = ((double*)num)->ToString(invariantCulture);
				bool flag = text.Contains(".");
				result = text;
				if (!flag)
				{
					bool flag2 = text.Contains("e");
					result = text;
					if (!flag2)
					{
						bool flag3 = text.Contains("E");
						result = text;
						if (!flag3)
						{
							string text2 = text + ".0";
							result = text2;
						}
					}
				}
				goto IL_015c;
			}
		}
		double num2 = (double)obj + 8.0;
		CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
		string text3 = ((double*)num2)->ToString(invariantCulture2);
		result = text3;
		goto IL_015c;
		IL_015c:
		return result;
	}
}
