using System;
using System.Collections.Generic;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Monetization.Offerwall;
using UnityEngine;

public class OfferWallDataManager : IOfferWallDataManager
{
	private const string OFFERWALL_DISABLED_ONLINE_SETTING = "offerwall_disabled";

	private const string NUMBER_OF_EARNERS_ONLINE_SETTING = "offerwall_number_of_earners";

	private const string OFFERS_REFRESH_INTERVAL_AFTER_SUCCESS_ONLINE_SETTING = "offerwall_offers_refresh_interval_after_success";

	private const string OFFERS_REFRESH_INTERVAL_AFTER_FAIL_ONLINE_SETTING = "offerwall_offers_refresh_interval_after_fail";

	private const string REWARDS_REFRESH_INTERVAL_AFTER_SUCCESS_ONLINE_SETTING = "offerwall_rewards_refresh_interval_after_success";

	private const string REWARDS_REFRESH_INTERVAL_AFTER_FAIL_ONLINE_SETTING = "offerwall_rewards_refresh_interval_after_fail";

	private const string MIN_REWARD_ALLOWED_ONLINE_SETTING = "offerwal_min_reward_allowed";

	private const string MAX_REWARD_ALLOWED_ONLINE_SETTING = "offerwall_max_reward_allowed";

	private const string FILTER_MINMAX_REWARD_ONLINE_SETTING = "offerwall_filter_min_max_reward";

	private const string FILTER_FREE_OFFERS_ONLINE_SETTING = "offerwall_filter_free";

	private const string FILTER_OFFER_TYPE = "offerwall_filter_offer_type";

	private const string OFFERWALL_REQUEST_TIMEOUT = "offerwall_request_timeout";

	private const bool DEFAULT_DISABLED_ONLINE_SETTING = false;

	private const int DEFAULT_NUMBER_OF_EARNERS = 14;

	private const int DEFAULT_OFFERS_REFRESH_INTERVAL_AFTER_FAIL = 30;

	private const int DEFAULT_OFFERS_REFRESH_INTERVAL_AFTER_SUCCESS = 3600;

	private const int DEFAULT_REWARDS_REFRESH_INTERVAL_AFTER_FAIL = 30;

	private const int DEFAULT_REWARDS_REFRESH_INTERVAL_AFTER_SUCCESS = 120;

	private const int DEFAULT_OFFERWALL_REQUEST_TIMEOUT = 10;

	private const int DEFAULT_MIN_REWARD = 10;

	private const int DEFAULT_MAX_REWARD = 10000;

	private const string DEFAULT_OFFER_COST = "Free";

	private const string DEFAULT_OFFER_TYPE = "App";

	private const bool DEFAULT_FILTER_MIN_MAX = true;

	private const bool DEFAULT_FILTER_FREE_OFFERS = true;

	private const bool DEFAULT_FILTER_OFFER_TYPE = true;

	private const string DEFAULT_EXTERNAL_IP_URL = "http://hoodrunner.kiloo.com/externalip.php";

	public bool isOfferWallDisabled
	{
		get
		{
			OnlineSettings instance = OnlineSettings.instance;
			return instance.GetValue("offerwall_disabled", defaultValue: false);
		}
	}

	public int offersRefreshIntervalAfterSuccess
	{
		get
		{
			OnlineSettings instance = OnlineSettings.instance;
			return instance.GetValue("offerwall_offers_refresh_interval_after_success", 3600);
		}
	}

	public int offersRefreshIntervalAfterFail
	{
		get
		{
			OnlineSettings instance = OnlineSettings.instance;
			return instance.GetValue("offerwall_offers_refresh_interval_after_fail", 30);
		}
	}

	public int rewardsRefreshIntervalAfterSuccess
	{
		get
		{
			OnlineSettings instance = OnlineSettings.instance;
			return instance.GetValue("offerwall_rewards_refresh_interval_after_success", 120);
		}
	}

	public int rewardsRefreshIntervalAfterFail
	{
		get
		{
			OnlineSettings instance = OnlineSettings.instance;
			return instance.GetValue("offerwall_rewards_refresh_interval_after_fail", 30);
		}
	}

	public int requestTimeout
	{
		get
		{
			OnlineSettings instance = OnlineSettings.instance;
			return instance.GetValue("offerwall_request_timeout", 10);
		}
	}

