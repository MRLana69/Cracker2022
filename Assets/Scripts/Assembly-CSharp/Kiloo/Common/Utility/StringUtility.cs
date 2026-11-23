using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;

namespace Kiloo.Common.Utility;

public static class StringUtility
{
	public enum MatchType
	{
		Is,
		EndsWith,
		BeginsWith,
		Contains
	}

	public static bool Match(string str, string pattern, MatchType matchType, bool ignoreCase)
	{
		string text2 = default;
		string text3 = default;
		switch (matchType)
		{
		default:
			return false;
		case MatchType.Is:
		{
			StringComparison comparisonType3 = StringComparison.OrdinalIgnoreCase;
			if (!ignoreCase)
			{
				comparisonType3 = StringComparison.Ordinal;
			}
			return text2.Equals(text3, comparisonType3);
		}
		case MatchType.EndsWith:
		{
			StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
			if (!ignoreCase)
			{
				comparisonType = StringComparison.Ordinal;
			}
			return text2.EndsWith(text3, comparisonType);
		}
		case MatchType.BeginsWith:
		{
			StringComparison comparisonType2 = StringComparison.OrdinalIgnoreCase;
			if (!ignoreCase)
			{
				comparisonType2 = StringComparison.Ordinal;
			}
			return text2.StartsWith(text3, comparisonType2);
		}
		case MatchType.Contains:
		{
			string text = default;
			string value = default;
			if (ignoreCase)
			{
				text = text2.ToLower();
				value = text3.ToLower();
			}
			return text.Contains(value);
		}
		}
	}

