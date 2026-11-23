using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Plugins.DeviceUtility;
using Newtonsoft.Json.Linq;
using SYBO.Subway;
using SYBO.Subway.Info;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameOverScreen : RunStartScreen
{
	public enum ActiveTabState
	{
		leaderBoard,
		topRun
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__28_0;

		public static UnityAction _003C_003E9__28_1;

		public static UnityAction _003C_003E9__28_2;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CAwake_003Eb__28_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("GameOverScreen");
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.PushScreen("FrontUI");
		}

		internal void _003CAwake_003Eb__28_1()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance._Screen = ShopScreen.Screen.Upgrade;
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.PushPopup("ShopScreen");
			UIScreenController instance3 = UIScreenController.Instance;
			instance3.ActivateAnchors(active: false);
		}

		internal void _003CAwake_003Eb__28_2()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("GameOverScreen");
			SSEventsManagerController instance2 = SSEventsManagerController.instance;
			instance2.RestoreBoardAfterEventIfNeeded();
			Game instance3 = Game.Instance;
			instance3.StartNewGame(duel: false);
			UIScreenController instance4 = UIScreenController.Instance;
			instance4.PushScreen("IngameUI");
			SaveMeManager.ResetSaveMeForNewRun();
		}
	}

	private sealed class _003CScrollOnTop_003Ed__33(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameOverScreen _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0093: Expected I, but got Obj
			//IL_00bc: Expected I, but got Obj
			//IL_00ce: Expected I, but got Obj
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Canvas.ForceUpdateCanvases();
					ScrollRect componentInChildren = _003C_003E4__this.GetComponentInChildren<ScrollRect>();
					VerticalLayoutGroup component = componentInChildren.m_Content.GetComponent<VerticalLayoutGroup>();
					nint num = (nint)component;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S1_v13 (Il2CppClass<UnityEngine.UI.VerticalLayoutGroup>)+1A4] (should have been resolved before IL gen)");
					ContentSizeFitter component2 = componentInChildren.m_Content.GetComponent<ContentSizeFitter>();
					nint num2 = (nint)component2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S1_v18 (Il2CppClass<UnityEngine.UI.ContentSizeFitter>)+15C] (should have been resolved before IL gen)");
					nint num3 = (nint)componentInChildren;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ S3_v3 (Il2CppClass<UnityEngine.UI.ScrollRect>)+244] (should have been resolved before IL gen)");
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 0.15f;
			object obj = default;
			_003C_003E2__current = obj;
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

	private sealed class _003CCountUpCoins_003Ed__61(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameOverScreen _003C_003E4__this;

		private float _003CcountTime_003E5__2;

		private float _003CcountFactor_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Expected I4, but got Unknown
			//IL_03f6: Expected I, but got Obj
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected I4, but got Unknown
			//IL_0174: Expected I, but got Obj
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected I4, but got Unknown
			//IL_01b3: Expected I, but got Obj
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected I4, but got Unknown
			//IL_01ed: Expected I, but got Obj
			//IL_02f2: Expected F8, but got I4
			//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c0: Expected I4, but got Unknown
			//IL_04d5: Expected I, but got Obj
			//IL_033e: Expected F8, but got I4
			//IL_05de: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e3: Expected I4, but got Unknown
			//IL_05f8: Expected I, but got Obj
			//IL_0716: Expected Ref, but got F4
			//IL_0722: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			GameOverScreen gameOverScreen = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						if (_003CcountFactor_003E5__3 < 1f)
						{
							goto IL_0218;
						}
						ScoreCounterSoundPlayer scoreCounterSoundPlayer = gameOverScreen.scoreCounterSoundPlayer;
						scoreCounterSoundPlayer.playScore = false;
						TMP_Text scoreLabel = gameOverScreen.scoreLabel;
						int num = gameOverScreen + 92;
						string text = ((int*)num)->ToString();
						nint num2 = (nint)scoreLabel;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ S2_v69 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
						TMP_Text coinboxLabel = gameOverScreen.coinboxLabel;
						int num3 = gameOverScreen + 100;
						string text2 = ((int*)num3)->ToString();
						nint num4 = (nint)coinboxLabel;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v188 @ S2_v74 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
						TMP_Text collectedCoinLabel = gameOverScreen.collectedCoinLabel;
						int num5 = gameOverScreen + 108;
						string text3 = ((int*)num5)->ToString();
						nint num6 = (nint)collectedCoinLabel;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ S2_v79 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
						gameOverScreen.countingUpCoins = false;
						gameOverScreen.CountUpCompleted();
					}
					bool result = default;
					return result;
				}
				_003CcountFactor_003E5__3 = 0f;
				_003C_003E1__state = -1;
				goto IL_0218;
			}
			_003C_003E1__state = -1;
			float num7 = (float)gameOverScreen.collectedCoinsTo / 100f;
			float num8 = Math.Min(num7, 1f);
			bool flag = num7 < 0f;
			float num9 = 0f;
			if (!flag)
			{
				num9 = num8;
			}
			float num10 = num9 * 1.7f;
			float num11 = num10 + 0.3f;
			_003CcountTime_003E5__2 = num11;
			gameOverScreen.countingUpCoins = true;
			gameOverScreen.UpdateDoubleCoinLabels((string)(object)this);
			TMP_Text collectedCoinLabel2 = gameOverScreen.collectedCoinLabel;
			int num12 = gameOverScreen + 104;
			string text4 = ((int*)num12)->ToString();
			nint num13 = (nint)collectedCoinLabel2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v181 @ S2_v12 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			_ = 1.2f;
			object obj3 = default;
			_003C_003E2__current = obj3;
			_003C_003E1__state = 1;
			return true;
			IL_0218:
			gameOverScreen.scoreCounterSoundPlayer.PlayCoinSound(_003CcountFactor_003E5__3);
			float deltaTime = Time.deltaTime;
			float num14 = deltaTime / _003CcountTime_003E5__2;
			float num15 = (_003CcountFactor_003E5__3 += num14);
			TMP_Text scoreLabel2 = gameOverScreen.scoreLabel;
			float num16 = Math.Min(num15, 1f);
			bool flag2 = num15 < 0f;
			float num17 = 0f;
			if (!flag2)
			{
				num17 = num16;
			}
			float num18 = num17 * -2f;
			float num19 = num18 * num17;
			float num20 = num19 * num17;
			float num21 = num17 * 3f;
			float num22 = num21 * num17;
			float num23 = num20 + num22;
			float num24 = (float)gameOverScreen.scoreTo * num23;
			float num25 = 1f - num23;
			float num26 = (float)gameOverScreen.scoreFrom * num25;
			float num27 = num24 + num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double value = default;
			double num28 = Math.Abs(value);
			if (!(num28 < 2147483648.0))
			{
				value = -2147483648.0;
			}
			int num29 = obj + 12;
			string text5 = ((int*)num29)->ToString();
			nint num30 = (nint)scoreLabel2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v267 @ S2_v32 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text coinboxLabel2 = gameOverScreen.coinboxLabel;
			float num31 = Math.Min(_003CcountFactor_003E5__3, 1f);
			bool flag3 = _003CcountFactor_003E5__3 < 0f;
			float num32 = 0f;
			if (!flag3)
			{
				num32 = num31;
			}
			float num33 = num32 * -2f;
			float num34 = num33 * num32;
			float num35 = num34 * num32;
			float num36 = num32 * 3f;
			float num37 = num36 * num32;
			float num38 = num35 + num37;
			float num39 = (float)gameOverScreen.coinboxTo * num38;
			float num40 = 1f - num38;
			float num41 = (float)gameOverScreen.coinboxFrom * num40;
			float num42 = num39 + num41;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double value2 = default;
			double num43 = Math.Abs(value2);
			if (!(num43 < 2147483648.0))
			{
				value2 = -2147483648.0;
			}
			int num44 = obj + 12;
			string text6 = ((int*)num44)->ToString();
			nint num45 = (nint)coinboxLabel2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v339 @ S2_v49 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text collectedCoinLabel3 = gameOverScreen.collectedCoinLabel;
			float num46 = Math.Min(_003CcountFactor_003E5__3, 1f);
			bool flag4 = _003CcountFactor_003E5__3 < 0f;
			float num47 = 0f;
			if (!flag4)
			{
				num47 = num46;
			}
			float num48 = num47 * -2f;
			float num49 = num48 * num47;
			float num50 = num49 * num47;
			float num51 = num47 * 3f;
			float num52 = num51 * num47;
			float num53 = num50 + num52;
			float num54 = (float)gameOverScreen.collectedCoinsTo * num53;
			float num55 = 1f - num53;
			float num56 = (float)gameOverScreen.collectedCoinsFrom * num55;
			float num57 = num54 + num56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			float num58 = (float)obj + 8f;
			string text7 = ((float*)num58)->ToString();
			nint num59 = (nint)collectedCoinLabel3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v389 @ S2_v63 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			_003C_003E2__current = null;
			_003C_003E1__state = 2;
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

	private Button HomeButton;

	private Button BoostButton;

	private Button PlayButton;

	private Button DoubleCoinButton;

	private TMP_Text scoreLabel;

	private Transform contentList;

	private TMP_Text collectedCoinLabel;

	private TMP_Text coinboxLabel;

	private Friend[] _friends;

	private int scoreFrom;

	private int scoreTo;

	private int coinboxFrom;

	private int coinboxTo;

	private int collectedCoinsFrom;

	private int collectedCoinsTo;

	private bool countingUpCoins;

	private ScoreCounterSoundPlayer scoreCounterSoundPlayer;

	private int _counter;

	private DateTime _lastCountUpTimeStamp;

	private GameObject _characterDayParticleSystem;

	private Color darkBlue;

	private Color yellow;

	private bool hasBeenSetupAfterAGame;

	public static Action OnGameOverScreenShown;

	public static Action onTabClicked;

	private GameObject Notification;

	private UIPopupIn UIPopupIn;

	public void GameActive(bool value)
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value);
	}

	private unsafe void Awake()
	{
		UIScreenController instance = UIScreenController.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(GameOverScreen.OnLastPopupClosed));
		instance.OnLastPopupClosed += action;
		Button homeButton = HomeButton;
		bool flag = _003C_003Ec._003C_003E9__28_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__28_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__28_0));
			_003C_003Ec._003C_003E9__28_0 = unityAction;
			call = unityAction;
		}
		homeButton.m_OnClick.AddListener(call);
		Button boostButton = BoostButton;
		bool flag3 = _003C_003Ec._003C_003E9__28_1 == null;
		bool flag4 = !flag3;
		UnityAction call2 = _003C_003Ec._003C_003E9__28_1;
		if (!flag4)
		{
			UnityAction unityAction2 = default;
			unityAction2._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__28_1));
			_003C_003Ec._003C_003E9__28_1 = unityAction2;
			call2 = unityAction2;
		}
		boostButton.m_OnClick.AddListener(call2);
		Button playButton = PlayButton;
		bool flag5 = _003C_003Ec._003C_003E9__28_2 == null;
		bool flag6 = !flag5;
		UnityAction call3 = _003C_003Ec._003C_003E9__28_2;
		if (!flag6)
		{
			UnityAction unityAction3 = default;
			unityAction3._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__28_2));
			_003C_003Ec._003C_003E9__28_2 = unityAction3;
			call3 = unityAction3;
		}
		playButton.m_OnClick.AddListener(call3);
		UnityAction unityAction4 = default;
		unityAction4._002Ector(this, (nint)__ldftn(GameOverScreen._003CAwake_003Eb__28_3));
		OutConplete.AddListener(unityAction4);
	}

	private void OnEnable()
	{
		ShowPopUp();
	}

	public override void Init()
	{
		//IL_000a: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<GameOverScreen>)+104] (should have been resolved before IL gen)");
		ScoreCounterSoundPlayer component = GetComponent<ScoreCounterSoundPlayer>();
		scoreCounterSoundPlayer = component;
	}

	private void SetNewDataList()
	{
		throw new ArgumentException();
	}

	public override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = default;
		GameOverScreen gameOverScreen = (GameOverScreen)(obj - 32);
		gameOverScreen._footerHandler = null;
		gameOverScreen._selectedFooterButton = 0;
		base.Show();
		UIScreenController instance = UIScreenController.Instance;
		throw new ArgumentException();
	}

	public IEnumerator ScrollOnTop()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
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
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.IN);
	}

	public void HidePupUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.OUT);
	}

	private void HideEventStarsIfNecessary()
	{
		UIScreenController instance = UIScreenController.Instance;
		if (instance.isShowingPopup && _characterDayParticleSystem.activeSelf)
		{
			_characterDayParticleSystem.SetActive(value: false);
		}
	}

	private void OnLastPopupClosed()
	{
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			UIModelController instance = UIModelController.Instance;
			instance.ActivateGameOverModel();
			SSEventsManagerController instance2 = SSEventsManagerController.instance;
			IEventManager activeEventManager = instance2.GetActiveEventManager(SSEventType.CharacterDay);
			if (activeEventManager != null)
			{
				bool active = ShouldEnableCharacterDayEventElements(activeEventManager);
				_characterDayParticleSystem.SetActive(active);
			}
		}
	}

	private bool ShouldEnableCharacterDayEventElements(IEventManager activeEventManager)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = activeEventManager == null;
		bool result = false;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			bool flag2 = (nint)obj3 != 7;
			result = false;
			if (!flag2)
			{
				object obj4 = obj + 15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
				object obj5 = default;
				bool flag3 = (nint)obj5 == instance._currentCharacter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
				bool flag4 = (nint)0 != 0;
				bool flag5 = flag3 & flag4;
				result = flag5;
			}
		}
		return result;
	}

	private void SetUpEventUIElements()
	{
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		bool active;
		if (((GameOverScreen)null).ShouldEnableCharacterDayEventElements(activeEventManager))
		{
			UIScreenController instance2 = UIScreenController.Instance;
			bool isShowingPopup = instance2.isShowingPopup;
			active = (byte)((isShowingPopup ? 1u : 0u) ^ 1u) != 0;
		}
		else
		{
			active = false;
		}
		_characterDayParticleSystem.SetActive(active);
	}

	public bool IsCountingUpCoins()
	{
		return countingUpCoins;
	}

	public override void Hide()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		base.Hide();
		UIScreenController instance = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private void OnCharacterSelected()
	{
		UIModelController instance = UIModelController.Instance;
		instance.ActivateGameOverModel();
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void InAppManager_OnPurchaseSuccess(string productId, bool wasRestored)
	{
		UpdateDoubleCoinLabels((string)(object)this);
		UpdateUpgradeSticker((string)(object)this);
	}

	public unsafe void SetupBeforeMysteryBox()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected I4, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		hasBeenSetupAfterAGame = true;
		TMP_Text tMP_Text = scoreLabel;
		GameStats instance = GameStats.Instance;
		_ = instance._score;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		string text2 = string.Empty + text;
		nint num2 = (nint)tMP_Text;
		object obj3 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		GameStats instance2 = GameStats.Instance;
		scoreFrom = instance2._score;
	}

	public void SetupAfterMysteryBox()
	{
		//IL_003b: Expected I4, but got Obj
		if (~(hasBeenSetupAfterAGame ? 1u : 0u) == 0)
		{
			GameStats instance = GameStats.Instance;
			int num = (collectedCoinsTo = instance.CoinsCollected);
			collectedCoinsFrom = 0;
			int num2 = GameStats.CoinToScoreConversion((int)this);
			int num3 = scoreFrom + num2;
			scoreTo = num3;
			PlayerInfo instance2 = PlayerInfo.Instance;
			int num4 = num + (coinboxFrom = instance2.amountOfCoins);
			coinboxTo = num4;
			PlayerInfo instance3 = PlayerInfo.Instance;
			instance3.amountOfCoins = coinboxTo;
			MissionsManager instance4 = MissionsManager.Instance;
			instance4.PlayerDidThis(MissionTarget.GetExactlyAmountOfCoins, num);
			IEnumerator routine = CountUpCoins();
			Coroutine coroutine = StartCoroutine(routine);
			hasBeenSetupAfterAGame = false;
			HideEventStarsIfNecessary();
		}
	}

	private void PushNewHighScoreCelebrationScreen(int newHighSchore)
	{
		//IL_0077: Expected I4, but got I8
		CelebrationReward celebrationReward = default;
		celebrationReward._002Ector();
		celebrationReward.CelebrationRewardOrigin = CelebrationRewardOrigin.NewHighScore;
		PlayerInfo instance = PlayerInfo.Instance;
		celebrationReward.characterType = (Characters.CharacterType)instance._currentCharacter;
		PlayerInfo instance2 = PlayerInfo.Instance;
		int currentThemeIndex = instance2.currentThemeIndex;
		celebrationReward.characterOutfitIndex = currentThemeIndex;
		RewardManager.AddRewardToUnlock(celebrationReward);
	}

	private void UpdateUpgradeSticker(string data = "")
	{
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager(SSEventType.BiggerJackpot);
	}

	private void OnCoinsChanged()
	{
		((GameOverScreen)null).UpdateUpgradeSticker((string)null);
	}

	private void OnMissionComplete(string message)
	{
		((GameOverScreen)null).UpdateUpgradeSticker((string)null);
	}

	private void ReloadFriends()
	{
	}

	private void CountUpCompleted()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected VT, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 80;
		PlayerInfo instance = PlayerInfo.Instance;
		int num = instance._ratingAskCounter + 1;
		if (instance._ratingAskCounter != num)
		{
			instance._dirty = true;
			instance._ratingAskCounter = num;
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		object obj5;
		if (!instance2._neverAskForRating)
		{
			PlayerInfo instance3 = PlayerInfo.Instance;
			if (instance3._ratingAskCounter >= 1)
			{
				PlayerInfo instance4 = PlayerInfo.Instance;
				int num2 = instance4._ratingAskCounter / 15;
				object obj3 = num2 * 15;
				object obj4 = instance4._ratingAskCounter - obj3;
				if (obj4 == null)
				{
					PlayerInfo instance5 = PlayerInfo.Instance;
					string bundleVersion = DeviceUtility.GetBundleVersion();
					if (instance5._lastVersionRated != bundleVersion)
					{
						string ratingURL = Globals.RatingURL;
						if (ratingURL != null)
						{
							obj5 = 0;
							if (ratingURL._stringLength != 0)
							{
								goto IL_02b4;
							}
						}
						obj5 = 1;
						goto IL_02b4;
					}
				}
			}
		}
		goto IL_0173;
		IL_02b4:
		if (obj5 == null)
		{
			UIScreenController instance6 = UIScreenController.Instance;
			instance6.QueuePopup("RatingPopup");
		}
		goto IL_0173;
		IL_0173:
		UIScreenController instance7 = UIScreenController.Instance;
		if (!instance7.isShowingPopup && IsAllowedToShowInterstitial())
		{
			ScreenAdsManager instance8 = ScreenAdsManager.instance;
			Location location = InterstitialLocations.GetLocation(LocationID.gameover_after_countup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			object obj6 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Location location2 = (Location)(obj + 8);
			instance8.EnableShowLocation(location2, enable: true);
		}
	}

	public unsafe bool IsAllowedToShowInterstitial()
	{
		//IL_000e: Expected F8, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected I4, but got Unknown
		//IL_0188: Expected Obj, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		OnlineSettings instance = OnlineSettings.instance;
		uint value = instance.GetValue("interstitial_game_over_counter_expire_time", 72000u);
		TimeSpan timeSpan = TimeSpan.FromSeconds((int)value);
		DateTime t = _lastCountUpTimeStamp + timeSpan;
		DateTime now = CDateTime.Now;
		int num = DateTime.Compare(now, t);
		if (num >= 1)
		{
			_counter = 0;
		}
		int num2 = this + 120;
		string text = ((int*)num2)->ToString();
		OnlineSettings instance2 = OnlineSettings.instance;
		uint value2 = instance2.GetValue("interstitial_game_over_total_show_slots", 5u);
		OnlineSettings instance3 = OnlineSettings.instance;
		uint num3 = instance3.GetValue("interstitial_game_over_active_show_slot", 1u);
		DateTime now2 = CDateTime.Now;
		_lastCountUpTimeStamp = now2;
		int counter = _counter + 1;
		_counter = counter;
		if ((int)value2 <= (int)num3)
		{
			num3 = 1u;
		}
		int num4 = _counter / (int)value2;
		object obj = num4 * (int)value2;
		object obj2 = _counter - obj;
		return (int)num3 == (nint)obj2;
	}

	private void OnPopupShown(string popupName)
	{
		HideEventStarsIfNecessary();
		DisableInterstitialShowLocation();
	}

	private void DisableInterstitialShowLocation()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		Debug.Log("DisableInterstitialShowLocation");
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		if (topScreenName != null && topScreenName == "GameoverUI")
		{
			ScreenAdsManager instance2 = ScreenAdsManager.instance;
			Location location = InterstitialLocations.GetLocation(LocationID.gameover_after_countup);
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

	public void FacebookLoggedIn()
	{
	}

	private void UpdateDoubleCoinLabels(string data = "")
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		PlayerInfo instance = PlayerInfo.Instance;
		if (~(instance._hasDoubleCoinsUpgrade ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (GameOverScreen)+A4]");
			_ = 0;
			obj = yellow;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		}
	}

	public unsafe void StopCoinsCountUp()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I4, but got Unknown
		//IL_0085: Expected I, but got Obj
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected I4, but got Unknown
		//IL_0101: Expected I, but got Obj
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected I4, but got Unknown
		//IL_015a: Expected I, but got Obj
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(countingUpCoins ? 1u : 0u) == 0)
		{
			IEnumerator routine = CountUpCoins();
			StopCoroutine(routine);
			ScoreCounterSoundPlayer scoreCounterSoundPlayer = this.scoreCounterSoundPlayer;
			scoreCounterSoundPlayer.playScore = false;
			TMP_Text tMP_Text = scoreLabel;
			int num = this + 92;
			string text = ((int*)num)->ToString();
			string text2 = string.Empty + text;
			nint num2 = (nint)tMP_Text;
			object obj3 = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S2_v8 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text2 = coinboxLabel;
			PlayerInfo instance = PlayerInfo.Instance;
			int amountOfCoins = instance.amountOfCoins;
			int num3 = obj + 12;
			string text3 = ((int*)num3)->ToString();
			string text4 = string.Empty + text3;
			nint num4 = (nint)tMP_Text2;
			object obj4 = tMP_Text2 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S2_v16 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text3 = collectedCoinLabel;
			int num5 = this + 108;
			string text5 = ((int*)num5)->ToString();
			string text6 = string.Empty + text5;
			nint num6 = (nint)tMP_Text3;
			object obj5 = tMP_Text3 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v121 @ S2_v23 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			countingUpCoins = false;
			CountUpCompleted();
		}
	}

	private IEnumerator CountUpCoins()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public GameOverScreen()
	{
		//IL_001e: Expected VT, but got I8
		//IL_0037: Expected VT, but got I8
		_ = 4575657222436077761L;
		yellow = (Color)4566614701407993856L;
		_ = 4575657222459532967L;
		darkBlue = (Color)4479015274249498801L;
		_lastCountUpTimeStamp = DateTime.MinValue;
		base._002Ector();
	}

	private void _003CAwake_003Eb__28_3()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<GameOverScreen>)+EC] (should have been resolved before IL gen)");
	}

	private void _003CSetNewDataList_003Eb__31_0(LeaderboardData data)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_0024: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected I4, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		PlayerInfo instance = PlayerInfo.Instance;
		string userName = instance.UserName;
		Results[] results = data.results;
		object obj = 0;
		object obj2 = 0;
		object obj6 = default;
		while ((nint)obj2 < results.Length)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)results + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v19+10]");
			object obj5 = 0;
			obj6++;
			if ((nint)obj6 <= 10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v20+18]");
				JObject jObject = JObject.Parse((string)0);
				JToken jToken = jObject.get_Item("name");
				string text = (string)jToken;
				JToken jToken2 = jObject.get_Item("country");
				string text2 = (string)jToken2;
				UIScreenController instance2 = UIScreenController.Instance;
				LeaderboardPopup leaderboardPopup = instance2.LeaderboardPopup;
				LeaderboardCell leaderboardCell = UnityEngine.Object.Instantiate(leaderboardPopup.LeaderboardCellPrefab, contentList);
				bool flag = userName == text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v20+10]");
				int rank = (int)((nint)0 + (nint)1);
				object obj7 = obj ^ 1;
				bool me = (byte)((flag & obj7) ? 1 : 0) != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v20+14]");
				leaderboardCell.UpdateCell(rank, text, 0, me);
				object obj8 = obj | flag;
				object obj9 = obj2 + 1;
				obj = obj8;
				obj2 = obj9;
				continue;
			}
			break;
		}
	}

	private void _003CShow_003Eb__32_0(string data)
	{
		SetNewDataList();
	}
}
