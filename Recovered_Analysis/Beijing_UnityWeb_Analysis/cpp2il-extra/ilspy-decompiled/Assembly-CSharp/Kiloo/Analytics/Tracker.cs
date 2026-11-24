using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using InAppPurchase;
using Info;
using Kiloo.Common;
using Kiloo.Common.Plugins.DeviceUtility;
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

	internal const string PARAMETER_MYSTERY_BOXES_COLLECTED_IN_RUN = "MB_cnt";

	internal const string PARAMETER_FIRST_MYSTERY_BOX_COLLECTED_IN_RUN = "MB1_sec";

	internal const string PARAMETER_DAILY_LETTERS_COLLECTED_IN_RUN = "d_let_cnt";

	internal const string PARAMETER_CHARACTER_LETTERS_COLLECTED_IN_RUN = "c_let_cnt";

	private const string EVENT_NAME_STATIC_DATA = "static";

	private const string PARAMETER_DATA_INSTALL_DATE = "inst_date";

	private const string PARAMETER_DATA_FLURRY_ID = "flurry";

	private const string EVENT_NAME_DAILY_DATA = "daily";

	private const string PARAMETER_DEVICE_LOCALE = "locale";

	private const string EVENT_NAME_MADE_ONE_PURCHASE = "one_iap";

	private const string EVENT_NAME_IN_APP_PURCHASE = "iap_val";

	private const string PARAMETER_IAP_PRODUCT_ID = "pid";

	private const string PARAMETER_IAP_PRODUCT_LOCALIZED_PRICE = "loc_price";

	private const string PARAMETER_IAP_INSTALL_DATE = "inst_date";

	private const string EVENT_NAME_ABTEST_DAILY_REPORT = "abtest_day";

	private const string PARAMETER_ABTEST_IDENTIFIER = "id";

	private const string PARAMETER_ABTEST_PAYLOAD = "pl";

	private const string EVENT_NAME_SYBO_USER_ID = "sybo_id";

	private const string PARAMETER_SYBO_USER_ID = "uid";

	private const string EVENT_NAME_PLAYER_BIRTHDAY = "bday";

	private const string PARAMETER_PLAYER_BIRTHDAY_YEAR = "year";

	private const string PARAMETER_PLAYER_BIRTHDAY_MONTH = "month";

	private const string EVENT_NAME_CONSENT_GIVEN = "cons_give";

	private const string EVENT_NAME_CONSENT_WITHDRAWN = "cons_with";

	private const string PARAMETER_CONSENT_RESULT = "res";

	private const string EVENT_NAME_CONSENT_PRIVACY_POLICY_LINK_OPENED = "cons_privacy";

	private static Event GetStaticData()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Event obj = default;
		obj.name = null;
		return obj;
	}

	private static Event GetDailyData()
	{
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_01f4: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_022f: Expected Obj, but got VT
		//IL_0257: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02ab: Expected I, but got Obj
		//IL_02c1: Expected Obj, but got I
		//IL_00cb: Expected I, but got Obj
		//IL_02fd: Expected Obj, but got I
		//IL_030d: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected Obj, but got Unknown
		//IL_0118: Expected I, but got Obj
		//IL_0165: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		string abTestPlayerSeed = AnalyticsSave.abTestPlayerSeed;
		if (abTestPlayerSeed != null)
		{
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @91EE");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S3_v4+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v81 @ S4_v5 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v20 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num3 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v60 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastTimeAVideoForKeysWasSeen = UserSave.lastTimeAVideoForKeysWasSeen;
		nint num4 = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v27 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num5 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v56 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = lastTimeAVideoForKeysWasSeen;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D76F");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S4_v8+60]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S4_v9+48]");
		object obj12 = 0;
		object obj13 = obj12 & 0x7FF;
		object obj14 = obj13 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v137 @ S5_v7 (should have been resolved before IL gen)");
		nint num7 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v38 (Il2CppClass<Flurry>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num8 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v52 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool wasInitialized = Flurry.wasInitialized;
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S4_v12 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S4_v13+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S4_v14+48]");
		object obj18 = 0;
		object obj19 = obj18 & 0x7FF;
		object obj20 = obj19 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S5_v11 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Event obj22 = default;
		object obj21 = obj22 + 8;
		obj21 = "static";
		object obj23 = obj22 + 12;
		object obj24 = default;
		obj23 = obj24;
		return obj22;
	}

	private static Event GetSyboUserId()
	{
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0142: Expected Obj, but got VT
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got VT
		//IL_0057: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_00e4: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		DateTime abTestLastDailyEventsReportDate = AnalyticsSave.abTestLastDailyEventsReportDate;
		obj = abTestLastDailyEventsReportDate;
		string text = (string)(obj2 + 16);
		text = (string)obj;
		JsonObject jsonObject = JsonObject.Deserialize(text);
		if (jsonObject != null)
		{
			return null;
		}
		DateTime today = CDateTime.Today;
		obj2 = today;
		text = (string)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @91F2");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S3_v4+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v93 @ S4_v5 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v24 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num3 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v38 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S4_v8+60]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S4_v9+48]");
		object obj11 = 0;
		object obj12 = obj11 & 0x7FF;
		object obj13 = obj12 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S5_v7 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Event obj15 = default;
		object obj14 = obj15 + 8;
		obj14 = "daily";
		object obj16 = obj15 + 12;
		object obj17 = default;
		obj16 = obj17;
		return obj15;
	}

	private static Event GetSingleValidPurchase()
	{
		//IL_00af: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		if (SyboAnalyticsSave.isSyboAnalyticsUserIdAssigned)
		{
			return null;
		}
		bool flag;
		if (SyboAnalyticsSave.syboAnalyticsCurrentSession != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (System.Int32)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			return null;
		}
		Dictionary<string, string> dictionary = SyboAnalyticsSave.SyboAnalyticsGetPendingOfferRewards();
		if (dictionary != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S3_v3 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S3_v4+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S4_v5 (should have been resolved before IL gen)");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S4_v7 (Il2CppMethodInfo)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S4_v8+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S4_v9+48]");
			object obj8 = 0;
			object obj9 = obj8 & 0x7FF;
			object obj10 = obj9 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S5_v7 (should have been resolved before IL gen)");
			SyboAnalyticsSave.SyboAnalyticsRemovePendingOffer((string)1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Event obj12 = default;
			object obj11 = obj12 + 8;
			obj11 = "sybo_id";
			object obj13 = obj12 + 12;
			object obj14 = default;
			obj13 = obj14;
			return obj12;
		}
		return null;
	}

	private static Event GetValidInAppPurchase(string productId)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Event obj = default;
		obj.name = null;
		object obj2 = obj + 16;
		obj2 = productId;
		return obj;
	}

	private static Event GetPlayerBirthday()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Event obj2 = default;
		object obj = obj2 + 8;
		obj = "one_iap";
		object obj3 = obj2 + 12;
		obj3 = 0;
		return obj2;
	}

	private static Event GetConsentGivenEvent()
	{
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0261: Expected Obj, but got I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0278: Expected Obj, but got I4
		//IL_0286: Expected I, but got Obj
		//IL_029c: Expected Obj, but got I
		//IL_0367: Expected Obj, but got VT
		//IL_037f: Expected I, but got Obj
		//IL_0395: Expected Obj, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got VT
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0134: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v66 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime scheduledFirstInterstitialShowTime = AdsSave.scheduledFirstInterstitialShowTime;
		obj = scheduledFirstInterstitialShowTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<System.DateTime>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v62 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 8;
		obj6 = scheduledFirstInterstitialShowTime;
		obj2 = obj3;
		object obj7 = obj2 + 32;
		obj7 = obj6;
		object obj8 = obj2 + 40;
		obj8 = obj2;
		object obj9 = obj7 & 0x3FFFFFFFFFFFFFFFL;
		object obj10 = obj8 & 0x3FFFFFFFFFFFFFFFL;
		if (obj9 != obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S3_v3 (Il2CppMethodInfo)+C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S3_v4+60]");
			object obj12 = 0;
			object obj13 = obj12;
			object obj14 = obj13 & 0x1FFF;
			object obj15 = obj14 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v112 @ S4_v5 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
			object obj16 = default;
			obj8 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S4_v7 (Il2CppMethodInfo)+C]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S4_v8+60]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S4_v9+48]");
			object obj19 = 0;
			object obj20 = obj19 & 0x7FF;
			object obj21 = obj20 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v170 @ S5_v7 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC8");
			object obj22 = default;
			obj7 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S4_v12 (Il2CppMethodInfo)+C]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S4_v13+60]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S4_v14+48]");
			object obj25 = 0;
			object obj26 = obj25 & 0x7FF;
			object obj27 = obj26 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S5_v11 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Event obj29 = default;
			object obj28 = obj29 + 8;
			obj28 = "bday";
			object obj30 = obj29 + 12;
			object obj31 = default;
			obj30 = obj31;
			return obj29;
		}
		return null;
	}

	private static Event GetConsentWithdrawnEvent(string result)
	{
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_0326: Expected Obj, but got I4
		//IL_033d: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_00e7: Expected I4, but got Obj
		//IL_00e7: Expected I4, but got Obj
		//IL_00fe: Expected I4, but got Obj
		//IL_00fe: Expected I4, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_011a: Expected I4, but got Obj
		//IL_011a: Expected I4, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01f3: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0247: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I
		//IL_0389: Expected Obj, but got VT
		//IL_03a9: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I
		//IL_03c9: Expected Obj, but got I
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_0288: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		string text = (string)(obj2 + 24);
		text = (string)0;
		text.m_stringLength = 0;
		obj2 = 0;
		if (result == null || result.m_stringLength == 0)
		{
			SDebug.LogFormat("Product ID not set", null);
			return null;
		}
		bool isValidationSupportedOnCurrentPlatform = InAppPurchaseProvider.IsValidationSupportedOnCurrentPlatform;
		if (((InAppPurchaseProvider)isValidationSupportedOnCurrentPlatform).StartPurchase(result, text))
		{
			obj = text;
			_ = text.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			Type type = (Type)0;
		}
		else
		{
			object msg = ((IConvertible)"No localized price found for productId, localizedPrice will have default value: \"").ToType((Type)(object)"NULL", (IFormatProvider)(object)"\"");
			SDebug.LogFormat((string)msg, null);
			Type type = (Type)(object)"NULL";
		}
		string text2 = result.Remove((int)"com.kiloo.subways.", (int)string.Empty);
		string text3 = text2.Remove((int)"com.kiloo.subwaysurfers.", (int)string.Empty);
		string text4 = text3.Remove((int)"com.kiloo.subway", (int)string.Empty);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S3_v8 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S3_v9+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v154 @ S4_v5 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S4_v8+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v9+48]");
		object obj10 = 0;
		object obj11 = obj10 & 0x7FF;
		object obj12 = obj11 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v171 @ S5_v7 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S4_v12 (Il2CppMethodInfo)+C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S4_v13+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S4_v14+48]");
		object obj15 = 0;
		object obj16 = obj15 & 0x7FF;
		object obj17 = obj16 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v189 @ S5_v11 (should have been resolved before IL gen)");
		nint num4 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v37 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num5 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v52 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastTimeAVideoForKeysWasSeen = UserSave.lastTimeAVideoForKeysWasSeen;
		obj2 = lastTimeAVideoForKeysWasSeen;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCF5");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S4_v17 (Il2CppMethodInfo)+C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S4_v18+60]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S4_v19+48]");
		object obj21 = 0;
		object obj22 = obj21 & 0x7FF;
		object obj23 = obj22 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v61 @ S5_v15 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Event obj25 = default;
		object obj24 = obj25 + 8;
		obj24 = "iap_val";
		object obj26 = obj25 + 12;
		object obj27 = default;
		obj26 = obj27;
		return obj25;
	}

	private static Event GetConsentPrivacyLinkClickedEvent()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Event obj2 = default;
		object obj = obj2 + 8;
		obj = "cons_give";
		object obj3 = obj2 + 12;
		obj3 = 0;
		return obj2;
	}

	private static Event GetABTestDailyReportValue(string identifier)
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S5_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Event obj12 = default;
		object obj11 = obj12 + 8;
		obj11 = "cons_with";
		object obj13 = obj12 + 12;
		object obj14 = default;
		obj13 = obj14;
		return obj12;
	}

	public static void CreateEvent(EventType eventType, Action<Event> onLogReady, string extra = null)
	{
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_0273: Expected I, but got Obj
		//IL_0289: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0315: Expected Obj, but got I4
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_01bd: Expected I, but got Obj
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj = onLogReady & 1;
		nint num = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v65 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		bool flag = (nint)0 != 0;
		bool initialized = Manager._initialized;
		object obj3 = (initialized ? 1 : 0) ^ 1;
		object obj4 = flag & obj3;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v56 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(Manager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v61 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RunTracker.LogRunEndedData((Action<Event>)1);
		}
		nint num5 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v19 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v49 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Manager._initialized ? 1u : 0u) != 0)
		{
			return;
		}
		nint num7 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v28 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v45 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C17");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		object obj9 = default;
		object obj8 = obj9 | 0;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num9 = 0;
			string text = default;
			text.m_stringLength = (int)num9;
			_ = 0;
			object obj10 = text + 16;
			object obj11 = default;
			obj10 = obj11;
			((Event)eventType)._002Ector(text, (Dictionary<string, object>)(object)extra);
		}
	}

	private static bool IsDateToday(DateTime lastDate)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return false;
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[KilooAnalyticsManager] ", (int)msg);
		SDebug.LogFormat(msg2, (object[])(object)context);
	}
}
