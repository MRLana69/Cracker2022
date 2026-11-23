using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Monetization.Offerwall;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Subway;
using TopRun;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FrontScreen : RunStartScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__24_0;

		public static UnityAction _003C_003E9__24_1;

		public static UnityAction _003C_003E9__24_2;

		public static UnityAction _003C_003E9__24_3;

		public static UnityAction _003C_003E9__24_4;

		public static UnityAction _003C_003E9__24_5;

		public static UnityAction _003C_003E9__24_6;

		public static UnityAction _003C_003E9__24_7;

		public static UnityAction _003C_003E9__24_8;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CStart_003Eb__24_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.PushPopup("SettingsPopup");
		}

		internal void _003CStart_003Eb__24_1()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance._Screen = ShopScreen.Screen.Boost;
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.CloseActivePopups("FrontUI");
			UIScreenController instance3 = UIScreenController.Instance;
			instance3.PushPopup("ShopScreen");
		}

		internal void _003CStart_003Eb__24_2()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("FrontUI");
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.PushPopup("MeScreen");
		}

		internal void _003CStart_003Eb__24_3()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.PushPopup("DailyChallengePopup");
		}

		internal void _003CStart_003Eb__24_4()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.PushPopup("HoverboardPopup");
		}

		internal void _003CStart_003Eb__24_5()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.PushPopup("MissionPopup");
		}

		internal void _003CStart_003Eb__24_6()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.PushPopup("ItemmHuntPopup");
		}

		internal void _003CStart_003Eb__24_7()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.PushPopup("LeaderboardPopup");
		}

		internal void _003CStart_003Eb__24_8()
		{
			SSEventsManagerController instance = SSEventsManagerController.instance;
			instance.RestoreBoardAfterEventIfNeeded();
			Game instance2 = Game.Instance;
			instance2.StartNewGame(duel: false);
			UIScreenController instance3 = UIScreenController.Instance;
			instance3.CloseActivePopups("FrontUI");
			UIScreenController instance4 = UIScreenController.Instance;
			instance4.PushScreen("IngameUI");
			SaveMeManager.ResetSaveMeForNewRun();
		}
	}

	private sealed class _003CAnimateOfferWallPopupButton_003Ed__53(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject offerWallButton;

		public float delay;

		private Vector3 _003CendPosition_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Expected VT, but got Unknown
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Expected Obj, but got Unknown
			//IL_00b4: Expected VT, but got I
			//IL_00e5: Expected F4, but got I
			//IL_00e0: Expected native int or pointer, but got VT
			//IL_0117: Expected F4, but got I
			//IL_0112: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj + -64);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FrontScreen+<AnimateOfferWallPopupButton>d__53)+20]");
					_ = 0;
					_ = _003CendPosition_003E5__2;
					Vector3 pos = vector + 16;
					SpringPosition springPosition = SpringPosition.Begin(offerWallButton, pos, 5f);
					springPosition.ignoreTimeScale = true;
					object obj2 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				}
			}
			else
			{
				_003C_003E1__state = -1;
				if (!offerWallButton.activeSelf)
				{
					NGUITools.SetActive(offerWallButton, state: true);
					Transform transform = offerWallButton.transform;
					Vector3 localPosition = transform.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_003CendPosition_003E5__2 = (Vector3)0;
					Transform transform2 = offerWallButton.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					float num = 0f + -60f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					((Vector3*)(nint)vector)->x = 0f;
					transform2.localPosition = vector;
					_ = delay;
					object obj3 = default;
					_003C_003E2__current = obj3;
					_003C_003E1__state = 1;
				}
			}
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

	private sealed class _003CAnimateLimitedPopupButton_003Ed__54(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject limitedButton;

		public float delay;

		private Vector3 _003CendPosition_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Expected VT, but got Unknown
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Expected Obj, but got Unknown
			//IL_00b4: Expected VT, but got I
			//IL_00e5: Expected F4, but got I
			//IL_00e0: Expected native int or pointer, but got VT
			//IL_0117: Expected F4, but got I
			//IL_0112: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj + -64);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FrontScreen+<AnimateLimitedPopupButton>d__54)+20]");
					_ = 0;
					_ = _003CendPosition_003E5__2;
					Vector3 pos = vector + 16;
					SpringPosition springPosition = SpringPosition.Begin(limitedButton, pos, 5f);
					springPosition.ignoreTimeScale = true;
					object obj2 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				}
			}
			else
			{
				_003C_003E1__state = -1;
				if (!limitedButton.activeSelf)
				{
					NGUITools.SetActive(limitedButton, state: true);
					Transform transform = limitedButton.transform;
					Vector3 localPosition = transform.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_003CendPosition_003E5__2 = (Vector3)0;
					Transform transform2 = limitedButton.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					float num = 0f + -60f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					((Vector3*)(nint)vector)->x = 0f;
					transform2.localPosition = vector;
					_ = delay;
					object obj3 = default;
					_003C_003E2__current = obj3;
					_003C_003E1__state = 1;
				}
			}
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

	private sealed class _003CDelayTheActivationOfTheStartButton_003Ed__55(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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
			//IL_005b: Expected I4, but got I8
			int num;
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				num = -1;
				if (!flag)
				{
					goto IL_0078;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				num = 1;
			}
			_003C_003E1__state = num;
			goto IL_0078;
			IL_0078:
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

	private Button SettingButton;

	private Button ShopButton;

	private Button PlayButton;

	private Button MeButton;

	private Button TopRunButton;

	private Button DailyChallengeButton;

	private Button HoverboardButton;

	private Button MissionButton;

	private Button EventButton;

	private bool _hasTriggeredTweens;

	private GameObject[] gameobjectsToTween;

	private static bool buttonsHaveTweened;

	private bool _isEventActive;

	private WeeklyHuntManager.WeeklyHuntPeriodData _currentWeekHuntPrize;

	private int _huntCollectedItems;

	private int _huntMaxItems;

	private bool _isApplicationResuming;

	private Transform topLeft;

	private Transform topRight;

	private Transform bottomCenter;

	private UIPopupIn UIPopupIn;

	public static bool canEnableSound
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	private unsafe void Start()
	{
		Button settingButton = SettingButton;
		bool flag = _003C_003Ec._003C_003E9__24_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__24_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__24_0));
			_003C_003Ec._003C_003E9__24_0 = unityAction;
			call = unityAction;
		}
		settingButton.m_OnClick.AddListener(call);
		Button shopButton = ShopButton;
		bool flag3 = _003C_003Ec._003C_003E9__24_1 == null;
		bool flag4 = !flag3;
		UnityAction call2 = _003C_003Ec._003C_003E9__24_1;
		if (!flag4)
		{
			UnityAction unityAction2 = default;
			unityAction2._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__24_1));
			_003C_003Ec._003C_003E9__24_1 = unityAction2;
			call2 = unityAction2;
		}
		shopButton.m_OnClick.AddListener(call2);
		Button meButton = MeButton;
		bool flag5 = _003C_003Ec._003C_003E9__24_2 == null;
		bool flag6 = !flag5;
		UnityAction call3 = _003C_003Ec._003C_003E9__24_2;
		if (!flag6)
		{
			UnityAction unityAction3 = default;
			unityAction3._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__24_2));
			_003C_003Ec._003C_003E9__24_2 = unityAction3;
			call3 = unityAction3;
		}
		meButton.m_OnClick.AddListener(call3);
		Button dailyChallengeButton = DailyChallengeButton;
		bool flag7 = _003C_003Ec._003C_003E9__24_3 == null;
		bool flag8 = !flag7;
		UnityAction call4 = _003C_003Ec._003C_003E9__24_3;
		if (!flag8)
		{
			UnityAction unityAction4 = default;
			unityAction4._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__24_3));
			_003C_003Ec._003C_003E9__24_3 = unityAction4;
			call4 = unityAction4;
		}
		dailyChallengeButton.m_OnClick.AddListener(call4);
		Button hoverboardButton = HoverboardButton;
		bool flag9 = _003C_003Ec._003C_003E9__24_4 == null;
		bool flag10 = !flag9;
		UnityAction call5 = _003C_003Ec._003C_003E9__24_4;
		if (!flag10)
		{
			UnityAction unityAction5 = default;
			unityAction5._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__24_4));
			_003C_003Ec._003C_003E9__24_4 = unityAction5;
			call5 = unityAction5;
		}
		hoverboardButton.m_OnClick.AddListener(call5);
		Button missionButton = MissionButton;
		bool flag11 = _003C_003Ec._003C_003E9__24_5 == null;
		bool flag12 = !flag11;
		UnityAction call6 = _003C_003Ec._003C_003E9__24_5;
		if (!flag12)
		{
			UnityAction unityAction6 = default;
			unityAction6._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__24_5));
			_003C_003Ec._003C_003E9__24_5 = unityAction6;
			call6 = unityAction6;
		}
		missionButton.m_OnClick.AddListener(call6);
		Button eventButton = EventButton;
		bool flag13 = _003C_003Ec._003C_003E9__24_6 == null;
		bool flag14 = !flag13;
		UnityAction call7 = _003C_003Ec._003C_003E9__24_6;
		if (!flag14)
		{
			UnityAction unityAction7 = default;
			unityAction7._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__24_6));
			_003C_003Ec._003C_003E9__24_6 = unityAction7;
			call7 = unityAction7;
		}
		eventButton.m_OnClick.AddListener(call7);
		Button topRunButton = TopRunButton;
		bool flag15 = _003C_003Ec._003C_003E9__24_7 == null;
		bool flag16 = !flag15;
		UnityAction call8 = _003C_003Ec._003C_003E9__24_7;
		if (!flag16)
		{
			UnityAction unityAction8 = default;
			unityAction8._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__24_7));
			_003C_003Ec._003C_003E9__24_7 = unityAction8;
			call8 = unityAction8;
		}
		topRunButton.m_OnClick.AddListener(call8);
		Button playButton = PlayButton;
		bool flag17 = _003C_003Ec._003C_003E9__24_8 == null;
		bool flag18 = !flag17;
		UnityAction call9 = _003C_003Ec._003C_003E9__24_8;
		if (!flag18)
		{
			UnityAction unityAction9 = default;
			unityAction9._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__24_8));
			_003C_003Ec._003C_003E9__24_8 = unityAction9;
			call9 = unityAction9;
		}
		playButton.m_OnClick.AddListener(call9);
		UnityAction unityAction10 = default;
		unityAction10._002Ector(this, (nint)__ldftn(FrontScreen._003CStart_003Eb__24_9));
		OutConplete.AddListener(unityAction10);
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<FrontScreen>)+104] (should have been resolved before IL gen)");
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
		UIScreenController instance = UIScreenController.Instance;
		instance.screen_game = SCREEN_GAME.MENU;
	}

	private void GetComponent()
	{
		if (UIPopupIn == null)
		{
			UIPopupIn componentInChildren = GetComponentInChildren<UIPopupIn>();
			UIPopupIn = componentInChildren;
		}
	}

	private void ShowPopUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.IN_FRONT);
	}

	public void HidePupUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.OUT_FRONT);
	}

	private void OnEnable()
	{
		bool flag = ShouldDisplayChangeLog();
		PlayerInfo instance = PlayerInfo.Instance;
		UIScreenController instance2 = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private unsafe void OnDisable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FrontScreen.CheckTheEventsButtonState));
		SSEventsManagerController.OnSSEventChangedHandler -= action;
		Action action2 = default;
		action2._002Ector(null, (nint)(delegate*<void>)(&SSEventsPopup.ShowIfNeeded));
		SSEventsManagerController.OnSSEventChangedHandler -= action2;
		UIScreenController instance = UIScreenController.Instance;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(FrontScreen.ReEnableInterstitialShowLocation));
		instance.OnLastPopupClosed -= action3;
		UIScreenController instance2 = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private void ActivateScreenElements()
	{
		GameObject gameObject = topLeft.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = topRight.gameObject;
		gameObject2.SetActive(value: true);
		GameObject gameObject3 = bottomCenter.gameObject;
		gameObject3.SetActive(value: true);
		CheckTheEventsButtonState();
		CheckOfferWallButtonState();
	}

	private void TournamentChanged(object sender, TournamentChangedEventArgs eventArg)
	{
		TopRunRewardHelper.RefreshPendingResults();
	}

	private static bool ShouldDisplayChangeLog()
	{
		string bundleVersion = DeviceUtility.GetBundleVersion();
		string value = FormatVersionNumber(bundleVersion);
		string oldVersionNumber = PlayerPrefs.GetString("lastSeenBundleVersionKey", string.Empty);
		string text = FormatVersionNumber(oldVersionNumber);
		bool flag = text.Equals(value);
		bool result = false;
		if (!flag)
		{
			bool flag2 = text != string.Empty;
			result = false;
			if (flag2)
			{
				PlayerInfo instance = PlayerInfo.Instance;
				if (~(instance._isFreshInstall ? 1u : 0u) == 0)
				{
					instance._dirty = true;
					instance._isFreshInstall = false;
				}
				result = true;
			}
		}
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.MetroPlayerARM && text == string.Empty)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			if (~(instance2._dataExists ? 1u : 0u) == 0)
			{
				PlayerInfo instance3 = PlayerInfo.Instance;
				if (~(instance3._isFreshInstall ? 1u : 0u) == 0)
				{
					instance3._dirty = true;
					instance3._isFreshInstall = false;
				}
				result = true;
			}
		}
		if (!text.Equals(value))
		{
			string bundleVersion2 = DeviceUtility.GetBundleVersion();
			PlayerPrefs.SetString("lastSeenBundleVersionKey", bundleVersion2);
		}
		return result;
	}

	private static string FormatVersionNumber(string oldVersionNumber)
	{
		string[] array = oldVersionNumber.Split('.');
		if (array.Length >= 2)
		{
			return array[0] + "." + array[1];
		}
		return oldVersionNumber;
	}

	private unsafe void HookUpToEvents()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FrontScreen.CheckTheEventsButtonState));
		SSEventsManagerController.OnSSEventChangedHandler += action;
		Action action2 = default;
		action2._002Ector(null, (nint)(delegate*<void>)(&SSEventsPopup.ShowIfNeeded));
		SSEventsManagerController.OnSSEventChangedHandler += action2;
		UIScreenController instance = UIScreenController.Instance;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(FrontScreen.ReEnableInterstitialShowLocation));
		instance.OnLastPopupClosed += action3;
		UIScreenController instance2 = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private void OnPopupClosed(string popupName)
	{
		if (popupName == "WelcomePopup")
		{
			EnableScreenElements();
		}
		else if (popupName == "CoinsUI_earn")
		{
			((FrontScreen)(object)popupName).CheckOfferWallButtonState();
		}
		else if (!(popupName != "LimitedCharacterPopup") || !(popupName != "LimitedBoardPopup") || popupName == "DebugSettingsPopup")
		{
			((FrontScreen)(object)popupName).CheckLimitedCharacterButtonState();
			((FrontScreen)(object)popupName).CheckLimitedBoardButtonState(0f);
		}
	}

	private void EnableScreenElements()
	{
		HookUpToEvents();
		UpdateHuntLabel();
		CheckTheEventsButtonState();
		CheckOfferWallButtonState();
		CheckLimitedCharacterButtonState();
		CheckLimitedBoardButtonState();
		TweenAndHandleUI();
	}

	private void DisableInterstitialShowLocation(string popupName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		if (topScreenName != null && topScreenName == "FrontUI")
		{
			ScreenAdsManager instance2 = ScreenAdsManager.instance;
			Location location = InterstitialLocations.GetLocation(LocationID.front_screen_after_tweens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			object obj3 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Location location2 = (Location)(obj + 8);
			instance2.EnableShowLocation(location2, enable: false);
		}
	}

	private void ReEnableInterstitialShowLocation()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		if (topScreenName != null && topScreenName == "FrontUI")
		{
			ScreenAdsManager instance2 = ScreenAdsManager.instance;
			Location location = InterstitialLocations.GetLocation(LocationID.front_screen_after_tweens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			object obj3 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Location location2 = (Location)(obj + 8);
			instance2.EnableShowLocation(location2, enable: true);
		}
	}

	private void UpdateHuntLabel()
	{
		SynchronizeData();
	}

	private void SynchronizeData()
	{
		WeeklyHuntManager.PrizePeriodId activePeriode = WeeklyHuntManager.GetActivePeriode();
		WeeklyHuntManager.WeeklyHuntPeriodData prizeDataForPeriod = WeeklyHuntManager.GetPrizeDataForPeriod(activePeriode);
		_currentWeekHuntPrize = prizeDataForPeriod;
		WeeklyHuntManager.WeeklyHuntPeriodData currentWeekHuntPrize = _currentWeekHuntPrize;
		_huntMaxItems = currentWeekHuntPrize.itemsToColect;
		_huntCollectedItems = currentWeekHuntPrize.itemsCollected;
		bool flag = currentWeekHuntPrize.itemsCollected >= 0;
		bool flag2 = !flag;
		int huntCollectedItems = 0;
		if (!flag2)
		{
			bool flag3 = currentWeekHuntPrize.itemsCollected <= currentWeekHuntPrize.itemsToColect;
			huntCollectedItems = currentWeekHuntPrize.itemsToColect;
			if (flag3)
			{
				return;
			}
		}
		_huntCollectedItems = huntCollectedItems;
	}

	public static bool HaveButtonsTweened()
	{
		return buttonsHaveTweened;
	}

	private void TweenAndHandleUI()
	{
		if (~(_hasTriggeredTweens ? 1u : 0u) != 0)
		{
			Invoke("TriggerTween", 0.5f);
			_hasTriggeredTweens = true;
		}
		else
		{
			HandlePopups();
		}
		CheckForDiscountButton();
		RewardManager.PayoutNonMysteryBoxRewards();
	}

	private void CheckTheEventsButtonState()
	{
		_isEventActive = false;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		bool isEventActive;
		if (~(Globals.DEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER ? 1u : 0u) != 0)
		{
			bool flag = activeEventManager == null;
			isEventActive = false;
			if (!flag)
			{
				PlayerInfo instance2 = PlayerInfo.Instance;
				bool isTutorialCompleted = instance2._isTutorialCompleted;
				isEventActive = isTutorialCompleted;
			}
		}
		else
		{
			bool flag2 = activeEventManager != null;
			isEventActive = flag2;
		}
		_isEventActive = isEventActive;
	}

	private void OnOfferWallOffersRecieved(List<IDisplayableOffer> list, bool b)
	{
		((FrontScreen)null).CheckOfferWallButtonState();
	}

	private void CheckOfferWallButtonState()
	{
		List<IDisplayableOffer> currentOffers;
		do
		{
			OnlineSettings instance = OnlineSettings.instance;
			if (!instance.GetValue("kiloo_offerwall_popup_enabled", defaultValue: true))
			{
				break;
			}
			OfferWallManager instance2 = OfferWallManager.Instance;
			if (!instance2.AreOffersAllowedOnDevice())
			{
				break;
			}
			if (Application.platform == RuntimePlatform.OSXEditor)
			{
				RuntimePlatform platform = Application.platform;
				if (platform == RuntimePlatform.WindowsEditor)
				{
					break;
				}
			}
			OfferWallManager instance3 = OfferWallManager.Instance;
			if (instance3 != null)
			{
				OfferWallManager instance4 = OfferWallManager.Instance;
				currentOffers = instance4.CurrentOffers;
				continue;
			}
			break;
		}
		while (currentOffers._size >= 1);
	}

	private void CheckLimitedCharacterButtonState()
	{
		LimitedCharacterPopupManager instance2;
		do
		{
			OfferWallManager instance = OfferWallManager.Instance;
			if (!instance.AreOffersAllowedOnDevice())
			{
				instance2 = LimitedCharacterPopupManager.Instance;
				continue;
			}
			break;
		}
		while (instance2.ShouldButtonBeVisible());
	}

	private void CheckLimitedBoardButtonState()
	{
		((FrontScreen)null).CheckLimitedBoardButtonState(0f);
	}

	private void CheckLimitedBoardButtonState(float activationDelay)
	{
		LimitedBoardPopupManager instance2;
		do
		{
			OfferWallManager instance = OfferWallManager.Instance;
			if (!instance.AreOffersAllowedOnDevice())
			{
				instance2 = LimitedBoardPopupManager.Instance;
				continue;
			}
			break;
		}
		while (instance2.ShouldButtonBeVisible());
	}

	private void AnimateVideoButton()
	{
	}

	private IEnumerator AnimateOfferWallPopupButton(GameObject offerWallButton, float delay)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateLimitedPopupButton(GameObject limitedButton, float delay)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator DelayTheActivationOfTheStartButton()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void TriggerTween()
	{
		CheckTheEventsButtonState();
		CheckForDiscountButton();
		if (~(_isActive ? 1u : 0u) == 0)
		{
			IEnumerator routine = DelayTheActivationOfTheStartButton();
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private void TweensHaveFinishedAnimating()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00b6: Expected I4, but got Obj
		//IL_00c8: Expected I4, but got Obj
		//IL_00da: Expected I4, but got Obj
		//IL_00ec: Expected I, but got Obj
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected VT, but got Unknown
		object obj = default;
		FrontScreen frontScreen = (FrontScreen)(obj - 80);
		buttonsHaveTweened = true;
		frontScreen.CheckOfferWallButtonState();
		frontScreen.CheckLimitedCharacterButtonState();
		frontScreen.CheckLimitedBoardButtonState();
		frontScreen.HandlePopups();
		UIScreenController instance = UIScreenController.Instance;
		if (!instance.isShowingPopup)
		{
			ScreenAdsManager instance2 = ScreenAdsManager.instance;
			Location location = InterstitialLocations.GetLocation(LocationID.front_screen_after_tweens);
			((UIScreen)frontScreen).parentScreen__BackingField = (string)(object)frontScreen.DailyChallengeButton;
			((UIScreen)frontScreen).addScreen = (byte)(int)(frontScreen.InComplete = (UnityEvent)(frontScreen - -64)) != 0;
			frontScreen._selectedFooterButton = (int)frontScreen.DailyChallengeButton;
			((UIScreen)frontScreen)._footerInited = (byte)(int)frontScreen.ShopButton != 0;
			((UnityEngine.Object)frontScreen).m_CachedPtr = (IntPtr)frontScreen.ShopButton;
			Location location2 = (Location)(frontScreen + 8);
			instance2.EnableShowLocation(location2, enable: true);
		}
	}

	private void CheckForDiscountButton()
	{
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager(SSEventType.BiggerJackpot);
	}

	private void _PauseApplication(bool paused)
	{
		if (!paused)
		{
			_isApplicationResuming = true;
			AssetBundleManager instance = AssetBundleManager.Instance;
			instance.ResumeAssetBundlesDownload();
		}
	}

	private void OnApplicationPause(bool paused)
	{
		_PauseApplication(paused);
	}

	private void OnApplicationFocus(bool focus)
	{
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.WindowsEditor && Application.platform != RuntimePlatform.OSXEditor)
		{
			bool paused = (byte)((focus ? 1u : 0u) ^ 1u) != 0;
			_PauseApplication(paused);
		}
	}

	private void LateUpdate()
	{
		if (~(_isApplicationResuming ? 1u : 0u) == 0)
		{
			_isApplicationResuming = false;
			UpdateHuntLabel();
			CheckForDiscountButton();
		}
	}

	private void HandlePopups()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.RequeueDelayedPopups();
		CodeVoucherPopup.ShowOnFrontScreenIfNeeded();
		UpdateApp.ShowIfNeeded();
		SSEventsPopup.ShowIfNeeded();
		FacebookWeeklyGiftPopup.ShowIfNeeded();
	}

	public void EventsButtonClicked()
	{
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			UIScreenController instance2 = UIScreenController.Instance;
			object obj = default;
			bool flag = (nint)obj == 8;
			object popupName = "CharacterNameEventPopup";
			if (!flag)
			{
				popupName = "EventsPopup";
			}
			instance2.QueuePopup((string)popupName);
		}
	}

	public void OfferWallButtonClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.QueuePopup("CoinsUI_earn");
	}

	public void LimitedCharacterButtonClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.QueuePopup("LimitedCharacterPopup");
	}

	public void LimitedBoardButtonClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.QueuePopup("LimitedBoardPopup");
	}

	private void _003CStart_003Eb__24_9()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<FrontScreen>)+EC] (should have been resolved before IL gen)");
	}
}
