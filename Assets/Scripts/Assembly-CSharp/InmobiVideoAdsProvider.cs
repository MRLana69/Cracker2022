using System;
using System.Collections;
using System.Collections.Generic;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Monetization.Inmobi;
using Kiloo.Monetization.Inmobi.Internal;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

public class InmobiVideoAdsProvider : VideoAdProvider
{
	private sealed class _003CCheckVideoAvailability_003Ed__47(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public InmobiVideoAdsProvider _003C_003E4__this;

		private int _003CmaxRetries_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			InmobiVideoAdsProvider inmobiVideoAdsProvider = _003C_003E4__this;
			bool flag;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0124;
				}
				_003C_003E1__state = -1;
				if (ProviderHasAdAvailable())
				{
					goto IL_0165;
				}
				flag = ++_003Ci_003E5__3 < _003CmaxRetries_003E5__2;
			}
			else
			{
				_003C_003E1__state = -1;
				_003C_003E4__this.InitiateCachingTimeLogging();
				inmobiVideoAdsProvider._isCheckAvailabilityCoroutineRunning = true;
				if (ProviderHasAdAvailable())
				{
					goto IL_0165;
				}
				OnlineSettings instance = OnlineSettings.instance;
				int value = instance.GetValue("inmobi_video_caching_timelimit", INMOBI_DEFAULT_CACHING_TIMELIMIT);
				_003Ci_003E5__3 = 0;
				_003CmaxRetries_003E5__2 = value;
				flag = value > 0;
			}
			if (!flag)
			{
				_003C_003E4__this.OnVideoCachingTimedOut("rewardedVideo");
				goto IL_0124;
			}
			IEnumerator coroutine = CoroutineUtil.WaitForRealSeconds(1f);
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			_003C_003E2__current = coroutine2;
			_003C_003E1__state = 1;
			return true;
			IL_0165:
			_003C_003E4__this.OnVideoCachingSuccess("rewardedVideo");
			return false;
			IL_0124:
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

	private const string KEY_REWARDED_VIDEO = "rewardedVideo";

	private const string PROVIDER_INMOBI_PRIORITY = "inmobi_video_priority";

	private const int INMOBI_DEFAULT_PRIORITY = 3;

	private const int INMOBI_DEFAULT_WEIGHT = 50;

	private const int MINIMUM_SUPPORTED_ANDROID_API = 16;

	private const int MINIMUM_SUPPORTED_IOS_VERSION = 8;

	private IEnumerator _checkVideoCoroutine;

	private bool _isCheckAvailabilityCoroutineRunning;

	private const string PROVIDER_INMOBI_CACHING_TIMELIMIT = "inmobi_video_caching_timelimit";

	private static readonly int INMOBI_DEFAULT_CACHING_TIMELIMIT = 10;

	private static InmobiVideoAdsProvider _instance;

	private float _cachingStartTime = float.MinValue;

	private float _appMinimizedTime;

	private float _appResumedTime;

	private float _amountOfTimePaused;

	public static InmobiVideoAdsProvider instance
	{
		get
		{
			bool flag = _instance == null;
			bool flag2 = !flag;
			InmobiVideoAdsProvider result = _instance;
			if (!flag2)
			{
				InmobiVideoAdsProvider inmobiVideoAdsProvider = default;
				inmobiVideoAdsProvider._002Ector();
				_instance = inmobiVideoAdsProvider;
				result = inmobiVideoAdsProvider;
			}
			return result;
		}
	}

	public static bool isVideoProviderSupported
	{
		get
		{
			//IL_0067: Expected Obj, but got I4
			//IL_011c: Expected Obj, but got I4
			//IL_004b: Expected Obj, but got I4
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected I4, but got Unknown
			//IL_00c9: Expected Obj, but got I4
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_00ad: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1669");
			AdConstants adConstants = AdConstants.instance;
			string inmobiAppIdRewardedVideo = adConstants.InmobiAppIdRewardedVideo;
			object obj;
			if (inmobiAppIdRewardedVideo != null)
			{
				obj = 0;
				if (inmobiAppIdRewardedVideo._stringLength != 0)
				{
					goto IL_00f9;
				}
			}
			obj = 1;
			goto IL_00f9;
			IL_0164:
			RuntimePlatform platform = Application.platform;
			bool flag;
			if (platform == RuntimePlatform.Android)
			{
				int androidApiLevel = DeviceUtility.GetAndroidApiLevel();
				flag = androidApiLevel > 15;
			}
			else
			{
				flag = true;
			}
			object obj3;
			object obj4 = default;
			object obj2 = obj3 & obj4;
			return (byte)((flag & obj2) ? 1 : 0) != 0;
			IL_012a:
			object obj6;
			object obj5 = obj6 ^ 1;
			obj3 = obj5;
			goto IL_0164;
			IL_00f9:
			bool flag2 = obj == null;
			bool flag3 = !flag2;
			obj3 = 0;
			if (!flag3)
			{
				AdConstants adConstants2 = AdConstants.instance;
				string inmobiAccountId = adConstants2.InmobiAccountId;
				if (inmobiAccountId != null)
				{
					obj6 = 0;
					if (inmobiAccountId._stringLength != 0)
					{
						goto IL_012a;
					}
				}
				obj6 = 1;
				goto IL_012a;
			}
			goto IL_0164;
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

	private string appId
	{
		get
		{
			AdConstants adConstants = AdConstants.instance;
			return adConstants.InmobiAppIdRewardedVideo;
		}
	}

	private unsafe InmobiVideoAdsProvider()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Ref, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Ref, but got Unknown
		VideoAdProvider.SetVideoProviderData("inmobi_video_priority", 3, 50, ref *(int*)(this + 36), ref *(int*)(this + 40));
	}

	public unsafe override void Init()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			InmobiCallback inmobiCallback = default;
			inmobiCallback._002Ector(this, (nint)__ldftn(InmobiVideoAdsProvider.OnVideoCachingSuccess));
			InmobiPlugin.onCacheAd += inmobiCallback;
			InmobiCallback inmobiCallback2 = default;
			inmobiCallback2._002Ector(this, (nint)__ldftn(InmobiVideoAdsProvider.OnVideoCachingFailed));
			InmobiPlugin.onFailToLoadAd += inmobiCallback2;
			InmobiCallback inmobiCallback3 = default;
			inmobiCallback3._002Ector(this, (nint)__ldftn(InmobiVideoAdsProvider.OnVideoStart));
			InmobiPlugin.willShowAd += inmobiCallback3;
			InmobiCallback inmobiCallback4 = default;
			inmobiCallback4._002Ector(this, (nint)__ldftn(InmobiVideoAdsProvider.OnVideoFinished));
			InmobiPlugin.onDismissAd += inmobiCallback4;
			InmobiCallback inmobiCallback5 = default;
			inmobiCallback5._002Ector(this, (nint)__ldftn(InmobiVideoAdsProvider.OnCompleteIncentive));
			InmobiPlugin.onCompleteIncentive += inmobiCallback5;
			AdConstants adConstants = AdConstants.instance;
			string inmobiAccountId = adConstants.InmobiAccountId;
			InmobiPlugin.Initialize(inmobiAccountId);
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
				string text = appId;
				InmobiPlugin.ShowAd("rewardedVideo", text);
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
			string key = appId;
			OnVideoCachingFailed(key);
		}
		else if (~(_isCheckAvailabilityCoroutineRunning ? 1u : 0u) != 0)
		{
			string text = appId;
			InmobiPlugin.CacheAd("rewardedVideo", text);
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
		string text = ((InmobiVideoAdsProvider)null).appId;
		return InmobiPlugin.HasCachedAd("rewardedVideo", text);
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

	private void OnVideoCachingSuccess(string key)
	{
		//IL_0056: Expected Obj, but got I
		if (key.Equals("rewardedVideo"))
		{
			StopCheckVideoAvailabilityCouroutine();
			CalculateAndReportCachingTime("Success");
			if (_onVideoAvailable != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S3_v4+4] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnVideoCachingFailed(string key)
	{
		//IL_0056: Expected Obj, but got I
		if (key.Equals("rewardedVideo"))
		{
			StopCheckVideoAvailabilityCouroutine();
			CalculateAndReportCachingTime("Failed");
			if (_onVideoUnavailable != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S4_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ S4_v4+4] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnVideoCachingTimedOut(string key)
	{
		//IL_005c: Expected Obj, but got I
		if (key.Equals("rewardedVideo"))
		{
			StopCheckVideoAvailabilityCouroutine();
			_amountOfTimePaused = 0f;
			_cachingStartTime = float.MinValue;
			if (_onCachingTimedOut != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S3_v4+4] (should have been resolved before IL gen)");
			}
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

	private void OnVideoStart(string key)
	{
		//IL_0040: Expected Obj, but got I
		if (key.Equals("rewardedVideo") && _onTakeoverBegan != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnVideoFinished(string key)
	{
		//IL_0084: Expected Obj, but got I
		//IL_0059: Expected Obj, but got I
		if (!key.Equals("rewardedVideo"))
		{
			return;
		}
		if (~(_videoWatched ? 1u : 0u) == 0)
		{
			if (_onVideoWatched != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S3_v9 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ S3_v10+4] (should have been resolved before IL gen)");
			}
			_videoWatched = false;
		}
		if (_onTakeoverEnded != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S3_v4 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S3_v5+4] (should have been resolved before IL gen)");
		}
	}

	private void OnCompleteIncentive(string key)
	{
		if (key.Equals("rewardedVideo"))
		{
			_videoWatched = true;
		}
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
			InmobiVideoAdsProvider inmobiVideoAdsProvider = instance;
			nint num6 = (nint)inmobiVideoAdsProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S1_v17 (Il2CppClass<InmobiVideoAdsProvider>)+F4] (should have been resolved before IL gen)");
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
		string text = "[InmobiVideo] " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
