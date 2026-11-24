using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using InApp;
using Info;
using Info.VideoRewardCooldowns;
using Kiloo.Common.Extensions;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.Timer;
using SYBO.Subway;
using UI.ButtonHelpers;
using UI.Footer;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.ModelCamera;
using UI.Pages;
using UI.Popups.ConsumablesPopupInternal;
using UI.Popups.LimitedBoardPopupInternal;
using UI.Popups.LimitedCharacterPopupInternal;
using UI.Screens;
using UI.Screens.NotEnoughCurrencyPopupInternal;
using UI.ScrollListSelectPopup;
using UnityEngine;

namespace UI.Popups;

public class NotEnoughCurrencyPopup : UIScreen
{
	private enum PopupClosingAction
	{
		None,
		Buy,
		Cancel,
		Ok,
		VideoCoins
	}

	private const int FIRST_PURCHASE_BONUS_BANNER_WIDTH = 305;

	private UILabel popupTitle;

	private UILabel popupDescription;

	private GameObject uiContentCoins;

	private GameObject uiContentKeys;

	private GameObject emptySpace;

	private GameObject uiContentVideoForCoins;

	private Transform _dynamicContentRoot;

	private VerticalLayout _dynamicContentVerticalLayout;

	private UITable _table;

	private GameObject _currencyButtonPrefab;

	private GameObject _firstPurchaseBonusBannerPrefab;

	private GameObject _okButtonPrefab;

	private GameObject _buyMoreInStoreLabelPrefab;

	private GameObject _emptySpace;

	private Transform _popupContent;

	private PopupClosingAction _closingAction;

	private static InAppManagerPopupData _popupData;

	private UiElementsManager _uiElementsManager;

	private GameObject _coinsForAdButton;

	private GameObject _buyCurrencyButton;

	private GameObject _okButton;

	private GameObject _buyMoreInStorelabel;

	private GameObject _firstPurchaseBanner;

	private int _newCoinPrice;

	private static RewardForVideoButton _rewardForVideoButton;

	private const string STANDARD_VIDEO_REWARD = "-1";

	private const string VIDEO_AVAIL_YES = "Yes";

	private const string VIDEO_AVAIL_FAIL = "No_caching_failed";

	private const string VIDEO_AVAIL_NO_TRY = "No_caching_not_attempted";

	private const string BUTTON_NAME_CLOSE = "Closed";

	private const string BUTTON_NAME_IAP = "IAP";

	private const string BUTTON_NAME_VIDEO = "Video";

	private const string BUTTON_NO_COOLDOWN = "No Cooldown";

	private const string BUTTON_COOLDOWN = "Cooldown_{0}_watched";

	private string _flurryVideoAvailable;

	private string _flurryButtonName;

	private string _flurryVideoReward;

	private string _flurryCooldownStep;

	private VideoButtonPayload _videoButtonPayload;

