using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using InApp;
using InAppPurchase;
using Info;
using UI.Generic;
using UI.Generic.Layout;
using UI.Pages.DailyChallengePageInternal;
using UI.Popups.AgeRestrictionPopupInternal;
using UI.Popups.BoardBundlePopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class BoardBundlePopup : UIScreen
{
	private GameObject _topAnchor;

	private UILabel _popupBoardTitle;

	private UILabel _popupBoardName;

	private TimerHelper _timerPrefab;

	private UIWidget _timerContainer;

	private Layout _timerLayout;

	private BoardBundleItem _board;

	private BoardBundleItem _bundle1;

	private BoardBundleItem _bundle2;

	private UILabel _bestStickerLabel;

	private TimerHelper _timer;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	private unsafe void SetupBundle(BoardBundleItem boardBundleItem, Boards.BoardId boardId, InAppItemModel inAppItemModel)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Ref, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Ref, but got Unknown
		//IL_023b: Expected Obj, but got I4
		//IL_0248: Invalid comparison between VT and I4
		//IL_0183: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ListElementHelper component = ((GameObject)(object)boardBundleItem._bundleIcons).GetComponent<ListElementHelper>();
		ListContentElement listContentElement = component._listContentElement;
		_ = listContentElement.value__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = default;
		obj = obj3;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S4_v3+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S4_v4+78]");
		object obj6 = 0;
		object obj7 = obj6 & 0x7FF;
		object obj8 = obj7 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S5_v4 (should have been resolved before IL gen)");
		object obj9 = default;
		ref bool reference = ref (object)this == null ? ref *(bool*)(obj9 - 1) : ref *(bool*)(obj9 + 1);
		bool flag = (nint)inAppItemModel.normalOfferId == 1;
		bool flag2 = !flag;
		ref bool reference2 = ref reference;
		if (!flag2)
		{
			if ((object)this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardId @ L2 (Info.Boards+BoardId)+C]");
				bool flag3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) >= unchecked((nint)null);
				bool flag4 = !flag3;
				reference2 = ref reference;
				if (!flag4)
				{
					reference2 = ref *(bool*)null;
				}
			}
			else
			{
				bool flag5 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) < unchecked((nint)null);
				bool flag6 = !flag5;
				reference2 = ref reference;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [boardId @ L2 (Info.Boards+BoardId)+C]");
					reference2 = ref *(bool*)(-1);
				}
			}
		}
		_0021_00210 eventValue = (_0021_00210)((ExpiredLimitedBoardEventManager)boardId).GetEventValue<T>(out reference2);
		if (eventValue != (_0021_00210)(object)0)
		{
			ListContentElement listContentElement2 = ((List<ListContentElement>)boardId).get_Item((int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2));
			GameObject gameObject = listContentElement2.helper__BackingField.gameObject;
			Vector2 vector = ((CoinBoxSizer)(object)gameObject).CalculateDistanceToBounds((UIWidget)null);
		}
	}

	public override void Show()
	{
		//IL_01aa: Expected I, but got Obj
		//IL_01c0: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0220: Expected I4, but got Obj
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0239: Expected I, but got Obj
		//IL_024f: Expected Obj, but got I
		//IL_028b: Expected Obj, but got I
		//IL_02a9: Expected I4, but got Obj
		//IL_02a9: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_015c: Expected I4, but got Obj
		//IL_015c: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0190: Expected I4, but got Obj
		//IL_0190: Expected I4, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v35 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		OnCloseClicked();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (System.Int32)+1C]");
		((BoardPromotionPopup)this).SetupTop(Boards.BoardId.normal);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v21 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("BOARD_BUNDLE_BEST_STICKER");
		_bestStickerLabel.fontSize = (int)text;
		object obj3 = this - -64;
		nint num5 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v22 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex2 = ChallengesScreen.GetPageIndex();
		Dictionary<string, InAppItemModel> inAppData = InAppData.inAppData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S4_v2 (System.Int32)+10]");
		InAppItemModel inAppItemModel = inAppData.get_Item((string)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (System.Int32)+1C]");
		((LimitedBoardPopup)null).ShowHoverboardInMenu((byte)(int)obj3 != 0, false, (Hoverboard.BoardAbility)inAppItemModel);
		InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item("com.kiloo.subwayboard.mumbai.bundletier1");
		BoardBundleItem bundle = _bundle1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (System.Int32)+1C]");
		((LimitedBoardPopup)null).ShowHoverboardInMenu((byte)(int)bundle != 0, false, (Hoverboard.BoardAbility)inAppItemModel2);
		InAppItemModel inAppItemModel3 = InAppData.inAppData.get_Item("com.kiloo.subwayboard.mumbai.bundletier2");
		BoardBundleItem bundle2 = _bundle2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (System.Int32)+1C]");
		((LimitedBoardPopup)null).ShowHoverboardInMenu((byte)(int)bundle2 != 0, false, (Hoverboard.BoardAbility)inAppItemModel3);
	}

	public override void GainFocus()
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		base.Hide();
		object obj = this - -64;
		((BoardBundleItem)obj).LoseFocus();
		_bundle1.LoseFocus();
		_bundle2.LoseFocus();
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v14 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v18 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public override void LoseFocus()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		((BoardBundleItem)obj).Show();
		_bundle1.Show();
		_bundle2.Show();
	}

	private void InitializeTimer()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		((BoardBundleItem)obj).Align();
		_bundle1.Align();
		_bundle2.Align();
	}

	public unsafe void OnCloseClicked()
	{
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017a: Expected Obj, but got VT
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected VT, but got Unknown
		//IL_01ab: Expected F4, but got Obj
		//IL_01a6: Expected native int or pointer, but got VT
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01dd: Expected Obj, but got VT
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0200: Expected F4, but got Obj
		//IL_01fb: Expected native int or pointer, but got VT
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected I4, but got Unknown
		//IL_0228: Expected I4, but got Obj
		//IL_0242: Expected F4, but got Obj
		//IL_023d: Expected native int or pointer, but got VT
		//IL_0257: Expected F4, but got I
		//IL_0252: Expected native int or pointer, but got VT
		//IL_026a: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		GameObject parent = _timerContainer.gameObject;
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 80;
		TimerHelper timerHelper = Object.Instantiate(_timerPrefab, (Transform)(object)parent);
		obj2 = timerHelper;
		nint num3 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v9 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v34 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 44;
		obj4 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_TEXT;
		object obj6 = obj5 + 40;
		obj6 = obj4;
		Matrix4x4 matrix4x = (Matrix4x4)(obj5 - -64);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		object obj7 = obj5 + 24;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		object obj8 = obj5 + 20;
		obj8 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_BG;
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
		_timer.SetTimerText(null);
	}

	public void OnBoardPurchaseClicked()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
	}

	public void OnBundle1PurchaseClicked()
	{
		//IL_009b: Expected I, but got Obj
		//IL_00b1: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_008c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		int pageIndex2 = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		PurchaseResult purchaseResult = default;
		object obj2 = purchaseResult + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (System.Int32)+10]");
		((BoardBundlePopupManager)pageIndex).OnPurchaseFailedOrCancelled((string)0, purchaseResult);
	}

	public void OnBundle2PurchaseClicked()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		PurchaseResult purchaseResult = default;
		object obj2 = purchaseResult + 16;
		obj2 = this;
		((BoardBundlePopupManager)pageIndex).OnPurchaseFailedOrCancelled("com.kiloo.subwayboard.mumbai.bundletier1", purchaseResult);
	}

	private void SetupTop(Boards.BoardId boardId)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I
		//IL_0029: Expected I, but got Obj
		//IL_003f: Expected Obj, but got I
		//IL_016b: Expected Obj, but got F4
		//IL_0180: Expected Obj, but got F4
		//IL_01a2: Expected Obj, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_023e: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 12;
		obj4 = 0;
		_ = 0;
		object obj5 = this + 84;
		obj5 = boardId;
		string text = ((Component)boardId).tag;
		bool isInstanced = UIScreenController.IsInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v16 (System.Boolean)+18]");
		int layer = ((GameObject)0).layer;
		bool flag = ((RegularDayHelper)(object)text).ShouldActivateDivider(layer, 31);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj3 = 9f;
		_ = -165f;
		_ = 0f;
		obj4 = 13f;
		_ = 13f;
		_ = 13f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.BoardBundlePopup)+54]");
		((CharacterScreenController)0).SetFreeze(0f);
		string text2 = (string)(obj2 + 48);
		text2 = (string)obj;
		string text3 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		text3.m_stringLength = 0;
		string text4 = (string)(obj2 + 60);
		text4 = (string)obj3;
		string text5 = text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		text5.m_stringLength = 0;
		string text6 = (string)(obj2 + 72);
		text6 = (string)obj4;
		string text7 = text6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		text7.m_stringLength = 0;
		((SecretPopup)(object)_timerPrefab).InsertDoubleInfo((string)flag, text2, text4, text6);
	}

	public BoardBundlePopup()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		PurchaseResult purchaseResult = default;
		object obj2 = purchaseResult + 16;
		obj2 = this;
		((BoardBundlePopupManager)pageIndex).OnPurchaseFailedOrCancelled("com.kiloo.subwayboard.mumbai.bundletier2", purchaseResult);
	}
}
