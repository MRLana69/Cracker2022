using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

namespace Kiloo.Common.Backend;

public static class KilooWebClient
{
	private const string TAGS_PLAYERPREFS_KEY = "kiloowebclient_tags";

	private static Dictionary<string, string> _clientInfoHeaders;

	private static IDictionary<string, object> _tags;

	private static float defaultRequestTimeout__BackingField;

	private static float defaultKeepAlive__BackingField;

	private static float defaultMinBackOffTime__BackingField;

	private static float defaultMaxBackOffTime__BackingField;

	public static float defaultRequestTimeout
	{
		get
		{
			return defaultRequestTimeout__BackingField;
		}
		set
		{
			defaultRequestTimeout__BackingField = value;
		}
	}

	public static float defaultKeepAlive
	{
		get
		{
			return defaultKeepAlive__BackingField;
		}
		set
		{
			defaultKeepAlive__BackingField = value;
		}
	}

	public static float defaultMinBackOffTime
	{
		get
		{
			return defaultMinBackOffTime__BackingField;
		}
		set
		{
			defaultMinBackOffTime__BackingField = value;
		}
	}

	public static float defaultMaxBackOffTime
	{
		get
		{
			return defaultMaxBackOffTime__BackingField;
		}
		set
		{
			defaultMaxBackOffTime__BackingField = value;
		}
	}

