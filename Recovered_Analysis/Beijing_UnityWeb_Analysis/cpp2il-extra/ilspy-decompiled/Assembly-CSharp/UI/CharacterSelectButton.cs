using System;
using System.Collections.Generic;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using SYBO.Subway.Info;
using UI.FreeStuff;
using UI.Generic;
using UI.Generic.Layout;
using UI.Screens;
using UI.Screens.PauseScreenInternal;
using UI.Screens.RewardManagement;
using UI.VideoAdPrizes;
using UnityEngine;

namespace UI;

public class CharacterSelectButton : MonoBehaviour
{
	public enum ButtonStates
	{
		Buy,
		Select,
		BuyWithInapp,
		Facebook,
		Collect
	}

	public enum ButtonContext
	{
		CharacterScreen,
		CharacterNameEventPopup,
		LimitedCharacterPopup,
		CharacterPromotion
	}

	public enum StickerType
	{
		None,
		Event,
		Limited,
		Gift
	}

	private UIButtonOverlayOff _uiButtonOverlayOff;

	private GameObject _buyContent;

	private UILabel _priceLabel;

	private UISprite _keySprite;

	private UISprite _coinSprite;

	private Layout _buyLayout;

	private GameObject _selectContent;

	private UILabel _labelSelected;

	private GameObject _lockedThemeContent;

	private Layout _themeTopLayout;

	private Layout _themeBottomLayout;

	private UISprite _notAvailableThemeCoin;

	private UISprite _notAvailableThemeKey;

	private UILabel _notAvailableThemeAmount;

	private UILabel _notAvailableThemeFeedback;

	private GameObject _lockedTokenContent;

	private UILabel _progressLabel;

	private UISprite _tokenSprite;

	private GameObject _buyWithInappContent;

	private UILabel _labelBuyWithInapp;

	private GameObject _facebookContent;

	private GameObject _facebookOfflineContent;

	private UILabel _facebookOfflineLabel;

	private Layout _facebookOfflineLayout;

	private GameObject _facebookLoadingContent;

	private UILabel _facebookLoadingLabel;

	private Layout _facebookLoadingLayout;

	private GameObject _stickerContent;

	private UISprite _backgroundSticker;

	private UISprite _eventIcon;

	private UISprite _giftIcon;

	private UISprite _clockIcon;

	private GameObject _collectContent;

	private UILabel _labelCollect;

	private GameObject _smallFirstPurchaseBonusBannerGo;

	private Characters.CharacterId _currentlyShownModelId;

	private Characters.Model _modelData;

	private int _currentlyShownThemeIndex;

	private Outfit _modelOutfit;

	private PurchaseData.UnlockType _unlockType;

	private bool _isCharacterOwned;

	private bool _isThemeOwned;

	private int _unlockPrice;

	private const string TEXT_PROGRESS = "{0} / {1}";

	private bool _hasInited;

	private bool _buyCharacterWithIapEventIsRunning;

	private ButtonStates _activeState;

	private ButtonContext _buttonContext;

	private CharacterScreenManager _managerInstance;

