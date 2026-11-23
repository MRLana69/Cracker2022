using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Monetization.FacebookAds;
using UnityEngine;

public class FacebookNativeAdProvider : ScreenAdProvider
{
	private sealed class _003CCacheInterstitial_003Ed__21(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FacebookNativeAdProvider _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			FacebookNativeAdProvider facebookNativeAdProvider = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_00c2;
				}
			}
			else
			{
				_003Ctimer_003E5__2 = 0f;
			}
			_003C_003E1__state = -1;
			if (~(facebookNativeAdProvider._initialized ? 1u : 0u) != 0)
			{
				if (!(_003Ctimer_003E5__2 > 3f))
				{
					float unscaledDeltaTime = Time.unscaledDeltaTime;
					float num = _003Ctimer_003E5__2 + unscaledDeltaTime;
					_003C_003E2__current = null;
					_003Ctimer_003E5__2 = num;
					_003C_003E1__state = 1;
					return true;
				}
			}
			else
			{
				FacebookNativeAds.LoadNativeAd();
			}
			goto IL_00c2;
			IL_00c2:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private bool _instantiated;

	private bool _initialized;

	private bool _startedInitializing;

	private static FacebookNativeAdProvider _instance;

	private const float INITIALIZE_WAIT = 3f;

	private bool _adHasBeenShown;

	public NativeInterstitialAdObject adObject
	{
		get
		{
			if (FacebookNativeAds.IsNativeAdLoaded())
			{
				return FacebookNativeAds.GetAdObject();
			}
			return null;
		}
	}

	public static FacebookNativeAdProvider instance
	{
		get
		{
			if (_instance == null)
			{
				FacebookNativeAdProvider facebookNativeAdProvider = default;
				_instance = facebookNativeAdProvider;
			}
			return _instance;
		}
	}

	public override bool isInitialized => _initialized;

	public override bool HasCachedInterstials
	{
		get
		{
			if (~(_initialized ? 1u : 0u) != 0)
			{
				return false;
			}
			return FacebookNativeAds.IsNativeAdLoaded();
		}
	}

	public override bool isScreenAdProviderSupported => FacebookNativeAds.IsSupportedOnPlatform();

	public override string id => "facebook";

	public override bool allowedWhenAgeRestricted => false;

	public override void CacheNowInterstitials()
	{
		if (~(_startedInitializing ? 1u : 0u) == 0)
		{
			IEnumerator coroutine = CacheInterstitial();
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
		}
	}

	private IEnumerator CacheInterstitial()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override void Init()
	{
		_startedInitializing = true;
		if (~(_instantiated ? 1u : 0u) != 0)
		{
			throw new ArgumentException();
		}
	}

	private void OnInitialise(string placementID)
	{
		_initialized = true;
	}

	private void OnNativeDidLoad(string placementID)
	{
		Action<ScreenAdProvider> action = base.onDidCacheInterstitial;
		if (base.onDidCacheInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
		_adHasBeenShown = false;
	}

	private void OnNativeAdError(string error)
	{
		Action<ScreenAdProvider> action = base.onDidFailToLoadInterstitial;
		if (base.onDidFailToLoadInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void DisposeAd()
	{
		FacebookNativeAds.DisposeNativeAd();
	}

	public override void ShowInterstitial()
	{
	}

	public override bool IsNativeProvider()
	{
		return true;
	}

	public override void NativeAdWasShown()
	{
		Action<ScreenAdProvider> action = base.onDidShowInterstitial;
		if (base.onDidShowInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
		FacebookNativeAds.LogExternalImpression();
		_adHasBeenShown = true;
	}

	public override void NativeAdWasHidden()
	{
		if (~(_adHasBeenShown ? 1u : 0u) == 0)
		{
			FacebookNativeAds.DisposeNativeAd();
		}
		Action<ScreenAdProvider> action = base.onDidDismissInterstitial;
		if (base.onDidDismissInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S0_v5 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	public override NativeInterstitialAdObject NativeGetAdObject()
	{
		return ((FacebookNativeAdProvider)null).adObject;
	}

	public override void DiscardInvalidAd()
	{
		FacebookNativeAds.DisposeNativeAd();
	}

	public override void NativeAdWasClicked()
	{
		FacebookNativeAds.LogExternalClick();
		Action<ScreenAdProvider> action = base.onDidClickInterstitial;
		if (base.onDidClickInterstitial != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S0_v3 (System.Action`1<ScreenAdProvider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void Log(string s)
	{
	}
}
