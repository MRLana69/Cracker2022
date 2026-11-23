using System;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Plugins.MdotM;
using Kiloo.Plugins.MdotM.Internal;
using UnityEngine;

public class MdotMAdsProvider : ScreenAdProvider
{
	private ScreenAdProvider _mdotmProvider;

	private static MdotMAdsProvider _instance;

	private bool _isCaching;

	private bool _isPluginInitialized;

	public override bool isInitialized => _isPluginInitialized;

	public static MdotMAdsProvider instance
	{
		get
		{
			if (_instance == null)
			{
				MdotMAdsProvider mdotMAdsProvider = default;
				_instance = mdotMAdsProvider;
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
			if (MdotM.IsSupportedOnPlatform())
			{
				AdConstants adConstants = AdConstants.instance;
				string mdotmAppId = adConstants.MdotmAppId;
				if (mdotmAppId != null)
				{
					obj = 0;
					if (mdotmAppId._stringLength != 0)
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

	public override bool HasCachedInterstials => MdotM.HasCachedInterstitial();

	public override bool allowedWhenAgeRestricted => false;

	public override string id => "mdotm";

	private MdotMAdsProvider()
	{
	}

	public unsafe override void Init()
	{
		//IL_000a: Expected I, but got Obj
		if (!_isPluginInitialized)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v4 (Il2CppClass<MdotMAdsProvider>)+EC] (should have been resolved before IL gen)");
			object obj = default;
			if (obj != null)
			{
				_isPluginInitialized = true;
				AdConstants adConstants = AdConstants.instance;
				string mdotmAppId = adConstants.MdotmAppId;
				MdotM.StartSession(mdotmAppId);
				MdotMLocationCallback mdotMLocationCallback = default;
				mdotMLocationCallback._002Ector(this, (nint)__ldftn(MdotMAdsProvider.OnDidClickInterstitial));
				MdotM.onClickInterstitial += mdotMLocationCallback;
				MdotMLocationCallback mdotMLocationCallback2 = default;
				mdotMLocationCallback2._002Ector(this, (nint)__ldftn(MdotMAdsProvider.OnDidFailToLoadInterstitial));
				MdotM.onFailToLoadInterstitial += mdotMLocationCallback2;
				MdotMLocationCallback mdotMLocationCallback3 = default;
				mdotMLocationCallback3._002Ector(this, (nint)__ldftn(MdotMAdsProvider.OnDidCacheInterstitial));
				MdotM.onCacheInterstitial += mdotMLocationCallback3;
				MdotMLocationCallback mdotMLocationCallback4 = default;
				mdotMLocationCallback4._002Ector(this, (nint)__ldftn(MdotMAdsProvider.OnDidDismissInterstitial));
				MdotM.onDismissInterstitial += mdotMLocationCallback4;
				MdotMLocationCallback mdotMLocationCallback5 = default;
				mdotMLocationCallback5._002Ector(this, (nint)__ldftn(MdotMAdsProvider.OnShowInterstitial));
				MdotM.onShowInterstitial += mdotMLocationCallback5;
			}
		}
	}

	public override void ShowInterstitial()
	{
		MdotM.ShowInterstitial();
	}

	public override void CacheNowInterstitials()
	{
		if (~(_isCaching ? 1u : 0u) != 0)
		{
			MdotM.CacheInterstitial();
		}
	}

	private void OnDidClickInterstitial(string location)
	{
		_isCaching = false;
		Action<ScreenAdProvider> action = base.onDidClickInterstitial;
		if (base.onDidClickInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void OnDidCacheInterstitial(string location)
	{
		_isCaching = false;
		Action<ScreenAdProvider> action = base.onDidCacheInterstitial;
		if (base.onDidCacheInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void OnDidFailToLoadInterstitial(string location)
	{
		_isCaching = false;
		Action<ScreenAdProvider> action = base.onDidFailToLoadInterstitial;
		if (base.onDidFailToLoadInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void OnDidDismissInterstitial(string location)
	{
		_isCaching = false;
		Action<ScreenAdProvider> action = base.onDidDismissInterstitial;
		if (base.onDidDismissInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v4 @ S0_v3 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void OnShowInterstitial(string location)
	{
		Action<ScreenAdProvider> action = base.onDidShowInterstitial;
		if (base.onDidShowInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
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
