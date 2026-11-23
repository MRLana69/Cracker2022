using System;
using System.Collections;
using System.Collections.Generic;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Monetization.Tapjoy;
using Kiloo.Monetization.Tapjoy.Internal;
using UnityEngine;

public class TapJoyVideoProvider : VideoAdProvider
{
	private enum TapJoyProviderConnectionState
	{
		Disconnected,
		Connecting,
		Connected
	}

	private sealed class _003CCheckVideoAvailability_003Ed__46(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TapJoyVideoProvider _003C_003E4__this;

		private int _003CmaxRetries_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			TapJoyVideoProvider tapJoyVideoProvider = _003C_003E4__this;
			bool flag;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_014e;
				}
				_003C_003E1__state = -1;
				if (~(tapJoyVideoProvider._isVideoAvailable ? 1u : 0u) == 0)
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
				tapJoyVideoProvider._isVideoAvailable = false;
				TapJoy.GetFullScreenAd();
				if (~(tapJoyVideoProvider._isVideoAvailable ? 1u : 0u) == 0)
				{
					_003C_003E4__this.OnVideoCachingSucceded();
					return false;
				}
				OnlineSettings instance = OnlineSettings.instance;
				int value = instance.GetValue("tapjoy_video_caching_timelimit", TAPJOYVIDEO_DEFAULT_CACHING_TIMELIMIT);
				_003Ci_003E5__3 = 0;
				_003CmaxRetries_003E5__2 = value;
				flag = value > 0;
			}
			if (!flag)
			{
				_003C_003E4__this.OnVideoCachingTimedOut();
				goto IL_014e;
			}
			IEnumerator coroutine = CoroutineUtil.WaitForRealSeconds(1f);
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			_003C_003E2__current = coroutine2;
			_003C_003E1__state = 1;
			return true;
			IL_014e:
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

	private bool _hasHookedUpEvents;

	private bool _isStopped;

	private bool _isVideoAvailable;

	private bool _isCheckAvailabilityCoroutineRunning;

	private bool _videoCompleted;

	private TapJoyProviderConnectionState _providerConnectionState;

	private const string PROVIDER_TAPJOYVIDEO_PRIORITY = "tapjoy_video_priority";

	private static readonly int TAPJOYVIDEO_DEFAULT_PRIORITY = 2;

	private static readonly int TAPJOYVIDEO_DEFAULT_WEIGHT;

	private IEnumerator _checkVideoCoroutine;

	private const string PROVIDER_TAPJOYVIDEO_CACHING_TIMELIMIT = "tapjoy_video_caching_timelimit";

	private static readonly int TAPJOYVIDEO_DEFAULT_CACHING_TIMELIMIT = 10;

	private static TapJoyVideoProvider _instance;

	private string _id;

	private int _weight;

	private int _priority;

	private float _cachingStartTime = float.MinValue;

	private float _appMinimizedTime;

	private float _appResumedTime;

	private float _amountOfTimePaused;

	public static TapJoyVideoProvider instance
	{
		get
		{
			if (_instance == null)
			{
				TapJoyVideoProvider tapJoyVideoProvider = default;
				tapJoyVideoProvider._002Ector();
				_instance = tapJoyVideoProvider;
			}
			return _instance;
		}
	}

	public static bool isVideoProviderSupported
	{
		get
		{
			//IL_0062: Expected Obj, but got I4
			//IL_0046: Expected Obj, but got I4
			//IL_00c4: Expected Obj, but got I4
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected I4, but got Unknown
			//IL_00a8: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A50");
			object obj = default;
			bool flag = obj == null;
			bool result = false;
			if (flag)
			{
				goto IL_00f9;
			}
			AdConstants adConstants = AdConstants.instance;
			string tapJoyAppId = adConstants.TapJoyAppId;
			object obj2;
			if (tapJoyAppId != null)
			{
				obj2 = 0;
				if (tapJoyAppId._stringLength != 0)
				{
					goto IL_00fe;
				}
			}
			obj2 = 1;
			goto IL_00fe;
			IL_00fe:
			result = false;
			if (obj2 != null)
			{
				goto IL_00f9;
			}
			AdConstants adConstants2 = AdConstants.instance;
			string tapJoyAppKey = adConstants2.TapJoyAppKey;
			object obj3;
			if (tapJoyAppKey != null)
			{
				obj3 = 0;
				if (tapJoyAppKey._stringLength != 0)
				{
					goto IL_0115;
				}
			}
			obj3 = 1;
			goto IL_0115;
			IL_00f9:
			return result;
			IL_0115:
			bool flag2 = (byte)(obj3 ^ 1) != 0;
			result = flag2;
			goto IL_00f9;
		}
	}

	public override bool isInitialized => _providerConnectionState == TapJoyProviderConnectionState.Connected;

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

	private unsafe TapJoyVideoProvider()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Ref, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Ref, but got Unknown
		VideoAdProvider.SetVideoProviderData("tapjoy_video_priority", TAPJOYVIDEO_DEFAULT_PRIORITY, TAPJOYVIDEO_DEFAULT_WEIGHT, ref *(int*)(this + 56), ref *(int*)(this + 52));
	}

	public unsafe override void Init()
	{
		//IL_022a: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<TapJoyVideoProvider>)+DC] (should have been resolved before IL gen)");
		object obj = default;
		if (obj == null && _providerConnectionState != TapJoyProviderConnectionState.Connecting && isVideoProviderSupported)
		{
			_providerConnectionState = TapJoyProviderConnectionState.Connecting;
			if (~(_hasHookedUpEvents ? 1u : 0u) != 0)
			{
				TapjoyConnectEvent tapjoyConnectEvent = default;
				tapjoyConnectEvent._002Ector(this, (nint)__ldftn(TapJoyVideoProvider.InitializeFinished));
				TapJoy.onInitializeFinished += tapjoyConnectEvent;
				TapjoyGetFullScreenAdResponseEvent tapjoyGetFullScreenAdResponseEvent = default;
				tapjoyGetFullScreenAdResponseEvent._002Ector(this, (nint)__ldftn(TapJoyVideoProvider.FullScreenAdResponse));
				TapJoy.onFullScreenAdResponse += tapjoyGetFullScreenAdResponseEvent;
				TapjoyViewDidAppearEvent tapjoyViewDidAppearEvent = default;
				tapjoyViewDidAppearEvent._002Ector(this, (nint)__ldftn(TapJoyVideoProvider.ViewAppeared));
				TapJoy.onViewDidAppear += tapjoyViewDidAppearEvent;
				TapjoyViewDidDisappearEvent tapjoyViewDidDisappearEvent = default;
				tapjoyViewDidDisappearEvent._002Ector(this, (nint)__ldftn(TapJoyVideoProvider.ViewDisappeared));
				TapJoy.onViewDidDisappear += tapjoyViewDidDisappearEvent;
				TapjoyViewWillAppearEvent tapjoyViewWillAppearEvent = default;
				tapjoyViewWillAppearEvent._002Ector(this, (nint)__ldftn(TapJoyVideoProvider.ViewWillAppear));
				TapJoy.onViewWillAppear += tapjoyViewWillAppearEvent;
				TapjoyViewWillDisappearEvent tapjoyViewWillDisappearEvent = default;
				tapjoyViewWillDisappearEvent._002Ector(this, (nint)__ldftn(TapJoyVideoProvider.ViewWillDisappear));
				TapJoy.onViewWillDisappear += tapjoyViewWillDisappearEvent;
				TapjoyVideoStartEvent tapjoyVideoStartEvent = default;
				tapjoyVideoStartEvent._002Ector(this, (nint)__ldftn(TapJoyVideoProvider.VideoStarted));
				TapJoy.onVideoStart += tapjoyVideoStartEvent;
				TapjoyVideoErrorEvent tapjoyVideoErrorEvent = default;
				tapjoyVideoErrorEvent._002Ector(this, (nint)__ldftn(TapJoyVideoProvider.VideoError));
				TapJoy.onVideoError += tapjoyVideoErrorEvent;
				TapjoyVideoCompleteEvent tapjoyVideoCompleteEvent = default;
				tapjoyVideoCompleteEvent._002Ector(this, (nint)__ldftn(TapJoyVideoProvider.VideoCompleted));
				TapJoy.onVideoComplete += tapjoyVideoCompleteEvent;
				_hasHookedUpEvents = true;
			}
			if (TapJoy.isInitialized)
			{
				InitializeFinished("success");
				return;
			}
			AdConstants adConstants = AdConstants.instance;
			string tapJoyAppId = adConstants.TapJoyAppId;
			AdConstants adConstants2 = AdConstants.instance;
			string tapJoyAppKey = adConstants2.TapJoyAppKey;
			AdConstants adConstants3 = AdConstants.instance;
			string tapJoyEventName = adConstants3.TapJoyEventName;
			TapJoy.Initialize(tapJoyAppId, tapJoyAppKey, tapJoyEventName);
		}
	}

	public override bool PlayVideoIfAvailable()
	{
		//IL_004f: Expected I, but got Obj
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v3 (Il2CppClass<TapJoyVideoProvider>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		bool flag = obj2 == null;
		bool result = false;
		if (!flag)
		{
			bool flag2 = (byte)(~(_isVideoAvailable ? 1u : 0u)) != 0;
			result = false;
			if (!flag2)
			{
				TapJoy.ShowFullScreenAd();
				_isVideoAvailable = false;
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
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<TapJoyVideoProvider>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 != null && !_isCheckAvailabilityCoroutineRunning)
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

	private void OnVideoCachingFailed()
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

	private void InitializeFinished(string result)
	{
		//IL_0015: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		if (result == "success")
		{
			_providerConnectionState = TapJoyProviderConnectionState.Connected;
			nint num = (nint)this;
			object obj = this + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v8 (Il2CppClass<TapJoyVideoProvider>)+144] (should have been resolved before IL gen)");
		}
		else
		{
			_providerConnectionState = TapJoyProviderConnectionState.Disconnected;
			OnVideoCachingFailed();
		}
	}

	private void FullScreenAdResponse(string result)
	{
		if (result == "success")
		{
			OnVideoCachingSucceded();
			_isVideoAvailable = true;
		}
		else
		{
			_isVideoAvailable = false;
			OnVideoCachingFailed();
		}
	}

	private void ViewAppeared(string viewType)
	{
		//IL_0021: Expected Obj, but got I
		_videoCompleted = false;
		if (_onTakeoverBegan != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void ViewDisappeared(string viewType)
	{
		//IL_0021: Expected Obj, but got I
		//IL_006b: Expected Obj, but got I
		if (_onTakeoverEnded != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v9 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S3_v10+4] (should have been resolved before IL gen)");
		}
		if (~(_videoCompleted ? 1u : 0u) == 0)
		{
			if (_onVideoWatched != null)
			{
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S3_v5 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S3_v6+4] (should have been resolved before IL gen)");
			}
			_videoCompleted = false;
		}
	}

	private void ViewWillAppear(string viewType)
	{
	}

	private void ViewWillDisappear(string viewType)
	{
	}

	private void VideoStarted()
	{
	}

	private void VideoError(string error)
	{
	}

	private void VideoCompleted()
	{
		_videoCompleted = true;
		_isVideoAvailable = false;
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
			TapJoyVideoProvider tapJoyVideoProvider = instance;
			nint num6 = (nint)tapJoyVideoProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S1_v17 (Il2CppClass<TapJoyVideoProvider>)+F4] (should have been resolved before IL gen)");
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
