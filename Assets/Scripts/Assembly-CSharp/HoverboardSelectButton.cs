using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HoverboardSelectButton : MonoBehaviour
{
	public enum ButtonStates
	{
		Buy,
		Select,
		Trial,
		BuyWithInapp,
		Unselect
	}

	public enum StickerColors
	{
		Gift,
		Discount
	}

	private TMP_Text _labelSelected;

	private TMP_Text _labelUnselect;

	private TMP_Text _labelTry;

	private TMP_Text _labelBuyWithInapp;

	private TMP_Text _priceLabel;

	private TMP_Text _progressLabel;

	private Image _tokenSprite;

	private TMP_Text _expirePriceLabel;

	private Image _keySprite;

	private Image _coinSprite;

	private Image _lockedKeySprite;

	private Image _lockedCoinSprite;

	private TMP_Text _notAvailableThemeAmount;

	private TMP_Text _notAvailableThemeFeedback;

	private GameObject _buy;

	private GameObject _select;

	private GameObject _trial;

	private GameObject _buyWithInapp;

	private GameObject _unselect;

	private GameObject _lockedBoardGraphics;

	private GameObject _lockedThemeGraphics;

	private Hoverboards.BoardType _boardType;

	private int _currentThemeIndex;

	private bool _purchaseInProgress;

	private bool _hasInited;

	private bool _shouldShowEventIndicatorsForTryBoardsEvent;

	private bool _shouldShowEventIndicatorsForBuyLimitedBoardsEvent;

	private HoverboardManager.ScreenContext _screenContext;

	private ButtonStates _activeState;

	private Action m_OnClickSelectedButton;

	private Button Click;

	private Sprite _select_img;

	private Sprite _selected_img;

	public event Action OnClickSelectedButton
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 116;
			Delegate obj2 = this.m_OnClickSelectedButton;
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
			object obj = this + 116;
			Delegate obj2 = this.m_OnClickSelectedButton;
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

	public void UpdateCurrentThemeIndex()
	{
		HoverboardManager instance = HoverboardManager.Instance;
		int currentlyShownHoverboardTheme = instance.GetCurrentlyShownHoverboardTheme(_screenContext);
		_currentThemeIndex = currentlyShownHoverboardTheme;
	}

	public void SetStickerColors(StickerColors stickerType)
	{
	}

	public unsafe void UpdateSticker(Hoverboards.BoardType boardType, int themeIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02f7: Expected Obj, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected VT, but got Unknown
		//IL_008f: Expected Ref, but got VT
		//IL_0181: Expected Obj, but got I4
		//IL_01d4: Expected Obj, but got VT
		//IL_0215: Expected Obj, but got VT
		object obj = default;
		HoverboardSelectButton hoverboardSelectButton = (HoverboardSelectButton)(obj - 16);
		((UnityEngine.Object)hoverboardSelectButton).m_CachedPtr = (IntPtr)0;
		hoverboardSelectButton = (HoverboardSelectButton)0;
		Hoverboards.Board board = Hoverboards.boardData.get_Item(boardType);
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = instance.IsHoverboardUnlocked(boardType);
		HoverboardManager instance2 = HoverboardManager.Instance;
		Hoverboards.BoardType? eventBoardType = instance2.GetEventBoardType();
		bool flag2 = ((UnityEngine.Object)hoverboardSelectButton).m_CachedPtr == (IntPtr)0;
		bool flag3 = true;
		if (!flag2)
		{
			Hoverboards.BoardType? boardType2 = (Hoverboards.BoardType?)(object)(hoverboardSelectButton + 8);
			Hoverboards.BoardType value = ((Hoverboards.BoardType?*)boardType2)->Value;
			bool flag4 = value != boardType;
			flag3 = flag4;
		}
		if (themeIndex == 0)
		{
			if (flag)
			{
				return;
			}
			if (!flag3)
			{
				SSEventsManagerController instance3 = SSEventsManagerController.instance;
				if (!instance3.HasTheCurrentEventBeenTried())
				{
					return;
				}
			}
			if (hoverboardSelectButton.IsBoardOrThemeFree(boardType))
			{
				return;
			}
			if (~(board.hasOnlineTimeLimit ? 1u : 0u) != 0)
			{
				bool flag5 = WeeklyHuntManager.IsBoardAwardedInCurrentPeriod(boardType);
				object obj2 = flag5 & flag3;
				if (obj2 == null)
				{
					return;
				}
			}
			else if (!flag3)
			{
				return;
			}
			PlayerInfo instance4 = PlayerInfo.Instance;
			TimeSpan timeSpan = instance4.BoardExpirationTimespan(boardType);
			hoverboardSelectButton = (HoverboardSelectButton)timeSpan;
			if (WeeklyHuntManager.IsBoardAwardedInCurrentPeriod(boardType))
			{
				TimeSpan timeLeftForActivePeriod = WeeklyHuntManager.GetTimeLeftForActivePeriod();
				hoverboardSelectButton = (HoverboardSelectButton)timeLeftForActivePeriod;
			}
			return;
		}
		int themeIndex2 = themeIndex - 1;
		if (hoverboardSelectButton.IsBoardOrThemeFree(boardType, themeIndex2))
		{
			PlayerInfo instance5 = PlayerInfo.Instance;
			if (instance5.IsHoverboardUnlocked(boardType))
			{
				PlayerInfo instance6 = PlayerInfo.Instance;
				int tIndex = themeIndex - 1;
				HoverboardThemes.ThemeIdentifier themeIdentifier = HoverboardThemes.GetThemeIdentifier(boardType, tIndex);
				bool flag6 = instance6._hoverboardCustomizationData.IsThemeOwned(boardType, themeIdentifier);
			}
		}
	}

	private bool IsBoardOrThemeFree(Hoverboards.BoardType boardType, int themeIndex = -1)
	{
		//IL_011c: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		HoverboardThemes.HoverboardTheme hoverboardTheme;
		bool result;
		Hoverboards.Board board;
		if (themeIndex >= 0)
		{
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(boardType);
			hoverboardTheme = list.get_Item(themeIndex);
			object obj = hoverboardTheme.unlockType - 2;
			if (hoverboardTheme.unlockType == PurchaseData.UnlockType.Coins)
			{
				goto IL_00d9;
			}
			bool flag = (nint)obj == 1;
			result = false;
			if (!flag)
			{
				bool flag2 = (nint)obj == 2;
				result = false;
				if (!flag2)
				{
					if ((nint)obj == 3)
					{
						goto IL_00d9;
					}
					result = false;
				}
			}
		}
		else
		{
			board = Hoverboards.boardData.get_Item(boardType);
			object obj2 = board.unlockType - 2;
			if (board.unlockType == PurchaseData.UnlockType.Coins)
			{
				goto IL_01b5;
			}
			bool flag3 = (nint)obj2 == 1;
			result = false;
			if (!flag3)
			{
				bool flag4 = (nint)obj2 == 2;
				result = false;
				if (!flag4)
				{
					if ((nint)obj2 == 3)
					{
						goto IL_01b5;
					}
					result = false;
				}
			}
		}
		goto IL_0201;
		IL_01b5:
		bool flag5 = board.price == 0;
		result = flag5;
		goto IL_0201;
		IL_0201:
		return result;
		IL_00d9:
		return hoverboardTheme.price == 0;
	}

	private void SetButtonState(ButtonStates state)
	{
		_activeState = state;
		bool active = state == ButtonStates.Buy;
		_buy.SetActive(active);
		bool active2 = state == ButtonStates.Select;
		_select.SetActive(active2);
		bool active3 = state == ButtonStates.Trial;
		_trial.SetActive(active3);
		bool active4 = state == ButtonStates.BuyWithInapp;
		_buyWithInapp.SetActive(active4);
		bool active5 = state == ButtonStates.Unselect;
		_unselect.SetActive(active5);
	}

	private void DisableStickers()
	{
	}

	private void EnableFreeSticker()
	{
	}

	private void UpdateStickerLabel(float positionY, int fontSize)
	{
	}

	private unsafe void OnEnable()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(HoverboardSelectButton.OnChangedCurrentlyShownHoverboardModel));
		SSEventsManagerController.OnSSEventStartedHandler += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(HoverboardSelectButton.OnChangedCurrentlyShownHoverboardModel));
		SSEventsManagerController.OnSSEventFinishedHandler += action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(HoverboardSelectButton.OnChangedCurrentlyShownHoverboardModel));
		UIScreenController.OnApplicationResumed += action3;
		Action action4 = default;
		action4._002Ector(this, (nint)__ldftn(HoverboardSelectButton.OnChangedCurrentlyShownHoverboardModel));
		UIModelController.OnChangedCurrentlyShownHoverboard += action4;
		Button click = Click;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(HoverboardSelectButton._003COnEnable_003Eb__45_0));
		click.m_OnClick.AddListener(unityAction);
	}

	private unsafe void OnDisable()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(HoverboardSelectButton.OnChangedCurrentlyShownHoverboardModel));
		SSEventsManagerController.OnSSEventStartedHandler -= action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(HoverboardSelectButton.OnChangedCurrentlyShownHoverboardModel));
		SSEventsManagerController.OnSSEventFinishedHandler -= action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(HoverboardSelectButton.OnChangedCurrentlyShownHoverboardModel));
		UIScreenController.OnApplicationResumed -= action3;
		Action action4 = default;
		action4._002Ector(this, (nint)__ldftn(HoverboardSelectButton.OnChangedCurrentlyShownHoverboardModel));
		UIModelController.OnChangedCurrentlyShownHoverboard -= action4;
	}

	public void InitButton(HoverboardManager.ScreenContext newContext)
	{
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			_screenContext = newContext;
			OnChangedCurrentlyShownHoverboardModel();
			_hasInited = true;
		}
	}

	private bool CurrentlyShownBoardMatchesTrySpecialPowerBoard()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager(SSEventType.SpecialPowerBoard);
		if (activeEventManager != null)
		{
			_ = 0;
			object obj3 = obj + 15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
			object obj4 = default;
			if ((nint)0 != 0)
			{
				return (nint)obj4 == (nint)_boardType;
			}
		}
		bool result = default;
		return result;
	}

	private bool CurrentlyShownBoardMatchesLimitedExpiredBoardEvent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			if ((nint)obj3 == 6)
			{
				_ = 0;
				object obj4 = obj + 15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
				if ((nint)0 != 0)
				{
					HoverboardManager instance2 = HoverboardManager.Instance;
					Hoverboards.BoardType currentlyShownHoverboard = instance2.GetCurrentlyShownHoverboard(_screenContext);
					object obj5 = default;
					return (nint)currentlyShownHoverboard == (nint)obj5;
				}
			}
		}
		bool result = default;
		return result;
	}

	public void OnChangedCurrentlyShownHoverboardModel()
	{
		HoverboardManager instance = HoverboardManager.Instance;
		Hoverboards.BoardType currentlyShownHoverboard = instance.GetCurrentlyShownHoverboard(_screenContext);
		if (currentlyShownHoverboard != _boardType)
		{
			_currentThemeIndex = 0;
			BoardScreenManager instance2 = BoardScreenManager.Instance;
			instance2.shouldResetThemeSelection__BackingField = true;
		}
		_boardType = currentlyShownHoverboard;
		Hoverboards.Board board = Hoverboards.boardData.get_Item(_boardType);
		bool shouldShowEventIndicatorsForTryBoardsEvent = CurrentlyShownBoardMatchesTrySpecialPowerBoard();
		_shouldShowEventIndicatorsForTryBoardsEvent = shouldShowEventIndicatorsForTryBoardsEvent;
		bool shouldShowEventIndicatorsForBuyLimitedBoardsEvent = CurrentlyShownBoardMatchesLimitedExpiredBoardEvent();
		_shouldShowEventIndicatorsForBuyLimitedBoardsEvent = shouldShowEventIndicatorsForBuyLimitedBoardsEvent;
		if (_currentThemeIndex == 0)
		{
			PlayerInfo instance3 = PlayerInfo.Instance;
			if (instance3.IsHoverboardUnlocked(_boardType) || board.unlockType == PurchaseData.UnlockType.AlwaysUnlocked || (board.unlockType != PurchaseData.UnlockType.Tokens && board.unlockType != PurchaseData.UnlockType.Coins && board.unlockType == PurchaseData.UnlockType.WeeklyHunt))
			{
				if (_shouldShowEventIndicatorsForTryBoardsEvent)
				{
					goto IL_0180;
				}
				if (!_shouldShowEventIndicatorsForBuyLimitedBoardsEvent)
				{
					SetButtonState(ButtonStates.Select);
					SetSelectHoverboardUI();
					return;
				}
			}
			else
			{
				if (~(_shouldShowEventIndicatorsForTryBoardsEvent ? 1u : 0u) == 0)
				{
					goto IL_0180;
				}
				if (!_shouldShowEventIndicatorsForBuyLimitedBoardsEvent && board.unlockType != PurchaseData.UnlockType.InApp)
				{
					SetButtonState(ButtonStates.Buy);
					SetBuyHoverboardUI();
					return;
				}
			}
			SetButtonState(ButtonStates.BuyWithInapp);
			BuyHoverboardWithInapp();
			return;
		}
		int tIndex = _currentThemeIndex - 1;
		HoverboardThemes.ThemeIdentifier themeIdentifier = HoverboardThemes.GetThemeIdentifier(_boardType, tIndex);
		PlayerInfo instance4 = PlayerInfo.Instance;
		PlayerInfo instance5 = PlayerInfo.Instance;
		if (instance5.IsHoverboardUnlocked(_boardType))
		{
			if (instance4._hoverboardCustomizationData.IsThemeOwned(_boardType, themeIdentifier))
			{
				if (instance4._hoverboardCustomizationData.IsThemeActive(_boardType, themeIdentifier))
				{
					SetButtonState(ButtonStates.Unselect);
					SetUnselectBoardThemeUI();
				}
				else
				{
					SetButtonState(ButtonStates.Select);
					SetSelectBoardThemeUI();
				}
			}
			else
			{
				SetButtonState(ButtonStates.Buy);
				SetBuyBoardThemeUI();
			}
		}
		else
		{
			SetNeedsToUnlockBoardUI();
		}
		return;
		IL_0180:
		SetButtonState(ButtonStates.Trial);
		SetTryHoverboardUI();
	}

	private void SetTryHoverboardUI()
	{
		//IL_00ec: Expected F8, but got I8
		SSEventsManagerController instance = SSEventsManagerController.instance;
		if (!instance.HasTheCurrentEventBeenTried())
		{
			goto IL_006e;
		}
		if (~(_shouldShowEventIndicatorsForTryBoardsEvent ? 1u : 0u) == 0)
		{
			HoverboardManager instance2 = HoverboardManager.Instance;
			Hoverboards.BoardType currentlyShownHoverboard = instance2.GetCurrentlyShownHoverboard(_screenContext);
			PlayerInfo instance3 = PlayerInfo.Instance;
			if (currentlyShownHoverboard != instance3._currentHoverboard)
			{
				goto IL_006e;
			}
		}
		SetToSelectedBlueState();
		goto IL_0084;
		IL_006e:
		SetToSelectGreenState();
		goto IL_0084;
		IL_0084:
		GameObject gameObject = _coinSprite.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = _keySprite.gameObject;
		gameObject2.SetActive(value: false);
		SSEventsManagerController instance4 = SSEventsManagerController.instance;
		long num = instance4.TimeLeftInSeconds();
		TimeSpan timeLeft = TimeSpan.FromSeconds(num);
		EnableLimitedOffer(timeLeft);
	}

	private void SetSelectHoverboardUI()
	{
		DisableLimitedOffer();
		PlayerInfo instance = PlayerInfo.Instance;
		if (instance._currentHoverboard == _boardType)
		{
			SetToSelectedBlueState();
			return;
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		if (!instance2.IsHoverboardUnlocked(_boardType))
		{
			Hoverboards.Board board = Hoverboards.boardData.get_Item(_boardType);
			if (board.unlockType != PurchaseData.UnlockType.AlwaysUnlocked)
			{
				SetToSelectUnavailableState();
				return;
			}
		}
		SetToSelectGreenState();
	}

	private unsafe void SetBuyHoverboardUI()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected I4, but got Unknown
		//IL_009c: Expected I, but got Obj
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00d8: Expected I, but got Obj
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		SetToSelectGreenState();
		Hoverboards.Board board = Hoverboards.boardData.get_Item(_boardType);
		GameObject gameObject = _coinSprite.gameObject;
		bool active = board.unlockType == PurchaseData.UnlockType.Coins;
		gameObject.SetActive(active);
		GameObject gameObject2 = _keySprite.gameObject;
		bool active2 = board.unlockType == PurchaseData.UnlockType.Keys;
		gameObject2.SetActive(active2);
		TMP_Text priceLabel = _priceLabel;
		int num = board + 16;
		string text = ((int*)num)->ToString();
		nint num2 = (nint)priceLabel;
		object obj = priceLabel + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text expirePriceLabel = _expirePriceLabel;
		string text2 = ((int*)num)->ToString();
		nint num3 = (nint)expirePriceLabel;
		object obj2 = expirePriceLabel + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S2_v15 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		DisableLimitedOffer();
	}

	private unsafe void SetBuyBoardThemeUI()
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected I4, but got Unknown
		//IL_00db: Expected I, but got Obj
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_0112: Expected I, but got Obj
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		SetToSelectGreenState();
		if (_currentThemeIndex != 0)
		{
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(_boardType);
			int index = _currentThemeIndex - 1;
			HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index);
			GameObject gameObject = _coinSprite.gameObject;
			bool active = hoverboardTheme.unlockType == PurchaseData.UnlockType.Coins;
			gameObject.SetActive(active);
			GameObject gameObject2 = _keySprite.gameObject;
			bool active2 = hoverboardTheme.unlockType == PurchaseData.UnlockType.Keys;
			gameObject2.SetActive(active2);
			TMP_Text priceLabel = _priceLabel;
			int num = hoverboardTheme + 8;
			string text = ((int*)num)->ToString();
			nint num2 = (nint)priceLabel;
			object obj = priceLabel + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S2_v14 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text expirePriceLabel = _expirePriceLabel;
			string text2 = ((int*)num)->ToString();
			nint num3 = (nint)expirePriceLabel;
			object obj2 = expirePriceLabel + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S2_v19 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			DisableLimitedOffer();
		}
	}

	private void SetSelectBoardThemeUI()
	{
		DisableLimitedOffer();
		SetToSelectGreenState();
	}

	private void SetUnselectBoardThemeUI()
	{
		DisableLimitedOffer();
		SetToUnselectBlueState();
	}

	private void SetNeedsToUnlockBoardUI()
	{
		DisableLimitedOffer();
		SetToNeedsUnlockGreyState();
	}

	private void BuyHoverboardWithInapp()
	{
		//IL_004b: Expected F8, but got I8
		//IL_0083: Expected I, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		SetToSelectGreenState();
		GameObject gameObject = _coinSprite.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = _keySprite.gameObject;
		gameObject2.SetActive(value: false);
		SSEventsManagerController instance = SSEventsManagerController.instance;
		long num = instance.TimeLeftInSeconds();
		TimeSpan timeLeft = TimeSpan.FromSeconds(num);
		EnableLimitedOffer(timeLeft);
		TMP_Text labelBuyWithInapp = _labelBuyWithInapp;
		string text = Strings.Get(StringID.EVENT_LIMITED_BOARD_DEFAULT_BUTTON_BUY);
		nint num2 = (nint)labelBuyWithInapp;
		object obj = labelBuyWithInapp + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	private void EnableLimitedOffer(TimeSpan timeLeft)
	{
		GameObject gameObject = _priceLabel.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = _expirePriceLabel.gameObject;
		bool flag = ~(_shouldShowEventIndicatorsForTryBoardsEvent ? 1u : 0u) == 0 && _shouldShowEventIndicatorsForBuyLimitedBoardsEvent;
		bool active = !flag;
		gameObject2.SetActive(active);
	}

	private void DisableLimitedOffer()
	{
		GameObject gameObject = _priceLabel.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = _expirePriceLabel.gameObject;
		gameObject2.SetActive(value: false);
	}

	private void Update()
	{
	}

	private void SetToSelectGreenState()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		_lockedThemeGraphics.SetActive(value: false);
		SetNotAvalibleVisibilityTokens(val: false);
		object obj;
		StringID key;
		if (_currentThemeIndex == 0)
		{
			if (~(_shouldShowEventIndicatorsForTryBoardsEvent ? 1u : 0u) == 0)
			{
				obj = this + 20;
				key = StringID.HOVERBOARD_TRY_BUTTON_SELECT;
			}
			else
			{
				obj = this + 12;
				key = StringID.HOVERBOARD_SELCTECT_BUTTON_SELECT;
			}
		}
		else
		{
			obj = this + 12;
			key = StringID.HOVERBOARD_THEME_SELECT_BUTTON_TEXT;
		}
		object obj2 = obj;
		string text = Strings.Get(key);
		object obj3 = obj2;
		object obj4 = obj2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ S2_v5+2CC] (should have been resolved before IL gen)");
		Image image = Click.image;
		image.sprite = _select_img;
		UIClickable component = GetComponent<UIClickable>();
		component.enabled = true;
		Click.enabled = true;
	}

	private void SetToSelectedBlueState()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		_lockedThemeGraphics.SetActive(value: false);
		SetNotAvalibleVisibilityTokens(val: false);
		object obj = this + 20;
		object obj2 = this + 12;
		if (!_shouldShowEventIndicatorsForTryBoardsEvent)
		{
			obj = obj2;
		}
		object obj3 = obj;
		string text = Strings.Get(StringID.HOVERBOARD_SELCTECT_BUTTON_SELECTED);
		object obj4 = obj3;
		object obj5 = obj3 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S2_v8+2CC] (should have been resolved before IL gen)");
		Image image = Click.image;
		image.sprite = _selected_img;
		UIClickable component = GetComponent<UIClickable>();
		component.enabled = false;
		Click.enabled = false;
	}

	private void SetToUnselectBlueState()
	{
		//IL_001b: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		_lockedThemeGraphics.SetActive(value: false);
		SetNotAvalibleVisibilityTokens(val: false);
		TMP_Text labelSelected = _labelSelected;
		string text = Strings.Get(StringID.HOVERBOARD_THEME_BUTTON_UNSELECT);
		nint num = (nint)labelSelected;
		object obj = labelSelected + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Image image = Click.image;
		image.sprite = _selected_img;
		UIClickable component = GetComponent<UIClickable>();
		component.enabled = false;
		Click.enabled = false;
	}

	private unsafe void SetToNeedsUnlockGreyState()
	{
		//IL_003c: Expected I, but got Obj
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected I4, but got Unknown
		//IL_00c0: Expected I, but got Obj
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00eb: Expected Obj, but got I4
		//IL_01f3: Expected I, but got Obj
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		_select.SetActive(value: true);
		_lockedBoardGraphics.SetActive(value: false);
		_lockedThemeGraphics.SetActive(value: true);
		_buy.SetActive(value: false);
		_buyWithInapp.SetActive(value: false);
		TMP_Text labelSelected = _labelSelected;
		nint num = (nint)labelSelected;
		object obj = labelSelected + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(_boardType);
		int index = _currentThemeIndex - 1;
		HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index);
		TMP_Text notAvailableThemeAmount = _notAvailableThemeAmount;
		int num2 = hoverboardTheme + 8;
		string text = ((int*)num2)->ToString();
		nint num3 = (nint)notAvailableThemeAmount;
		object obj2 = notAvailableThemeAmount + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S2_v18 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		object obj3 = hoverboardTheme.unlockType - 2;
		bool flag = hoverboardTheme.unlockType == PurchaseData.UnlockType.Coins;
		bool active = true;
		bool active2 = false;
		if (!flag)
		{
			if ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 != 3)
			{
				goto IL_01a4;
			}
			active = false;
			active2 = true;
		}
		GameObject gameObject = _lockedCoinSprite.gameObject;
		gameObject.SetActive(active);
		GameObject gameObject2 = _lockedKeySprite.gameObject;
		gameObject2.SetActive(active2);
		goto IL_01a4;
		IL_01a4:
		TMP_Text notAvailableThemeFeedback = _notAvailableThemeFeedback;
		Hoverboards.Board board = Hoverboards.boardData.get_Item(_boardType);
		string text2 = Strings.Get(board.name);
		string text3 = text2.ToUpper();
		nint num4 = (nint)notAvailableThemeFeedback;
		object obj4 = notAvailableThemeFeedback + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S2_v29 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Image image = Click.image;
		image.sprite = _selected_img;
		UIClickable component = GetComponent<UIClickable>();
		component.enabled = false;
		Click.enabled = false;
	}

	private void SetToSelectUnavailableState()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0132: Expected I, but got Obj
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_00a2: Expected I, but got Obj
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		TMP_Text labelSelected = _labelSelected;
		nint num = (nint)labelSelected;
		object obj3 = labelSelected + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S2_v2 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Hoverboards.Board board = Hoverboards.boardData.get_Item(_boardType);
		if (board.unlockType == PurchaseData.UnlockType.WeeklyHunt)
		{
			TMP_Text progressLabel = _progressLabel;
			int num2 = WeeklyHuntManager.ItemsCollectedForBoardType(_boardType);
			object obj4 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			int num3 = WeeklyHuntManager.ItemsToCollectForBoardType(_boardType);
			object obj5 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			object arg2 = default;
			string text = $"{arg} / {arg2}";
			nint num4 = (nint)progressLabel;
			object obj6 = progressLabel + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v133 @ S2_v23 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		string path = "UI/" + board.tokenSprite2dName;
		Sprite sprite = Resources.Load<Sprite>(path);
		_tokenSprite.sprite = sprite;
		SetNotAvalibleVisibilityTokens(val: true);
		Image image = Click.image;
		image.sprite = _selected_img;
		UIClickable component = GetComponent<UIClickable>();
		component.enabled = false;
		Click.enabled = false;
	}

	private void SetNotAvalibleVisibilityTokens(bool val)
	{
		_lockedBoardGraphics.SetActive(val);
		_lockedThemeGraphics.SetActive(value: false);
	}

	public void OnClick()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		if (_activeState != ButtonStates.Buy)
		{
			if (_activeState != ButtonStates.Select)
			{
				if (_activeState != ButtonStates.Trial)
				{
					if (_activeState != ButtonStates.BuyWithInapp)
					{
						if (_activeState == ButtonStates.Unselect)
						{
							int themeIndex = _currentThemeIndex - 1;
							DeactivateTheme(_boardType, themeIndex);
						}
					}
					else if (!_purchaseInProgress)
					{
						_purchaseInProgress = true;
						PurchaseHandler instance = PurchaseHandler.Instance;
						HoverboardManager instance2 = HoverboardManager.Instance;
						Hoverboards.BoardType currentlyShownHoverboard = instance2.GetCurrentlyShownHoverboard(_screenContext);
						instance.StartPurchaseBoardWithInapp(currentlyShownHoverboard, this);
					}
				}
				else
				{
					SSEventsManagerController instance3 = SSEventsManagerController.instance;
					IEventManager activeEventManager = instance3.GetActiveEventManager(SSEventType.SpecialPowerBoard);
					if (activeEventManager != null)
					{
						PlayerInfo instance4 = PlayerInfo.Instance;
						PlayerInfo instance5 = PlayerInfo.Instance;
						if (instance5._currentHoverboard != instance4._previousHoverboard)
						{
							instance4._dirty = true;
							instance4._previousHoverboard = instance5._currentHoverboard;
						}
						PlayerInfo instance6 = PlayerInfo.Instance;
						if (!instance6._shouldRestoreAfterEvent)
						{
							instance6._dirty = true;
							instance6._shouldRestoreAfterEvent = true;
						}
						PlayerInfo instance7 = PlayerInfo.Instance;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
						long num = default;
						if (num != instance7._lastEventID)
						{
							instance7._dirty = true;
							instance7._lastEventID = num;
						}
						object obj3 = obj + 31;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F]");
						if ((nint)0 != 0)
						{
							PlayerInfo instance8 = PlayerInfo.Instance;
							Enum obj4 = (Enum)(obj + 8);
							_ = -1;
							obj4 = (Enum)(object)typeof(Hoverboards.BoardType);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
							_ = 0;
							string lastEventItemID = obj4.ToString();
							instance8.lastEventItemID = lastEventItemID;
						}
						OnChangedCurrentlyShownHoverboardModel();
						HoverboardManager instance9 = HoverboardManager.Instance;
						instance9.SelectCurrentlyShownBoard(_screenContext);
						SSEventsManagerController instance10 = SSEventsManagerController.instance;
						if (!instance10.HasTheCurrentEventBeenTried())
						{
							UIScreenController instance11 = UIScreenController.Instance;
							PlayerInfo instance12 = PlayerInfo.Instance;
							instance11.ShowUnlockAnimationForHoverboard(instance12._currentHoverboard);
							SSEventsManagerController instance13 = SSEventsManagerController.instance;
							instance13.CurrentEventHasBeenTriedNow();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F]");
							if ((nint)0 != 0)
							{
								Enum obj5 = (Enum)(obj + 8);
								_ = -1;
								obj5 = (Enum)(object)typeof(Hoverboards.BoardType);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
								_ = 0;
								string text = obj5.ToString();
								string text2 = text.ToUpper();
							}
						}
					}
				}
			}
			else
			{
				if (_currentThemeIndex != 0)
				{
					int themeIndex2 = _currentThemeIndex - 1;
					ActivateTheme(_boardType, themeIndex2, allowSignatureAnimation: true);
					OnChangedCurrentlyShownHoverboardModel();
				}
				HoverboardManager instance14 = HoverboardManager.Instance;
				instance14.SelectCurrentlyShownBoard(_screenContext);
			}
		}
		else if (!_purchaseInProgress)
		{
			_purchaseInProgress = true;
			PurchaseHandler instance15 = PurchaseHandler.Instance;
			if (_currentThemeIndex == 0)
			{
				instance15.PurchaseHoverboard(_boardType, this);
			}
			else
			{
				int themeIndex3 = _currentThemeIndex - 1;
				instance15.PurchaseHoverboardTheme(_boardType, themeIndex3, this);
			}
		}
		Action onClickSelectedButton = this.m_OnClickSelectedButton;
		if (this.m_OnClickSelectedButton != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void ActivateTheme(Hoverboards.BoardType boardType, int themeIndex, bool allowSignatureAnimation)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		PlayerInfo instance = PlayerInfo.Instance;
		HoverboardThemes.ThemeIdentifier themeIdentifier = HoverboardThemes.GetThemeIdentifier(boardType, themeIndex);
		instance._hoverboardCustomizationData.SetThemeActive(boardType, themeIdentifier, active: true);
		HoverboardThemes.ThemeIdentifier themeIdentifier2 = HoverboardThemes.GetThemeIdentifier(boardType, themeIndex);
		_ = -1;
		obj = (Enum)(object)typeof(HoverboardThemes.ThemeIdentifier);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text = obj.ToString();
		OnChangedCurrentlyShownHoverboardModel();
		HoverboardThemes.HoverboardTheme hoverboardTheme = default;
		if (allowSignatureAnimation)
		{
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(boardType);
			hoverboardTheme = list.get_Item(themeIndex);
		}
		HoverboardManager instance2 = HoverboardManager.Instance;
		instance2.ChangeThemeActiveState(_screenContext, hoverboardTheme.power);
	}

	private void DeactivateTheme(Hoverboards.BoardType boardType, int themeIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		PlayerInfo instance = PlayerInfo.Instance;
		HoverboardThemes.ThemeIdentifier themeIdentifier = HoverboardThemes.GetThemeIdentifier(boardType, themeIndex);
		instance._hoverboardCustomizationData.SetThemeActive(boardType, themeIdentifier, active: false);
		HoverboardThemes.ThemeIdentifier themeIdentifier2 = HoverboardThemes.GetThemeIdentifier(boardType, themeIndex);
		_ = -1;
		obj = (Enum)(object)typeof(HoverboardThemes.ThemeIdentifier);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string text = obj.ToString();
		OnChangedCurrentlyShownHoverboardModel();
		HoverboardManager instance2 = HoverboardManager.Instance;
		instance2.ChangeThemeActiveState(_screenContext);
	}

	public void PurchaseSuccessful(bool isBoardTheme = false, int themeIndex = 0)
	{
		_purchaseInProgress = false;
		if (isBoardTheme)
		{
			BoardThemePurchaseSuccessful(themeIndex);
		}
		else
		{
			BoardPurchaseSuccessful();
		}
		PlayerInfo instance = PlayerInfo.Instance;
		instance.SaveIfDirty();
	}

	private unsafe void BoardPurchaseSuccessful()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected I4, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected I4, but got Unknown
		object obj = default;
		HoverboardSelectButton hoverboardSelectButton = (HoverboardSelectButton)(obj - 16);
		((UnityEngine.Object)hoverboardSelectButton).m_CachedPtr = (IntPtr)0;
		HoverboardManager instance = HoverboardManager.Instance;
		instance.SelectCurrentlyShownBoard(_screenContext);
		Hoverboards.Board board = Hoverboards.boardData.get_Item(_boardType);
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.ShowUnlockAnimationForHoverboard(_boardType);
		string text = Strings.Get(board.name);
		char c = text.get_Chars(0);
		char c2 = char.ToUpper(c);
		char c3 = (char)(hoverboardSelectButton + 14);
		string text2 = ((char*)(ushort)c3)->ToString();
		string text3 = Strings.Get(board.name);
		string text4 = text3.Substring(1);
		string text5 = text2 + text4;
		if (hoverboardSelectButton.IsBoardOrThemeFree(_boardType))
		{
			PlayerInfo instance3 = PlayerInfo.Instance;
			((UnityEngine.Object)hoverboardSelectButton).m_CachedPtr = (IntPtr)instance3._numberOfBreadCrumbsShownOnFrontPage;
			int num = hoverboardSelectButton + 8;
			string text6 = ((int*)num)->ToString();
			string text7 = text6 + string.Empty;
		}
	}

	private void BoardThemePurchaseSuccessful(int themeIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		HoverboardManager instance = HoverboardManager.Instance;
		instance.SelectCurrentlyShownBoard(_screenContext);
		PlayerInfo instance2 = PlayerInfo.Instance;
		HoverboardThemes.ThemeIdentifier themeIdentifier = HoverboardThemes.GetThemeIdentifier(_boardType, themeIndex);
		if (instance2._hoverboardCustomizationData.IsThemeOwned(_boardType, themeIdentifier))
		{
			ActivateTheme(_boardType, themeIndex, allowSignatureAnimation: false);
			UIScreenController instance3 = UIScreenController.Instance;
			PlayerInfo instance4 = PlayerInfo.Instance;
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(_boardType);
			HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(themeIndex);
			instance3.ShowUnlockAnimationForHoverboard(instance4._currentHoverboard, hoverboardTheme.power);
			HoverboardThemes.ThemeIdentifier themeIdentifier2 = HoverboardThemes.GetThemeIdentifier(_boardType, themeIndex);
			_ = -1;
			obj = (Enum)(object)typeof(HoverboardThemes.ThemeIdentifier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
		}
	}

	public void PurchaseFailure()
	{
		_purchaseInProgress = false;
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

	private void _003COnEnable_003Eb__45_0()
	{
		OnClick();
	}
}
