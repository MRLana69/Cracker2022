using System;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;
using TMPro;
using UI.Generic.Layout;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI;

public class CharacterSelectButton : MonoBehaviour
{
	public enum ButtonStates
	{
		buy,
		select,
		trial,
		buyWithInapp,
		unselect,
		facebook
	}

	public enum ButtonContext
	{
		characterScreen,
		characterNameEventPopup,
		limitedCharacterPopup
	}

	public enum StickerColors
	{
		Gift,
		Discount
	}

	private TMP_Text labelSelected;

	private TMP_Text labelUnselect;

	private TMP_Text labelBuyWithInapp;

	private TMP_Text priceLabel;

	private TMP_Text progressLabel;

	private Image tokenSprite;

	private TMP_Text expireTimeLabel;

	private Image _keySprite;

	private Image _coinSprite;

	private Image _notAvailableThemeCoin;

	private Image _notAvailableThemeKey;

	private TMP_Text _notAvailableThemeAmount;

	private TMP_Text _notAvailableThemeFeedback;

	private GameObject buy;

	private GameObject select;

	private GameObject trial;

	private GameObject buyWithInapp;

	private GameObject unselect;

	private GameObject lockedBoardGraphics;

	private GameObject lockedThemeGraphics;

	private GameObject lockedCharacterGraphics;

	private Characters.CharacterType currentlyShownModelType;

	private Characters.Model modelData;

	private int currentlyShownThemeIndex;

	private CharacterTheme modelTheme;

	private PurchaseData.UnlockType unlockType;

	private bool isCharacterOwned;

	private bool isThemeOwned;

	private int unlockPrice;

	private string textProgress = "{0} / {1}";

	private bool _hasInited;

	private bool buyCharacterWithIAPEventIsRunning;

	private ButtonStates _activeState;

	private ButtonContext _buttonContext;

	private CharacterScreenManager _managerInstance;

	private int _totalSeconds = -1;

	private Button OnClick;

	private Sprite _select;

	private Sprite _selected;

	public void EnableEventIcon(bool enable)
	{
	}

