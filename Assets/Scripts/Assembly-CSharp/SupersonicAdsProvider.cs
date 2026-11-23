using System;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using Kiloo.Plugins.Supersonic;
using UnityEngine;

public class SupersonicAdsProvider : ScreenAdProvider
{
	private ScreenAdProvider _supersonicProvider;

	private static SupersonicAdsProvider _instance;

	private bool _isCaching;

	private bool _isBaseInitialized;

	private bool _isInterstitialInitialized;

	private bool _isInterstitialInitializeInProgress;

	private bool _attemptedToCacheBeforeInitialized;

	private const int MINIMUM_SUPPORTED_IOS_VERSION = 8;

	private const string LOCATION_INTERSTITIAL = "DefaultInterstitial";

	public override bool isInitialized
	{
		get
		{
			if (~(_isBaseInitialized ? 1u : 0u) != 0)
			{
				return false;
			}
			return _isInterstitialInitialized;
		}
	}

	public static SupersonicAdsProvider instance
	{
		get
		{
			if (_instance == null)
			{
				SupersonicAdsProvider supersonicAdsProvider = default;
				_instance = supersonicAdsProvider;
			}
			return _instance;
		}
	}

	public override bool isScreenAdProviderSupported
	{
		get
		{
			//IL_007f: Expected Obj, but got I4
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected I4, but got Unknown
			//IL_0063: Expected Obj, but got I4
			object obj;
			if (Supersonic.IsSupportedOnPlatform())
			{
				AdConstants adConstants = AdConstants.instance;
				string supersonicAppId = adConstants.SupersonicAppId;
				if (supersonicAppId != null)
				{
					obj = 0;
					if (supersonicAppId._stringLength != 0)
					{
						goto IL_0092;
					}
				}
				obj = 1;
				goto IL_0092;
			}
			return false;
			IL_0092:
			return (byte)(obj ^ 1) != 0;
		}
	}

	public override bool HasCachedInterstials
	{
		get
		{
			if (~(_isInterstitialInitialized ? 1u : 0u) != 0)
			{
				return false;
			}
			return Supersonic.IsInterstitialReady();
		}
	}

	public override bool allowedWhenAgeRestricted => true;

	public override string id => "supersonic";

	private SupersonicAdsProvider()
	{
	}

	public unsafe override void Init()
	{
		//IL_000a: Expected I, but got Obj
		if (!_isBaseInitialized)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v6 (Il2CppClass<SupersonicAdsProvider>)+EC] (should have been resolved before IL gen)");
			object obj = default;
			if (obj != null)
			{
				_isBaseInitialized = true;
				Action action = default;
				action._002Ector(this, (nint)__ldftn(SupersonicAdsProvider.OnInterstitialReady));
				Supersonic.onInterstitialReady += action;
				Action action2 = default;
				action2._002Ector(this, (nint)__ldftn(SupersonicAdsProvider.OnInterstitialClick));
				Supersonic.onInterstitialClick += action2;
				Action action3 = default;
				action3._002Ector(this, (nint)__ldftn(SupersonicAdsProvider.OnInterstitialClose));
				Supersonic.onInterstitialClose += action3;
				throw new ArgumentException();
			}
		}
		if (~(_isInterstitialInitialized ? 1u : 0u) != 0)
		{
			InitInterstitial();
		}
	}

	private void InitInterstitial()
	{
		//IL_00c1: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		if (~(_isInterstitialInitializeInProgress ? 1u : 0u) == 0)
		{
			return;
		}
		_isInterstitialInitializeInProgress = true;
		string text = DeviceUtility.GetDeviceIdentifier();
		RuntimePlatform platform = Application.platform;
		bool flag = platform == RuntimePlatform.Android;
		bool flag2 = !flag;
		string userId = text;
		if (flag2)
		{
			goto IL_00d4;
		}
		string androidAdvertisingID = DeviceUtility.GetAndroidAdvertisingID();
		object obj;
		if (androidAdvertisingID != null)
		{
			obj = 0;
			if (androidAdvertisingID._stringLength != 0)
			{
				goto IL_00fc;
			}
		}
		obj = 1;
		goto IL_00fc;
		IL_00d4:
		AdConstants adConstants = AdConstants.instance;
		string supersonicAppId = adConstants.SupersonicAppId;
		Supersonic.InitInterstitial(supersonicAppId, userId);
		return;
		IL_00fc:
		if (obj == null)
		{
			text = androidAdvertisingID;
		}
		userId = text;
		goto IL_00d4;
	}

	public override void ShowInterstitial()
	{
		Supersonic.ShowInterstitial("DefaultInterstitial");
	}

	public override void CacheNowInterstitials()
	{
		if (_isCaching)
		{
			return;
		}
		if (~(_isInterstitialInitialized ? 1u : 0u) != 0)
		{
			_attemptedToCacheBeforeInitialized = true;
			if (!_isInterstitialInitializeInProgress)
			{
				InitInterstitial();
			}
		}
		else
		{
			_isCaching = true;
			Supersonic.LoadInterstitial();
		}
	}

	private void OnInterstitialReady()
	{
		_isCaching = false;
		Action<ScreenAdProvider> action = base.onDidCacheInterstitial;
		if (base.onDidCacheInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void OnInterstitialClick()
	{
		_isCaching = false;
		Action<ScreenAdProvider> action = base.onDidClickInterstitial;
		if (base.onDidClickInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void OnInterstitialClose()
	{
		_isCaching = false;
		Action<ScreenAdProvider> action = base.onDidDismissInterstitial;
		if (base.onDidDismissInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void OnInterstitialInitFailed(string obj)
	{
		_isInterstitialInitialized = false;
	}

	private void OnInterstitialInitSuccess()
	{
		//IL_0034: Expected I, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		_isInterstitialInitialized = true;
		if (~(_attemptedToCacheBeforeInitialized ? 1u : 0u) == 0)
		{
			_attemptedToCacheBeforeInitialized = false;
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S1_v5 (Il2CppClass<SupersonicAdsProvider>)+104] (should have been resolved before IL gen)");
		}
	}

	private void OnInterstitialLoadFailed(string obj)
	{
		_isCaching = false;
		Action<ScreenAdProvider> action = base.onDidFailToLoadInterstitial;
		if (base.onDidFailToLoadInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void OnInterstitialOpen()
	{
		_isCaching = false;
		Action<ScreenAdProvider> action = base.onDidShowInterstitial;
		if (base.onDidShowInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void OnInterstitialShowFailed(string obj)
	{
		_isCaching = false;
		Action<ScreenAdProvider> action = base.onDidFailToShowInterstitial;
		if (base.onDidFailToShowInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void OnInterstitialShowSuccess()
	{
		_isCaching = false;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "SupersonicAdsProvider: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
