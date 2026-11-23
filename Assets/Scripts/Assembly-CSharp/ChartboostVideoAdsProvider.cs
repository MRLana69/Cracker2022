using System;
using System.Collections;
using System.Collections.Generic;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Plugins.Chartboost;
using Kiloo.Plugins.Chartboost.Internal;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

public class ChartboostVideoAdsProvider : VideoAdProvider
{
	private sealed class _003CCheckVideoAvailability_003Ed__43(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ChartboostVideoAdsProvider _003C_003E4__this;

		private int _003CmaxRetries_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			ChartboostVideoAdsProvider chartboostVideoAdsProvider = _003C_003E4__this;
			bool flag;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_011f;
				}
				_003C_003E1__state = -1;
				if (ProviderHasAdAvailable())
				{
					goto IL_0160;
				}
				flag = ++_003Ci_003E5__3 < _003CmaxRetries_003E5__2;
			}
			else
			{
				_003C_003E1__state = -1;
				_003C_003E4__this.InitiateCachingTimeLogging();
				chartboostVideoAdsProvider._isCheckAvailabilityCoroutineRunning = true;
				if (ProviderHasAdAvailable())
				{
					goto IL_0160;
				}
				OnlineSettings instance = OnlineSettings.instance;
				int value = instance.GetValue("chartboost_video_caching_timelimit", CHARTBOOST_DEFAULT_CACHING_TIMELIMIT);
				_003Ci_003E5__3 = 0;
				_003CmaxRetries_003E5__2 = value;
				flag = value > 0;
			}
			if (!flag)
			{
				_003C_003E4__this.OnVideoCachingTimedOut();
				goto IL_011f;
			}
			IEnumerator coroutine = CoroutineUtil.WaitForRealSeconds(1f);
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			_003C_003E2__current = coroutine2;
			_003C_003E1__state = 1;
			return true;
			IL_0160:
			_003C_003E4__this.OnVideoCachingSuccess((string)(object)this);
			return false;
			IL_011f:
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

	private bool _videoWatched;

	private int _priority;

	private int _weight;

	private const string REWARDEDVIDEO_LOCATION = "Main Menu";

	private const string PROVIDER_CHARTBOOST_PRIORITY = "chartboost_video_priority";

	private const int CHARTBOOST_DEFAULT_PRIORITY = 5;

	private const int CHARTBOOST_DEFAULT_WEIGHT = 50;

	private IEnumerator _checkVideoCoroutine;

	private bool _isCheckAvailabilityCoroutineRunning;

	private const string PROVIDER_CHARTBOOST_CACHING_TIMELIMIT = "chartboost_video_caching_timelimit";

	private static readonly int CHARTBOOST_DEFAULT_CACHING_TIMELIMIT = 10;

	private static ChartboostVideoAdsProvider _instance;

	private float _cachingStartTime = float.MinValue;

	private float _appMinimizedTime;

	private float _appResumedTime;

	private float _amountOfTimePaused;

	public static ChartboostVideoAdsProvider instance
	{
		get
		{
			bool flag = _instance == null;
			bool flag2 = !flag;
			ChartboostVideoAdsProvider result = _instance;
			if (!flag2)
			{
				ChartboostVideoAdsProvider chartboostVideoAdsProvider = default;
				chartboostVideoAdsProvider._002Ector();
				_instance = chartboostVideoAdsProvider;
				result = chartboostVideoAdsProvider;
			}
			return result;
		}
	}

	public static bool isVideoProviderSupported
	{
		get
		{
			if (DeviceUtility.isKindleDevice)
			{
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1669");
			bool result = default;
			return result;
		}
	}

	public override bool isInitialized => _initialized;

	public override bool allowedWhenAgeRestricted => true;

	public override bool IsStopped => false;

	public override string id
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
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

	private unsafe ChartboostVideoAdsProvider()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Ref, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Ref, but got Unknown
		VideoAdProvider.SetVideoProviderData("chartboost_video_priority", 5, 50, ref *(int*)(this + 36), ref *(int*)(this + 40));
	}

	public unsafe override void Init()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			AdConstants adConstants = AdConstants.instance;
			string chartboostAppId = adConstants.ChartboostAppId;
			AdConstants adConstants2 = AdConstants.instance;
			string chartboostAppSignature = adConstants2.ChartboostAppSignature;
			Chartboost.StartSession(chartboostAppId, chartboostAppSignature);
			ChartboostLocationCallback chartboostLocationCallback = default;
			chartboostLocationCallback._002Ector(this, (nint)__ldftn(ChartboostVideoAdsProvider.OnVideoCachingSuccess));
			Chartboost.onCacheRewardedVideo += chartboostLocationCallback;
			ChartboostLocationCallback chartboostLocationCallback2 = default;
			chartboostLocationCallback2._002Ector(this, (nint)__ldftn(ChartboostVideoAdsProvider.OnVideoCachingFailed));
			Chartboost.onFailToLoadRewardedVideo += chartboostLocationCallback2;
			ChartboostLocationCallback chartboostLocationCallback3 = default;
			chartboostLocationCallback3._002Ector(this, (nint)__ldftn(ChartboostVideoAdsProvider.OnDismissVideo));
			Chartboost.onDismissRewardedVideo += chartboostLocationCallback3;
			ChartboostLocationCallback chartboostLocationCallback4 = default;
			chartboostLocationCallback4._002Ector(this, (nint)__ldftn(ChartboostVideoAdsProvider.OnVideoFinished));
			Chartboost.onCloseRewardedVideo += chartboostLocationCallback4;
			ChartboostLocationCallback chartboostLocationCallback5 = default;
			chartboostLocationCallback5._002Ector(this, (nint)__ldftn(ChartboostVideoAdsProvider.OnClickRewardedVideo));
			Chartboost.onClickRewardedVideo += chartboostLocationCallback5;
			ChartboostLocationCallback chartboostLocationCallback6 = default;
			chartboostLocationCallback6._002Ector(this, (nint)__ldftn(ChartboostVideoAdsProvider.OnCompleteIncentive));
			Chartboost.onCompleteRewardedVideo += chartboostLocationCallback6;
			ChartboostLocationCallback chartboostLocationCallback7 = default;
			chartboostLocationCallback7._002Ector(this, (nint)__ldftn(ChartboostVideoAdsProvider.OnDisplayRewardedVideo));
			Chartboost.onDisplayRewardedVideo += chartboostLocationCallback7;
			ChartboostLocationCallback chartboostLocationCallback8 = default;
			chartboostLocationCallback8._002Ector(this, (nint)__ldftn(ChartboostVideoAdsProvider.OnVideoStart));
			Chartboost.onWillDisplayVideo += chartboostLocationCallback8;
			_initialized = true;
		}
	}

	public override bool PlayVideoIfAvailable()
	{
		_videoWatched = false;
		bool flag = (byte)(~(_initialized ? 1u : 0u)) != 0;
		bool result = false;
		if (!flag)
		{
			bool flag2 = ProviderHasAdAvailable();
			bool flag3 = !flag2;
			result = false;
			if (!flag3)
			{
				Chartboost.ShowRewardedVideo("Main Menu");
				result = true;
			}
		}
		return result;
	}

	public override void StopProvider()
	{
	}

	public override void ResumeProvider()
	{
	}

	public override void StartCachingVideo()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			OnVideoCachingFailed((string)(object)this);
		}
		else if (~(_isCheckAvailabilityCoroutineRunning ? 1u : 0u) != 0)
		{
			Chartboost.CacheRewardedVideo("Main Menu");
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

	private bool ProviderHasAdAvailable()
	{
		return Chartboost.HasCachedRewardedVideo("Main Menu");
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

	private void OnVideoCachingSuccess(string location)
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

	private void OnVideoCachingFailed(string location)
	{
		//IL_0021: Expected Obj, but got I
		StopCheckVideoAvailabilityCouroutine();
		CalculateAndReportCachingTime("Failed");
		if (_onVideoUnavailable != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S4_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S4_v4+4] (should have been resolved before IL gen)");
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

	private void OnVideoStart(string location)
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

	private void OnVideoFinished(string location)
	{
		//IL_006b: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		if (~(_videoWatched ? 1u : 0u) == 0)
		{
			if (_onVideoWatched != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S3_v9 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S3_v10+4] (should have been resolved before IL gen)");
			}
			_videoWatched = false;
		}
		if (_onTakeoverEnded != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S3_v4 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S3_v5+4] (should have been resolved before IL gen)");
		}
	}

	private void OnCompleteIncentive(string location)
	{
		_videoWatched = true;
	}

	private void OnDismissVideo(string location)
	{
	}

	private void OnClickRewardedVideo(string location)
	{
	}

	private void OnDisplayRewardedVideo(string location)
	{
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
			ChartboostVideoAdsProvider chartboostVideoAdsProvider = instance;
			nint num6 = (nint)chartboostVideoAdsProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S1_v17 (Il2CppClass<ChartboostVideoAdsProvider>)+F4] (should have been resolved before IL gen)");
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
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