	public string externalIpUrl => "http://hoodrunner.kiloo.com/externalip.php";

	public int GetNumberOfOffersToRequest()
	{
		int valueFromOnlineSettings = ((OfferWallDataManager)null).GetValueFromOnlineSettings(14, "offerwall_number_of_earners");
		int numberOfDisplayedNonOfferEarners = EarnCoinsData.GetNumberOfDisplayedNonOfferEarners();
		bool flag = valueFromOnlineSettings > 0;
		int num = valueFromOnlineSettings;
		if (!flag)
		{
			num = 0;
		}
		if (numberOfDisplayedNonOfferEarners < num)
		{
			return num - numberOfDisplayedNonOfferEarners;
		}
		return 1;
	}

	public string GetSDKAppID(OfferWallProviderID providerID)
	{
		if (providerID == OfferWallProviderID.TapJoy)
		{
			AdConstants instance = AdConstants.instance;
			return instance.TapJoyAppId;
		}
		return string.Empty;
	}

	public string GetSDKAppKey(OfferWallProviderID providerID)
	{
		if (providerID == OfferWallProviderID.TapJoy)
		{
			AdConstants instance = AdConstants.instance;
			return instance.TapJoyAppKey;
		}
		return string.Empty;
	}

	public string GetSDKEventName(OfferWallProviderID providerID)
	{
		if (providerID == OfferWallProviderID.TapJoy)
		{
			AdConstants instance = AdConstants.instance;
			return instance.TapJoyEventName;
		}
		return string.Empty;
	}

	public unsafe Dictionary<OfferWallFilterType, string> GetFilters()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected I4, but got Unknown
		//IL_009b: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected I4, but got Unknown
		//IL_0141: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I
		object obj = default;
		OfferWallDataManager offerWallDataManager = (OfferWallDataManager)(obj - 16);
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Kiloo.Monetization.Offerwall.OfferWallFilterType, System.String>>>)+4] (should have been resolved before IL gen)");
		OnlineSettings instance = OnlineSettings.instance;
		if (instance.GetValue("offerwall_filter_min_max_reward", defaultValue: true))
		{
			int valueFromOnlineSettings = offerWallDataManager.GetValueFromOnlineSettings(10, "offerwal_min_reward_allowed");
			int num3 = offerWallDataManager + 12;
			string text = ((int*)num3)->ToString();
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S5_v16 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Kiloo.Monetization.Offerwall.OfferWallFilterType, System.String>>)+5C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ S5_v17+4] (should have been resolved before IL gen)");
			int valueFromOnlineSettings2 = offerWallDataManager.GetValueFromOnlineSettings(10000, "offerwall_max_reward_allowed");
			int num6 = offerWallDataManager + 12;
			string text2 = ((int*)num6)->ToString();
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S5_v21 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Kiloo.Monetization.Offerwall.OfferWallFilterType, System.String>>)+5C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ S5_v22+4] (should have been resolved before IL gen)");
		}
		OnlineSettings instance2 = OnlineSettings.instance;
		if (instance2.GetValue("offerwall_filter_free", defaultValue: true))
		{
			nint num9 = 0;
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S5_v11 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Kiloo.Monetization.Offerwall.OfferWallFilterType, System.String>>)+5C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ S5_v12+4] (should have been resolved before IL gen)");
		}
		OnlineSettings instance3 = OnlineSettings.instance;
		if (instance3.GetValue("offerwall_filter_offer_type", defaultValue: true))
		{
			nint num11 = 0;
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S5_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Kiloo.Monetization.Offerwall.OfferWallFilterType, System.String>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ S5_v7+4] (should have been resolved before IL gen)");
		}
		Dictionary<OfferWallFilterType, string> result = default;
		return result;
	}

	private unsafe int GetValueFromOnlineSettings(int defaultValue, string onlineSettingKey)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Ref, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Ref, but got Unknown
		//IL_0055: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		_ = string.Empty;
		OnlineSettings instance = OnlineSettings.instance;
		int result2 = default;
		if (instance.TryGetValue(onlineSettingKey, out *(string*)(obj + 12)))
		{
			_ = 0;
			ref int result = ref *(int*)(obj + 8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			bool flag = int.TryParse((string)0, out result);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			result2 = 0;
			if (!flag)
			{
				int num = default;
				result2 = num;
			}
		}
		return result2;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "OfferWallManager: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
