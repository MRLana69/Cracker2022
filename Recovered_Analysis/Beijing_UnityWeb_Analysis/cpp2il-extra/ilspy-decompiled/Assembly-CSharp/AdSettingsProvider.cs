using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Ads;
using UnityEngine;

public class AdSettingsProvider : IAdSettingsProvider
{
	private const string AGE_RESTRICTION_PREFIX = "_restricted";

	private const char PRIORITY_LIST_PROVIDER_SEPARATOR = ',';

	private const char PRIORITY_LIST_PROVIDER_COMPONENTS_SEPARATOR = ':';

	private const char PRIORITY_LIST_PROVIDER_PRIORITY_WEIGHT_SEPARATOR = '_';

	private const string INTERSTITIAL_GRACE_PERIOD_KEY = "ads_grace_period";

	private const string NUMBER_OF_FAILS_FOR_EACH_PROVIDER = "number_of_fails_for_interstitial";

	private const string GLOBAL_TIME_BETWEEN_INTERSTITIALS_KEY = "global_time_between_interstitials";

	private const string LIMIT_PER_HOUR = "interstitials_limit_per_hour";

	private const string LIMIT_PER_DAY = "interstitials_limit_per_day";

	private const string LOCK_ON_TIME_LIMIT_KEY = "lock_on_time_limit_{0}";

	private const string CACHE_TIMEOUT_LIMIT_ADTYPE_KEY = "cache_timeout_limit_{0}";

	private const string CACHE_TIMEOUT_LIMIT_PROVIDER_KEY = "cache_timeout_limit_{0}_{1}";

	private const string AD_LOCATION_OVERRIDE_CACHE_ID_KEY = "ad_location_{0}_{1}{2}_cacheid";

	private const string AD_LOCATION_TIME_LIMIT_KEY = "ad_location_{0}_time_between_interstitials";

	private const string AD_LOCATION_AVAILABILITY_KEY = "ad_location_{0}_enabled";

	private const string AD_LOCATION_WAIT_WHILE_CACHING_TIME_LIMIT_KEY = "ad_location_{0}_{1}_wait_caching_limit";

	private const string PRIORITY_LIST_VERSION_KEY = "prio_list_{0}_version";

	private const string PROVIDER_MINIMUM_DEVICE_VERSION_KEY = "provider_{0}_{1}_minimum_device_version";

	private const string WATERFALL_LOCATION_LIST_KEY = "{0}_list";

	private const string WATERFALL_ADTYPE_LIST_KEY = "default_{0}_list";

	private const string IMPRESSION_LIMIT_KEY = "impression_limit_{0}_{1}";

	private const uint DEFAULT_INTERSTITIAL_GRACE_PERIOD = 72000u;

	private const int DEFAULT_NUMBER_OF_FAILS_FOR_PROVIDER = 1;

	private const int DEFAULT_GLOBAL_TIME_BETWEEN_INTERSTITIALS = 10;

	private const int DEFAULT_LIMIT_PER_HOUR = 5;

	private const int DEFAULT_LIMIT_PER_DAY = 20;

	private const int DEFAULT_LOCK_ON_TIME_LIMIT_INTERSTITIAL = 72000;

	private const int DEFAULT_LOCK_ON_TIME_LIMIT_VIDEO = 72000;

	private const int DEFAULT_CACHE_TIMEOUT_LIMIT = 10;

	private const bool DEFAULT_AD_LOCATION_AVAILABILITY = false;

	private const int DEFAULT_AD_LOCATION_TIME_LIMIT = 10;

	private const int DEFAULT_AD_LOCATION_WAIT_WHILE_CACHING_TIME_LIMIT = 10;

	private const string DEFAULT_PRIORITY_LIST_VERSION = "notset";

	private const int DEFAULT_IMPRESSION_LIMIT = int.MaxValue;

	private Dictionary<AdType, string> _debugPriorityListVersion;

	private static List<AdProviderInfo> _allInterstitialProviders;

	private static List<AdProviderInfo> _allVideoProviders;

	private static List<string> _interstitialProviderIDs;

	private static List<string> _videoProviderIDs;

	private static Dictionary<string, AdType> _cachedAdTypesForLocationIDs;

