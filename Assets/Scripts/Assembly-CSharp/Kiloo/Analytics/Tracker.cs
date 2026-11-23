using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Analytics;

internal static class Tracker
{
	internal const string EVENT_NAME_RUN_ENDED = "run_ended";

	internal const string PARAMETER_RUN_LENGTH = "len_sec";

	internal const string PARAMETER_SAVE_ME_COUNT_IN_RUN = "save_count";

	internal const string PARAMETER_RUN_LENGTH_UNTIL_FIRST_SAVE_ME = "len_save";

	internal const string PARAMETER_BASE_MULTIPLIER_START_OF_RUN = "multiply";

	internal const string PARAMETER_HOVERBOARD_COUNT_IN_RUN = "hovb_count";

	internal const string PARAMETER_RUN_WAS_ABORTED = "aborted";

	private const string EVENT_NAME_STATIC_DATA = "static";

	private const string PARAMETER_DATA_INSTALL_DATE = "inst_date";

	private const string PARAMETER_DATA_FLURRY_ID = "flurry";

	private const string EVENT_NAME_MADE_ONE_PURCHASE = "one_iap";

	private const string EVENT_NAME_IN_APP_PURCHASE = "iap_val";

	private const string PARAMETER_IAP_PRODUCT_ID = "pid";

	private const string EVENT_NAME_SYBO_USER_ID = "sybo_id";

	private const string PARAMETER_SYBO_USER_ID = "uid";

	private const string EVENT_NAME_PLAYER_BIRTHDAY = "bday";

	private const string PARAMETER_PLAYER_BIRTHDAY_YEAR = "year";

	private const string PARAMETER_PLAYER_BIRTHDAY_MONTH = "month";