	private unsafe void Start()
	{
		Button onClick = OnClick;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(CharacterSelectButton._003CStart_003Eb__43_0));
		onClick.m_OnClick.AddListener(unityAction);
	}

	public void SetButtonState(ButtonStates state)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_activeState = state;
		switch (state)
		{
		case ButtonStates.buy:
		{
			buy.SetActive(value: true);
			bool activeSelf17 = buy.activeSelf;
			bool active17 = (byte)((activeSelf17 ? 1u : 0u) ^ 1u) != 0;
			select.SetActive(active17);
			bool activeSelf18 = buy.activeSelf;
			bool active18 = (byte)((activeSelf18 ? 1u : 0u) ^ 1u) != 0;
			trial.SetActive(active18);
			bool activeSelf19 = buy.activeSelf;
			bool active19 = (byte)((activeSelf19 ? 1u : 0u) ^ 1u) != 0;
			buyWithInapp.SetActive(active19);
			bool activeSelf20 = buy.activeSelf;
			bool active20 = (byte)((activeSelf20 ? 1u : 0u) ^ 1u) != 0;
			unselect.SetActive(active20);
			break;
		}
		case ButtonStates.trial:
		{
			trial.SetActive(value: true);
			bool activeSelf13 = trial.activeSelf;
			bool active13 = (byte)((activeSelf13 ? 1u : 0u) ^ 1u) != 0;
			buy.SetActive(active13);
			bool activeSelf14 = trial.activeSelf;
			bool active14 = (byte)((activeSelf14 ? 1u : 0u) ^ 1u) != 0;
			select.SetActive(active14);
			bool activeSelf15 = trial.activeSelf;
			bool active15 = (byte)((activeSelf15 ? 1u : 0u) ^ 1u) != 0;
			buyWithInapp.SetActive(active15);
			bool activeSelf16 = trial.activeSelf;
			bool active16 = (byte)((activeSelf16 ? 1u : 0u) ^ 1u) != 0;
			unselect.SetActive(active16);
			break;
		}
		case ButtonStates.select:
		{
			select.SetActive(value: true);
			bool activeSelf9 = select.activeSelf;
			bool active9 = (byte)((activeSelf9 ? 1u : 0u) ^ 1u) != 0;
			buy.SetActive(active9);
			bool activeSelf10 = select.activeSelf;
			bool active10 = (byte)((activeSelf10 ? 1u : 0u) ^ 1u) != 0;
			trial.SetActive(active10);
			bool activeSelf11 = select.activeSelf;
			bool active11 = (byte)((activeSelf11 ? 1u : 0u) ^ 1u) != 0;
			buyWithInapp.SetActive(active11);
			bool activeSelf12 = select.activeSelf;
			bool active12 = (byte)((activeSelf12 ? 1u : 0u) ^ 1u) != 0;
			unselect.SetActive(active12);
			break;
		}
		case ButtonStates.unselect:
		{
			unselect.SetActive(value: true);
			bool activeSelf5 = unselect.activeSelf;
			bool active5 = (byte)((activeSelf5 ? 1u : 0u) ^ 1u) != 0;
			buy.SetActive(active5);
			bool activeSelf6 = unselect.activeSelf;
			bool active6 = (byte)((activeSelf6 ? 1u : 0u) ^ 1u) != 0;
			trial.SetActive(active6);
			bool activeSelf7 = unselect.activeSelf;
			bool active7 = (byte)((activeSelf7 ? 1u : 0u) ^ 1u) != 0;
			buyWithInapp.SetActive(active7);
			bool activeSelf8 = unselect.activeSelf;
			bool active8 = (byte)((activeSelf8 ? 1u : 0u) ^ 1u) != 0;
			select.SetActive(active8);
			break;
		}
		case ButtonStates.buyWithInapp:
		{
			buyWithInapp.SetActive(value: true);
			bool activeSelf = buyWithInapp.activeSelf;
			bool active = (byte)((activeSelf ? 1u : 0u) ^ 1u) != 0;
			buy.SetActive(active);
			bool activeSelf2 = buyWithInapp.activeSelf;
			bool active2 = (byte)((activeSelf2 ? 1u : 0u) ^ 1u) != 0;
			select.SetActive(active2);
			bool activeSelf3 = buyWithInapp.activeSelf;
			bool active3 = (byte)((activeSelf3 ? 1u : 0u) ^ 1u) != 0;
			trial.SetActive(active3);
			bool activeSelf4 = buyWithInapp.activeSelf;
			bool active4 = (byte)((activeSelf4 ? 1u : 0u) ^ 1u) != 0;
			unselect.SetActive(active4);
			break;
		}
		default:
		{
			_ = -1;
			obj = (Enum)(object)typeof(ButtonStates);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			string text2 = "No handler for button state: " + text;
			break;
		}
		}
	}

	public void InitButton(ButtonContext newContext)
	{
		_buttonContext = newContext;
		_hasInited = true;
		CharacterScreenManager instance = CharacterScreenManager.Instance;
		_managerInstance = instance;
		ReloadButton();
	}

	public void SetStickerColors(StickerColors stickerType)
	{
	}

	public bool CurrentlyShownCharacterMatchesEventItem()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0193: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I4
		//IL_0185: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		obj = 0;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		bool flag = activeEventManager == null;
		bool result = false;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj4 = default;
			object obj3 = obj4 - 3;
			if ((nint)obj4 == 3)
			{
				goto IL_00e5;
			}
			bool flag2 = (nint)obj3 == 1;
			result = false;
			if (!flag2)
			{
				bool flag3 = (nint)obj3 == 2;
				result = false;
				if (!flag3)
				{
					bool flag4 = (nint)obj3 == 3;
					result = false;
					if (!flag4)
					{
						if ((nint)obj3 == 4)
						{
							goto IL_00e5;
						}
						result = false;
					}
				}
			}
		}
		goto IL_01d4;
		IL_01d4:
		return result;
		IL_00e5:
		_ = 0;
		object obj5 = obj + 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
		obj = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		bool flag5 = (nint)0 == 0;
		result = false;
		if (!flag5)
		{
			UIModelController instance2 = UIModelController.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			bool flag6 = (nint)0 != (nint)instance2._currentlyShownModel;
			result = false;
			if (!flag6)
			{
				result = (byte)(int)obj != 0;
			}
		}
		goto IL_01d4;
	}

	public void ReloadButton(bool overrideCharacter = false, Characters.CharacterType newCharacter = Characters.CharacterType.slick)
	{
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			return;
		}
		CharacterScreenManager instance = CharacterScreenManager.Instance;
		LimitedCharacterPopupManager instance2 = LimitedCharacterPopupManager.Instance;
		int num;
		if (_buttonContext != ButtonContext.characterScreen)
		{
			if (_buttonContext != ButtonContext.characterNameEventPopup)
			{
				if (_buttonContext == ButtonContext.limitedCharacterPopup)
				{
					Characters.CharacterType currentCharacter = instance2.currentCharacter;
					currentlyShownModelType = currentCharacter;
					num = instance2._currentThemeIndex;
					goto IL_016e;
				}
			}
			else if (overrideCharacter)
			{
				currentlyShownModelType = newCharacter;
				PlayerInfo instance3 = PlayerInfo.Instance;
				int indexForLastSelectedTheme = instance3.GetIndexForLastSelectedTheme(currentlyShownModelType);
				CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(newCharacter, indexForLastSelectedTheme);
				bool flag = themeForCharacter == null;
				num = 0;
				if (!flag)
				{
					PlayerInfo instance4 = PlayerInfo.Instance;
					num = instance4.GetIndexForLastSelectedTheme(currentlyShownModelType);
				}
				goto IL_016e;
			}
			goto IL_0464;
		}
		currentlyShownModelType = instance.currentlyShownCharacter__BackingField;
		num = instance.currentlyShownThemeIndex__BackingField;
		goto IL_016e;
		IL_0464:
		Characters.Model model = Characters.characterData.get_Item(currentlyShownModelType);
		modelData = model;
		if (_buttonContext == ButtonContext.characterScreen || (_buttonContext != ButtonContext.characterNameEventPopup && _buttonContext == ButtonContext.limitedCharacterPopup))
		{
			CharacterTheme themeForCharacter2 = CharacterThemes.GetThemeForCharacter(currentlyShownModelType, currentlyShownThemeIndex);
			modelTheme = themeForCharacter2;
		}
		else
		{
			modelTheme = null;
		}
		Characters.Model model2 = modelData;
		this.unlockType = model2.unlockType;
		PlayerInfo instance5 = PlayerInfo.Instance;
		bool flag2 = instance5.IsCharacterOwned(currentlyShownModelType);
		isCharacterOwned = flag2;
		Characters.Model model3 = modelData;
		unlockPrice = model3.Price;
		CharacterTheme characterTheme = modelTheme;
		if (modelTheme != null)
		{
			this.unlockType = characterTheme.unlockType;
			PlayerInfo instance6 = PlayerInfo.Instance;
			bool flag3 = instance6.IsThemeUnlockedForCharacter(currentlyShownModelType, currentlyShownThemeIndex);
			isThemeOwned = flag3;
			unlockPrice = characterTheme.price;
		}
		SSEventsManagerController instance7 = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance7.GetActiveEventManager(SSEventType.ExpiredLimitedCharacter);
		bool flag4 = CurrentlyShownCharacterMatchesEventItem();
		bool flag5 = !flag4;
		bool flag6 = false;
		if (!flag5)
		{
			if (~(isCharacterOwned ? 1u : 0u) != 0)
			{
				flag6 = false;
				if (modelTheme != null)
				{
					goto IL_0505;
				}
			}
			bool flag7 = activeEventManager != null;
			flag6 = flag7;
		}
		goto IL_0505;
		IL_016e:
		currentlyShownThemeIndex = num;
		goto IL_0464;
		IL_03d8:
		if (buyCharacterWithIAPEventIsRunning)
		{
			goto IL_0406;
		}
		goto IL_0434;
		IL_0434:
		SetButtonState(ButtonStates.select);
		UpdateUIForSelectState();
		return;
		IL_0505:
		buyCharacterWithIAPEventIsRunning = flag6;
		PurchaseData.UnlockType unlockType = this.unlockType;
		if (this.unlockType == PurchaseData.UnlockType.Facebook)
		{
			if (~(Globals.DEBUG_ALL_CHARS ? 1u : 0u) != 0)
			{
				if (!isCharacterOwned)
				{
					SetButtonState(ButtonStates.facebook);
					UpdateUIForFacebookState();
					return;
				}
				goto IL_0434;
			}
			unlockType = this.unlockType;
		}
		if (unlockType < PurchaseData.UnlockType.Coins)
		{
			goto IL_03d8;
		}
		if (~(isCharacterOwned ? 1u : 0u) == 0)
		{
			if (modelTheme == null || isThemeOwned)
			{
				goto IL_03d8;
			}
		}
		else if (modelTheme != null)
		{
			goto IL_03d8;
		}
		if (~(buyCharacterWithIAPEventIsRunning ? 1u : 0u) == 0)
		{
			goto IL_0406;
		}
		SetButtonState(ButtonStates.buy);
		UpdateUIForBuyState();
		return;
		IL_0406:
		SetButtonState(ButtonStates.buyWithInapp);
		UpdateUIForBuyWithInappState();
	}

	private void UpdateUIForFacebookState()
	{
		DisableLimitedOfferElements();
		CharacterScreenManager instance = CharacterScreenManager.Instance;
		if (~(instance._facebookLoginRunning ? 1u : 0u) == 0)
		{
			SetToFacebookLoadingState();
		}
		else
		{
			SetToFacebookOfflineState();
		}
	}

	private void SetToFacebookLoadingState()
	{
		SetUIToSelectUnavailableState();
	}

	private void SetToFacebookOfflineState()
	{
		SetUIToSelectGreenState();
	}

	private void UpdateUIForBuyWithInappState()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01b6: Expected Obj, but got VT
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01e8: Expected Obj, but got VT
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_023d: Expected Obj, but got VT
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0270: Expected Obj, but got I
		//IL_007b: Expected F8, but got I8
		//IL_00a9: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0174: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		SetUIToSelectGreenState();
		object obj3 = GlobalColors.EXPIRE_TIME_COUNTER_TRY_NOT_SELECTED >> 16;
		object obj4 = obj3 & 0xFF;
		float num = (float)obj4 / 255f;
		object obj5 = GlobalColors.EXPIRE_TIME_COUNTER_TRY_NOT_SELECTED >> 24;
		float num2 = (float)obj5 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj6 = GlobalColors.EXPIRE_TIME_COUNTER_TRY_NOT_SELECTED & 0xFF;
		float num3 = (float)obj6 / 255f;
		object obj7 = GlobalColors.EXPIRE_TIME_COUNTER_TRY_NOT_SELECTED >> 8;
		object obj8 = obj7 & 0xFF;
		float num4 = (float)obj8 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		GameObject gameObject = _coinSprite.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = _keySprite.gameObject;
		gameObject2.SetActive(value: false);
		SSEventsManagerController instance = SSEventsManagerController.instance;
		long num5 = instance.TimeLeftInSeconds();
		TimeSpan timeSpan = TimeSpan.FromSeconds(num5);
		TMP_Text tMP_Text = labelBuyWithInapp;
		string text = Strings.Get(StringID.EVENT_LIMITED_CHAR_DEFAULT_BUTTON_BUY);
		nint num6 = (nint)tMP_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S2_v16 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		string key = InAppData.ConvertCharacterTypeToDynamicPurchaseId(currentlyShownModelType);
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S3_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, InAppItemModel>>)+54]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ S3_v6+4] (should have been resolved before IL gen)");
		object obj11 = default;
		object obj10 = obj11 ^ -1;
		object obj12 = obj10 >> 31;
		TMP_Text tMP_Text2 = labelBuyWithInapp;
		if (obj12 != null)
		{
			InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(key);
			string localizedPrice = inAppItemModel.LocalizedPrice;
		}
		else
		{
			string localizedPrice = Strings.Get(StringID.BUY_INAPP_NOPRICE_DEFAULT);
		}
		nint num9 = (nint)tMP_Text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ S2_v25 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Layout component = buyWithInapp.GetComponent<Layout>();
		component.Align();
	}

	private unsafe void UpdateUIForSelectState()
	{
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected I4, but got Unknown
		//IL_01f1: Expected I, but got Obj
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I4
		//IL_02a4: Expected Obj, but got I4
		//IL_02e4: Expected I, but got Obj
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		DisableLimitedOfferElements();
		PlayerInfo instance = PlayerInfo.Instance;
		if (instance._currentCharacter == (int)currentlyShownModelType)
		{
			if (_buttonContext == ButtonContext.characterScreen || (_buttonContext != ButtonContext.characterNameEventPopup && _buttonContext == ButtonContext.limitedCharacterPopup))
			{
				PlayerInfo instance2 = PlayerInfo.Instance;
				int currentThemeIndex = instance2.currentThemeIndex;
				if (currentThemeIndex != currentlyShownThemeIndex)
				{
					goto IL_00d0;
				}
			}
			SetUIToSelectedBlueState();
			return;
		}
		goto IL_00d0;
		IL_00d0:
		bool flag = false;
		if (modelTheme == null)
		{
			flag = isCharacterOwned;
		}
		string text2;
		object obj2;
		if (!flag)
		{
			if (~(isCharacterOwned ? 1u : 0u) != 0)
			{
				if (modelTheme == null && unlockType != PurchaseData.UnlockType.Tokens)
				{
					return;
				}
				SetUIToSelectUnavailableState();
				bool uINotAvalibleVisibilityTokens = modelTheme == null;
				SetUINotAvalibleVisibilityTokens(uINotAvalibleVisibilityTokens);
				if (modelTheme != null)
				{
					TMP_Text notAvailableThemeAmount = _notAvailableThemeAmount;
					int num = modelTheme + 8;
					string text = ((int*)num)->ToString();
					nint num2 = (nint)notAvailableThemeAmount;
					object obj = notAvailableThemeAmount + 528;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v124 @ S2_v9 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
					bool flag2 = unlockType == PurchaseData.UnlockType.Coins;
					_notAvailableThemeCoin.enabled = flag2;
					bool flag3 = unlockType == PurchaseData.UnlockType.Keys;
					_notAvailableThemeKey.enabled = flag3;
					Characters.Model model = Characters.characterData.get_Item(currentlyShownModelType);
					text2 = Strings.Get(model.name);
					if (text2 != null)
					{
						obj2 = 0;
						if (text2._stringLength != 0)
						{
							goto IL_0355;
						}
					}
					obj2 = 1;
					goto IL_0355;
				}
				lockedThemeGraphics.SetActive(value: false);
				SetUIToSelectUnavailableState();
				return;
			}
			if (~(isThemeOwned ? 1u : 0u) != 0)
			{
				return;
			}
		}
		SetUIToSelectGreenState();
		return;
		IL_0355:
		if (obj2 == null)
		{
			TMP_Text notAvailableThemeFeedback = _notAvailableThemeFeedback;
			string text3 = text2.ToUpper();
			nint num3 = (nint)notAvailableThemeFeedback;
			object obj3 = notAvailableThemeFeedback + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v191 @ S2_v22 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		lockedThemeGraphics.SetActive(value: true);
	}

	private unsafe void UpdateUIForBuyState()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I4, but got Unknown
		//IL_0099: Expected I, but got Obj
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		CharacterTheme characterTheme = modelTheme;
		if (modelTheme != null)
		{
			unlockType = characterTheme.unlockType;
			PlayerInfo instance = PlayerInfo.Instance;
			bool flag = instance.IsThemeUnlockedForCharacter(currentlyShownModelType, currentlyShownThemeIndex);
			isThemeOwned = flag;
			unlockPrice = characterTheme.price;
		}
		if (unlockType == PurchaseData.UnlockType.Tokens)
		{
			SetUIToSelectUnavailableState();
		}
		else
		{
			SetUIToSelectGreenState();
		}
		TMP_Text tMP_Text = priceLabel;
		int num = this + 120;
		string text = ((int*)num)->ToString();
		nint num2 = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		GameObject gameObject = _coinSprite.gameObject;
		bool active = unlockType == PurchaseData.UnlockType.Coins;
		gameObject.SetActive(active);
		GameObject gameObject2 = _keySprite.gameObject;
		bool active2 = unlockType == PurchaseData.UnlockType.Keys;
		gameObject2.SetActive(active2);
		DisableLimitedOfferElements();
	}

	private void DisableLimitedOfferElements()
	{
		GameObject gameObject = priceLabel.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = expireTimeLabel.gameObject;
		gameObject2.SetActive(value: false);
	}

	private void SetUIToSelectGreenState()
	{
		//IL_001b: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		lockedThemeGraphics.SetActive(value: false);
		SetUINotAvalibleVisibilityTokens(val: false);
		TMP_Text tMP_Text = labelSelected;
		string text = Strings.Get(StringID.UICHARACTER_SELECT_BUTTON_SELECT);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Image image = OnClick.image;
		image.sprite = _select;
		UIClickable component = GetComponent<UIClickable>();
		component.enabled = true;
		OnClick.enabled = true;
	}

	private void SetUIToSelectedBlueState()
	{
		//IL_001b: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		lockedThemeGraphics.SetActive(value: false);
		SetUINotAvalibleVisibilityTokens(val: false);
		TMP_Text tMP_Text = labelSelected;
		string text = Strings.Get(StringID.UICHARACTER_SELECT_BUTTON_SELECTED);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Image image = OnClick.image;
		image.sprite = _selected;
		OnClick.enabled = false;
		UIClickable component = GetComponent<UIClickable>();
		component.enabled = false;
	}

	private void SetUIToSelectUnavailableState()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0048: Expected I, but got Obj
		//IL_007a: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_0101: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		Image image = OnClick.image;
		image.sprite = _selected;
		UIClickable component = GetComponent<UIClickable>();
		component.enabled = false;
		OnClick.enabled = false;
		TMP_Text tMP_Text = labelSelected;
		nint num = (nint)tMP_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = progressLabel;
		PlayerInfo instance = PlayerInfo.Instance;
		object obj3 = (int)currentlyShownModelType << 2;
		object obj4 = (object)instance._collectedCharacterTokens + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v17+10]");
		_ = 0;
		object obj5 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		Characters.Model model = modelData;
		_ = model.Price;
		object obj6 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		string text = string.Format(textProgress, arg, arg2);
		nint num2 = (nint)tMP_Text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ S2_v13 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Characters.Model model2 = Characters.characterData.get_Item(currentlyShownModelType);
		string path = "UI/" + model2.tokenSprite2dName;
		Sprite sprite = Resources.Load<Sprite>(path);
		tokenSprite.sprite = sprite;
	}

	private void SetUINotAvalibleVisibilityTokens(bool val)
	{
		lockedCharacterGraphics.SetActive(val);
		lockedBoardGraphics.SetActive(value: false);
	}

	private void PurchaseCharacter(bool withInAppPurchase)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		if (_buttonContext != ButtonContext.characterScreen)
		{
			if (_buttonContext != ButtonContext.characterNameEventPopup)
			{
				if (_buttonContext == ButtonContext.limitedCharacterPopup)
				{
					_managerInstance.PurchaseCharacter(CharacterScreenManager.CharacterPurchaseInitiator.limitedCharacterPopup, currentlyShownModelType, currentlyShownThemeIndex);
					CharacterScreen.forceCenterOnCurrentlySelectedCharacter = true;
					CharacterScreen.forceRefreshOnCharacterScreen = true;
				}
				else
				{
					_ = -1;
					obj = (Enum)(object)typeof(ButtonContext);
					_ = _buttonContext;
					string text = obj.ToString();
					string text2 = "No handler for context: " + text;
				}
			}
			else
			{
				_managerInstance.PurchaseCharacter(CharacterScreenManager.CharacterPurchaseInitiator.characterNameEvent, currentlyShownModelType, 0);
				CharacterScreen.forceCenterOnCurrentlySelectedCharacter = true;
				CharacterScreen.forceRefreshOnCharacterScreen = true;
			}
		}
		else
		{
			_managerInstance.PurchaseCharacter(CharacterScreenManager.CharacterPurchaseInitiator.characterScreen, currentlyShownModelType, currentlyShownThemeIndex, unlockPrice);
		}
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

	private void _003CStart_003Eb__43_0()
	{
		if (_activeState == ButtonStates.buy)
		{
			PurchaseCharacter(withInAppPurchase: false);
		}
		else
		{
			_managerInstance.SelectCharacter(currentlyShownModelType, currentlyShownThemeIndex);
		}
	}
}
