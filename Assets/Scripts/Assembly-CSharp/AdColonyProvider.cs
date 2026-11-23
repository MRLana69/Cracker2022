using System;
using System.Collections;
using System.Collections.Generic;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Plugins.AdColony;
using UnityEngine;

public class AdColonyProvider : VideoAdProvider
{
	private sealed class _003CCheckVideoAvailability_003Ed__38(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AdColonyProvider _003C_003E4__this;

		private int _003CmaxRetries_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			AdColonyProvider adColonyProvider = _003C_003E4__this;
			bool flag;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0155;
				}
				_003C_003E1__state = -1;
				if (AdColony.IsVideoAvailable())
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
				adColonyProvider._isCheckAvailabilityCoroutineRunning = true;
				if (AdColony.IsVideoAvailable())
				{
					_003C_003E4__this.OnVideoCachingSucceded();
					return false;
				}
				OnlineSettings instance = OnlineSettings.instance;
				int value = instance.GetValue("adcolony_video_caching_timelimit", ADCOLONY_DEFAULT_CACHING_TIMELIMIT);
				_003Ci_003E5__3 = 0;
				_003CmaxRetries_003E5__2 = value;
				flag = value > 0;
			}
			if (!flag)
			{
				_003C_003E4__this.OnVideoCachingTimedOut();
				goto IL_0155;
			}
			IEnumerator coroutine = CoroutineUtil.WaitForRealSeconds(1f);
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			_003C_003E2__current = coroutine2;
			_003C_003E1__state = 1;
			return true;
			IL_0155:
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

	private const string PROVIDER_ADCOLONY_PRIORITY = "adcolony_video_priority";

	private static readonly int ADCOLONY_DEFAULT_PRIORITY = 1;

	private static readonly int ADCOLONY_DEFAULT_WEIGHT = 10;

	private IEnumerator _checkVideoCoroutine;

	private bool _isCheckAvailabilityCoroutineRunning;

	private const string PROVIDER_ADCOLONY_CACHING_TIMELIMIT = "adcolony_video_caching_timelimit";

	private static readonly int ADCOLONY_DEFAULT_CACHING_TIMELIMIT = 10;

	private static AdColonyProvider _instance;

	private bool _isInitialized;

	private float _cachingStartTime = float.MinValue;

	private float _appMinimizedTime;

	private float _appResumedTime;

	private float _amountOfTimePaused;

	private string _id;

	private int _priority;

	private int _weight;

	public static AdColonyProvider instance
	{
		get
		{
			if (_instance == null)
			{
				AdColonyProvider adColonyProvider = default;
				adColonyProvider._002Ector();
				_instance = adColonyProvider;
			}
			return _instance;
		}
	}

	public static bool isVideoProviderSupported
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
			string adColonyAppId = adConstants.AdColonyAppId;
			object obj;
			if (adColonyAppId != null)
			{
				obj = 0;
				if (adColonyAppId._stringLength != 0)
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
			string adColonyZoneId = adConstants2.AdColonyZoneId;
			if (adColonyZoneId != null)
			{
				obj4 = 0;
				if (adColonyZoneId._stringLength != 0)
				{
					goto IL_010b;
				}
			}
			obj4 = 1;
			goto IL_010b;
		}
	}

	public override bool allowedWhenAgeRestricted => true;

	public override bool isInitialized => _isInitialized;

	public override bool IsStopped => false;

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

	private unsafe AdColonyProvider()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Ref, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Ref, but got Unknown
		VideoAdProvider.SetVideoProviderData("adcolony_video_priority", ADCOLONY_DEFAULT_PRIORITY, ADCOLONY_DEFAULT_WEIGHT, ref *(int*)(this + 60), ref *(int*)(this - -64));
	}

	public unsafe override void Init()
	{
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(AdColonyProvider.OnVideoFinished));
			AdColony.onAdAttemptFinished += action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(AdColonyProvider.OnVideoStarted));
			AdColony.onAdStarted += action2;
			throw new ArgumentException();
		}
	}

	public override void StartCachingVideo()
	{
		AdConstants adConstants = AdConstants.instance;
		string adColonyZoneId = adConstants.AdColonyZoneId;
		AdColony.LoadVideoAd(adColonyZoneId);
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

	public override bool PlayVideoIfAvailable()
	{
		bool flag = AdColony.IsVideoAvailable();
		if (flag)
		{
			AdColony.PlayVideoAd();
		}
		return flag;
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

	private bool ProviderHasAdAvailable()
	{
		return AdColony.IsVideoAvailable();
	}

	public void OnVideoCachingSucceded()
	{
		//IL_0021: Expected Obj, but got I
		CoroutineUtil.StopCoroutine(_checkVideoCoroutine);
		_isCheckAvailabilityCoroutineRunning = false;
		CalculateAndReportCachingTime("Success");
		if (_onVideoAvailable != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	public void OnVideoCachingFailed()
	{
		//IL_0021: Expected Obj, but got I
		CoroutineUtil.StopCoroutine(_checkVideoCoroutine);
		_isCheckAvailabilityCoroutineRunning = false;
		CalculateAndReportCachingTime("Failed");
		if (_onVideoUnavailable != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S4_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S4_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnVideoCachingTimedOut()
	{
		//IL_0021: Expected Obj, but got I
		_amountOfTimePaused = 0f;
		_cachingStartTime = float.MinValue;
		_isCheckAvailabilityCoroutineRunning = false;
		if (_onCachingTimedOut != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnVideoStarted()
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

	private void OnVideoFinished()
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

	private void OnV4VCWatched(bool success)
	{
		//IL_0040: Expected Obj, but got I
		if (success && _onVideoWatched != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnInitFinished()
	{
		//IL_0010: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		_isInitialized = true;
		nint num = (nint)this;
		object obj = this + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v3 (Il2CppClass<AdColonyProvider>)+144] (should have been resolved before IL gen)");
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
			AdColonyProvider adColonyProvider = instance;
			nint num6 = (nint)adColonyProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S1_v17 (Il2CppClass<AdColonyProvider>)+F4] (should have been resolved before IL gen)");
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
