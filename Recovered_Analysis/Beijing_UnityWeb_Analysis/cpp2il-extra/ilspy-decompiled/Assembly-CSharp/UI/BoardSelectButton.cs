using System;
using System.Collections;
using System.Collections.Generic;
using Cloud;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Ionic.Crc;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.Extensions;
using Kiloo.Common.Timer;
using Missions;
using SYBO.Subway.Info;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;
using UnityEngine;
using WeeklyHunt;

namespace UI;

public class BoardSelectButton : MonoBehaviour
{
	private enum ButtonStates
	{
		Buy,
		Select,
		Trial,
		BuyWithInapp,
		Unselect,
		LockedTheme,
		WatchVideo,
		GetNow,
		NoAvailableVideo
	}

	private enum StickerType
	{
		None,
		Event,
		Limited,
		Gift
	}

	private enum VideoState
	{
		Ready,
		Failed,
		Loading
	}

	private GameObject _buy;

	private UILabel _priceLabel;

	private UISprite _keySprite;

	private UISprite _coinSprite;

	private HorizontalLayout _buyLayout;

	private GameObject _select;

	private UILabel _labelSelected;

	private GameObject _watchVideo;

	private UISprite _videoSprite;

	private UISprite _loadingSprite;

	private UISprite _spacingSprite;

	private UILabel _watchVideoLabel;

	private UILabel _watchVideoSubLabel;

	private HorizontalLayout _watchVideoLayout;

	private VerticalLayout _watchVideoLabelLayout;

	private GameObject _lockedBoardContent;

	private UILabel _progressLabel;

	private UISprite _tokenSprite;

	private HorizontalLayout _lockedBoardLayout;

	private GameObject _trial;

	private UILabel _labelTry;

	private GameObject _buyWithInapp;

	private UILabel _labelBuyWithInapp;

	private GameObject _unselect;

	private UILabel _labelUnselect;

	private GameObject _lockedThemeContent;

	private UISprite _lockedKeySprite;

	private UISprite _lockedCoinSprite;

	private UILabel _notAvailableThemeAmount;

	private UILabel _notAvailableThemeFeedback;

	private HorizontalLayout _themeToplayout;

	private HorizontalLayout _themeBottomLayout;

	private GameObject _getNowContent;

	private UISprite _backgroundSticker;

	private UISprite _eventIcon;

	private UISprite _giftIcon;

	private UISprite _limitedIcon;

	public Action onPurchaseSuccessful;

	public Action onPurchaseFailed;

	private Boards.BoardId _boardId;

	private int _currentThemeIndex;

	private UIButtonOverlayOff _uiButtonOverlayOff;

	private bool _purchaseInProgress = false;

	private bool _hasInited;

	private bool _shouldShowEventIndicatorsForTryBoardsEvent;

	private bool _shouldShowEventIndicatorsForBuyLimitedBoardsEvent;

	private bool _shouldShowExpirationTimeForBoardBundleSale;

	private int _videoCacheRetry;

	private bool _didWatchVideo;

	private bool _shouldLogWatchVideoData;

	private VideoState _currentVideoState;

	private BoardManager.ScreenContext _screenContext;

	private ButtonStates _activeState;

	public void UpdateCurrentThemeIndex()
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		object obj = this + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		object obj3 = this + 124;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private void SetSticker(StickerType type)
	{
		//IL_000f: Expected Obj, but got I4
		((GameObject)(object)_coinSprite).tag = (string)type;
	}

