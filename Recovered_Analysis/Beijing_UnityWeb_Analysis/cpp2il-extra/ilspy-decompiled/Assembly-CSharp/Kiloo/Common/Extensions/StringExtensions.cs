using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Extensions;

public static class StringExtensions
{
	public static string FilterWhiteSpaces(string input)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0201: Expected I, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0242: Expected I, but got Obj
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 4;
		obj = input;
		if ((nint)input > 0)
		{
			object obj3 = input / 100;
			object obj4 = obj3 * 100;
			object obj5 = (object)input - obj4;
			object obj6 = obj5 - 11;
			if ((nint)obj6 < 3)
			{
				obj2 = input;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text = default;
				return text + "th";
			}
			object obj7 = input / 10;
			object obj8 = obj7 * 10;
			object obj9 = (object)input - obj8;
			object obj10 = obj9 - 1;
			if ((nint)obj9 != 1)
			{
				if ((nint)obj10 != 1)
				{
					if ((nint)obj10 == 2)
					{
						obj2 = input;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						string text2 = default;
						return text2 + "rd";
					}
					obj2 = input;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					string text3 = default;
					return text3 + "th";
				}
				obj2 = input;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text4 = default;
				return text4 + "nd";
			}
			obj2 = input;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text5 = default;
			return text5 + "st";
		}
		nint num = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v14 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v20 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D55B");
		string result = default;
		return result;
	}

	public static string Populate(string str, object[] args)
	{
		return (string)(object)Enumerable.OrderBy<TSource, TKey>((IEnumerable<TSource>)(object)args, (Func<TSource, TKey>)(object)str);
	}

	public static string Format(string str, object[] args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A56D");
		string result = default;
		return result;
	}

	public static bool IsNullOrEmpty(string str)
	{
		//IL_014f: Expected I4, but got Obj
		//IL_0021: Expected Obj, but got I4
		//IL_0141: Expected I4, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got I4
		//IL_00f9: Expected I4, but got Obj
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		if (str != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector((string)str.m_stringLength);
			char[] array4;
			for (char[] array = null; (nint)array < str.m_stringLength; array4 = (char[])(array + 1), array = array4)
			{
				bool flag = array != null;
				string[] array2 = str.Split(array);
				object obj = array2 & 0xFFFF;
				bool flag2 = (nint)obj == 32;
				object obj2 = flag & flag2;
				if (obj2 != null)
				{
					char[] separator = (char[])(array - 1);
					string[] array3 = str.Split(separator);
					object obj3 = array3 & 0xFFFF;
					if ((nint)obj3 == 32)
					{
						continue;
					}
				}
				StringBuilder stringBuilder2 = stringBuilder.Append((int)array2);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string str2 = default;
			string text = string.Copy(str2);
			return (byte)(int)text != 0;
		}
		return (byte)(int)string.Empty != 0;
	}

	public static bool IsNullOrWhiteSpace(string str)
	{
		if (str != null)
		{
			return str.m_stringLength == 0;
		}
		return true;
	}

	public static string ToTitleCase(string str)
	{
		//IL_00ea: Expected Obj, but got I4
		//IL_003c: Expected I, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_011a: Expected I4, but got Obj
		//IL_0018: Expected Obj, but got I4
		//IL_007d: Expected I, but got Obj
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		if (str != null)
		{
			char[] array = null;
			while (true)
			{
				if ((nint)array >= str.m_stringLength)
				{
					return (string)1;
				}
				string[] array2 = str.Split(array);
				nint num = (nint)typeof(char);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v8 (Il2CppClass<System.Char>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(char);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v14 (Il2CppClass<System.Char>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!char.IsUpper((char)(int)array2))
				{
					break;
				}
				char[] array3 = (char[])(array + 1);
				array = array3;
			}
			return null;
		}
		return (string)1;
	}

	public static bool Contains(string haystack, string needle, StringComparison comp = StringComparison.Ordinal)
	{
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009b: Expected I4, but got Obj
		//IL_005a: Expected I4, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref haystack) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref needle))
		{
			return (byte)(int)needle != 0;
		}
		if ((nint)haystack > (nint)comp)
		{
			return (byte)comp != 0;
		}
		return (byte)(int)haystack != 0;
	}

	public static bool IsOneOf(string needle, IEnumerable<string> haystack)
	{
		//IL_0011: Expected I4, but got Obj
		return (byte)(int)(needle + haystack) != 0;
	}

	public static bool IsOneOf(string needle, string[] haystack)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = needle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Func<string, bool> func = default;
		object obj3 = func + 16;
		obj3 = obj2;
		return Enumerable.Any(haystack, func);
	}
}