	public static string ArrayToString<MyType>(MyType[] array)
	{
		//IL_00c5: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_00a4: Expected I, but got Obj
		//IL_0074: Expected Obj, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object obj = 1;
		object obj2 = 0;
		while (array.Length > (nint)obj2)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)array + obj3;
			if (obj == null)
			{
				StringBuilder stringBuilder2 = stringBuilder.Append(", ");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v17+10]");
			StringBuilder stringBuilder3 = stringBuilder.Append((object)0);
			object obj5 = obj2 + 1;
			obj = 0;
			obj2 = obj5;
		}
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S1_v6 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public static void ValidateEnumValueString(Type enumType, string enumValueString, bool mayBeNullOrEmpty, string varName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		object obj4;
		if (enumValueString != null)
		{
			obj4 = 0;
			if (enumValueString._stringLength != 0)
			{
				goto IL_0398;
			}
		}
		obj4 = 1;
		goto IL_0398;
		IL_03b5:
		string[] names = Enum.GetNames(enumType);
		string text = StringUtility.ArrayToString<MyType>((MyType[])(object)names);
		string text2 = varName + " must be one of: " + text;
		return;
		IL_03d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_0398:
		if (obj4 != null)
		{
			if (mayBeNullOrEmpty)
			{
				return;
			}
			goto IL_03b5;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				return;
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
		bool flag = obj5 != obj6;
		object obj8 = default;
		object obj7 = obj8;
		if (!flag)
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj12 = (nint)0 << 2;
						object obj13 = obj3 + obj12;
						obj13 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj14 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj15 = -1;
						goto IL_03b5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj16 = obj10;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					obj7 = obj10;
					if (flag2)
					{
						goto IL_03d5;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj17 = default;
			obj7 = obj17;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj7 = obj17;
			}
		}
		goto IL_03d5;
	}

	public static int NonEscapedIndexOf(string text, int startIndex, char ch)
	{
		int num = text.IndexOf(ch, startIndex);
		bool flag = num == 0;
		int result = 0;
		if (!flag)
		{
			if (num >= 1)
			{
				int index = num - 1;
				char c = text.get_Chars(index);
				bool flag2 = c != '\\';
				result = num;
				if (flag2)
				{
					goto IL_00bb;
				}
			}
			result = -1;
		}
		goto IL_00bb;
		IL_00bb:
		return result;
	}

	public unsafe static int GetNextKeyValuePair(string text, int startIndex, out string key, out string value)
	{
		//IL_008f: Expected Obj, but got I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected I4, but got Unknown
		//IL_0168: Expected Obj, but got I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected I4, but got Unknown
		int num = NonEscapedIndexOf(text, startIndex, '[');
		ref string reference;
		ref string reference2;
		if (num >= 0)
		{
			int startIndex2 = num + 1;
			int num2 = NonEscapedIndexOf(text, startIndex2, ']');
			if (num2 >= 0)
			{
				int startIndex3 = num + 1;
				object obj = num2 - num;
				int length = obj - 1;
				string text2 = text.Substring(startIndex3, length);
				string text3 = text2.Trim();
				reference = ref *(string*)text3;
				int startIndex4 = num2 + 1;
				int startIndex5 = num2 + 1;
				int num3 = NonEscapedIndexOf(text, startIndex5, '[');
				bool flag = num3 <= -1;
				bool flag2 = !flag;
				int num4 = num3;
				if (!flag2)
				{
					num4 = text._stringLength;
				}
				object obj2 = num4 - num2;
				int length2 = obj2 - 1;
				string text4 = text.Substring(startIndex4, length2);
				string text5 = text4.Trim();
				reference2 = ref *(string*)text5;
				return num4;
			}
		}
		reference = ref *(string*)null;
		reference2 = ref *(string*)null;
		return -1;
	}

	public unsafe static Dictionary<string, string> ParseProperties(string text)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Ref, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Ref, but got Unknown
		//IL_002f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		int nextKeyValuePair = default;
		do
		{
			nextKeyValuePair = GetNextKeyValuePair(text, nextKeyValuePair, out *(string*)(obj + 12), out *(string*)(obj + 8));
			if (nextKeyValuePair <= -1)
			{
				break;
			}
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S5_v6+4] (should have been resolved before IL gen)");
		}
		while (nextKeyValuePair != text._stringLength);
		Dictionary<string, string> result = default;
		return result;
	}

	public static string FormatProperties(Dictionary<string, string> props)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected Obj, but got Unknown
		//IL_0752: Expected I, but got Obj
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Obj, but got Unknown
		//IL_00bf: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		//IL_06ed: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I
		//IL_022a: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 91;
		_ = 93;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj10 = default;
		object obj11 = default;
		string text = default;
		string text2 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj9;
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
					object obj8 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
						if ((nint)0 != 0)
						{
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v90+8]");
							if ((nint)0 != 0)
							{
								goto IL_0761;
							}
						}
						obj9 = 1;
						goto IL_0761;
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
			goto IL_05aa;
			IL_05aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj10 == obj11;
			bool flag3 = !flag2;
			string result = text;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = text2;
			}
			_ = 0;
			object obj12 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
			IL_07d5:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj13;
			if ((nint)0 != 1)
			{
				if (obj13 != null)
				{
					continue;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
			goto IL_05aa;
			IL_0761:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj9 != null)
				{
					continue;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
				object obj14 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
					if ((nint)0 != 0)
					{
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v113+8]");
						if ((nint)0 != 0)
						{
							goto IL_07d5;
						}
					}
					obj13 = 1;
					goto IL_07d5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_05aa;
		}
		object obj15 = obj7 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8F8");
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v181 @ S1_v33 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result2 = default;
		return result2;
	}

	public static string[][] ParseSets(string setsString)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public static string ToHexString(byte[] bytes, bool lowerCase = false)
	{
		//IL_0103: Expected Obj, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0206: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_017d: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		object obj = 97;
		if (!lowerCase)
		{
			obj = 65;
		}
		object obj2 = obj - 10;
		object obj3 = bytes.Length << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj4 = default;
		char[] array = default;
		object obj23 = default;
		while (bytes.Length > (nint)obj4)
		{
			object obj5 = (object)bytes + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v18+10]");
			object obj6 = (nint)0 >> 4;
			object obj7 = obj4 << 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v18+10]");
			object obj8;
			object obj9;
			if ((nint)0 <= (nint)159)
			{
				obj8 = obj4 << 1;
				obj9 = 48;
			}
			else
			{
				obj9 = obj2;
				obj8 = obj7;
			}
			object obj10 = obj8 << 1;
			object obj11 = (object)array + obj10;
			object obj12 = obj9 + obj6;
			object obj13 = obj4 << 1;
			object obj14 = obj13 + 1;
			object obj15 = (object)bytes + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v22+10]");
			object obj16 = (nint)0 & (nint)0xF;
			object obj18;
			object obj19;
			if ((nint)obj16 <= 9)
			{
				object obj17 = obj4 << 1;
				obj18 = obj17 + 1;
				obj19 = 48;
			}
			else
			{
				obj19 = obj2;
				obj18 = obj14;
			}
			object obj20 = obj18 << 1;
			object obj21 = (object)array + obj20;
			object obj22 = obj19 + obj16;
			obj4 = obj23 + 1;
		}
		return ((string)null).CreateString(array);
	}

	private static int ParseHexDigit(char c)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0113: Expected I4, but got Obj
		//IL_0050: Expected Obj, but got I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		char c2 = default;
		object obj = c2 - 48;
		object obj2 = obj & 0xFFFF;
		bool flag = (nint)obj2 < 10;
		object obj3 = 48;
		ArgumentException ex = default;
		if (!flag)
		{
			object obj4 = c2 - 65;
			object obj5 = obj4 & 0xFFFF;
			bool flag2 = (nint)obj5 < 6;
			obj3 = 65;
			if (!flag2)
			{
				object obj6 = c2 - 97;
				object obj7 = obj6 & 0xFFFF;
				bool flag3 = (nint)obj7 < 6;
				obj3 = 97;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					ex._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
					obj3 = 97;
				}
			}
		}
		return (object)ex - obj3;
	}

	public static byte[] FromHexString(string hex)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		int num = hex._stringLength / 2;
		int num2 = num << 1;
		if (num2 != hex._stringLength)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj = 0;
			int num3 = default;
			object obj3 = default;
			while ((nint)obj < num)
			{
				char c = hex.get_Chars(num3);
				int num4 = ParseHexDigit(c);
				int num5 = num3 + 1;
				num3 = num5 + 1;
				object obj2 = obj + obj3;
				char c2 = hex.get_Chars(num5);
				int num6 = ParseHexDigit(c2);
				object obj4 = obj + 1;
				obj = obj4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ArgumentException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte[])(object)ex;
	}
}
