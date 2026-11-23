using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

public class ScreenAdsManager
{
	private enum ChangeProviderListLevel
	{
		dontRepopulate,
		repopulate_UsingCachedVersion_IfEmpty,
		repopulate_UsingCachedVersion_Forced,
		repopulate_UsingOnlineSettings_Forced
	}

	private const string INTERSTITIAL_LOCATION_PREFIX = "interstitial_location";

	private const string INTERSTITIAL_LOCATION_ENABLED_ENDING = "enabled";

	private const string INTERSTITIAL_LOCATION_TIME_LIMIT_ENDING = "time_limit";

	private const string ALLOWNEXT_TICKS_KEY = "cb_alwnxt_ticks";

	private const string HAS_SEEN_FIRST_INTERSTITIAL_KEY = "seen_first_interstitial";

	private const uint FIRSTTIME_DELAY_SECONDS = 72000u;

	private const uint DEFAULT_DELAY_SECONDS = 10u;

	private const string DELAY_SECONDS_ONLINESETTINGSKEY = "interstitials_delay_seconds";

	private const uint DEFAULT_NUMBER_OF_FAILS_FOR_EACH_PROVIDER = 1u;

	private const string NUMBER_OF_FAILS_FOR_EACH_PROVIDR = "number_of_fails_for_interstitial";

	private const string LIMIT_PER_HOUR = "interstitials_limit_per_hour";

	private const uint DEFAULT_LIMIT_PER_HOUR = 5u;

	private const string LIMIT_PER_DAY = "interstitials_limit_per_day";

	private const uint DEFAULT_LIMIT_PER_DAY = 20u;

	private const uint DEFAULT_TIME_LIMIT_BEFORE_CHANGE_PROVIDER = 30u;

	private const string PROVIDERS_LIST_VERSION = "interstitial_providers_list_version";

	public const int DEFAULT_PROVIDERS_LIST_VERSION = 0;

	private const string PROVIDER_LOCK_ON_TIME_LIMIT = "interstitial_provider_lock_on_time_limit";

	private const uint DEFAULT_PROVIDER_LOCK_ON_TIME_LIMIT = 72000u;

	private static ScreenAdsManager _instance;

	private ScreenAdProvider _currentProvider;

	private ScreenAdProvider _lastShownProvider;

	private List<ProviderSettings> _screenAdProviderSettingsList;

	private int _currentNumberOfFails;

	private bool _isCaching;

	private DateTime expireTime;

	private bool _allowedToCache;

	private Location _currentShowLocation;

	private NativeInterstitialHelper _customAdObject;

	private bool _isPresentingInterstitial;

	private const string COUNTRY_CODES_FOR_FLURRY_LOGGING_KEY = "interstitial_flurry_logging_country_codes";

	private const char SEPARATOR = ';';

	public bool isPresentingInterstitial => _isPresentingInterstitial;

	public static ScreenAdsManager instance
	{
		get
		{
			if (_instance == null)
			{
				ScreenAdsManager screenAdsManager = default;
				screenAdsManager._002Ector();
				_instance = screenAdsManager;
			}
			return _instance;
		}
	}

