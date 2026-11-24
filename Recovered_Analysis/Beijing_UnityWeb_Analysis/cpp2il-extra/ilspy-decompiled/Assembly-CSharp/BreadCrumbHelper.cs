using System;
using System.Collections;
using System.Collections.Generic;
using AppRefresh;
using Cpp2ILInjected;
using Data.DebugUtil;
using Data.Save;
using InApp;
using InAppPurchase;
using Missions;
using SYBO.Subway.Info;
using UI;
using UI.Screens;
using UI.Screens.RewardManagement;
using UI.SlideIns;
using UI.VideoAdPrizes;
using UnityEngine;
using UnityEngine.UI;

public class BreadCrumbHelper : MonoBehaviour
{
	private enum BreadCrumbStates
	{
		inactive,
		giftCharacter,
		giftBoard,
		boardEventActive,
		expiredLimitedCharacter,
		biggerJackpot,
		earnKeys,
		collectAward,
		expiredLimitedBoard,
		topRun,
		characterDay,
		facebookGift,
		sale,
		specialSale,
		collectableCharacter
	}

	private enum BreadCrumbLocations
	{
		meButton,
		shopButton,
		hoverboardsButton,
		charactersButton,
		upgradesFooter,
		upgradesScroll,
		earnCoinsFooterButton,
		earnCoinsVideoButton,
		mysteryBoxPrizeList,
		awardsButton,
		friendsButton,
		topRunButton,
		topRunTab,
		facebookGiftButton,
		characterCollectButton
	}

	private UISprite _sticker;

	private UISprite _stickerShadow;

	private UISprite _giftIcon;

	private UISprite _earnKeysIcon;

	private UISprite _eventIcon;

	private UISprite _awardIcon;

	private UISprite _topRunIcon;

	private UISprite _collectableCharacterIcon;

	private GameObject _notification;

	private GameObject _discount;

	private BreadCrumbStates _currentState;

	private BreadCrumbLocations _currentLocation;

	private bool _isApplicationResuming;

	public bool IsAnyBreadCrumbActive => _currentLocation != BreadCrumbLocations.meButton;

	private void OnEnable()
	{
		CancelInvoke();
	}