	public void SetButtonState(ButtonStates state)
	{
		//IL_0021: Expected Obj, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_06b5: Expected I4, but got Obj
		//IL_0105: Expected I4, but got Obj
		//IL_00b7: Expected I, but got Obj
		//IL_038a: Expected Obj, but got I4
		//IL_015a: Expected I4, but got Obj
		//IL_039d: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I
		//IL_0772: Expected I, but got Obj
		//IL_0788: Expected Obj, but got I
		//IL_07cc: Expected Obj, but got I4
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected Obj, but got Unknown
		//IL_07f7: Expected Obj, but got I
		//IL_03de: Expected I, but got Obj
		//IL_01fa: Expected I4, but got Obj
		//IL_0478: Expected I, but got Obj
		//IL_048e: Expected Obj, but got I
		//IL_042b: Expected I, but got Obj
		//IL_026b: Expected I4, but got Obj
		//IL_085f: Expected I4, but got Obj
		//IL_028d: Expected Obj, but got I4
		//IL_0506: Expected I, but got Obj
		//IL_051c: Expected Obj, but got I
		//IL_04b9: Expected I, but got Obj
		//IL_02a0: Expected I, but got Obj
		//IL_02b6: Expected Obj, but got I
		//IL_06f1: Expected I, but got Obj
		//IL_0707: Expected Obj, but got I
		//IL_0745: Expected I4, but got Obj
		//IL_02e1: Expected I, but got Obj
		//IL_066d: Expected I4, but got Obj
		//IL_060a: Expected I, but got Obj
		//IL_032e: Expected I, but got Obj
		//IL_05d3: Expected I4, but got Obj
		//IL_0585: Expected I, but got Obj
		((CameraSettings)(object)this).nearClipPlane = 0f;
		((GameObject)(object)_priceLabel).tag = null;
		((GameObject)(object)_keySprite).tag = null;
		((GameObject)(object)_buyLayout).tag = null;
		((GameObject)(object)_labelSelected).tag = (string)1;
		string text = _progressLabel.tag;
		((GameObject)(object)text).tag = null;
		object obj = this - -64;
		((UILabel)obj).fontStyle = (FontStyle)30;
		object obj2 = this - -64;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v14 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v88 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("DOUBLE_UP_CELEBRATION_SCREEN_TITLE");
		((UILabel)obj2).fontSize = (int)text2;
		string text3 = Strings.GetDefault("DOUBLE_UP_CELEBRATION_SCREEN_SUBTITLE");
		_notAvailableThemeFeedback.fontSize = (int)text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+C]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+14]");
			string text4 = ((CelebrationPopupLabelTemplate)null)._GetKeysLabel(0);
			((UILabel)(object)_lockedTokenContent).fontSize = (int)text4;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+C]");
		if ((nint)0 != 3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+C]");
			if ((nint)0 == 6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+14]");
				int seed = (int)((nint)0 << 1);
				List<VideoAdPrize> shuffledCloneOfRandomPrizePool = ((VideoAdPrizePools)null).GetShuffledCloneOfRandomPrizePool(seed);
				((UILabel)(object)_lockedTokenContent).fontSize = (int)shuffledCloneOfRandomPrizePool;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+C]");
			if ((nint)0 != 2)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+14]");
			CelebrationRewardOrigin celebrationRewardOrigin = (CelebrationRewardOrigin)((nint)0 << 1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+28]");
			CelebrationReward celebrationReward = ((VideoAdPrize)null).CreateMysteryBox(MysteryBox.Type.Normal, celebrationRewardOrigin);
			((UILabel)(object)_lockedTokenContent).fontSize = (int)celebrationReward;
			string text5 = _progressLabel.tag;
			((GameObject)(object)text5).tag = (string)1;
			nint num3 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v68 (Il2CppClass<Info.Upgrades>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Upgrades);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S1_v78 (Il2CppClass<Info.Upgrades>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<UpgradeType, Upgrade> upgrades = Upgrades.upgrades;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+28]");
			Upgrade upgrade = upgrades.get_Item(UpgradeType._notset);
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S2_v62 (Il2CppClass<Strings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S2_v68 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text6 = Strings.GetDefault(upgrade.mysteryBoxDescription);
			_progressLabel.fontSize = (int)text6;
			return;
		}
		string text7 = _progressLabel.tag;
		((GameObject)(object)text7).tag = (string)1;
		nint num7 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v40 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v82 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Characters.CharacterId, Characters.Model> characterData = Characters.characterData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+18]");
		Characters.Model model = characterData.get_Item(Characters.CharacterId.slick);
		nint num9 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S2_v18 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S2_v50 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+18]");
		int outfitIndex = CharacterManager.GetOutfitIndex(Characters.CharacterId.slick);
		object obj8 = model.Price - outfitIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+14]");
		object obj9 = obj8 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+14]");
		object obj10 = (nint)0 << 1;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Dictionary<Characters.CharacterId, Characters.Model> characterData2 = Characters.characterData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.CharacterSelectButton+ButtonStates)+18]");
		Characters.Model model2 = characterData2.get_Item(Characters.CharacterId.slick);
		nint num11 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S2_v30 (Il2CppClass<Strings>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num12 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S2_v46 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string arg = Strings.GetDefault(model2.tokenName);
		string format = default;
		string text8 = string.Format((IFormatProvider)(object)"{0}x {1}", format, arg);
		((UILabel)(object)_lockedTokenContent).fontSize = (int)text8;
		nint num13 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v56 (Il2CppClass<Strings>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		bool flag = obj13 == null;
		if ((nint)obj9 < 1)
		{
			if (!flag)
			{
				nint num14 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v78 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format2 = Strings.GetDefault("CELEBRATION_POPUP_YOU_UNLOCKED_TROPHY");
			string args = Strings.GetDefault(model.name);
			string text9 = string.Format(format2, (object[])(object)args);
			_progressLabel.fontSize = (int)text9;
			return;
		}
		if (!flag)
		{
			nint num15 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v70 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string provider = Strings.GetDefault("CELEBRATION_POPUP_COLLECT_MORE_TOKENS");
		obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string arg2 = Strings.GetDefault(model.name);
		string format3 = default;
		string text10 = string.Format((IFormatProvider)(object)provider, format3, arg2);
		_progressLabel.fontSize = (int)text10;
	}

	public void InitButton(ButtonContext newContext)
	{
		//IL_0028: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		_activeState = (ButtonStates)newContext;
		bool flag = newContext == ButtonContext.CharacterScreen;
		_buyContent.tag = (string)flag;
		bool flag2 = newContext == ButtonContext.CharacterNameEventPopup;
		_selectContent.tag = (string)flag2;
		bool flag3 = newContext == ButtonContext.LimitedCharacterPopup;
		_buyWithInappContent.tag = (string)flag3;
		bool flag4 = newContext == ButtonContext.CharacterPromotion;
		_facebookContent.tag = (string)flag4;
		bool flag5 = newContext == (ButtonContext)4;
		_collectContent.tag = (string)flag5;
		switch (newContext)
		{
		case ButtonContext.CharacterScreen:
			SetUIToSelectGreenState();
			break;
		case ButtonContext.CharacterNameEventPopup:
			UpdateUIForCollectState();
			break;
		case ButtonContext.LimitedCharacterPopup:
			UpdateUIForSelectState();
			break;
		case ButtonContext.CharacterPromotion:
			SetToFacebookLoadingState();
			break;
		case (ButtonContext)4:
			UpdateUIForBuyState();
			break;
		}
	}

	public void SetSticker(StickerType type)
	{
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		_hasInited = true;
		_buttonContext = (ButtonContext)type;
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v17 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 192;
		bool running = FirstPurchaseBonusManager.running;
		obj2 = running;
		object obj3 = this + 12;
		UIButtonOverlayOff component = GetComponent<UIButtonOverlayOff>();
		obj3 = component;
		((DiscountButton)this).ShowOnSale((string)null, (string)null);
	}

	public bool CurrentlyShownCharacterMatchesEventItem()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)((ComputeShader)(object)_keySprite).FindKernel((string)null) != 0;
	}

	public void ReloadButton(bool overrideCharacter = false, Characters.CharacterId newCharacter = Characters.CharacterId.slick)
	{
		//IL_0027: Expected I, but got Obj
		//IL_003d: Expected Obj, but got I
		//IL_0014: Expected Obj, but got I4
		//IL_0068: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I4
		if (CurrentlyShownCharacterMatchesEventItem())
		{
			((GameObject)(object)_keySprite).tag = (string)overrideCharacter;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_coinSprite).FindKernel((string)null) != 0)
		{
			string text = _coinSprite.tag;
			((GameObject)(object)text).tag = (string)newCharacter;
		}
	}

	private void UpdateUIForFacebookState()
	{
		//IL_000b: Expected Obj, but got I4
		_uiButtonOverlayOff = (UIButtonOverlayOff)(-1);
		CancelInvoke();
	}

	private void SetToFacebookLoadingState()
	{
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool running = FirstPurchaseBonusManager.running;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+9]");
		if ((nint)0 != 0)
		{
			SetToFacebookOfflineState();
		}
		else
		{
			UpdateUIForBuyWithInappState();
		}
	}

	private void SetToFacebookOfflineState()
	{
		//IL_0069: Expected Obj, but got I4
		//IL_0083: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_00d3: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		_facebookLoadingContent.tag = (string)1;
		_facebookOfflineContent.tag = null;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v14 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SOCIAL_BUTTON_FEEDBACK_CONNECTING");
		_facebookLoadingLabel.fontSize = (int)text;
		((RewardForVideoButton)(object)_facebookLoadingLayout).Init((VideoButtonPayload)null);
		OnClick();
	}

	private void UpdateUIForBuyWithInappState()
	{
		//IL_0075: Expected Obj, but got I4
		//IL_0083: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_00d3: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		_facebookLoadingContent.tag = null;
		_facebookOfflineContent.tag = (string)1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v14 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SOCIAL_BUTTON_LOGIN");
		_facebookOfflineLabel.fontSize = (int)text;
		((RewardForVideoButton)(object)_facebookOfflineLayout).Init((VideoButtonPayload)null);
		SetUIToSelectedBlueState();
	}

	private void UpdateUIForSelectState()
	{
		//IL_01df: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_022f: Expected I4, but got Obj
		//IL_023d: Expected I, but got Obj
		//IL_0253: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got I
		//IL_02a5: Expected Obj, but got I
		//IL_02b5: Expected Obj, but got I
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0345: Expected I4, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0311: Expected Obj, but got I4
		//IL_032a: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		SetUIToSelectedBlueState();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v56 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("BUY_INAPP_NOPRICE_DEFAULT");
		_labelBuyWithInapp.fontSize = (int)text;
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v12 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v52 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = InAppData.IsUsingCustomIapIdForCharacter((Characters.Model)_currentlyShownModelId);
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S3_v3+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S3_v4+44]");
		object obj5 = 0;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v72 @ S4_v4 (should have been resolved before IL gen)");
		object obj8 = default;
		int fontSize;
		if ((nint)obj8 > -1)
		{
			nint num6 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v37 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num7 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v46 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppItemModel objectToClone = InAppData.inAppData.get_Item((string)flag);
			InAppItemModel inAppItemModel = InAppItemModel.Clone(objectToClone);
			fontSize = (int)inAppItemModel;
		}
		else
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v25 (Il2CppClass<Strings>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v32 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault("BUY_INAPP_NOPRICE_DEFAULT");
			fontSize = (int)text2;
		}
		_labelBuyWithInapp.fontSize = fontSize;
	}

	private void UpdateUIForCollectState()
	{
		//IL_00b3: Expected Obj, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_01a2: Expected Obj, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_0212: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_0245: Expected I, but got Obj
		//IL_025b: Expected Obj, but got I
		//IL_03d4: Expected I, but got Obj
		//IL_03ea: Expected Obj, but got I
		//IL_0286: Expected I, but got Obj
		//IL_02d3: Expected I, but got Obj
		//IL_0355: Expected I4, but got Obj
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		if (currentBoardId == (Boards.BoardId)_currentlyShownModelId)
		{
			if (_buttonContext == ButtonContext.CharacterScreen || _buttonContext == ButtonContext.LimitedCharacterPopup)
			{
				Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
				if (currentCharacterId != (Characters.CharacterId)_currentlyShownThemeIndex)
				{
					goto IL_007d;
				}
			}
			SetUIToNotTappable();
			return;
		}
		goto IL_007d;
		IL_007d:
		bool flag = _modelOutfit != null;
		bool isCharacterOwned = _isCharacterOwned;
		object obj = (isCharacterOwned ? 1 : 0) ^ 1;
		object obj2 = flag | obj;
		if (obj2 != null && (~(_isCharacterOwned ? 1u : 0u) != 0 || !_isThemeOwned))
		{
			bool flag2 = _unlockType == PurchaseData.UnlockType.Tokens;
			object obj3 = flag | flag2;
			bool isCharacterOwned2 = _isCharacterOwned;
			object obj4 = (isCharacterOwned2 ? 1 : 0) ^ 1;
			object obj5 = obj3 & obj4;
			if (obj5 == null)
			{
				return;
			}
			OnClick();
			bool withInAppPurchase = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			PurchaseCharacter(withInAppPurchase);
			_lockedThemeContent.tag = (string)flag;
			if (!flag)
			{
				return;
			}
			object obj6 = this - -64;
			object obj7 = _modelOutfit + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			int fontSize = default;
			((UILabel)obj6).fontSize = fontSize;
			bool flag3 = _unlockType == PurchaseData.UnlockType.Coins;
			_notAvailableThemeCoin.tag = (string)flag3;
			bool flag4 = _unlockType == PurchaseData.UnlockType.Keys;
			_notAvailableThemeKey.tag = (string)flag4;
			nint num = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v37 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v60 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Characters.Model model = Characters.characterData.get_Item(_currentlyShownModelId);
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v38 (Il2CppClass<Strings>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v48 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault(model.name);
			if (text != null && text.m_stringLength != 0)
			{
				string text2 = text.ToUpperInvariant();
				_notAvailableThemeFeedback.fontSize = (int)text2;
			}
			((RewardForVideoButton)(object)_themeTopLayout).Init((VideoButtonPayload)null);
			((RewardForVideoButton)(object)_themeBottomLayout).Init((VideoButtonPayload)null);
		}
		else
		{
			SetUIToSelectedBlueState();
		}
	}

	private void UpdateUIForBuyState()
	{
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		SetUIToSelectedBlueState();
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v23 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v19 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_smallFirstPurchaseBonusBannerGo.tag = null;
	}

	private void SetUIToSelectGreenState()
	{
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I4
		//IL_0118: Expected Obj, but got I4
		//IL_006d: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I4
		if (_modelOutfit != null)
		{
			Outfit modelOutfit = _modelOutfit;
			_unlockType = modelOutfit.unlockType;
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v30 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v36 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isThemeOwned = ((UserData)_currentlyShownModelId).StrictlyBetterThan((UserData)_currentlyShownThemeIndex);
			_isThemeOwned = isThemeOwned;
			_unlockPrice = modelOutfit.price;
		}
		if (_unlockType == PurchaseData.UnlockType.Tokens)
		{
			OnClick();
		}
		else
		{
			SetUIToSelectedBlueState();
		}
		object obj2 = this + 176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_priceLabel.fontSize = fontSize;
		string text = _coinSprite.tag;
		bool flag = _unlockType == PurchaseData.UnlockType.Coins;
		((GameObject)(object)text).tag = (string)flag;
		string text2 = _keySprite.tag;
		bool flag2 = _unlockType == PurchaseData.UnlockType.Keys;
		((GameObject)(object)text2).tag = (string)flag2;
		((RewardForVideoButton)(object)_buyLayout).Init((VideoButtonPayload)null);
	}

	private void SetUIToSelectedBlueState()
	{
		//IL_0032: Expected Obj, but got I4
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_0109: Expected I4, but got Obj
		//IL_0081: Expected I, but got Obj
		_lockedThemeContent.tag = null;
		PurchaseCharacter(withInAppPurchase: false);
		_uiButtonOverlayOff.LockState(locked: true);
		_uiButtonOverlayOff.GoToNotAvailableState();
		string text = _labelSelected.tag;
		((GameObject)(object)text).tag = (string)1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v9 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v16 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("SELECT_BUTTON_SELECT");
		_labelSelected.fontSize = (int)text2;
	}

	private void SetUIToNotTappable()
	{
		//IL_0032: Expected Obj, but got I4
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_0109: Expected I4, but got Obj
		//IL_0081: Expected I, but got Obj
		_lockedThemeContent.tag = null;
		PurchaseCharacter(withInAppPurchase: false);
		_uiButtonOverlayOff.LockState(locked: true);
		_uiButtonOverlayOff._002Ector();
		string text = _labelSelected.tag;
		((GameObject)(object)text).tag = (string)1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v9 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v16 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("SELECT_BUTTON_SELECTED");
		_labelSelected.fontSize = (int)text2;
	}

	private unsafe void ShowLockedTokenContent(bool show)
	{
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected VT, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_03c9: Expected Obj, but got I4
		//IL_03f4: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_048e: Expected Obj, but got VT
		//IL_04a3: Expected F4, but got Obj
		//IL_049e: Expected native int or pointer, but got VT
		//IL_04bd: Expected F4, but got Obj
		//IL_04b8: Expected native int or pointer, but got VT
		//IL_04d2: Expected F4, but got I
		//IL_04cd: Expected native int or pointer, but got VT
		//IL_04e1: Expected I4, but got VT
		//IL_04ea: Expected Obj, but got VT
		//IL_04ff: Expected F4, but got Obj
		//IL_04fa: Expected native int or pointer, but got VT
		//IL_022e: Expected F4, but got Obj
		//IL_0229: Expected native int or pointer, but got VT
		//IL_0243: Expected F4, but got I
		//IL_023e: Expected native int or pointer, but got VT
		//IL_0252: Expected I4, but got VT
		//IL_01e2: Expected I, but got Obj
		//IL_0265: Expected I, but got Obj
		//IL_027b: Expected Obj, but got I
		//IL_051a: Expected Obj, but got VT
		//IL_052f: Expected F4, but got Obj
		//IL_052a: Expected native int or pointer, but got VT
		//IL_0549: Expected F4, but got Obj
		//IL_0544: Expected native int or pointer, but got VT
		//IL_055e: Expected F4, but got I
		//IL_0559: Expected native int or pointer, but got VT
		//IL_056d: Expected I4, but got VT
		//IL_0576: Expected Obj, but got VT
		//IL_058b: Expected F4, but got Obj
		//IL_0586: Expected native int or pointer, but got VT
		//IL_02f2: Expected F4, but got Obj
		//IL_02ed: Expected native int or pointer, but got VT
		//IL_0307: Expected F4, but got I
		//IL_0302: Expected native int or pointer, but got VT
		//IL_0316: Expected I4, but got VT
		//IL_02a6: Expected I, but got Obj
		//IL_00dd: Expected I, but got Obj
		//IL_00f3: Expected Obj, but got I
		//IL_0402: Expected Obj, but got VT
		//IL_0417: Expected F4, but got Obj
		//IL_0412: Expected native int or pointer, but got VT
		//IL_0431: Expected F4, but got Obj
		//IL_042c: Expected native int or pointer, but got VT
		//IL_0446: Expected F4, but got I
		//IL_0441: Expected native int or pointer, but got VT
		//IL_0455: Expected I4, but got VT
		//IL_045e: Expected Obj, but got VT
		//IL_0473: Expected F4, but got Obj
		//IL_046e: Expected native int or pointer, but got VT
		//IL_016a: Expected F4, but got Obj
		//IL_0165: Expected native int or pointer, but got VT
		//IL_017f: Expected F4, but got I
		//IL_017a: Expected native int or pointer, but got VT
		//IL_018e: Expected I4, but got VT
		//IL_011e: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 72);
		object obj2 = obj + 40;
		object obj3 = obj + 24;
		object obj4 = obj - -64;
		object obj5 = obj + 16;
		object obj6 = obj + 60;
		object obj7 = obj + 56;
		object obj8 = obj + 52;
		object obj9 = obj + 48;
		object obj10 = obj + 44;
		bool flag = show;
		_stickerContent.tag = (string)flag;
		string text = _eventIcon.tag;
		bool flag2 = show;
		((GameObject)(object)text).tag = (string)flag2;
		string text2 = _giftIcon.tag;
		bool flag3 = (show ? 1 : 0) == 3;
		((GameObject)(object)text2).tag = (string)flag3;
		string text3 = _clockIcon.tag;
		bool flag4 = (show ? 1 : 0) == 2;
		((GameObject)(object)text3).tag = (string)flag4;
		object obj11 = (show ? 1 : 0) - 1;
		if (!show)
		{
			if ((nint)obj11 != 1)
			{
				if ((nint)obj11 != 2)
				{
					return;
				}
				nint num = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v77 (Il2CppClass<GlobalColors>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num2 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v95 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColors.GIFT_COLOR;
				obj9 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
				Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_backgroundSticker.rawPivot = (UIWidget.Pivot)matrix4x;
				obj5 = GlobalColors.GIFT_LABEL_COLOR;
				obj10 = obj5;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
				Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_giftIcon.rawPivot = (UIWidget.Pivot)matrix4x;
				return;
			}
			nint num3 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v52 (Il2CppClass<GlobalColorsGenerated>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num4 = (nint)typeof(GlobalColorsGenerated);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v70 (Il2CppClass<GlobalColorsGenerated>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
			obj7 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
			Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_backgroundSticker.rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
			obj8 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
			Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_clockIcon.rawPivot = (UIWidget.Pivot)matrix4x;
			return;
		}
		nint num5 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v27 (Il2CppClass<GlobalColors>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num6 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v45 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = GlobalColors.GIFT_COLOR;
		obj4 = obj2;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_backgroundSticker.rawPivot = (UIWidget.Pivot)matrix4x;
		obj5 = GlobalColors.GIFT_LABEL_COLOR;
		obj6 = obj5;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_eventIcon.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	public void OnClick()
	{
		_uiButtonOverlayOff.GoToSelectedState();
		string text = _labelSelected.tag;
		((GameObject)(object)text).tag = null;
	}

	private void PurchaseCharacter(bool withInAppPurchase)
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0177: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I4
		//IL_00b8: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00cb: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got I
		//IL_01ff: Expected I4, but got Obj
		//IL_010c: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		_lockedTokenContent.tag = (string)withInAppPurchase;
		if (!withInAppPurchase)
		{
			return;
		}
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v9 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v43 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int outfitIndex = CharacterManager.GetOutfitIndex(_currentlyShownModelId);
		obj = outfitIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Characters.Model modelData = _modelData;
		obj2 = modelData.Price;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format = default;
		object arg = default;
		string text = string.Format((IFormatProvider)(object)"{0} / {1}", format, arg);
		_progressLabel.fontSize = (int)text;
		nint num3 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v25 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v37 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(_currentlyShownModelId);
		_tokenSprite.fillCenter = (byte)(int)model.tokenSprite2dName != 0;
		FitSpriteToWidget component = _tokenSprite.GetComponent<FitSpriteToWidget>();
		component.FitStretch();
	}

	public unsafe CharacterSelectButton()
	{
		//IL_013f: Expected I, but got Obj
		//IL_0155: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I4
		//IL_025b: Expected I, but got Obj
		//IL_0271: Expected Obj, but got I
		//IL_0180: Expected I, but got Obj
		//IL_04ca: Expected I, but got Obj
		//IL_04e0: Expected Obj, but got I
		//IL_01cd: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_029c: Expected I, but got Obj
		//IL_04a6: Expected Obj, but got I4
		//IL_0344: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I4
		//IL_0361: Expected I, but got Obj
		//IL_0377: Expected Obj, but got I
		//IL_02e9: Expected I, but got Obj
		//IL_020e: Expected I, but got Obj
		//IL_0535: Expected I, but got Obj
		//IL_054b: Expected Obj, but got I
		//IL_057f: Expected Obj, but got I4
		//IL_03a2: Expected I, but got Obj
		//IL_03ef: Expected I, but got Obj
		if (_activeState != ButtonStates.Buy)
		{
			if (_activeState == ButtonStates.BuyWithInapp)
			{
				((CoinButtonHelper)this).Show(true);
				return;
			}
			if (_activeState == ButtonStates.Facebook)
			{
				SetToFacebookOfflineState();
				_managerInstance.OnFacebookLoginStopped();
				return;
			}
			if (_activeState == ButtonStates.Select)
			{
				((CoinScreen)(object)_managerInstance).InsertEarner((int)_currentlyShownModelId, ref *(int*)_currentlyShownThemeIndex);
				return;
			}
			if (_activeState != ButtonStates.Collect)
			{
				object obj = _activeState;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text = default;
				string msg = "CharacterSelect was clicked with an unknown state: " + text;
				SDebug.LogFormat(msg, null);
				return;
			}
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v26 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v84 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UserSave.inAppLegacyPurchaseCount == 0)
			{
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v74 (Il2CppClass<UIScreenController>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v80 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag)._ActivateNextPopup("CoinsUI_quick");
				return;
			}
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S2_v4 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v10 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterManager.SetOutfitSelectionIndex(_currentlyShownModelId, _unlockPrice);
			nint num7 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v36 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v69 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool running = FirstPurchaseBonusManager.running;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
			dailyChallengeRewardHelper.Refresh();
			((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)7;
			dailyChallengeRewardHelper._rewardLayout = (Layout)8;
			dailyChallengeRewardHelper._rewardLabel = (UILabel)_currentlyShownModelId;
			nint num9 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v49 (Il2CppClass<RewardManager>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v65 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RewardManager.AddMysteryBoxToUnlock((CelebrationReward)(object)dailyChallengeRewardHelper);
			nint num11 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v55 (Il2CppClass<UIScreenController>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num12 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v61 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag2).QueuePopup((GameObject)(object)"CelebrationPopup");
		}
		else
		{
			((CoinButtonHelper)this).Show(false);
		}
	}
}