	private static Event GetStaticData()
	{
		//IL_0092: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = (byte)(~(instance._hasLoggedStaticData ? 1u : 0u)) != 0;
		bool flag2 = !flag;
		Event result = null;
		if (!flag2)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			if (!instance2._hasLoggedStaticData)
			{
				instance2._dirty = true;
				instance2._hasLoggedStaticData = true;
			}
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			PlayerInfo instance3 = PlayerInfo.Instance;
			string text = TimeUtility.ToJSON(instance3._firstInstallDate);
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S5_v5+4] (should have been resolved before IL gen)");
			PlayerInfo instance4 = PlayerInfo.Instance;
			string flurryUserIdHash = instance4.flurryUserIdHash;
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ S5_v10+4] (should have been resolved before IL gen)");
			Event obj3 = default;
			obj3.name = "static";
			Dictionary<string, object> parameters = default;
			obj3.parameters = parameters;
			result = obj3;
		}
		return result;
	}

	private static Event GetSyboUserId()
	{
		//IL_0067: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I
		PlayerInfo instance = PlayerInfo.Instance;
		Event result = null;
		if (instance._hasLoggedSyboUserId)
		{
			goto IL_018f;
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		string syboAnalyticsUserId = instance2._syboAnalyticsUserId;
		object obj;
		if (instance2._syboAnalyticsUserId != null)
		{
			obj = 0;
			if (syboAnalyticsUserId._stringLength != 0)
			{
				goto IL_0194;
			}
		}
		obj = 1;
		goto IL_0194;
		IL_0194:
		result = null;
		if (obj != null)
		{
			goto IL_018f;
		}
		PlayerInfo instance3 = PlayerInfo.Instance;
		string syboAnalyticsUserId2 = instance3._syboAnalyticsUserId;
		object obj2;
		if (instance3._syboAnalyticsUserId != null)
		{
			obj2 = 0;
			if (syboAnalyticsUserId2._stringLength != 0)
			{
				goto IL_01a7;
			}
		}
		obj2 = 1;
		goto IL_01a7;
		IL_018f:
		return result;
		IL_01a7:
		object obj3 = obj2 ^ 1;
		bool flag = obj3 == null;
		result = null;
		if (!flag)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S5_v5+4] (should have been resolved before IL gen)");
			PlayerInfo instance4 = PlayerInfo.Instance;
			instance4._dirty = true;
			instance4._hasLoggedSyboUserId = true;
			Event obj5 = default;
			obj5.name = "sybo_id";
			Dictionary<string, object> parameters = default;
			obj5.parameters = parameters;
			result = obj5;
		}
		goto IL_018f;
	}

	private static Event GetSingleValidPurchase()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = (byte)(~(instance._hasMadeOneValidPurchase ? 1u : 0u)) != 0;
		bool flag2 = !flag;
		Event result = null;
		if (!flag2)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			instance2._dirty = true;
			instance2._hasMadeOneValidPurchase = true;
			Event obj = default;
			obj.name = "one_iap";
			obj.parameters = null;
			result = obj;
		}
		return result;
	}

	private static Event GetValidInAppPurchase(string productId)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I
		object obj;
		if (productId != null)
		{
			obj = 0;
			if (productId._stringLength != 0)
			{
				goto IL_0107;
			}
		}
		obj = 1;
		goto IL_0107;
		IL_0107:
		bool flag = obj == null;
		bool flag2 = !flag;
		Event result = null;
		if (!flag2)
		{
			string text = productId.Replace("com.kiloo.subways.", string.Empty);
			string text2 = text.Replace("com.kiloo.subwaysurfers.", string.Empty);
			string text3 = text2.Replace("com.kiloo.subway", string.Empty);
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S5_v5+4] (should have been resolved before IL gen)");
			Event obj3 = default;
			obj3.name = "iap_val";
			Dictionary<string, object> parameters = default;
			obj3.parameters = parameters;
			result = obj3;
		}
		return result;
	}

	private unsafe static Event GetPlayerBirthday()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0028: Expected VT, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected VT, but got Unknown
		//IL_0084: Expected Ref, but got VT
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected VT, but got Unknown
		//IL_00e7: Expected Ref, but got VT
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		DateTime userBirthday = AgeRestriction.GetUserBirthday();
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		Event obj8 = default;
		if (userBirthday != (DateTime)0)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			DateTime dateTime = (DateTime)(obj + 24);
			int year = ((DateTime*)dateTime)->Year;
			object obj4 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ S5_v5+4] (should have been resolved before IL gen)");
			DateTime dateTime2 = (DateTime)(obj + 24);
			int month = ((DateTime*)dateTime2)->Month;
			object obj6 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ S5_v10+4] (should have been resolved before IL gen)");
			obj8.name = "bday";
			Dictionary<string, object> parameters = default;
			obj8.parameters = parameters;
		}
		return obj8;
	}

	public static void CreateEvent(EventType eventType, Action<Event> onLogReady, string extra = null)
	{
		switch (eventType)
		{
		case EventType.RunEnded:
			RunTracker.LogRunEndedData(onLogReady);
			break;
		case EventType.StaticData:
		{
			Event staticData = GetStaticData();
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onLogReady @ L1 (System.Action`1<Kiloo.Analytics.Event>)+C] (should have been resolved before IL gen)");
			break;
		}
		case EventType.SyboUserId:
		{
			Event syboUserId = GetSyboUserId();
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onLogReady @ L1 (System.Action`1<Kiloo.Analytics.Event>)+C] (should have been resolved before IL gen)");
			break;
		}
		case EventType.SingleValidPurchase:
		{
			Event singleValidPurchase = GetSingleValidPurchase();
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onLogReady @ L1 (System.Action`1<Kiloo.Analytics.Event>)+C] (should have been resolved before IL gen)");
			break;
		}
		case EventType.MadeValidPurchase:
		{
			Event validInAppPurchase = GetValidInAppPurchase(extra);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onLogReady @ L1 (System.Action`1<Kiloo.Analytics.Event>)+C] (should have been resolved before IL gen)");
			break;
		}
		case EventType.PlayerBirthdayEntered:
		{
			Event playerBirthday = GetPlayerBirthday();
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onLogReady @ L1 (System.Action`1<Kiloo.Analytics.Event>)+C] (should have been resolved before IL gen)");
			break;
		}
		}
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
		string message = "[KilooAnalyticsTracker] " + msg;
		Debug.Log(message, context);
	}
}
