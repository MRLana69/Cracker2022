using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Info;
using Kiloo;
using Kiloo.Analytics;
using Kiloo.Common.Backend;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using Missions;
using SYBO.Subway.Info;
using TopRun;
using UnityEngine;

public class HouseKeeper : MonoBehaviour
{
	public delegate void OnLateUpdate();

	private sealed class _003COnSecondFrameEnded_003Ed__27(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
			{
				if (_003C_003E1__state == 2)
				{
					_003C_003E1__state = -1;
					Action secondFrameEnded = HouseKeeper.m_secondFrameEnded;
					if (HouseKeeper.m_secondFrameEnded != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			int renderedFrameCount = Time.renderedFrameCount;
			if (renderedFrameCount >= 2)
			{
				object obj = default;
				_003C_003E2__current = obj;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E2__current = null;
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

	private const string KEY_FIRST_TIME_RUN = "SetShouldShowPopupToFalse";

	private const string APPLICATION_AUTHENTICITY_KEY = "applicationAuthenticity";

	private const string SOUND_BEFORE_APPLICATION_LOSTFOCUS = "soundBeforeLostFocus";

	private const string SFX_BEFORE_APPLICATION_LOSTFOCUS = "sfxBeforeLostFocus";

	private const string MUSIC_BEFORE_APPLICATION_LOSTFOCUS = "musicBeforeLostFocus";

	private const string RTL_ALIGNED_LANGUAGES_REGEX = "\\p{IsArabic}|\\p{IsHebrew}|\\p{IsSyriac}|\\p{IsThaana}";

	private int[] _dailyKeysBrackets;

	private int[] _consumableHoverboardBrackets;

	private int[] _headstartBrackets;

	private int[] _scoreBoosterBrackets;

	private const string ANDROID_IN_APP_BILLING_GAMEOBJECT_NAME = "InAppBillingAndroidGameObject";

	private static Action<bool> delegateFacebookPayoutPopupAction;

	private const float MIN_REFRESH_INTERVAL = 3600f;

	private const string REFRESH_INTERVAL_KEY = "refreshinterval";

	private static float _onlineSettingsLastDownloadTime;

	private static Action<bool> _003C_003Ef__mg_0024cache0;

	private static Action<bool> _003C_003Ef__mg_0024cache1;

	private static OnLateUpdate m_onLateUpdate;

	private static Action m_secondFrameEnded;

	public static event OnLateUpdate onLateUpdate
	{
		add
		{
			Delegate obj = HouseKeeper.m_onLateUpdate;
			OnLateUpdate onLateUpdate2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == HouseKeeper.m_onLateUpdate;
				OnLateUpdate onLateUpdate = onLateUpdate2;
				if (!flag)
				{
					onLateUpdate = HouseKeeper.m_onLateUpdate;
				}
				HouseKeeper.m_onLateUpdate = onLateUpdate;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = HouseKeeper.m_onLateUpdate;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = HouseKeeper.m_onLateUpdate;
			OnLateUpdate onLateUpdate2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == HouseKeeper.m_onLateUpdate;
				OnLateUpdate onLateUpdate = onLateUpdate2;
				if (!flag)
				{
					onLateUpdate = HouseKeeper.m_onLateUpdate;
				}
				HouseKeeper.m_onLateUpdate = onLateUpdate;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = HouseKeeper.m_onLateUpdate;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action secondFrameEnded
	{
		add
		{
			Delegate obj = HouseKeeper.m_secondFrameEnded;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == HouseKeeper.m_secondFrameEnded;
				Action action = action2;
				if (!flag)
				{
					action = HouseKeeper.m_secondFrameEnded;
				}
				HouseKeeper.m_secondFrameEnded = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = HouseKeeper.m_secondFrameEnded;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = HouseKeeper.m_secondFrameEnded;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == HouseKeeper.m_secondFrameEnded;
				Action action = action2;
				if (!flag)
				{
					action = HouseKeeper.m_secondFrameEnded;
				}
				HouseKeeper.m_secondFrameEnded = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = HouseKeeper.m_secondFrameEnded;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private unsafe void Awake()
	{
		DeviceUtility.Init();
		Application.targetFrameRate = 60;
		GameObject target = gameObject;
		UnityEngine.Object.DontDestroyOnLoad(target);
		Strings.Language = "english";
		string flurryApiKey = AdConstants.FlurryApiKey;
		PlayerInfo instance = PlayerInfo.Instance;
		string flurryUserIdHash = instance.flurryUserIdHash;
		InitHttp();
		InitTopRun();
		RefreshOnlineSettingsAndInappsIfNeeded();
		SSEventsManagerController instance2 = SSEventsManagerController.instance;
		instance2.Initialize();
		HookUpListenersToOnlineSettings();
		TryRestoreSoundOptionAfterLostFocusIfNeeded();
		IncomingCallManager.Init();
		SocialManager.Init();
		TopRunNotificationSlideInManager.Init();
		Layers.Init();
		ScreenAdsManager instance3 = ScreenAdsManager.instance;
		instance3.InitProviderListAndCache();
		CancellAllLocalNotifications();
		if (!PlayerPrefs.HasKey("SetShouldShowPopupToFalse"))
		{
			goto IL_013e;
		}
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.MetroPlayerARM)
		{
			PlayerInfo instance4 = PlayerInfo.Instance;
			if (!instance4._dataExists)
			{
				goto IL_013e;
			}
		}
		goto IL_02f1;
		IL_013e:
		PlayerPrefs.SetString("SetShouldShowPopupToFalse", "true");
		PlayerInfo instance5 = PlayerInfo.Instance;
		if (~(instance5._shouldShowCollectPopup ? 1u : 0u) == 0)
		{
			instance5._dirty = true;
			instance5._shouldShowCollectPopup = false;
		}
		PlayerInfo instance6 = PlayerInfo.Instance;
		if (~(instance6._shouldShowDuelsBreadcrumb ? 1u : 0u) == 0)
		{
			instance6._dirty = true;
			instance6._shouldShowDuelsBreadcrumb = false;
		}
		PlayerInfo instance7 = PlayerInfo.Instance;
		DateTime now = CDateTime.Now;
		instance7._dirty = true;
		instance7._lastTimeAppWasUpdatedOrInstalled = now;
		PlayerInfo instance8 = PlayerInfo.Instance;
		DateTime now2 = CDateTime.Now;
		instance8._dirty = true;
		instance8._firstInstallDate = now2;
		PlayerInfo instance9 = PlayerInfo.Instance;
		string bundleVersion = DeviceUtility.GetBundleVersion();
		instance9._firstInstalledVersion = bundleVersion;
		instance9._dirty = true;
		goto IL_02f1;
		IL_02f1:
		PostFlurryEventsOnceADay();
		FixUnlockCherryBoardIfNeeded();
		LogApplicationAuthenticity();
		AwardsManager instance10 = AwardsManager.instance;
		instance10.InitAwards();
		OfferWallManager instance11 = OfferWallManager.Instance;
		instance11.Initialize();
		PlayerInfo instance12 = PlayerInfo.Instance;
		FacebookWeeklyGiftManager instance13 = FacebookWeeklyGiftManager.Instance;
		Action action = default;
		action._002Ector(instance13, (nint)__ldftn(FacebookWeeklyGiftManager.CheckAndUpdateNextWeeklyGiftDate));
		instance12.onKnownServerTimeChange += action;
		Manager.Initialize();
		RunTracker.Initialize();
		AddFpsCounter();
		InRunLogging.Init();
		NotificationsObserver instance14 = NotificationsObserver.instance;
		throw new ArgumentException();
	}

	private void LateUpdate()
	{
		if (HouseKeeper.m_onLateUpdate != null)
		{
			OnLateUpdate onLateUpdate = HouseKeeper.m_onLateUpdate;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void Start()
	{
		IEnumerator routine = OnSecondFrameEnded();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator OnSecondFrameEnded()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void AddFpsCounter()
	{
		GameObject gameObject = default;
		gameObject._002Ector("FpsCounter");
		gameObject.name = "FpsCounter";
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		InRunAverageFPSCounter inRunAverageFPSCounter = gameObject.AddComponent<InRunAverageFPSCounter>();
		inRunAverageFPSCounter.Initialize();
	}

	private void LogApplicationAuthenticity()
	{
		if (!PlayerPrefs.HasKey("applicationAuthenticity") && (!Application.genuineCheckAvailable || Application.genuine))
		{
			PlayerPrefs.SetString("applicationAuthenticity", "set");
		}
	}

	private unsafe void HookUpListenersToOnlineSettings()
	{
		OnlineSettings instance = OnlineSettings.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(HouseKeeper.OnOnlineSettingsSetupFinished));
		instance.AddOnFinishedDownloadingOnlineSettingsHandler(action);
		OnlineSettings instance2 = OnlineSettings.instance;
		throw new ArgumentException();
	}

	private void OnOnlineSettingsSetupFinished()
	{
		((HouseKeeper)null).InitializeVideoAdsSystem();
	}

	private unsafe void OnOnlineSettingsDownloadedWithResult(bool result)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0064: Expected I, but got VT
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected VT, but got Unknown
		//IL_008d: Expected Ref, but got VT
		object obj = default;
		HouseKeeper houseKeeper = (HouseKeeper)(obj - 16);
		PlayerInfo instance = PlayerInfo.Instance;
		if (!houseKeeper.IsDateToday(instance._lastDailyOnlineLog))
		{
			if (result)
			{
				string locale = DeviceUtility.GetLocale();
				string contryCodeFromLocale = Utils.GetContryCodeFromLocale(locale);
			}
			PlayerInfo instance2 = PlayerInfo.Instance;
			DateTime now = CDateTime.Now;
			((UnityEngine.Object)houseKeeper).m_CachedPtr = (IntPtr)now;
			DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
			DateTime dateTime = (DateTime)(houseKeeper + 8);
			string lastDailyOnlineLog = ((DateTime*)dateTime)->ToString(invariantInfo);
			instance2.lastDailyOnlineLog = lastDailyOnlineLog;
		}
	}

	private void InitializeVideoAdsSystem()
	{
		VideoAdsManager instance = VideoAdsManager.instance;
		if (instance.state__BackingField == VideoAdsManager.State.Uninitialized)
		{
			VideoAdsManager instance2 = VideoAdsManager.instance;
			instance2.Init();
			VideoAdsManager instance3 = VideoAdsManager.instance;
			instance3.StartCachingVideo();
		}
	}

	private unsafe void FixUnlockCherryBoardIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (PlayerPrefs.HasKey("FixUnlockCherryBoardIfNeeded"))
		{
			return;
		}
		PlayerPrefs.SetInt("FixUnlockCherryBoardIfNeeded", 1);
		PlayerInfo instance = PlayerInfo.Instance;
		string[] array = instance._weeklyChallangeData.Split(',');
		if (array.Length >= 5 && array[4] != null)
		{
			bool flag = int.TryParse(array[4], out *(int*)(obj + 12));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 == 60 && !instance.IsHoverboardUnlocked(Hoverboards.BoardType.cherry))
			{
				instance.UnlockHoverboard(Hoverboards.BoardType.cherry);
			}
		}
	}

	private void InitHttp()
	{
		WebClient.timeout__BackingField = 10f;
		WebClient.ClearCache((WebClient.ClearCacheFlags)6, 2419200f);
		KilooWebClient.InitAutomatically("subway_surfers");
	}

	private void InitTopRun()
	{
		if (TopRunRoot.manager__BackingField == null)
		{
			CountryManager instance = CountryManager.instance;
			string defaultCountryCodeFromDevice = instance.GetDefaultCountryCodeFromDevice();
			PlayerInfo instance2 = PlayerInfo.Instance;
			int num = instance2._currentMissionSet + 1;
			if (num >= 30)
			{
				num = 30;
			}
			if (num <= 1)
			{
				num = 1;
			}
			PlayerInfo instance3 = PlayerInfo.Instance;
			TopRunRoot.Init(defaultCountryCodeFromDevice, num, instance3._highScore);
		}
	}

	private void RefreshTopRun()
	{
		if (TopRunRoot.manager__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	private unsafe void RegisterAllBundlesDownloaded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got VT
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected VT, but got Unknown
		//IL_0175: Expected Ref, but got VT
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected I4, but got Unknown
		object obj = default;
		HouseKeeper houseKeeper = (HouseKeeper)(obj - 32);
		_ = 0;
		houseKeeper._consumableHoverboardBrackets = null;
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.WindowsEditor && Application.platform != RuntimePlatform.OSXEditor)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			if (!houseKeeper.IsDateToday(instance._lastQuitDate))
			{
				string locale = DeviceUtility.GetLocale();
				string contryCodeFromLocale = Utils.GetContryCodeFromLocale(locale);
				PlayerInfo instance2 = PlayerInfo.Instance;
				_ = instance2._allAssetBundlesDownloaded;
				_ = instance2._allAssetBundlesDownloaded;
				object obj2 = houseKeeper + 15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg = default;
				string text = $"All Bundles Downloaded {arg} in Country";
				string text2 = "All Bundles Downloaded?;" + text;
				bool flag = (byte)(houseKeeper + 31) != 0;
				string text3 = (flag ? ((bool*)1) : ((bool*)null))->ToString();
				string text4 = text3 + ";" + contryCodeFromLocale;
			}
			PlayerInfo instance3 = PlayerInfo.Instance;
			DateTime now = CDateTime.Now;
			houseKeeper._consumableHoverboardBrackets = (int[])now;
			DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
			DateTime dateTime = (DateTime)(houseKeeper + 16);
			string lastQuitDate = ((DateTime*)dateTime)->ToString(invariantInfo);
			instance3.lastQuitDate = lastQuitDate;
			PlayerInfo instance4 = PlayerInfo.Instance;
			instance4.SaveIfDirty();
		}
	}

	private void RegisterLocalNotificationStatus()
	{
	}

	private unsafe void RegisterReminderStatus()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		bool optionReminder = Settings.optionReminder;
		bool flag = (byte)(obj + 15) != 0;
		string text = (flag ? ((bool*)1) : ((bool*)null))->ToString();
	}

	private unsafe void RegisterDailyActiveCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		_ = instance._currentCharacter;
		Enum obj3 = (Enum)(obj + 8);
		_ = -1;
		obj3 = (Enum)(object)typeof(Characters.CharacterType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		_ = 0;
		string text = obj3.ToString();
		PlayerInfo instance2 = PlayerInfo.Instance;
		int currentThemeIndex = instance2.currentThemeIndex;
		int num = obj + 24;
		string text2 = ((int*)num)->ToString();
		string text3 = text + "_Theme" + text2;
	}

	private void RegisterDailyActiveBoard()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I4
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		PlayerInfo instance2 = PlayerInfo.Instance;
		_ = instance2._currentHoverboard;
		Enum obj3 = (Enum)(obj + 8);
		_ = -1;
		obj3 = (Enum)(object)typeof(Hoverboards.BoardType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
		_ = 0;
		string text = obj3.ToString();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+54]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj6 = default;
		object obj5 = obj6 ^ -1;
		object obj7 = obj5 >> 31;
		if (obj7 == null)
		{
			return;
		}
		object obj8 = obj + 8;
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(instance._currentHoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj9 = obj + 24;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj11 = default;
		object obj13 = default;
		object obj15 = default;
		object obj16 = default;
		object obj18 = default;
		object obj19 = default;
		object obj20 = default;
		while (true)
		{
			_ = 0;
			object obj10 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj11 == null)
				{
					goto IL_03fb;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
				object obj12 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj13 == null)
								{
									continue;
								}
								_ = -1;
								_ = typeof(HoverboardThemes.ThemeIdentifier);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v97+28]");
								_ = 0;
								_ = 0;
								object obj14 = obj + 8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_0369;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0369;
			IL_0369:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj15 != obj16;
			object obj17 = obj18;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			obj = obj19;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_03fb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj17 = obj20;
			break;
			IL_03fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A71");
			return;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	private unsafe void RegisterDailyCoinsAmount()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected I4, but got Unknown
		object obj = default;
		HouseKeeper houseKeeper = (HouseKeeper)(obj - 16);
		houseKeeper._dailyKeysBrackets = null;
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfCoins = instance.amountOfCoins;
		if (amountOfCoins >= 10001)
		{
			if (amountOfCoins >= 100001)
			{
				if (amountOfCoins >= 1000001)
				{
					if (amountOfCoins <= 3000000)
					{
						string text = houseKeeper.RoundUpToTargetValue(amountOfCoins, 500000);
						return;
					}
					houseKeeper._dailyKeysBrackets = (int[])3000000;
					int num = houseKeeper + 12;
					string text2 = ((int*)num)->ToString();
					string text3 = text2 + "+";
				}
				else
				{
					string text4 = houseKeeper.RoundUpToTargetValue(amountOfCoins, 100000);
				}
			}
			else
			{
				string text5 = houseKeeper.RoundUpToTargetValue(amountOfCoins, 10000);
			}
		}
		else
		{
			string text6 = houseKeeper.RoundUpToTargetValue(amountOfCoins, 1000);
		}
	}

	private void RegisterDailyKeysAmount()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfKeys = instance.amountOfKeys;
		string bracketForValue = GetBracketForValue(amountOfKeys, _dailyKeysBrackets);
	}

	private void RegisterFacebookStatus()
	{
		SocialManager instance = SocialManager.instance;
		if (instance.facebookIsLoggedIn)
		{
		}
	}

	private unsafe string RoundUpToTargetValue(int total, int factor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected I4, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		string result = string.Empty;
		object obj3 = 1;
		while ((nint)obj3 < 11)
		{
			object obj4 = factor * obj3;
			if (total <= (nint)obj4)
			{
				object obj5 = factor * obj3;
				object obj6 = obj5 - factor;
				int num = obj + 8;
				string text = ((int*)num)->ToString();
				int num2 = obj + 12;
				string text2 = ((int*)num2)->ToString();
				result = text + " - " + text2;
				break;
			}
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
		return result;
	}

	private void RegisterDevicePerfomanceLevel()
	{
		DeviceInfo instance = DeviceInfo.Instance;
		if (instance.performanceLevel == DeviceInfo.PerformanceLevel.High)
		{
		}
	}

	private unsafe void RegisterDeviceMemory()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.MetroPlayerARM)
		{
			RuntimePlatform platform2 = Application.platform;
			if (platform2 != RuntimePlatform.WindowsPlayer)
			{
				return;
			}
		}
		int physicalMemoryMB = SystemInfo.GetPhysicalMemoryMB();
		int num = obj + 12;
		string text = ((int*)num)->ToString();
	}

	private unsafe void RegisterOwnedCharactersAndOutfits()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected Obj, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected Obj, but got Unknown
		//IL_0513: Expected Obj, but got I
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected Obj, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected I4, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 24;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj13 = default;
		object obj14 = default;
		object obj16 = default;
		object obj17 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj8 = obj + 56;
					object obj9 = obj + 52;
					object obj10 = obj + 48;
					object obj11 = obj + 44;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj12 = obj + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj13 == obj14;
			bool flag3 = !flag2;
			object obj15 = obj16;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj15 = obj17;
			}
			_ = 0;
			object obj18 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj19 = obj7 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BA");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ L0_v2+38]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ L0_v2+34]");
		object obj20 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ L0_v2+30]");
		object obj21 = 0 + obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ L0_v2+2C]");
		object obj22 = 0 + obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num2 = obj7 + 60;
		string text = ((int*)num2)->ToString();
		throw new ArrayTypeMismatchException();
	}

	private unsafe void IncrementTypeOfOwnedCharacter(Characters.CharacterType character, ref int regularCharactersOwned, ref int limitedCharactersOwned, ref int tokenCharactersOwned, ref int facebookCharactersOwned)
	{
		//IL_011d: Expected Obj, but got I
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0174: Expected Obj, but got I4
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 == null)
		{
			return;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		if (!instance.IsCharacterOwned(character))
		{
			return;
		}
		Characters.Model model = Characters.characterData.get_Item(character);
		ref int reference = default;
		if (!model.hasOnlineSettings)
		{
			bool flag = model.unlockType == PurchaseData.UnlockType.Tokens;
			reference = ref tokenCharactersOwned;
			if (!flag)
			{
				if (model.unlockType == PurchaseData.UnlockType.Facebook)
				{
					SocialManager instance2 = SocialManager.instance;
					bool facebookIsLoggedIn = instance2.facebookIsLoggedIn;
					reference = ref facebookCharactersOwned;
					if (!facebookIsLoggedIn)
					{
						return;
					}
				}
				else
				{
					reference = ref regularCharactersOwned;
				}
			}
		}
		object obj5 = reference + 1;
		reference = ref *(int*)obj5;
	}

	private unsafe void IncrementOwnedOutfits(Characters.CharacterType character, ref int outfitsOwned)
	{
		//IL_003c: Expected Obj, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I4
		List<CharacterTheme> list = CharacterThemes.TryGetCustomThemesForChar(character);
		if (list == null || list._size <= 0)
		{
			return;
		}
		int num = 1;
		object obj = 0;
		while ((nint)obj < list._size)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			if (instance.IsThemeUnlockedForCharacter(character, num))
			{
				object obj2 = outfitsOwned + 1;
				ref int reference = ref *(int*)obj2;
			}
			int num2 = num + 1;
			object obj3 = obj + 1;
			num = num2;
			obj = obj3;
		}
	}

	public unsafe void RegisterOwnedHoverboardsAndAbilities()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bef: Expected Obj, but got Unknown
		//IL_0c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c21: Expected Obj, but got Unknown
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Expected Obj, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d89: Expected Obj, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected Obj, but got Unknown
		//IL_09d2: Expected Obj, but got I
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected Obj, but got Unknown
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Expected I4, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected Obj, but got Unknown
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected Obj, but got Unknown
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected Obj, but got Unknown
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected Obj, but got Unknown
		//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Expected Obj, but got Unknown
		//IL_088c: Expected Obj, but got I4
		//IL_0d2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Expected Obj, but got Unknown
		//IL_06bb: Expected Obj, but got I
		//IL_02c8: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_087e: Expected Obj, but got I4
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected Obj, but got Unknown
		//IL_07ca: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 128;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj4 = obj + 96;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
		object obj21 = default;
		object obj26 = default;
		object obj28 = default;
		object obj30 = default;
		object obj31 = default;
		object obj33 = default;
		object obj35 = default;
		object obj36 = default;
		object obj40 = default;
		object obj41 = default;
		object obj42 = default;
		object obj43 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_039d;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj7 == null)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_02ff;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj8 == null)
									{
										continue;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										goto IL_02ff;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S0_v394+25]");
										if ((nint)0 != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
											object obj9 = (nint)0 + (nint)1;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
											object obj10 = (nint)0 + (nint)1;
										}
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_030e;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_030e;
			IL_02ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_030e;
			IL_030e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj11 != obj12;
			object obj13 = obj14;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_039d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj13 = obj15;
			}
			_ = 0;
			object obj16 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				break;
			}
			goto IL_0b64;
			IL_039d:
			object obj17 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDC");
			object obj18 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			object obj19 = obj + 72;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			while (true)
			{
				_ = 0;
				object obj20 = obj + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj32;
				object obj34;
				if ((nint)0 != 1)
				{
					if (obj21 == null)
					{
						goto IL_099d;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+54]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						_ = 0;
						_ = 0;
						object obj22 = obj - -64;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									object obj23 = obj + 24;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
										_ = 0;
										object obj24 = obj + 48;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
										_ = 0;
										while (true)
										{
											_ = 0;
											object obj25 = obj + 48;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											if (obj26 != null)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
												object obj27 = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												if (obj28 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
													object obj29 = (nint)0 + (nint)1;
												}
												continue;
											}
											goto IL_0883;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
										bool flag2 = obj30 != obj31;
										obj32 = obj30;
										obj13 = obj33;
										if (!flag2)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												obj34 = 0;
												goto IL_0d1e;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
											obj32 = obj35;
											obj13 = obj36;
										}
										_ = 0;
										object obj37 = obj + 24;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											break;
										}
										goto IL_0dbe;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								goto IL_092f;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_092f;
				IL_099d:
				object obj38 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1981");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
				object obj39 = num + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				int num2 = obj + 124;
				string text = ((int*)num2)->ToString();
				throw new ArrayTypeMismatchException();
				IL_092f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj32 = obj40;
				obj13 = obj41;
				goto IL_0dbe;
				IL_0883:
				obj34 = 6;
				goto IL_0d1e;
				IL_0dbe:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				if (obj42 == obj32)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_099d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj13 = obj43;
				}
				_ = 0;
				object obj44 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto end_IL_0c3e;
				}
				break;
				IL_0d1e:
				_ = 0;
				object obj45 = obj + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if ((nint)obj34 == 6 || obj34 == null)
					{
						continue;
					}
					object obj46 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1981");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_092f;
			}
			goto IL_0b64;
			IL_0b64:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			continue;
			end_IL_0c3e:
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private void RegisterOwnedConsumableHoverboards()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int upgradeAmount = instance.GetUpgradeAmount(PowerupType.hoverboard);
		string bracketForValue = GetBracketForValue(upgradeAmount, _consumableHoverboardBrackets);
	}

	private void RegisterOwnedHeadstarts()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int upgradeAmount = instance.GetUpgradeAmount(PowerupType.headstart2000);
		string bracketForValue = GetBracketForValue(upgradeAmount, _headstartBrackets);
	}

	private void RegisterOwnedScoreBoosters()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int upgradeAmount = instance.GetUpgradeAmount(PowerupType.scorebooster);
		string bracketForValue = GetBracketForValue(upgradeAmount, _scoreBoosterBrackets);
	}

	private unsafe void RegisterTotalAmountOfFinishedGoldAwards()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		AwardsManager instance = AwardsManager.instance;
		int numberOfFinishedAwards = instance.GetNumberOfFinishedAwards(AwardTierType.Gold);
		int num = obj + 12;
		string text = ((int*)num)->ToString();
	}

	private unsafe void RegisterTotalAmountOfFinishedSilverAwards()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		AwardsManager instance = AwardsManager.instance;
		int numberOfFinishedAwards = instance.GetNumberOfFinishedAwards(AwardTierType.Silver);
		int num = obj + 12;
		string text = ((int*)num)->ToString();
	}

	private void RegisterBundleIdentifier()
	{
		string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
	}

	private unsafe string GetBracketForValue(int value, int[] bracket)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		//IL_0021: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected I4, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected I4, but got Unknown
		//IL_01a2: Expected Obj, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string text = string.Empty;
		string text3;
		object obj13;
		if (value > bracket[0])
		{
			object obj3 = 1;
			while (true)
			{
				if (bracket.Length > (nint)obj3)
				{
					object obj4 = obj3 << 2;
					object obj5 = (object)bracket + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v28+10]");
					if ((nint)value <= (nint)0)
					{
						object obj6 = obj3 - 1;
						object obj7 = obj6 << 2;
						object obj8 = (object)bracket + obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v32+10]");
						object obj9 = (nint)0 + (nint)1;
						int num = obj + 8;
						string text2 = ((int*)num)->ToString();
						object obj10 = obj3 << 2;
						object obj11 = (object)bracket + obj10;
						int num2 = obj11 + 16;
						text = ((int*)num2)->ToString();
						text3 = text2;
						break;
					}
					object obj12 = obj3 + 1;
					obj3 = obj12;
					continue;
				}
				text3 = string.Empty;
				break;
			}
			if (text != null)
			{
				obj13 = 0;
				if (text._stringLength != 0)
				{
					goto IL_028c;
				}
			}
			obj13 = 1;
			goto IL_028c;
		}
		int num3 = obj + 12;
		return ((int*)num3)->ToString();
		IL_028c:
		if (obj13 != null)
		{
			object obj14 = bracket.Length << 2;
			object obj15 = (object)bracket + obj14;
			int num4 = obj15 + 12;
			string text4 = ((int*)num4)->ToString();
			return text4 + "+";
		}
		return text3 + "-" + text;
	}

	private unsafe void RegisterFirstInstallDate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I8
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected I8, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		if (instance._firstInstallDate != DateTime.MinValue)
		{
			long num = TimeUtility.ToUnixTime(instance._firstInstallDate);
			object obj3 = num * 1000;
			long num2 = obj + 8;
			string text = ((long*)num2)->ToString();
		}
	}

	private unsafe void PostFlurryEventsOnceADay()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got VT
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected I4, but got Unknown
		object obj = default;
		HouseKeeper houseKeeper = (HouseKeeper)(obj - 16);
		houseKeeper = (HouseKeeper)0;
		PlayerInfo instance = PlayerInfo.Instance;
		if (!houseKeeper.IsDateToday(instance._lastPlayDate))
		{
			houseKeeper.RegisterReminderStatus();
			RegisterDailyCoinsAmount();
			RegisterDailyKeysAmount();
			houseKeeper.RegisterDailyActiveCharacter();
			houseKeeper.RegisterDailyActiveBoard();
			houseKeeper.RegisterFacebookStatus();
			houseKeeper.RegisterDevicePerfomanceLevel();
			houseKeeper.RegisterDeviceMemory();
			RegisterOwnedCharactersAndOutfits();
			houseKeeper.RegisterOwnedHoverboardsAndAbilities();
			RegisterOwnedConsumableHoverboards();
			RegisterOwnedHeadstarts();
			RegisterOwnedScoreBoosters();
			houseKeeper.RegisterTotalAmountOfFinishedGoldAwards();
			houseKeeper.RegisterTotalAmountOfFinishedSilverAwards();
			houseKeeper.RegisterFirstInstallDate();
			houseKeeper.RegisterBundleIdentifier();
			int numberOfDaysSinceLastPlay = houseKeeper.GetNumberOfDaysSinceLastPlay();
			houseKeeper._dailyKeysBrackets = (int[])numberOfDaysSinceLastPlay;
			if (numberOfDaysSinceLastPlay >= 1)
			{
				int num = houseKeeper + 12;
				NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
				string text = ((int*)num)->ToString(invariantInfo);
			}
			PlayerInfo instance2 = PlayerInfo.Instance;
			DateTime now = CDateTime.Now;
			houseKeeper = (HouseKeeper)now;
			DateTimeFormatInfo invariantInfo2 = DateTimeFormatInfo.InvariantInfo;
			string lastPlayDate = ((DateTime*)houseKeeper)->ToString(invariantInfo2);
			instance2.lastPlayDate = lastPlayDate;
		}
	}

	private void OnApplicationPause(bool pause)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0044: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		VideoAdsManager instance = VideoAdsManager.instance;
		VideoAdProvider currentProvider = instance.currentProvider;
		if (instance.currentProvider != null)
		{
			object obj = 18;
			if (!pause)
			{
				obj = 19;
			}
			object obj2 = obj << 3;
			object obj3 = (object)currentProvider + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S1_v18+BC] (should have been resolved before IL gen)");
		}
		if (pause)
		{
			PostFlurryEventsOnceADay();
			ScheduleLocalNotificationsIfNecessary();
			((HouseKeeper)pause).RegisterAllBundlesDownloaded();
			return;
		}
		string flurryApiKey = AdConstants.FlurryApiKey;
		PlayerInfo instance2 = PlayerInfo.Instance;
		string flurryUserIdHash = instance2.flurryUserIdHash;
		ScreenAdsManager instance3 = ScreenAdsManager.instance;
		if (!instance3._isPresentingInterstitial)
		{
			VideoAdsManager instance4 = VideoAdsManager.instance;
			if (!instance4._isVideoPlaying)
			{
				OfferWallManager instance5 = OfferWallManager.Instance;
				if (instance5.AreOffersAllowedOnDevice())
				{
					OfferWallManager instance6 = OfferWallManager.Instance;
					instance6.GetPendingRewards(bypassTimeLimitsEnforcedByOutside: true);
				}
				TryRestoreSoundOptionAfterLostFocusIfNeeded();
			}
		}
		((HouseKeeper)(object)flurryApiKey).CancellAllLocalNotifications();
		DailyWord instance7 = DailyWord.Instance;
		if (instance7 != null)
		{
			DailyWord instance8 = DailyWord.Instance;
			instance8.DownloadDaily();
		}
		RefreshOnlineSettingsAndInappsIfNeeded();
	}

	private void OnApplicationQuit()
	{
		ScheduleLocalNotificationsIfNecessary();
		RegisterAllBundlesDownloaded();
	}

	private unsafe int GetNumberOfDaysSinceLastPlay()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected VT, but got Unknown
		//IL_005d: Expected Ref, but got VT
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected VT, but got Unknown
		//IL_0078: Expected Ref, but got VT
		//IL_00d1: Expected VT, but got I
		//IL_00d1: Expected VT, but got I
		//IL_0147: Expected F8, but got I4
		//IL_0176: Expected I4, but got F8
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		DateTime now = CDateTime.Now;
		DateTime dateTime = Utils.StringToDateTime(instance._lastPlayDate, now);
		DateTime now2 = CDateTime.Now;
		DateTime dateTime2 = (DateTime)(obj + 16);
		DateTime date = ((DateTime*)dateTime2)->Date;
		DateTime dateTime3 = (DateTime)(obj + 24);
		DateTime date2 = ((DateTime*)dateTime3)->Date;
		bool flag = date > date2;
		bool flag2 = !flag;
		int result = 0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			TimeSpan timeSpan = (DateTime)num - (DateTime)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num2 = 0.0 * 1.1574074074074074E-12;
			double num3 = Math.Abs(num2);
			if (!(num3 < 2147483648.0))
			{
				num2 = -2147483648.0;
			}
			result = (int)num2;
		}
		return result;
	}

	private unsafe bool IsDateToday(string previousDate)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected VT, but got Unknown
		//IL_002f: Expected Ref, but got VT
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected VT, but got Unknown
		//IL_005d: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		DateTime dateTime = Utils.StringToDateTime(previousDate, DateTime.MinValue);
		DateTime dateTime2 = (DateTime)(obj + 8);
		DateTime date = ((DateTime*)dateTime2)->Date;
		DateTime now = CDateTime.Now;
		DateTime dateTime3 = (DateTime)(obj + 8);
		DateTime date2 = ((DateTime*)dateTime3)->Date;
		return date == date2;
	}

	private void CancellAllLocalNotifications()
	{
		LocalNotificationsManager instance = LocalNotificationsManager.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
	}

	private unsafe void ScheduleLocalNotificationsIfNecessary()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected Ref, but got Unknown
		//IL_0027: Expected Obj, but got I4
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0437: Expected Obj, but got VT
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected VT, but got Unknown
		//IL_0457: Expected Ref, but got VT
		//IL_0380: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Ref, but got Unknown
		//IL_0314: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I
		//IL_0504: Expected Obj, but got VT
		//IL_026c: Expected Obj, but got I
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected VT, but got Unknown
		//IL_0524: Expected Ref, but got VT
		//IL_0535: Expected Obj, but got VT
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected VT, but got Unknown
		//IL_0555: Expected Ref, but got VT
		//IL_056b: Expected Obj, but got VT
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected VT, but got Unknown
		//IL_0582: Expected Ref, but got VT
		//IL_029a: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I4
		//IL_081d: Expected VT, but got I
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected VT, but got Unknown
		//IL_0620: Expected Ref, but got VT
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected VT, but got Unknown
		//IL_07c0: Expected Ref, but got VT
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected VT, but got Unknown
		//IL_066b: Expected Ref, but got VT
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected VT, but got Unknown
		//IL_0732: Expected Ref, but got VT
		//IL_0681: Expected Obj, but got VT
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected VT, but got Unknown
		//IL_06a1: Expected Ref, but got VT
		object obj = default;
		HouseKeeper houseKeeper = (HouseKeeper)(obj - 48);
		_ = 0;
		_ = 0;
		_ = 0;
		houseKeeper._consumableHoverboardBrackets = null;
		object obj2 = houseKeeper + 8;
		_ = 0;
		OnlineSettings instance = OnlineSettings.instance;
		bool flag = instance.TryGetValue("enable_local_notifications", out *(string*)(houseKeeper + 44));
		bool flag2 = !flag;
		object obj3 = 0;
		HouseKeeper houseKeeper2 = houseKeeper;
		object obj8;
		HouseKeeper houseKeeper3;
		if (!flag2)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj5 = default;
					object obj4 = obj5 ^ 1;
					obj3 = obj4;
					houseKeeper2 = houseKeeper;
					goto IL_08e9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj6 = default;
			object obj7 = default;
			bool flag3 = obj6 == obj7;
			bool flag4 = !flag3;
			object obj9 = default;
			obj8 = obj9;
			houseKeeper3 = houseKeeper;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj11 = default;
					object obj10 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj12 = default;
						if (obj12 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
							object obj13 = (nint)0 << 2;
							object obj14 = obj2 + obj13;
							obj14 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
							object obj15 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (HouseKeeper)+2C]");
							string text = "Unable to convert '" + (string)0 + "'.";
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
							object obj16 = -1;
							obj3 = 0;
							houseKeeper2 = houseKeeper;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj17 = obj11;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag5 = (nint)0 != 1;
							obj3 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							houseKeeper2 = (HouseKeeper)0;
							if (!flag5)
							{
								goto IL_0322;
							}
						}
						goto IL_08e9;
					}
				}
				goto IL_0322;
			}
			goto IL_03a6;
		}
		goto IL_08e9;
		IL_0822:
		if (Settings.optionReminder)
		{
			object obj18 = obj3 ^ 1;
			if (obj18 != null)
			{
				houseKeeper2.ScheduleDailyVideoNotificationIfNecessary();
				houseKeeper2.ScheduleTopRunNotificationIfNecessary();
			}
		}
		return;
		IL_03a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		obj3 = obj8;
		houseKeeper2 = houseKeeper3;
		goto IL_0904;
		IL_0322:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag6 = (nint)0 == 1;
		object obj19 = default;
		obj8 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		houseKeeper3 = (HouseKeeper)0;
		obj3 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		houseKeeper2 = (HouseKeeper)0;
		if (!flag6)
		{
			goto IL_03a6;
		}
		goto IL_0904;
		IL_080d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ L0_v2 (HouseKeeper)+20]");
		DateTime time = (DateTime)0;
		goto IL_0927;
		IL_0927:
		string title;
		string localNotificationMessage;
		houseKeeper2.ScheduleNotification(time, title, localNotificationMessage);
		goto IL_0822;
		IL_0904:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_08e9;
		IL_08e9:
		PlayerInfo instance2 = PlayerInfo.Instance;
		TimeSpan dailyWordTimeLeft = instance2.dailyWordTimeLeft;
		bool optionReminder = Settings.optionReminder;
		if (obj3 == null && optionReminder && dailyWordTimeLeft > TimeSpan.Zero)
		{
			DateTime today = DateTime.Today;
			houseKeeper2._consumableHoverboardBrackets = (int[])today;
			DateTime dateTime = (DateTime)(houseKeeper2 + 16);
			DateTime dateTime2 = ((DateTime*)dateTime)->AddHours(17.0);
			title = Strings.Get(StringID.LOCAL_NOTIFICATION_TITLE);
			localNotificationMessage = houseKeeper2.GetLocalNotificationMessage();
			DateTime now = CDateTime.Now;
			TimeSpan timeSpan = dateTime2 - now;
			PlayerInfo instance3 = PlayerInfo.Instance;
			int dailyWordDaysInARow = instance3.GetDailyWordDaysInARow(out *(bool*)(houseKeeper2 + 31));
			if (dailyWordDaysInARow >= 1)
			{
				DateTime now2 = CDateTime.Now;
				houseKeeper2._consumableHoverboardBrackets = (int[])now2;
				DateTime dateTime3 = (DateTime)(houseKeeper2 + 16);
				DateTime dateTime4 = ((DateTime*)dateTime3)->Add(dailyWordTimeLeft);
				houseKeeper2._consumableHoverboardBrackets = (int[])dateTime4;
				DateTime dateTime5 = (DateTime)(houseKeeper2 + 16);
				DateTime dateTime6 = ((DateTime*)dateTime5)->AddMinutes(30.0);
				houseKeeper2._consumableHoverboardBrackets = (int[])dateTime6;
				DateTime dateTime7 = (DateTime)(houseKeeper2 + 16);
				int hour = ((DateTime*)dateTime7)->Hour;
				if (hour == 17)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ L0_v2 (HouseKeeper)+1F]");
					if ((nint)0 != 0)
					{
						if (timeSpan > TimeSpan.Zero)
						{
							DateTime dateTime8 = (DateTime)(houseKeeper2 + 32);
							time = ((DateTime*)dateTime8)->AddHours(1.0);
						}
						else
						{
							if (timeSpan > TimeSpan.Zero)
							{
								goto IL_0822;
							}
							DateTime dateTime9 = (DateTime)(houseKeeper2 + 32);
							DateTime dateTime10 = ((DateTime*)dateTime9)->AddDays(1.0);
							houseKeeper2._consumableHoverboardBrackets = (int[])dateTime10;
							DateTime dateTime11 = (DateTime)(houseKeeper2 + 16);
							time = ((DateTime*)dateTime11)->AddHours(1.0);
						}
						goto IL_0927;
					}
					if (timeSpan < TimeSpan.Zero)
					{
						TimeSpan timeSpan2 = TimeSpan.FromHours(1.0);
						TimeSpan timeSpan3 = timeSpan + timeSpan2;
						if (timeSpan3 > TimeSpan.Zero)
						{
							DateTime dateTime12 = (DateTime)(houseKeeper2 + 32);
							time = ((DateTime*)dateTime12)->AddHours(1.0);
							goto IL_0927;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ L0_v2 (HouseKeeper)+1F]");
					if ((nint)0 != 0)
					{
						if (timeSpan > dailyWordTimeLeft)
						{
							goto IL_080d;
						}
						if (timeSpan < dailyWordTimeLeft)
						{
							DateTime dateTime13 = (DateTime)(houseKeeper2 + 32);
							time = ((DateTime*)dateTime13)->AddDays(1.0);
							goto IL_0927;
						}
					}
					else if (timeSpan < dailyWordTimeLeft && timeSpan > TimeSpan.Zero)
					{
						goto IL_080d;
					}
				}
			}
		}
		goto IL_0822;
	}

	private unsafe void ScheduleTopRunNotificationIfNecessary()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04f5: Expected Obj, but got VT
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected VT, but got Unknown
		//IL_0515: Expected Ref, but got VT
		//IL_0029: Expected Obj, but got VT
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected VT, but got Unknown
		//IL_0049: Expected Ref, but got VT
		//IL_0068: Expected Obj, but got VT
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected VT, but got Unknown
		//IL_0088: Expected Ref, but got VT
		//IL_009e: Expected Obj, but got VT
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected VT, but got Unknown
		//IL_00be: Expected Ref, but got VT
		//IL_00dd: Expected Obj, but got VT
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected VT, but got Unknown
		//IL_00fd: Expected Ref, but got VT
		//IL_010e: Expected Obj, but got VT
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected VT, but got Unknown
		//IL_012e: Expected Ref, but got VT
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected VT, but got Unknown
		//IL_01c9: Expected native int or pointer, but got VT
		//IL_01e5: Expected VT, but got I
		//IL_01f6: Expected Obj, but got VT
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected VT, but got Unknown
		//IL_0237: Expected Ref, but got VT
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected VT, but got Unknown
		//IL_034c: Expected Ref, but got VT
		//IL_036b: Expected Obj, but got VT
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected VT, but got Unknown
		//IL_038b: Expected Ref, but got VT
		//IL_0285: Expected VT, but got Obj
		//IL_02e2: Expected VT, but got Obj
		//IL_03d0: Expected VT, but got Obj
		//IL_02b9: Expected VT, but got Obj
		//IL_042d: Expected VT, but got Obj
		//IL_0498: Expected VT, but got Obj
		//IL_0404: Expected VT, but got Obj
		object obj = default;
		HouseKeeper houseKeeper = (HouseKeeper)(obj - 32);
		houseKeeper._scoreBoosterBrackets = null;
		houseKeeper._consumableHoverboardBrackets = null;
		DateTime today = DateTime.Today;
		houseKeeper._consumableHoverboardBrackets = (int[])today;
		DateTime dateTime = (DateTime)(houseKeeper + 16);
		DateTime dateTime2 = ((DateTime*)dateTime)->AddHours(9.0);
		DateTime today2 = DateTime.Today;
		houseKeeper._consumableHoverboardBrackets = (int[])today2;
		DateTime dateTime3 = (DateTime)(houseKeeper + 16);
		DateTime dateTime4 = ((DateTime*)dateTime3)->AddHours(21.0);
		DateTime today3 = DateTime.Today;
		houseKeeper._consumableHoverboardBrackets = (int[])today3;
		DateTime dateTime5 = (DateTime)(houseKeeper + 16);
		DateTime dateTime6 = ((DateTime*)dateTime5)->AddDays(1.0);
		houseKeeper._consumableHoverboardBrackets = (int[])dateTime6;
		DateTime dateTime7 = (DateTime)(houseKeeper + 16);
		DateTime dateTime8 = ((DateTime*)dateTime7)->AddHours(9.0);
		DateTime today4 = DateTime.Today;
		houseKeeper._consumableHoverboardBrackets = (int[])today4;
		DateTime dateTime9 = (DateTime)(houseKeeper + 16);
		DateTime dateTime10 = ((DateTime*)dateTime9)->AddDays(1.0);
		houseKeeper._consumableHoverboardBrackets = (int[])dateTime10;
		DateTime dateTime11 = (DateTime)(houseKeeper + 16);
		DateTime dateTime12 = ((DateTime*)dateTime11)->AddHours(21.0);
		if (TopRunRoot.manager__BackingField == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
		((UnityEngine.Object)houseKeeper).m_CachedPtr = (IntPtr)0;
		TimeSpan timeSpan = (TimeSpan)(houseKeeper + 8);
		*(TimeSpan*)(nint)timeSpan = new TimeSpan(0, 8, 0, 0);
		DateTime dateTime14 = default;
		DateTime dateTime13 = dateTime14 - (TimeSpan)(nint)((UnityEngine.Object)houseKeeper).m_CachedPtr;
		houseKeeper._scoreBoosterBrackets = (int[])dateTime13;
		object[] extraFormatArgs = Array.Empty<object>();
		string message = FormatMessageWithNameIfPossible(StringID.LOCAL_NOTIFICATION_MESSAGE_TOPRUN_ENDING, StringID.LOCAL_NOTIFICATION_MESSAGE_TOPRUN_ENDING_PERSONAL, extraFormatArgs);
		DateTime dateTime15 = (DateTime)(houseKeeper + 24);
		DateTime date = ((DateTime*)dateTime15)->Date;
		DateTime today5 = DateTime.Today;
		DateTime time;
		if (date == today5)
		{
			if (dateTime2 < (DateTime)houseKeeper._scoreBoosterBrackets && (DateTime)houseKeeper._scoreBoosterBrackets < dateTime4)
			{
				goto IL_048b;
			}
			if (!((DateTime)houseKeeper._scoreBoosterBrackets < dateTime2))
			{
				return;
			}
			bool flag = dateTime2 < dateTime14;
			time = dateTime2;
			if (!flag)
			{
				return;
			}
		}
		else
		{
			DateTime dateTime16 = (DateTime)(houseKeeper + 24);
			DateTime date2 = ((DateTime*)dateTime16)->Date;
			DateTime today6 = DateTime.Today;
			houseKeeper._consumableHoverboardBrackets = (int[])today6;
			DateTime dateTime17 = (DateTime)(houseKeeper + 16);
			DateTime dateTime18 = ((DateTime*)dateTime17)->AddDays(1.0);
			if (!(date2 == dateTime18))
			{
				return;
			}
			if (dateTime8 < (DateTime)houseKeeper._scoreBoosterBrackets && (DateTime)houseKeeper._scoreBoosterBrackets < dateTime12)
			{
				goto IL_048b;
			}
			if (!((DateTime)houseKeeper._scoreBoosterBrackets < dateTime8) || !(dateTime8 < dateTime14))
			{
				return;
			}
			time = dateTime8;
		}
		goto IL_04b7;
		IL_048b:
		time = (DateTime)houseKeeper._scoreBoosterBrackets;
		goto IL_04b7;
		IL_04b7:
		string title = Strings.Get(StringID.LOCAL_NOTIFICATION_TITLE);
		houseKeeper.ScheduleNotification(time, title, message);
	}

	private unsafe void ScheduleDailyVideoNotificationIfNecessary()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Expected I, but got VT
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected VT, but got Unknown
		//IL_0053: Expected Ref, but got VT
		//IL_0077: Expected Obj, but got VT
		//IL_0097: Expected Obj, but got VT
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected VT, but got Unknown
		//IL_00d3: Expected Ref, but got VT
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected VT, but got Unknown
		//IL_00f3: Expected Ref, but got VT
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected VT, but got Unknown
		//IL_0148: Expected Ref, but got VT
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected VT, but got Unknown
		//IL_0168: Expected Ref, but got VT
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected VT, but got Unknown
		//IL_01d2: Expected Ref, but got VT
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected VT, but got Unknown
		//IL_01f2: Expected Ref, but got VT
		//IL_02c2: Expected I, but got VT
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected VT, but got Unknown
		//IL_02e2: Expected Ref, but got VT
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected VT, but got Unknown
		//IL_0247: Expected Ref, but got VT
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected VT, but got Unknown
		//IL_0267: Expected Ref, but got VT
		object obj = default;
		HouseKeeper houseKeeper = (HouseKeeper)(obj - 48);
		_ = 0;
		houseKeeper._scoreBoosterBrackets = null;
		houseKeeper._consumableHoverboardBrackets = null;
		VideoAdsManager instance = VideoAdsManager.instance;
		DateTime lastTimeAVideoForKeysWasSeen = instance.GetLastTimeAVideoForKeysWasSeen();
		DateTime now = CDateTime.Now;
		((UnityEngine.Object)houseKeeper).m_CachedPtr = (IntPtr)now;
		DateTime dateTime = (DateTime)(houseKeeper + 8);
		DateTime dateTime2 = ((DateTime*)dateTime)->AddDays(-1.0);
		DateTime now2 = CDateTime.Now;
		houseKeeper._scoreBoosterBrackets = (int[])now2;
		PlayerInfo instance2 = PlayerInfo.Instance;
		houseKeeper._consumableHoverboardBrackets = (int[])instance2._lastTimeAppWasUpdatedOrInstalled;
		object[] extraFormatArgs = Array.Empty<object>();
		string message = FormatMessageWithNameIfPossible(StringID.LOCAL_NOTIFICATION_MESSAGE_DAILY_VIDEO, StringID.LOCAL_NOTIFICATION_MESSAGE_DAILY_VIDEO_PERSONAL, extraFormatArgs);
		DateTime dateTime3 = (DateTime)(houseKeeper + 40);
		DateTime date = ((DateTime*)dateTime3)->Date;
		DateTime dateTime4 = (DateTime)(houseKeeper + 32);
		DateTime date2 = ((DateTime*)dateTime4)->Date;
		DateTime time;
		if (!(date == date2))
		{
			DateTime dateTime5 = (DateTime)(houseKeeper + 16);
			DateTime date3 = ((DateTime*)dateTime5)->Date;
			DateTime dateTime6 = (DateTime)(houseKeeper + 32);
			DateTime date4 = ((DateTime*)dateTime6)->Date;
			if (!(date3 == date4))
			{
				DateTime dateTime7 = (DateTime)(houseKeeper + 40);
				DateTime date5 = ((DateTime*)dateTime7)->Date;
				DateTime dateTime8 = (DateTime)(houseKeeper + 24);
				DateTime date6 = ((DateTime*)dateTime8)->Date;
				if (!(date5 == date6))
				{
					DateTime dateTime9 = (DateTime)(houseKeeper + 16);
					DateTime date7 = ((DateTime*)dateTime9)->Date;
					DateTime dateTime10 = (DateTime)(houseKeeper + 24);
					DateTime date8 = ((DateTime*)dateTime10)->Date;
					if (!(date7 == date8))
					{
						return;
					}
				}
				LocalNotificationsManager instance3 = LocalNotificationsManager.Instance;
				DateTime nextNotificationTimeForVideos = instance3.GetNextNotificationTimeForVideos();
				((UnityEngine.Object)houseKeeper).m_CachedPtr = (IntPtr)nextNotificationTimeForVideos;
				DateTime dateTime11 = (DateTime)(houseKeeper + 8);
				time = ((DateTime*)dateTime11)->AddDays(1.0);
				goto IL_02eb;
			}
		}
		LocalNotificationsManager instance4 = LocalNotificationsManager.Instance;
		time = instance4.GetNextNotificationTimeForVideos();
		goto IL_02eb;
		IL_02eb:
		string title = Strings.Get(StringID.LOCAL_NOTIFICATION_TITLE);
		houseKeeper.ScheduleNotification(time, title, message);
	}

	private unsafe void ScheduleNotification(DateTime time, string title, string message)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected VT, but got Unknown
		//IL_014a: Expected Ref, but got VT
		//IL_0165: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		DateTime now = CDateTime.Now;
		DateTime dateTime = (DateTime)(obj + 8);
		int num = ((DateTime*)dateTime)->CompareTo(now);
		if (num < 1)
		{
			return;
		}
		LocalNotificationsManager instance = LocalNotificationsManager.Instance;
		ILocalNotificationController notificationCtrl = LocalNotificationsManager._notificationCtrl;
		nint num2 = (nint)notificationCtrl;
		object obj3 = 0;
		while (true)
		{
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v32 (Il2CppClass<ILocalNotificationController>)+B2]");
			if (obj4 != null)
			{
				object obj5 = obj3 + 1;
				object obj6 = obj3 << 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v32 (Il2CppClass<ILocalNotificationController>)+58]");
				object obj7 = 0 + obj6;
				bool flag = obj7 != typeof(ILocalNotificationController);
				obj3 = obj5;
				if (!flag)
				{
					object obj8 = obj5 << 3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v32 (Il2CppClass<ILocalNotificationController>)+58]");
					object obj9 = 0 + obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S6_v13+4]");
					object obj10 = (nint)0 << 3;
					object obj11 = num2 + obj10;
					object obj12 = obj11 + 188;
					break;
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F4");
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ S5_v5] (should have been resolved before IL gen)");
	}

	private string GetLocalNotificationMessage()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0135: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo instance = PlayerInfo.Instance;
		DailyWord.DailyWordReward rewardForDay = DailyWord.GetRewardForDay(instance._dailyWordInRow);
		if (obj != null && (nint)obj == 1)
		{
			object[] extraFormatArgs = Array.Empty<object>();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 == 1)
			{
				return FormatMessageWithNameIfPossible(StringID.LOCAL_NOTIFICATION_MESSAGE_SMB, StringID.LOCAL_NOTIFICATION_MESSAGE_SMB_PERSONAL, extraFormatArgs);
			}
			return FormatMessageWithNameIfPossible(StringID.LOCAL_NOTIFICATION_MESSAGE_MB, StringID.LOCAL_NOTIFICATION_MESSAGE_MB_PERSONAL, extraFormatArgs);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	public static string FormatMessageWithNameIfPossible(StringID unidentifiedMessageID, StringID identifiedMessageID, object[] extraFormatArgs)
	{
		//IL_007f: Expected Obj, but got I4
		SocialManager instance = SocialManager.instance;
		if (instance._fbProfile != null || instance._gcProfile != null)
		{
			SocialManager instance2 = SocialManager.instance;
			string localUserName = instance2.localUserName;
			if (!Regex.IsMatch(localUserName, "\\p{IsArabic}|\\p{IsHebrew}|\\p{IsSyriac}|\\p{IsThaana}"))
			{
				object obj = extraFormatArgs.Length + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				SocialManager instance3 = SocialManager.instance;
				string localUserName2 = instance3.localUserName;
				throw new ArrayTypeMismatchException();
			}
		}
		string format = Strings.Get(unidentifiedMessageID);
		return string.Format(format, extraFormatArgs);
	}

	private void OnFriendsConsolidated(bool success)
	{
		SocialManager instance = SocialManager.instance;
		PlayerInfo instance2 = PlayerInfo.Instance;
		bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
		bool flag = !facebookIsLoggedIn;
		bool flag2 = true;
		int relationsMask = 0;
		if (!flag)
		{
			int num = (instance2._hasPayedOutFacebook ? 1 : 0) ^ 1;
			bool hasPayedOutFacebook = instance2._hasPayedOutFacebook;
			flag2 = hasPayedOutFacebook;
			relationsMask = num;
		}
		TriggerActionForFacebookPayout(facebookIsLoggedIn);
		if (instance.gamecenterIsLoggedIn && !instance2._hasPayedOutGameCenter)
		{
			int amountOfCoins = instance2.amountOfCoins;
			int amountOfCoins2 = amountOfCoins + 250;
			instance2.amountOfCoins = amountOfCoins2;
			if (!instance2._hasPayedOutGameCenter)
			{
				instance2._dirty = true;
				instance2._hasPayedOutGameCenter = true;
			}
			UIScreenController.QueueGameCenterPayoutPopup();
		}
		PlayerInfo instance3 = PlayerInfo.Instance;
		instance3.SaveIfDirty();
		SocialManager instance4 = SocialManager.instance;
		instance4.SaveIfDirty();
		if (!flag2)
		{
			instance.AnnounceToFriends(relationsMask);
		}
		((HouseKeeper)(object)instance).RefreshTopRun();
	}

	private static void TriggerActionForFacebookPayout(bool isLoggedInToFacebook)
	{
		Action<bool> action = delegateFacebookPayoutPopupAction;
		if (delegateFacebookPayoutPopupAction != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S0_v10 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
		}
	}

	private static void QueueFacebookPayoutPopupIfNeeded(bool isLoggedInToFacebook)
	{
		if (isLoggedInToFacebook && !FacebookRewardsInfo.HasReceivedAllAvailableRewards())
		{
			UIScreenController.QueueFacebookPayoutPopup();
		}
	}

	public static void SetFacebookPayoutAction(Action<bool> action)
	{
		delegateFacebookPayoutPopupAction = action;
	}

	public static void SetFacebookPayoutActionToDefault()
	{
		throw new ArgumentException();
	}

	public static void SaveAudioOptionsBeforeVideoAds(bool sfxEnabled, bool musicEnabled)
	{
		PlayerPrefs.SetInt("sfxBeforeLostFocus", sfxEnabled ? 1 : 0);
		PlayerPrefs.SetInt("musicBeforeLostFocus", musicEnabled ? 1 : 0);
	}

	public static void DeleteSoundOptionBeforeVideoAds()
	{
		if (PlayerPrefs.HasKey("soundBeforeLostFocus"))
		{
			PlayerPrefs.DeleteKey("soundBeforeLostFocus");
		}
		if (PlayerPrefs.HasKey("sfxBeforeLostFocus"))
		{
			PlayerPrefs.DeleteKey("sfxBeforeLostFocus");
		}
		if (PlayerPrefs.HasKey("musicBeforeLostFocus"))
		{
			PlayerPrefs.DeleteKey("musicBeforeLostFocus");
		}
	}

	public static void TryRestoreSoundOptionAfterLostFocusIfNeeded()
	{
		if (~(IncomingCallManager._isInCall ? 1u : 0u) != 0)
		{
			if (PlayerPrefs.HasKey("sfxBeforeLostFocus"))
			{
				int num = PlayerPrefs.GetInt("sfxBeforeLostFocus", 1);
				bool optionSfx = num != 0;
				Settings.optionSfx = optionSfx;
			}
			if (PlayerPrefs.HasKey("musicBeforeLostFocus"))
			{
				int num2 = PlayerPrefs.GetInt("musicBeforeLostFocus", 1);
				bool optionMusic = num2 != 0;
				Settings.optionMusic = optionMusic;
			}
			DeleteSoundOptionBeforeVideoAds();
		}
	}

	public unsafe static void RefreshOnlineSettingsAndInappsIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Ref, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Ref, but got Unknown
		//IL_004f: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_007d: Invalid comparison between I and F4
		//IL_00ca: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 1163984896;
		_ = 0;
		OnlineSettings instance = OnlineSettings.instance;
		if (instance.TryGetValue("refreshinterval", out *(string*)(obj + 8)))
		{
			ref float result = ref *(float*)(obj + 4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if (float.TryParse((string)0, out result))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				if (!(0f < 10f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
					_ = 0;
				}
				else
				{
					float num = (float)obj + 12f;
					string text = ((float*)num)->ToString();
					string text2 = "OnlineSettings refresh interval too small: " + text;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				string text3 = "Failed to parse Onlinesettings refresh interval from: " + (string)0;
			}
		}
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float num2 = _onlineSettingsLastDownloadTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		float num3 = num2 + 0f;
		if (realtimeSinceStartup > num3)
		{
			float realtimeSinceStartup2 = Time.realtimeSinceStartup;
			_onlineSettingsLastDownloadTime = realtimeSinceStartup2;
			OnlineSettings instance2 = OnlineSettings.instance;
			if (~(instance2._isDownloading ? 1u : 0u) != 0)
			{
				OnlineSettings instance3 = OnlineSettings.instance;
				instance3.DownloadNow();
			}
			if (!InAppManager.isInitialized)
			{
				return;
			}
		}
		else
		{
			if (!InAppManager.isInitialized)
			{
				return;
			}
			InAppManager instance4 = InAppManager.instance;
			if (instance4._productRequestSucceeded)
			{
				return;
			}
		}
		InAppManager instance5 = InAppManager.instance;
		instance5.RequestIAPInfo();
	}

	private void OnOpenedThroughNotification(Notification notification)
	{
		//IL_0066: Expected I, but got Obj
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_00da: Expected I, but got Obj
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		bool flag = notification.userInfo__BackingField == null;
		string type = string.Empty;
		HouseKeeper houseKeeper = null;
		if (!flag)
		{
			object obj = notification.userInfo__BackingField.get_Item("type");
			bool flag2 = obj == null;
			type = string.Empty;
			houseKeeper = null;
			if (!flag2)
			{
				object obj2 = notification.userInfo__BackingField.get_Item("type");
				nint num = (nint)obj2;
				object obj3 = obj2 + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S1_v10 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
				string text = default;
				bool flag3 = text == "job";
				bool flag4 = !flag3;
				type = text;
				houseKeeper = null;
				if (!flag4)
				{
					object obj4 = notification.userInfo__BackingField.get_Item("jobid");
					nint num2 = (nint)obj4;
					object obj5 = obj4 + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ S1_v18 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
					type = text;
					HouseKeeper houseKeeper2 = default;
					houseKeeper = houseKeeper2;
				}
			}
		}
		houseKeeper.LogApplicationWasLaunchedFromNotification(notification.message__BackingField, type, (string)(object)houseKeeper);
	}

	private void LogApplicationWasLaunchedFromNotification(string message, string type = "", string jobID = "")
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
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

	public HouseKeeper()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E.E74AFD7B316AA40881110EDF51DF81D821BC4D672861D882198ED60E0EED7058));
		_dailyKeysBrackets = (int[])array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array2 = default;
		RuntimeHelpers.InitializeArray(array2, __ldtoken(_003CPrivateImplementationDetails_003E.E74AFD7B316AA40881110EDF51DF81D821BC4D672861D882198ED60E0EED7058));
		_consumableHoverboardBrackets = (int[])array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array3 = default;
		RuntimeHelpers.InitializeArray(array3, __ldtoken(_003CPrivateImplementationDetails_003E.E74AFD7B316AA40881110EDF51DF81D821BC4D672861D882198ED60E0EED7058));
		_headstartBrackets = (int[])array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array4 = default;
		RuntimeHelpers.InitializeArray(array4, __ldtoken(_003CPrivateImplementationDetails_003E.E74AFD7B316AA40881110EDF51DF81D821BC4D672861D882198ED60E0EED7058));
		_scoreBoosterBrackets = (int[])array4;
		base._002Ector();
	}

	static HouseKeeper()
	{
		throw new ArgumentException();
	}
}
