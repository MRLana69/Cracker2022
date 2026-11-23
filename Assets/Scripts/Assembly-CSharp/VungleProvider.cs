using System;
using System.Collections;
using System.Collections.Generic;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Plugins.Vungle;
using Kiloo.Plugins.Vungle.Internal;
using UnityEngine;

public class VungleProvider : VideoAdProvider
{
	private sealed class _003CCheckVideoAvailability_003Ed__36(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public VungleProvider _003C_003E4__this;

		private int _003CmaxRetries_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			VungleProvider vungleProvider = _003C_003E4__this;
			bool flag;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_013f;
				}
				_003C_003E1__state = -1;
				if (Vungle.IsCachedAdAvailable())
				{
					vungleProvider.OnVideoCachingSucceded();
					return false;
				}
				flag = ++_003Ci_003E5__3 < _003CmaxRetries_003E5__2;
			}
			else
			{
				_003C_003E1__state = -1;
				vungleProvider._isCheckAvailabilityCoroutineRunning = true;
				if (Vungle.IsCachedAdAvailable())
				{
					vungleProvider.OnVideoCachingSucceded();
					return false;
				}
				OnlineSettings instance = OnlineSettings.instance;
				int value = instance.GetValue("vungle_video_caching_timelimit", VUNGLE_DEFAULT_CACHING_TIMELIMIT);
				_003Ci_003E5__3 = 0;
				_003CmaxRetries_003E5__2 = value;
				flag = value > 0;
			}
			if (!flag)
			{
				vungleProvider.OnVideoCachingTimedOut();
				goto IL_013f;
			}
			IEnumerator coroutine = CoroutineUtil.WaitForRealSeconds(1f);
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			_003C_003E2__current = coroutine2;
			_003C_003E1__state = 1;
			return true;
			IL_013f:
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

	private bool _hasSubscribedToEvents;

	private const bool _isStopped = false;

	private const string PROVIDER_VUNGLE_PRIORITY = "vungle_video_priority";

	private const int VUNGLE_DEFAULT_PRIORITY = 5;

	private const int VUNGLE_DEFAULT_WEIGHT = 50;

	private IEnumerator _checkVideoCoroutine;

	private bool _isCheckAvailabilityCoroutineRunning;

	private const string PROVIDER_VUNGLE_CACHING_TIMELIMIT = "vungle_video_caching_timelimit";

	private static readonly int VUNGLE_DEFAULT_CACHING_TIMELIMIT = 10;

	private static VungleProvider _instance;

	private int _priority;

	private int _weight;

	public static VungleProvider instance
	{
		get
		{
			if (_instance == null)
			{
				VungleProvider vungleProvider = default;
				vungleProvider._002Ector();
				_instance = vungleProvider;
			}
			return _instance;
		}
	}

	public static bool isVideoProviderSupported
	{
		get
		{
			//IL_0084: Expected Obj, but got I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected I4, but got Unknown
			//IL_0068: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A50");
			object obj = default;
			object obj2;
			if (obj != null)
			{
				AdConstants adConstants = AdConstants.instance;
				string vungleAppId = adConstants.VungleAppId;
				if (vungleAppId != null)
				{
					obj2 = 0;
					if (vungleAppId._stringLength != 0)
					{
						goto IL_0097;
					}
				}
				obj2 = 1;
				goto IL_0097;
			}
			return false;
			IL_0097:
			return (byte)(obj2 ^ 1) != 0;
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

	private unsafe VungleProvider()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Ref, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Ref, but got Unknown
		VideoAdProvider.SetVideoProviderData("vungle_video_priority", 5, 50, ref *(int*)(this + 44), ref *(int*)(this + 48));
	}

	public unsafe override void Init()
	{
		if (~(_hasSubscribedToEvents ? 1u : 0u) != 0)
		{
			VungleVideoViewFinishedEvent vungleVideoViewFinishedEvent = default;
			vungleVideoViewFinishedEvent._002Ector(this, (nint)__ldftn(VungleProvider.OnVideoViewFinished));
			Vungle.onVideoViewFinished += vungleVideoViewFinishedEvent;
			VungleAdStartEvent vungleAdStartEvent = default;
			vungleAdStartEvent._002Ector(this, (nint)__ldftn(VungleProvider.OnAdStart));
			Vungle.onAdStart += vungleAdStartEvent;
			VungleAdUnavailableEvent vungleAdUnavailableEvent = default;
			vungleAdUnavailableEvent._002Ector(this, (nint)__ldftn(VungleProvider.OnAdUnavailable));
			Vungle.onAdUnavailable += vungleAdUnavailableEvent;
			VungleCachedAdAvailableEvent vungleCachedAdAvailableEvent = default;
			vungleCachedAdAvailableEvent._002Ector(this, (nint)__ldftn(VungleProvider.OnCachedAdAvailable));
			Vungle.onCachedAdAvailable += vungleCachedAdAvailableEvent;
			_hasSubscribedToEvents = true;
		}
		if (!_initialized && isVideoProviderSupported)
		{
			AdConstants adConstants = AdConstants.instance;
			string vungleAppId = adConstants.VungleAppId;
			bool initialized = Vungle.InitVungle(vungleAppId);
			_initialized = initialized;
		}
	}

	public override void StartCachingVideo()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			OnVideoCachingFailed();
		}
		else if (~(_isCheckAvailabilityCoroutineRunning ? 1u : 0u) != 0)
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

	public void OnVideoCachingSucceded()
	{
		//IL_0021: Expected Obj, but got I
		StopCheckVideoAvailabilityCouroutine();
		if (_onVideoAvailable != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	public void OnVideoCachingFailed()
	{
		//IL_0021: Expected Obj, but got I
		StopCheckVideoAvailabilityCouroutine();
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

	private bool ProviderHasAdAvailable()
	{
		return Vungle.IsCachedAdAvailable();
	}

	public override bool PlayVideoIfAvailable()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<VungleProvider>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		bool flag = obj2 == null;
		bool result = false;
		if (!flag)
		{
			bool flag2 = Vungle.IsCachedAdAvailable();
			bool flag3 = !flag2;
			result = false;
			if (!flag3)
			{
				Dictionary<string, string> videoAdOptions = ((VungleProvider)null).GetVideoAdOptions();
				Vungle.PlayAdWithOptions(videoAdOptions);
				result = true;
			}
		}
		return result;
	}

	private unsafe Dictionary<string, string> GetVideoAdOptions()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected I4, but got Unknown
		//IL_0195: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			_ = 1;
			Enum obj3 = (Enum)(obj + 8);
			_ = -1;
			obj3 = (Enum)(object)typeof(VungleAndroid.AndroidOrientationOptions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
			_ = 0;
			string text = obj3.ToString();
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S5_v19 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S5_v20+4] (should have been resolved before IL gen)");
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S5_v24 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ S5_v25+4] (should have been resolved before IL gen)");
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S5_v29 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S5_v30+4] (should have been resolved before IL gen)");
		}
		else
		{
			RuntimePlatform platform2 = Application.platform;
			if (platform2 == RuntimePlatform.IPhonePlayer)
			{
				nint num9 = 0;
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ S5_v5+4] (should have been resolved before IL gen)");
				nint num11 = 0;
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v178 @ S5_v10+4] (should have been resolved before IL gen)");
				_ = 4;
				int num13 = obj + 24;
				string text2 = ((int*)num13)->ToString();
				string text3 = string.Empty + text2;
				nint num14 = 0;
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S5_v14 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ S5_v15+4] (should have been resolved before IL gen)");
			}
		}
		Dictionary<string, string> result = default;
		return result;
	}

	public override void StopProvider()
	{
	}

	public override void ResumeProvider()
	{
	}

	public override void OnPause()
	{
		Vungle.OnPause();
	}

	public override void OnResume()
	{
		Vungle.OnResume();
	}

	private unsafe void OnVideoViewFinished(string isCompletedView)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Ref, but got Unknown
		//IL_002f: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_onTakeoverEnded != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S3_v8 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S3_v9+4] (should have been resolved before IL gen)");
		}
		bool flag = bool.TryParse(isCompletedView, out *(bool*)(obj + 15));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		if ((nint)0 != 0 && _onVideoWatched != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S3_v4 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S3_v5+4] (should have been resolved before IL gen)");
		}
	}

	private void OnAdStart()
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

	private void OnCachedAdAvailable()
	{
		//IL_0021: Expected Obj, but got I
		OnVideoCachingSucceded();
		if (_onVideoAvailable != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	private void OnAdUnavailable(string result)
	{
		//IL_0021: Expected Obj, but got I
		OnVideoCachingFailed();
		if (_onVideoUnavailable != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S4_v3 (Il2CppMethodRgctx<VideoAdProvider::InvokeHandlerIfNotNull>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S4_v4+4] (should have been resolved before IL gen)");
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "VungleProvider: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