	private bool HasCachedInterstial
	{
		get
		{
			//IL_0042: Expected I, but got Obj
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected Obj, but got Unknown
			ScreenAdProvider currentProvider = _currentProvider;
			if (_currentProvider == null)
			{
				return false;
			}
			nint num = (nint)currentProvider;
			object obj = currentProvider + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ S1_v2 (Il2CppClass<ScreenAdProvider>)+E4] (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
	}

	private bool interstitialsEnabled
	{
		get
		{
			bool result = true;
			if (!Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES)
			{
				SystemLanguage systemLanguage = Application.systemLanguage;
				bool flag = systemLanguage == SystemLanguage.Chinese;
				result = true;
				if (!flag)
				{
					PlayerInfo playerInfo = PlayerInfo.Instance;
					bool flag2 = playerInfo._inAppConsumablePurchaseCount > 0;
					result = false;
					if (!flag2)
					{
						PlayerInfo playerInfo2 = PlayerInfo.Instance;
						bool flag3 = playerInfo2._inAppNonconsumablePurchaseCount > 0;
						result = false;
						if (!flag3)
						{
							PlayerInfo playerInfo3 = PlayerInfo.Instance;
							bool flag4 = playerInfo3._inAppRestoredPurchaseCount > 0;
							result = false;
							if (!flag4)
							{
								PlayerInfo playerInfo4 = PlayerInfo.Instance;
								bool flag5 = playerInfo4._inAppLegacyPurchaseCount < 1;
								result = flag5;
							}
						}
					}
				}
			}
			return result;
		}
	}

	public unsafe string GetCurrentProvider(out bool hasCached, out bool isCaching)
	{
		//IL_0048: Expected I, but got Obj
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0094: Expected I, but got Obj
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00d0: Expected I, but got Obj
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		ref bool reference = ref *(bool*)null;
		ref bool reference2 = ref *(bool*)null;
		ScreenAdProvider currentProvider = _currentProvider;
		bool flag = _currentProvider == null;
		string result = null;
		if (!flag)
		{
			nint num = (nint)currentProvider;
			object obj = currentProvider + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v5 (Il2CppClass<ScreenAdProvider>)+DC] (should have been resolved before IL gen)");
			object obj2 = default;
			bool flag2 = obj2 == null;
			result = null;
			if (!flag2)
			{
				ScreenAdProvider currentProvider2 = _currentProvider;
				nint num2 = (nint)currentProvider2;
				object obj3 = currentProvider2 + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S2_v6 (Il2CppClass<ScreenAdProvider>)+E4] (should have been resolved before IL gen)");
				object obj4 = default;
				reference = ref *(bool*)obj4;
				reference2 = ref *(_isCaching ? ((bool*)1) : ((bool*)null));
				ScreenAdProvider currentProvider3 = _currentProvider;
				nint num3 = (nint)currentProvider3;
				object obj5 = currentProvider3 + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S1_v14 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				string text = default;
				result = text;
			}
		}
		return result;
	}

	public string GetLastShownProvider()
	{
		//IL_003e: Expected I, but got Obj
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		ScreenAdProvider lastShownProvider = _lastShownProvider;
		if (_lastShownProvider == null)
		{
			return null;
		}
		nint num = (nint)lastShownProvider;
		object obj = lastShownProvider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ S1_v2 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public void InitProviderListAndCache()
	{
		if (interstitialsEnabled)
		{
			_allowedToCache = true;
			ChooseProviderAndTryCache(forceChangeProvider: true, ChangeProviderListLevel.repopulate_UsingCachedVersion_IfEmpty);
		}
	}

	public void SetAllowCache(bool allow)
	{
		//IL_002c: Expected Obj, but got I4
		_allowedToCache = allow;
		if (allow && ((ScreenAdsManager)allow).interstitialsEnabled)
		{
			ChooseProviderAndTryCache(forceChangeProvider: false, ChangeProviderListLevel.repopulate_UsingCachedVersion_IfEmpty);
		}
	}

	public void EnableShowLocation(Location location, bool enable)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0107: Invalid comparison between VT and I4
		//IL_0037: Expected Obj, but got VT
		//IL_0049: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected VT, but got Unknown
		//IL_0143: Expected Obj, but got VT
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got I4
		//IL_0090: Expected VT, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00a8: Expected Obj, but got I4
		object obj = default;
		ScreenAdsManager screenAdsManager = (ScreenAdsManager)(obj - 80);
		if (enable)
		{
			screenAdsManager._isCaching = (byte)location.defaultTimeLimitToNextShow != 0;
			screenAdsManager._screenAdProviderSettingsList = (List<ProviderSettings>)location.lastShownAdTimeStamp;
			screenAdsManager._currentProvider = (ScreenAdProvider)location.id;
			Location location2 = (Location)(screenAdsManager + 8);
			if (screenAdsManager.GetLocationEnabledState(location2))
			{
				_currentShowLocation = (Location)location.id;
				object obj2 = this - -64;
				obj2 = location.defaultTimeLimitToNextShow;
				_ = location.lastShownAdTimeStamp;
				if (screenAdsManager.interstitialsEnabled)
				{
					ChooseProviderAndTryCache(forceChangeProvider: false, ChangeProviderListLevel.repopulate_UsingCachedVersion_IfEmpty);
					ShowInterstitialIfAble();
				}
			}
		}
		else if (_currentShowLocation == (Location)(object)location.id)
		{
			Location location3 = InterstitialLocations.GetLocation(LocationID.DisableShow);
			screenAdsManager._customAdObject = (NativeInterstitialHelper)screenAdsManager._currentShowLocation;
			object obj3 = screenAdsManager - -64;
			obj3 = screenAdsManager._allowedToCache;
			_ = screenAdsManager.expireTime;
			_ = screenAdsManager._currentShowLocation;
			_ = screenAdsManager._allowedToCache;
			_currentShowLocation = (Location)screenAdsManager.expireTime;
		}
	}

	private void ChooseProviderAndTryCache(bool forceChangeProvider, ChangeProviderListLevel level)
	{
		//IL_0025: Expected Obj, but got I4
		//IL_000d: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I4
		ScreenAdProvider currentProvider = _currentProvider;
		object obj = default;
		if (_currentProvider != null)
		{
			nint num = (nint)currentProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v24 (Il2CppClass<ScreenAdProvider>)+E4] (should have been resolved before IL gen)");
		}
		else
		{
			obj = 0;
		}
		if (obj != null)
		{
			return;
		}
		if (OnlineSettingsProvidersVersionChanged())
		{
			goto IL_00ad;
		}
		ChangeProviderListLevel changeProviderListLevel = default;
		bool flag;
		if (HasLockOnTimeLimitPassed())
		{
			changeProviderListLevel = ChangeProviderListLevel.repopulate_UsingCachedVersion_Forced;
			flag = true;
		}
		else
		{
			if (changeProviderListLevel == ChangeProviderListLevel.repopulate_UsingOnlineSettings_Forced)
			{
				goto IL_00ad;
			}
			flag = changeProviderListLevel == ChangeProviderListLevel.repopulate_UsingCachedVersion_Forced;
		}
		goto IL_01f1;
		IL_00ad:
		changeProviderListLevel = ChangeProviderListLevel.repopulate_UsingOnlineSettings_Forced;
		flag = true;
		goto IL_01f1;
		IL_0131:
		object obj2;
		if (obj2 == null)
		{
			ScreenAdProvider currentProvider2 = _currentProvider;
			if (_currentProvider != null)
			{
				nint num2 = (nint)currentProvider2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v120 @ S1_v13 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				string providerID = default;
				LogFlurryEventForProvider("Interstitial Providers Request", providerID, "Request TimeOut");
				_isCaching = false;
			}
		}
		ChangeProvider(changeProviderListLevel);
		goto IL_01ae;
		IL_01f1:
		object obj3 = flag | forceChangeProvider;
		obj2 = 1;
		if (obj3 == null)
		{
			bool flag2 = _currentProvider == null;
			obj2 = 1;
			if (!flag2)
			{
				if (~(_isCaching ? 1u : 0u) == 0)
				{
					bool flag3 = DidExceedTimeLimitSinceLastCache();
					bool flag4 = !flag3;
					obj2 = 0;
					if (!flag4)
					{
						goto IL_0131;
					}
					if (_isCaching)
					{
						return;
					}
				}
				goto IL_01ae;
			}
		}
		goto IL_0131;
		IL_01ae:
		CacheNowInterstitial();
	}

	private void ShowInterstitialIfAble()
	{
		//IL_0025: Expected Obj, but got I4
		//IL_000d: Expected I, but got Obj
		//IL_0079: Invalid comparison between VT and I4
		ScreenAdProvider currentProvider = _currentProvider;
		object obj = default;
		if (_currentProvider != null)
		{
			nint num = (nint)currentProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v11 (Il2CppClass<ScreenAdProvider>)+E4] (should have been resolved before IL gen)");
		}
		else
		{
			obj = 0;
		}
		if (obj == null || !interstitialsEnabled)
		{
			return;
		}
		VideoAdsManager videoAdsManager = VideoAdsManager.instance;
		if (videoAdsManager._isVideoPlaying || _currentShowLocation == (Location)(object)0)
		{
			return;
		}
		DateTime now = CDateTime.Now;
		if (~(Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT ? 1u : 0u) != 0)
		{
			DateTime dateTime = NextAllowedShowTime();
			if (!(now >= dateTime) || !DidNotExceedNumberOfInterstitials())
			{
				return;
			}
		}
		ShowInterstitial();
	}

	private unsafe void CacheNowInterstitial()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected VT, but got Unknown
		//IL_009f: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(_allowedToCache ? 1u : 0u) == 0)
		{
			ScreenAdProvider currentProvider = _currentProvider;
			if (_currentProvider != null && !_isCaching)
			{
				nint num = (nint)currentProvider;
				object obj3 = currentProvider + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S1_v6 (Il2CppClass<ScreenAdProvider>)+104] (should have been resolved before IL gen)");
				DateTime utcNow = CDateTime.UtcNow;
				DateTime dateTime = (DateTime)(obj + 8);
				DateTime dateTime2 = ((DateTime*)dateTime)->AddSeconds(30.0);
				_isCaching = true;
				expireTime = dateTime2;
			}
		}
	}

	private void GetBestProvider()
	{
		//IL_0192: Expected Obj, but got I4
		//IL_01fc: Expected I, but got Obj
		//IL_020f: Expected Obj, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_03fe: Expected Obj, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0295: Expected Obj, but got I4
		List<ProviderSettings> screenAdProviderSettingsList = _screenAdProviderSettingsList;
		ScreenAdProvider currentProvider = default;
		if (_screenAdProviderSettingsList != null && screenAdProviderSettingsList._size >= 1)
		{
			ProviderSettings providerSettings = _screenAdProviderSettingsList.get_Item(0);
			List<ProviderSettings> list = default;
			list._002Ector();
			list.Add(providerSettings);
			int num = 1;
			ProviderSettings providerSettings2 = providerSettings;
			while (true)
			{
				List<ProviderSettings> screenAdProviderSettingsList2 = _screenAdProviderSettingsList;
				if (num >= screenAdProviderSettingsList2._size)
				{
					break;
				}
				ProviderSettings providerSettings3 = _screenAdProviderSettingsList.get_Item(num);
				ProviderSettings item;
				if (providerSettings2._priority > providerSettings3._priority)
				{
					ProviderSettings providerSettings4 = _screenAdProviderSettingsList.get_Item(num);
					((List<T>)(object)list).Clear();
					item = providerSettings4;
					providerSettings2 = providerSettings4;
				}
				else
				{
					ProviderSettings providerSettings5 = _screenAdProviderSettingsList.get_Item(num);
					if (providerSettings2._priority != providerSettings5._priority)
					{
						goto IL_0147;
					}
					ProviderSettings providerSettings6 = _screenAdProviderSettingsList.get_Item(num);
					item = providerSettings6;
				}
				list.Add(item);
				goto IL_0147;
				IL_0147:
				int num2 = num + 1;
				num = num2;
			}
			bool flag = list._size < 2;
			ScreenAdsManager screenAdsManager = null;
			if (!flag)
			{
				object obj = 0;
				int num3 = 0;
				while (num3 < list._size)
				{
					ProviderSettings providerSettings7 = list.get_Item(num3);
					object obj2 = providerSettings7._weight + obj;
					int num4 = num3 + 1;
					obj = obj2;
					num3 = num4;
				}
				System.Random random = default;
				random._002Ector();
				nint num5 = (nint)random;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ S3_v5 (Il2CppClass<System.Random>)+EC] (should have been resolved before IL gen)");
				object obj3 = 0;
				int num6 = 0;
				object obj4 = default;
				while (true)
				{
					bool flag2 = num6 >= list._size;
					screenAdsManager = (ScreenAdsManager)num6;
					if (flag2)
					{
						break;
					}
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
					{
						ProviderSettings providerSettings8 = list.get_Item(num6);
						object obj5 = providerSettings8._weight + obj3;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
						{
							ProviderSettings providerSettings9 = list.get_Item(num6);
							screenAdsManager = (ScreenAdsManager)num6;
							providerSettings2 = providerSettings9;
							break;
						}
					}
					ProviderSettings providerSettings10 = list.get_Item(num6);
					object obj6 = providerSettings10._weight + obj3;
					int num7 = num6 + 1;
					obj3 = obj6;
					num6 = num7;
				}
			}
			if (providerSettings2 == null)
			{
				currentProvider = null;
			}
			else
			{
				ScreenAdProvider providerForSettings = screenAdsManager.GetProviderForSettings(providerSettings2);
				currentProvider = providerForSettings;
			}
		}
		SetCurrentProvider(currentProvider);
	}

	private ScreenAdProvider GetProviderForSettings(ProviderSettings settings)
	{
		if (!(settings._id == "inmobi"))
		{
			if (settings._id != "chartboost")
			{
				if (settings._id != "mdotm")
				{
					SupersonicAdsProvider result;
					if (settings._id != "supersonic")
					{
						bool flag = settings._id == "facebook";
						bool flag2 = !flag;
						result = null;
						if (!flag2)
						{
							return FacebookNativeAdProvider.instance;
						}
					}
					else
					{
						SupersonicAdsProvider supersonicAdsProvider = SupersonicAdsProvider.instance;
						result = supersonicAdsProvider;
					}
					return result;
				}
				return MdotMAdsProvider.instance;
			}
			return ChartboostAdsProvider.instance;
		}
		return InmobiAdsProvider.instance;
	}

	private ProviderSettings GetSettingsForProvider(ScreenAdProvider provider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			ProviderSettings result;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					result = null;
					goto IL_0204;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				ProviderSettings providerSettings = (ProviderSettings)0;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj7 == null)
							{
								continue;
							}
							result = providerSettings;
							goto IL_0204;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 != obj9;
			object obj10 = obj11;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 == 1;
			result = null;
			if (!flag2)
			{
				goto IL_0204;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_0204:
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2290");
			return result;
		}
		_ = 0;
		object obj14 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		ProviderSettings result2 = default;
		return result2;
	}

	private void ChangeProvider(ChangeProviderListLevel changeLevel)
	{
		//IL_0036: Expected Obj, but got I4
		if (UIScreenController.IsInstanced)
		{
			UIScreenController uIScreenController = UIScreenController.Instance;
			uIScreenController.HideAdsOverlay();
		}
		SetCurrentProvider(null);
		object obj = changeLevel - 1;
		if (changeLevel != ChangeProviderListLevel.repopulate_UsingCachedVersion_IfEmpty)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					SetProviderList(fromOnlineSettings: true);
				}
			}
			else
			{
				SetProviderList(fromOnlineSettings: false);
			}
		}
		else
		{
			List<ProviderSettings> screenAdProviderSettingsList = _screenAdProviderSettingsList;
			if (screenAdProviderSettingsList._size <= 0)
			{
				SetProviderList(fromOnlineSettings: false);
			}
		}
		GetBestProvider();
	}

	private bool DidExceedTimeLimitSinceLastCache()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(_isCaching ? 1u : 0u) == 0)
		{
			DateTime utcNow = CDateTime.UtcNow;
			TimeSpan timeSpan = expireTime - utcNow;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num = 0.0 * 1E-07;
			return !(num > 0.0);
		}
		bool result = default;
		return result;
	}

	private unsafe void ShowInterstitial()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00df: Expected I, but got Obj
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0109: Expected I, but got Obj
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0185: Expected I, but got Obj
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_0335: Expected VT, but got I
		//IL_0330: Expected native int or pointer, but got VT
		//IL_0345: Expected native int or pointer, but got VT
		//IL_035a: Expected native int or pointer, but got VT
		//IL_0150: Expected I, but got Obj
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01c0: Expected Obj, but got I
		//IL_0206: Expected VT, but got I
		object obj = default;
		Location location = (Location)(obj - 96);
		if (_currentProvider != null)
		{
			_isPresentingInterstitial = true;
			UIScreenController uIScreenController = UIScreenController.Instance;
			uIScreenController.ShowTransitionAdsOverlay();
			if (!PlayerPrefs.HasKey("seen_first_interstitial"))
			{
				PlayerPrefs.SetInt("seen_first_interstitial", 1);
			}
			Enum obj2 = (Enum)(location + 72);
			_ = -1;
			obj2 = (Enum)(object)typeof(LocationID);
			_ = _currentShowLocation;
			string text = obj2.ToString();
			string text2 = "Interstitial Providers Show " + text;
			ScreenAdProvider currentProvider = _currentProvider;
			nint num = (nint)currentProvider;
			object obj3 = currentProvider + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S1_v18 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
			ScreenAdProvider currentProvider2 = _currentProvider;
			nint num2 = (nint)currentProvider2;
			object obj4 = currentProvider2 + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S1_v22 (Il2CppClass<ScreenAdProvider>)+11C] (should have been resolved before IL gen)");
			ScreenAdProvider currentProvider3 = _currentProvider;
			object obj5 = default;
			if (obj5 != null)
			{
				nint num3 = (nint)currentProvider3;
				object obj6 = currentProvider3 + 128;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ S2_v20 (Il2CppClass<ScreenAdProvider>)+13C] (should have been resolved before IL gen)");
				NativeInterstitialAdObject adObject = default;
				ShowCustomInterstitial(adObject, _currentProvider);
			}
			else
			{
				nint num4 = (nint)currentProvider3;
				object obj7 = currentProvider3 + 88;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v158 @ S1_v67 (Il2CppClass<ScreenAdProvider>)+114] (should have been resolved before IL gen)");
			}
			_lastShownProvider = _currentProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScreenAdsManager)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScreenAdsManager)+38]");
			_ = 0;
			_ = _currentShowLocation;
			DateTime now = CDateTime.Now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Location)+50]");
			((Location*)(nint)location)->lastShownAdTimeStamp = (DateTime)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Location)+58]");
			((Location*)(nint)location)->defaultTimeLimitToNextShow = 0u;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Location)+48]");
			((Location*)(nint)location)->id = LocationID.DisableShow;
			Location location2 = InterstitialLocations.SetLocationLastShownAdTimeStamp(location, now);
			object obj8 = location - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Location)+28]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Location)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Location)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Location)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Location)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Location)+18]");
			_currentShowLocation = (Location)0;
			PlayerInfo playerInfo = PlayerInfo.Instance;
			DateTime now2 = CDateTime.Now;
			playerInfo.lastTimeInterstitialWasSeen = now2;
			PlayerInfo playerInfo2 = PlayerInfo.Instance;
			int num5 = playerInfo2._numberOfInterstitialsPerHour + 1;
			if (playerInfo2._numberOfInterstitialsPerHour != num5)
			{
				playerInfo2._dirty = true;
				playerInfo2._numberOfInterstitialsPerHour = num5;
			}
			PlayerInfo playerInfo3 = PlayerInfo.Instance;
			int num6 = playerInfo3._numberOfInterstitialsPerDay + 1;
			if (playerInfo3._numberOfInterstitialsPerDay != num6)
			{
				playerInfo3._dirty = true;
				playerInfo3._numberOfInterstitialsPerDay = num6;
			}
		}
		else
		{
			LogError("ScreenAdsManager: ShowInterstitial() -->>> the currentProvider is NULL");
		}
	}

	private void ShowCustomInterstitial(NativeInterstitialAdObject adObject, ScreenAdProvider assignedProvider)
	{
		//IL_0131: Expected I, but got Obj
		//IL_006c: Expected I, but got Obj
		//IL_009f: Expected I, but got Obj
		//IL_00d2: Expected I, but got Obj
		if (_customAdObject == null)
		{
			UIScreenController uIScreenController = UIScreenController.Instance;
			NativeInterstitialHelper nativeInterstitialAdView = uIScreenController.NativeInterstitialAdView;
			_customAdObject = nativeInterstitialAdView;
			if (!(_customAdObject != null))
			{
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			Action action = default;
			action._002Ector(assignedProvider, (IntPtr)ex);
			_customAdObject.onActionClicked += action;
			NullReferenceException ex2 = new NullReferenceException();
			Action action2 = default;
			action2._002Ector(assignedProvider, (IntPtr)ex2);
			_customAdObject.onAdHidden += action2;
			NullReferenceException ex3 = new NullReferenceException();
			Action action3 = default;
			action3._002Ector(assignedProvider, (IntPtr)ex3);
			_customAdObject.onAdShown += action3;
		}
		if (_customAdObject.UpdateAdObject(adObject))
		{
			_customAdObject.Show();
			return;
		}
		_customAdObject.Hide();
		nint num = (nint)assignedProvider;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S1_v8 (Il2CppClass<ScreenAdProvider>)+144] (should have been resolved before IL gen)");
	}

	private unsafe DateTime NextAllowedShowTime()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_033b: Expected VT, but got I4
		//IL_0357: Expected VT, but got I4
		//IL_0368: Invalid comparison between VT and I4
		//IL_0389: Expected VT, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Ref, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected VT, but got Unknown
		//IL_016b: Expected Ref, but got VT
		//IL_0181: Expected VT, but got I8
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected I8, but got Unknown
		//IL_00df: Expected I4, but got VT
		//IL_024b: Expected F8, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected VT, but got Unknown
		//IL_00fb: Expected Ref, but got VT
		//IL_010c: Expected VT, but got I8
		//IL_00c4: Expected I8, but got VT
		//IL_0294: Expected Obj, but got I
		//IL_02a3: Expected Obj, but got VT
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected VT, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected VT, but got Unknown
		//IL_039f: Expected native int or pointer, but got VT
		//IL_02d0: Expected F8, but got I4
		//IL_02e9: Expected VT, but got I
		object obj = default;
		ScreenAdsManager screenAdsManager = (ScreenAdsManager)(obj + -64);
		screenAdsManager._currentShowLocation = (Location)0;
		screenAdsManager._allowedToCache = false;
		screenAdsManager.expireTime = (DateTime)0;
		_ = DateTime.MaxValue;
		if (_currentShowLocation != (Location)(object)0)
		{
			if (!PlayerPrefs.HasKey("seen_first_interstitial"))
			{
				if (PlayerPrefs.HasKey("cb_alwnxt_ticks"))
				{
					string s = PlayerPrefs.GetString("cb_alwnxt_ticks");
					long ticks;
					if (long.TryParse(s, out *(long*)(screenAdsManager + 48)))
					{
						ticks = (long)screenAdsManager._currentShowLocation;
					}
					else
					{
						DateTime now = CDateTime.Now;
						screenAdsManager._allowedToCache = (byte)(int)now != 0;
						DateTime dateTime = (DateTime)(screenAdsManager + 40);
						long ticks2 = ((DateTime*)dateTime)->Ticks;
						screenAdsManager._currentShowLocation = (Location)ticks2;
						ticks = ticks2;
					}
					DateTime dateTime2 = (DateTime)(screenAdsManager + 56);
					*(DateTime*)(nint)dateTime2 = new DateTime(ticks);
				}
				else
				{
					DateTime now2 = CDateTime.Now;
					TimeSpan timeSpan = TimeSpan.FromSeconds(72000.0);
					DateTime dateTime3 = now2 + timeSpan;
					DateTime dateTime4 = (DateTime)(screenAdsManager + 56);
					long ticks3 = ((DateTime*)dateTime4)->Ticks;
					screenAdsManager.expireTime = (DateTime)ticks3;
					long num = screenAdsManager + 32;
					string value = ((long*)num)->ToString();
					PlayerPrefs.SetString("cb_alwnxt_ticks", value);
				}
			}
			else
			{
				DateTime now3 = CDateTime.Now;
				PlayerInfo playerInfo = PlayerInfo.Instance;
				if (now3 < playerInfo._lastTimeInterstitialWasSeen)
				{
					_ = DateTime.MinValue;
				}
				else
				{
					OnlineSettings onlineSettings = OnlineSettings.instance;
					uint value2 = onlineSettings.GetValue("interstitials_delay_seconds", 10u);
					PlayerInfo playerInfo2 = PlayerInfo.Instance;
					TimeSpan timeSpan2 = TimeSpan.FromSeconds((int)value2);
					DateTime dateTime5 = playerInfo2._lastTimeInterstitialWasSeen + timeSpan2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScreenAdsManager)+40]");
					screenAdsManager._isCaching = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScreenAdsManager)+38]");
					screenAdsManager._screenAdProviderSettingsList = (List<ProviderSettings>)0;
					screenAdsManager._currentProvider = (ScreenAdProvider)_currentShowLocation;
					Location location = (Location)(screenAdsManager + 8);
					uint locationTimeLimitToNextShow = screenAdsManager.GetLocationTimeLimitToNextShow(location);
					TimeSpan timeSpan3 = TimeSpan.FromSeconds((int)locationTimeLimitToNextShow);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ScreenAdsManager)+38]");
					DateTime t = (DateTime)0 + timeSpan3;
					int num2 = DateTime.Compare(dateTime5, t);
					if (num2 >= 1)
					{
						t = dateTime5;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (ScreenAdsManager)+38]");
		return (DateTime)0;
	}

	private unsafe bool DidNotExceedNumberOfInterstitials()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_00f8: Expected VT, but got I4
		//IL_010a: Expected Ref, but got VT
		//IL_014a: Expected VT, but got I4
		//IL_015c: Expected Ref, but got VT
		//IL_0361: Expected VT, but got I4
		//IL_0373: Expected Ref, but got VT
		object obj = default;
		uint num = (uint)(obj - 32);
		_ = 0;
		_ = 0;
		((uint*)(int)num)->m_value = 0u;
		PlayerInfo playerInfo = PlayerInfo.Instance;
		PlayerInfo playerInfo2 = PlayerInfo.Instance;
		PlayerInfo playerInfo3 = PlayerInfo.Instance;
		PlayerInfo playerInfo4 = PlayerInfo.Instance;
		DateTime utcNow = CDateTime.UtcNow;
		TimeSpan timeSpan = playerInfo._dailyInterstitialExpireTime - utcNow;
		DateTime utcNow2 = CDateTime.UtcNow;
		TimeSpan timeSpan2 = playerInfo2._hourlyInterstitialExpireTime - utcNow2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.UInt32)+18]");
		double num2 = 0.0 * 1E-07;
		bool result;
		if (num2 < 0.0)
		{
			PlayerInfo playerInfo5 = PlayerInfo.Instance;
			DateTime utcNow3 = CDateTime.UtcNow;
			DateTime dateTime = (DateTime)(num + 8);
			DateTime dailyInterstitialsTimeLeft = ((DateTime*)dateTime)->AddHours(24.0);
			playerInfo5.dailyInterstitialsTimeLeft = dailyInterstitialsTimeLeft;
			PlayerInfo playerInfo6 = PlayerInfo.Instance;
			DateTime utcNow4 = CDateTime.UtcNow;
			DateTime dateTime2 = (DateTime)(num + 8);
			DateTime hourlyInterstitialsTimeLeft = ((DateTime*)dateTime2)->AddHours(1.0);
			playerInfo6.hourlyInterstitialsTimeLeft = hourlyInterstitialsTimeLeft;
			PlayerInfo playerInfo7 = PlayerInfo.Instance;
			if (playerInfo7._numberOfInterstitialsPerDay != 0)
			{
				playerInfo7._dirty = true;
				playerInfo7._numberOfInterstitialsPerDay = 0;
			}
			PlayerInfo playerInfo8 = PlayerInfo.Instance;
			if (playerInfo8._numberOfInterstitialsPerHour != 0)
			{
				playerInfo8._dirty = true;
				playerInfo8._numberOfInterstitialsPerHour = 0;
			}
			result = true;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.UInt32)+18]");
			double num3 = 0.0 * 1E-07;
			bool flag = num3 > 0.0;
			bool flag2 = !flag;
			result = false;
			if (!flag2)
			{
				OnlineSettings onlineSettings = OnlineSettings.instance;
				uint value = onlineSettings.GetValue("interstitials_limit_per_day", 20u);
				if (playerInfo4._numberOfInterstitialsPerDay >= (int)value)
				{
					uint num4 = num + 4;
					string text = ((uint*)num4)->ToString();
					result = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.UInt32)+10]");
					double num5 = 0.0 * 1E-07;
					if (!(num5 > 0.0))
					{
						PlayerInfo playerInfo9 = PlayerInfo.Instance;
						if (playerInfo9._numberOfInterstitialsPerHour != 0)
						{
							playerInfo9._dirty = true;
							playerInfo9._numberOfInterstitialsPerHour = 0;
						}
						PlayerInfo playerInfo10 = PlayerInfo.Instance;
						DateTime utcNow5 = CDateTime.UtcNow;
						DateTime dateTime3 = (DateTime)(num + 8);
						DateTime hourlyInterstitialsTimeLeft2 = ((DateTime*)dateTime3)->AddHours(1.0);
						playerInfo10.hourlyInterstitialsTimeLeft = hourlyInterstitialsTimeLeft2;
						result = true;
					}
					else
					{
						OnlineSettings onlineSettings2 = OnlineSettings.instance;
						bool flag3 = (int)(((uint*)(int)num)->m_value = onlineSettings2.GetValue("interstitials_limit_per_hour", 5u)) > playerInfo3._numberOfInterstitialsPerHour;
						result = true;
						if (!flag3)
						{
							string text2 = ((uint*)num)->ToString();
							result = false;
						}
					}
				}
			}
		}
		return result;
	}

	private uint GetLocationTimeLimitToNextShow(Location location)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = location.id;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string key = string.Format("{0}_{1}_{2}", "interstitial_location", arg, "time_limit");
		OnlineSettings onlineSettings = OnlineSettings.instance;
		return onlineSettings.GetValue(key, location.defaultTimeLimitToNextShow);
	}

	private bool GetLocationEnabledState(Location location)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = location.id;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string key = string.Format("{0}_{1}_{2}", "interstitial_location", arg, "enabled");
		OnlineSettings onlineSettings = OnlineSettings.instance;
		return onlineSettings.GetValue(key, location.defaultEnabled);
	}

	private bool OnlineSettingsProvidersVersionChanged()
	{
		OnlineSettings onlineSettings = OnlineSettings.instance;
		int value = onlineSettings.GetValue("interstitial_providers_list_version", 0);
		PlayerInfo playerInfo = PlayerInfo.Instance;
		if (playerInfo._interstitialProviderListVersion != value)
		{
			PlayerInfo playerInfo2 = PlayerInfo.Instance;
			if (value != playerInfo2._interstitialProviderListVersion)
			{
				playerInfo2._dirty = true;
				playerInfo2._interstitialProviderListVersion = value;
			}
		}
		return value != playerInfo._interstitialProviderListVersion;
	}

	private bool HasLockOnTimeLimitPassed()
	{
		//IL_001c: Expected F8, but got I4
		OnlineSettings onlineSettings = OnlineSettings.instance;
		uint value = onlineSettings.GetValue("interstitial_provider_lock_on_time_limit", 72000u);
		PlayerInfo playerInfo = PlayerInfo.Instance;
		TimeSpan timeSpan = TimeSpan.FromSeconds((int)value);
		DateTime t = playerInfo._lastTimeInterstitialProviderHasChanged + timeSpan;
		DateTime now = CDateTime.Now;
		int num = DateTime.Compare(now, t);
		return num > 0;
	}

	private void SetProviderList(bool fromOnlineSettings)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		((List<T>)(object)_screenAdProviderSettingsList).Clear();
		if (AgeRestriction.waitForAgeRestriction)
		{
			return;
		}
		string locale = DeviceUtility.GetLocale();
		object obj3 = obj + 16;
		List<ProviderSettings> providersForLocale = GroupInfo.GetProvidersForLocale(locale, fromOnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					goto IL_044a;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj7 = 0;
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
							if (obj8 == null)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v76+C]");
							if ((nint)0 < (nint)1)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj9 == null)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											if (obj10 == null)
											{
												continue;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj11 != obj12;
			object obj13 = obj14;
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
				goto IL_044a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj13 = obj15;
			break;
			IL_044a:
			object obj16 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2290");
			return;
		}
		_ = 0;
		object obj17 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private void SetCurrentProvider(ScreenAdProvider provider)
	{
		//IL_0218: Expected I, but got Obj
		//IL_025e: Expected I, but got Obj
		ScreenAdProvider currentProvider = _currentProvider;
		if (_currentProvider != provider)
		{
			if (_currentProvider != null)
			{
				throw new ArgumentException();
			}
			if (provider != null)
			{
				_currentProvider = provider;
				throw new ArgumentException();
			}
			currentProvider = _currentProvider;
		}
		if (currentProvider != null)
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			DateTime now = CDateTime.Now;
			playerInfo.lastTimeInterstitialProviderHasChanged = now;
			ScreenAdProvider currentProvider2 = _currentProvider;
			nint num = (nint)currentProvider2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v148 @ S1_v8 (Il2CppClass<ScreenAdProvider>)+DC] (should have been resolved before IL gen)");
			object obj = default;
			if (obj == null && !AgeRestriction.waitForAgeRestriction)
			{
				ScreenAdProvider currentProvider3 = _currentProvider;
				nint num2 = (nint)currentProvider3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v195 @ S1_v11 (Il2CppClass<ScreenAdProvider>)+10C] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnProviderChachedInterstitial(ScreenAdProvider provider)
	{
		//IL_0036: Expected I, but got Obj
		//IL_0048: Expected I, but got Obj
		//IL_008e: Expected I, but got Obj
		if (provider != null)
		{
			ScreenAdProvider currentProvider = _currentProvider;
			if (_currentProvider != null)
			{
				nint num = (nint)currentProvider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S1_v26 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				nint num2 = (nint)provider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S2_v12 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				string text = default;
				string text2 = default;
				if (text == text2)
				{
					ScreenAdProvider currentProvider2 = _currentProvider;
					nint num3 = (nint)currentProvider2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S1_v31 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
					string providerID = default;
					LogFlurryEventForProvider("Interstitial Providers Request", providerID, "Request Success");
					_isCaching = false;
					ShowInterstitialIfAble();
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private void OnProviderDidFailToLoadInterstitial(ScreenAdProvider provider)
	{
		//IL_0036: Expected I, but got Obj
		//IL_0048: Expected I, but got Obj
		//IL_00b3: Expected I, but got Obj
		if (provider != null)
		{
			ScreenAdProvider currentProvider = _currentProvider;
			if (_currentProvider != null)
			{
				nint num = (nint)currentProvider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S1_v27 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				nint num2 = (nint)provider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S2_v13 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				string text = default;
				string text2 = default;
				if (text == text2)
				{
					_isPresentingInterstitial = false;
					int currentNumberOfFails = _currentNumberOfFails + 1;
					_currentNumberOfFails = currentNumberOfFails;
					ScreenAdProvider currentProvider2 = _currentProvider;
					nint num3 = (nint)currentProvider2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S1_v36 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
					string providerID = default;
					LogFlurryEventForProvider("Interstitial Providers Request", providerID, "Request Failed");
					_isCaching = false;
					OnlineSettings onlineSettings = OnlineSettings.instance;
					uint value = onlineSettings.GetValue("number_of_fails_for_interstitial", 1u);
					if (_currentNumberOfFails >= (int)value)
					{
						ChooseProviderAndTryCache(forceChangeProvider: true, ChangeProviderListLevel.dontRepopulate);
					}
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private void OnProviderDidClickInterstitial(ScreenAdProvider provider)
	{
		//IL_0036: Expected I, but got Obj
		//IL_0048: Expected I, but got Obj
		//IL_0142: Expected I, but got Obj
		//IL_00b5: Expected I, but got Obj
		//IL_00d0: Expected I, but got Obj
		if (provider != null)
		{
			ScreenAdProvider currentProvider = _currentProvider;
			if (_currentProvider != null)
			{
				nint num = (nint)currentProvider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S1_v26 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				nint num2 = (nint)provider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S2_v12 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				string text = default;
				string text2 = default;
				if (text == text2)
				{
					if (UIScreenController.IsInstanced)
					{
						ScreenAdProvider currentProvider2 = _currentProvider;
						nint num3 = (nint)currentProvider2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v106 @ S1_v36 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
						InmobiAdsProvider inmobiAdsProvider = InmobiAdsProvider.instance;
						nint num4 = (nint)inmobiAdsProvider;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v148 @ S2_v21 (Il2CppClass<InmobiAdsProvider>)+F4] (should have been resolved before IL gen)");
						string text3 = default;
						string text4 = default;
						if (text3 == text4)
						{
							UIScreenController uIScreenController = UIScreenController.Instance;
							uIScreenController.HideAdsOverlay();
						}
					}
					_isPresentingInterstitial = false;
					ScreenAdProvider currentProvider3 = _currentProvider;
					nint num5 = (nint)currentProvider3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ S1_v33 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private void OnProviderDidFailToShowInterstitial(ScreenAdProvider provider)
	{
		//IL_0036: Expected I, but got Obj
		//IL_0048: Expected I, but got Obj
		//IL_008e: Expected I, but got Obj
		if (provider != null)
		{
			ScreenAdProvider currentProvider = _currentProvider;
			if (_currentProvider != null)
			{
				nint num = (nint)currentProvider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S1_v26 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				nint num2 = (nint)provider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S2_v12 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				string text = default;
				string text2 = default;
				if (text == text2)
				{
					ScreenAdProvider currentProvider2 = _currentProvider;
					nint num3 = (nint)currentProvider2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S1_v31 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
					string providerID = default;
					LogFlurryEventForProvider("Interstitial Providers Request", providerID, "Request Failed To Show");
					ChangeProvider(ChangeProviderListLevel.dontRepopulate);
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private void OnProviderDidShowInterstitial(ScreenAdProvider provider)
	{
		//IL_006f: Expected I, but got Obj
		//IL_0081: Expected I, but got Obj
		if (UIScreenController.IsInstanced)
		{
			UIScreenController uIScreenController = UIScreenController.Instance;
			uIScreenController.ShowAdsOverlay();
		}
		if (provider != null)
		{
			ScreenAdProvider currentProvider = _currentProvider;
			if (_currentProvider != null)
			{
				nint num = (nint)currentProvider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S1_v28 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				nint num2 = (nint)provider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S2_v13 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				string text = default;
				string text2 = default;
				if (!(text != text2))
				{
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private void OnProviderDidDismissInterstitial(ScreenAdProvider provider)
	{
		//IL_007a: Expected I, but got Obj
		//IL_008c: Expected I, but got Obj
		if (UIScreenController.IsInstanced)
		{
			UIScreenController uIScreenController = UIScreenController.Instance;
			uIScreenController.HideAdsOverlay();
		}
		_isPresentingInterstitial = false;
		if (provider != null)
		{
			ScreenAdProvider currentProvider = _currentProvider;
			if (_currentProvider != null)
			{
				nint num = (nint)currentProvider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S1_v29 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				nint num2 = (nint)provider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ S2_v13 (Il2CppClass<ScreenAdProvider>)+F4] (should have been resolved before IL gen)");
				string text = default;
				string text2 = default;
				if (!(text != text2))
				{
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private void LogFlurryEventForProvider(string flurryEvent, string providerID, string eventParameter)
	{
		//IL_0047: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		string locale = DeviceUtility.GetLocale();
		string contryCodeFromLocale = Utils.GetContryCodeFromLocale(locale);
		object obj;
		if (contryCodeFromLocale != null)
		{
			obj = 0;
			if (contryCodeFromLocale._stringLength != 0)
			{
				goto IL_00cc;
			}
		}
		obj = 1;
		goto IL_00cc;
		IL_00cc:
		if (obj == null)
		{
			string text = contryCodeFromLocale.ToUpper();
			List<string> countryCodesForFlurryLogging = ((ScreenAdsManager)(object)flurryEvent).GetCountryCodesForFlurryLogging();
			if (countryCodesForFlurryLogging.Contains(text))
			{
				string text2 = flurryEvent + "-" + text;
			}
		}
	}

	private unsafe List<string> GetCountryCodesForFlurryLogging()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Ref, but got Unknown
		//IL_0079: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_03f4: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		List<string> list = default;
		list._002Ector();
		_ = string.Empty;
		OnlineSettings onlineSettings = OnlineSettings.instance;
		if (onlineSettings.TryGetValue("interstitial_flurry_logging_country_codes", out *(string*)(obj + 44)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			string[] array = ((string)0).Split(';');
			List<string> list2 = (List<string>)(object)array;
		}
		else
		{
			List<string> list3 = default;
			list3._002Ector();
			list3.Add("US");
			list3.Add("GB");
			list3.Add("CA");
			list3.Add("DK");
			list3.Add("BR");
			list3.Add("MX");
			list3.Add("IN");
			list3.Add("ID");
			List<string> list2 = list3;
		}
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S4_v3 (Il2CppRgctx<System.Collections.Generic.List`1<System.String>>)+3C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S4_v4+4] (should have been resolved before IL gen)");
		List<string> list4 = default;
		list4._002Ector();
		object obj4 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj5 = obj + 24;
		obj = obj5;
		_ = 0;
		object obj7 = default;
		object obj8;
		object obj9 = default;
		object obj10 = default;
		List<string> list5 = default;
		List<string> list6 = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj7 == null;
				obj8 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj9 == obj10;
			bool flag3 = !flag2;
			List<string> result = list5;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj8 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = list6;
			}
			_ = 0;
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj8 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		object obj12 = obj8 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
		return list4;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "[ScreenAdsManager] " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public ScreenAdsManager()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I
		//IL_0072: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 48;
		List<ProviderSettings> list = default;
		list._002Ector();
		_screenAdProviderSettingsList = list;
		Location location = InterstitialLocations.GetLocation(LocationID.DisableShow);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj3 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_currentShowLocation = (Location)obj;
	}
}
