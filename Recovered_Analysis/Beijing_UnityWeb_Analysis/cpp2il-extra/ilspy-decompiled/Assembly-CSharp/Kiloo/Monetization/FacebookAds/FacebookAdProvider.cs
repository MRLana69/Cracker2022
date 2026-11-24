using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using Kiloo.Integration.Google;
using Kiloo.Monetization.FacebookAds.Internal;
using Kiloo.Monetization.FlurryPlugin.Internal;

namespace Kiloo.Monetization.FacebookAds;

public class FacebookAdProvider : AbstractAdProvider
{
	public const string ID = "facebook";

	private bool _addedListeners;

	private bool _videoWatched;

	private Dictionary<string, string> _adLocationToCacheId;

	public override string id => null;

	public override bool supportsMulticaching
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (byte)(int)"facebook" != 0;
		}
	}

	public override List<AdType> adTypesWithClickCallbackSupport => null;

	protected override void CheckPlatformSupport(AdProviderConfiguration configuration)
	{
		throw new InvalidOperationException();
	}

	protected override void OnInitialize(AdProviderConfiguration configuration)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FacebookNativeAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookNativeAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FacebookNativeAdsAndroid facebookNativeAdsAndroid = FacebookNativeAdsAndroid.CreatePlugin();
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S4_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S4_v4+48]");
		object obj4 = 0;
		object obj5 = obj4 & 0x7FF;
		object obj6 = obj5 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S5_v4 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S4_v8+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S4_v9+48]");
		object obj9 = 0;
		object obj10 = obj9 & 0x7FF;
		object obj11 = obj10 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v63 @ S5_v8 (should have been resolved before IL gen)");
	}

	protected override void CacheInterstitial(string adLocationID, string cacheID)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		_showInterstitialLocation = cacheID;
		_cacheVideoLocation = cacheID;
		object obj = this + 16;
		obj = adLocationID;
	}

	protected override void ShowInterstitial(string adLocationID, string cacheID)
	{
		//IL_00b5: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
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
		object obj6 = this + 12;
		obj6 = adLocationID;
		nint num2 = (nint)typeof(FacebookNativeAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v11 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num3 = (nint)typeof(FacebookNativeAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v30 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FacebookNativeAds.LoadVideoAd(cacheID);
		nint num4 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v17 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v24 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID = default;
		AbstractAdProvider.eventInvoker.FailedToCacheAd(AdType.Interstitial, providerID, adLocationID);
	}

	protected override bool HasCachedInterstitial(string cacheID)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAdsIos);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAdsIos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return false;
	}

	protected override void CacheVideo(string adLocationID, string cacheID)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FacebookNativeAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookNativeAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FacebookNativeAds.onNativeInitialize += (Action<bool>)(object)cacheID;
		object obj2 = this + 8;
		obj2 = adLocationID;
	}

	protected override void ShowVideo(string adLocationId, string cacheId)
	{
		//IL_00b5: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
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
		object obj6 = this + 20;
		obj6 = adLocationId;
		nint num2 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v11 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num3 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v28 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID = default;
		AbstractAdProvider.eventInvoker.FailedToCacheAd(AdType.Video, providerID, adLocationId);
		nint num4 = (nint)typeof(FacebookNativeAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v19 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(FacebookNativeAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v24 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FacebookNativeAds.ShowVideo(cacheId);
	}

	protected override bool HasCachedVideo(string cacheID)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FacebookNativeAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookNativeAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)((GoogleKilooAuthPlatform)(object)cacheID).name != 0;
	}

	private void Log(string message)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_050f: Expected I, but got Obj
		//IL_0525: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_004c: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0324: Expected I, but got Obj
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_008d: Expected I, but got Obj
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (~(_addedListeners ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			Action<bool> action = default;
			object obj3 = action + 16;
			obj3 = this;
			nint num2 = (nint)typeof(FacebookNativeAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v83 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num3 = (nint)typeof(FacebookNativeAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v199 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FacebookNativeAds.onNativeInitialize -= action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			_ = 0;
			Action<string> action2 = default;
			object obj5 = action2 + 16;
			obj5 = this;
			FacebookNativeAds.onNativeDidLoad -= action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Action<string> action3 = default;
			object obj6 = action3 + 16;
			obj6 = this;
			FacebookNativeAds.onNativeCacheAdError -= action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num6 = 0;
			_ = 0;
			Action<string> action4 = default;
			object obj7 = action4 + 16;
			obj7 = this;
			FacebookNativeAds.onNativeAdShown -= action4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			_ = 0;
			Action<string> action5 = default;
			object obj8 = action5 + 16;
			obj8 = this;
			FacebookNativeAds.onNativeAdClosed -= action5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num8 = 0;
			_ = 0;
			Action<string> action6 = default;
			object obj9 = action6 + 16;
			obj9 = this;
			FacebookNativeAds.onNativeAdClicked -= action6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num9 = 0;
			_ = 0;
			Action<string> action7 = default;
			object obj10 = action7 + 16;
			obj10 = this;
			FacebookNativeAds.onVideoDidLoad -= action7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num10 = 0;
			_ = 0;
			Action<string> action8 = default;
			object obj11 = action8 + 16;
			obj11 = this;
			FacebookNativeAds.onVideoError -= action8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num11 = 0;
			_ = 0;
			Action<string> action9 = default;
			object obj12 = action9 + 16;
			obj12 = this;
			FacebookNativeAds.onVideoCacheError -= action9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num12 = 0;
			_ = 0;
			Action<string> action10 = default;
			object obj13 = action10 + 16;
			obj13 = this;
			FacebookNativeAds.onVideoViewStarted -= action10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num13 = 0;
			_ = 0;
			Action<string> action11 = default;
			object obj14 = action11 + 16;
			obj14 = this;
			FacebookNativeAds.onVideoViewFinished -= action11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num14 = 0;
			_ = 0;
			Action<string> action12 = default;
			object obj15 = action12 + 16;
			obj15 = this;
			FacebookNativeAds.onVideoViewClosed -= action12;
			_addedListeners = true;
		}
		nint num15 = (nint)typeof(FacebookNativeAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num16 = (nint)typeof(FacebookNativeAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v66 (Il2CppClass<Kiloo.Monetization.FacebookAds.FacebookNativeAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
	}

	private void LogWarning(string message)
	{
	}

	private void LogError(string message)
	{
	}

	public FacebookAdProvider()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private void _003COnInitialize_003Eb__10_0(string cacheID)
	{
		//IL_0013: Expected I4, but got Obj
		string msg = string.ConcatArray((string[])(object)"[FacebookAdProvider] ", (int)cacheID);
		SDebug.LogFormat(msg, null);
	}

	private void _003COnInitialize_003Eb__10_1(string msg)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID = default;
		((AdController.EventHandler)(object)AbstractAdProvider.eventInvoker).CachedAd(AdType.Interstitial, providerID, _cacheInterstitialLocation, false);
	}

	private void _003COnInitialize_003Eb__10_2(string msg)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID = default;
		AbstractAdProvider.eventInvoker.FailedToShowAd(AdType.Interstitial, providerID, _cacheInterstitialLocation);
	}

	private void _003COnInitialize_003Eb__10_3(string msg)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID = default;
		AbstractAdProvider.eventInvoker.DismissedAd(AdType.Interstitial, providerID, _cacheInterstitialLocation);
	}

	private void _003COnInitialize_003Eb__10_4(string placement)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID = default;
		AbstractAdProvider.eventInvoker.StartedCachingAd(AdType.Interstitial, providerID, _cacheInterstitialLocation);
	}

	private void _003COnInitialize_003Eb__10_5(string cacheID)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AbstractAdProvider.eventInvoker.ChangedProvider(AdType.Interstitial, "facebook", _showInterstitialLocation);
	}

	private void _003COnInitialize_003Eb__10_6(string msg)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID = default;
		((AdController.EventHandler)(object)AbstractAdProvider.eventInvoker).CachedAd(AdType.Video, providerID, _cacheVideoLocation, false);
	}

	private void _003COnInitialize_003Eb__10_7(string msg)
	{
		//IL_019c: Expected I, but got Obj
		//IL_01b2: Expected Obj, but got I
		//IL_01dd: Expected I, but got Obj
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_014f: Expected I, but got Obj
		//IL_00c1: Expected I, but got Obj
		string showVideoLocation = _showVideoLocation;
		bool flag = _showVideoLocation == null || showVideoLocation.m_stringLength == 0;
		if (!flag && !string.Equals(_showVideoLocation, "undetermined"))
		{
			if (~(_videoWatched ? 1u : 0u) == 0)
			{
				_videoWatched = false;
				nint num = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v48 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(AbstractAdProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v55 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				string providerID = default;
				((AdController.EventHandler)(object)AbstractAdProvider.eventInvoker).HandleFail(providerID, _showVideoLocation);
			}
			nint num3 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v31 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v40 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string providerID2 = default;
			AbstractAdProvider.eventInvoker.StartedCachingAd(AdType.Video, providerID2, _showVideoLocation);
			object obj3 = this + 16;
			obj3 = "";
			return;
		}
		nint num5 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v11 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AbstractAdProvider.eventInvoker.FailedToShowAd(AdType.Video, "facebook", _cacheVideoLocation);
	}

	private void _003COnInitialize_003Eb__10_8(string cacheID)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AbstractAdProvider.eventInvoker.FailedToShowAd(AdType.Video, "facebook", _cacheVideoLocation);
	}

	private void _003COnInitialize_003Eb__10_9(string cacheID)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID = default;
		AbstractAdProvider.eventInvoker.DismissedAd(AdType.Video, providerID, _showVideoLocation);
	}

	private void _003COnInitialize_003Eb__10_10(string cacheID)
	{
		_videoWatched = true;
	}
}
