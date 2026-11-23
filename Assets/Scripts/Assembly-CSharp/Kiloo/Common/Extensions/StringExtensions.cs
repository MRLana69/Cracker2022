using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;

namespace Kiloo.Common.Extensions;

public static class StringExtensions
{
	public static string FilterWhiteSpaces(string input)
	{
		//IL_00f3: Expected I, but got Obj
		if (input == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(input._stringLength);
		int num2;
		for (int num = 0; input._stringLength > num; num2 = num + 1, num = num2)
		{
			char c = input.get_Chars(num);
			if (num != 0 && c == ' ')
			{
				int index = num - 1;
				char c2 = input.get_Chars(index);
				if (c2 == ' ')
				{
					continue;
				}
			}
			StringBuilder stringBuilder2 = stringBuilder.Append(c);
		}
		nint num3 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S1_v6 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string text = default;
		return text.Trim();
	}

	public static string Populate(string str, object[] args)
	{
		return string.Format(str, args);
	}

	public static bool IsNullOrEmpty(string str)
	{
		bool result;
		if (str != null)
		{
			result = false;
			if (str._stringLength != 0)
			{
				goto IL_0047;
			}
		}
		result = true;
		goto IL_0047;
		IL_0047:
		return result;
	}

	public static string ToTitleCase(string str)
	{
		//IL_002c: Expected I, but got Obj
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		nint num = (nint)currentCulture;
		object obj = currentCulture + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v3 (Il2CppClass<System.Globalization.CultureInfo>)+10C] (should have been resolved before IL gen)");
		string str2 = str.ToLower();
		TextInfo textInfo = default;
		return textInfo.ToTitleCase(str2);
	}

	public static bool IsAny(string s1, IEnumerable<string> sArr)
	{
		throw new ArgumentException();
	}

	public static bool Contains(string haystack, string needle, StringComparison comp = StringComparison.Ordinal)
	{
		int num = haystack.IndexOf(needle, comp);
		int num2 = num ^ -1;
		return (byte)(num2 >> 31) != 0;
	}
}
