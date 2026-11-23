using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

public class VideoAdsManager
{
	public delegate void OnVideoCacherDelegate();

	public enum VideoState
	{
		Offline,
		Downloading,
		Ready,
		NoVideos
	}

	public enum State
	{
		Uninitialized,
		Initialized,
		TakeoverActive
	}

	private sealed class _003CFakeOnProviderVideoWatched_003Ed__76(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public VideoAdsManager _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0052: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					_003C_003E4__this.OnProviderVideoWatched((VideoAdProvider)(object)this);
				}
				return false;
			}
			_003C_003E1__state = -1;
			_003C_003E1__state = 1;
			return true;
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

	private const int MAX_PROVIDERS_TO_INIT_PER_CALL = 1;

	private const int NUMBER_OF_PROVIDERS_ALLOWERD_ON_LOW_END_DEVICES = 1;

	private const int DEFAULT_NUMBER_OF_KEYS_TO_REWARD_FOR_VIDEO_AD = 2;

	private int _numberOfKeysToRewardForVideo = 2;

	private const string ONLINESETTINGS_PROVIDERLIST_KEY = "videoads_providerlist";

	private const string ONLINE_SETTING_KEYS_REWARDED_FOR_VIDEO = "keys_rewarded_for_video_ad";

	private const string PROVIDER_ADCOLONY = "adcolony";

	private const string PROVIDER_FLURRYVIDEOADS = "flurryvideoads";

	private const string PROVIDER_VUNGLECLIPS = "vungleclips";

	private const string PROVIDER_TAPJOYVIDEOADS = "tapjoyvideoads";

	private const string PROVIDER_INMOBIVIDEOADS = "inmobivideoads";

	private const string PROVIDER_CHARTBOOSTVIDEOADS = "chartboostvideoads";

	private const string PROVIDER_SUPERSONICVIDEOADS = "supersonicvideoads";

	private static readonly string[] DEFAULT_PROVIDER_LIST;

	private VideoAdProvider currentProvider;

	private VideoAdProvider lastShownProvider;

	private List<VideoAdProvider> currentListOfProviders;

	private int currentProviderIndex = -1;

	private VideoAdProvider _adColonyProvider;

	private VideoAdProvider _flurryVideoAdsProvider;

	private VideoAdProvider _vungleVideoAdsProvider;

	private VideoAdProvider _tapjoyVideoAdProvider;

	private VideoAdProvider _inmobiVideoAdsProvider;

	private VideoAdProvider _chartboostVideoAdProvider;

	private VideoAdProvider _supersonicVideoAdProvider;

	private bool _isVideoPlaying;

	private Action _onVideoStateChangedHandler;

	private Action _onKeyVideoWatchedChangedHandler;

	private Action _onVideoProviderChangedHandler;

	private static VideoAdsManager _instance;

	private Action _rewardOverride;

	private bool _gameSfxOnBeforeMute;

	private bool _gameMusicOnBeforeMute;

	private VideoState currentVideoState__BackingField = VideoState.Offline;

	private State state__BackingField;

	private OnVideoCacherDelegate m_OnVideoCached;

	private Action<VideoAdProvider> m_OnTakeoverEnded;

	public VideoState currentVideoState
	{
		get
		{
			return currentVideoState__BackingField;
		}
		private set
		{
			currentVideoState__BackingField = value;
		}
	}

	public State state
	{
		get
		{
			return state__BackingField;
		}
		private set
		{
			state__BackingField = value;
		}
	}

	public bool isVideoPlaying => _isVideoPlaying;

	public static VideoAdsManager instance
	{
		get
		{
			if (_instance == null)
			{
				VideoAdsManager videoAdsManager = default;
				videoAdsManager.currentProviderIndex = -1;
				videoAdsManager._numberOfKeysToRewardForVideo = 2;
				videoAdsManager.currentVideoState__BackingField = VideoState.Offline;
				_instance = videoAdsManager;
			}
			return _instance;
		}
	}

	public bool isInitialized => state__BackingField != State.Uninitialized;

	public bool IsStopped => false;

	public event OnVideoCacherDelegate OnVideoCached
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 88;
			Delegate obj2 = this.m_OnVideoCached;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 88;
			Delegate obj2 = this.m_OnVideoCached;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<VideoAdProvider> OnTakeoverEnded
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 92;
			Delegate obj2 = this.m_OnTakeoverEnded;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 92;
			Delegate obj2 = this.m_OnTakeoverEnded;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	private VideoAdsManager()
	{
	}

	public VideoAdProvider GetCurrentProvider()
	{
		return currentProvider;
	}

	public VideoAdProvider GetLastShownProvider()
	{
		return lastShownProvider;
	}

	public void AddOnVideoStateChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Combine(_onVideoStateChangedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onVideoStateChangedHandler = default;
		_onVideoStateChangedHandler = onVideoStateChangedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void RemoveOnVideoStateChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Remove(_onVideoStateChangedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onVideoStateChangedHandler = default;
		_onVideoStateChangedHandler = onVideoStateChangedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void AddOnKeyVideoWatchedChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Combine(_onKeyVideoWatchedChangedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onKeyVideoWatchedChangedHandler = default;
		_onKeyVideoWatchedChangedHandler = onKeyVideoWatchedChangedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void RemoveOnKeyVideoWatchedChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Remove(_onKeyVideoWatchedChangedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onKeyVideoWatchedChangedHandler = default;
		_onKeyVideoWatchedChangedHandler = onKeyVideoWatchedChangedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void AddOnVideoProviderChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Combine(_onVideoProviderChangedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onVideoProviderChangedHandler = default;
		_onVideoProviderChangedHandler = onVideoProviderChangedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void RemoveOnVideoProviderChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Remove(_onVideoProviderChangedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onVideoProviderChangedHandler = default;
		_onVideoProviderChangedHandler = onVideoProviderChangedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void Init()
	{
		if (state__BackingField == State.Uninitialized)
		{
			RefreshListProviders();
			state__BackingField = State.Initialized;
		}
	}

	public void StartCachingVideo()
	{
		//IL_00c8: Expected I, but got Obj
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		if (state__BackingField == State.Uninitialized)
		{
			return;
		}
		ResumeProvider();
		if (currentProvider != null && currentVideoState__BackingField != VideoState.Downloading)
		{
			currentVideoState__BackingField = VideoState.Downloading;
			Action onVideoStateChangedHandler = _onVideoStateChangedHandler;
			bool flag = _onVideoStateChangedHandler == null;
			VideoAdProvider videoAdProvider = currentProvider;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				videoAdProvider = currentProvider;
			}
			nint num = (nint)videoAdProvider;
			object obj = videoAdProvider + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S1_v8 (Il2CppClass<VideoAdProvider>)+144] (should have been resolved before IL gen)");
		}
	}

	private void OnVideoCachingSucceded(VideoAdProvider provider)
	{
		//IL_0223: Expected I, but got Obj
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0037: Expected I, but got Obj
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_00a8: Expected I, but got Obj
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00fe: Expected I, but got Obj
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0128: Expected I, but got Obj
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		bool flag = currentProvider == null;
		string text = string.Empty;
		if (!flag)
		{
			nint num = (nint)provider;
			object obj = provider + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v32 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
			VideoAdProvider videoAdProvider = currentProvider;
			nint num2 = (nint)videoAdProvider;
			object obj2 = videoAdProvider + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v29 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
			string text2 = default;
			string text3 = default;
			bool flag2 = text2 == text3;
			string text4 = "Notcurrent";
			if (flag2)
			{
				text4 = string.Empty;
			}
			text = text4;
		}
		nint num3 = (nint)provider;
		object obj3 = provider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S1_v4 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
		string text6 = default;
		string text5 = text6 + " Result";
		string text7 = "Success" + text;
		string locale = DeviceUtility.GetLocale();
		string contryCodeFromLocale = Utils.GetContryCodeFromLocale(locale);
		nint num4 = (nint)provider;
		object obj4 = provider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ S1_v12 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
		string text9 = default;
		string text8 = text9 + "Success Country";
		if (currentProvider == null)
		{
			return;
		}
		nint num5 = (nint)provider;
		object obj5 = provider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v121 @ S1_v19 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
		VideoAdProvider videoAdProvider2 = currentProvider;
		nint num6 = (nint)videoAdProvider2;
		object obj6 = videoAdProvider2 + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v133 @ S2_v16 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
		string text10 = default;
		string text11 = default;
		if (text10 == text11)
		{
			currentVideoState__BackingField = VideoState.Ready;
			Action onVideoStateChangedHandler = _onVideoStateChangedHandler;
			if (_onVideoStateChangedHandler != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v167.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			OnVideoCacherDelegate onVideoCached = this.m_OnVideoCached;
			if (this.m_OnVideoCached != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v177.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnVideoCachingFailed(VideoAdProvider provider, string extraInfo)
	{
		//IL_0221: Expected I, but got Obj
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0037: Expected I, but got Obj
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0104: Expected I, but got Obj
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_015a: Expected I, but got Obj
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0184: Expected I, but got Obj
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		bool flag = currentProvider == null;
		string text = string.Empty;
		if (!flag)
		{
			nint num = (nint)provider;
			object obj = provider + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v35 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
			VideoAdProvider videoAdProvider = currentProvider;
			nint num2 = (nint)videoAdProvider;
			object obj2 = videoAdProvider + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v28 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
			string text2 = default;
			string text3 = default;
			bool flag2 = text2 == text3;
			string text4 = "Notcurrent";
			if (flag2)
			{
				text4 = string.Empty;
			}
			text = text4;
		}
		bool flag3 = extraInfo == string.Empty;
		nint num3 = (nint)provider;
		object obj3 = provider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S1_v8 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
		string text6 = default;
		if (flag3)
		{
			string text5 = text6 + " Result";
			string text7 = "Failed" + text;
		}
		else
		{
			string text8 = text6 + " Result;Error code";
			string text9 = "Failed;" + extraInfo;
		}
		string locale = DeviceUtility.GetLocale();
		string contryCodeFromLocale = Utils.GetContryCodeFromLocale(locale);
		nint num4 = (nint)provider;
		object obj4 = provider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S1_v14 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
		string text11 = default;
		string text10 = text11 + "Failed Country";
		if (currentProvider != null)
		{
			nint num5 = (nint)provider;
			object obj5 = provider + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ S1_v21 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
			VideoAdProvider videoAdProvider2 = currentProvider;
			nint num6 = (nint)videoAdProvider2;
			object obj6 = videoAdProvider2 + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ S2_v16 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
			string text12 = default;
			string text13 = default;
			if (text12 == text13)
			{
				GoToNextProvider();
			}
		}
	}

	private void OnVideoCachingTimedOut(VideoAdProvider provider)
	{
		//IL_00f0: Expected I, but got Obj
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_001f: Expected I, but got Obj
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0070: Expected I, but got Obj
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_009a: Expected I, but got Obj
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		nint num = (nint)provider;
		object obj = provider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
		string text2 = default;
		string text = text2 + " Result";
		string locale = DeviceUtility.GetLocale();
		string contryCodeFromLocale = Utils.GetContryCodeFromLocale(locale);
		nint num2 = (nint)provider;
		object obj2 = provider + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S1_v10 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
		string text4 = default;
		string text3 = text4 + "Timedout Country";
		if (currentProvider != null)
		{
			nint num3 = (nint)provider;
			object obj3 = provider + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S1_v17 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
			VideoAdProvider videoAdProvider = currentProvider;
			nint num4 = (nint)videoAdProvider;
			object obj4 = videoAdProvider + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ S2_v14 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
			string text5 = default;
			string text6 = default;
			if (text5 == text6)
			{
				GoToNextProvider();
			}
		}
	}

	private void GoToNextProvider()
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0041: Expected I, but got Obj
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0188: Expected I, but got Obj
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_020d: Expected I, but got Obj
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_00c4: Expected I, but got Obj
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_0095: Expected I, but got Obj
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		VideoAdProvider videoAdProvider = currentProvider;
		if (currentProvider != null)
		{
			nint num = (nint)videoAdProvider;
			object obj = videoAdProvider + 120;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v36 (Il2CppClass<VideoAdProvider>)+134] (should have been resolved before IL gen)");
		}
		VideoAdProvider nextProvider = GetNextProvider();
		currentProvider = nextProvider;
		Action onVideoProviderChangedHandler = _onVideoProviderChangedHandler;
		if (_onVideoProviderChangedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		VideoAdProvider videoAdProvider2 = currentProvider;
		if (currentProvider != null)
		{
			nint num2 = (nint)videoAdProvider2;
			object obj2 = videoAdProvider2 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S1_v11 (Il2CppClass<VideoAdProvider>)+DC] (should have been resolved before IL gen)");
			object obj3 = default;
			if (obj3 == null && !AgeRestriction.waitForAgeRestriction)
			{
				VideoAdProvider videoAdProvider3 = currentProvider;
				nint num3 = (nint)videoAdProvider3;
				object obj4 = videoAdProvider3 + 104;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v148 @ S1_v29 (Il2CppClass<VideoAdProvider>)+124] (should have been resolved before IL gen)");
			}
			VideoAdProvider videoAdProvider4 = currentProvider;
			nint num4 = (nint)videoAdProvider4;
			object obj5 = videoAdProvider4 + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S1_v16 (Il2CppClass<VideoAdProvider>)+EC] (should have been resolved before IL gen)");
			object obj6 = default;
			if (obj6 != null)
			{
				VideoAdProvider videoAdProvider5 = currentProvider;
				nint num5 = (nint)videoAdProvider5;
				object obj7 = videoAdProvider5 + 128;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S1_v25 (Il2CppClass<VideoAdProvider>)+13C] (should have been resolved before IL gen)");
			}
			VideoAdProvider videoAdProvider6 = currentProvider;
			nint num6 = (nint)videoAdProvider6;
			object obj8 = videoAdProvider6 + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ S1_v21 (Il2CppClass<VideoAdProvider>)+144] (should have been resolved before IL gen)");
		}
		else
		{
			currentVideoState__BackingField = VideoState.NoVideos;
			Action onVideoStateChangedHandler = _onVideoStateChangedHandler;
			if (_onVideoStateChangedHandler != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v68.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void RefreshListProviders()
	{
		//IL_00da: Expected I, but got Obj
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_012e: Expected I, but got Obj
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		currentProviderIndex = -1;
		string[] providerList = GetProviderList();
		List<VideoAdProvider> sortedListOfProviders = GetSortedListOfProviders(providerList);
		currentListOfProviders = sortedListOfProviders;
		if (currentListOfProviders != null)
		{
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.IPhonePlayer)
			{
				DeviceInfo deviceInfo = DeviceInfo.Instance;
				if (deviceInfo.performanceLevel == DeviceInfo.PerformanceLevel.Low)
				{
					List<VideoAdProvider> list = currentListOfProviders;
					if (list._size >= 2)
					{
						throw new IndexOutOfRangeException();
					}
				}
			}
		}
		VideoAdProvider nextProvider = GetNextProvider();
		currentProvider = nextProvider;
		Action onVideoProviderChangedHandler = _onVideoProviderChangedHandler;
		if (_onVideoProviderChangedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		VideoAdProvider videoAdProvider = currentProvider;
		if (currentProvider != null)
		{
			nint num = (nint)videoAdProvider;
			object obj = videoAdProvider + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ S1_v11 (Il2CppClass<VideoAdProvider>)+DC] (should have been resolved before IL gen)");
			object obj2 = default;
			if (obj2 == null && !AgeRestriction.waitForAgeRestriction)
			{
				VideoAdProvider videoAdProvider2 = currentProvider;
				nint num2 = (nint)videoAdProvider2;
				object obj3 = videoAdProvider2 + 104;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S1_v15 (Il2CppClass<VideoAdProvider>)+124] (should have been resolved before IL gen)");
			}
		}
	}

	public void TryCachingVideosAgain()
	{
		currentVideoState__BackingField = VideoState.NoVideos;
		RefreshListProviders();
		StartCachingVideo();
	}

	public bool PlayVideoIfAvailable(Action rewardOverride = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_0093: Expected I, but got Obj
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00da: Expected I, but got Obj
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_01b6: Expected I, but got Obj
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_0138: Expected I, but got Obj
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0162: Expected I, but got Obj
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_rewardOverride = rewardOverride;
		if (~(Globals.DEBUG_SKIP_VIDEO_ADS ? 1u : 0u) == 0)
		{
			IEnumerator coroutine = FakeOnProviderVideoWatched();
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			return true;
		}
		if (state__BackingField == State.Initialized && currentVideoState__BackingField == VideoState.Ready)
		{
			VideoAdProvider videoAdProvider = currentProvider;
			nint num = (nint)videoAdProvider;
			object obj3 = videoAdProvider + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S1_v31 (Il2CppClass<VideoAdProvider>)+DC] (should have been resolved before IL gen)");
			object obj4 = default;
			if (obj4 != null)
			{
				VideoAdProvider videoAdProvider2 = currentProvider;
				nint num2 = (nint)videoAdProvider2;
				object obj5 = videoAdProvider2 + 112;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v148 @ S1_v35 (Il2CppClass<VideoAdProvider>)+12C] (should have been resolved before IL gen)");
				object obj6 = default;
				if (obj6 != null)
				{
					lastShownProvider = currentProvider;
					_isVideoPlaying = true;
					VideoAdProvider videoAdProvider3 = currentProvider;
					nint num3 = (nint)videoAdProvider3;
					object obj7 = videoAdProvider3 + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v192 @ S1_v50 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
					VideoAdProvider videoAdProvider4 = currentProvider;
					nint num4 = (nint)videoAdProvider4;
					object obj8 = videoAdProvider4 + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ S1_v54 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
					string text2 = default;
					string text = "VideoAds " + text2 + " request";
					return true;
				}
				VideoAdProvider videoAdProvider5 = currentProvider;
				nint num5 = (nint)videoAdProvider5;
				object obj9 = videoAdProvider5 + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v205 @ S1_v39 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
				string text4 = default;
				string text3 = "VideoAds " + text4 + " request";
				currentVideoState__BackingField = VideoState.NoVideos;
				Action onVideoStateChangedHandler = _onVideoStateChangedHandler;
				if (_onVideoStateChangedHandler != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v262.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
		else
		{
			_ = state__BackingField;
			Enum obj10 = (Enum)(obj + 24);
			_ = -1;
			obj10 = (Enum)(object)typeof(State);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			_ = 0;
			string text5 = obj10.ToString();
			_ = currentVideoState__BackingField;
			Enum obj11 = (Enum)(obj + 8);
			_ = -1;
			obj11 = (Enum)(object)typeof(VideoState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			string text6 = obj11.ToString();
			string text7 = "VideoAdsManager: Not ready to play (state is " + text5 + ") and CurrentVideoState is " + text6;
			if (state__BackingField == State.TakeoverActive)
			{
				state__BackingField = State.Initialized;
			}
		}
		return false;
	}

	private IEnumerator FakeOnProviderVideoWatched()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void StopProvider()
	{
		//IL_0031: Expected I, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0078: Expected I, but got Obj
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		VideoAdProvider videoAdProvider = currentProvider;
		if (currentProvider != null)
		{
			nint num = (nint)videoAdProvider;
			object obj = videoAdProvider + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<VideoAdProvider>)+DC] (should have been resolved before IL gen)");
			object obj2 = default;
			if (obj2 != null)
			{
				VideoAdProvider videoAdProvider2 = currentProvider;
				nint num2 = (nint)videoAdProvider2;
				object obj3 = videoAdProvider2 + 120;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S1_v7 (Il2CppClass<VideoAdProvider>)+134] (should have been resolved before IL gen)");
			}
		}
	}

	public void ResumeProvider()
	{
		//IL_0031: Expected I, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0078: Expected I, but got Obj
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00bf: Expected I, but got Obj
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		VideoAdProvider videoAdProvider = currentProvider;
		if (currentProvider == null)
		{
			return;
		}
		nint num = (nint)videoAdProvider;
		object obj = videoAdProvider + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<VideoAdProvider>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 != null)
		{
			VideoAdProvider videoAdProvider2 = currentProvider;
			nint num2 = (nint)videoAdProvider2;
			object obj3 = videoAdProvider2 + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S1_v7 (Il2CppClass<VideoAdProvider>)+EC] (should have been resolved before IL gen)");
			object obj4 = default;
			if (obj4 != null)
			{
				VideoAdProvider videoAdProvider3 = currentProvider;
				nint num3 = (nint)videoAdProvider3;
				object obj5 = videoAdProvider3 + 128;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S1_v11 (Il2CppClass<VideoAdProvider>)+13C] (should have been resolved before IL gen)");
			}
		}
	}

	private VideoAdProvider GetNextProvider()
	{
		//IL_0015: Expected Obj, but got I4
		List<VideoAdProvider> list = currentListOfProviders;
		if (currentListOfProviders != null)
		{
			object obj = currentProviderIndex + 1;
			if (list._size > (nint)obj)
			{
				int index = ++currentProviderIndex;
				return currentListOfProviders.get_Item(index);
			}
			string locale = DeviceUtility.GetLocale();
			string contryCodeFromLocale = Utils.GetContryCodeFromLocale(locale);
			currentProviderIndex = -1;
		}
		return null;
	}

	private List<VideoAdProvider> GetSortedListOfProviders(string[] providerIds)
	{
		//IL_002f: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_00e2: Expected I, but got Obj
		if (AgeRestriction.waitForAgeRestriction)
		{
			return null;
		}
		List<VideoAdProvider> list = default;
		list._002Ector();
		List<VideoAdProvider> list2 = default;
		list2._002Ector();
		object obj5;
		nint num2 = default;
		object obj4 = default;
		for (object obj = 0; providerIds.Length > (nint)obj; obj5 = obj + 1, obj = obj5)
		{
			object obj2 = obj << 2;
			object obj3 = (object)providerIds + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v11+10]");
			VideoAdProvider provider = GetProvider((string)0);
			if (provider == null)
			{
				continue;
			}
			bool isRestricted = AgeRestriction.isRestricted;
			bool flag = !isRestricted;
			nint num = num2;
			if (!flag)
			{
				nint num3 = (nint)provider;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ S1_v18 (Il2CppClass<VideoAdProvider>)+E4] (should have been resolved before IL gen)");
				bool flag2 = obj4 == null;
				num = num3;
				num2 = num3;
				if (flag2)
				{
					continue;
				}
			}
			list.Add(provider);
			num2 = num;
		}
		return SortListUsingTheWeightSystem(list);
	}

	private List<VideoAdProvider> SortListUsingTheWeightSystem(List<VideoAdProvider> sourceList)
	{
		//IL_0228: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I4
		//IL_00fa: Expected I, but got Obj
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		List<VideoAdProvider> list = default;
		list._002Ector();
		List<List<VideoAdProvider>> list2 = default;
		list2._002Ector();
		if (sourceList != null && sourceList._size != 0)
		{
			int num = default;
			object obj = default;
			List<VideoAdProvider> list3 = default;
			object obj4 = default;
			int num6 = default;
			while (num < sourceList._size)
			{
				VideoAdProvider videoAdProvider = sourceList.get_Item(num);
				int num2 = 0;
				while (true)
				{
					nint num3 = (nint)videoAdProvider;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v134 @ S1_v25 (Il2CppClass<VideoAdProvider>)+114] (should have been resolved before IL gen)");
					if ((nint)obj <= num2)
					{
						break;
					}
					object obj2 = list2._size - 1;
					if (num2 > (nint)obj2)
					{
						list3._002Ector();
						list2.Add(list3);
					}
					nint num4 = (nint)videoAdProvider;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ S2_v18 (Il2CppClass<VideoAdProvider>)+114] (should have been resolved before IL gen)");
					object obj3 = obj4 - 1;
					if (num2 == (nint)obj3)
					{
						List<VideoAdProvider> list4 = list2.get_Item(num2);
						list4.Add(videoAdProvider);
					}
					int num5 = num2 + 1;
					num2 = num5;
				}
				num = num6 + 1;
			}
			int num7 = default;
			int num10 = default;
			while (num7 < list2._size)
			{
				List<VideoAdProvider> sourceList2 = list2.get_Item(num7);
				List<VideoAdProvider> list5 = ((VideoAdsManager)null).OrderListOfSamePriorityByWeight(sourceList2);
				int num8 = 0;
				while (num8 < list5._size)
				{
					VideoAdProvider item = list5.get_Item(num8);
					list.Add(item);
					int num9 = num8 + 1;
					num8 = num9;
				}
				num7 = num10 + 1;
			}
		}
		return list;
	}

	private List<VideoAdProvider> OrderListOfSamePriorityByWeight(List<VideoAdProvider> sourceList)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected Obj, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected Obj, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_02a2: Expected Obj, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		//IL_05b1: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I4
		//IL_02c7: Expected Obj, but got I4
		//IL_02e5: Expected I, but got Obj
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<VideoAdProvider> list = default;
		list._002Ector();
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		List<VideoAdProvider> list2 = default;
		List<VideoAdProvider> list3 = default;
		object obj11;
		object obj15 = default;
		object obj16 = default;
		object obj17 = default;
		List<VideoAdProvider> list4 = default;
		List<VideoAdProvider> list5 = default;
		object obj22 = default;
		while (true)
		{
			int num;
			List<VideoAdProvider> result;
			if (sourceList._size > 1)
			{
				object obj3 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				object obj4 = obj + 32;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				num = 0;
				while (true)
				{
					_ = 0;
					object obj5 = obj + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						break;
					}
					if (obj6 != null)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							break;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							break;
						}
						int num2 = obj7 + num;
						num = num2;
						continue;
					}
					goto IL_01e2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj8 != obj9;
				result = list2;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_01e2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result = list3;
				}
				_ = 0;
				object obj10 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag2 = (nint)0 == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj11 = 0;
				if (flag2)
				{
					goto IL_05bf;
				}
				goto IL_05e8;
			}
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj13 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			while (true)
			{
				_ = 0;
				object obj14 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					bool flag3 = obj15 == null;
					obj11 = obj;
					if (flag3)
					{
						break;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag4 = obj16 == obj17;
				bool flag5 = !flag4;
				result = list4;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 != 1;
					obj11 = obj;
					if (flag6)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result = list5;
				}
				goto IL_0563;
			}
			break;
			IL_01e2:
			object obj18 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A08");
			int num3 = UnityEngine.Random.Range(0, num);
			object obj19 = num3 + 1;
			VideoAdProvider videoAdProvider = sourceList.get_Item(0);
			int num4 = 0;
			object obj20 = 0;
			VideoAdProvider item;
			while (true)
			{
				if (num4 < sourceList._size)
				{
					VideoAdProvider videoAdProvider2 = sourceList.get_Item(num4);
					nint num5 = (nint)videoAdProvider2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v443 @ S2_v36 (Il2CppClass<VideoAdProvider>)+104] (should have been resolved before IL gen)");
					object obj21 = obj22 + obj20;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19))
					{
						item = sourceList.get_Item(num4);
						break;
					}
					int num6 = num4 + 1;
					num4 = num6;
					obj20 = obj21;
					continue;
				}
				item = videoAdProvider;
				break;
			}
			list.Add(item);
			bool flag7 = sourceList.Remove(item);
			continue;
			IL_05bf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			break;
			IL_05e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
			IL_0563:
			_ = 0;
			object obj23 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag8 = (nint)0 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj11 = 0;
			if (!flag8)
			{
				goto IL_05bf;
			}
			goto IL_05e8;
		}
		object obj24 = obj11 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A08");
		return list;
	}

	private unsafe string[] GetProviderList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Ref, but got Unknown
		//IL_01cc: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I4
		//IL_0250: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string[] result;
		object obj4;
		if (~(Globals.DEBUG_VIDEOADS_PROVIDERS ? 1u : 0u) == 0)
		{
			List<string> list = default;
			list._002Ector();
			if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_ADCOLONY ? 1u : 0u) == 0)
			{
				list.Add("adcolony");
			}
			if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_FLURRY ? 1u : 0u) == 0)
			{
				list.Add("flurryvideoads");
			}
			if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_INMOBI ? 1u : 0u) == 0)
			{
				list.Add("inmobivideoads");
			}
			if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_TABJOY ? 1u : 0u) == 0)
			{
				list.Add("tapjoyvideoads");
			}
			if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_VUNGLE ? 1u : 0u) == 0)
			{
				list.Add("vungleclips");
			}
			if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_CHARTBOOST ? 1u : 0u) == 0)
			{
				list.Add("chartboostvideoads");
			}
			if (~(Globals.DEBUG_VIDEOADS_PROVIDERS_SUPERSONIC ? 1u : 0u) == 0)
			{
				list.Add("supersonicvideoads");
			}
			string[] array = list.ToArray();
			result = array;
		}
		else
		{
			OnlineSettings onlineSettings = OnlineSettings.instance;
			bool flag = onlineSettings.TryGetValue("videoads_providerlist", out *(string*)(obj + 12));
			bool flag2 = !flag;
			result = DEFAULT_PROVIDER_LIST;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				if ((nint)0 != 0)
				{
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v31+8]");
					if ((nint)0 != 0)
					{
						goto IL_02ea;
					}
				}
				obj4 = 1;
				goto IL_02ea;
			}
		}
		goto IL_02e5;
		IL_02ea:
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			string[] array2 = default;
			result = array2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			string[] array3 = ((string)0).Split(',');
			object obj5 = default;
			bool flag3 = (nint)obj5 >= array3.Length;
			result = array3;
			if (!flag3)
			{
				object obj6 = obj5 << 2;
				object obj7 = (object)array3 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v14+10]");
				string text = ((string)0).Trim();
				throw new ArrayTypeMismatchException();
			}
		}
		goto IL_02e5;
		IL_02e5:
		return result;
	}

	private VideoAdProvider GetProvider(string providerId)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Obj, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected Obj, but got Unknown
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected Obj, but got Unknown
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected Obj, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected Obj, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		switch (providerId)
		{
		case "adcolony":
		{
			object result3 = this + 28;
			if (_adColonyProvider == null && AdColonyProvider.isVideoProviderSupported)
			{
				AdColonyProvider adColonyProvider = AdColonyProvider.instance;
				_adColonyProvider = adColonyProvider;
				VideoAdProvider adColonyProvider2 = _adColonyProvider;
				object obj3 = adColonyProvider2 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v192 @ S2_v151+BC] (should have been resolved before IL gen)");
				throw new ArgumentException();
			}
			return (VideoAdProvider)result3;
		}
		case "flurryvideoads":
		{
			object result6 = this + 32;
			if (_flurryVideoAdsProvider == null && FlurryVideoAdsProvider.isVideoProviderSupported)
			{
				FlurryVideoAdsProvider flurryVideoAdsProvider = FlurryVideoAdsProvider.instance;
				_flurryVideoAdsProvider = flurryVideoAdsProvider;
				VideoAdProvider flurryVideoAdsProvider2 = _flurryVideoAdsProvider;
				object obj6 = flurryVideoAdsProvider2 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v248 @ S2_v128+BC] (should have been resolved before IL gen)");
				throw new ArgumentException();
			}
			return (VideoAdProvider)result6;
		}
		case "vungleclips":
		{
			object result4 = this + 36;
			if (_vungleVideoAdsProvider == null && VungleProvider.isVideoProviderSupported)
			{
				VungleProvider vungleVideoAdsProvider = VungleProvider.instance;
				_vungleVideoAdsProvider = vungleVideoAdsProvider;
				VideoAdProvider vungleVideoAdsProvider2 = _vungleVideoAdsProvider;
				object obj4 = vungleVideoAdsProvider2 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v315 @ S2_v105+BC] (should have been resolved before IL gen)");
				throw new ArgumentException();
			}
			return (VideoAdProvider)result4;
		}
		case "tapjoyvideoads":
		{
			object result7 = this + 40;
			if (_tapjoyVideoAdProvider == null && TapJoyVideoProvider.isVideoProviderSupported)
			{
				TapJoyVideoProvider tapjoyVideoAdProvider = TapJoyVideoProvider.instance;
				_tapjoyVideoAdProvider = tapjoyVideoAdProvider;
				VideoAdProvider tapjoyVideoAdProvider2 = _tapjoyVideoAdProvider;
				object obj7 = tapjoyVideoAdProvider2 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v391 @ S2_v82+BC] (should have been resolved before IL gen)");
				throw new ArgumentException();
			}
			return (VideoAdProvider)result7;
		}
		case "inmobivideoads":
		{
			object result2 = this + 44;
			if (_inmobiVideoAdsProvider == null && InmobiVideoAdsProvider.isVideoProviderSupported)
			{
				InmobiVideoAdsProvider inmobiVideoAdsProvider = InmobiVideoAdsProvider.instance;
				_inmobiVideoAdsProvider = inmobiVideoAdsProvider;
				VideoAdProvider inmobiVideoAdsProvider2 = _inmobiVideoAdsProvider;
				object obj2 = inmobiVideoAdsProvider2 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v475 @ S2_v59+BC] (should have been resolved before IL gen)");
				throw new ArgumentException();
			}
			return (VideoAdProvider)result2;
		}
		case "chartboostvideoads":
		{
			object result5 = this + 48;
			if (_chartboostVideoAdProvider == null && ChartboostVideoAdsProvider.isVideoProviderSupported)
			{
				ChartboostVideoAdsProvider chartboostVideoAdProvider = ChartboostVideoAdsProvider.instance;
				_chartboostVideoAdProvider = chartboostVideoAdProvider;
				VideoAdProvider chartboostVideoAdProvider2 = _chartboostVideoAdProvider;
				object obj5 = chartboostVideoAdProvider2 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v550 @ S2_v36+BC] (should have been resolved before IL gen)");
				throw new ArgumentException();
			}
			return (VideoAdProvider)result5;
		}
		case "supersonicvideoads":
		{
			object result = this + 52;
			if (_supersonicVideoAdProvider == null && SupersonicVideoAdsProvider.isVideoProviderSupported)
			{
				SupersonicVideoAdsProvider supersonicVideoAdProvider = SupersonicVideoAdsProvider.instance;
				_supersonicVideoAdProvider = supersonicVideoAdProvider;
				VideoAdProvider supersonicVideoAdProvider2 = _supersonicVideoAdProvider;
				object obj = supersonicVideoAdProvider2 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v632 @ S2_v13+BC] (should have been resolved before IL gen)");
				throw new ArgumentException();
			}
			return (VideoAdProvider)result;
		}
		default:
		{
			string text = "VideoAdsManager WARNING: Unknown provider id: " + providerId;
			return null;
		}
		}
	}

	private string GetProviderId(VideoAdProvider provider)
	{
		if (provider != null)
		{
			if (_adColonyProvider == provider)
			{
				return "adcolony";
			}
			if (_flurryVideoAdsProvider == provider)
			{
				return "flurryvideoads";
			}
			if (_vungleVideoAdsProvider == provider)
			{
				return "vungleclips";
			}
			if (_tapjoyVideoAdProvider == provider)
			{
				return "tapjoyvideoads";
			}
			if (_inmobiVideoAdsProvider == provider)
			{
				return "inmobivideoads";
			}
			if (provider == _chartboostVideoAdProvider)
			{
				return "chartboostvideoads";
			}
		}
		LogError("VideoAdsManager GetProviderId() ERROR: Unknown provider");
		return null;
	}

	public VideoState GetCurrentVideoState()
	{
		return currentVideoState__BackingField;
	}

	private void ResetCurrentVideoState()
	{
		currentVideoState__BackingField = VideoState.NoVideos;
	}

	private void OnProviderTakeoverBegan(VideoAdProvider provider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_ = 0;
		if (state__BackingField != State.Initialized)
		{
			_ = state__BackingField;
			_ = -1;
			obj = (Enum)(object)typeof(State);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			string text2 = "VideoAdsManager: Unexpected state in OnProviderTakeoverBegan (" + text + ")";
		}
		state__BackingField = State.TakeoverActive;
		MuteSound();
	}

	private void OnProviderTakeoverEnded(VideoAdProvider provider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_ = 0;
		if (state__BackingField != State.TakeoverActive)
		{
			_ = state__BackingField;
			_ = -1;
			obj = (Enum)(object)typeof(State);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			string text2 = "VideoAdsManager: Unexpected state in OnProviderTakeoverEnded (" + text + ")";
		}
		state__BackingField = State.Initialized;
		UIScreenController uIScreenController = UIScreenController.Instance;
		if (uIScreenController.IsVideoAdsOverlayVisible())
		{
			UIScreenController uIScreenController2 = UIScreenController.Instance;
			uIScreenController2.HideVideoAdsOverlay();
		}
		RestoreSound();
		_isVideoPlaying = false;
		StartCachingVideo();
	}

	private void OnProviderVideoWatched(VideoAdProvider provider)
	{
		state__BackingField = State.Initialized;
		VideoWatched();
	}

	private void MuteSound()
	{
		bool optionSfx = Settings.optionSfx;
		_gameSfxOnBeforeMute = optionSfx;
		bool optionMusic = Settings.optionMusic;
		_gameMusicOnBeforeMute = optionMusic;
		Settings.DisableAllSoundOptions();
		HouseKeeper.SaveAudioOptionsBeforeVideoAds(_gameSfxOnBeforeMute, _gameMusicOnBeforeMute);
	}

	private void RestoreSound()
	{
		Settings.optionSfx = _gameSfxOnBeforeMute;
		Settings.optionMusic = _gameMusicOnBeforeMute;
		HouseKeeper.DeleteSoundOptionBeforeVideoAds();
	}

	private void VideoWatched()
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		_isVideoPlaying = false;
		Action rewardOverride = _rewardOverride;
		if (_rewardOverride == null)
		{
			if (AbleToWatchAVideoForKeysToday() && _numberOfKeysToRewardForVideo >= 1)
			{
				int amountOfKeys = playerInfo.amountOfKeys;
				int amountOfKeys2 = amountOfKeys + _numberOfKeysToRewardForVideo;
				playerInfo.amountOfKeys = amountOfKeys2;
				playerInfo._dirty = true;
				playerInfo._lastTimeAVideoForKeysWasSeen = playerInfo._lastKnownServerTime;
				Action onKeyVideoWatchedChangedHandler = _onKeyVideoWatchedChangedHandler;
				if (_onKeyVideoWatchedChangedHandler != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v92.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				UIScreenController uIScreenController = UIScreenController.Instance;
				UIScreenController.SlideIn slideIn = default;
				slideIn._002Ector(UIScreenController.SlideInType.VideoForKeys);
				uIScreenController.QueueSlideIn(slideIn);
			}
			else
			{
				RewardManager.AddRewardToUnlock(CelebrationRewardOrigin.MysteryBoxMini);
				UIScreenController uIScreenController2 = UIScreenController.Instance;
				uIScreenController2.QueueMysteryBox();
			}
		}
		else
		{
			_rewardOverride = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v21.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		UIScreenController uIScreenController3 = UIScreenController.Instance;
		if (uIScreenController3.IsVideoAdsOverlayVisible())
		{
			UIScreenController uIScreenController4 = UIScreenController.Instance;
			uIScreenController4.HideVideoAdsOverlay();
		}
	}

	public bool IsAnyVideoAvailable()
	{
		if (~(Globals.DEBUG_SKIP_VIDEO_ADS ? 1u : 0u) == 0)
		{
			return true;
		}
		return currentVideoState__BackingField == VideoState.Ready;
	}

	public bool IsVideoForKeysAvailable()
	{
		int amountOfKeysRewardedForVideo = GetAmountOfKeysRewardedForVideo();
		bool flag = AbleToWatchAVideoForKeysToday();
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			bool flag3 = IsAnyVideoAvailable();
			bool flag4 = !flag3;
			result = false;
			if (!flag4)
			{
				bool flag5 = _numberOfKeysToRewardForVideo > 0;
				result = flag5;
			}
		}
		return result;
	}

	private unsafe bool AbleToWatchAVideoForKeysToday()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected VT, but got Unknown
		//IL_002a: Expected Ref, but got VT
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected VT, but got Unknown
		//IL_005d: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo playerInfo = PlayerInfo.Instance;
		_ = playerInfo._lastKnownServerTime;
		DateTime dateTime = (DateTime)(obj + 8);
		DateTime date = ((DateTime*)dateTime)->Date;
		PlayerInfo playerInfo2 = PlayerInfo.Instance;
		_ = playerInfo2._lastTimeAVideoForKeysWasSeen;
		DateTime dateTime2 = (DateTime)(obj + 8);
		DateTime date2 = ((DateTime*)dateTime2)->Date;
		int num = DateTime.Compare(date, date2);
		return num != 0;
	}

	public DateTime GetLastTimeAVideoForKeysWasSeen()
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		return playerInfo._lastTimeAVideoForKeysWasSeen;
	}

	public int GetAmountOfKeysRewardedForVideo()
	{
		OnlineSettings onlineSettings = OnlineSettings.instance;
		return _numberOfKeysToRewardForVideo = onlineSettings.GetValue("keys_rewarded_for_video_ad", 2);
	}

	public void OnApplicationPause(bool pause)
	{
		//IL_0032: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		VideoAdProvider videoAdProvider = currentProvider;
		if (currentProvider != null)
		{
			object obj = 18;
			if (!pause)
			{
				obj = 19;
			}
			object obj2 = obj << 3;
			object obj3 = (object)videoAdProvider + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S1_v4+BC] (should have been resolved before IL gen)");
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "[VideoAdsManager] " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	static VideoAdsManager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
