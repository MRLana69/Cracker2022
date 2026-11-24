using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Ads;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using UI.Screens.CharacterScreenInternal;

public class AdEventLogger : IAdEventListener
{
	private struct CacheAttemptInfo
	{
		public AdType adType;

		public string providerID;

		public DateTime startCacheTime;

		public TimeSpan timePaused;
	}

	private const string EVENT_INTERSTITIAL_PROVIDER_REQUEST = "AdSystem2.0_Interstitial Providers Request";

	private const string EVENT_INTERSTITIAL_PROVIDER_SHOW = "AdSystem2.0_Interstitial Providers Show";

	private const string EVENT_INTERSTITIAL_SHOW_DAILY_LIMIT_REACHED = "AdSystem2.0_Interstitials Show Daily Limit Reached";

	private const string EVENT_INTERSTITIAL_SHOW_HOURLY_LIMIT_REACHED = "AdSystem2.0_Interstitials Show Hourly Limit Reached";

	private const string EVENT_INTERSTITIAL_SHOW_NEW_USER_LIMIT_REACHED = "AdSystem2.0_Interstitials Show New User Limit Reached";

	private const string EVENT_INTERSTITIAL_SHOW_TIME_BETWEEN_ADS_LIMIT_REACHED = "AdSystem2.0_Interstitials Show Time Between Ads Limit Reached";

	private const string EVENT_VIDEOADS_CACHE_REQUEST_ENDED = "AdSystem2.0_VideoAds Cache Request Ended";

	private const string EVENT_VIDEOADS_PROVIDER_SHOW = "AdSystem2.0_VideoAds Providers Show";

	private const string EVENT_VIDEOADS_FAILED_TO_SHOW = "AdSystem2.0_Failed To Show Video Provider";

	private const string EVENT_ADS_CACHING_TIME = "AdSystem2.0_Ads Caching Time";

	private const string EVENT_FAILED_TO_INITIALIZE_PROVIDER = "AdSystem2.0_Failed To Initialize Provider";

	private const string EVENT_END_OF_WATERFALL = "AdSystem2.0_End of waterfall";

	private const string EVENT_ARGVALUE_INTERSTITIAL_REQUEST_SUCCESS = "Request Success";

	private const string EVENT_ARGVALUE_INTERSTITIAL_REQUEST_FAILED = "Request Failed";

	private const string EVENT_ARGVALUE_INTERSTITIAL_REQUEST_TIMEOUT = "Request TimeOut";

	private const string EVENT_ARGVALUE_INTERSTITIAL_REQUEST_FAILED_TO_SHOW = "Request Failed To Show";

	private const string EVENT_ARGVALUE_INTERSTITIAL_SHOW_AD = "Show Ad";

	private const string EVENT_ARGVALUE_INTERSTITIAL_CLICK = "Click";

	private const string EVENT_ARGVALUE_INTERSTITIAL_DISMISSED = "Dismissed Ad";

	private const string EVENT_ARGKEY_INTERSTITIAL_LIMIT = "Limit";

	private const string EVENT_ARGVALUE_VIDEO_REQUEST_SUCCESS = "Success";

	private const string EVENT_ARGVALUE_VIDEO_REQUEST_FAILED = "Failed";

	private const string EVENT_ARGVALUE_VIDEO_REQUEST_TIMEDOUT = "Timedout";

	private const string EVENT_ARGVALUE_VIDEO_SHOW_START = "Video starts";

	private const string EVENT_ARGVALUE_VIDEO_SHOW_COMPLETE = "Video completes";

	private const string EVENT_ARGVALUE_VIDEO_SHOW_CLICKED = "Video clicked";

	private const string EVENT_ARGVALUE_VIDEO_SHOW_FAILED = "Video failed to show";

	private const string EVENT_ARGKEY_PROVIDER_RESULT = "{0}_{1} Result";

	private const string EVENT_ARGKEY_PROVIDER_FAILED = "{0} Fails";

	private const string EVENT_ARGVALUE_PROVIDER = "Provider";

	private const string EVENT_ARGKEY_CACHE_TIME = "{0}{1}{2} Time";

	private const string EVENT_ARGVALUE_WATERFALL_INTEGER = "Integer";

	private const string EVENT_ARGKEY_WATERFALL_COUNT = "{0}_{1}";

	private const int WATERFALL_COUNT_LIMIT = 20;

	private readonly string EVENT_ARGKEY_WATERFALL_ABOVE_LIMIT;

	private Dictionary<string, int> _priorityListIterationCounter;

	private Dictionary<string, CacheAttemptInfo> _cacheInfo;