	private void Update()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj = this + 84;
		obj = list;
		((UpgradeScreen)this).Start();
	}

	private static int GetCachedRewardAmount()
	{
		//IL_000b: Expected I4, but got Obj
		return (int)UI.ScrollListSelectPopup.ScrollListSelectPopup._instance;
	}

	public override void Init()
	{
		//IL_000a: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		if (Input.GetKeyDown((string)13) || Input.GetKeyDown((string)32))
		{
			this._002Ector();
		}
	}

	private static VideoButtonPayload CreateButtonPayload()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardForVideoButton rewardForVideoButton = _rewardForVideoButton;
		return (VideoButtonPayload)rewardForVideoButton._cachedRewardAmount;
	}

	public override void Show()
	{
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v19 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 148;
		LimitedCharacterPopupManager instance = LimitedCharacterPopupManager.Instance;
		obj2 = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		UiElementsManager uiElementsManager = default;
		uiElementsManager.DeactivateAllUiElements();
		object obj3 = this + 104;
		obj3 = uiElementsManager;
		HideDynamicUiElements();
	}

	private void RefreshPopupContent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		base.Hide();
		CenterSelf();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		AdSystemManager.onFinishedWatchingVideo -= action;
	}

	private void HandleOnCoinsForVideoFinished(string adLocation)
	{
		//IL_011f: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0168: Expected I4, but got Obj
		//IL_0100: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.instance;
		if ((instance._overwrittenBoardForNextShowing ? 1 : 0) == (nint)adLocation)
		{
			return;
		}
		nint num3 = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v25 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LimitedBoardPopupManager instance2 = LimitedBoardPopupManager.instance;
		instance2._overwrittenBoardForNextShowing = (byte)(int)adLocation != 0;
		bool isInstanced = UIScreenController.IsInstanced;
		LimitedBoardPopupManager instance3 = LimitedBoardPopupManager.instance;
		int currentThemeIndex = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		((UIModelController)isInstanced).SetupModelScreen((UIModelController.ModelScreen)currentThemeIndex, (ModelScreenSetup)(object)adLocation, (ModelScreenData)10);
		((LimitedCharacterPopup)this).UpdateSelectedCharacter();
	}

	private void CenterSelf()
	{
		//IL_1497: Expected I, but got Obj
		//IL_14ad: Expected Obj, but got I
		//IL_1bbb: Expected I, but got Obj
		//IL_1bd1: Expected Obj, but got I
		//IL_14d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d8: Expected Obj, but got Unknown
		//IL_14e9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0c1e: Expected I, but got Obj
		//IL_0c34: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_1a18: Expected I, but got Obj
		//IL_1a2e: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0c5f: Expected I, but got Obj
		//IL_1524: Expected I4, but got Obj
		//IL_0cac: Expected I, but got Obj
		//IL_01d6: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8a: Expected Obj, but got Unknown
		//IL_0cf9: Expected I, but got Obj
		//IL_0d0f: Expected Obj, but got I
		//IL_15e1: Expected I4, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_1abd: Expected I, but got Obj
		//IL_1ad3: Expected Obj, but got I
		//IL_1a5b: Expected I4, but got Obj
		//IL_1598: Expected I, but got Obj
		//IL_15ae: Expected Obj, but got I
		//IL_0217: Expected I, but got Obj
		//IL_155b: Expected Obj, but got I4
		//IL_1c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c55: Expected Obj, but got Unknown
		//IL_1c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c63: Expected Obj, but got Unknown
		//IL_1a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6b: Expected Obj, but got Unknown
		//IL_0d3a: Expected I, but got Obj
		//IL_01c3: Expected I4, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0fa2: Expected I, but got Obj
		//IL_0fb8: Expected Obj, but got I
		//IL_0ea6: Expected I, but got Obj
		//IL_0de6: Expected I, but got Obj
		//IL_0dfc: Expected Obj, but got I
		//IL_02d3: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_0264: Expected I, but got Obj
		//IL_10df: Expected I, but got Obj
		//IL_10f5: Expected Obj, but got I
		//IL_0fe3: Expected I, but got Obj
		//IL_0f15: Expected VT, but got I4
		//IL_0e27: Expected I, but got Obj
		//IL_0395: Expected Obj, but got I4
		//IL_0314: Expected I, but got Obj
		//IL_0f36: Expected VT, but got I4
		//IL_0f3f: Expected Obj, but got I4
		//IL_0f4e: Expected Obj, but got F4
		//IL_0e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e71: Expected Obj, but got Unknown
		//IL_0363: Expected Obj, but got I4
		//IL_1644: Expected I, but got Obj
		//IL_165a: Expected Obj, but got I
		//IL_121c: Expected I, but got Obj
		//IL_1232: Expected Obj, but got I
		//IL_1120: Expected I, but got Obj
		//IL_1052: Expected VT, but got I4
		//IL_1073: Expected VT, but got I4
		//IL_107c: Expected Obj, but got I4
		//IL_108b: Expected Obj, but got F4
		//IL_03d5: Expected I, but got Obj
		//IL_03eb: Expected Obj, but got I
		//IL_0c0b: Expected Obj, but got I4
		//IL_0463: Expected I, but got Obj
		//IL_1359: Expected I, but got Obj
		//IL_136f: Expected Obj, but got I
		//IL_125d: Expected I, but got Obj
		//IL_118f: Expected VT, but got I4
		//IL_18b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b7: Expected Obj, but got Unknown
		//IL_11b0: Expected VT, but got I4
		//IL_11b9: Expected Obj, but got I4
		//IL_11c8: Expected Obj, but got F4
		//IL_0416: Expected I, but got Obj
		//IL_139a: Expected I, but got Obj
		//IL_12cc: Expected VT, but got I4
		//IL_0501: Expected I, but got Obj
		//IL_0517: Expected Obj, but got I
		//IL_12ed: Expected VT, but got I4
		//IL_12f6: Expected Obj, but got I4
		//IL_1305: Expected Obj, but got F4
		//IL_16b4: Expected I, but got Obj
		//IL_16ca: Expected Obj, but got I
		//IL_04ee: Expected Obj, but got I4
		//IL_1409: Expected VT, but got I4
		//IL_1700: Expected Obj, but got I
		//IL_0542: Expected I, but got Obj
		//IL_142a: Expected VT, but got I4
		//IL_1433: Expected Obj, but got I4
		//IL_1442: Expected Obj, but got F4
		//IL_17bb: Expected I, but got Obj
		//IL_17d1: Expected Obj, but got I
		//IL_058f: Expected I, but got Obj
		//IL_05e5: Expected I, but got Obj
		//IL_05fb: Expected Obj, but got I
		//IL_18f8: Expected I, but got Obj
		//IL_190e: Expected Obj, but got I
		//IL_08ec: Expected I, but got Obj
		//IL_0942: Expected I, but got Obj
		//IL_0958: Expected Obj, but got I
		//IL_0626: Expected I, but got Obj
		//IL_0b90: Expected I, but got Obj
		//IL_0673: Expected I, but got Obj
		//IL_0689: Expected Obj, but got I
		//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Expected Obj, but got Unknown
		//IL_0983: Expected I, but got Obj
		//IL_09b6: Expected I, but got Obj
		//IL_09cc: Expected Obj, but got I
		//IL_06b4: Expected I, but got Obj
		//IL_06e7: Expected I, but got Obj
		//IL_06fd: Expected Obj, but got I
		//IL_09f7: Expected I, but got Obj
		//IL_0a3c: Expected Obj, but got I
		//IL_0a4c: Expected Obj, but got I
		//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected Obj, but got Unknown
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected Obj, but got Unknown
		//IL_0a90: Expected Obj, but got I
		//IL_0aa0: Expected Obj, but got I
		//IL_0ab0: Expected Obj, but got I
		//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abe: Expected Obj, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected Obj, but got Unknown
		//IL_0ae4: Expected I, but got Obj
		//IL_0afa: Expected Obj, but got I
		//IL_0728: Expected I, but got Obj
		//IL_195e: Expected I, but got Obj
		//IL_1974: Expected Obj, but got I
		//IL_19c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ca: Expected Obj, but got Unknown
		//IL_0b25: Expected I, but got Obj
		//IL_0b58: Expected I, but got Obj
		//IL_0798: Expected Obj, but got I
		//IL_07a8: Expected Obj, but got I
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected Obj, but got Unknown
		//IL_07ec: Expected Obj, but got I
		//IL_07fc: Expected Obj, but got I
		//IL_080c: Expected Obj, but got I
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected Obj, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected Obj, but got Unknown
		//IL_0840: Expected I, but got Obj
		//IL_0856: Expected Obj, but got I
		//IL_17fc: Expected I, but got Obj
		//IL_1812: Expected Obj, but got I
		//IL_183e: Expected Obj, but got I4
		//IL_1867: Unknown result type (might be due to invalid IL or missing references)
		//IL_186c: Expected Obj, but got Unknown
		//IL_0881: Expected I, but got Obj
		//IL_08b4: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v377 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		nint num3 = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v371 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		Transform transform = (Transform)(obj3 + 36);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (System.Collections.Generic.Dictionary`2<System.String, InApp.InAppItemModel>)+3C]");
		_popupData = (InAppManagerPopupData)0;
		if (_popupData == null)
		{
			goto IL_0c10;
		}
		nint num5 = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v185 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v345 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppManagerPopupData popupData = _popupData;
		popupTitle.fontSize = (int)popupData.popupTitle;
		int fontSize;
		if (_newCoinPrice != 0)
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v333 (Il2CppClass<Strings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v341 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format = Strings.GetDefault("NOT_ENOUGH_COINS_POPUP_ADD_ON_COINS");
			transform = (Transform)_newCoinPrice;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text = string.Format(format, args);
			fontSize = (int)text;
		}
		else
		{
			nint num9 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S1_v318 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(NotEnoughCurrencyPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v326 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppManagerPopupData popupData2 = _popupData;
			fontSize = (int)popupData2.popupDescription;
		}
		popupDescription.fontSize = fontSize;
		nint num11 = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v119 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v365 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppManagerPopupData popupData3 = _popupData;
		if (~(popupData3.isErrorMessage ? 1u : 0u) == 0)
		{
			uiContentCoins.tag = null;
			uiContentKeys.tag = null;
		}
		else
		{
			nint num13 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v326 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num14 = (nint)typeof(NotEnoughCurrencyPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v355 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppManagerPopupData popupData4 = _popupData;
			if (~(popupData4.isCoinsPack ? 1u : 0u) == 0)
			{
				uiContentCoins.tag = (string)1;
				uiContentKeys.tag = null;
			}
			else
			{
				uiContentCoins.tag = null;
				uiContentKeys.tag = (string)1;
			}
			if (base.parentScreen__BackingField != "CharacterNameEventPopup")
			{
				nint num15 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S0_v342 (Il2CppClass<Flurry>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num16 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ S0_v345 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
			}
		}
		UpdateFirstPurchaseBonusBannerStatus();
		nint num17 = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S0_v130 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num18 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v319 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppManagerPopupData popupData5 = _popupData;
		if (~(popupData5.canMakePurchase ? 1u : 0u) == 0)
		{
			Hide();
			if (CooldownManager.GetChargesUsed("coins") != 0)
			{
				((SecretPopup)this).AppendSection((string)5, (string)(object)emptySpace, SecretPopup.FileLogType.Data);
			}
			nint num19 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S0_v155 (Il2CppClass<AdLocations>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num20 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S0_v312 (Il2CppClass<AdLocations>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((WaterFallReach)(object)AdLocations.FREE_COINS_POPUP_VIDEOS)._002Ector();
			nint num21 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ S0_v163 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num22 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ S0_v308 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S0_v168 (System.Boolean)+60]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ S0_v169+8]");
			if ((nint)0 == 0)
			{
				OfferWallManager instance = OfferWallManager.instance;
				nint num23 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ S1_v268 (Il2CppClass<AdLocations>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num24 = (nint)typeof(AdLocations);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ S1_v299 (Il2CppClass<AdLocations>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((AdSystemManager)(object)instance).IsCaching((string)(object)AdLocations.FREE_COINS_POPUP_VIDEOS))
				{
					nint num25 = (nint)typeof(NotEnoughCurrencyPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ S0_v253 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num26 = (nint)typeof(NotEnoughCurrencyPopup);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ S0_v303 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					InAppManagerPopupData popupData6 = _popupData;
					if (~(popupData6.isCoinsPack ? 1u : 0u) == 0)
					{
						nint num27 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ S1_v277 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj16 = (nint)0 & (nint)0x200;
						if (obj16 != null)
						{
							nint num28 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ S1_v296 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)_coinsForAdButton).FindKernel((string)null) != 0 && CooldownManager.GetChargesUsed("coins") != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ S3_v37 (Il2CppMethodInfo)+C]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ S3_v38+60]");
							object obj18 = 0;
							object obj19 = obj18;
							object obj20 = obj19 & 0x1FFF;
							object obj21 = obj20 + 113696;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1147 @ S4_v16 (should have been resolved before IL gen)");
							nint num30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ S4_v18 (Il2CppMethodInfo)+C]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ S4_v19+60]");
							object obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ S4_v20+48]");
							object obj24 = 0;
							object obj25 = obj24 & 0x7FF;
							object obj26 = obj25 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v573 @ S5_v14 (should have been resolved before IL gen)");
							nint num31 = (nint)typeof(Flurry);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ S0_v276 (Il2CppClass<Flurry>)+BA]");
							object obj27 = (nint)0 & (nint)0x200;
							if (obj27 != null)
							{
								nint num32 = (nint)typeof(Flurry);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ S0_v300 (Il2CppClass<Flurry>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							nint num33 = (nint)typeof(AdLocations);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ S0_v281 (Il2CppClass<AdLocations>)+BA]");
							object obj28 = (nint)0 & (nint)0x200;
							if (obj28 != null)
							{
								nint num34 = (nint)typeof(AdLocations);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1194 @ S0_v295 (Il2CppClass<AdLocations>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							AdTrackingSystemLogger.LogAttemptToShowButtonFlow(AdLocations.FREE_COINS_POPUP_VIDEOS, (string)1);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num35 = 0;
							string text2 = default;
							text2.m_stringLength = (int)num35;
							_ = 0;
							object obj29 = text2 + 16;
							obj29 = this;
							Timer.Log(text2);
							goto IL_187f;
						}
					}
				}
			}
			nint num36 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ S0_v176 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num37 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ S0_v245 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_coinsForAdButton).FindKernel((string)null) != 0)
			{
				OfferWallManager instance2 = OfferWallManager.instance;
				nint num38 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ S1_v241 (Il2CppClass<AdLocations>)+BA]");
				object obj31 = (nint)0 & (nint)0x200;
				if (obj31 != null)
				{
					nint num39 = (nint)typeof(AdLocations);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ S1_v262 (Il2CppClass<AdLocations>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!((AdSystemManager)(object)instance2).IsCaching((string)(object)AdLocations.FREE_COINS_POPUP_VIDEOS))
				{
					nint num40 = (nint)typeof(NotEnoughCurrencyPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ S0_v198 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
					object obj32 = (nint)0 & (nint)0x200;
					if (obj32 != null)
					{
						nint num41 = (nint)typeof(NotEnoughCurrencyPopup);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ S0_v240 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					InAppManagerPopupData popupData7 = _popupData;
					if (~(popupData7.isCoinsPack ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num42 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ S3_v31 (Il2CppMethodInfo)+C]");
						object obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ S3_v32+60]");
						object obj34 = 0;
						object obj35 = obj34;
						object obj36 = obj35 & 0x1FFF;
						object obj37 = obj36 + 113696;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1097 @ S4_v7 (should have been resolved before IL gen)");
						nint num43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ S4_v9 (Il2CppMethodInfo)+C]");
						object obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1105 @ S4_v10+60]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ S4_v11+48]");
						object obj40 = 0;
						object obj41 = obj40 & 0x7FF;
						object obj42 = obj41 + 39195;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v574 @ S5_v8 (should have been resolved before IL gen)");
						nint num44 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1114 @ S0_v213 (Il2CppClass<Flurry>)+BA]");
						object obj43 = (nint)0 & (nint)0x200;
						if (obj43 != null)
						{
							nint num45 = (nint)typeof(Flurry);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ S0_v237 (Il2CppClass<Flurry>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						nint num46 = (nint)typeof(AdLocations);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1128 @ S0_v218 (Il2CppClass<AdLocations>)+BA]");
						object obj44 = (nint)0 & (nint)0x200;
						if (obj44 != null)
						{
							nint num47 = (nint)typeof(AdLocations);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ S0_v232 (Il2CppClass<AdLocations>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						AdTrackingSystemLogger.LogAttemptToShowButtonFlow(AdLocations.FREE_COINS_POPUP_VIDEOS, null);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num48 = 0;
						string text3 = default;
						text3.m_stringLength = (int)num48;
						_ = 0;
						object obj45 = text3 + 16;
						obj45 = this;
						Timer.Log(text3);
						goto IL_187f;
					}
				}
			}
			nint num49 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ S1_v224 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj46 = (nint)0 & (nint)0x200;
			if (obj46 != null)
			{
				nint num50 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ S1_v237 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_coinsForAdButton).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num51 = 0;
				string text4 = default;
				text4.m_stringLength = (int)num51;
				_ = 0;
				object obj47 = text4 + 16;
				obj47 = this;
				Timer.Log(text4);
			}
		}
		else
		{
			_emptySpace.tag = (string)1;
		}
		goto IL_187f;
		IL_0c10:
		nint num52 = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v31 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj48 = (nint)0 & (nint)0x200;
		if (obj48 != null)
		{
			nint num53 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v108 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num54 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj49 = (nint)0 & (nint)0x200;
		if (obj49 != null)
		{
			nint num55 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v180 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_rewardForVideoButton).FindKernel((string)null) != 0)
		{
			nint num56 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v95 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
			object obj50 = (nint)0 & (nint)0x200;
			if (obj50 != null)
			{
				nint num57 = (nint)typeof(NotEnoughCurrencyPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v102 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_rewardForVideoButton.SetState((RewardForVideoButton.VideoState)_videoButtonPayload);
		}
		if (CooldownManager.GetChargesUsed("coins") != 0)
		{
			if (CooldownManager.GetChargesUsed("coins") != 0)
			{
				OfferWallManager instance3 = OfferWallManager.instance;
				nint num58 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S1_v161 (Il2CppClass<AdLocations>)+BA]");
				object obj51 = (nint)0 & (nint)0x200;
				if (obj51 != null)
				{
					nint num59 = (nint)typeof(AdLocations);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S1_v171 (Il2CppClass<AdLocations>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!((AdSystemManager)(object)instance3).IsCaching((string)(object)AdLocations.FREE_COINS_POPUP_VIDEOS))
				{
					object obj52 = this + 132;
					obj52 = "No_caching_failed";
					goto IL_1aaf;
				}
			}
			object obj53 = this + 132;
			obj53 = "Yes";
		}
		else
		{
			object obj54 = this + 132;
			obj54 = "No_caching_not_attempted";
		}
		goto IL_1aaf;
		IL_1aaf:
		nint num60 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj55 = (nint)0 & (nint)0x200;
		if (obj55 != null)
		{
			nint num61 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S1_v148 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform2 = (Transform)(obj3 + 24);
		Transform transform3 = (Transform)(obj3 + 12);
		if (((ComputeShader)(object)_coinsForAdButton).FindKernel((string)null) != 0)
		{
			int layer = _coinsForAdButton.layer;
			int layer2 = _coinsForAdButton.layer;
			transform2.localPosition = (Vector3)layer2;
			int layer3 = _coinsForAdButton.layer;
			transform3.localPosition = (Vector3)layer3;
			obj3 = 0;
			_ = 0;
			obj3 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S1_v24 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			transform = (Transform)obj3;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
		}
		nint num62 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj56 = (nint)0 & (nint)0x200;
		if (obj56 != null)
		{
			nint num63 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S1_v129 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_buyCurrencyButton).FindKernel((string)null) != 0)
		{
			int layer4 = _buyCurrencyButton.layer;
			int layer5 = _buyCurrencyButton.layer;
			transform2.localPosition = (Vector3)layer5;
			int layer6 = _buyCurrencyButton.layer;
			transform3.localPosition = (Vector3)layer6;
			obj3 = 0;
			_ = 0;
			obj3 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S1_v24 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			transform = (Transform)obj3;
			Transform transform5 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles2 = transform.eulerAngles;
		}
		nint num64 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj57 = (nint)0 & (nint)0x200;
		if (obj57 != null)
		{
			nint num65 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S1_v110 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_okButton).FindKernel((string)null) != 0)
		{
			int layer7 = _okButton.layer;
			int layer8 = _okButton.layer;
			transform2.localPosition = (Vector3)layer8;
			int layer9 = _okButton.layer;
			transform3.localPosition = (Vector3)layer9;
			obj3 = 0;
			_ = 0;
			obj3 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S1_v24 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			transform = (Transform)obj3;
			Transform transform6 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles3 = transform.eulerAngles;
		}
		nint num66 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj58 = (nint)0 & (nint)0x200;
		if (obj58 != null)
		{
			nint num67 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S1_v91 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_buyMoreInStorelabel).FindKernel((string)null) != 0)
		{
			int layer10 = _buyMoreInStorelabel.layer;
			int layer11 = _buyMoreInStorelabel.layer;
			transform2.localPosition = (Vector3)layer11;
			int layer12 = _buyMoreInStorelabel.layer;
			transform3.localPosition = (Vector3)layer12;
			obj3 = 0;
			_ = 0;
			obj3 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S1_v24 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			transform = (Transform)obj3;
			Transform transform7 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles4 = transform.eulerAngles;
		}
		nint num68 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj59 = (nint)0 & (nint)0x200;
		if (obj59 != null)
		{
			nint num69 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_firstPurchaseBanner).FindKernel((string)null) != 0)
		{
			int layer13 = _firstPurchaseBanner.layer;
			int layer14 = _firstPurchaseBanner.layer;
			transform2.localPosition = (Vector3)layer14;
			int layer15 = _firstPurchaseBanner.layer;
			transform3.localPosition = (Vector3)layer15;
			obj3 = 0;
			_ = 0;
			obj3 = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S1_v24 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			transform = (Transform)obj3;
			Transform transform8 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles5 = transform.eulerAngles;
		}
		return;
		IL_187f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num70 = 0;
		string text5 = default;
		text5.m_stringLength = (int)num70;
		_ = 0;
		object obj60 = text5 + 16;
		obj60 = this;
		Timer.Log(text5);
		goto IL_0c10;
	}

	private void HideDynamicUiElements()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v8 (System.Boolean)+3C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v9+14]");
		float posZ = 0f * 0.5f;
		TransformExtensions.SetLocalPosZ(_popupContent, posZ);
	}

	private unsafe void ActivateUiElement(UiElementType uiElementType, GameObject prefab, OnActivatedPrefab onActivatedPrefab = null)
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_00d7: Expected I4, but got Obj
		//IL_00d7: Expected VT, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_00d7: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		bool isInstanced = UIScreenController.IsInstanced;
		nint num = (nint)typeof(LimitedBoardPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v11 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts = SellConsumablesHelper.defaultVideoRewardAmounts;
		int currentlyShownThemeIndex = ((LimitedBoardPopupManager)(object)defaultVideoRewardAmounts).currentlyShownThemeIndex;
		NGUITools.FitOnScreen((Camera)isInstanced, (Transform)currentlyShownThemeIndex, (Transform)11, (Vector3)uiElementType, out *(Bounds*)prefab, (byte)(int)onActivatedPrefab != 0);
		((LimitedBoardPopup)this).SetupThemeShifter();
	}

	private void UpdateFirstPurchaseBonusBannerStatus()
	{
		((FooterButton)(object)_uiElementsManager).OnClick();
	}

	protected override string GetFlurryName()
	{
		//IL_01f1: Expected Obj, but got I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		bool flag = ((ConsumablesPopup)this).ShouldShowVideoButton();
		GameObject gameObject = ((DailyChallengePage)(object)_flurryVideoReward)._003CInit_003Eb__17_0((UIWidget)flag);
		object obj = gameObject - 1;
		if ((nint)gameObject != 1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					return "headstart";
				}
				if ((nint)obj != 3 && (nint)obj != 4 && (nint)obj != 5 && (nint)obj != 6 && (nint)obj != 7 && (nint)obj != 8 && (nint)obj != 9 && (nint)obj != 10 && (nint)obj != 11 && (nint)obj != 12 && (nint)obj != 13 && (nint)obj == 14)
				{
					return "score_booster";
				}
			}
			return string.Empty;
		}
		return "hoverboard";
	}

	private void OnFirstPurchaseBonusBannerSpawned(GameObject firstPurchaseBonusBannerGo, bool wasSpawned)
	{
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0093: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_0184: Expected Obj, but got I4
		//IL_00d4: Expected I, but got Obj
		nint num = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.instance;
		instance._overwrittenBoardForNextShowing = wasSpawned;
		((LimitedCharacterPopup)this)._002Ector();
		((LimitedCharacterPopup)this).UpdateSelectedCharacter();
		_buyMoreInStoreLabelPrefab = (GameObject)1;
		if ((wasSpawned ? 1 : 0) <= (false ? 1 : 0))
		{
			return;
		}
		nint num3 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19 (Il2CppClass<Info.Outfits>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v27 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((OutfitSet)(object)firstPurchaseBonusBannerGo).HasOutfitWithName((string)wasSpawned);
		if (flag)
		{
			string stateString = ((LimitedCharacterPopup)null).GetStateString(flag);
			((List<string>)(object)_okButtonPrefab).Add(stateString);
		}
	}

	private void OnOkButtonActivated(GameObject okButtonGo, bool wasSpawned)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 124;
		obj = okButtonGo;
		UIWidget component = okButtonGo.GetComponent<UIWidget>();
		component.height = 305;
	}

	private unsafe void OnVideoForCoinsActivated(GameObject coinVideoGo, bool wasSpawned)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got VT
		if (wasSpawned)
		{
			object obj = this + 116;
			obj = coinVideoGo;
			_0021_00210 componentInChildren = (_0021_00210)coinVideoGo.GetComponentInChildren<T>();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(NotEnoughCurrencyPopup.OnOkClicked);
			object obj2 = action + 16;
			obj2 = this;
			((OkButtonHelper)componentInChildren).OkButtonClicked -= action;
		}
	}

	private void OnCurrencyOfferActivated(GameObject currencyButtonGo, bool wasSpawned)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_0125: Expected I4, but got Obj
		//IL_0082: Expected I, but got Obj
		//IL_00b2: Expected I, but got Obj
		//IL_00d8: Expected I, but got Obj
		if (!wasSpawned)
		{
			return;
		}
		object obj = this + 108;
		obj = currencyButtonGo;
		RewardForVideoButton component = currencyButtonGo.GetComponent<RewardForVideoButton>();
		nint num = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v12 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		nint num2 = (nint)typeof(NotEnoughCurrencyPopup);
		if (!flag)
		{
			nint num3 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(NotEnoughCurrencyPopup);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(NotEnoughCurrencyPopup);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ L1_v3 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+5C]");
		object obj3 = (nint)0 + (nint)4;
		obj3 = component;
		_rewardForVideoButton.SetState((RewardForVideoButton.VideoState)_videoButtonPayload);
	}

	private void OnBuyMoreInStoreLabelActivated(GameObject activatedGo, bool wasSpawned)
	{
	}

	public override void Hide()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_emptySpace.tag = (string)1;
	}

	public void OnOkClicked()
	{
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0107: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I4
		base.LoseFocus();
		if (_closingAction == PopupClosingAction.None)
		{
			object obj = this + 140;
			obj = "-1";
			object obj2 = this + 136;
			obj2 = "Closed";
			object obj3 = this + 144;
			string text = ((Cooldowns)(object)"coins").AsString();
			string text3;
			if (text != null)
			{
				string text2 = ((Cooldowns)(object)"coins").AsString();
				object obj4 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args = default;
				text3 = $"Cooldown_{args}_watched";
			}
			else
			{
				text3 = "No Cooldown";
			}
			obj3 = text3;
			((SecretPopup)this).CacheStateChangedForLocation((string)2);
		}
		_closingAction = PopupClosingAction.None;
		nint num = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v15 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v33 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_popupData = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action = default;
		object obj6 = action + 16;
		obj6 = this;
		AdSystemManager.onWillShowInterstitial += action;
		_newCoinPrice = 0;
	}

	public void OnBuyClicked()
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_01a8: Expected Obj, but got I4
		//IL_01b6: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I
		//IL_005d: Expected I, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I4
		//IL_00eb: Expected I, but got Obj
		object obj = this + 140;
		obj = "-1";
		object obj2 = this + 136;
		obj2 = "Closed";
		object obj3 = this + 144;
		string text = ((Cooldowns)(object)"coins").AsString();
		string text3;
		if (text != null)
		{
			string text2 = ((Cooldowns)(object)"coins").AsString();
			object obj4 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			text3 = $"Cooldown_{args}_watched";
		}
		else
		{
			text3 = "No Cooldown";
		}
		obj3 = text3;
		_closingAction = PopupClosingAction.Ok;
		((SecretPopup)this).CacheStateChangedForLocation((string)_closingAction);
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v36 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController instance = UIScreenController.Instance;
		if ((object)instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v26 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v32 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
	}

	public void OnCancelClicked()
	{
		//IL_0276: Expected I, but got Obj
		//IL_028c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0346: Expected I, but got Obj
		//IL_035c: Expected Obj, but got I
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_031f: Expected Obj, but got I4
		//IL_03b7: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I4
		//IL_012f: Expected I, but got Obj
		//IL_0229: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v59 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController instance = UIScreenController.Instance;
		if ((object)instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v55 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppManager instance2 = InAppManager.instance;
		if ((object)instance2 == null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v45 (Il2CppClass<UIScreenController>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v51 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			text.m_stringLength = 7;
			object obj4 = text + 12;
			obj4 = "Purchase Failed";
			((UIScreenController)flag)._QueueMessage(text);
			return;
		}
		object obj5 = this + 140;
		obj5 = "-1";
		object obj6 = this + 136;
		obj6 = "IAP";
		object obj7 = this + 144;
		string text2 = ((Cooldowns)(object)"coins").AsString();
		string text4;
		if (text2 != null)
		{
			string text3 = ((Cooldowns)(object)"coins").AsString();
			object obj8 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			text4 = $"Cooldown_{args}_watched";
		}
		else
		{
			text4 = "No Cooldown";
		}
		obj7 = text4;
		_closingAction = PopupClosingAction.Buy;
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v33 (Il2CppClass<UIScreenController>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v40 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).ClosePopup((GameObject)(object)screenName);
		((SecretPopup)this).CacheStateChangedForLocation((string)_closingAction);
	}

	private void Payout(PopupClosingAction action)
	{
		//IL_01df: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected I4, but got Unknown
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_028e: Expected Obj, but got I4
		//IL_029c: Expected I, but got Obj
		//IL_02b2: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I4
		//IL_0145: Expected I, but got Obj
		//IL_0192: Expected I, but got Obj
		nint num = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v55 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppManagerPopupData popupData = _popupData;
		if (~(popupData.isCoinsPack ? 1u : 0u) != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v49 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppManagerPopupData popupData2 = _popupData;
		VideoButtonPayload videoButtonPayload = CreateButtonPayload();
		int newCoinPrice = popupData2.currencyMissing - videoButtonPayload;
		_newCoinPrice = newCoinPrice;
		if (_newCoinPrice >= 1)
		{
			CenterSelf();
			return;
		}
		_newCoinPrice = 0;
		nint num5 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v26 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v44 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		object obj4 = activeInAppOffers + 60;
		obj4 = 0;
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v34 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v40 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag)._RemovePopup(screenName);
	}

	public NotEnoughCurrencyPopup()
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_01a8: Expected Obj, but got I4
		//IL_01b6: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I
		//IL_005d: Expected I, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I4
		//IL_00eb: Expected I, but got Obj
		object obj = this + 140;
		obj = "-1";
		object obj2 = this + 136;
		obj2 = "Closed";
		object obj3 = this + 144;
		string text = ((Cooldowns)(object)"coins").AsString();
		string text3;
		if (text != null)
		{
			string text2 = ((Cooldowns)(object)"coins").AsString();
			object obj4 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			text3 = $"Cooldown_{args}_watched";
		}
		else
		{
			text3 = "No Cooldown";
		}
		obj3 = text3;
		_closingAction = PopupClosingAction.Cancel;
		((SecretPopup)this).CacheStateChangedForLocation((string)_closingAction);
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v36 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController instance = UIScreenController.Instance;
		if ((object)instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v26 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v32 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)"NotEnoughCurrencyPopup");
	}

	private void _003CRefreshPopupContent_003Eb__46_2()
	{
		((UpgradeScreen)this).Start();
	}

	private void _003CRefreshPopupContent_003Eb__46_3()
	{
		//IL_0010: Expected Obj, but got I4
		_coinsForAdButton.tag = (string)1;
	}

	private void _003CRefreshPopupContent_003Eb__46_0()
	{
		_coinsForAdButton.tag = null;
	}

	private void _003CRefreshPopupContent_003Eb__46_1()
	{
		_coinsForAdButton.tag = null;
	}
}
