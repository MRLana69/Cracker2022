using System;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Monetization.Inmobi;
using Kiloo.Monetization.Inmobi.Internal;
using UnityEngine;

public class InmobiAdsProvider : ScreenAdProvider
{
	private ScreenAdProvider _inmobiProvider;

	private static InmobiAdsProvider _instance;

	private bool _isCaching;

	private bool _isPluginInitialized;

	private const string INMOBI_INTERSTITIAL_TEST_APP_ID = "inmobi_interstitial_test_appid";

	private string _inmobiTestAppID = string.Empty;

	private const string KEY_INTERSTITIAL = "interstitial";

	public static InmobiAdsProvider instance
	{
		get
		{
			if (_instance == null)
			{
				InmobiAdsProvider inmobiAdsProvider = default;
				inmobiAdsProvider._002Ector();
				_instance = inmobiAdsProvider;
			}
			return _instance;
		}
	}

	public override bool isInitialized => _isPluginInitialized;

	public override bool isScreenAdProviderSupported
	{
		get
		{
			//IL_0067: Expected Obj, but got I4
			//IL_004b: Expected Obj, but got I4
			//IL_0075: Expected Obj, but got I4
			//IL_00d7: Expected Obj, but got I4
			//IL_0106: Expected I4, but got Obj
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected Obj, but got Unknown
			//IL_00bb: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1669");
			AdConstants adConstants = AdConstants.instance;
			string inmobiAppIdInterstitial = adConstants.InmobiAppIdInterstitial;
			object obj;
			if (inmobiAppIdInterstitial != null)
			{
				obj = 0;
				if (inmobiAppIdInterstitial._stringLength != 0)
				{
					goto IL_00dc;
				}
			}
			obj = 1;
			goto IL_00dc;
			IL_00f9:
			object obj2;
			object obj3 = default;
			return (byte)(obj2 & obj3) != 0;
			IL_010b:
			object obj4;
			obj2 = obj4 ^ 1;
			goto IL_00f9;
			IL_00dc:
			if (obj != null)
			{
				obj2 = 0;
				goto IL_00f9;
			}
			AdConstants adConstants2 = AdConstants.instance;
			string inmobiAccountId = adConstants2.InmobiAccountId;
			if (inmobiAccountId != null)
			{
				obj4 = 0;
				if (inmobiAccountId._stringLength != 0)
				{
					goto IL_010b;
				}
			}
			obj4 = 1;
			goto IL_010b;
		}
	}

	public override bool HasCachedInterstials
	{
		get
		{
			AdConstants adConstants = AdConstants.instance;
			string inmobiAppIdInterstitial = adConstants.InmobiAppIdInterstitial;
			return InmobiPlugin.HasCachedAd("interstitial", inmobiAppIdInterstitial);
		}
	}

	public override bool allowedWhenAgeRestricted => true;

	public override string id => "inmobi";

	private InmobiAdsProvider()
	{
	}

	public unsafe override void Init()
	{
		//IL_000a: Expected I, but got Obj
		if (_isPluginInitialized)
		{
			return;
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v4 (Il2CppClass<InmobiAdsProvider>)+EC] (should have been resolved before IL gen)");
		object obj = default;
		if (obj != null)
		{
			_isPluginInitialized = true;
			AdConstants adConstants = AdConstants.instance;
			string inmobiAccountId = adConstants.InmobiAccountId;
			InmobiPlugin.Initialize(inmobiAccountId);
			InmobiCallback inmobiCallback = default;
			inmobiCallback._002Ector(this, (nint)__ldftn(InmobiAdsProvider.OnDidCacheInterstitial));
			InmobiPlugin.onCacheAd += inmobiCallback;
			InmobiCallback inmobiCallback2 = default;
			inmobiCallback2._002Ector(this, (nint)__ldftn(InmobiAdsProvider.OnDidFailToLoadInterstitial));
			InmobiPlugin.onFailToLoadAd += inmobiCallback2;
			InmobiCallback inmobiCallback3 = default;
			inmobiCallback3._002Ector(this, (nint)__ldftn(InmobiAdsProvider.OnDidDismissScreen));
			InmobiPlugin.onDismissAd += inmobiCallback3;
			InmobiCallback inmobiCallback4 = default;
			inmobiCallback4._002Ector(this, (nint)__ldftn(InmobiAdsProvider.OnShowInterstitial));
			InmobiPlugin.willShowAd += inmobiCallback4;
			OnlineSettings onlineSettings = OnlineSettings.instance;
			if (onlineSettings.HasValue("inmobi_interstitial_test_appid"))
			{
				OnlineSettings onlineSettings2 = OnlineSettings.instance;
				string value = onlineSettings2.GetValue("inmobi_interstitial_test_appid", string.Empty);
				_inmobiTestAppID = value;
			}
		}
	}

	public override void CacheNowInterstitials()
	{
		//IL_0053: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		if (~(_isCaching ? 1u : 0u) == 0)
		{
			return;
		}
		string inmobiTestAppID = _inmobiTestAppID;
		object obj;
		if (_inmobiTestAppID != null)
		{
			obj = 0;
			if (inmobiTestAppID._stringLength != 0)
			{
				goto IL_00ac;
			}
		}
		obj = 1;
		goto IL_00ac;
		IL_00ac:
		string appId;
		if (obj != null)
		{
			AdConstants adConstants = AdConstants.instance;
			appId = adConstants.InmobiAppIdInterstitial;
		}
		else
		{
			appId = _inmobiTestAppID;
		}
		InmobiPlugin.CacheAd("interstitial", appId);
	}

	public override void ShowInterstitial()
	{
		AdConstants adConstants = AdConstants.instance;
		string inmobiAppIdInterstitial = adConstants.InmobiAppIdInterstitial;
		InmobiPlugin.ShowAd("interstitial", inmobiAppIdInterstitial);
	}

	private void OnDidCacheInterstitial(string key)
	{
		if (key.Equals("interstitial"))
		{
			_isCaching = false;
			Action<ScreenAdProvider> action = base.onDidCacheInterstitial;
			if (base.onDidCacheInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S0_v10 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnDidFailToLoadInterstitial(string key)
	{
		if (key.Equals("interstitial"))
		{
			_isCaching = false;
			Action<ScreenAdProvider> action = base.onDidFailToLoadInterstitial;
			if (base.onDidFailToLoadInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S0_v10 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnDidDismissScreen(string key)
	{
		if (key.Equals("interstitial"))
		{
			_isCaching = false;
			Action<ScreenAdProvider> action = base.onDidDismissInterstitial;
			if (base.onDidDismissInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S0_v10 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnDidClickInterstitial(string key)
	{
		if (key.Equals("interstitial"))
		{
			_isCaching = false;
			Action<ScreenAdProvider> action = base.onDidClickInterstitial;
			if (base.onDidClickInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S0_v10 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnShowInterstitial(string key)
	{
		if (key.Equals("interstitial"))
		{
			Action<ScreenAdProvider> action = base.onDidShowInterstitial;
			if (base.onDidShowInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S0_v9 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