	private DateTime _onPauseTime;

	public AdEventLogger()
	{
		_ = 1;
	}

	public void WillShowAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_00aa: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00ca: Expected Obj, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AdEventLogger)+14]");
		AdsSave.interstitialStats = (InterstitialStats)0;
		if (adLocationID == null)
		{
			return;
		}
		nint num2 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v13 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v18 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
	}

	public void ShowedAd(AdType adType, string providerID, string adLocationID)
	{
	}

	public void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached)
	{
		//IL_005b: Expected Obj, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		switch (adType)
		{
		case AdType.Interstitial:
			if (AdSystemManager.onCachedInterstitial != null)
			{
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v3 (Il2CppMethodInfo)+18]");
				object obj5 = 0;
				object obj6 = obj5;
				object obj7 = obj6 & 0x3FFF;
				object obj8 = obj7 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S3_v6 (should have been resolved before IL gen)");
			}
			break;
		case AdType.Video:
			if (AdSystemManager.onCachedVideo != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S3_v7 (Il2CppMethodInfo)+18]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = obj2 & 0x1FFF;
				object obj4 = obj3 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v64 @ S4_v8 (should have been resolved before IL gen)");
			}
			break;
		}
	}

	public void DismissedAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_003f: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		switch (adType)
		{
		case AdType.Interstitial:
			((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)providerID, (int)adLocationID, (Action)(object)"AdSystem2.0_Interstitial Providers Show", (CharacterModelRequest)(object)"Show Ad");
			break;
		case AdType.Video:
			((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)providerID, (int)adLocationID, (Action)(object)"AdSystem2.0_VideoAds Providers Show", (CharacterModelRequest)(object)"Video starts");
			break;
		}
	}

	public void StartedCachingAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_001d: Expected I4, but got Obj
		//IL_001d: Expected I4, but got Obj
		if (adType == AdType.Interstitial)
		{
			((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)providerID, (int)adLocationID, (Action)(object)"AdSystem2.0_Interstitial Providers Show", (CharacterModelRequest)(object)"Dismissed Ad");
		}
	}

	private unsafe void OnApplicationPaused()
	{
		//IL_01b9: Expected Obj, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0170: Expected I, but got Obj
		object obj = 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object obj2 = this + 8;
		string text2 = default;
		string text = "Above " + text2;
		obj2 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S3_v4+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50 @ S4_v4 (should have been resolved before IL gen)");
		object obj8 = this + 12;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S3_v8 (Il2CppMethodInfo)+C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S3_v9+60]");
		object obj11 = 0;
		object obj12 = obj11;
		object obj13 = obj12 & 0x1FFF;
		object obj14 = obj13 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S4_v8 (should have been resolved before IL gen)");
		object obj15 = this + 16;
		object obj16 = default;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(AdEventLogger.OnApplicationPaused);
		object obj17 = action + 16;
		obj17 = this;
		nint num3 = (nint)typeof(ApplicationState);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v31 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num4 = (nint)typeof(ApplicationState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v44 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ApplicationState.paused -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(AdEventLogger.OnApplicationResumed);
		object obj19 = action2 + 16;
		obj19 = this;
		ApplicationState.resumed -= action2;
	}

	private void OnApplicationResumed()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got VT
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00c4: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime utcNow = DateTime.UtcNow;
		object obj2 = utcNow;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		_onPauseTime = (DateTime)obj3;
	}

	public void FinishedWatchingVideo(string providerID, string adLocationID)
	{
		//IL_0013: Expected I4, but got Obj
		((AdController)(object)_priorityListIterationCounter).UpdatePriorityListForID(providerID, (AdType)adLocationID);
	}

	public unsafe void FailedToCacheAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got VT
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected VT, but got Unknown
		//IL_010a: Expected I4, but got Obj
		//IL_0105: Expected native int or pointer, but got VT
		//IL_0121: Expected I4, but got Obj
		//IL_011c: Expected native int or pointer, but got VT
		//IL_0136: Expected VT, but got I
		//IL_0131: Expected native int or pointer, but got VT
		//IL_014b: Expected VT, but got I
		//IL_0146: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = adType;
		object obj2 = obj + 4;
		obj2 = providerID;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v11 (Il2CppClass<System.DateTime>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v26 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj + 24;
		DateTime utcNow = DateTime.UtcNow;
		obj4 = utcNow;
		CacheAttemptInfo cacheAttemptInfo = (CacheAttemptInfo)(obj + 32);
		((CacheAttemptInfo*)(nint)cacheAttemptInfo)->adType = (AdType)obj4;
		_ = cacheAttemptInfo.adType;
		((CacheAttemptInfo*)(nint)cacheAttemptInfo)->adType = (AdType)obj;
		CacheAttemptInfo cacheAttemptInfo2 = cacheAttemptInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((CacheAttemptInfo*)(nint)cacheAttemptInfo2)->startCacheTime = (DateTime)0;
		CacheAttemptInfo cacheAttemptInfo3 = cacheAttemptInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		((CacheAttemptInfo*)(nint)cacheAttemptInfo3)->timePaused = (TimeSpan)0;
		_cacheInfo.set_Item(adLocationID, cacheAttemptInfo);
	}

	private void LogCacheTime(AdType adType, string providerID, string adLocationID, string status)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0073: Expected I4, but got Obj
		//IL_0073: Expected I4, but got Obj
		//IL_0090: Expected I4, but got Obj
		//IL_0090: Expected I4, but got Obj
		if (status == null)
		{
			LogProviderResult((string)adType, providerID, adLocationID, "Success");
			switch (adType)
			{
			case AdType.Interstitial:
				((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)providerID, (int)adLocationID, (Action)(object)"AdSystem2.0_Interstitial Providers Request", (CharacterModelRequest)(object)"Request Success");
				break;
			case AdType.Video:
				((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)providerID, (int)adLocationID, (Action)(object)"AdSystem2.0_VideoAds Cache Request Ended", (CharacterModelRequest)(object)"Success");
				break;
			}
		}
	}

	public void FailedToShowAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_0057: Expected Obj, but got I4
		//IL_003a: Expected I4, but got Obj
		//IL_003a: Expected I4, but got Obj
		//IL_001d: Expected I4, but got Obj
		//IL_001d: Expected I4, but got Obj
		LogProviderResult((string)adType, providerID, adLocationID, "Failed");
		if (adType != AdType.Interstitial)
		{
			((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)providerID, (int)adLocationID, (Action)(object)"AdSystem2.0_VideoAds Cache Request Ended", (CharacterModelRequest)(object)"Failed");
		}
		else
		{
			((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)providerID, (int)adLocationID, (Action)(object)"AdSystem2.0_Interstitial Providers Request", (CharacterModelRequest)(object)"Request Failed");
		}
	}

	public void FailedToInitAdProvider(string providerID)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I4
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		IndexOutOfRangeException ex = default;
		object obj = ex + 16;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(Guid);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<System.Guid>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Guid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v15 (Il2CppClass<System.Guid>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ex._002Ector();
		obj = ex;
		_ = ((Exception)ex)._className;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EF7B");
		AbstractAdProvider provider = default;
		((AdController)(object)_priorityListIterationCounter).SetProviderForAdLocation(providerID, provider);
	}

	public void CachingTimedOut(AdType adType, string providerID, string adLocationID)
	{
		//IL_003f: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		switch (adType)
		{
		case AdType.Interstitial:
			((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)providerID, (int)adLocationID, (Action)(object)"AdSystem2.0_Interstitial Providers Request", (CharacterModelRequest)(object)"Request Failed To Show");
			break;
		case AdType.Video:
			((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)providerID, (int)adLocationID, (Action)(object)"AdSystem2.0_Failed To Show Video Provider", (CharacterModelRequest)(object)"Video failed to show");
			break;
		}
	}

	public void ClickedAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_0079: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		LogProviderResult((string)adType, providerID, adLocationID, "Timeout");
		switch (adType)
		{
		case AdType.Interstitial:
			((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)providerID, (int)adLocationID, (Action)(object)"AdSystem2.0_Interstitial Providers Request", (CharacterModelRequest)(object)"Request TimeOut");
			break;
		case AdType.Video:
			((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)providerID, (int)adLocationID, (Action)(object)"AdSystem2.0_VideoAds Cache Request Ended", (CharacterModelRequest)(object)"Timedout");
			break;
		}
	}

	public void ReachedDailyInterstitialLimit(int limit)
	{
		//IL_0060: Expected Obj, but got I4
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string text = $"{(object[])limit} Fails";
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public void ReachedHourlyInterstitialLimit(int limit)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_001b: Expected I, but got Obj
		object obj = limit;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v17 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public void ReachedNewUserInterstitialLimit(int limit)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_001b: Expected I, but got Obj
		object obj = limit;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v17 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public void ReachedTimeBetweenAdsInterstitialLimit(int limit)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_001b: Expected I, but got Obj
		object obj = limit;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v17 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID)
	{
		//IL_003f: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		//IL_005c: Expected I4, but got Obj
		switch (adType)
		{
		case AdType.Interstitial:
			((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)newProvider, (int)changedWaterfallID, (Action)(object)"AdSystem2.0_Interstitial Providers Show", (CharacterModelRequest)(object)"Click");
			break;
		case AdType.Video:
			((AssetBundleManager)null).EnqueueAsyncCharacterBundleRequest((Characters.CharacterId)newProvider, (int)changedWaterfallID, (Action)(object)"AdSystem2.0_VideoAds Providers Show", (CharacterModelRequest)(object)"Video clicked");
			break;
		}
	}

	public void PriorityListWrapped(string waterfallID)
	{
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_001b: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v17 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private unsafe void LogProviderResult(string providerID, string adLocationID, string eventName, string eventValue)
	{
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected VT, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Ref, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_0482: Expected Obj, but got F8
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_0499: Expected Obj, but got I4
		//IL_04ac: Expected VT, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_0502: Expected Obj, but got VT
		//IL_0512: Expected Obj, but got I
		//IL_051f: Expected I8, but got Obj
		//IL_051a: Expected native int or pointer, but got VT
		//IL_0534: Expected Ref, but got VT
		//IL_0569: Expected I, but got Obj
		//IL_057f: Expected Obj, but got I
		//IL_05a4: Expected Obj, but got I8
		//IL_05b4: Expected Obj, but got I
		//IL_05c1: Expected I8, but got Obj
		//IL_05bc: Expected native int or pointer, but got VT
		//IL_05fd: Expected I, but got Obj
		//IL_0613: Expected Obj, but got I
		//IL_00f3: Expected I, but got Obj
		//IL_066a: Expected Obj, but got F8
		//IL_0140: Expected I, but got Obj
		//IL_01da: Expected I, but got Obj
		//IL_01f0: Expected Obj, but got I
		//IL_018d: Expected I, but got Obj
		//IL_021b: Expected I, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 128);
		DateTime dateTime = (DateTime)(obj + 120);
		object obj2 = obj + 40;
		object obj3 = obj + 72;
		object obj4 = obj - -64;
		object obj5 = obj + 32;
		object obj6 = obj + 24;
		ref _00211 reference = ref *(_00211*)(obj + 96);
		reference = ref *(_00211*)null;
		_ = 0;
		_ = 0;
		object obj7 = obj + 88;
		obj7 = 0.0;
		object obj8 = obj + 80;
		obj8 = 0;
		if (((Dictionary<TKey, TValue>)(object)_cacheInfo).TryGetValue((TKey)eventName, out System.Runtime.CompilerServices.Unsafe.As<_00211, TValue>(ref reference)))
		{
			formatProvider = System.Runtime.CompilerServices.Unsafe.As<_00211, IFormatProvider>(ref reference);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (TValue&)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (TValue&)+10]");
			_ = 0;
			if ((object)formatProvider != providerID)
			{
				return;
			}
			formatProvider = System.Runtime.CompilerServices.Unsafe.As<_00211, IFormatProvider>(ref reference);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (TValue&)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (TValue&)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IFormatProvider)+4]");
			if (!((string)0 != adLocationID))
			{
				return;
			}
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v75 (Il2CppClass<System.DateTime>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v154 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime utcNow = DateTime.UtcNow;
			obj2 = System.Runtime.CompilerServices.Unsafe.As<_00211, object>(ref reference);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (TValue&)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (TValue&)+10]");
			_ = 0;
			obj3 = utcNow;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			obj4 = 0;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj3;
			formatProvider = (IFormatProvider)obj4;
			long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
			obj = System.Runtime.CompilerServices.Unsafe.As<_00211, object>(ref reference);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (TValue&)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (TValue&)+10]");
			_ = 0;
			nint num4 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v98 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num5 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v150 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			obj6 = 0;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
			formatProvider = (IFormatProvider)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3F7");
			object obj11 = default;
			obj8 = obj11;
			double num6 = (double)obj8 * 1E-07;
			nint num7 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v111 (Il2CppClass<System.Math>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num8 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v146 (Il2CppClass<System.Math>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			double num9 = num6 * 2.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D10");
			object obj13 = default;
			double num10 = (double)obj13 * 0.5;
			obj7 = num10;
			formatProvider = (IFormatProvider)(object)providerID;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object arg = default;
			string text = string.Format((IFormatProvider)(object)"{0}{1}{2} Time", adLocationID, arg, eventValue);
			nint num11 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v124 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num12 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v142 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			throw new OverflowException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
