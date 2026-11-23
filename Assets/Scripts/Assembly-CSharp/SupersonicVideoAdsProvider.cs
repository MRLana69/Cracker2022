using System;
using System.Collections;
using System.Collections.Generic;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using Kiloo.Plugins.Supersonic;
using UnityEngine;

public class SupersonicVideoAdsProvider : VideoAdProvider
{
	private sealed class _003CCheckVideoAvailability_003Ed__44(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SupersonicVideoAdsProvider _003C_003E4__this;

		private int _003CmaxRetries_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			SupersonicVideoAdsProvider supersonicVideoAdsProvider = _003C_003E4__this;
			bool flag;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0113;
				}
				_003C_003E1__state = -1;
				if (supersonicVideoAdsProvider.ProviderHasAdAvailable())
				{
					goto IL_0154;
				}
				flag = ++_003Ci_003E5__3 < _003CmaxRetries_003E5__2;
			}
			else
			{
				_003C_003E1__state = -1;
				supersonicVideoAdsProvider._isCheckAvailabilityCoroutineRunning = true;
				if (supersonicVideoAdsProvider.ProviderHasAdAvailable())
				{
					goto IL_0154;
				}
				OnlineSettings instance = OnlineSettings.instance;
				int value = instance.GetValue("supersonic_video_caching_timelimit", SUPERSONIC_DEFAULT_CACHING_TIMELIMIT);
				_003Ci_003E5__3 = 0;
				_003CmaxRetries_003E5__2 = value;
				flag = value > 0;
			}
			if (!flag)
			{
				supersonicVideoAdsProvider.OnVideoCachingTimedOut();
				goto IL_0113;
			}
			IEnumerator coroutine = CoroutineUtil.WaitForRealSeconds(1f);
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			_003C_003E2__current = coroutine2;
			_003C_003E1__state = 1;
			return true;
			IL_0154:
			supersonicVideoAdsProvider.OnVideoCachingSuccess((string)(object)this);
			return false;
			IL_0113:
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

	private bool _isBaseInitialized;

	private bool _videoWatched;

	private int _priority;

	private int _weight;

	private const string REWARDEDVIDEO_LOCATION = "DefaultRewardedVideo";

	private const string PROVIDER_SUPERSONIC_PRIORITY = "supersonic_video_priority";

	private const int SUPERSONIC_DEFAULT_PRIORITY = 3;

	private const int SUPERSONIC_DEFAULT_WEIGHT = 50;

	private IEnumerator _checkVideoCoroutine;

	private bool _isCheckAvailabilityCoroutineRunning;

	private bool _isInitializingVideos;

	private const string PROVIDER_SUPERSONIC_CACHING_TIMELIMIT = "supersonic_video_caching_timelimit";

	private static readonly int SUPERSONIC_DEFAULT_CACHING_TIMELIMIT = 10;

	private const int MINIMUM_SUPPORTED_ANDROID_API = 17;

	private static SupersonicVideoAdsProvider _instance;

	private bool _isRewardedVideosInitialized;

	private bool _hasCachedVideo;

	public static SupersonicVideoAdsProvider instance
	{
		get
		{
			bool flag = _instance == null;
			bool flag2 = !flag;
			SupersonicVideoAdsProvider result = _instance;
			if (!flag2)
			{
				SupersonicVideoAdsProvider supersonicVideoAdsProvider = default;
				supersonicVideoAdsProvider._002Ector();
				_instance = supersonicVideoAdsProvider;
				result = supersonicVideoAdsProvider;
			}
			return result;
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

	public override bool isInitialized
	{
		get
		{
			if (~(_isBaseInitialized ? 1u : 0u) != 0)
			{
				return false;
			}
			return _isRewardedVideosInitialized;
		}
	}

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

	private unsafe SupersonicVideoAdsProvider()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Ref, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Ref, but got Unknown
		VideoAdProvider.SetVideoProviderData("supersonic_video_priority", 3, 50, ref *(int*)(this + 36), ref *(int*)(this + 40));
	}

	public unsafe override void Init()
	{
		if (~(_isBaseInitialized ? 1u : 0u) != 0)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(SupersonicVideoAdsProvider.OnRewardedVideoInitSuccess));
			Supersonic.onRewardedVideoInitSuccess += action;
			throw new ArgumentException();
		}
		if (~(_isRewardedVideosInitialized ? 1u : 0u) != 0)
		{
			InitRewardedVideo();
		}
	}

	private void InitRewardedVideo()
	{
		//IL_0054: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I4
		if (~(_isInitializingVideos ? 1u : 0u) == 0)
		{
			return;
		}
		_isInitializingVideos = true;
		string text = DeviceUtility.GetDeviceIdentifier();
		RuntimePlatform platform = Application.platform;
		object obj = platform - 8;
		string userId;
		string androidAdvertisingID;
		object obj2;
		if (platform != RuntimePlatform.IPhonePlayer)
		{
			bool flag = (nint)obj == 1;
			userId = text;
			if (!flag)
			{
				bool flag2 = (nint)obj == 2;
				userId = text;
				if (!flag2)
				{
					if ((nint)obj == 3)
					{
						androidAdvertisingID = DeviceUtility.GetAndroidAdvertisingID();
						if (androidAdvertisingID != null)
						{
							obj2 = 0;
							if (androidAdvertisingID._stringLength != 0)
							{
								goto IL_0182;
							}
						}
						obj2 = 1;
						goto IL_0182;
					}
					userId = text;
				}
			}
		}
		else
		{
			Supersonic.ShouldTrackNetworkState(shouldTrack: true);
			userId = text;
		}
		goto IL_015a;
		IL_0182:
		if (obj2 == null)
		{
			text = androidAdvertisingID;
		}
		userId = text;
		goto IL_015a;
		IL_015a:
		AdConstants adConstants = AdConstants.instance;
		string supersonicAppId = adConstants.SupersonicAppId;
		Supersonic.InitRewardedVideo(supersonicAppId, userId);
	}

	public override bool PlayVideoIfAvailable()
	{
		_videoWatched = false;
		bool flag = (byte)(~(_isBaseInitialized ? 1u : 0u)) != 0;
		bool result = false;
		if (!flag)
		{
			bool flag2 = ProviderHasAdAvailable();
			bool flag3 = !flag2;
			result = false;
			if (!flag3)
			{
				Supersonic.ShowRewardedVideo("DefaultRewardedVideo");
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

	private bool ProviderHasAdAvailable()
	{
		if (~(_isRewardedVideosInitialized ? 1u : 0u) != 0)
		{
			return false;
		}
		return Supersonic.IsRewardedVideoAvailable();
	}

	public override void OnPause()
	{
	}

	public override void OnResume()
	{
	}

	private void OnVideoAvailabilityChanged(bool obj)
	{
		//IL_004b: Expected Obj, but got I
		if (~(_hasCachedVideo ? 1u : 0u) == 0)
		{
			_hasCachedVideo = false;
			if (_onVideoUnavailable != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S4_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S4_v4+4] (should have been resolved before IL gen)");
			}
		}
	}

	private void OnVideoStart()
	{
	}

	private void OnVideoEnd()
	{
	}

	private void OnRewardedVideoInitSuccess()
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			Supersonic.ShouldTrackNetworkState(shouldTrack: true);
		}
		_isInitializingVideos = false;
	}

	private void OnRewardedVideoInitFail(string obj)
	{
		_isInitializingVideos = false;
	}

	private void OnRewardedVideoAdClosed()
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

	private void OnRewardedVideoAdOpened()
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

	private void OnRewardedVideoShowFail(string obj)
	{
		//IL_0021: Expected Obj, but got I
		if (_onVideoUnavailable != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S4_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S4_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnRewardedVideoAdRewarded(string obj)
	{
		_videoWatched = true;
	}

	private void OnVideoCachingSuccess(string location)
	{
		//IL_0021: Expected Obj, but got I
		_hasCachedVideo = true;
		StopCheckVideoAvailabilityCouroutine();
		if (_onVideoAvailable != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnVideoCachingTimedOut()
	{
		//IL_0021: Expected Obj, but got I
		StopCheckVideoAvailabilityCouroutine();
		if (_onCachingTimedOut != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S3_v4+4] (should have been resolved before IL gen)");
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

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "SupersonicVideoProvider: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
