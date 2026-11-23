using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Analytics.Integration;

public class AnalyticsHelper
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<char, bool> _003C_003E9__3_0;

		public static Func<char, bool> _003C_003E9__3_1;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal bool _003CGetLocalCurrencyPriceAsFloat_003Eb__3_0(char c)
		{
			return c == '.';
		}

		internal bool _003CGetLocalCurrencyPriceAsFloat_003Eb__3_1(char c)
		{
			return c == ',';
		}
	}

	private static Dictionary<string, string> AndroidOsVersionByApiVersion;

	private static List<KeyValuePair<string, string>> AndroidApiVersionByOsVersion;

	private static Func<char, bool> _003C_003Ef__mg_0024cache0;

	public unsafe static float GetLocalCurrencyPriceAsFloat(string localPriceWithCurrency, InAppItemModel.ItemType itemType, string itemTitleId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected I4, but got Unknown
		//IL_0504: Expected I, but got Obj
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Ref, but got Unknown
		//IL_0648: Expected F4, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected Obj, but got Unknown
		//IL_031b: Expected Obj, but got I4
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected I4, but got Unknown
		//IL_0358: Expected Obj, but got I4
		//IL_044e: Expected Obj, but got I4
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [52F92C]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		CultureInfo cultureInfo = default;
		cultureInfo._002Ector("en-US");
		int num = 0;
		string text = string.Empty;
		int num2;
		for (; num < localPriceWithCurrency._stringLength; num2 = num + 1, num = num2)
		{
			char c = localPriceWithCurrency.get_Chars(num);
			if (!char.IsDigit(c))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+16]");
				if (!char.IsWhiteSpace('\0'))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+16]");
					object obj3 = -44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+16]");
					if ((nint)0 != 44 && ((nint)obj3 == 1 || (nint)obj3 != 2))
					{
						if (text._stringLength > 0)
						{
							break;
						}
						continue;
					}
				}
			}
			char c2 = (char)(obj + 22);
			string text2 = ((char*)(ushort)c2)->ToString();
			string text3 = text + text2;
			text = text3;
		}
		string text4 = text.Replace(" ", string.Empty);
		string text5 = text4.Trim();
		bool flag3 = _003C_003Ec._003C_003E9__3_0 == null;
		bool flag4 = !flag3;
		Func<char, bool> predicate = _003C_003Ec._003C_003E9__3_0;
		if (!flag4)
		{
			throw new ArgumentException();
		}
		int num3 = Enumerable.Count(text5, predicate);
		bool flag5 = _003C_003Ec._003C_003E9__3_1 == null;
		bool flag6 = !flag5;
		Func<char, bool> predicate2 = _003C_003Ec._003C_003E9__3_1;
		if (!flag6)
		{
			throw new ArgumentException();
		}
		int num4 = Enumerable.Count(text5, predicate2);
		_ = 46;
		int num5 = num4;
		int num6 = num3;
		int num7 = -1;
		string text6 = string.Empty;
		int num8 = 0;
		IFormatProvider provider = default;
		while (true)
		{
			if (text5._stringLength > num8)
			{
				char c3 = text5.get_Chars(num8);
				if (char.IsDigit(c3))
				{
					char c4 = (char)(obj + 20);
					string text7 = ((char*)(ushort)c4)->ToString();
					string text8 = text6 + text7;
					text6 = text8;
					goto IL_0746;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
				if ((nint)0 != 44)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E]");
					if (num9 != 0)
					{
						goto IL_0746;
					}
				}
				bool flag7 = num7 >= 1;
				object obj4 = num8 - num7;
				if ((nint)obj4 >= 3)
				{
					flag7 = false;
				}
				if (flag7)
				{
					break;
				}
				object obj5 = text5._stringLength - num8;
				if ((nint)obj5 < 3)
				{
					break;
				}
				if (num6 >= 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1E]");
					if (num10 == 0)
					{
						int num11 = num6 - 1;
						num6 = num11;
						goto IL_076f;
					}
				}
				if (num5 >= 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
					if ((nint)0 == 44)
					{
						int num12 = num5 - 1;
						num5 = num12;
						goto IL_076f;
					}
				}
				object obj6 = text5._stringLength - num8;
				if ((nint)obj6 == 3)
				{
					int startIndex = num8 + 1;
					string text9 = text5.Substring(startIndex);
					if (ContainsDigits(text9))
					{
						char c5 = (char)(obj + 30);
						string text10 = ((char*)(ushort)c5)->ToString();
						string text11 = text6 + text10;
						text6 = text11;
					}
				}
				goto IL_076f;
			}
			_ = -1082130432;
			nint num13 = (nint)cultureInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v272 @ S3_v7 (Il2CppClass<System.Globalization.CultureInfo>)+134] (should have been resolved before IL gen)");
			if (!float.TryParse(text6, NumberStyles.Float, provider, out *(float*)(obj + 24)))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				float time = Time.time;
				object obj7 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			return 0f;
			IL_076f:
			num7 = num8;
			goto IL_0746;
			IL_0746:
			int num14 = num8 + 1;
			num8 = num14;
		}
		return -1f;
	}

	private static bool ContainsDigits(string text)
	{
		throw new ArgumentException();
	}

	public static string GetAndroidDeviceOsString(string deviceOs)
	{
		//IL_002f: Expected I, but got Obj
		//IL_0065: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		Regex regex = default;
		regex._002Ector("Android OS(?>[a-zA-Z]| |_|\\[|\\])+([0-9]{1,2}\\.[0-9]\\.[0-9]|[0-9]{1,2}\\.[0-9]).*\\/ API-([0-9]{2})");
		Match match = regex.Match(deviceOs);
		if (((System.Text.RegularExpressions.Group)match)._capcount != 0)
		{
			nint num = (nint)match;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S1_v16 (Il2CppClass<System.Text.RegularExpressions.Match>)+E4] (should have been resolved before IL gen)");
			GroupCollection groupCollection = default;
			System.Text.RegularExpressions.Group obj = groupCollection.get_Item(1);
			string value = obj.Value;
			nint num2 = (nint)match;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S1_v21 (Il2CppClass<System.Text.RegularExpressions.Match>)+E4] (should have been resolved before IL gen)");
			GroupCollection groupCollection2 = default;
			System.Text.RegularExpressions.Group obj2 = groupCollection2.get_Item(2);
			string value2 = obj2.Value;
			return GetAndroidDeviceOsString(value, value2);
		}
		Regex regex2 = default;
		regex2._002Ector("\\/ API-([0-9]{2})");
		Match match2 = regex2.Match(deviceOs);
		if (((System.Text.RegularExpressions.Group)match2)._capcount != 0)
		{
			nint num3 = (nint)match2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S1_v9 (Il2CppClass<System.Text.RegularExpressions.Match>)+E4] (should have been resolved before IL gen)");
			GroupCollection groupCollection3 = default;
			System.Text.RegularExpressions.Group obj3 = groupCollection3.get_Item(1);
			string value3 = obj3.Value;
			string androidOsVersionFromApiVersion = GetAndroidOsVersionFromApiVersion(value3);
			return GetAndroidDeviceOsString(androidOsVersionFromApiVersion, value3);
		}
		return "Android OS 0.0.0 / API-0";
	}

	private static string GetAndroidDeviceOsString(string osVersion, string apiVersion)
	{
		string text = ValidateAndroidOsVersionFromApiVersion(osVersion, apiVersion);
		return "Android OS " + text + " / API-" + apiVersion;
	}

	private unsafe static string GetAndroidOsVersionFromApiVersion(string apiVersion)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object result = obj + 12;
		if (!AndroidOsVersionByApiVersion.TryGetValue(apiVersion, out *(string*)(obj + 12)))
		{
			result = "0.0.0";
		}
		return (string)result;
	}

	private static string ValidateAndroidOsVersionFromApiVersion(string osVersion, string apiVersion)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got F4
		//IL_003c: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj4 = default;
		string text = default;
		object obj5 = default;
		while (true)
		{
			List<KeyValuePair<string, string>> androidApiVersionByOsVersion = AndroidApiVersionByOsVersion;
			object obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v8 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.String, System.String>>)+C]");
			if ((nint)obj3 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40A");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				if (text.StartsWith((string)0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					if (apiVersion.Equals((string)0))
					{
						break;
					}
				}
				obj4 = obj5 + 1;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			float time = Time.time;
			obj = time;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
		string result = default;
		return result;
	}

	static AnalyticsHelper()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0536: Expected Obj, but got I
		//IL_055c: Expected Obj, but got I
		//IL_0582: Expected Obj, but got I
		//IL_05a8: Expected Obj, but got I
		//IL_05ce: Expected Obj, but got I
		//IL_05f4: Expected Obj, but got I
		//IL_061a: Expected Obj, but got I
		//IL_0640: Expected Obj, but got I
		//IL_0666: Expected Obj, but got I
		//IL_068c: Expected Obj, but got I
		//IL_06b2: Expected Obj, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected VT, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected VT, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected VT, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected VT, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected VT, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected VT, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected VT, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected VT, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected VT, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected VT, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected VT, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected VT, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected VT, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected VT, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected VT, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected VT, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 416;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S5_v4+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S5_v9+4] (should have been resolved before IL gen)");
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ S5_v14+4] (should have been resolved before IL gen)");
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S5_v19+4] (should have been resolved before IL gen)");
		nint num11 = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S5_v23 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v121 @ S5_v24+4] (should have been resolved before IL gen)");
		nint num13 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S5_v28 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ S5_v29+4] (should have been resolved before IL gen)");
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S5_v33 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ S5_v34+4] (should have been resolved before IL gen)");
		nint num17 = 0;
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S5_v38 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ S5_v39+4] (should have been resolved before IL gen)");
		nint num19 = 0;
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S5_v43 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ S5_v44+4] (should have been resolved before IL gen)");
		nint num21 = 0;
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S5_v48 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ S5_v49+4] (should have been resolved before IL gen)");
		nint num23 = 0;
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S5_v53 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ S5_v54+4] (should have been resolved before IL gen)");
		Dictionary<string, string> androidOsVersionByApiVersion = default;
		AndroidOsVersionByApiVersion = androidOsVersionByApiVersion;
		List<KeyValuePair<string, string>> list = default;
		list._002Ector();
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+198]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+198]");
		_ = 0;
		KeyValuePair<string, string> item = (KeyValuePair<string, string>)(obj + 136);
		list.Add(item);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+188]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+188]");
		_ = 0;
		KeyValuePair<string, string> item2 = (KeyValuePair<string, string>)(obj + 128);
		list.Add(item2);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
		_ = 0;
		KeyValuePair<string, string> item3 = (KeyValuePair<string, string>)(obj + 120);
		list.Add(item3);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+168]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+168]");
		_ = 0;
		KeyValuePair<string, string> item4 = (KeyValuePair<string, string>)(obj + 112);
		list.Add(item4);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+158]");
		_ = 0;
		KeyValuePair<string, string> item5 = (KeyValuePair<string, string>)(obj + 104);
		list.Add(item5);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+148]");
		_ = 0;
		KeyValuePair<string, string> item6 = (KeyValuePair<string, string>)(obj + 96);
		list.Add(item6);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+138]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+138]");
		_ = 0;
		KeyValuePair<string, string> item7 = (KeyValuePair<string, string>)(obj + 88);
		list.Add(item7);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
		_ = 0;
		KeyValuePair<string, string> item8 = (KeyValuePair<string, string>)(obj + 80);
		list.Add(item8);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
		_ = 0;
		KeyValuePair<string, string> item9 = (KeyValuePair<string, string>)(obj + 72);
		list.Add(item9);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
		_ = 0;
		KeyValuePair<string, string> item10 = (KeyValuePair<string, string>)(obj - -64);
		list.Add(item10);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
		_ = 0;
		KeyValuePair<string, string> item11 = (KeyValuePair<string, string>)(obj + 56);
		list.Add(item11);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
		_ = 0;
		KeyValuePair<string, string> item12 = (KeyValuePair<string, string>)(obj + 48);
		list.Add(item12);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
		_ = 0;
		KeyValuePair<string, string> item13 = (KeyValuePair<string, string>)(obj + 40);
		list.Add(item13);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		KeyValuePair<string, string> item14 = (KeyValuePair<string, string>)(obj + 32);
		list.Add(item14);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		_ = 0;
		KeyValuePair<string, string> item15 = (KeyValuePair<string, string>)(obj + 24);
		list.Add(item15);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
		_ = 0;
		KeyValuePair<string, string> item16 = (KeyValuePair<string, string>)(obj + 16);
		list.Add(item16);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
		_ = 0;
		KeyValuePair<string, string> item17 = (KeyValuePair<string, string>)(obj + 8);
		list.Add(item17);
		AndroidApiVersionByOsVersion = list;
	}
}
