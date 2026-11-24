using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using InAppPurchase;
using Info;
using Kiloo.Common.LocalizationManager;
using SYBO.Subway.Info;
using UI.Generic;
using UI.Generic.Layout;
using UI.Popups.BoardBundlePopupInternal;
using UI.Popups.ConsumablesPopupInternal;
using UI.Popups.LimitedBoardPopupInternal;
using UI.Screens;
using UI.Screens.NotEnoughCurrencyPopupInternal;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.Popups;

public class LimitedBoardPopup : UIScreen
{
	private GameObject _modelAnchor;

	private UILabel _nameLabel;

	private UILabel _staticPowerupLabel;

	private UILabel _descriptionLabel;

	private UISprite _powerIcon;

	private UILabel _themeLimitedLabel;

	private GameObject _themePower;

	private UILabel _themePowerLabel;

	private UIWidget _coinBoxAnchor;

	private UIHoverboardThemeShifter _hoverboardThemeShifter;

	private BoardSelectButton _boardSelectButtonPrefab;

	private UIWidget _boardSelectButtonParent;

	private BoardSelectButton _boardSelectButton;

	private TimerHelper _timerPrefab;

	private UIWidget _timerParent;

	private TimerHelper _timer;

	private const bool ALLOW_SIGNATURE_ANIMATIONS = false;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I4
		ShowIfInactive();
		bool isInstanced = UIScreenController.IsInstanced;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (System.Boolean)+3C]");
		if ((UnityEngine.Object)0 != null)
		{
			bool isInstanced2 = UIScreenController.IsInstanced;
			object obj2 = (isInstanced2 ? 1 : 0) + 60;
			obj2 = _modelAnchor;
		}
		InitializeTimer();
		UpdateUIElements();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
		UIHoverboardThemeShifter hoverboardThemeShifter = _hoverboardThemeShifter;
		hoverboardThemeShifter._context = BoardManager.ScreenContext.LimitedBoardPopup;
	}

	public unsafe override void Hide()
	{
		//IL_0303: Expected I, but got Obj
		//IL_0319: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03b5: Expected I, but got Obj
		//IL_03cb: Expected Obj, but got I
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_0107: Expected I, but got Obj
		//IL_0154: Expected I, but got Obj
		//IL_02d1: Expected Obj, but got I4
		//IL_01ed: Expected I, but got Obj
		//IL_0203: Expected Obj, but got I
		//IL_044e: Expected I, but got Obj
		//IL_0464: Expected Obj, but got I
		//IL_048a: Expected Obj, but got I4
		//IL_022e: Expected I, but got Obj
		//IL_027b: Expected I, but got Obj
		base.Hide();
		nint num = (nint)typeof(LimitedBoardPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v85 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts = SellConsumablesHelper.defaultVideoRewardAmounts;
		_ = 0;
		_boardSelectButton.OnEnable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<int> action = default;
		object obj2 = action + 16;
		obj2 = this;
		_hoverboardThemeShifter.OnClickedTheme -= action;
		UpdateThemeShifter();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<Hoverboard.BoardAbility> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		nint num5 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v28 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v81 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardManager.themeActiveStateChanged -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr;
		((Delegate)action3).method = (nint)__ldftn(LimitedBoardPopup.HidePopupIfNeeded);
		object obj5 = action3 + 16;
		obj5 = this;
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v40 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v77 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<Boards.BoardId> action4 = default;
		object obj7 = action4 + 16;
		obj7 = this;
		BoardManager.boardUnlocked -= action4;
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts2 = SellConsumablesHelper.defaultVideoRewardAmounts;
		int currentlyShownThemeIndex = ((LimitedBoardPopupManager)(object)defaultVideoRewardAmounts2).currentlyShownThemeIndex;
		if (!BoardManager.IsBoardUnlocked((Boards.BoardId)currentlyShownThemeIndex))
		{
			nint num10 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v66 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num11 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v73 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<UpgradeType, int> defaultVideoRewardAmounts3 = SellConsumablesHelper.defaultVideoRewardAmounts;
			int currentlyShownThemeIndex2 = ((LimitedBoardPopupManager)(object)defaultVideoRewardAmounts3).currentlyShownThemeIndex;
			nint num12 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v49 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num13 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v54 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BoardManager.boardUnlocked += (Action<Boards.BoardId>)currentlyShownThemeIndex2;
		}
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).SelectCurrentlyShownBoard(Boards.BoardId.treehugger);
		((NotEnoughCurrencyPopup)this).ActivateUiElement(UiElementType.OkButton, (GameObject)null, (OnActivatedPrefab)null);
		SetupThemeShifter();
	}

	public override void GainFocus()
	{
		//IL_015a: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01b5: Expected I, but got Obj
		//IL_01cb: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I4
		//IL_007f: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I4
		//IL_00cc: Expected I, but got Obj
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		BoardManager.ScreenContext screenContext = default;
		object obj = screenContext + 16;
		obj = this;
		_hoverboardThemeShifter.Init(screenContext);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Boards.BoardId boardId = default;
		object obj2 = boardId + 16;
		obj2 = this;
		nint num3 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v18 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v52 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardManager.ResetDisplayedCustomSets(boardId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action = default;
		object obj4 = action + 16;
		obj4 = this;
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v30 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v48 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Boards.BoardId boardId2 = default;
		object obj6 = boardId2 + 16;
		obj6 = this;
		BoardManager.UnlockBoard(boardId2);
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.LimitedBoardPopup);
		HidePopupIfNeeded();
	}

	public override void LoseFocus()
	{
		//IL_0017: Expected Obj, but got I4
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).SelectCurrentlyShownBoard(Boards.BoardId.treehugger);
		((NotEnoughCurrencyPopup)this).ActivateUiElement(UiElementType.OkButton, (GameObject)null, (OnActivatedPrefab)null);
	}

	private void InitializeSelectButton()
	{
		//IL_0017: Expected Obj, but got I4
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.LimitedBoardPopup);
	}

	private void InitializeTimer()
	{
		//IL_00bd: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		GameObject parent = _boardSelectButtonParent.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 88;
		BoardSelectButton boardSelectButton = UnityEngine.Object.Instantiate(_boardSelectButtonPrefab, (Transform)(object)parent);
		obj2 = boardSelectButton;
		GameObject gameObject = _boardSelectButton.gameObject;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v20 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj4 = default;
		Transform transform = (Transform)(obj4 + 12);
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		_boardSelectButton.rewardedBreakComplete(withReward: true);
	}

	private unsafe void UpdateUIElements()
	{
		//IL_00bd: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0124: Expected I, but got Obj
		//IL_013a: Expected Obj, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got VT
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected VT, but got Unknown
		//IL_019f: Expected F4, but got Obj
		//IL_019a: Expected native int or pointer, but got VT
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got VT
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01f4: Expected F4, but got Obj
		//IL_01ef: Expected native int or pointer, but got VT
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected I4, but got Unknown
		//IL_021c: Expected I4, but got Obj
		//IL_0236: Expected F4, but got Obj
		//IL_0231: Expected native int or pointer, but got VT
		//IL_024b: Expected F4, but got I
		//IL_0246: Expected native int or pointer, but got VT
		//IL_025e: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		GameObject parent = _timerParent.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 100;
		TimerHelper timerHelper = UnityEngine.Object.Instantiate(_timerPrefab, (Transform)(object)parent);
		obj2 = timerHelper;
		nint num3 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v9 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v33 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 44;
		obj4 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
		object obj6 = obj5 + 40;
		obj6 = obj4;
		Matrix4x4 matrix4x = (Matrix4x4)(obj5 - -64);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		object obj7 = obj5 + 24;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		object obj8 = obj5 + 20;
		obj8 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
		object obj9 = obj5 + 16;
		obj9 = obj8;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		bool flag = (byte)(obj5 + 48) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj7 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v20+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_timer.AnimateClock(flag, (byte)(int)matrix4x != 0);
	}

	private unsafe void SetupThemeShifter()
	{
		//IL_0556: Expected I, but got Obj
		//IL_056c: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_05a9: Expected I, but got Obj
		//IL_05bf: Expected Obj, but got I
		//IL_05fd: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_014e: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_018b: Expected I4, but got Obj
		//IL_01ad: Expected I4, but got Obj
		//IL_0663: Expected Obj, but got I4
		//IL_068f: Expected Obj, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_03a9: Expected Obj, but got I4
		//IL_027f: Expected Obj, but got I4
		//IL_03bc: Expected I, but got Obj
		//IL_03d2: Expected Obj, but got I
		//IL_02ab: Expected I, but got Obj
		//IL_02c1: Expected Obj, but got I
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected I4, but got Unknown
		//IL_077b: Expected Obj, but got I4
		//IL_06ea: Expected I, but got Obj
		//IL_0700: Expected Obj, but got I
		//IL_0478: Expected I, but got Obj
		//IL_048e: Expected Obj, but got I
		//IL_03fd: Expected I, but got Obj
		//IL_073e: Expected I4, but got Obj
		//IL_074e: Expected I4, but got Obj
		//IL_02ec: Expected I, but got Obj
		//IL_07c2: Expected Obj, but got I4
		//IL_0339: Expected I, but got Obj
		//IL_0500: Expected Obj, but got VT
		//IL_050d: Expected I4, but got Obj
		//IL_04b9: Expected I, but got Obj
		nint num = (nint)typeof(LimitedBoardPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v114 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts = SellConsumablesHelper.defaultVideoRewardAmounts;
		int currentlyShownThemeIndex = ((LimitedBoardPopupManager)(object)defaultVideoRewardAmounts).currentlyShownThemeIndex;
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts2 = SellConsumablesHelper.defaultVideoRewardAmounts;
		nint num3 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v6 (Il2CppClass<Info.Boards>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v87 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)currentlyShownThemeIndex);
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v4 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S2_v56 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(board.name);
		_nameLabel.fontSize = (int)text;
		Boards.Board board2 = Boards.boardData.get_Item((Boards.BoardId)currentlyShownThemeIndex);
		string text2 = Strings.GetDefault(board2.description);
		_descriptionLabel.fontSize = (int)text2;
		Boards.Board board3 = Boards.boardData.get_Item((Boards.BoardId)currentlyShownThemeIndex);
		string text3 = Strings.GetDefault(board3.limitedDescription);
		_themeLimitedLabel.fontSize = (int)text3;
		string text4 = Strings.GetDefault("BOARD_SCREEN_SPECIAL_POWER");
		_staticPowerupLabel.fontSize = (int)text4;
		Boards.Board board4 = Boards.boardData.get_Item((Boards.BoardId)currentlyShownThemeIndex);
		string text5 = Strings.GetDefault(board4.limitedDescription);
		bool flag = text5 == null || text5.m_stringLength == 0;
		Boards.Board board5 = Boards.boardData.get_Item((Boards.BoardId)currentlyShownThemeIndex);
		string text6 = Strings.GetDefault(board5.description);
		bool flag2 = text6 == null || text6.m_stringLength == 0;
		string text7 = (string)((flag2 ? 1 : 0) ^ 1);
		_powerIcon.tag = text7;
		_staticPowerupLabel.tag = text7;
		string text8 = (string)((flag ? 1 : 0) ^ 1);
		_themeLimitedLabel.tag = text8;
		object obj4 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (System.Collections.Generic.Dictionary`2<Info.UpgradeType, System.Int32>)+10]");
		if ((nint)0 != 0)
		{
			((GameObject)obj4).tag = (string)1;
			string text9 = _nameLabel.tag;
			((GameObject)(object)text9).tag = null;
			nint num7 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v68 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S1_v81 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item((Boards.BoardId)currentlyShownThemeIndex);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (System.Collections.Generic.Dictionary`2<Info.UpgradeType, System.Int32>)+10]");
			int index = (int)(-1);
			HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index);
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S2_v45 (Il2CppClass<Strings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S2_v52 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text10 = Strings.GetDefault(hoverboardTheme.title);
			_themePowerLabel.fontSize = (int)text10;
			_themeLimitedLabel.fontSize = (int)"";
		}
		else
		{
			((GameObject)obj4).tag = null;
			string text11 = _nameLabel.tag;
			((GameObject)(object)text11).tag = (string)1;
		}
		nint num11 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v56 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v90 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = default;
		HorizontalAlignment horizontalAlignment = (HorizontalAlignment)(obj8 + 8);
		bool flag3 = BoardManager.HasAllThemesBeenSeen((Boards.BoardId)currentlyShownThemeIndex);
		object obj9 = flag | flag3;
		if (obj9 != null)
		{
			_timer.HideIcon();
			string text12 = _timer.tag;
			((GameObject)(object)text12).tag = null;
		}
		else
		{
			nint num13 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v70 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num14 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v81 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime dateTime = BoardManager.BoardStartAvailabilityDate((Boards.BoardId)currentlyShownThemeIndex);
			string text13 = _timer.tag;
			((GameObject)(object)text13).tag = (string)1;
			obj8 = dateTime;
			((HorizontalAlignment*)(int)horizontalAlignment)->value__ = (int)obj8;
			_timer.SetAlignment(horizontalAlignment);
		}
		LogFlurryEvent();
		BoardSelectButton boardSelectButton = _boardSelectButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (System.Collections.Generic.Dictionary`2<Info.UpgradeType, System.Int32>)+10]");
		boardSelectButton.DeactivateTheme((Boards.BoardId)currentlyShownThemeIndex, 0);
	}

	private void UpdateThemeShifter()
	{
		_hoverboardThemeShifter._002Ector();
		LogFlurryEvent();
	}

	private void BoardUnlocked(Boards.BoardId boardId)
	{
		//IL_01d4: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_005d: Expected I, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_020b: Expected Obj, but got I
		//IL_0225: Expected I4, but got Obj
		//IL_0225: Expected Obj, but got I
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_009e: Expected I, but got Obj
		//IL_0263: Expected Obj, but got I
		//IL_0271: Expected I, but got Obj
		//IL_0287: Expected Obj, but got I
		//IL_00eb: Expected I4, but got Obj
		//IL_02bb: Expected Obj, but got I4
		//IL_013f: Expected I, but got Obj
		//IL_018c: Expected I, but got Obj
		UIEventListener component = ((GameObject)boardId).GetComponent<UIEventListener>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10+1C]");
		Locale locale = (Locale)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10+1C]");
		if ((Locale)0 != null)
		{
			return;
		}
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v53 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B5E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v23+8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v24+18]");
		if (((string)0).get_Chars((int)locale.combined) == '\0')
		{
			PreferencesSave.soundEffectsEnabled = (byte)(int)locale.combined != 0;
			return;
		}
		nint num3 = (nint)typeof(LanguageSelectionConfirmationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v29 (Il2CppClass<UI.Popups.LanguageSelectionConfirmationPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(LanguageSelectionConfirmationPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v46 (Il2CppClass<UI.Popups.LanguageSelectionConfirmationPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10+1C]");
		LanguageSelectionConfirmationPopup.requestedLocale = (Locale)0;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v36 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v42 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("LanguageSelectionConfirmationPopup");
	}

	private void OnThemeActiveStateChanged(Hoverboard.BoardAbility boardAbility)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		((UnityEngine.Object)instance).m_CachedPtr = (IntPtr)1;
	}

	private void ThemeButtonClicked(int index)
	{
		//IL_0014: Expected Obj, but got I4
		//IL_0014: Expected Obj, but got I4
		((NotEnoughCurrencyPopup)this).ActivateUiElement(UiElementType.OkButton, (GameObject)1, (OnActivatedPrefab)index);
	}

	private void UpdateDisplayedModelWithTheme(Boards.BoardId boardId, int themeIndex)
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I4
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v12 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("INVENTORY_ITEM_COUNTER");
		object obj2 = themeIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = string.Format(format, args);
		_staticPowerupLabel.fontSize = (int)text;
	}

	private void ShowHoverboardInMenu(bool willUpdateAnimation, bool willAllowSignatureAnimation, Hoverboard.BoardAbility ability = Hoverboard.BoardAbility.None)
	{
		//IL_0079: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_009b: Expected I4, but got Obj
		//IL_009b: Expected Obj, but got I4
		//IL_0012: Expected Obj, but got I4
		//IL_0012: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I4
		IsIAPConsumableValue isIAPConsumableValue = ((InAppManager)ability).IsProductConsumable((string)willAllowSignatureAnimation);
		InAppItemModel inAppItemModel = InAppItemModel.Clone((InAppItemModel)ability);
		((BoardBundleItem)willUpdateAnimation).SetupThemeInfo(willAllowSignatureAnimation ? 1 : 0, (int)inAppItemModel);
		((BoardBundleItem)willUpdateAnimation).SetupTrail((GameObject)isIAPConsumableValue);
		int num = 0;
		while (true)
		{
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6 (InAppPurchase.IsIAPConsumableValue)+C]");
			if ((nint)num2 >= (nint)0)
			{
				break;
			}
			int boardId = ((List<int>)isIAPConsumableValue).get_Item(num);
			((BundleIcon)willUpdateAnimation).SetupTheme((Boards.BoardId)boardId, num);
			int num3 = num + 1;
			num = num3;
		}
		((BoardBundleItem)willUpdateAnimation)._002Ector();
	}

	private void LogFlurryEvent()
	{
		//IL_01ad: Expected I, but got Obj
		//IL_01c3: Expected Obj, but got I
		//IL_022f: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I
		//IL_02cb: Expected Obj, but got I
		//IL_02db: Expected Obj, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01ee: Expected I, but got Obj
		//IL_0204: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0189: Expected I4, but got Obj
		//IL_013b: Expected I, but got Obj
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v41 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(LimitedBoardPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v20 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts = SellConsumablesHelper.defaultVideoRewardAmounts;
		int currentlyShownThemeIndex = ((LimitedBoardPopupManager)(object)defaultVideoRewardAmounts).currentlyShownThemeIndex;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S2_v4 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S2_v5+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S2_v6+44]");
		object obj5 = 0;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v61 @ S3_v4 (should have been resolved before IL gen)");
		object obj8 = default;
		if ((nint)obj8 > -1)
		{
			nint num6 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v18 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num7 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v35 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num8 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v26 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v31 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<UpgradeType, int> defaultVideoRewardAmounts2 = SellConsumablesHelper.defaultVideoRewardAmounts;
			int currentlyShownThemeIndex2 = ((LimitedBoardPopupManager)(object)defaultVideoRewardAmounts2).currentlyShownThemeIndex;
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item((Boards.BoardId)currentlyShownThemeIndex2);
			_hoverboardThemeShifter.UpdateSelector((int)list);
		}
		else
		{
			_hoverboardThemeShifter.UpdateThemeStates();
		}
	}

	private string GetStateString(bool state)
	{
		//IL_00e8: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		nint num = (nint)typeof(CharacterNameEventManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CharacterNameEventManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<CharacterNameEventManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = CharacterNameEventManager.FILTERED_CHARACTERS + 12;
		object obj3 = 0;
		string result;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
			result = null;
			if (flag)
			{
				break;
			}
			object obj4 = CharacterNameEventManager.FILTERED_CHARACTERS + 16;
			object obj5 = obj3 << 1;
			object obj6 = obj4 + obj5;
			object obj7 = (state ? 1 : 0) & 0xFFFF;
			if (obj6 == obj7)
			{
				result = (string)1;
				break;
			}
			object obj8 = obj3 + 1;
			obj3 = obj8;
		}
		return result;
	}

	private void HidePopupIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected Obj, but got Unknown
		//IL_0567: Expected Obj, but got I4
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_0584: Expected Obj, but got I4
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		//IL_05ae: Expected I, but got Obj
		//IL_05c4: Expected Obj, but got I
		//IL_0767: Expected I, but got Obj
		//IL_077d: Expected Obj, but got I
		//IL_0601: Expected I, but got Obj
		//IL_0617: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0661: Expected I, but got Obj
		//IL_0677: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_0154: Expected I4, but got Obj
		//IL_0108: Expected I, but got Obj
		//IL_0175: Expected Obj, but got I4
		//IL_0195: Expected I4, but got Obj
		//IL_01ba: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I
		//IL_07d9: Expected I, but got Obj
		//IL_07ef: Expected Obj, but got I
		//IL_01fb: Expected I, but got Obj
		//IL_0511: Expected I, but got Obj
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03e6: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_02a8: Expected I, but got Obj
		//IL_02be: Expected Obj, but got I
		//IL_046e: Expected Obj, but got I
		//IL_02e9: Expected I, but got Obj
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 32;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(LimitedBoardPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v214 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts = SellConsumablesHelper.defaultVideoRewardAmounts;
		int currentlyShownThemeIndex = ((LimitedBoardPopupManager)(object)defaultVideoRewardAmounts).currentlyShownThemeIndex;
		nint num3 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v28 (Il2CppClass<Info.Boards>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v208 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)currentlyShownThemeIndex);
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v17 (Il2CppClass<Strings>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v106 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(board.name);
		string args = text.ToLowerInvariant();
		nint num7 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v40 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v204 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = BoardManager.HasAllThemesBeenSeen((Boards.BoardId)currentlyShownThemeIndex);
		string text2 = $"Board {(object[])(object)args} bought";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		stringBuilder.Length = (int)text2;
		StringBuilder stringBuilder2 = stringBuilder.AppendLine(";");
		string themeNameForAnalytics = ((LimitedCharacterPopup)null).GetThemeNameForAnalytics((Outfit)flag);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder3 = default;
		stringBuilder3.Length = (int)themeNameForAnalytics;
		StringBuilder stringBuilder4 = stringBuilder3.AppendLine(";");
		nint num9 = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v62 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num10 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v200 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CelebrationReward celebrationReward = MysteryBox.Roll((MysteryBox.Type)currentlyShownThemeIndex);
		if (celebrationReward != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj11 = default;
			object obj13 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj11 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v134+28]");
				obj4 = 0;
				nint num11 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v139 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num12 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v193 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				obj4 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			}
			object obj14 = obj5 + 4;
			object obj15 = obj14 + 1;
			obj14 = obj15;
			object obj16 = obj15 << 2;
			object obj17 = obj5 + obj16;
			obj17 = 232;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
				object obj18 = (nint)0 << 2;
				object obj19 = obj5 + obj18;
				if ((nint)obj19 == 232)
				{
					object obj20 = obj5 + 4;
					if ((nint)obj20 > -1)
					{
						object obj21 = obj20 + -1;
						obj20 = obj21;
					}
					goto IL_07b7;
				}
			}
			object obj22 = default;
			if (obj22 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_07b7;
		IL_07b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num13 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v74 (Il2CppClass<Flurry>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num14 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v79 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private unsafe static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_04e5: Expected I, but got Obj
		//IL_04fb: Expected Obj, but got I
		//IL_0720: Expected I, but got Obj
		//IL_0736: Expected Obj, but got I
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected Ref, but got Unknown
		//IL_0533: Expected Obj, but got I4
		//IL_0545: Expected I, but got Obj
		//IL_055b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_05d9: Expected Obj, but got I
		//IL_05ea: Expected I4, but got Obj
		//IL_018c: Expected I, but got Obj
		//IL_0116: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I4
		//IL_021d: Expected I, but got Obj
		//IL_0233: Expected Obj, but got I
		//IL_05f9: Expected Obj, but got I4
		//IL_025e: Expected I, but got Obj
		//IL_02a6: Expected Obj, but got I4
		//IL_02b8: Expected I, but got Obj
		//IL_02ce: Expected Obj, but got I
		//IL_02f9: Expected I, but got Obj
		//IL_0346: Expected I, but got Obj
		//IL_035c: Expected Obj, but got I
		//IL_0657: Expected Obj, but got I
		//IL_0387: Expected I, but got Obj
		//IL_06c9: Expected I, but got Obj
		//IL_06df: Expected Obj, but got I
		//IL_03fc: Expected I, but got Obj
		//IL_0412: Expected Obj, but got I
		//IL_0787: Expected Obj, but got I4
		//IL_0787: Expected Obj, but got I4
		//IL_0787: Expected Obj, but got I4
		//IL_0787: Expected Obj, but got I
		//IL_0787: Expected Obj, but got I4
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected I4, but got Unknown
		//IL_0498: Expected I, but got Obj
		//IL_043d: Expected I, but got Obj
		nint num = (nint)typeof(LimitedBoardPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v134 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts = SellConsumablesHelper.defaultVideoRewardAmounts;
		int currentlyShownThemeIndex = ((LimitedBoardPopupManager)(object)defaultVideoRewardAmounts).currentlyShownThemeIndex;
		nint num3 = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v130 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool themeId = ((NotificationsObserver)currentlyShownThemeIndex).DidAppStartFromNotificationAndroid(out *(Notification*)(context - 1));
		nint num5 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v126 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = BoardManager.IsThemeActive((Boards.BoardId)currentlyShownThemeIndex, themeId ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none);
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts2 = SellConsumablesHelper.defaultVideoRewardAmounts;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (System.Collections.Generic.Dictionary`2<Info.UpgradeType, System.Int32>)+10]");
		if (0 == (nint)context)
		{
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+58]");
				((BoardSelectButton)0).OnFinishedWatchingVideo();
			}
			else if ((object)context != null)
			{
				return;
			}
		}
		nint num7 = (nint)typeof(LimitedBoardPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v34 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v117 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts3 = SellConsumablesHelper.defaultVideoRewardAmounts;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+58]");
		((BoardSelectButton)0).OnEnable();
		((LimitedCharacterPopup)(object)msg).UpdateThemeShifter((Characters.CharacterId)currentlyShownThemeIndex, (int)context);
		if (flag)
		{
			return;
		}
		bool isInstanced = UIScreenController.IsInstanced;
		Characters.CharacterId activeCharacterId = ((UIModelController)isInstanced).GetActiveCharacterId(UIModelController.ModelScreen.LimitedBoardPopup);
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v113 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)activeCharacterId).FindKernel(null) == 0)
		{
			return;
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)activeCharacterId).AddEquippedHoverboard();
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v60 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v109 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)hoverboardBundle).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v105 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+A8]");
		if (((ComputeShader)0).FindKernel(null) == 0)
		{
			return;
		}
		Hoverboard.BoardAbility boardAbility;
		if ((nint)context > 0)
		{
			nint num15 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v89 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num16 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v99 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item((Boards.BoardId)currentlyShownThemeIndex);
			int index = context - 1;
			HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index);
			boardAbility = hoverboardTheme.power;
		}
		else
		{
			boardAbility = Hoverboard.BoardAbility.None;
		}
		nint num17 = (nint)typeof(HoverboardModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v77 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num18 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v83 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinMagnet instance = CoinMagnet.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v47 (SYBO.Subway.Info.Characters+CharacterId)+A8]");
		((TutorialMultilineLabelsHelper)(object)instance).SetText((string)currentlyShownThemeIndex, (string)(object)hoverboardBundle, (string)0, (string)1, (string)1, (string)boardAbility);
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public LimitedBoardPopup()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(LimitedBoardPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<UpgradeType, int> defaultVideoRewardAmounts = SellConsumablesHelper.defaultVideoRewardAmounts;
		if (((LimitedBoardPopupManager)(object)defaultVideoRewardAmounts).ShouldButtonBeVisible())
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)"LimitedBoardPopup");
	}
}