	public virtual IList<AdProviderInfo> GetPriorityList(string waterfallID, AdType adType)
	{
		//IL_0139: Expected I, but got Obj
		//IL_014f: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_00b4: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got I4
		//IL_00d0: Expected I, but got Obj
		//IL_0100: Expected I, but got Obj
		//IL_0126: Expected I, but got Obj
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = AdLocations.adLocations == null;
		bool flag2 = !flag;
		ICollection<AdLocationInfo> collection = AdLocations.adLocations;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
			ICollection<AdLocationInfo> collection2 = default;
			collection = collection2;
		}
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v16 (Il2CppClass<AdLocations>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag3 = obj2 == null;
		nint num4 = (nint)typeof(AdLocations);
		if (!flag3)
		{
			nint num5 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v31 (Il2CppClass<AdLocations>)+74]");
			bool flag4 = (nint)0 == 0;
			bool flag5 = !flag4;
			num4 = (nint)typeof(AdLocations);
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(AdLocations);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ L3_v4 (Il2CppClass<AdLocations>)+5C]");
		object obj3 = (nint)0 + (nint)92;
		obj3 = collection;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IList<AdProviderInfo> list = default;
		object obj4 = list + 8;
		obj4 = this;
		object obj5 = adType & AdType.Video;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		return list;
	}

	public virtual TimeSpan GetCacheTimeoutLimit(string providerID, AdType adType)
	{
		//IL_0010: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return (TimeSpan)0;
	}

	public virtual TimeSpan? GetTimeLimitForAdProvider(string providerID, AdType adType)
	{
		//IL_0047: Expected I4, but got Obj
		//IL_0013: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_0025: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (System.Nullable`1<System.TimeSpan>)+C]");
		if ((nint)0 != 0)
		{
			object value = JsonUtility.FromJson((string)adType, (Type)1);
			SetDebugPriorityListVersion((AdType)providerID, (string)value);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PokiUnitySDK pokiUnitySDK = default;
			pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		TimeSpan? result = default;
		return result;
	}

	public virtual TimeSpan GetMinimumShowInterval(AdType adType)
	{
		//IL_0010: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return (TimeSpan)0;
	}

	public virtual uint GetGracePeriodValue()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AdSettingsProvider)+D]");
		return ((nint)0 != 0) ? 1u : 0u;
	}

	public virtual DateTime GetScheduledFirstInterstitialShowTime()
	{
		//IL_0045: Expected Obj, but got I4
		//IL_004f: Expected VT, but got Obj
		//IL_0037: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2768");
		object obj = default;
		object obj2;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v5+8]");
			obj2 = 0;
		}
		else
		{
			obj2 = 0;
		}
		return (DateTime)obj2;
	}

	public virtual bool GetAvailabilityForLocation(string locationID)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		object obj = this + 76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AdSettingsProvider)+58]");
		object obj2 = (nint)0 >> 1;
		object obj3 = this + 84;
		IntPtr intPtr = default;
		object obj4 = obj3 + (nint)intPtr;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		}
		obj3 = obj4;
		object obj5 = obj + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12367");
		object obj6 = this + 32;
		object obj7 = obj6 + (nint)intPtr;
		obj6 = obj7;
		return (byte)(nint)intPtr != 0;
	}

	public virtual bool AreInterstitialsAllowed()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_00b3: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		return (byte)(int)((OnlineSettings)(object)saveDataPath).GetValue("ads_grace_period", (string)72000) != 0;
	}

	public virtual int GetProviderWaitWhileCachingTimeLimit(string adLocationID, string providerID)
	{
		return 0;
	}

	public virtual bool TryGetProviderOverrideSupportedOnPlatform(AdType adType, string providerID, out string supportedDeviceVersion)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + -3020;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5BB1");
		bool result = default;
		return result;
	}

	public virtual TimeSpan GetMinimumShowIntervalForLocation(string locationID, AdType adType)
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01d7: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00ec: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_012d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = adType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = $"cache_timeout_limit_{args}";
		string key = text.ToLowerInvariant();
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v37 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		uint value = ((OnlineSettings)(object)saveDataPath).GetValue(key, 10u);
		obj2 = adType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format = default;
		string text2 = string.Format((IFormatProvider)(object)"cache_timeout_limit_{0}_{1}", format, locationID);
		string key2 = text2.ToLowerInvariant();
		string saveDataPath2 = OnlineSettings.GetSaveDataPath();
		uint value2 = ((OnlineSettings)(object)saveDataPath2).GetValue(key2, value);
		nint num3 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v16 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v22 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
		TimeSpan result = default;
		return result;
	}

	public virtual void UpdateProviderCacheIDs()
	{
	}

	private static IEnumerable<AdProviderInfo> GetAllProvidersForAdType(AdType adType)
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES ? 1u : 0u) == 0)
		{
			return (IEnumerable<AdProviderInfo>)1;
		}
		nint num3 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int inAppLegacyPurchaseCount = UserSave.inAppLegacyPurchaseCount;
		return (IEnumerable<AdProviderInfo>)(inAppLegacyPurchaseCount ^ 1);
	}

	public unsafe virtual Dictionary<AdLocationInfo, string> GetProviderCacheIDs(string providerId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected VT, but got Unknown
		//IL_07e6: Expected VT, but got I4
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected Obj, but got Unknown
		//IL_07fd: Expected Obj, but got I4
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected Obj, but got Unknown
		//IL_0827: Expected I, but got Obj
		//IL_083d: Expected Obj, but got I
		//IL_0a67: Expected Obj, but got I
		//IL_0a77: Expected Obj, but got I
		//IL_0a87: Expected Obj, but got I
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Expected Obj, but got Unknown
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected Obj, but got Unknown
		//IL_0104: Expected VT, but got Obj
		//IL_0021: Expected I, but got Obj
		//IL_01dc: Expected I, but got Obj
		//IL_01f2: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_087a: Expected VT, but got I4
		//IL_021d: Expected I, but got Obj
		//IL_08ad: Expected Ref, but got VT
		//IL_08c7: Expected Obj, but got I
		//IL_08d7: Expected Obj, but got I
		//IL_08e7: Expected Obj, but got I
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected Obj, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected Obj, but got Unknown
		//IL_00af: Expected I, but got Obj
		//IL_06a1: Expected I, but got Obj
		//IL_06b7: Expected Obj, but got I
		//IL_0178: Expected I, but got Obj
		//IL_026a: Expected I, but got Obj
		//IL_0280: Expected Obj, but got I
		//IL_0a09: Expected Obj, but got I4
		//IL_06e2: Expected I, but got Obj
		//IL_072a: Expected Ref, but got VT
		//IL_0358: Expected I, but got Obj
		//IL_036e: Expected Obj, but got I
		//IL_02ab: Expected I, but got Obj
		//IL_02f2: Expected Obj, but got VT
		//IL_0328: Expected Obj, but got I4
		//IL_0784: Expected Obj, but got I4
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected Obj, but got Unknown
		//IL_0399: Expected I, but got Obj
		//IL_03e0: Expected Obj, but got VT
		//IL_0416: Expected Obj, but got I4
		//IL_0441: Expected I, but got Obj
		//IL_0457: Expected Obj, but got I
		//IL_0963: Expected Obj, but got I4
		//IL_0482: Expected I, but got Obj
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Expected Obj, but got Unknown
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Expected Obj, but got Unknown
		//IL_09b0: Expected Obj, but got I4
		//IL_05ec: Expected Obj, but got I
		//IL_0522: Expected Obj, but got I4
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected Obj, but got Unknown
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Expected Obj, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected Obj, but got Unknown
		AdSystemManager adSystemManager = default;
		object obj = adSystemManager + 32;
		AdType? adType = (AdType?)(object)(adSystemManager + 16);
		adType = (AdType?)(object)0;
		object obj2 = adSystemManager + 8;
		obj2 = 0;
		object obj3 = adSystemManager + 24;
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(AdSettingsProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19 (Il2CppClass<AdSettingsProvider>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(AdSettingsProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v237 (Il2CppClass<AdSettingsProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v3+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S2_v4+44]");
		object obj7 = 0;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S3_v4 (should have been resolved before IL gen)");
		object obj10 = default;
		if ((nint)obj10 > -1)
		{
			nint num4 = (nint)typeof(AdSettingsProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v219 (Il2CppClass<AdSettingsProvider>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num5 = (nint)typeof(AdSettingsProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v231 (Il2CppClass<AdSettingsProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AdType adType2 = _cachedAdTypesForLocationIDs.get_Item(providerId);
			_ = 1;
			adType = (AdType?)(object)adType2;
		}
		else
		{
			adSystemManager.Show(null, (Action)(object)providerId);
			adType = (AdType?)(object)adSystemManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Nullable`1<Kiloo.Common.Ads.AdType>)+4]");
			if ((nint)0 != 0)
			{
				nint num6 = (nint)typeof(AdSettingsProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v204 (Il2CppClass<AdSettingsProvider>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num7 = (nint)typeof(AdSettingsProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v212 (Il2CppClass<AdSettingsProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				AdType value = ((AdType?*)adType)->Value;
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S4_v5 (Il2CppMethodInfo)+C]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S4_v6+60]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S4_v7+48]");
				object obj15 = 0;
				object obj16 = obj15 & 0x7FF;
				object obj17 = obj16 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v145 @ S5_v5 (should have been resolved before IL gen)");
			}
			else
			{
				object obj18 = ((IConvertible)"The location with id: ").ToType((Type)(object)providerId, (IFormatProvider)(object)" does NOT have an AdType assigned to it. Please assign an AdType!");
				nint num9 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v87 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num10 = (nint)typeof(AdSystemLog);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S1_v92 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((DebugAdGUI)obj18).Awake();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Nullable`1<Kiloo.Common.Ads.AdType>)+4]");
		if ((nint)0 != 0)
		{
			nint num11 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v69 (Il2CppClass<Globals>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num12 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v188 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_VIDEOADS_PROVIDERS ? 1u : 0u) == 0)
			{
				obj2 = adType;
				bool flag = (nint)obj2 == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11+4]");
				bool flag2 = (nint)0 != 0;
				object obj21 = flag & flag2;
				if (obj21 != null)
				{
					goto IL_0433;
				}
			}
			nint num13 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v154 (Il2CppClass<Globals>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num14 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v172 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_INTERSTITIAL_PROVIDERS ? 1u : 0u) == 0)
			{
				obj2 = adType;
				bool flag3 = obj2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11+4]");
				bool flag4 = (nint)0 != 0;
				object obj23 = flag3 & flag4;
				if (obj23 != null)
				{
					goto IL_0433;
				}
			}
		}
		goto IL_0681;
		IL_0433:
		nint num15 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v79 (Il2CppClass<AdLocations>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num16 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v146 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj25 = 0;
		object obj26 = default;
		object obj27 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj26 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj27 != null)
			{
				obj25 = 1;
			}
		}
		object obj28 = obj3 + 4;
		object obj29 = obj28 + 1;
		obj28 = obj29;
		object obj30 = obj29 << 2;
		object obj31 = obj3 + obj30;
		obj31 = 288;
		object obj32 = default;
		if (obj32 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
		bool flag6 = default;
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
			object obj33 = (nint)0 << 2;
			object obj34 = obj3 + obj33;
			if ((nint)obj34 == 288)
			{
				object obj35 = obj3 + 4;
				if ((nint)obj35 > -1)
				{
					object obj36 = obj35 + -1;
					obj35 = obj36;
				}
				object obj37 = obj25 & 0xFF;
				bool flag5 = obj37 != null;
				flag6 = flag5;
				goto IL_0a04;
			}
		}
		object obj38 = default;
		if (obj38 == null)
		{
			goto IL_0681;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		goto IL_0a04;
		IL_0681:
		string key = $"ad_location_{(object[])(object)providerId}_enabled";
		nint num17 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v42 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj39 = (nint)0 & (nint)0x200;
		if (obj39 != null)
		{
			nint num18 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v64 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		bool flag7 = ((OnlineSettings)(object)saveDataPath).TryGetValue(key, out *(string*)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Nullable`1<Kiloo.Common.Ads.AdType>)+4]");
		bool flag8 = (nint)0 == 0;
		flag6 = flag7;
		if (!flag8)
		{
			AdType value2 = ((AdType?*)adType)->Value;
			bool flag9 = value2 == AdType.Interstitial;
			bool flag10 = !flag9;
			flag6 = flag7;
			if (!flag10)
			{
				NetworkReachability internetReachability = Application.internetReachability;
				bool flag11 = internetReachability == (NetworkReachability)6;
				object obj40 = (flag7 ? 1 : 0) ^ 1;
				object obj41 = flag11 | obj40;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				}
				flag6 = flag11;
			}
		}
		goto IL_0a04;
		IL_0a04:
		return (Dictionary<AdLocationInfo, string>)flag6;
	}

	public virtual string GetCacheID(string adProvider, AdLocationInfo adLocation)
	{
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		string key = string.Format((IFormatProvider)(object)"ad_location_{0}_{1}_wait_caching_limit", adProvider, adLocation);
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v9 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v16 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		return (string)((OnlineSettings)(object)saveDataPath).GetValue(key, 10u);
	}

	public virtual string GetWaterfallID(string adLocationID)
	{
		if (adLocationID != "flurry")
		{
			string flurryApiKey = AdConstants.FlurryApiKey;
			return ((AdConstants)(object)flurryApiKey).AdColonyAppId;
		}
		if (adLocationID != "facebook")
		{
			string flurryApiKey2 = AdConstants.FlurryApiKey;
			return (string)(object)((AdConstants)(object)flurryApiKey2).MobVistaCacheIDs;
		}
		return null;
	}

	public virtual string GetWaterfallID(AdType adType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03c4: Expected I, but got Obj
		//IL_03da: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0164: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I4
		//IL_0323: Expected I, but got Obj
		//IL_0339: Expected Obj, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_0364: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v18 (Il2CppClass<AdLocations>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v99 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj4 = default;
		object obj5 = default;
		string text;
		string text2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj6 = obj2 + 4;
					object obj7 = obj6 + 1;
					obj6 = obj7;
					object obj8 = obj7 << 2;
					object obj9 = obj2 + obj8;
					obj9 = 74;
					text = text2;
					break;
				}
				continue;
			}
			object obj10 = obj2 + 4;
			object obj11 = obj10 + 1;
			obj10 = obj11;
			object obj12 = obj11 << 2;
			object obj13 = obj2 + obj12;
			obj13 = 74;
			text = string.Empty;
			break;
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj2 + obj15;
			if ((nint)obj16 == 74)
			{
				object obj17 = obj2 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_045e;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_045e;
		IL_045e:
		if (text == null || text.m_stringLength == 0)
		{
			string text3 = string.ConcatArray((string[])(object)"WaterfallID is not set for locationID: ", (int)adType);
			nint num3 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v20 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num4 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S1_v25 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DebugAdGUI)(object)text3).Awake();
		}
		return text;
	}

	public virtual string GetLatestVersionForWaterfall(AdLocation adLocation)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = $"default_{args}_list";
		return text.ToLowerInvariant();
	}

	public virtual string[] GetAdProvidersToInitialize()
	{
		//IL_0032: Expected I, but got Obj
		//IL_0048: Expected Obj, but got I
		//IL_0073: Expected I, but got Obj
		//IL_00c0: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_0101: Expected I, but got Obj
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_01b5: Expected I, but got Obj
		if (this != null)
		{
			if ((nint)this == 1)
			{
				nint num = (nint)typeof(AdSettingsProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v25 (Il2CppClass<AdSettingsProvider>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(AdSettingsProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v32 (Il2CppClass<AdSettingsProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (string[])(object)_allVideoProviders;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string text = "GetAllProvidersForAdType: Unhandled AdType " + text2;
			nint num3 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v11 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v16 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DebugAdGUI)(object)text).Awake();
			return null;
		}
		nint num5 = (nint)typeof(AdSettingsProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<AdSettingsProvider>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(AdSettingsProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18 (Il2CppClass<AdSettingsProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string[])(object)_allInterstitialProviders;
	}

	private string[] GetAdColonyZoneIDs()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		string[] result = default;
		return result;
	}

	public virtual AdProviderConfiguration GetConfigurationForProvider(string providerID)
	{
		//IL_0222: Expected Obj, but got I4
		//IL_0230: Expected I, but got Obj
		//IL_0246: Expected Obj, but got I
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0172: Expected I, but got Obj
		//IL_0188: Expected Obj, but got I
		//IL_00d6: Expected I, but got Obj
		//IL_0202: Expected Obj, but got I
		//IL_0296: Expected I4, but got Obj
		//IL_02a2: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I
		//IL_01b3: Expected I, but got Obj
		object result = 0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v63 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_INTERSTITIAL_PROVIDERS ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [providerID @ L1 (System.String)+24]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v60+C]");
			if ((nint)0 == 0)
			{
				goto IL_01f2;
			}
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v26 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v53 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_VIDEOADS_PROVIDERS ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [providerID @ L1 (System.String)+24]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v50+C]");
			if ((nint)0 == 1)
			{
				goto IL_01f2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [providerID @ L1 (System.String)+28]");
		string key = $"prio_list_{(object[])0}_version";
		nint num5 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v38 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v45 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		bool value = ((OnlineSettings)(object)saveDataPath).GetValue(key, (byte)(int)"notset" != 0);
		return (AdProviderConfiguration)value;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [providerID @ L1 (System.String)+24]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		return (AdProviderConfiguration)result;
	}

	public virtual int GetFailCountTolerance(string adProvider, AdType adType)
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_01b8: Expected I4, but got Obj
		//IL_012d: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj3 = default;
		object obj5;
		object arg;
		IFormatProvider provider;
		object arg2;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
			object obj4 = default;
			if (obj4 != null)
			{
				obj5 = obj;
				goto IL_01b3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+1C]");
			object obj6 = num - 0;
			obj2 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			object obj7 = default;
			arg = obj7;
			provider = (IFormatProvider)(object)"Cache ID not found in AdSettingsProvider.GetCacheID for provider: {0} and location: {1} dict size: {2}";
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [adType @ L2 (Kiloo.Common.Ads.AdType)+8]");
			arg2 = 0;
		}
		else
		{
			arg = "null";
			provider = (IFormatProvider)(object)"Cache ID not found in AdSettingsProvider.GetCacheID for provider: {0} and location: {1} dict size: {2}";
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [adType @ L2 (Kiloo.Common.Ads.AdType)+8]");
			arg2 = 0;
		}
		string text = string.Format(provider, adProvider, arg2, arg);
		nint num2 = (nint)typeof(AdSystemLog);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v12 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num3 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v17 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((DebugAdGUI)(object)text).Awake();
		obj5 = "";
		goto IL_01b3;
		IL_01b3:
		return (int)obj5;
	}

	public virtual int GetMaxImpressionForProvider(string adProvider, AdType adType)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		return (int)((OnlineSettings)(object)saveDataPath).GetValue("number_of_fails_for_interstitial", 1u);
	}

	public virtual int GetMaxInterstitialImpressionsPerHour()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_028e: Expected Obj, but got I4
		//IL_002a: Expected I, but got Obj
		//IL_0040: Expected Obj, but got I
		//IL_006b: Expected I, but got Obj
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_0318: Expected Obj, but got I4
		//IL_035b: Expected I4, but got Obj
		//IL_01cd: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = obj;
		_ = -1;
		string flurryApiKey = AdConstants.FlurryApiKey;
		string tapJoyAppId = ((AdConstants)(object)flurryApiKey).TapJoyAppId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v22 (Il2CppClass<AdLocations>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v97 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = default;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
		}
		object obj7 = obj2 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj2 + obj9;
		obj10 = 76;
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj2 + obj12;
			if ((nint)obj13 == 76)
			{
				object obj14 = obj2 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_034e;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_034e;
		IL_034e:
		return (int)list.ToArray();
	}

	public virtual int GetMaxInterstitialImpressionsPerDay()
	{
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT ? 1u : 0u) == 0)
		{
			return int.MaxValue;
		}
		nint num3 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v22 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		return (int)((OnlineSettings)(object)saveDataPath).GetValue("interstitials_limit_per_hour", 5u);
	}

	private static void CacheProviderIDs()
	{
		//IL_05c0: Expected Obj, but got I4
		//IL_05e1: Expected Obj, but got I4
		//IL_05f3: Expected I, but got Obj
		//IL_0609: Expected Obj, but got I
		//IL_0625: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0053: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I4
		//IL_009c: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_00dc: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I
		//IL_010e: Expected Obj, but got I4
		//IL_0125: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_0157: Expected Obj, but got I4
		//IL_0169: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I4
		//IL_01b2: Expected I, but got Obj
		//IL_01c8: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I4
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I4
		//IL_023f: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_0283: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got I4
		//IL_02cc: Expected I, but got Obj
		//IL_02e2: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I4
		//IL_0310: Expected I, but got Obj
		//IL_0326: Expected Obj, but got I
		//IL_0342: Expected Obj, but got I4
		//IL_0359: Expected I, but got Obj
		//IL_036f: Expected Obj, but got I
		//IL_038b: Expected Obj, but got I4
		//IL_039d: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I
		//IL_03cf: Expected Obj, but got I4
		//IL_03e6: Expected I, but got Obj
		//IL_03fc: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I4
		//IL_042a: Expected I, but got Obj
		//IL_0440: Expected Obj, but got I
		//IL_045c: Expected Obj, but got I4
		//IL_0473: Expected I, but got Obj
		//IL_0489: Expected Obj, but got I
		//IL_04a5: Expected Obj, but got I4
		//IL_04b7: Expected I, but got Obj
		//IL_04cd: Expected Obj, but got I
		//IL_04e9: Expected Obj, but got I4
		//IL_0500: Expected I, but got Obj
		//IL_0516: Expected Obj, but got I
		//IL_0532: Expected Obj, but got I4
		//IL_0544: Expected I, but got Obj
		//IL_055a: Expected Obj, but got I
		//IL_0576: Expected Obj, but got I4
		//IL_058d: Expected I, but got Obj
		//IL_05a3: Expected Obj, but got I
		IList<AdProviderInfo> priorityList = ((AdSettingsProvider)(object)"pool1_videos").GetPriorityList((string)1, AdType.Video);
		AdLocations.POOL1_VIDEOS = (AdLocationInfo)priorityList;
		IList<AdProviderInfo> priorityList2 = ((AdSettingsProvider)(object)"pool2_videos").GetPriorityList((string)1, AdType.Video);
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<AdLocations>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = priorityList2;
		IList<AdProviderInfo> priorityList3 = ((AdSettingsProvider)(object)"pool3_videos").GetPriorityList((string)1, AdType.Video);
		nint num2 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v22 (Il2CppClass<AdLocations>)+5C]");
		object obj2 = (nint)0 + (nint)8;
		obj2 = priorityList3;
		IList<AdProviderInfo> priorityList4 = ((AdSettingsProvider)(object)"home_interstitials").GetPriorityList((string)null, AdType.Video);
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v29 (Il2CppClass<AdLocations>)+5C]");
		object obj3 = (nint)0 + (nint)12;
		obj3 = priorityList4;
		IList<AdProviderInfo> priorityList5 = ((AdSettingsProvider)(object)"home_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num4 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v36 (Il2CppClass<AdLocations>)+5C]");
		object obj4 = (nint)0 + (nint)16;
		obj4 = priorityList5;
		IList<AdProviderInfo> priorityList6 = ((AdSettingsProvider)(object)"game_over_interstitials").GetPriorityList((string)null, AdType.Interstitial);
		nint num5 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v43 (Il2CppClass<AdLocations>)+5C]");
		object obj5 = (nint)0 + (nint)20;
		obj5 = priorityList6;
		IList<AdProviderInfo> priorityList7 = ((AdSettingsProvider)(object)"earn_coins_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num6 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v50 (Il2CppClass<AdLocations>)+5C]");
		object obj6 = (nint)0 + (nint)24;
		obj6 = priorityList7;
		IList<AdProviderInfo> priorityList8 = ((AdSettingsProvider)(object)"double_up_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num7 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v57 (Il2CppClass<AdLocations>)+5C]");
		object obj7 = (nint)0 + (nint)28;
		obj7 = priorityList8;
		IList<AdProviderInfo> priorityList9 = ((AdSettingsProvider)(object)"wordy_weekend_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num8 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v64 (Il2CppClass<AdLocations>)+5C]");
		object obj8 = (nint)0 + (nint)32;
		obj8 = priorityList9;
		IList<AdProviderInfo> priorityList10 = ((AdSettingsProvider)(object)"board_button_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num9 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v71 (Il2CppClass<AdLocations>)+5C]");
		object obj9 = (nint)0 + (nint)36;
		obj9 = priorityList10;
		IList<AdProviderInfo> priorityList11 = ((AdSettingsProvider)(object)"revival_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num10 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v78 (Il2CppClass<AdLocations>)+5C]");
		object obj10 = (nint)0 + (nint)40;
		obj10 = priorityList11;
		IList<AdProviderInfo> priorityList12 = ((AdSettingsProvider)(object)"double_coins_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num11 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v85 (Il2CppClass<AdLocations>)+5C]");
		object obj11 = (nint)0 + (nint)44;
		obj11 = priorityList12;
		IList<AdProviderInfo> priorityList13 = ((AdSettingsProvider)(object)"hoverboard_popup_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num12 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v92 (Il2CppClass<AdLocations>)+5C]");
		object obj12 = (nint)0 + (nint)48;
		obj12 = priorityList13;
		IList<AdProviderInfo> priorityList14 = ((AdSettingsProvider)(object)"hoverboard_free_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num13 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v99 (Il2CppClass<AdLocations>)+5C]");
		object obj13 = (nint)0 + (nint)52;
		obj13 = priorityList14;
		IList<AdProviderInfo> priorityList15 = ((AdSettingsProvider)(object)"hoverboard_run_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num14 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v106 (Il2CppClass<AdLocations>)+5C]");
		object obj14 = (nint)0 + (nint)56;
		obj14 = priorityList15;
		IList<AdProviderInfo> priorityList16 = ((AdSettingsProvider)(object)"skip_mission_pause_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num15 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v113 (Il2CppClass<AdLocations>)+5C]");
		object obj15 = (nint)0 + (nint)60;
		obj15 = priorityList16;
		IList<AdProviderInfo> priorityList17 = ((AdSettingsProvider)(object)"skip_mission_tour_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num16 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v120 (Il2CppClass<AdLocations>)+5C]");
		object obj16 = -(-64);
		obj16 = priorityList17;
		IList<AdProviderInfo> priorityList18 = ((AdSettingsProvider)(object)"free_coins_free_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num17 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v127 (Il2CppClass<AdLocations>)+5C]");
		object obj17 = (nint)0 + (nint)68;
		obj17 = priorityList18;
		IList<AdProviderInfo> priorityList19 = ((AdSettingsProvider)(object)"free_coins_popup_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num18 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v134 (Il2CppClass<AdLocations>)+5C]");
		object obj18 = (nint)0 + (nint)72;
		obj18 = priorityList19;
		IList<AdProviderInfo> priorityList20 = ((AdSettingsProvider)(object)"headstart_free_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num19 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v141 (Il2CppClass<AdLocations>)+5C]");
		object obj19 = (nint)0 + (nint)76;
		obj19 = priorityList20;
		IList<AdProviderInfo> priorityList21 = ((AdSettingsProvider)(object)"headstart_run_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num20 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v148 (Il2CppClass<AdLocations>)+5C]");
		object obj20 = (nint)0 + (nint)80;
		obj20 = priorityList21;
		IList<AdProviderInfo> priorityList22 = ((AdSettingsProvider)(object)"scorebooster_free_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num21 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v155 (Il2CppClass<AdLocations>)+5C]");
		object obj21 = (nint)0 + (nint)84;
		obj21 = priorityList22;
		IList<AdProviderInfo> priorityList23 = ((AdSettingsProvider)(object)"scorebooster_run_videos").GetPriorityList((string)1, AdType.Interstitial);
		nint num22 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v162 (Il2CppClass<AdLocations>)+5C]");
		object obj22 = (nint)0 + (nint)88;
		obj22 = priorityList23;
	}

	private static List<AdProviderInfo> GetDebugPriorityList(AdType adType)
	{
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT ? 1u : 0u) == 0)
		{
			return (List<AdProviderInfo>)int.MaxValue;
		}
		nint num3 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v22 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		uint value = ((OnlineSettings)(object)saveDataPath).GetValue("interstitials_limit_per_day", 20u);
		return (List<AdProviderInfo>)value;
	}

	public virtual void SetDebugPriorityListVersion(AdType adType, string value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
	}

	private AdType? GetAdTypeForLocationID(string locationID)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S4_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S4_v4+48]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S5_v4 (should have been resolved before IL gen)");
		AdType? result = default;
		return result;
	}

	public AdSettingsProvider()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1305: Unknown result type (might be due to invalid IL or missing references)
		//IL_130a: Expected Obj, but got Unknown
		//IL_1313: Expected Obj, but got I4
		//IL_132f: Expected I, but got Obj
		//IL_1345: Expected Obj, but got I
		//IL_141c: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_0110: Expected I, but got Obj
		//IL_0fd1: Expected Obj, but got I4
		//IL_0196: Expected I, but got Obj
		//IL_01ac: Expected Obj, but got I
		//IL_0ff9: Expected Obj, but got I4
		//IL_01d7: Expected I, but got Obj
		//IL_1252: Expected Obj, but got I
		//IL_1288: Unknown result type (might be due to invalid IL or missing references)
		//IL_128d: Expected Obj, but got Unknown
		//IL_1021: Expected Obj, but got I4
		//IL_02cd: Expected Obj, but got I4
		//IL_12be: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c3: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_0339: Expected I, but got Obj
		//IL_034f: Expected Obj, but got I
		//IL_037a: Expected I, but got Obj
		//IL_07c4: Expected Obj, but got I4
		//IL_1049: Expected Obj, but got I4
		//IL_08e7: Expected Obj, but got I4
		//IL_0835: Expected Obj, but got I
		//IL_08d9: Expected Obj, but got I4
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected Obj, but got Unknown
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a6: Expected Obj, but got Unknown
		//IL_1071: Expected Obj, but got I4
		//IL_1099: Expected Obj, but got I4
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected Obj, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected Obj, but got Unknown
		//IL_075b: Expected Obj, but got I4
		//IL_10c1: Expected Obj, but got I4
		//IL_10e9: Expected Obj, but got I4
		//IL_1120: Expected Obj, but got I4
		//IL_1148: Expected Obj, but got I4
		//IL_1156: Unknown result type (might be due to invalid IL or missing references)
		//IL_115b: Expected Obj, but got Unknown
		//IL_1164: Unknown result type (might be due to invalid IL or missing references)
		//IL_1169: Expected Obj, but got Unknown
		//IL_1195: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<AdLocations>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v303 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = 0;
		object obj6 = default;
		object obj7;
		object obj9 = default;
		object obj11 = default;
		object obj13 = default;
		object obj15 = default;
		object obj16 = default;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		object obj26 = default;
		object obj28 = default;
		object obj29 = default;
		object obj31 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj6 == null)
			{
				obj7 = 69;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			nint num3 = (nint)typeof(AdSettingsProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v127 (Il2CppClass<AdSettingsProvider>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(AdSettingsProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v293 (Il2CppClass<AdSettingsProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 == null)
			{
				continue;
			}
			nint num5 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v139 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num6 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v284 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			bool flag = obj11 == null;
			bool flag2 = !flag;
			object obj12 = "_restricted";
			if (!flag2)
			{
				obj12 = "";
			}
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj13 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
				nint num7 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ S0_v235 (Il2CppClass<Info.OnlineSettings>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num8 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ S0_v271 (Il2CppClass<Info.OnlineSettings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				if (obj15 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj16 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					}
				}
			}
			object obj17 = 50;
			object obj18 = obj17 - 31;
			if ((nint)obj17 != 31 && (nint)obj18 != 1 && (nint)obj18 != 2)
			{
				if ((nint)obj18 != 3 && (nint)obj18 != 4 && (nint)obj18 != 5)
				{
					if ((nint)obj18 == 6 || (nint)obj18 == 7)
					{
						goto IL_0768;
					}
					if ((nint)obj18 != 8 && (nint)obj18 != 9 && (nint)obj18 != 10)
					{
						if ((nint)obj18 == 11 || (nint)obj18 == 12)
						{
							goto IL_0768;
						}
						if ((nint)obj18 != 13 && (nint)obj18 != 14 && (nint)obj18 != 15 && (nint)obj18 != 16)
						{
							if ((nint)obj18 == 17 || (nint)obj18 == 18)
							{
								goto IL_0768;
							}
							if ((nint)obj18 == 19)
							{
								object obj19 = obj2 + 4;
								object obj20 = obj19 + 1;
								obj19 = obj20;
								object obj21 = obj20 << 2;
								object obj22 = obj2 + obj21;
								obj22 = 174;
								obj23 = obj5;
							}
						}
					}
				}
				goto IL_1430;
			}
			goto IL_0768;
			IL_0768:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			if (obj24 != obj25)
			{
				obj26 = obj24;
				object obj27 = obj28;
				obj7 = 67;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			obj23 = obj29;
			goto IL_1430;
			IL_144d:
			object obj30;
			obj5 = obj30;
			continue;
			IL_1430:
			if (obj31 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj32 = (nint)0 << 2;
				object obj33 = obj2 + obj32;
				if ((nint)obj33 == 174)
				{
					object obj34 = obj2 + 4;
					if ((nint)obj34 > -1)
					{
						object obj35 = obj34 + -1;
						obj34 = obj35;
					}
					obj30 = obj23;
					goto IL_144d;
				}
			}
			if (obj23 != null)
			{
				obj7 = 62;
				break;
			}
			obj30 = 0;
			goto IL_144d;
		}
		object obj36 = obj7 - 11;
		object obj41 = default;
		if ((nint)obj7 != 11)
		{
			if ((nint)obj36 != 1)
			{
				if ((nint)obj36 != 2 && (nint)obj36 != 3)
				{
					if ((nint)obj36 != 4)
					{
						if ((nint)obj36 != 5 && (nint)obj36 != 6 && (nint)obj36 != 7)
						{
							if ((nint)obj36 != 8)
							{
								if ((nint)obj36 != 9 && (nint)obj36 != 10 && (nint)obj36 != 11)
								{
									if ((nint)obj36 != 12)
									{
										if ((nint)obj36 != 13)
										{
											if ((nint)obj36 != 14 && (nint)obj36 != 15 && (nint)obj36 != 16 && (nint)obj36 != 17 && (nint)obj36 != 18 && (nint)obj36 != 19 && (nint)obj36 != 20 && (nint)obj36 != 21 && (nint)obj36 != 22 && (nint)obj36 != 23 && (nint)obj36 != 24 && (nint)obj36 != 25 && (nint)obj36 != 26 && (nint)obj36 != 27 && (nint)obj36 != 28 && (nint)obj36 != 29 && (nint)obj36 != 30 && (nint)obj36 != 31 && (nint)obj36 != 32 && (nint)obj36 != 33 && (nint)obj36 != 34 && (nint)obj36 != 35 && (nint)obj36 != 36 && (nint)obj36 != 37 && (nint)obj36 != 38 && (nint)obj36 != 39 && (nint)obj36 != 40 && (nint)obj36 != 41)
											{
												if ((nint)obj36 != 42)
												{
													if ((nint)obj36 != 43 && (nint)obj36 != 44)
													{
														if ((nint)obj36 != 45)
														{
															if ((nint)obj36 != 46 && (nint)obj36 != 47 && (nint)obj36 != 48 && (nint)obj36 != 49 && (nint)obj36 != 50)
															{
																if ((nint)obj36 != 51)
																{
																	if ((nint)obj36 != 52 && (nint)obj36 != 53 && (nint)obj36 != 54)
																	{
																		if ((nint)obj36 != 55)
																		{
																			if ((nint)obj36 != 56 && (nint)obj36 != 57 && (nint)obj36 == 58)
																			{
																				object obj37 = obj2 + 4;
																				object obj38 = obj37 + 1;
																				obj37 = obj38;
																				object obj39 = obj38 << 2;
																				object obj40 = obj2 + obj39;
																				obj40 = 197;
																				obj41 = obj5;
																			}
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																			obj26 = obj24;
																			object obj42 = default;
																			object obj27 = obj42;
																			obj7 = 67;
																		}
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	obj26 = obj24;
																	object obj43 = default;
																	object obj27 = obj43;
																	obj7 = 67;
																}
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															obj26 = obj24;
															object obj44 = default;
															object obj27 = obj44;
															obj7 = 67;
														}
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													obj26 = obj24;
													object obj45 = default;
													object obj27 = obj45;
													obj7 = 67;
												}
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											obj26 = obj24;
											object obj46 = default;
											object obj27 = obj46;
											obj7 = 67;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										obj26 = obj24;
										object obj47 = default;
										object obj27 = obj47;
										obj7 = 67;
									}
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj26 = obj24;
								object obj48 = default;
								object obj27 = obj48;
								obj7 = 67;
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj26 = obj24;
						object obj49 = default;
						object obj27 = obj49;
						obj7 = 67;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				obj26 = obj24;
				object obj50 = default;
				object obj27 = obj50;
				obj7 = 67;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj26 = obj24;
			object obj51 = default;
			object obj27 = obj51;
			obj7 = 67;
		}
		if ((nint)obj7 == 67)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj52 = default;
			if (obj26 == obj52)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				object obj53 = default;
				obj41 = obj53;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
		}
		object obj54 = default;
		if (obj54 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj55 = (nint)0 << 2;
			object obj56 = obj2 + obj55;
			if ((nint)obj56 == 197)
			{
				object obj57 = obj2 + 4;
				if ((nint)obj57 > -1)
				{
					object obj58 = obj57 + -1;
					obj57 = obj58;
				}
				return;
			}
		}
		if (obj41 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	static AdSettingsProvider()
	{
		//IL_03fc: Expected I, but got Obj
		//IL_0412: Expected Obj, but got I
		//IL_0632: Expected I, but got Obj
		//IL_0648: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_021d: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_05bb: Expected I, but got Obj
		//IL_05d1: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0278: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_02c5: Expected I, but got Obj
		//IL_02db: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0306: Expected I, but got Obj
		//IL_01bd: Expected I, but got Obj
		//IL_0353: Expected I, but got Obj
		//IL_0369: Expected Obj, but got I
		//IL_0394: Expected I, but got Obj
		nint num = (nint)typeof(AdSettingsProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AdSettingsProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdSettingsProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v136 (Il2CppClass<AdSettingsProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<string> videoProviderIDs = _videoProviderIDs;
		if (videoProviderIDs._size == 0)
		{
			int num5 = default;
			int num10 = default;
			while (true)
			{
				nint num3 = (nint)typeof(AdSettingsProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v89 (Il2CppClass<AdSettingsProvider>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(AdSettingsProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v130 (Il2CppClass<AdSettingsProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<AdProviderInfo> allVideoProviders = _allVideoProviders;
				if (num5 >= allVideoProviders._size)
				{
					break;
				}
				nint num6 = (nint)typeof(AdSettingsProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v98 (Il2CppClass<AdSettingsProvider>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(AdSettingsProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v124 (Il2CppClass<AdSettingsProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				AdProviderInfo adProviderInfo = _allVideoProviders.get_Item(num5);
				if (!_videoProviderIDs.Contains(adProviderInfo.providerID__BackingField))
				{
					nint num8 = (nint)typeof(AdSettingsProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v111 (Il2CppClass<AdSettingsProvider>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num9 = (nint)typeof(AdSettingsProvider);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v118 (Il2CppClass<AdSettingsProvider>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					AdProviderInfo adProviderInfo2 = _allVideoProviders.get_Item(num5);
					_videoProviderIDs.Add(adProviderInfo2.providerID__BackingField);
				}
				num5 = num10 + 1;
			}
		}
		nint num11 = (nint)typeof(AdSettingsProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v19 (Il2CppClass<AdSettingsProvider>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num12 = (nint)typeof(AdSettingsProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v81 (Il2CppClass<AdSettingsProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<string> interstitialProviderIDs = _interstitialProviderIDs;
		if (interstitialProviderIDs._size != 0)
		{
			return;
		}
		int num13 = 0;
		while (true)
		{
			nint num14 = (nint)typeof(AdSettingsProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v34 (Il2CppClass<AdSettingsProvider>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num15 = (nint)typeof(AdSettingsProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v75 (Il2CppClass<AdSettingsProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<AdProviderInfo> allInterstitialProviders = _allInterstitialProviders;
			if (num13 >= allInterstitialProviders._size)
			{
				break;
			}
			nint num16 = (nint)typeof(AdSettingsProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v43 (Il2CppClass<AdSettingsProvider>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num17 = (nint)typeof(AdSettingsProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v69 (Il2CppClass<AdSettingsProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AdProviderInfo adProviderInfo3 = _allInterstitialProviders.get_Item(num13);
			if (!_interstitialProviderIDs.Contains(adProviderInfo3.providerID__BackingField))
			{
				nint num18 = (nint)typeof(AdSettingsProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v56 (Il2CppClass<AdSettingsProvider>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num19 = (nint)typeof(AdSettingsProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v63 (Il2CppClass<AdSettingsProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				AdProviderInfo adProviderInfo4 = _allInterstitialProviders.get_Item(num13);
				_interstitialProviderIDs.Add(adProviderInfo4.providerID__BackingField);
			}
			int num20 = num13 + 1;
			num13 = num20;
		}
	}
}