	static KilooWebClient()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
		IDictionary<string, object> tags = default;
		_tags = tags;
		defaultRequestTimeout__BackingField = 0f;
		defaultKeepAlive__BackingField = 5f;
		defaultMinBackOffTime__BackingField = 1f;
		defaultMaxBackOffTime__BackingField = 0f;
	}

	public unsafe static void InitAutomatically(string appId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Ref, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Ref, but got Unknown
		//IL_002d: Expected Obj, but got VT
		//IL_0091: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		obj = 0;
		GetLanguageAndCountry(out *(string*)(obj + 12), out *(string*)(obj + 8));
		DateTime now = CDateTime.Now;
		TimeSpan currentTimeZoneUTCOffset = TimeUtility.GetCurrentTimeZoneUTCOffset(now);
		obj = currentTimeZoneUTCOffset;
		double num = (double)obj * 2.7777777777777777E-11;
		string bundleVersion = DeviceUtility.GetBundleVersion();
		object obj3;
		if (bundleVersion != null)
		{
			obj3 = 0;
			if (bundleVersion._stringLength != 0)
			{
				goto IL_0137;
			}
		}
		obj3 = 1;
		goto IL_0137;
		IL_0137:
		string text = "0.0";
		if (obj3 == null)
		{
			text = bundleVersion;
		}
		string platformIdentifier = GetPlatformIdentifier();
		string deviceModel = SystemInfo.GetDeviceModel();
		string osIdentifier = GetOsIdentifier();
		string osVersion = GetOsVersion();
		string appVersion = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		InitWithClientInfo(appId, appVersion, platformIdentifier, deviceModel, osIdentifier, osVersion, (string)num2, (string)0, (float)num);
	}

	public static void InitWithClientInfo(string appId, string appVersion, string platformId, string deviceModel, string osId, string osVersion, string deviceLanguage, string deviceCountry, float deviceTimeZone)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I4
		//IL_0229: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I4
		//IL_02bc: Expected F8, but got I4
		//IL_02fb: Expected F8, but got I4
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_05fe: Expected Obj, but got F8
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected Obj, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_0355: Expected Obj, but got I
		//IL_037b: Expected Obj, but got I
		//IL_03a1: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I
		//IL_0404: Expected Obj, but got I
		//IL_042a: Expected Obj, but got I
		//IL_0450: Expected Obj, but got I
		//IL_0476: Expected Obj, but got I
		//IL_049c: Expected Obj, but got I
		//IL_04c2: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3;
		if (appId != null)
		{
			obj3 = 0;
			if (appId._stringLength != 0)
			{
				goto IL_050e;
			}
		}
		obj3 = 1;
		goto IL_050e;
		IL_0538:
		object obj4;
		if (obj4 != null)
		{
			return;
		}
		object obj5;
		if (osId != null)
		{
			obj5 = 0;
			if (osId._stringLength != 0)
			{
				goto IL_0546;
			}
		}
		obj5 = 1;
		goto IL_0546;
		IL_0554:
		object obj6;
		if (obj6 != null)
		{
			return;
		}
		object obj7;
		if (deviceLanguage != null)
		{
			obj7 = 0;
			if (deviceLanguage._stringLength != 0)
			{
				goto IL_0562;
			}
		}
		obj7 = 1;
		goto IL_0562;
		IL_050e:
		if (obj3 != null)
		{
			return;
		}
		object obj8;
		if (appVersion != null)
		{
			obj8 = 0;
			if (appVersion._stringLength != 0)
			{
				goto IL_051c;
			}
		}
		obj8 = 1;
		goto IL_051c;
		IL_052a:
		object obj9;
		if (obj9 != null)
		{
			return;
		}
		if (deviceModel != null)
		{
			obj4 = 0;
			if (deviceModel._stringLength != 0)
			{
				goto IL_0538;
			}
		}
		obj4 = 1;
		goto IL_0538;
		IL_0546:
		if (obj5 != null)
		{
			return;
		}
		if (osVersion != null)
		{
			obj6 = 0;
			if (osVersion._stringLength != 0)
			{
				goto IL_0554;
			}
		}
		obj6 = 1;
		goto IL_0554;
		IL_0562:
		if (obj7 != null)
		{
			return;
		}
		object obj10;
		if (deviceCountry != null)
		{
			obj10 = 0;
			if (deviceCountry._stringLength != 0)
			{
				goto IL_0570;
			}
		}
		obj10 = 1;
		goto IL_0570;
		IL_051c:
		if (obj8 != null)
		{
			return;
		}
		if (platformId != null)
		{
			obj9 = 0;
			if (platformId._stringLength != 0)
			{
				goto IL_052a;
			}
		}
		obj9 = 1;
		goto IL_052a;
		IL_0570:
		if (!(deviceTimeZone > 14f) && !(deviceTimeZone < -12f) && obj10 == null)
		{
			double num = Math.Abs((double)deviceTimeZone);
			double num2 = ((!(num < 2147483648.0)) ? (-2147483648.0) : ((double)deviceTimeZone));
			float num3 = deviceTimeZone - (float)num2;
			float num4 = num3 * 60f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num6 = default;
			double num5 = Math.Abs(num6);
			if (!(num5 < 2147483648.0))
			{
				num6 = -2147483648.0;
			}
			object obj11 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj12 = num6 >> 31;
			double num7 = num6 + (double)obj12;
			object obj13 = num7 ^ obj12;
			object obj14 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			object arg2 = default;
			string text = $"{arg:+00;-00}:{arg2:00}";
			nint num8 = 0;
			nint num9 = 0;
			IntPtr intPtr = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v266 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
			nint num10 = 0;
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v282 @ S5_v5+4] (should have been resolved before IL gen)");
			nint num12 = 0;
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v299 @ S5_v10+4] (should have been resolved before IL gen)");
			nint num14 = 0;
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S5_v14 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ S5_v15+4] (should have been resolved before IL gen)");
			nint num16 = 0;
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S5_v19 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v333 @ S5_v20+4] (should have been resolved before IL gen)");
			string text2 = "\"" + deviceModel + "\"";
			nint num18 = 0;
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S5_v24 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v358 @ S5_v25+4] (should have been resolved before IL gen)");
			nint num20 = 0;
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S5_v29 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ S5_v30+4] (should have been resolved before IL gen)");
			nint num22 = 0;
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S5_v34 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v392 @ S5_v35+4] (should have been resolved before IL gen)");
			nint num24 = 0;
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S5_v39 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v409 @ S5_v40+4] (should have been resolved before IL gen)");
			nint num26 = 0;
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S5_v44 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v426 @ S5_v45+4] (should have been resolved before IL gen)");
			nint num28 = 0;
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S5_v49 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v440 @ S5_v50+4] (should have been resolved before IL gen)");
			Dictionary<string, string> clientInfoHeaders = default;
			_clientInfoHeaders = clientInfoHeaders;
			IDictionary<string, object> tags = LoadTags();
			_tags = tags;
		}
	}

	public static IRequest CreatePost(Uri uri)
	{
		return CreateRequest("POST", uri);
	}

	public static IRequest CreateGet(Uri uri)
	{
		return CreateRequest("GET", uri);
	}

	public static IRequest CreatePut(Uri uri)
	{
		return CreateRequest("PUT", uri);
	}

	public static IRequest CreateDelete(Uri uri)
	{
		return CreateRequest("DELETE", uri);
	}

	public static IRequest WithKilooDeviceId(IRequest request)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string deviceIdentifier = DeviceUtility.GetDeviceIdentifier();
		Headers headers2 = default;
		Headers headers = headers2.Set("Kiloo-Device-Id", deviceIdentifier);
		return request;
	}

	public static IRequest WithKilooTags(IRequest request)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string tags = GetTags();
		Headers headers2 = default;
		Headers headers = headers2.Set("Kiloo-Tags", tags);
		return request;
	}

	public static bool HasTag(string tag)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		bool result = default;
		return result;
	}

	public static string GetTags()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		if ((nint)obj >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			string[] value = default;
			return string.Join(",", value);
		}
		return string.Empty;
	}

	public static void AddTags(string[] tags)
	{
		//IL_00db: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		Regex regex = default;
		regex._002Ector("^\\w+$");
		object obj = 0;
		while (true)
		{
			if (tags.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)tags + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v7+10]");
				if (!regex.IsMatch((string)0))
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
				object obj4 = obj + 1;
				obj = obj4;
				continue;
			}
			SaveTags();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ArgumentException ex = default;
		ex._002Ector("Invalid character in tag");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public static void RemoveTags(string[] tags)
	{
		//IL_005e: Expected Obj, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		object obj = 0;
		while (tags.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)tags + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj4 = obj + 1;
			obj = obj4;
		}
		SaveTags();
	}

	private static IRequest CreateRequest(string method, Uri uri)
	{
		IRequest request = HTTPFactory.CreateRequest(method, uri);
		IRequest request2 = RequestExtensions.WithTimeout(request, defaultRequestTimeout__BackingField);
		IRequest request3 = RequestExtensions.WithKeepAlive(request2, defaultKeepAlive__BackingField);
		IRequest request4 = RequestExtensions.WithMinBackOffTime(request3, defaultMinBackOffTime__BackingField);
		IRequest result = RequestExtensions.WithMaxBackOffTime(request4, defaultMaxBackOffTime__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		if (_clientInfoHeaders != null)
		{
			Headers headers2 = default;
			Headers headers = headers2.SetAll(_clientInfoHeaders);
		}
		return result;
	}

	private unsafe static void GetLanguageAndCountry(out string language, out string country)
	{
		//IL_0059: Expected Obj, but got I4
		//IL_003d: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		string locale = DeviceUtility.GetLocale();
		string[] array = locale.Split('-');
		string text = array[0].ToLowerInvariant();
		ref string reference = ref *(string*)text;
		string text2 = language;
		object obj;
		if (language != null)
		{
			obj = 0;
			if (text2._stringLength != 0)
			{
				goto IL_0106;
			}
		}
		obj = 1;
		goto IL_0106;
		IL_0152:
		object obj2;
		ref string reference2;
		if (obj2 != null)
		{
			reference2 = ref *(string*)"US";
		}
		return;
		IL_0106:
		if (obj != null)
		{
			reference = ref *(string*)"en";
		}
		string text3 = ((array.Length < 2) ? null : array[1].ToUpperInvariant());
		reference2 = ref *(string*)text3;
		string text4 = country;
		if (country != null)
		{
			obj2 = 0;
			if (text4._stringLength != 0)
			{
				goto IL_0152;
			}
		}
		obj2 = 1;
		goto IL_0152;
	}

	private static string GetOsIdentifier()
	{
		RuntimePlatform platform = Application.platform;
		bool flag = platform == RuntimePlatform.Android;
		object obj = "android";
		if (!flag)
		{
			obj = "other";
		}
		bool flag2 = platform == RuntimePlatform.IPhonePlayer;
		object result = "ios";
		if (!flag2)
		{
			result = obj;
		}
		return (string)result;
	}

	private static string GetOsVersion()
	{
		//IL_0040: Expected I, but got Obj
		//IL_0064: Expected I, but got Obj
		string operatingSystem = SystemInfo.GetOperatingSystem();
		Regex regex = default;
		regex._002Ector("(?:\\s|^)(\\d+\\.\\d+(?:\\.\\d+)?)(?:\\s|$)");
		Match match = regex.Match(operatingSystem);
		if (((System.Text.RegularExpressions.Group)match)._capcount != 0)
		{
			nint num = (nint)match;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S1_v6 (Il2CppClass<System.Text.RegularExpressions.Match>)+E4] (should have been resolved before IL gen)");
			GroupCollection groupCollection = default;
			System.Text.RegularExpressions.Group obj = groupCollection.get_Item(1);
			nint num2 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S1_v10 (Il2CppClass<System.Text.RegularExpressions.Group>)+D4] (should have been resolved before IL gen)");
			string result = default;
			return result;
		}
		return "0.0";
	}

	private static bool IsKindleDevice()
	{
		return false;
	}

	private static string GetPlatformIdentifier()
	{
		return GetOsIdentifier();
	}

	private static IDictionary<string, object> LoadTags()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
		string text = PlayerPrefs.GetString("kiloowebclient_tags", string.Empty);
		object obj;
		if (text != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00fe;
			}
		}
		obj = 1;
		goto IL_00fe;
		IL_00fe:
		if (obj == null)
		{
			string[] array = text.Split(',');
			object obj2 = 0;
			while ((nint)obj2 < array.Length)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)array + obj3;
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v105 @ S5_v6+4] (should have been resolved before IL gen)");
				object obj6 = obj2 + 1;
				obj2 = obj6;
			}
		}
		IDictionary<string, object> result = default;
		return result;
	}

	private static void SaveTags()
	{
		string tags = GetTags();
		PlayerPrefs.SetString("kiloowebclient_tags", tags);
		PlayerPrefs.Save();
	}

	private static void LogError(string msg)
	{
	}

	private static void Log(string msg)
	{
	}
}