	public void UpdateSticker(Boards.BoardId boardId, int themeIndex)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0018: Expected Obj, but got I4
		//IL_0045: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I
		//IL_0310: Expected Obj, but got I4
		//IL_02db: Expected Obj, but got I4
		//IL_00df: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0138: Expected Obj, but got I4
		//IL_0086: Expected I, but got Obj
		//IL_02b7: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I4
		//IL_02c2: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I4
		//IL_0269: Expected I4, but got Obj
		//IL_0269: Expected I4, but got Obj
		//IL_019e: Expected I4, but got Obj
		//IL_019e: Expected I4, but got Obj
		//IL_01ac: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I4
		if (boardId != Boards.BoardId.normal)
		{
			object obj = this + 208;
			obj = boardId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardId @ L1 (Info.Boards+BoardId)+20]");
			bool flag = (nint)0 != 0;
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v41 (Il2CppClass<SocialManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v52 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			bool flag2 = ((SocialManager)facebookDialogsSupported).HasFacebookAccessToken();
			int tierNumberToEnable = ((AwardCellHelper)this).GetTierNumberToEnable();
			_currentVideoState = (VideoState)tierNumberToEnable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardId @ L1 (Info.Boards+BoardId)+8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v39+1C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v40+10]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v40+1C]");
			object obj5 = num3 - 0;
			bool activeState = (nint)obj5 > 1;
			_activeState = (activeState ? ButtonStates.Select : ButtonStates.Buy);
			object obj6 = this + 200;
			obj6 = themeIndex;
		}
		((AwardCellHelper)this).SetupCellContent();
		((AwardCellHelper)this).SetupCellColors();
		((AwardCellHelper)this).CollectRewardClicked();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.BoardSelectButton)+D4]");
		if ((nint)0 != 0)
		{
			if (_activeState == ButtonStates.Buy)
			{
				bool flag3 = IsBoardOrThemeFree((Boards.BoardId)_lockedCoinSprite, (int)_watchVideoLabelLayout);
				Coroutine coroutine = StartCoroutine_Auto((IEnumerator)flag3);
			}
			else
			{
				AwardCellHelper.AwardCellState cellState = ((AwardCellHelper)this).GetCellState();
				object obj7 = cellState + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardId @ L1 (Info.Boards+BoardId)+24]");
				if (0 == (nint)obj7)
				{
					string text = _lockedKeySprite.tag;
					((GameObject)(object)text).tag = null;
				}
				else
				{
					object obj8 = _lockedThemeContent + 16;
					AwardCellHelper.AwardCellState cellState2 = ((AwardCellHelper)this).GetCellState();
					object obj9 = (int)cellState2 << 2;
					object obj10 = obj8 + obj9;
					bool flag4 = IsBoardOrThemeFree((Boards.BoardId)_lockedKeySprite, (int)obj10);
					Coroutine coroutine2 = StartCoroutine_Auto((IEnumerator)flag4);
					AwardCellHelper.AwardCellState cellState3 = ((AwardCellHelper)this).GetCellState();
					object obj11 = cellState3 + 1;
				}
			}
		}
		if (_currentVideoState == (VideoState)4)
		{
			((Animation)_boardId).CrossFade((string)2);
			IEnumerator enumerator = ((Animation)_boardId).GetEnumerator();
		}
		else
		{
			Animation.INTERNAL_CALL_Stop((Animation)_boardId);
		}
	}

	private bool IsBoardOrThemeFree(Boards.BoardId boardId, int themeIndex = -1)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 24;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 16;
		obj2 = boardId;
		object obj3 = (flag ? 1 : 0) + 20;
		obj3 = themeIndex;
		return flag;
	}

	private unsafe void SetButtonState(ButtonStates state)
	{
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected VT, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_0442: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_01f5: Expected I, but got Obj
		//IL_020b: Expected Obj, but got I
		//IL_0528: Expected Obj, but got VT
		//IL_053d: Expected F4, but got Obj
		//IL_0538: Expected native int or pointer, but got VT
		//IL_0557: Expected F4, but got Obj
		//IL_0552: Expected native int or pointer, but got VT
		//IL_056c: Expected F4, but got I
		//IL_0567: Expected native int or pointer, but got VT
		//IL_057b: Expected I4, but got VT
		//IL_0584: Expected Obj, but got VT
		//IL_0599: Expected F4, but got Obj
		//IL_0594: Expected native int or pointer, but got VT
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_0282: Expected F4, but got Obj
		//IL_027d: Expected native int or pointer, but got VT
		//IL_0297: Expected F4, but got I
		//IL_0292: Expected native int or pointer, but got VT
		//IL_02a6: Expected I4, but got VT
		//IL_02af: Expected Obj, but got VT
		//IL_02c4: Expected F4, but got Obj
		//IL_02bf: Expected native int or pointer, but got VT
		//IL_0236: Expected I, but got Obj
		//IL_045f: Expected Obj, but got VT
		//IL_0474: Expected F4, but got Obj
		//IL_046f: Expected native int or pointer, but got VT
		//IL_048e: Expected F4, but got Obj
		//IL_0489: Expected native int or pointer, but got VT
		//IL_04a3: Expected F4, but got I
		//IL_049e: Expected native int or pointer, but got VT
		//IL_04b2: Expected I4, but got VT
		//IL_04bb: Expected Obj, but got VT
		//IL_04d0: Expected F4, but got Obj
		//IL_04cb: Expected native int or pointer, but got VT
		//IL_02e3: Expected F4, but got Obj
		//IL_02de: Expected native int or pointer, but got VT
		//IL_02f8: Expected F4, but got I
		//IL_02f3: Expected native int or pointer, but got VT
		//IL_0307: Expected I4, but got VT
		//IL_0310: Expected Obj, but got VT
		//IL_0325: Expected F4, but got Obj
		//IL_0320: Expected native int or pointer, but got VT
		//IL_0135: Expected F4, but got Obj
		//IL_0130: Expected native int or pointer, but got VT
		//IL_014a: Expected F4, but got I
		//IL_0145: Expected native int or pointer, but got VT
		//IL_0159: Expected I4, but got VT
		//IL_0162: Expected Obj, but got VT
		//IL_0177: Expected F4, but got Obj
		//IL_0172: Expected native int or pointer, but got VT
		//IL_00e9: Expected I, but got Obj
		//IL_04fc: Expected F4, but got Obj
		//IL_04f7: Expected native int or pointer, but got VT
		//IL_0511: Expected F4, but got I
		//IL_050c: Expected native int or pointer, but got VT
		//IL_051e: Expected I4, but got VT
		//IL_0196: Expected F4, but got Obj
		//IL_0191: Expected native int or pointer, but got VT
		//IL_01ab: Expected F4, but got I
		//IL_01a6: Expected native int or pointer, but got VT
		//IL_01ba: Expected I4, but got VT
		//IL_01c3: Expected Obj, but got VT
		//IL_01d8: Expected F4, but got Obj
		//IL_01d3: Expected native int or pointer, but got VT
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 128);
		object obj2 = obj + 88;
		object obj3 = obj + 72;
		object obj4 = obj + 120;
		object obj5 = obj - -64;
		object obj6 = obj + 48;
		object obj7 = obj + 116;
		object obj8 = obj + 40;
		object obj9 = obj + 24;
		object obj10 = obj + 112;
		object obj11 = obj + 16;
		object obj12 = obj + 108;
		object obj13 = obj + 104;
		object obj14 = obj + 100;
		object obj15 = obj + 96;
		object obj16 = obj + 92;
		string text = _backgroundSticker.tag;
		bool flag = state != ButtonStates.Buy;
		((GameObject)(object)text).tag = (string)flag;
		string text2 = _eventIcon.tag;
		bool flag2 = state == ButtonStates.Select;
		((GameObject)(object)text2).tag = (string)flag2;
		string text3 = _giftIcon.tag;
		bool flag3 = state == ButtonStates.BuyWithInapp;
		((GameObject)(object)text3).tag = (string)flag3;
		string text4 = _limitedIcon.tag;
		bool flag4 = state == ButtonStates.Trial;
		((GameObject)(object)text4).tag = (string)flag4;
		UIWidget backgroundSticker;
		if (flag4)
		{
			nint num = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v89 (Il2CppClass<GlobalColorsGenerated>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num2 = (nint)typeof(GlobalColorsGenerated);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v109 (Il2CppClass<GlobalColorsGenerated>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_eventIcon.rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
			obj7 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
			Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_giftIcon.rawPivot = (UIWidget.Pivot)matrix4x;
			obj8 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
			obj10 = obj8;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
			Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_limitedIcon.rawPivot = (UIWidget.Pivot)matrix4x;
			obj11 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
			obj12 = obj11;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
			backgroundSticker = _backgroundSticker;
		}
		else
		{
			nint num3 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v62 (Il2CppClass<GlobalColors>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num4 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v82 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.GIFT_LABEL_COLOR;
			obj13 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
			Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_eventIcon.rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = GlobalColors.GIFT_LABEL_COLOR;
			obj14 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
			Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_giftIcon.rawPivot = (UIWidget.Pivot)matrix4x;
			obj8 = GlobalColors.GIFT_LABEL_COLOR;
			obj15 = obj8;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj15;
			Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_limitedIcon.rawPivot = (UIWidget.Pivot)matrix4x;
			obj11 = GlobalColors.GIFT_COLOR;
			obj16 = obj11;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
			backgroundSticker = _backgroundSticker;
		}
		Matrix4x4 matrix4x8 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		backgroundSticker.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	private void OnEnable()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v13 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool currentThemeIndex = BoardManager.ShouldCustomSetBeDisplayed((int)_screenContext);
		_currentThemeIndex = (currentThemeIndex ? 1 : 0);
	}

	private unsafe void OnDisable()
	{
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02cc: Expected I, but got Obj
		//IL_02e2: Expected Obj, but got I
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected Obj, but got Unknown
		//IL_03aa: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_018c: Expected I, but got Obj
		//IL_01a2: Expected Obj, but got I
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_01cd: Expected I, but got Obj
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(BoardSelectButton.OnChangedCurrentlyShownBoardModel);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v80 (Il2CppClass<SSEventsManagerController>)+74]");
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
		((Delegate)action2).method = (nint)__ldftn(BoardSelectButton.OnChangedCurrentlyShownBoardModel);
		object obj3 = action2 + 16;
		obj3 = this;
		SSEventsManagerController.OnSSEventFinishedHandler -= action2;
		nint num3 = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v25 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v76 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(BoardSelectButton.OnChangedCurrentlyShownBoardModel);
		object obj5 = action3 + 16;
		obj5 = this;
		((BoardBundlePopupManager)pageIndex).onBoardBundleStartedHandler -= action3;
		int pageIndex2 = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr4;
		((Delegate)action4).method = (nint)__ldftn(BoardSelectButton.OnChangedCurrentlyShownBoardModel);
		object obj6 = action4 + 16;
		obj6 = this;
		((BoardBundlePopupManager)pageIndex2).onBoardBundleExpiredHandler -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Action action5 = default;
		((Delegate)action5).method_ptr = method_ptr5;
		((Delegate)action5).method = (nint)__ldftn(BoardSelectButton.OnChangedCurrentlyShownBoardModel);
		object obj7 = action5 + 16;
		obj7 = this;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v40 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v72 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr6 = 0;
		Action action6 = default;
		((Delegate)action6).method_ptr = method_ptr6;
		((Delegate)action6).method = (nint)__ldftn(BoardSelectButton.OnChangedCurrentlyShownBoardModel);
		object obj9 = action6 + 16;
		obj9 = this;
		UIModelController.OnChangedCurrentlyShownHoverboard -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<string, bool> action7 = default;
		object obj10 = action7 + 16;
		obj10 = this;
		AdSystemManager.onCachedVideo -= action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<string> action8 = default;
		object obj11 = action8 + 16;
		obj11 = this;
		AdSystemManager.onFailedToCacheVideo -= action8;
	}

	public unsafe void SendFlurryLogForBirthdayBoard()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_005d: Expected I, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_00eb: Expected I, but got Obj
		//IL_0101: Expected Obj, but got I
		//IL_009e: Expected I, but got Obj
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03ae: Expected Obj, but got I4
		//IL_012c: Expected I, but got Obj
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01b9: Expected Obj, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01f7: Expected I, but got Obj
		//IL_020d: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_0238: Expected I, but got Obj
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		if (~(_shouldLogWatchVideoData ? 1u : 0u) == 0)
		{
			OnChangedCurrentlyShownBoardModel();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(BoardSelectButton.OnChangedCurrentlyShownBoardModel);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v83 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventFinishedHandler += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(BoardSelectButton.OnChangedCurrentlyShownBoardModel);
		object obj3 = action2 + 16;
		obj3 = this;
		SSEventsManagerController.OnSSEventChangedHandler += action2;
		nint num3 = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v28 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v79 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(BoardSelectButton.OnChangedCurrentlyShownBoardModel);
		object obj5 = action3 + 16;
		obj5 = this;
		((BoardBundlePopupManager)pageIndex).onBoardBundleExpiredHandler += action3;
		int pageIndex2 = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		UnityEngine.Object obj6 = default;
		obj6.m_CachedPtr = cachedPtr;
		_ = 0;
		object obj7 = obj6 + 16;
		obj7 = this;
		BoardBundlePopupManager.LogErr((string)pageIndex2, obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action4 = default;
		object obj8 = action4 + 16;
		obj8 = this;
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v43 (Il2CppClass<UIScreenController>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v75 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr2 = 0;
		UIModelController uIModelController = default;
		((UnityEngine.Object)uIModelController).m_CachedPtr = cachedPtr2;
		uIModelController.CelebrationPopupAnchor = (GameObject)0;
		object obj10 = uIModelController + 16;
		obj10 = this;
		uIModelController.SelectCurrentModelForPlay();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<string> action5 = default;
		object obj11 = action5 + 16;
		obj11 = this;
		AdSystemManager.onFailedToCacheVideo += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<string> action6 = default;
		object obj12 = action6 + 16;
		obj12 = this;
		AdSystemManager.onFinishedWatchingVideo += action6;
	}

	public void InitButton(BoardManager.ScreenContext newContext)
	{
		//IL_03b5: Expected Obj, but got I4
		//IL_03d3: Expected Obj, but got I4
		//IL_03f1: Expected Obj, but got I4
		//IL_0023: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I4
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_0146: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_00d6: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I4
		//IL_0187: Expected I, but got Obj
		//IL_01e4: Expected Obj, but got I4
		_activeState = (ButtonStates)newContext;
		bool flag = newContext == BoardManager.ScreenContext.BoardScreen;
		_buy.tag = (string)flag;
		bool flag2 = newContext == BoardManager.ScreenContext.LimitedBoardPopup;
		_select.tag = (string)flag2;
		bool flag3 = newContext == (BoardManager.ScreenContext)6;
		_watchVideo.tag = (string)flag3;
		bool flag4 = newContext == BoardManager.ScreenContext.BoardPromotionPopup;
		_trial.tag = (string)flag4;
		bool flag5 = newContext == (BoardManager.ScreenContext)3;
		_buyWithInapp.tag = (string)flag5;
		bool flag6 = newContext == (BoardManager.ScreenContext)4;
		_unselect.tag = (string)flag6;
		bool flag7 = newContext == (BoardManager.ScreenContext)5;
		_lockedThemeContent.tag = (string)flag7;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_getNowContent).FindKernel((string)null) != 0)
		{
			bool flag8 = newContext == (BoardManager.ScreenContext)7;
			_getNowContent.tag = (string)flag8;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_getNowContent).FindKernel((string)null) != 0)
		{
			bool flag9 = newContext == (BoardManager.ScreenContext)7;
			_getNowContent.tag = (string)flag9;
		}
		switch (newContext)
		{
		case BoardManager.ScreenContext.BoardScreen:
			if (_currentThemeIndex != 0)
			{
				SetSelectBoardThemeUI();
			}
			else
			{
				SetBuyBoardThemeUI();
			}
			break;
		case BoardManager.ScreenContext.LimitedBoardPopup:
			if (_currentThemeIndex != 0)
			{
				SetUnselectBoardThemeUI();
			}
			else
			{
				SetBuyHoverboardUI();
			}
			break;
		case BoardManager.ScreenContext.BoardPromotionPopup:
			SetSelectHoverboardUI();
			break;
		case (BoardManager.ScreenContext)3:
			SetToSelectGreenState();
			break;
		case (BoardManager.ScreenContext)4:
			SetSelectLockedTheme();
			break;
		case (BoardManager.ScreenContext)5:
			BuyHoverboardWithInapp();
			break;
		case (BoardManager.ScreenContext)6:
			OnClick();
			break;
		case (BoardManager.ScreenContext)7:
			SetToSelectedBlueState();
			break;
		}
	}

	private bool CurrentlyShownBoardMatchesTrySpecialPowerBoard()
	{
		//IL_0016: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.BoardSelectButton)+D0]");
		List<Award> awardsForState = ((AwardsManager)0).GetAwardsForState((AwardState)4);
		if (awardsForState != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.BoardSelectButton)+D0]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v13+1C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v14+10]");
			if ((nint)0 == 3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.BoardSelectButton)+D0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v18+C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v19+8]");
				return false;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.BoardSelectButton)+D0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
		return (byte)(-1) != 0;
	}

	private bool CurrentlyShownBoardMatchesLimitedExpiredBoardEvent()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return BoardManager.IsBoardEventLimitedExpiredBoard(_boardId);
	}

	private bool CurrentlyShownBoardMatchesBoardBundleEvent()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v9 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int currentlyShownHoverboardTheme = BoardManager.GetCurrentlyShownHoverboardTheme(_screenContext);
		return BoardManager.IsBoardOwned((Boards.BoardId)currentlyShownHoverboardTheme);
	}

	public void OnChangedCurrentlyShownBoardModel()
	{
		//IL_0156: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_0234: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		_shouldLogWatchVideoData = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 188;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S4_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S4_v8+48]");
		object obj9 = 0;
		object obj10 = obj9 & 0x7FF;
		object obj11 = obj10 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S5_v6 (should have been resolved before IL gen)");
		if (~(_didWatchVideo ? 1u : 0u) == 0)
		{
			object obj12 = "yes";
		}
		else
		{
			object obj12 = "no";
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v12+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S4_v13+48]");
		object obj15 = 0;
		object obj16 = obj15 & 0x7FF;
		object obj17 = obj16 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v84 @ S5_v10 (should have been resolved before IL gen)");
		object obj18;
		if (_screenContext != BoardManager.ScreenContext.BoardScreen)
		{
			bool flag = _screenContext != BoardManager.ScreenContext.BoardPromotionPopup;
			bool flag2 = !flag;
			obj18 = "Birthday Board showed in popup";
			if (!flag2)
			{
				obj18 = "";
			}
		}
		else
		{
			obj18 = "Birthday Board showed on Board screen";
		}
		bool flag3;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ L1_v3+8]");
			flag3 = (nint)0 == 0;
		}
		else
		{
			flag3 = true;
		}
		if (!flag3)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v32 (Il2CppClass<Flurry>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num5 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v35 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		_didWatchVideo = false;
		_videoCacheRetry = 0;
	}

	private unsafe void SetTryHoverboardUI()
	{
		//IL_060f: Expected I, but got Obj
		//IL_0625: Expected Obj, but got I
		//IL_065a: Expected I, but got Obj
		//IL_0670: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00f9: Expected I, but got Obj
		//IL_06a4: Expected Obj, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected I4, but got Unknown
		//IL_00ac: Expected I, but got Obj
		//IL_01b8: Expected I, but got Obj
		//IL_01ce: Expected Obj, but got I
		//IL_0416: Expected I, but got Obj
		//IL_042c: Expected Obj, but got I
		//IL_06ff: Expected Obj, but got I4
		//IL_0711: Expected I, but got Obj
		//IL_0727: Expected Obj, but got I
		//IL_01f9: Expected I, but got Obj
		//IL_0457: Expected I, but got Obj
		//IL_02a3: Expected I, but got Obj
		//IL_02b9: Expected Obj, but got I
		//IL_0246: Expected I, but got Obj
		//IL_0341: Expected I, but got Obj
		//IL_0357: Expected Obj, but got I
		//IL_02e4: Expected I, but got Obj
		//IL_0382: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v92 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int currentlyShownHoverboardTheme = BoardManager.GetCurrentlyShownHoverboardTheme(_screenContext);
		if (_boardId != (Boards.BoardId)currentlyShownHoverboardTheme)
		{
			_currentThemeIndex = 0;
			nint num3 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v98 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v104 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
			instance.hoverboards = (HoverboardModelPreviewFactory.HoverboardModelSetup[])1;
		}
		_boardId = (Boards.BoardId)currentlyShownHoverboardTheme;
		nint num5 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v14 (Il2CppClass<Info.Boards>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v90 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(_boardId);
		if (~(_shouldLogWatchVideoData ? 1u : 0u) == 0 && board.unlockType != PurchaseData.UnlockType.WatchVideo)
		{
			OnChangedCurrentlyShownBoardModel();
		}
		bool shouldShowEventIndicatorsForTryBoardsEvent = CurrentlyShownBoardMatchesLimitedExpiredBoardEvent();
		_shouldShowEventIndicatorsForTryBoardsEvent = shouldShowEventIndicatorsForTryBoardsEvent;
		bool shouldShowEventIndicatorsForBuyLimitedBoardsEvent = CurrentlyShownBoardMatchesBoardBundleEvent();
		_shouldShowEventIndicatorsForBuyLimitedBoardsEvent = shouldShowEventIndicatorsForBuyLimitedBoardsEvent;
		string eventLabelPrefix = ((CelebrationPopupLabelTemplate)this).GetEventLabelPrefix();
		bool shouldShowExpirationTimeForBoardBundleSale = (byte)(eventLabelPrefix & 1) != 0;
		_shouldShowExpirationTimeForBoardBundleSale = shouldShowExpirationTimeForBoardBundleSale;
		if (_currentThemeIndex != 0)
		{
			nint num7 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S2_v21 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S2_v37 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ref Notification notification = ref *(Notification*)(_currentThemeIndex - 1);
			bool themeId = ((NotificationsObserver)_boardId).DidAppStartFromNotificationAndroid(out notification);
			nint num9 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v53 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v83 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!BoardManager.HasAllThemesBeenSeen(_boardId))
			{
				InitButton((BoardManager.ScreenContext)5);
				return;
			}
			nint num11 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v59 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v78 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!BoardManager.IsThemeActive(_boardId, themeId ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none))
			{
				InitButton(BoardManager.ScreenContext.BoardScreen);
				return;
			}
			nint num13 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v65 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num14 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S1_v73 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (BoardManager.HasThemeBeenSeen(_boardId, themeId ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none))
			{
				InitButton((BoardManager.ScreenContext)4);
			}
			else
			{
				InitButton(BoardManager.ScreenContext.LimitedBoardPopup);
			}
			return;
		}
		if (board.unlockType != PurchaseData.UnlockType.AlwaysUnlocked)
		{
			nint num15 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v28 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num16 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v45 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!BoardManager.HasAllThemesBeenSeen(_boardId) && board.unlockType != PurchaseData.UnlockType.WeeklyHunt)
			{
				if (~(_shouldShowEventIndicatorsForTryBoardsEvent ? 1u : 0u) == 0)
				{
					InitButton(BoardManager.ScreenContext.BoardPromotionPopup);
				}
				else if (~(_shouldShowEventIndicatorsForBuyLimitedBoardsEvent ? 1u : 0u) != 0 && board.unlockType != PurchaseData.UnlockType.InApp && ~(_shouldShowExpirationTimeForBoardBundleSale ? 1u : 0u) != 0)
				{
					if (board.unlockType == PurchaseData.UnlockType.WatchVideo)
					{
						InitButton((BoardManager.ScreenContext)6);
						_shouldLogWatchVideoData = true;
					}
					else if (board.unlockType == PurchaseData.UnlockType.Redirect)
					{
						InitButton((BoardManager.ScreenContext)7);
					}
					else
					{
						InitButton(BoardManager.ScreenContext.BoardScreen);
					}
				}
				else
				{
					InitButton((BoardManager.ScreenContext)3);
				}
				return;
			}
		}
		InitButton(BoardManager.ScreenContext.LimitedBoardPopup);
	}

	public void SetSelectHoverboardUI()
	{
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_00ba: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (!((SSEventsManagerController)(object)flurryUserId).IsAnyEventEnabled())
		{
			goto IL_0104;
		}
		if (~(_shouldShowEventIndicatorsForTryBoardsEvent ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v14 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v21 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int currentlyShownHoverboardTheme = BoardManager.GetCurrentlyShownHoverboardTheme(_screenContext);
			Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
			if (currentlyShownHoverboardTheme != (int)previousBoardId)
			{
				goto IL_0104;
			}
		}
		SetToUnselectBlueState();
		goto IL_010f;
		IL_010f:
		string text = _coinSprite.tag;
		((GameObject)(object)text).tag = null;
		string text2 = _keySprite.tag;
		((GameObject)(object)text2).tag = null;
		return;
		IL_0104:
		SetToSelectedBlueState();
		goto IL_010f;
	}

	private void SetBuyHoverboardUI()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_00ed: Expected I, but got Obj
		Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
		if (previousBoardId == _boardId)
		{
			SetToUnselectBlueState();
			return;
		}
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v17 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!BoardManager.HasAllThemesBeenSeen(_boardId))
		{
			nint num3 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v16 (Il2CppClass<Info.Boards>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v26 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.Board board = Boards.boardData.get_Item(_boardId);
			if (board.unlockType != PurchaseData.UnlockType.AlwaysUnlocked)
			{
				SetWatchVideo();
				return;
			}
		}
		SetToSelectedBlueState();
	}

	public void SetBuyBoardThemeUI()
	{
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		SetToSelectedBlueState();
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v25 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(_boardId);
		string text = _coinSprite.tag;
		bool flag = board.unlockType == PurchaseData.UnlockType.Coins;
		((GameObject)(object)text).tag = (string)flag;
		string text2 = _keySprite.tag;
		bool flag2 = board.unlockType == PurchaseData.UnlockType.Keys;
		((GameObject)(object)text2).tag = (string)flag2;
		object obj2 = board + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_priceLabel.fontSize = fontSize;
		((RewardForVideoButton)(object)_buyLayout).Init((VideoButtonPayload)null);
	}

	private void SetSelectBoardThemeUI()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		SetToSelectedBlueState();
		if (_currentThemeIndex != 0)
		{
			nint num = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v31 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(_boardId);
			int index = _currentThemeIndex - 1;
			HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index);
			string text = _coinSprite.tag;
			bool flag = hoverboardTheme.unlockType == PurchaseData.UnlockType.Coins;
			((GameObject)(object)text).tag = (string)flag;
			string text2 = _keySprite.tag;
			bool flag2 = hoverboardTheme.unlockType == PurchaseData.UnlockType.Keys;
			((GameObject)(object)text2).tag = (string)flag2;
			object obj2 = hoverboardTheme + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			int fontSize = default;
			_priceLabel.fontSize = fontSize;
			((RewardForVideoButton)(object)_buyLayout).Init((VideoButtonPayload)null);
		}
		else
		{
			SDebug.LogFormat("Trying to set up 'buy theme' button while theme index is 0. Aborting.", null);
		}
	}

	private void SetUnselectBoardThemeUI()
	{
		SetToSelectedBlueState();
	}

	private void SetSelectLockedTheme()
	{
		SetToLockedBoard();
	}

	private void BuyHoverboardWithInapp()
	{
		//IL_0031: Expected I, but got Obj
		//IL_0047: Expected Obj, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_0072: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_0138: Expected I, but got Obj
		//IL_014e: Expected Obj, but got I
		//IL_02c3: Expected I, but got Obj
		//IL_02d9: Expected Obj, but got I
		//IL_0324: Expected I4, but got Obj
		//IL_0179: Expected I, but got Obj
		//IL_01c6: Expected I, but got Obj
		_uiButtonOverlayOff.LockState(locked: true);
		_uiButtonOverlayOff.GoToSelectedState();
		_lockedBoardContent.tag = null;
		string text = _labelSelected.tag;
		((GameObject)(object)text).tag = null;
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v38 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(_boardId);
		int index = _currentThemeIndex - 1;
		HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index);
		object obj2 = hoverboardTheme + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_notAvailableThemeAmount.fontSize = fontSize;
		string text2 = _lockedCoinSprite.tag;
		bool flag = hoverboardTheme.unlockType == PurchaseData.UnlockType.Coins;
		((GameObject)(object)text2).tag = (string)flag;
		string text3 = _lockedKeySprite.tag;
		bool flag2 = hoverboardTheme.unlockType == PurchaseData.UnlockType.Keys;
		((GameObject)(object)text3).tag = (string)flag2;
		nint num3 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v25 (Il2CppClass<Info.Boards>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v38 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(_boardId);
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S2_v20 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S2_v29 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text4 = Strings.GetDefault(board.name);
		string text5 = text4.ToUpperInvariant();
		_notAvailableThemeFeedback.fontSize = (int)text5;
		((RewardForVideoButton)(object)_themeToplayout).Init((VideoButtonPayload)null);
		((RewardForVideoButton)(object)_themeBottomLayout).Init((VideoButtonPayload)null);
	}

	private void SetToSelectGreenState()
	{
		//IL_0031: Expected I, but got Obj
		//IL_0047: Expected Obj, but got I
		//IL_01ce: Expected I4, but got Obj
		//IL_01dc: Expected I, but got Obj
		//IL_01f2: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_0234: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_0072: Expected I, but got Obj
		//IL_00bf: Expected I, but got Obj
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I4
		//IL_02d0: Expected I4, but got Obj
		//IL_014d: Expected I, but got Obj
		SetToSelectedBlueState();
		string text = _coinSprite.tag;
		((GameObject)(object)text).tag = null;
		string text2 = _keySprite.tag;
		((GameObject)(object)text2).tag = null;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v8 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v44 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("BUY_INAPP_NOPRICE_DEFAULT");
		_labelBuyWithInapp.fontSize = (int)text3;
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v16 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v40 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = InAppData.IsUsingCustomIapIdForBoard((Boards.Board)_boardId);
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v8 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v9+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v10+44]");
		object obj5 = 0;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S3_v4 (should have been resolved before IL gen)");
		object obj8 = default;
		if ((nint)obj8 <= -1)
		{
			return;
		}
		nint num6 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v25 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v34 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppItemModel objectToClone = InAppData.inAppData.get_Item((string)flag);
		InAppItemModel inAppItemModel = InAppItemModel.Clone(objectToClone);
		_labelBuyWithInapp.fontSize = (int)inAppItemModel;
	}

	private void SetToSelectedBlueState()
	{
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_0032: Expected I, but got Obj
		//IL_0048: Expected Obj, but got I
		//IL_02aa: Expected I4, but got Obj
		//IL_00ec: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0256: Expected I4, but got Obj
		//IL_0208: Expected Obj, but got I4
		//IL_01bb: Expected I, but got Obj
		//IL_0288: Expected I4, but got Obj
		//IL_00c0: Expected Obj, but got I4
		//IL_0073: Expected I, but got Obj
		//IL_012d: Expected I, but got Obj
		_lockedBoardContent.tag = null;
		_uiButtonOverlayOff.LockState(locked: true);
		_uiButtonOverlayOff.GoToNotAvailableState();
		if (_currentThemeIndex != 0)
		{
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v33 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v42 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("HOVERBOARD_THEME_SELECT_BUTTON_TEXT");
			_labelSelected.fontSize = (int)text;
			string text2 = _labelSelected.tag;
			((GameObject)(object)text2).tag = (string)1;
			return;
		}
		if (~(_shouldShowEventIndicatorsForTryBoardsEvent ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v21 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v28 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text3 = Strings.GetDefault("SELECT_BUTTON_TRY_FOR_FREE");
			_labelTry.fontSize = (int)text3;
			return;
		}
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v16 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text4 = Strings.GetDefault("SELECT_BUTTON_SELECT");
		_labelSelected.fontSize = (int)text4;
		string text5 = _labelSelected.tag;
		((GameObject)(object)text5).tag = (string)1;
	}

	private void SetToUnselectBlueState()
	{
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_01b9: Expected I4, but got Obj
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I4
		//IL_00fb: Expected I, but got Obj
		//IL_0197: Expected I4, but got Obj
		//IL_006d: Expected I, but got Obj
		_lockedBoardContent.tag = null;
		_uiButtonOverlayOff.LockState(locked: true);
		_uiButtonOverlayOff._002Ector();
		if (~(_shouldShowEventIndicatorsForTryBoardsEvent ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v21 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v28 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("SELECT_BUTTON_SELECTED");
			_labelTry.fontSize = (int)text;
			return;
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v16 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("SELECT_BUTTON_SELECTED");
		_labelSelected.fontSize = (int)text2;
		string text3 = _labelSelected.tag;
		((GameObject)(object)text3).tag = (string)1;
	}

	private void SetToLockedBoard()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00dc: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		_lockedBoardContent.tag = null;
		_uiButtonOverlayOff.LockState(locked: true);
		_uiButtonOverlayOff.GoToNotAvailableState();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v6 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v13 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("HOVERBOARD_THEME_BUTTON_UNSELECT");
		_labelUnselect.fontSize = (int)text;
	}

	private void SetWatchVideo()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_017c: Expected Obj, but got I4
		//IL_0190: Expected I4, but got Obj
		//IL_005e: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I4
		//IL_025b: Expected VT, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_00ec: Expected I, but got Obj
		//IL_0167: Expected I4, but got Obj
		_uiButtonOverlayOff.LockState(locked: true);
		_uiButtonOverlayOff.GoToSelectedState();
		string text = _labelSelected.tag;
		((GameObject)(object)text).tag = null;
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v39 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		Boards.Board board = Boards.boardData.get_Item(_boardId);
		if (board.unlockType == PurchaseData.UnlockType.WeeklyHunt)
		{
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v22 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v37 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = WeeklyHuntManager.ItemsToCollectForBoardType(_boardId);
			obj2 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			WeeklyHuntData.WeeklyHuntPrize weeklyHuntPrize = WeeklyHuntManager.DeterminePrize((WeeklyHuntData.PrizeData)_boardId);
			obj3 = weeklyHuntPrize;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			string text2 = string.Format((IFormatProvider)(object)"{0} / {1}", format, arg);
			_progressLabel.fontSize = (int)text2;
		}
		_lockedBoardContent.tag = (string)1;
		_tokenSprite.fillCenter = (byte)(int)board.tokenSprite2dName != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		((RewardForVideoButton)(object)_lockedBoardLayout).Init((VideoButtonPayload)null);
	}

	public void OnClick()
	{
		//IL_005e: Expected Obj, but got I4
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_0128: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_00be: Expected I, but got Obj
		//IL_01d9: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_050b: Expected I4, but got Obj
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected Obj, but got Unknown
		//IL_0169: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I4
		//IL_028c: Expected I, but got Obj
		//IL_02a2: Expected Obj, but got I
		//IL_021a: Expected I, but got Obj
		//IL_0347: Expected Obj, but got I4
		//IL_0355: Expected I, but got Obj
		//IL_036b: Expected Obj, but got I
		//IL_0555: Expected I4, but got Obj
		//IL_0269: Expected Obj, but got I4
		//IL_031b: Expected I4, but got Obj
		//IL_02cd: Expected I, but got Obj
		//IL_0400: Expected I, but got Obj
		//IL_0416: Expected Obj, but got I
		//IL_0396: Expected I, but got Obj
		//IL_05ad: Expected I4, but got Obj
		//IL_0441: Expected I, but got Obj
		if (_currentVideoState != VideoState.Ready)
		{
			if (_currentVideoState != VideoState.Failed)
			{
				if (_currentVideoState == VideoState.Loading)
				{
					SetWatchVideo();
					_videoSprite.tag = null;
					_loadingSprite.tag = (string)1;
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v69 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v89 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_spacingSprite))
					{
						_spacingSprite.tag = null;
					}
					_watchVideoSubLabel.tag = null;
					nint num3 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v77 (Il2CppClass<Strings>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v84 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text = Strings.GetDefault("AD_OVERLAY_LOADING");
					_watchVideoLabel.fontSize = (int)text;
				}
			}
			else
			{
				SetToLockedBoard();
				_videoSprite.tag = null;
				_loadingSprite.tag = null;
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v61 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_spacingSprite))
				{
					_spacingSprite.tag = (string)1;
				}
				_watchVideoSubLabel.tag = (string)1;
				nint num7 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v46 (Il2CppClass<Strings>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v56 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = Strings.GetDefault("BUTTON_TRY_AGAIN");
				_watchVideoLabel.fontSize = (int)text2;
				string text3 = Strings.GetDefault("CONNECTION_PROBLEM");
				_watchVideoSubLabel.fontSize = (int)text3;
			}
		}
		else
		{
			SetToSelectedBlueState();
			_videoSprite.tag = (string)1;
			_loadingSprite.tag = null;
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_spacingSprite))
			{
				_spacingSprite.tag = null;
			}
			_watchVideoSubLabel.tag = null;
			nint num11 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v18 (Il2CppClass<Strings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v25 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text4 = Strings.GetDefault("GET_NOW");
			_watchVideoLabel.fontSize = (int)text4;
		}
		object obj7 = this - -64;
		((RewardForVideoButton)obj7).Init((VideoButtonPayload)null);
		((RewardForVideoButton)(object)_watchVideoLabelLayout).Init((VideoButtonPayload)null);
	}

	public void rewardedBreakComplete(bool withReward)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			_screenContext = (withReward ? BoardManager.ScreenContext.LimitedBoardPopup : BoardManager.ScreenContext.BoardScreen);
			object obj = this + 176;
			UIButtonOverlayOff component = GetComponent<UIButtonOverlayOff>();
			obj = component;
			SetTryHoverboardUI();
			_hasInited = true;
		}
	}

	private void ActivateTheme(Boards.BoardId boardId, int themeIndex, bool allowSignatureAnimation)
	{
		//IL_003f: Expected Obj, but got I4
		if ((allowSignatureAnimation ? 1 : 0) > (false ? 1 : 0))
		{
			((CrcCalculatorStream)(object)_coinSprite).Write((byte[])boardId, themeIndex, allowSignatureAnimation ? 1 : 0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
	}

	private unsafe void DeactivateTheme(Boards.BoardId boardId, int themeIndex)
	{
		//IL_04ae: Expected VT, but got I4
		//IL_04b7: Expected VT, but got I4
		//IL_04c5: Expected I, but got Obj
		//IL_04db: Expected Obj, but got I
		//IL_071a: Expected I, but got Obj
		//IL_0730: Expected Obj, but got I
		//IL_051b: Expected VT, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00a8: Expected Ref, but got VT
		//IL_02d3: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_0314: Expected I, but got Obj
		//IL_0159: Expected I, but got Obj
		//IL_03df: Expected I, but got Obj
		//IL_03f5: Expected Obj, but got I
		//IL_01a6: Expected I, but got Obj
		//IL_01bc: Expected Obj, but got I
		//IL_05c0: Expected Obj, but got I4
		//IL_05d2: Expected I, but got Obj
		//IL_05e8: Expected Obj, but got I
		//IL_0420: Expected I, but got Obj
		//IL_01e7: Expected I, but got Obj
		//IL_0234: Expected I, but got Obj
		Boards.BoardId boardId3 = default;
		Boards.BoardId? boardId2 = (Boards.BoardId?)(object)(boardId3 + 8);
		boardId2 = (Boards.BoardId?)(object)0;
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v131 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(boardId);
		nint num3 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v20 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v127 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = BoardManager.HasAllThemesBeenSeen(boardId);
		BoardManager.MarkHoverboardAsSeen(boardId3);
		boardId2 = (Boards.BoardId?)(object)((Boards.BoardId*)(int)boardId3)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Nullable`1<Info.Boards+BoardId>)+4]");
		bool flag2;
		if ((nint)0 != 0)
		{
			Boards.BoardId value = ((Boards.BoardId?*)boardId2)->Value;
			flag2 = value == boardId;
		}
		else
		{
			flag2 = false;
		}
		bool flag3 = flag2;
		if (themeIndex != 0)
		{
			int amount = themeIndex - 1;
			string text = ((CelebrationPopupLabelTemplate)null)._GetPowerupLabel((UpgradeType)boardId, amount);
			if (text != null)
			{
				nint num5 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v89 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v119 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (BoardManager.HasAllThemesBeenSeen(boardId))
				{
					nint num7 = (nint)typeof(HoverboardThemes);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v96 (Il2CppClass<HoverboardThemes>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(HoverboardThemes);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v115 (Il2CppClass<HoverboardThemes>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool themeId = ((NotificationsObserver)boardId).DidAppStartFromNotificationAndroid(out *(Notification*)(themeIndex - 1));
					nint num9 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v103 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num10 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v111 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!BoardManager.IsThemeActive(boardId, themeId ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none))
					{
						SetButtonState(ButtonStates.BuyWithInapp);
						return;
					}
				}
			}
			SetButtonState(ButtonStates.Buy);
			return;
		}
		if (flag)
		{
			SetButtonState(ButtonStates.Buy);
			return;
		}
		if (flag3)
		{
			nint num11 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v70 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v79 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserId = Flurry.flurryUserId;
			if (!((SSEventsManagerController)(object)flurryUserId).IsAnyEventEnabled())
			{
				SetButtonState(ButtonStates.Select);
				return;
			}
		}
		string text2 = ((CelebrationPopupLabelTemplate)null)._GetPowerupLabel((UpgradeType)boardId, -1);
		if (text2 != null)
		{
			SetButtonState(ButtonStates.BuyWithInapp);
			return;
		}
		if (~(_shouldShowExpirationTimeForBoardBundleSale ? 1u : 0u) != 0)
		{
			if (~(board.hasOnlineTimeLimit ? 1u : 0u) == 0)
			{
				if (flag3)
				{
					goto IL_045f;
				}
			}
			else
			{
				nint num13 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v55 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num14 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v62 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num15 = WeeklyHuntManager.ItemsCollectedForBoardType(boardId);
				int num16 = num15 ^ 1;
				if (((flag3 ? 1u : 0u) | (uint)num16) != 0)
				{
					goto IL_045f;
				}
			}
		}
		goto IL_06a5;
		IL_045f:
		if (WelcomePackManager.ParseFirstInstalledVersion() == 0)
		{
			SetButtonState(ButtonStates.Buy);
			return;
		}
		goto IL_06a5;
		IL_06a5:
		SetButtonState(ButtonStates.Trial);
	}

	private void OnFailedToCacheVideo(string adLocationId)
	{
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_0126: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.RefreshOnlineSettingsAndInappsIfNeeded();
		nint num3 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v21 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError("Rewarded break finished");
		if (adLocationId != null)
		{
			BoardPurchaseSuccessful();
		}
	}

	private unsafe void OnCachedVideo(string adLocationId, bool wasAlreadyCached)
	{
		//IL_0153: Expected Obj, but got I4
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0200: Expected I, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I4
		//IL_01bb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v43 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((NotificationsObserver)(object)adLocationId).DidAppStartFromNotificationAndroid(out *(wasAlreadyCached ? ((Notification*)1) : ((Notification*)null)));
		nint num3 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v39 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudSave.SetUserDataIfChanged((CloudWorkingCopy)(object)adLocationId, (string)flag, (ICloudUserData)null);
		bool flag2 = ((NotificationsObserver)(object)adLocationId).DidAppStartFromNotificationAndroid(out *(wasAlreadyCached ? ((Notification*)1) : ((Notification*)null)));
		obj = flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private void OnFinishedWatchingVideo()
	{
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Expected Obj, but got Unknown
		//IL_09f0: Expected Obj, but got I4
		//IL_09f9: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got I4
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_0a23: Expected Obj, but got I4
		//IL_0278: Expected I, but got Obj
		//IL_028e: Expected Obj, but got I
		//IL_022b: Expected I, but got Obj
		//IL_02b9: Expected I, but got Obj
		//IL_030a: Expected Obj, but got I4
		//IL_031d: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		//IL_078b: Expected I, but got Obj
		//IL_07a1: Expected Obj, but got I
		//IL_0830: Expected Obj, but got I4
		//IL_0a6b: Expected Obj, but got I4
		//IL_035e: Expected I, but got Obj
		//IL_07cc: Expected I, but got Obj
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected Obj, but got Unknown
		//IL_0495: Expected I, but got Obj
		//IL_04ab: Expected Obj, but got I
		//IL_0a9d: Expected Obj, but got I4
		//IL_0aab: Expected I, but got Obj
		//IL_0ac1: Expected Obj, but got I
		//IL_04d6: Expected I, but got Obj
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected Obj, but got Unknown
		//IL_0957: Expected Obj, but got I4
		//IL_0971: Expected Obj, but got I4
		//IL_0523: Expected I, but got Obj
		//IL_0843: Expected I, but got Obj
		//IL_0859: Expected Obj, but got I
		//IL_0570: Expected I, but got Obj
		//IL_0586: Expected Obj, but got I
		//IL_0ba5: Expected Obj, but got I4
		//IL_0bb3: Expected I, but got Obj
		//IL_0bc9: Expected Obj, but got I
		//IL_0b38: Expected Obj, but got I4
		//IL_0b38: Expected Obj, but got I4
		//IL_0884: Expected I, but got Obj
		//IL_05fe: Expected I, but got Obj
		//IL_0614: Expected Obj, but got I
		//IL_05b1: Expected I, but got Obj
		//IL_08d1: Expected I, but got Obj
		//IL_063f: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		obj2 = 0;
		if (_activeState != ButtonStates.Buy)
		{
			if (_activeState != ButtonStates.Select)
			{
				if (_activeState != ButtonStates.Trial)
				{
					if (_activeState != ButtonStates.BuyWithInapp)
					{
						if (_activeState != ButtonStates.Unselect)
						{
							if (_activeState != ButtonStates.LockedTheme)
							{
								if (_activeState == ButtonStates.WatchVideo)
								{
									bool isInitialized = AdSystemManager.isInitialized;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									nint num = 0;
									_ = 0;
									object obj4 = default;
									object obj3 = obj4 + 16;
									obj3 = this;
									object obj5 = (isInitialized ? 1 : 0) + 20;
									obj5 = obj4;
									bool isInitialized2 = AdSystemManager.isInitialized;
									((PokiUnitySDK)isInitialized2).checkInit();
									return;
								}
								if (_activeState == ButtonStates.GetNow)
								{
									nint num2 = (nint)typeof(UIScreenController);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v136 (Il2CppClass<UIScreenController>)+BA]");
									object obj6 = (nint)0 & (nint)0x200;
									if (obj6 != null)
									{
										nint num3 = (nint)typeof(UIScreenController);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v155 (Il2CppClass<UIScreenController>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									bool flag = UIScreenController.ShouldShowOnlineScreen();
									((UIScreenController)flag)._ActivateNextPopup("CoinsUI_quick");
									nint num4 = (nint)typeof(CoinScreen);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v143 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
									object obj7 = (nint)0 & (nint)0x200;
									if (obj7 != null)
									{
										nint num5 = (nint)typeof(CoinScreen);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v149 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									CoinScreen.openedFromWelcomePackGetNowClick = true;
									return;
								}
							}
							object obj8 = this + 204;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							throw new NullReferenceException();
						}
						bool wasAlreadyCached = (byte)(_currentThemeIndex - 1) != 0;
						OnCachedVideo((string)_boardId, wasAlreadyCached);
					}
					else
					{
						if (~(_purchaseInProgress ? 1u : 0u) == 0)
						{
							return;
						}
						_purchaseInProgress = true;
						SlideinPowerupHelper instance = SlideinPowerupHelper.Instance;
						nint num6 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S2_v30 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num7 = (nint)typeof(BoardManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S2_v36 (Il2CppClass<Data.Managers.BoardManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int currentlyShownHoverboardTheme = BoardManager.GetCurrentlyShownHoverboardTheme(_screenContext);
						((PurchaseHandler)(object)instance).PurchaseHoverboard((Boards.BoardId)currentlyShownHoverboardTheme, this);
					}
					return;
				}
				nint num8 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v33 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num9 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v112 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string flurryUserId = Flurry.flurryUserId;
				if (!((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.tricky))
				{
					return;
				}
				Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
				PlayerSave.awardIsNew = (Dictionary<AwardId, bool>)previousBoardId;
				nint num10 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v44 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num11 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v108 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((EventsSave)1)._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9222");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
				object obj12 = default;
				obj2 = obj12;
				if (obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					throw new NullReferenceException();
				}
				SetTryHoverboardUI();
				nint num12 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S1_v44 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num13 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S1_v62 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BoardManager.boardSelected += (Action)_screenContext;
				nint num14 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v59 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num15 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v102 (Il2CppClass<SSEventsManagerController>)+74]");
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
				nint num16 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v68 (Il2CppClass<UIScreenController>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num17 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S0_v98 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = UIScreenController.ShouldShowOnlineScreen();
				Boards.BoardId previousBoardId2 = PlayerSave.previousBoardId;
				((UIScreenController)flag2).ShowRewardAnimationForBundlePurchase((List<InAppItemModel.BundleItem>)previousBoardId2, null);
				nint num18 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v75 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num19 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S0_v94 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string flurryUserId3 = Flurry.flurryUserId;
				((SSEventsManagerController)(object)flurryUserId3).StartEventTimer();
				if (obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					throw new NullReferenceException();
				}
				return;
			}
			if (_currentThemeIndex != 0)
			{
				int amount = _currentThemeIndex - 1;
				((CelebrationPopupLabelTemplate)this).SetupPowerup((UpgradeType)_boardId, amount, true);
				SetTryHoverboardUI();
			}
			nint num20 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v17 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num21 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v22 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BoardManager.boardSelected += (Action)_screenContext;
		}
		else if (~(_purchaseInProgress ? 1u : 0u) != 0)
		{
			_purchaseInProgress = true;
			bool flag3 = _currentThemeIndex == 0;
			SlideinPowerupHelper instance2 = SlideinPowerupHelper.Instance;
			if (flag3)
			{
				((PurchaseHandler)(object)instance2).PurchaseUpgrade((UpgradeType)_boardId, (IBuyButton)this);
				return;
			}
			Action action = (Action)(_currentThemeIndex - 1);
			((PurchaseHandler)(object)instance2).PurchaseUpgrade((UpgradeType)_boardId, action, (Action)(object)this);
		}
	}

	public void PurchaseSuccessful(bool isBoardTheme = false, int themeIndex = 0)
	{
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(_boardId);
		if (board.unlockType == PurchaseData.UnlockType.WatchVideo)
		{
			_currentVideoState = VideoState.Ready;
			OnClick();
		}
	}

	private void BoardPurchaseSuccessful()
	{
		//IL_01a2: Expected I, but got Obj
		//IL_01b8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_00e2: Expected I, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(_boardId);
		if (board.unlockType != PurchaseData.UnlockType.WatchVideo)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		string text = default;
		text.m_stringLength = (int)num3;
		_ = 0;
		object obj2 = text + 16;
		obj2 = this;
		Timer.Log(text);
		nint num4 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v15 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v32 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardManager.LockBoard(_boardId);
		_0021_00210[] array = (_0021_00210[])(object)UnityEngine.Object.FindObjectsOfType<T>();
		object obj4 = this + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private void BoardThemePurchaseSuccessful(int themeIndex)
	{
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(_boardId);
		if (board.unlockType == PurchaseData.UnlockType.WatchVideo)
		{
			_currentVideoState = VideoState.Failed;
			OnClick();
		}
	}

	public void PurchaseFailure()
	{
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_036f: Expected Obj, but got I4
		//IL_037d: Expected I, but got Obj
		//IL_0393: Expected Obj, but got I
		//IL_0561: Expected Obj, but got I4
		//IL_056f: Expected I, but got Obj
		//IL_0585: Expected Obj, but got I
		//IL_03d2: Expected I, but got Obj
		//IL_03e8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_041e: Expected Obj, but got I4
		//IL_041e: Expected Obj, but got I4
		//IL_042c: Expected I, but got Obj
		//IL_0442: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_048d: Expected I, but got Obj
		//IL_04a3: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_04c9: Expected I4, but got Obj
		//IL_04d5: Expected Obj, but got I4
		//IL_00fa: Expected I, but got Obj
		//IL_0194: Expected Obj, but got I4
		//IL_01a5: Expected I4, but got Obj
		//IL_0147: Expected I, but got Obj
		//IL_01bc: Expected I, but got Obj
		//IL_01d2: Expected Obj, but got I
		//IL_01fd: Expected I, but got Obj
		//IL_024a: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I
		//IL_053a: Expected Obj, but got I4
		//IL_02d8: Expected I, but got Obj
		//IL_02ee: Expected Obj, but got I
		//IL_028b: Expected I, but got Obj
		//IL_0319: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v46 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardManager.boardSelected += (Action)_screenContext;
		nint num3 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v13 (Il2CppClass<Info.Boards>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v84 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(_boardId);
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v22 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v80 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ShowRewardAnimationForBundlePurchase((List<InAppItemModel.BundleItem>)_boardId, null);
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v18 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v42 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(board.name);
		string[] array = text.Split(null);
		nint num9 = (nint)typeof(char);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v33 (Il2CppClass<System.Char>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(char);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v76 (Il2CppClass<System.Char>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		char c = char.ToUpperInvariant((char)(int)array);
		obj = c;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
		string text2 = Strings.GetDefault(board.name);
		string text3 = text2.Trim((char[])1);
		string[] values = default;
		string text4 = string.ConcatArray(values, (int)text3);
		nint num11 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v42 (Il2CppClass<Flurry>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v72 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text5 = ((CelebrationPopupLabelTemplate)null)._GetPowerupLabel((UpgradeType)_boardId, -1);
		if (text5 == null)
		{
			return;
		}
		nint num13 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v51 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num14 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v68 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int ageRestrictionInputVersion = UserSave.ageRestrictionInputVersion;
		obj2 = ageRestrictionInputVersion;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] array2 = default;
		string text6 = string.Concat(array2);
		nint num15 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v61 (Il2CppClass<Flurry>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num16 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v64 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public BoardSelectButton()
	{
		TransformExtensions.Reset((Transform)(object)onPurchaseFailed);
	}

	private void _003COnFinishedWatchingVideo_003Eb__88_0()
	{
		CancelInvoke();
	}
}
