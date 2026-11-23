using System;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Plugins.Chartboost;
using Kiloo.Plugins.Chartboost.Internal;
using UnityEngine;

public class ChartboostAdsProvider : ScreenAdProvider
{
	private ScreenAdProvider _chartboostProvider;

	private static ChartboostAdsProvider _instance;

	private bool _isCaching;

	private bool _isPluginInitialized;

	private const string LOCATION_INTERSTITIAL = "Main Menu";

	public override bool isInitialized => _isPluginInitialized;

	public static ChartboostAdsProvider instance
	{
		get
		{
			if (_instance == null)
			{
				ChartboostAdsProvider chartboostAdsProvider = default;
				_instance = chartboostAdsProvider;
			}
			return _instance;
		}
	}

	public override bool isScreenAdProviderSupported
	{
		get
		{
			//IL_008d: Expected Obj, but got I4
			//IL_0071: Expected Obj, but got I4
			//IL_00ef: Expected Obj, but got I4
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Expected I4, but got Unknown
			//IL_00d3: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1669");
			object obj = default;
			bool flag = obj == null;
			bool result = false;
			if (flag)
			{
				goto IL_00f4;
			}
			AdConstants adConstants = AdConstants.instance;
			string chartboostAppId = adConstants.ChartboostAppId;
			object obj2;
			if (chartboostAppId != null)
			{
				obj2 = 0;
				if (chartboostAppId._stringLength != 0)
				{
					goto IL_00f9;
				}
			}
			obj2 = 1;
			goto IL_00f9;
			IL_00f9:
			result = false;
			if (obj2 != null)
			{
				goto IL_00f4;
			}
			AdConstants adConstants2 = AdConstants.instance;
			string chartboostAppSignature = adConstants2.ChartboostAppSignature;
			object obj3;
			if (chartboostAppSignature != null)
			{
				obj3 = 0;
				if (chartboostAppSignature._stringLength != 0)
				{
					goto IL_0110;
				}
			}
			obj3 = 1;
			goto IL_0110;
			IL_00f4:
			return result;
			IL_0110:
			result = (byte)(obj3 ^ 1) != 0;
			goto IL_00f4;
		}
	}

	public override bool HasCachedInterstials => Chartboost.HasCachedInterstitial("Main Menu");

	public override bool allowedWhenAgeRestricted => true;

	public override string id => "chartboost";

	private ChartboostAdsProvider()
	{
	}

	public unsafe override void Init()
	{
		//IL_000a: Expected I, but got Obj
		if (!_isPluginInitialized)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v4 (Il2CppClass<ChartboostAdsProvider>)+EC] (should have been resolved before IL gen)");
			object obj = default;
			if (obj != null)
			{
				_isPluginInitialized = true;
				AdConstants adConstants = AdConstants.instance;
				string chartboostAppId = adConstants.ChartboostAppId;
				AdConstants adConstants2 = AdConstants.instance;
				string chartboostAppSignature = adConstants2.ChartboostAppSignature;
				Chartboost.StartSession(chartboostAppId, chartboostAppSignature);
				ChartboostLocationCallback chartboostLocationCallback = default;
				chartboostLocationCallback._002Ector(this, (nint)__ldftn(ChartboostAdsProvider.OnDidClickInterstitial));
				Chartboost.onClickInterstitial += chartboostLocationCallback;
				ChartboostLocationCallback chartboostLocationCallback2 = default;
				chartboostLocationCallback2._002Ector(this, (nint)__ldftn(ChartboostAdsProvider.OnDidFailToLoadInterstitial));
				Chartboost.onFailToLoadInterstitial += chartboostLocationCallback2;
				ChartboostLocationCallback chartboostLocationCallback3 = default;
				chartboostLocationCallback3._002Ector(this, (nint)__ldftn(ChartboostAdsProvider.OnDidCacheInterstitial));
				Chartboost.onCacheInterstitial += chartboostLocationCallback3;
				ChartboostLocationCallback chartboostLocationCallback4 = default;
				chartboostLocationCallback4._002Ector(this, (nint)__ldftn(ChartboostAdsProvider.OnDidDismissInterstitial));
				Chartboost.onDismissInterstitial += chartboostLocationCallback4;
				ChartboostLocationCallback chartboostLocationCallback5 = default;
				chartboostLocationCallback5._002Ector(this, (nint)__ldftn(ChartboostAdsProvider.OnShowInterstitial));
				Chartboost.onShowInterstitial += chartboostLocationCallback5;
			}
		}
	}

	public override void ShowInterstitial()
	{
		Chartboost.ShowInterstitial("Main Menu");
	}

	public override void CacheNowInterstitials()
	{
		if (~(_isCaching ? 1u : 0u) != 0)
		{
			Chartboost.CacheInterstitial("Main Menu");
		}
	}

	private void OnDidClickInterstitial(string location)
	{
		if (location.Equals("Main Menu"))
		{
			_isCaching = false;
			Action<ScreenAdProvider> action = base.onDidClickInterstitial;
			if (base.onDidClickInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S0_v10 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnDidCacheInterstitial(string location)
	{
		if (location.Equals("Main Menu"))
		{
			_isCaching = false;
			Action<ScreenAdProvider> action = base.onDidCacheInterstitial;
			if (base.onDidCacheInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S0_v10 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnDidFailToLoadInterstitial(string location)
	{
		if (location.Equals("Main Menu"))
		{
			_isCaching = false;
			Action<ScreenAdProvider> action = base.onDidFailToLoadInterstitial;
			if (base.onDidFailToLoadInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S0_v10 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnDidDismissInterstitial(string location)
	{
		if (location.Equals("Main Menu"))
		{
			_isCaching = false;
			Action<ScreenAdProvider> action = base.onDidDismissInterstitial;
			if (base.onDidDismissInterstitial != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S0_v10 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnShowInterstitial(string location)
	{
		if (location.Equals("Main Menu"))
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