	private unsafe void OnDisable()
	{
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02b2: Expected I, but got Obj
		//IL_02c8: Expected Obj, but got I
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_016c: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_00e0: Expected I, but got Obj
		//IL_01ad: Expected I, but got Obj
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(BreadCrumbHelper.SetupBreadCrumbState);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v90 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventStartedHandler -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(BreadCrumbHelper.SetupBreadCrumbState);
		object obj3 = action2 + 16;
		obj3 = this;
		SSEventsManagerController.OnSSEventChangedHandler -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		FirstPurchaseBonusBecameInactive firstPurchaseBonusBecameInactive = default;
		((Delegate)firstPurchaseBonusBecameInactive).method_ptr = method_ptr3;
		((Delegate)firstPurchaseBonusBecameInactive).method = (nint)__ldftn(BreadCrumbHelper.SetupBreadCrumbState);
		object obj4 = firstPurchaseBonusBecameInactive + 16;
		obj4 = this;
		nint num3 = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v31 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v86 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FirstPurchaseBonusManager.onFirstPurchaseBonusBecameInactive -= firstPurchaseBonusBecameInactive;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr4;
		((Delegate)action3).method = (nint)__ldftn(BreadCrumbHelper.DisableBreadCrumbElements);
		object obj6 = action3 + 16;
		obj6 = this;
		SSEventsManagerController.OnSSEventFinishedHandler -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr5;
		((Delegate)action4).method = (nint)__ldftn(BreadCrumbHelper.DisableEventBreadcrumb);
		object obj7 = action4 + 16;
		obj7 = this;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v50 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v82 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action4;
		if (_currentLocation == BreadCrumbLocations.earnCoinsFooterButton)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			_ = 0;
			Action<string, bool> action5 = default;
			object obj9 = action5 + 16;
			obj9 = this;
			AdSystemManager.onCachedVideo -= action5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num8 = 0;
			_ = 0;
			Action<string> action6 = default;
			object obj10 = action6 + 16;
			obj10 = this;
			AdSystemManager.onFailedToCacheVideo -= action6;
		}
		SetMeBreadcrumbState();
	}

	private void OnApplicationPause(bool paused)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_002c: Expected Obj, but got I4
		if (paused)
		{
			object obj = this + 44;
			obj = paused;
		}
		((AwardFinishedCellHelper)this).SetupCellContent();
		((AwardFinishedCellHelper)this).SetupCellColors();
		((AwardFinishedCellHelper)this)._002Ector();
	}

	private void OnApplicationFocus(bool focus)
	{
		if (!focus)
		{
			_isApplicationResuming = true;
		}
	}

	private void _PauseApplication(bool paused)
	{
		//IL_0068: Expected Obj, but got I4
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 7)
		{
			return;
		}
		string dataPath2 = Application.dataPath;
		if (dataPath2 != null)
		{
			object obj = (paused ? 1 : 0) ^ 1;
			if (obj == null)
			{
				_isApplicationResuming = true;
			}
		}
	}

	private unsafe void LateUpdate()
	{
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_0416: Expected I, but got Obj
		//IL_042c: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		//IL_0185: Expected I, but got Obj
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_026e: Expected I, but got Obj
		//IL_0284: Expected Obj, but got I
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0534: Expected I, but got Obj
		//IL_054a: Expected Obj, but got I
		//IL_02af: Expected I, but got Obj
		//IL_02fc: Expected I, but got Obj
		//IL_0349: Expected I, but got Obj
		//IL_035f: Expected Obj, but got I
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected Obj, but got Unknown
		//IL_038a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(BreadCrumbHelper.SetupBreadCrumbState);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v114 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventFinishedHandler += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		SSEventsManagerController sSEventsManagerController = default;
		sSEventsManagerController._currentEventManager = (IEventManager)num3;
		_ = 0;
		object obj3 = sSEventsManagerController + 16;
		obj3 = this;
		sSEventsManagerController.Initialize();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		RefreshType refreshType = default;
		object obj4 = refreshType + 16;
		obj4 = this;
		nint num5 = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v31 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v110 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FirstPurchaseBonusManager.AppWillRefresh(refreshType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(BreadCrumbHelper.DisableBreadCrumbElements);
		object obj6 = action2 + 16;
		obj6 = this;
		SSEventsManagerController.OnSSEventChangedHandler += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj7 = action3 + 16;
		obj7 = this;
		nint num8 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v50 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num9 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v106 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action3;
		if (_currentLocation == BreadCrumbLocations.earnCoinsFooterButton)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num10 = 0;
			_ = 0;
			Action<string> action4 = default;
			object obj9 = action4 + 16;
			obj9 = this;
			AdSystemManager.onFailedToCacheVideo += action4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num11 = 0;
			_ = 0;
			Action<string> action5 = default;
			object obj10 = action5 + 16;
			obj10 = this;
			AdSystemManager.onFinishedWatchingVideo += action5;
		}
		if (_currentLocation != BreadCrumbLocations.shopButton)
		{
			return;
		}
		nint num12 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v64 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num13 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v82 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		nint num14 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v59 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)activeInAppOffers).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num16 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v72 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num17 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v78 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
		((Delegate)onPurchaseSuccess).method_ptr = method_ptr3;
		((Delegate)onPurchaseSuccess).method = (nint)__ldftn(BreadCrumbHelper.SetupBreadCrumbState);
		object obj14 = onPurchaseSuccess + 16;
		obj14 = this;
		((InAppManager)(object)activeInAppOffers2).onPurchaseSuccess += onPurchaseSuccess;
	}

	private void OnVideoStateChanged(string adLocationId)
	{
		if (adLocationId == null)
		{
			_isApplicationResuming = true;
		}
	}

	private unsafe void OnVideoStateChanged(string adLocationId, bool wasAlreadyCached)
	{
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected VT, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected Obj, but got Unknown
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected Obj, but got Unknown
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected Obj, but got Unknown
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected Obj, but got Unknown
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected Obj, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected Obj, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected Obj, but got Unknown
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected Obj, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected Obj, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected Obj, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I4
		//IL_0128: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_08aa: Expected Obj, but got VT
		//IL_08bf: Expected F4, but got Obj
		//IL_08ba: Expected native int or pointer, but got VT
		//IL_08d9: Expected F4, but got Obj
		//IL_08d4: Expected native int or pointer, but got VT
		//IL_08ee: Expected F4, but got I
		//IL_08e9: Expected native int or pointer, but got VT
		//IL_08fd: Expected I4, but got VT
		//IL_092e: Expected Obj, but got VT
		//IL_0943: Expected F4, but got Obj
		//IL_093e: Expected native int or pointer, but got VT
		//IL_025a: Expected I, but got Obj
		//IL_0270: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0adc: Expected F4, but got Obj
		//IL_0ad7: Expected native int or pointer, but got VT
		//IL_0af1: Expected F4, but got I
		//IL_0aec: Expected native int or pointer, but got VT
		//IL_0b00: Expected I4, but got VT
		//IL_020d: Expected I, but got Obj
		//IL_090b: Expected Obj, but got VT
		//IL_0920: Expected F4, but got Obj
		//IL_091b: Expected native int or pointer, but got VT
		//IL_019c: Expected I, but got Obj
		//IL_0975: Expected Obj, but got VT
		//IL_098a: Expected F4, but got Obj
		//IL_0985: Expected native int or pointer, but got VT
		//IL_038c: Expected I, but got Obj
		//IL_03a2: Expected Obj, but got I
		//IL_0b1f: Expected F4, but got Obj
		//IL_0b1a: Expected native int or pointer, but got VT
		//IL_0b34: Expected F4, but got I
		//IL_0b2f: Expected native int or pointer, but got VT
		//IL_0b43: Expected I4, but got VT
		//IL_033f: Expected I, but got Obj
		//IL_0952: Expected Obj, but got VT
		//IL_0967: Expected F4, but got Obj
		//IL_0962: Expected native int or pointer, but got VT
		//IL_02ce: Expected I, but got Obj
		//IL_09bb: Expected Obj, but got VT
		//IL_09d0: Expected F4, but got Obj
		//IL_09cb: Expected native int or pointer, but got VT
		//IL_04be: Expected I, but got Obj
		//IL_04d4: Expected Obj, but got I
		//IL_0b62: Expected F4, but got Obj
		//IL_0b5d: Expected native int or pointer, but got VT
		//IL_0b77: Expected F4, but got I
		//IL_0b72: Expected native int or pointer, but got VT
		//IL_0b86: Expected I4, but got VT
		//IL_0471: Expected I, but got Obj
		//IL_0998: Expected Obj, but got VT
		//IL_09ad: Expected F4, but got Obj
		//IL_09a8: Expected native int or pointer, but got VT
		//IL_0400: Expected I, but got Obj
		//IL_0a01: Expected Obj, but got VT
		//IL_0a16: Expected F4, but got Obj
		//IL_0a11: Expected native int or pointer, but got VT
		//IL_05f0: Expected I, but got Obj
		//IL_0606: Expected Obj, but got I
		//IL_0623: Expected Obj, but got I4
		//IL_0ba5: Expected F4, but got Obj
		//IL_0ba0: Expected native int or pointer, but got VT
		//IL_0bba: Expected F4, but got I
		//IL_0bb5: Expected native int or pointer, but got VT
		//IL_0bc9: Expected I4, but got VT
		//IL_05a3: Expected I, but got Obj
		//IL_09de: Expected Obj, but got VT
		//IL_09f3: Expected F4, but got Obj
		//IL_09ee: Expected native int or pointer, but got VT
		//IL_0532: Expected I, but got Obj
		//IL_0aa8: Expected Obj, but got VT
		//IL_0abd: Expected F4, but got Obj
		//IL_0ab8: Expected native int or pointer, but got VT
		//IL_0a24: Expected Obj, but got VT
		//IL_0a39: Expected F4, but got Obj
		//IL_0a34: Expected native int or pointer, but got VT
		//IL_0a53: Expected F4, but got Obj
		//IL_0a4e: Expected native int or pointer, but got VT
		//IL_0a68: Expected F4, but got I
		//IL_0a63: Expected native int or pointer, but got VT
		//IL_0a77: Expected I4, but got VT
		//IL_0be8: Expected F4, but got Obj
		//IL_0be3: Expected native int or pointer, but got VT
		//IL_0bfd: Expected F4, but got I
		//IL_0bf8: Expected native int or pointer, but got VT
		//IL_0c0c: Expected I4, but got VT
		//IL_077f: Expected I, but got Obj
		//IL_0a85: Expected Obj, but got VT
		//IL_0a9a: Expected F4, but got Obj
		//IL_0a95: Expected native int or pointer, but got VT
		//IL_0680: Expected I, but got Obj
		//IL_070e: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 72);
		object obj2 = obj + 16;
		object obj3 = obj - -64;
		object obj4 = obj + 60;
		object obj5 = obj + 56;
		object obj6 = obj + 52;
		object obj7 = obj + 48;
		object obj8 = obj + 44;
		object obj9 = obj + 40;
		object obj10 = obj + 36;
		object obj11 = obj + 32;
		object obj12 = obj + 28;
		object obj13 = obj + 24;
		object obj14 = obj + 20;
		if (_currentLocation != BreadCrumbLocations.meButton)
		{
			nint num = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v197 (Il2CppClass<GlobalColors>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num2 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v208 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.TOPRUN_ME_PLAYER_BACKGROUND_COLOUR;
			obj3 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_collectableCharacterIcon.rawPivot = (UIWidget.Pivot)matrix4x;
			return;
		}
		object obj16 = (wasAlreadyCached ? 1 : 0) - 1;
		if (!wasAlreadyCached)
		{
			if ((nint)obj16 != 1)
			{
				if ((nint)obj16 != 2)
				{
					if ((nint)obj16 == 3)
					{
						nint num3 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S1_v125 (Il2CppClass<GlobalColors>)+BA]");
						object obj17 = (nint)0 & (nint)0x200;
						bool flag = obj17 == null;
						if (adLocationId != null)
						{
							if (!flag)
							{
								nint num4 = (nint)typeof(GlobalColors);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S1_v153 (Il2CppClass<GlobalColors>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR;
							obj10 = obj2;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
						}
						else
						{
							if (!flag)
							{
								nint num5 = (nint)typeof(GlobalColors);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S1_v141 (Il2CppClass<GlobalColors>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_LIGHT_COLOUR;
							obj11 = obj2;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
						}
						Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						_collectableCharacterIcon.rawPivot = (UIWidget.Pivot)matrix4x;
						return;
					}
					nint num6 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v53 (Il2CppClass<GlobalColors>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					bool flag2 = obj18 == null;
					object obj19 = (wasAlreadyCached ? 1 : 0) + -5;
					if ((nint)obj19 >= 6)
					{
						if (!flag2)
						{
							nint num7 = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v100 (Il2CppClass<GlobalColors>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR;
						obj14 = obj2;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
						Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						_collectableCharacterIcon.rawPivot = (UIWidget.Pivot)matrix4x;
						return;
					}
					if (adLocationId != null)
					{
						if (!flag2)
						{
							nint num8 = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S0_v84 (Il2CppClass<GlobalColors>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR;
						obj12 = obj2;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
					}
					else
					{
						if (!flag2)
						{
							nint num9 = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S0_v72 (Il2CppClass<GlobalColors>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_LIGHT_COLOUR;
						obj13 = obj2;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
					}
					Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					_collectableCharacterIcon.rawPivot = (UIWidget.Pivot)matrix4x;
					return;
				}
				nint num10 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v90 (Il2CppClass<GlobalColors>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				bool flag3 = obj20 == null;
				if (adLocationId != null)
				{
					if (!flag3)
					{
						nint num11 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S1_v118 (Il2CppClass<GlobalColors>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR;
					obj8 = obj2;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
				}
				else
				{
					if (!flag3)
					{
						nint num12 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S1_v106 (Il2CppClass<GlobalColors>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_LIGHT_COLOUR;
					obj9 = obj2;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
				}
				Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_collectableCharacterIcon.rawPivot = (UIWidget.Pivot)matrix4x;
				return;
			}
			nint num13 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v55 (Il2CppClass<GlobalColors>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			bool flag4 = obj21 == null;
			if (adLocationId != null)
			{
				if (!flag4)
				{
					nint num14 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S1_v83 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR;
				obj6 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			}
			else
			{
				if (!flag4)
				{
					nint num15 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S1_v71 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_LIGHT_COLOUR;
				obj7 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
			}
			Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_collectableCharacterIcon.rawPivot = (UIWidget.Pivot)matrix4x;
			return;
		}
		nint num16 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v20 (Il2CppClass<GlobalColors>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		bool flag5 = obj22 == null;
		if (adLocationId != null)
		{
			if (!flag5)
			{
				nint num17 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v48 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		}
		else
		{
			if (!flag5)
			{
				nint num18 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v36 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_LIGHT_COLOUR;
			obj5 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		}
		Matrix4x4 matrix4x8 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_collectableCharacterIcon.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	public void SetupBreadCrumbState()
	{
		if (~(_isApplicationResuming ? 1u : 0u) == 0)
		{
			_isApplicationResuming = false;
			SetMeBreadcrumbState();
		}
	}

	private void SetMeBreadcrumbState()
	{
		//IL_0224: Expected Obj, but got I4
		//IL_024a: Expected Obj, but got I4
		_currentState = BreadCrumbStates.inactive;
		if (_currentLocation != BreadCrumbLocations.meButton)
		{
			if (_currentLocation != BreadCrumbLocations.shopButton)
			{
				if (_currentLocation != BreadCrumbLocations.hoverboardsButton)
				{
					if (_currentLocation != BreadCrumbLocations.charactersButton)
					{
						if (_currentLocation != BreadCrumbLocations.upgradesFooter)
						{
							if (_currentLocation != BreadCrumbLocations.upgradesScroll)
							{
								if (_currentLocation != BreadCrumbLocations.earnCoinsFooterButton)
								{
									if (_currentLocation != BreadCrumbLocations.earnCoinsVideoButton)
									{
										if (_currentLocation != BreadCrumbLocations.mysteryBoxPrizeList)
										{
											if (_currentLocation != BreadCrumbLocations.awardsButton)
											{
												if (_currentLocation != BreadCrumbLocations.friendsButton && _currentLocation != BreadCrumbLocations.topRunButton && _currentLocation != BreadCrumbLocations.topRunTab)
												{
													if (_currentLocation != BreadCrumbLocations.facebookGiftButton)
													{
														if (_currentLocation == BreadCrumbLocations.characterCollectButton)
														{
															SetupBreadCrumb();
														}
													}
													else
													{
														SetTopRunBreadcrumbState();
													}
												}
												else
												{
													SetCharacterCollectButtonState();
												}
											}
											else
											{
												SetShopBreadcrumbState();
											}
										}
										else
										{
											((BundleContentSlot)this).UpdateAmount((string)1);
										}
									}
									else
									{
										SetFacebookGiftBreadcrumbState();
									}
								}
								else
								{
									SetEarnCoinsVideoBreadcrumbState();
								}
							}
							else
							{
								((BundleContentSlot)this).UpdateAmount((string)1);
							}
						}
						else
						{
							((BundleContentSlot)this).UpdateAmount((string)null);
						}
					}
					else
					{
						SetAwardsBreadcrumbState();
					}
				}
				else
				{
					SetCharacterBreadcrumbState();
				}
			}
			else
			{
				SetEarnCoinsBreadcrumbState();
			}
		}
		else
		{
			SetHoverboardBreadcrumbState();
		}
		EnableBreadCrumbElements();
	}

	private unsafe void SetHoverboardBreadcrumbState()
	{
		//IL_025e: Expected I, but got Obj
		//IL_0274: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_029f: Expected I, but got Obj
		//IL_02b5: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		object obj2 = default;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		}
		else
		{
			obj2 = 0;
		}
		nint num3 = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v15 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v39 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionsManager instance = MissionsManager.Instance;
		List<Award> sortedListAwards = ((AwardsManager)(object)instance).GetSortedListAwards(out *(bool*)2);
		if (sortedListAwards._size < 1)
		{
			object obj4 = obj2 - 1;
			if ((nint)obj2 != 1)
			{
				if ((nint)obj4 != 1)
				{
					if ((nint)obj4 == 2)
					{
						_currentState = BreadCrumbStates.expiredLimitedCharacter;
						return;
					}
					if ((nint)obj4 != 3 && (nint)obj4 != 4)
					{
						if ((nint)obj4 == 5)
						{
							_currentState = BreadCrumbStates.expiredLimitedBoard;
							return;
						}
						if ((nint)obj4 == 6)
						{
							_currentState = BreadCrumbStates.characterDay;
							return;
						}
					}
				}
				if (((BreadCrumbHelper)null).ShouldShowCharactersGiftSticker())
				{
					_currentState = BreadCrumbStates.giftBoard;
				}
				else if (((BreadCrumbHelper)null).ShouldShowCollectableCharacterSticker())
				{
					_currentState = BreadCrumbStates.giftCharacter;
				}
			}
			else
			{
				_currentState = BreadCrumbStates.boardEventActive;
			}
		}
		else
		{
			_currentState = BreadCrumbStates.collectAward;
		}
	}

	private void SetCharacterBreadcrumbState()
	{
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_032c: Expected I, but got Obj
		//IL_0342: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v61 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v57 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag2).DelayHideMainCamera();
		bool flag3 = enumerator == null;
		bool flag4 = !flag3;
		IEnumerator a = enumerator;
		if (!flag4)
		{
			a = (IEnumerator)(object)string.Empty;
		}
		if (string.Equals((string)(object)a, "BoardScreen"))
		{
			return;
		}
		nint num5 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v28 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v49 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId2 = Flurry.flurryUserId;
		if (((SSEventsManagerController)(object)flurryUserId2).IsAnyEventEnabled())
		{
			return;
		}
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj4 = default;
			if ((nint)obj4 == 1)
			{
				_currentState = BreadCrumbStates.boardEventActive;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj5 = default;
			if ((nint)obj5 == 6)
			{
				_currentState = BreadCrumbStates.expiredLimitedBoard;
				return;
			}
		}
		if (((BreadCrumbHelper)null).ShouldShowCharactersGiftSticker())
		{
			_currentState = BreadCrumbStates.giftBoard;
		}
	}

	private void SetAwardsBreadcrumbState()
	{
		//IL_0168: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I
		//IL_0264: Expected I, but got Obj
		//IL_027a: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v48 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v44 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag2).DelayHideMainCamera();
		bool flag3 = enumerator == null;
		bool flag4 = !flag3;
		IEnumerator a = enumerator;
		if (!flag4)
		{
			a = (IEnumerator)(object)string.Empty;
		}
		if (string.Equals((string)(object)a, "CharacterScreen"))
		{
			return;
		}
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj3 = default;
			if ((nint)obj3 == 3)
			{
				_currentState = BreadCrumbStates.expiredLimitedCharacter;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj4 = default;
			if ((nint)obj4 == 7)
			{
				_currentState = BreadCrumbStates.characterDay;
				return;
			}
		}
		if (((BreadCrumbHelper)null).ShouldShowCollectableCharacterSticker())
		{
			_currentState = BreadCrumbStates.giftCharacter;
		}
	}

	private void SetUpgradesBreadcrumbState(bool isPopup)
	{
		//IL_000c: Expected VT, but got I4
		TrySetColor(null, (Color)0);
	}

	private unsafe void SetShopBreadcrumbState()
	{
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		bool flag2 = enumerator == null;
		bool flag3 = !flag2;
		IEnumerator a = enumerator;
		if (!flag3)
		{
			a = (IEnumerator)(object)string.Empty;
		}
		if (string.Equals((string)(object)a, "AwardsScreen"))
		{
			return;
		}
		nint num3 = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v30 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionsManager instance = MissionsManager.Instance;
		List<Award> sortedListAwards = ((AwardsManager)(object)instance).GetSortedListAwards(out *(bool*)2);
		if (sortedListAwards._size > 0)
		{
			_currentState = BreadCrumbStates.collectAward;
		}
	}

	private void SetEarnCoinsBreadcrumbState()
	{
		//IL_0458: Expected I, but got Obj
		//IL_046e: Expected Obj, but got I
		//IL_05de: Expected I, but got Obj
		//IL_05f4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00e3: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0124: Expected I, but got Obj
		//IL_061f: Expected I, but got Obj
		//IL_0635: Expected Obj, but got I
		//IL_0171: Expected I, but got Obj
		//IL_0187: Expected Obj, but got I
		//IL_02df: Expected I, but got Obj
		//IL_01b2: Expected I, but got Obj
		//IL_032c: Expected I, but got Obj
		//IL_0342: Expected Obj, but got I
		//IL_01ff: Expected I, but got Obj
		//IL_0215: Expected Obj, but got I
		//IL_036d: Expected I, but got Obj
		//IL_0240: Expected I, but got Obj
		//IL_03ba: Expected I, but got Obj
		//IL_03d0: Expected Obj, but got I
		//IL_03fb: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v95 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v91 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_giftIcon).FindKernel((string)null) != 0)
		{
			string debugSaveDirectory = SaveGameDebug.debugSaveDirectory;
			if (debugSaveDirectory != null)
			{
				_currentState = BreadCrumbStates.facebookGift;
				return;
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_discount))
		{
			nint num7 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v65 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v83 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (InAppManager.IsDoubleCoinsDiscountActive)
			{
				nint num9 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v72 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v79 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (InAppManager.IsWinterHolidaySpecialSaleActive)
				{
					_currentState = BreadCrumbStates.specialSale;
					return;
				}
			}
		}
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj6 = default;
			if ((nint)obj6 == 4)
			{
				_currentState = BreadCrumbStates.biggerJackpot;
				return;
			}
		}
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_discount))
		{
			return;
		}
		nint num13 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v35 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num14 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v56 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!InAppManager.IsAnyCurrencyDiscountActive)
		{
			nint num15 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v45 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num16 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v52 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!InAppManager.IsDoubleCoinsDiscountActive)
			{
				return;
			}
		}
		_currentState = BreadCrumbStates.sale;
	}

	private void SetEarnCoinsVideoBreadcrumbState()
	{
		//IL_01d9: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		bool flag2 = enumerator == null;
		bool flag3 = !flag2;
		IEnumerator a = enumerator;
		if (!flag3)
		{
			a = (IEnumerator)(object)string.Empty;
		}
		if (string.Equals((string)(object)a, "EarnCoinsScreen"))
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_giftIcon).FindKernel((string)null) != 0)
		{
			string debugSaveDirectory = SaveGameDebug.debugSaveDirectory;
			if (debugSaveDirectory != null)
			{
				_currentState = BreadCrumbStates.facebookGift;
				return;
			}
		}
		SlideInData instance = SlideInData.instance;
		if (!((VideoAdPrizeManager)(object)instance).AbleToWatchAVideoForKeysToday())
		{
			return;
		}
		OfferWallManager instance2 = OfferWallManager.instance;
		nint num5 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v15 (Il2CppClass<AdLocations>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v23 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((AdSystemManager)(object)instance2).IsCaching((string)(object)AdLocations.EARN_COINS_VIDEOS))
		{
			_currentState = BreadCrumbStates.earnKeys;
		}
	}

	private void SetFacebookGiftBreadcrumbState()
	{
		//IL_001c: Expected I, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_005d: Expected I, but got Obj
		SlideInData instance = SlideInData.instance;
		if (!((VideoAdPrizeManager)(object)instance).AbleToWatchAVideoForKeysToday())
		{
			return;
		}
		OfferWallManager instance2 = OfferWallManager.instance;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v5 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v13 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((AdSystemManager)(object)instance2).IsCaching((string)(object)AdLocations.EARN_COINS_VIDEOS))
		{
			_currentState = BreadCrumbStates.earnKeys;
		}
	}

	private void SetTopRunBreadcrumbState()
	{
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_giftIcon).FindKernel((string)null) != 0)
		{
			string debugSaveDirectory = SaveGameDebug.debugSaveDirectory;
			if (debugSaveDirectory != null)
			{
				_currentState = BreadCrumbStates.facebookGift;
			}
		}
	}

	private void SetCharacterCollectButtonState()
	{
		//IL_0326: Expected I, but got Obj
		//IL_033c: Expected Obj, but got I
		//IL_040d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_00d6: Expected I, but got Obj
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I4
		//IL_0217: Expected I, but got Obj
		//IL_022d: Expected Obj, but got I
		//IL_01ca: Expected I, but got Obj
		//IL_0258: Expected I, but got Obj
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v77 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		bool flag2 = enumerator == null;
		bool flag3 = !flag2;
		IEnumerator enumerator2 = enumerator;
		if (!flag3)
		{
			enumerator2 = (IEnumerator)(object)string.Empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		if (obj3 == null)
		{
			return;
		}
		nint num3 = (nint)typeof(TopRunRewardHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v21 (Il2CppClass<TopRunRewardHelper>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v69 (Il2CppClass<TopRunRewardHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward pendingReward = TopRunRewardHelper.GetPendingReward();
		if (pendingReward == null)
		{
			return;
		}
		if (!string.Equals((string)(object)enumerator2, "GameOverScreen"))
		{
			if (!string.Equals((string)(object)enumerator2, "TopRunUI"))
			{
				_currentState = BreadCrumbStates.topRun;
			}
			return;
		}
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v31 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v62 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		UIScreen uIScreen = ((UIScreenController)flag4)._ActivateScreen((string)(object)enumerator2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v58 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num9 = 0;
			_ = 0;
			object obj8 = default;
			object obj7 = obj8 + 16;
			obj7 = this;
			object obj9 = computeShader + 336;
			obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v38 (UnityEngine.ComputeShader)+14C]");
			if ((nint)0 == 0)
			{
				_currentState = BreadCrumbStates.topRun;
			}
		}
	}

	private bool ShouldShowBoardsGiftSticker()
	{
		return _currentState != BreadCrumbStates.inactive;
	}

	private bool ShouldShowCharactersGiftSticker()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9290");
		object obj = default;
		if (obj != null)
		{
			return (byte)HoverboardStickerManager.GetNumberOfNewHoverboardsAndThemes() != 0;
		}
		return false;
	}

	private bool ShouldShowCollectableCharacterSticker()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9290");
		object obj = default;
		if (obj != null)
		{
			return (byte)CharacterStickerManager.GetNumberOfNewCharactersOrThemes() != 0;
		}
		return false;
	}

	private void SetupBreadCrumb()
	{
		if (((BundlePurchaseButton)null).GetBundleToSell() != InAppData.BundleTier.None)
		{
			_currentState = BreadCrumbStates.collectableCharacter;
		}
	}

	private void TrySetColor(UIWidget widget, Color color)
	{
		SetMeBreadcrumbState();
	}

	private bool TrySetActive(GameObject go, bool state)
	{
		//IL_00e0: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+14]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3+10]");
		bool flag = (byte)(num - 0) != 0;
		if ((flag ? 1 : 0) > (false ? 1 : 0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [go @ L1 (UnityEngine.GameObject)+14]");
			_ = 0;
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v23 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((flag ? 1 : 0) <= (state ? 1 : 0))
			{
				flag = state;
			}
		}
		else
		{
			flag = false;
		}
		return flag;
	}

	private bool TrySetActive(UIWidget widget, bool state)
	{
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)widget))
		{
			((GameObject)(object)widget).tag = (string)state;
			return true;
		}
		return false;
	}

	private void EnableBreadCrumbElements()
	{
		if (_currentState != BreadCrumbStates.inactive)
		{
			DisableBreadCrumbElements();
		}
		else
		{
			DisableEventBreadcrumb();
		}
	}

	private unsafe void DisableBreadCrumbElements()
	{
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected VT, but got Unknown
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected Obj, but got Unknown
		//IL_0901: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected Obj, but got Unknown
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected Obj, but got Unknown
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected Obj, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected Obj, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected Obj, but got Unknown
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_0064: Expected I, but got Obj
		//IL_007a: Expected Obj, but got I
		//IL_0974: Expected Obj, but got VT
		//IL_0989: Expected F4, but got Obj
		//IL_0984: Expected native int or pointer, but got VT
		//IL_09a3: Expected F4, but got Obj
		//IL_099e: Expected native int or pointer, but got VT
		//IL_09b8: Expected F4, but got I
		//IL_09b3: Expected native int or pointer, but got VT
		//IL_09c7: Expected I4, but got VT
		//IL_00a5: Expected I, but got Obj
		//IL_09ee: Expected Obj, but got I4
		//IL_0a3e: Expected Obj, but got I4
		//IL_0a63: Expected Obj, but got I4
		//IL_0a88: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I4
		//IL_042d: Expected I, but got Obj
		//IL_0443: Expected Obj, but got I
		//IL_0a9a: Expected Obj, but got VT
		//IL_0aa3: Expected Obj, but got VT
		//IL_0ab8: Expected F4, but got Obj
		//IL_0ab3: Expected native int or pointer, but got VT
		//IL_0ad2: Expected F4, but got Obj
		//IL_0acd: Expected native int or pointer, but got VT
		//IL_0ae7: Expected F4, but got I
		//IL_0ae2: Expected native int or pointer, but got VT
		//IL_0af7: Expected I4, but got VT
		//IL_0aff: Expected F4, but got Obj
		//IL_0b0c: Expected Obj, but got F4
		//IL_0b19: Expected F4, but got Obj
		//IL_0b14: Expected native int or pointer, but got VT
		//IL_0b33: Expected F4, but got Obj
		//IL_0b2e: Expected native int or pointer, but got VT
		//IL_0b48: Expected F4, but got I
		//IL_0b43: Expected native int or pointer, but got VT
		//IL_0b58: Expected I4, but got VT
		//IL_046e: Expected I, but got Obj
		//IL_0836: Expected I, but got Obj
		//IL_084c: Expected Obj, but got I
		//IL_07a8: Expected I, but got Obj
		//IL_07be: Expected Obj, but got I
		//IL_0877: Expected I, but got Obj
		//IL_0cd6: Expected F4, but got VT
		//IL_0cd1: Expected native int or pointer, but got VT
		//IL_07e9: Expected I, but got Obj
		//IL_04c0: Expected I, but got Obj
		//IL_04d6: Expected Obj, but got I
		//IL_0b8b: Expected Obj, but got VT
		//IL_0b94: Expected Obj, but got VT
		//IL_0ba9: Expected F4, but got Obj
		//IL_0ba4: Expected native int or pointer, but got VT
		//IL_0bc3: Expected F4, but got Obj
		//IL_0bbe: Expected native int or pointer, but got VT
		//IL_0bd8: Expected F4, but got I
		//IL_0bd3: Expected native int or pointer, but got VT
		//IL_0be8: Expected I4, but got VT
		//IL_0bf0: Expected F4, but got Obj
		//IL_0501: Expected I, but got Obj
		//IL_054e: Expected I, but got Obj
		//IL_0564: Expected Obj, but got I
		//IL_0c03: Expected F4, but got VT
		//IL_0bfe: Expected native int or pointer, but got VT
		//IL_058f: Expected I, but got Obj
		//IL_05dc: Expected I, but got Obj
		//IL_05f2: Expected Obj, but got I
		//IL_0c23: Expected F4, but got VT
		//IL_0c1e: Expected native int or pointer, but got VT
		//IL_061d: Expected I, but got Obj
		//IL_066a: Expected I, but got Obj
		//IL_0680: Expected Obj, but got I
		//IL_0c3e: Expected Obj, but got VT
		//IL_0c47: Expected Obj, but got VT
		//IL_0c5c: Expected F4, but got Obj
		//IL_0c57: Expected native int or pointer, but got VT
		//IL_0c76: Expected F4, but got Obj
		//IL_0c71: Expected native int or pointer, but got VT
		//IL_0c8b: Expected F4, but got I
		//IL_0c86: Expected native int or pointer, but got VT
		//IL_0c9b: Expected I4, but got VT
		//IL_0ca3: Expected F4, but got Obj
		//IL_06ab: Expected I, but got Obj
		//IL_071a: Expected I, but got Obj
		//IL_0730: Expected Obj, but got I
		//IL_0cb6: Expected F4, but got VT
		//IL_0cb1: Expected native int or pointer, but got VT
		//IL_075b: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 72);
		object obj2 = obj + 32;
		object obj3 = obj + 16;
		object obj4 = obj - -64;
		object obj5 = obj + 60;
		object obj6 = obj + 56;
		object obj7 = obj + 52;
		object obj8 = obj + 48;
		float num5;
		if (_currentState != BreadCrumbStates.sale && _currentState != BreadCrumbStates.specialSale)
		{
			Challenger[] combinedAndSortedChallengers = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_sticker, (Challenger[])1);
			if (combinedAndSortedChallengers != null)
			{
				nint num = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v125 (Il2CppClass<GlobalColors>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num2 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v136 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColors.GIFT_COLOR;
				obj4 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
				Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
				Matrix4x4 matrix4x3 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
				_sticker.rawPivot = (UIWidget.Pivot)matrix4x;
			}
			Challenger[] combinedAndSortedChallengers2 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_stickerShadow, (Challenger[])1);
			bool flag = ((BreadCrumbHelper)null).TrySetActive((UIWidget)(object)_notification, false);
			bool flag2 = _currentState == BreadCrumbStates.collectAward;
			Challenger[] combinedAndSortedChallengers3 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_awardIcon, (Challenger[])flag2);
			bool flag3 = _currentState == BreadCrumbStates.topRun;
			Challenger[] combinedAndSortedChallengers4 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_topRunIcon, (Challenger[])flag3);
			bool flag4 = _currentState == BreadCrumbStates.boardEventActive || _currentState == BreadCrumbStates.expiredLimitedCharacter || _currentState == BreadCrumbStates.characterDay || _currentState == BreadCrumbStates.biggerJackpot || _currentState == BreadCrumbStates.expiredLimitedBoard;
			bool flag5 = flag4;
			Challenger[] combinedAndSortedChallengers5 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_eventIcon, (Challenger[])flag5);
			bool flag6 = _currentState == BreadCrumbStates.giftBoard || _currentState == BreadCrumbStates.giftCharacter || _currentState == BreadCrumbStates.facebookGift;
			bool flag7 = flag6;
			Challenger[] combinedAndSortedChallengers6 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_giftIcon, (Challenger[])flag7);
			bool flag8 = _currentState == BreadCrumbStates.earnKeys;
			Challenger[] combinedAndSortedChallengers7 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_earnKeysIcon, (Challenger[])flag8);
			bool flag9 = _currentState == BreadCrumbStates.collectableCharacter;
			Challenger[] combinedAndSortedChallengers8 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_collectableCharacterIcon, (Challenger[])flag9);
			bool flag10 = ((BreadCrumbHelper)null).TrySetActive((UIWidget)(object)_discount, false);
			object obj10 = _currentState - 1;
			if (_currentState != BreadCrumbStates.giftCharacter && (nint)obj10 != 1)
			{
				if ((nint)obj10 == 2 || (nint)obj10 == 3 || (nint)obj10 == 4)
				{
					goto IL_079a;
				}
				if ((nint)obj10 != 5)
				{
					if ((nint)obj10 != 6)
					{
						if ((nint)obj10 == 7)
						{
							goto IL_079a;
						}
						if ((nint)obj10 != 8)
						{
							if ((nint)obj10 == 9)
							{
								goto IL_079a;
							}
							if ((nint)obj10 == 10)
							{
								nint num3 = (nint)typeof(GlobalColorsGenerated);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S0_v173 (Il2CppClass<GlobalColorsGenerated>)+BA]");
								object obj11 = (nint)0 & (nint)0x200;
								if (obj11 != null)
								{
									nint num4 = (nint)typeof(GlobalColorsGenerated);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v189 (Il2CppClass<GlobalColorsGenerated>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								obj2 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_BG;
								obj3 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_TEXT;
								obj7 = obj3;
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
								Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
								Matrix4x4 matrix4x5 = matrix4x;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
								((Matrix4x4*)(nint)matrix4x5)->m20 = 0f;
								((BundlePurchaseButton)null).OnPurchaseFailure((string)(object)_giftIcon, (PurchaseResult)matrix4x);
								num5 = (float)obj2;
							}
							else
							{
								if (_currentState != BreadCrumbStates.collectableCharacter)
								{
									goto IL_079a;
								}
								nint num6 = (nint)typeof(GlobalColors);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S0_v198 (Il2CppClass<GlobalColors>)+BA]");
								object obj12 = (nint)0 & (nint)0x200;
								if (obj12 != null)
								{
									nint num7 = (nint)typeof(GlobalColors);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S0_v205 (Il2CppClass<GlobalColors>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								((Matrix4x4*)(nint)matrix4x)->m00 = (float)GlobalColors.FIRST_PURCHASE_BONUS_BREADCRUMP_BUBBLE_COLOR;
								num5 = matrix4x.m00;
							}
						}
						else
						{
							nint num8 = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S0_v159 (Il2CppClass<GlobalColors>)+BA]");
							object obj13 = (nint)0 & (nint)0x200;
							if (obj13 != null)
							{
								nint num9 = (nint)typeof(GlobalColors);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S0_v166 (Il2CppClass<GlobalColors>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)GlobalColors.TOP_RUN_STICKER_COLOR;
							num5 = matrix4x.m00;
						}
					}
					else
					{
						nint num10 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v145 (Il2CppClass<GlobalColors>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num11 = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S0_v152 (Il2CppClass<GlobalColors>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)GlobalColors.AWARDS_COLLECTIBLE_STICKER_COLOR;
						num5 = matrix4x.m00;
					}
				}
				else
				{
					nint num12 = (nint)typeof(GlobalColorsGenerated);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S0_v122 (Il2CppClass<GlobalColorsGenerated>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num13 = (nint)typeof(GlobalColorsGenerated);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v138 (Il2CppClass<GlobalColorsGenerated>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj2 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
					obj3 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
					obj6 = obj3;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
					Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
					Matrix4x4 matrix4x7 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Matrix4x4*)(nint)matrix4x7)->m20 = 0f;
					((BundlePurchaseButton)null).OnPurchaseFailure((string)(object)_earnKeysIcon, (PurchaseResult)matrix4x);
					num5 = (float)obj2;
				}
			}
			else
			{
				nint num14 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v84 (Il2CppClass<GlobalColors>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num15 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v100 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColors.GIFT_COLOR;
				obj3 = GlobalColors.GIFT_LABEL_COLOR;
				obj5 = obj3;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
				Matrix4x4 matrix4x8 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
				Matrix4x4 matrix4x9 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x9)->m20 = 0f;
				((BundlePurchaseButton)null).OnPurchaseFailure((string)(object)_giftIcon, (PurchaseResult)matrix4x);
				num5 = (float)obj2;
			}
			goto IL_0b04;
		}
		DisableEventBreadcrumb();
		bool flag11 = ((BreadCrumbHelper)null).TrySetActive((UIWidget)(object)_discount, true);
		return;
		IL_079a:
		nint num16 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v108 (Il2CppClass<GlobalColors>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num17 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v115 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)GlobalColors.GIFT_COLOR;
		num5 = matrix4x.m00;
		goto IL_0b04;
		IL_0b04:
		obj8 = num5;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		Matrix4x4 matrix4x10 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Matrix4x4 matrix4x11 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((Matrix4x4*)(nint)matrix4x11)->m20 = 0f;
		((BundlePurchaseButton)null).OnPurchaseFailure((string)(object)_sticker, (PurchaseResult)matrix4x);
		if (_currentLocation != BreadCrumbLocations.meButton)
		{
			return;
		}
		nint num18 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v74 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num19 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S0_v79 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UserSave._002Ecctor();
	}

	private void DisableEventBreadcrumb()
	{
		Challenger[] combinedAndSortedChallengers = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_sticker, (Challenger[])null);
		Challenger[] combinedAndSortedChallengers2 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_eventIcon, (Challenger[])null);
		Challenger[] combinedAndSortedChallengers3 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_stickerShadow, (Challenger[])null);
		Challenger[] combinedAndSortedChallengers4 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_awardIcon, (Challenger[])null);
		Challenger[] combinedAndSortedChallengers5 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_topRunIcon, (Challenger[])null);
		bool flag = ((BreadCrumbHelper)null).TrySetActive((UIWidget)(object)_notification, true);
		bool flag2 = ((BreadCrumbHelper)null).TrySetActive((UIWidget)(object)_discount, false);
		Challenger[] combinedAndSortedChallengers6 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_giftIcon, (Challenger[])null);
		Challenger[] combinedAndSortedChallengers7 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_collectableCharacterIcon, (Challenger[])null);
		Challenger[] combinedAndSortedChallengers8 = ((FriendGhostHandler)null).GetCombinedAndSortedChallengers((Challenger[])(object)_earnKeysIcon, (Challenger[])null);
	}

	private void Update()
	{
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		bool flag2 = !flag;
		string text = tag;
		string text2 = ((GameObject)(object)text).tag;
		object obj2 = flag2 & text2;
		if (obj2 != null && (_currentState == BreadCrumbStates.boardEventActive || _currentState == BreadCrumbStates.characterDay || _currentState == BreadCrumbStates.expiredLimitedCharacter || _currentState == BreadCrumbStates.biggerJackpot))
		{
			DisableEventBreadcrumb();
		}
	}

	public BreadCrumbHelper()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		if (_currentState != BreadCrumbStates.collectAward)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_stickerShadow).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_sticker).FindKernel((string)null) != 0)
		{
			float unscaledTime = Time.unscaledTime;
			float end = unscaledTime * 60f;
			GameObject gameObject = _sticker.gameObject;
			((Dropdown)(object)gameObject).AlphaFadeList(0f, 0f, end);
			GameObject gameObject2 = _stickerShadow.gameObject;
			((Dropdown)(object)gameObject2).AlphaFadeList(0f, 0f, end);
		}
	}
}
