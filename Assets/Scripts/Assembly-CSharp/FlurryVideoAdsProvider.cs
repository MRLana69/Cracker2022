using System;
using System.Collections;
using System.Collections.Generic;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Monetization.Flurry;
using Kiloo.Monetization.Flurry.Internal;
using UnityEngine;

public class FlurryVideoAdsProvider : VideoAdProvider
{
	private sealed class _003CCheckVideoAvailability_003Ed__40(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FlurryVideoAdsProvider _003C_003E4__this;

		private int _003CmaxRetries_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00db: Expected Obj, but got I
			FlurryVideoAdsProvider flurryVideoAdsProvider = _003C_003E4__this;
			bool flag;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_01ca;
				}
				_003C_003E1__state = -1;
				if (~(flurryVideoAdsProvider._isVideoAvailable ? 1u : 0u) == 0)
				{
					_003C_003E4__this.OnVideoCachingSucceded();
					return false;
				}
				flag = ++_003Ci_003E5__3 < _003CmaxRetries_003E5__2;
			}
			else
			{
				_003C_003E1__state = -1;
				_003C_003E4__this.InitiateCachingTimeLogging();
				flurryVideoAdsProvider._isVideoAvailable = false;
				RuntimePlatform platform = Application.platform;
				if ((platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor) && flurryVideoAdsProvider._onVideoUnavailable != null)
				{
					nint num = 0;
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S4_v5 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v137 @ S4_v6+4] (should have been resolved before IL gen)");
				}
				if (FlurryVideoAds.HasCachedAd())
				{
					_003C_003E4__this.OnVideoCachingSucceded();
					goto IL_01ca;
				}
				FlurryVideoAds.CacheAd();
				OnlineSettings instance = OnlineSettings.instance;
				int value = instance.GetValue("flurry_video_caching_timelimit", FLURRY_DEFAULT_CACHING_TIMELIMIT);
				_003Ci_003E5__3 = 0;
				_003CmaxRetries_003E5__2 = value;
				flag = value > 0;
			}
			if (!flag)
			{
				_003C_003E4__this.OnVideoCachingTimedOut();
				return false;
			}
			IEnumerator coroutine = CoroutineUtil.WaitForRealSeconds(1f);
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			_003C_003E2__current = coroutine2;
			_003C_003E1__state = 1;
			return true;
			IL_01ca:
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

	private bool _initialized;

	private bool _isStopped;

	private bool _isVideoAvailable;

	private bool _isCheckAvailabilityCoroutineRunning;

	private IEnumerator _checkVideoCoroutine;

	private const string PROVIDER_FLURRYVIDEO_PRIORITY = "flurry_video_priority";

	private static readonly int FLURRYVIDEO_DEFAULT_PRIORITY = 4;

	private static readonly int FLURRYVIDEO_DEFAULT_WEIGHT = 10;

	private const string PROVIDER_FLURRY_CACHING_TIMELIMIT = "flurry_video_caching_timelimit";

	private static readonly int FLURRY_DEFAULT_CACHING_TIMELIMIT = 10;

	private static FlurryVideoAdsProvider _instance;

	private string _id;

	private int _priority;

	private int _weight;

	private float _cachingStartTime = float.MinValue;

	private float _appMinimizedTime;

	private float _appResumedTime;

	private float _amountOfTimePaused;

	public static FlurryVideoAdsProvider instance
	{
		get
		{
			if (_instance == null)
			{
				FlurryVideoAdsProvider flurryVideoAdsProvider = default;
				flurryVideoAdsProvider._002Ector();
				_instance = flurryVideoAdsProvider;
			}
			return _instance;
		}
	}

	public static bool isVideoProviderSupported
	{
		get
		{
			//IL_007f: Expected Obj, but got I4
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected I4, but got Unknown
			//IL_0063: Expected Obj, but got I4
			object obj;
			if (FlurryVideoAds.IsSupportedOnPlatform())
			{
				AdConstants adConstants = AdConstants.instance;
				string flurryAdSpace = adConstants.FlurryAdSpace;
				if (flurryAdSpace != null)
				{
					obj = 0;
					if (flurryAdSpace._stringLength != 0)
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

	public override bool isInitialized => _initialized;

	public override bool allowedWhenAgeRestricted => false;

	public override bool IsStopped => _isStopped;

	public override string id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = value;
		}
	}

	public override int priority
	{
		get
		{
			return _priority;
		}
		set
		{
			_priority = value;
		}
	}

	public override int weight
	{
		get
		{
			return _weight;
		}
		set
		{
			_weight = value;
		}
	}

	private unsafe FlurryVideoAdsProvider()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Ref, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Ref, but got Unknown
		VideoAdProvider.SetVideoProviderData("flurry_video_priority", FLURRYVIDEO_DEFAULT_PRIORITY, FLURRYVIDEO_DEFAULT_WEIGHT, ref *(int*)(this + 44), ref *(int*)(this + 48));
	}

	public unsafe override void Init()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			FlurryAdsCallback flurryAdsCallback = default;
			flurryAdsCallback._002Ector(this, (nint)__ldftn(FlurryVideoAdsProvider.OnTakeoverWillDisplay));
			FlurryVideoAds.onTakeoverWillDisplay += flurryAdsCallback;
			FlurryAdsCallback flurryAdsCallback2 = default;
			flurryAdsCallback2._002Ector(this, (nint)__ldftn(FlurryVideoAdsProvider.OnTakeoverWillClose));
			FlurryVideoAds.onTakeoverWillClose += flurryAdsCallback2;
			FlurryAdsCallback flurryAdsCallback3 = default;
			flurryAdsCallback3._002Ector(this, (nint)__ldftn(FlurryVideoAdsProvider.OnVideoDidFinish));
			FlurryVideoAds.onVideoDidFinish += flurryAdsCallback3;
			FlurryAdsCallback flurryAdsCallback4 = default;
			flurryAdsCallback4._002Ector(this, (nint)__ldftn(FlurryVideoAdsProvider.OnVideoDidNotFinish));
			FlurryVideoAds.onVideoDidNotFinish += flurryAdsCallback4;
			FlurryAdsCallback flurryAdsCallback5 = default;
			flurryAdsCallback5._002Ector(this, (nint)__ldftn(FlurryVideoAdsProvider.OnVideoAvailable));
			FlurryVideoAds.onVideoAvailable += flurryAdsCallback5;
			FlurryAdsCallback flurryAdsCallback6 = default;
			flurryAdsCallback6._002Ector(this, (nint)__ldftn(FlurryVideoAdsProvider.OnVideoUnavailable));
			FlurryVideoAds.onVideoUnavailable += flurryAdsCallback6;
			AdConstants adConstants = AdConstants.instance;
			string flurryAdSpace = adConstants.FlurryAdSpace;
			FlurryVideoAds.Initialize(flurryAdSpace);
			_initialized = true;
		}
	}

	public override void StartCachingVideo()
	{
		if (~(_isCheckAvailabilityCoroutineRunning ? 1u : 0u) != 0)
		{
			IEnumerator checkVideoCoroutine = CheckVideoAvailability();
			_checkVideoCoroutine = checkVideoCoroutine;
			Coroutine coroutine = CoroutineUtil.StartCoroutine(_checkVideoCoroutine);
		}
	}

	private IEnumerator CheckVideoAvailability()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void OnVideoCachingSucceded()
	{
		//IL_0021: Expected Obj, but got I
		StopCheckVideoAvailabilityCouroutine();
		CalculateAndReportCachingTime("Success");
		if (_onVideoAvailable != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnVideoCachingFailed(string message = "")
	{
		//IL_0021: Expected Obj, but got I
		StopCheckVideoAvailabilityCouroutine();
		CalculateAndReportCachingTime("Failed");
		if (_onVideoUnavailable != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S4_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S4_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnVideoCachingTimedOut()
	{
		//IL_0021: Expected Obj, but got I
		StopCheckVideoAvailabilityCouroutine();
		_amountOfTimePaused = 0f;
		_cachingStartTime = float.MinValue;
		if (_onCachingTimedOut != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void StopCheckVideoAvailabilityCouroutine()
	{
		if (~(_isCheckAvailabilityCoroutineRunning ? 1u : 0u) == 0)
		{
			CoroutineUtil.StopCoroutine(_checkVideoCoroutine);
			_isCheckAvailabilityCoroutineRunning = false;
		}
	}

	public override bool PlayVideoIfAvailable()
	{
		if (~(_initialized ? 1u : 0u) == 0)
		{
			if (FlurryVideoAds.HasCachedAd())
			{
				FlurryVideoAds.ShowAd();
				return true;
			}
		}
		else
		{
			LogError("FlurryVideoAdsProvider PlayVideoIfAvailable() called before initialized");
		}
		return false;
	}

	public override void StopProvider()
	{
	}

	public override void ResumeProvider()
	{
	}

	public override void OnPause()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		_appMinimizedTime = realtimeSinceStartup;
	}

	public override void OnResume()
	{
		float num = (_appResumedTime = Time.realtimeSinceStartup) - _appMinimizedTime;
		float amountOfTimePaused = _amountOfTimePaused + num;
		_amountOfTimePaused = amountOfTimePaused;
	}

	private void OnTakeoverWillDisplay(string adSpace)
	{
		//IL_0021: Expected Obj, but got I
		if (_onTakeoverBegan != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnTakeoverWillClose(string adSpace)
	{
		//IL_0021: Expected Obj, but got I
		if (_onTakeoverEnded != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnVideoDidFinish(string adSpace)
	{
		//IL_0021: Expected Obj, but got I
		if (_onVideoWatched != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnVideoDidNotFinish(string message)
	{
	}

	private void OnVideoAvailable(string adSpace)
	{
		OnVideoCachingSucceded();
		_isVideoAvailable = true;
	}

	private void OnVideoUnavailable(string message)
	{
		_isVideoAvailable = false;
		string text = default;
		if (!text.Contains("100"))
		{
		}
		OnVideoCachingFailed(string.Empty);
	}

	public unsafe void CalculateAndReportCachingTime(string argkeyState)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008e: Expected Ref, but got F8
		//IL_00ad: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_cachingStartTime > float.MinValue)
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float num = _cachingStartTime + _amountOfTimePaused;
			float num2 = realtimeSinceStartup - num;
			float num3 = num2 + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			object obj3 = default;
			double num4 = (double)obj3 * 0.5;
			double num5 = (double)obj + 8.0;
			string text = ((double*)num5)->ToString();
			FlurryVideoAdsProvider flurryVideoAdsProvider = instance;
			nint num6 = (nint)flurryVideoAdsProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S1_v17 (Il2CppClass<FlurryVideoAdsProvider>)+F4] (should have been resolved before IL gen)");
			string text3 = default;
			string text2 = text3 + argkeyState + " Time";
		}
		_amountOfTimePaused = 0f;
		_cachingStartTime = float.MinValue;
	}

	private void InitiateCachingTimeLogging()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		_amountOfTimePaused = 0f;
		_cachingStartTime = realtimeSinceStartup;
	}

	private void ResetCachingTimeLogging()
	{
		_amountOfTimePaused = 0f;
		_cachingStartTime = float.MinValue;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "FlurryVideoAdsProvider: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
