using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using SYBO.Subway.Info;
using UI.Screens.CharacterScreenInternal;
using UnityEngine;

namespace UI.Screens.BoardScreenInternal;

public class HoverboardOverlayHelper : MonoBehaviour
{
	public Boards.BoardId _cachedBoardId;

	private bool _currentlySelected;

	private int _placementIndex;

	private Transform _trackerTransform;

	private Camera _3DClipCam;

	private Camera _2DOverlayCam;

	private Transform _cachedTransform;

	private float _topOverlayMinX;

	private float _topOverlayMaxX;

	private float _currentDistFromCenter;

	private bool _dirtyDist;

	private bool _hasEventBeenTried;

	private Boards.BoardId? _eventBoardId;

	private Transform _topOverlay;

	private UISprite _newBubble;

	private UISprite _limitedBubble;

	private UISprite _limitedIcon;

	private UISprite _giftBubble;

	private UISprite _eventBubble;

	private Transform _bottomOverlay;

	private UISprite _ownedSprite;

	private UISprite _selectedSprite;

	private UISprite _trialSprite;

	public float currentDistFromCenter
	{
		set
		{
			_topOverlayMaxX = value;
		}
	}

	public unsafe void Init(int index, Boards.BoardId id, Transform transformToTrack)
	{
		//IL_01e3: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		//IL_03b2: Expected Obj, but got I
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got I
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got VT
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected VT, but got Unknown
		//IL_025e: Expected F4, but got Obj
		//IL_0259: Expected native int or pointer, but got VT
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0286: Expected F4, but got Obj
		//IL_0281: Expected native int or pointer, but got VT
		//IL_029b: Expected F4, but got I
		//IL_0296: Expected native int or pointer, but got VT
		//IL_02b0: Expected I4, but got VT
		//IL_02b0: Expected Obj, but got I
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_02d2: Expected Obj, but got VT
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02f5: Expected F4, but got Obj
		//IL_02f0: Expected native int or pointer, but got VT
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0111: Expected F4, but got Obj
		//IL_010c: Expected native int or pointer, but got VT
		//IL_0126: Expected F4, but got I
		//IL_0121: Expected native int or pointer, but got VT
		//IL_0133: Expected I4, but got VT
		//IL_0141: Expected I, but got Obj
		//IL_0157: Expected Obj, but got I
		//IL_00c5: Expected I, but got Obj
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_032c: Expected Obj, but got VT
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_034f: Expected F4, but got Obj
		//IL_034a: Expected native int or pointer, but got VT
		//IL_0369: Expected F4, but got Obj
		//IL_0364: Expected native int or pointer, but got VT
		//IL_037e: Expected F4, but got I
		//IL_0379: Expected native int or pointer, but got VT
		//IL_038d: Expected I4, but got VT
		//IL_0182: Expected I, but got Obj
		_currentlySelected = (byte)index != 0;
		_cachedBoardId = id;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v31 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 20;
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v8 (System.Boolean)+38]");
		obj2 = 0;
		object obj3 = this + 24;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v12 (System.Boolean)+24]");
		obj3 = 0;
		object obj4 = this + 32;
		GameObject gameObject = base.gameObject;
		obj4 = gameObject;
		Characters.CharacterId? characterId = ((ScrollListCharacterUI)(object)transformToTrack).EventCharacter();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77EA");
		nint num3 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v20 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v66 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = default;
		object obj6 = obj7 + 68;
		obj6 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
		object obj8 = obj7 + 72;
		obj8 = obj6;
		Matrix4x4 matrix4x = (Matrix4x4)(obj7 + 80);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		object obj9 = obj7 + 48;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v31+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.BoardScreenInternal.HoverboardOverlayHelper)+3C]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj10 = this - -64;
		object obj11 = obj7 + 44;
		obj11 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
		object obj12 = obj7 - -64;
		obj12 = obj11;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
		object obj13 = obj7 + 24;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v42+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)obj10).rawPivot = (UIWidget.Pivot)matrix4x;
		nint num5 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v47 (Il2CppClass<GlobalColors>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num6 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v60 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj15 = obj7 + 16;
		obj15 = GlobalColors.FIRST_PURCHASE_BONUS_BREADCRUMP_BUBBLE_COLOR;
		object obj16 = obj7 + 40;
		obj16 = obj15;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_limitedIcon.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	private void OnEnable()
	{
		//IL_0016: Expected I4, but got F4
		_currentDistFromCenter = 1f;
		_dirtyDist = true;
		CancelInvoke();
	}

	private unsafe void OnDisable()
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_014d: Expected VT, but got Obj
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_019a: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00e0: Expected I, but got Obj
		HoverboardThemeButton hoverboardThemeButton = default;
		hoverboardThemeButton.themeIndex = 0;
		object obj = hoverboardThemeButton + 8;
		obj = hoverboardThemeButton;
		_eventBoardId = (Boards.BoardId?)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(HoverboardOverlayHelper.RefreshEvent);
		object obj2 = action + 16;
		obj2 = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v48 (Il2CppClass<SSEventsManagerController>)+74]");
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
		((Delegate)action2).method = (nint)__ldftn(HoverboardOverlayHelper.RefreshEvent);
		object obj4 = action2 + 16;
		obj4 = this;
		SSEventsManagerController.OnSSEventFinishedHandler -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(HoverboardOverlayHelper.RefreshEvent);
		object obj5 = action3 + 16;
		obj5 = this;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v38 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v44 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action3;
	}

	private unsafe void RefreshEvent()
	{
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0158: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00cc: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(HoverboardOverlayHelper.RefreshEvent);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v40 (Il2CppClass<SSEventsManagerController>)+74]");
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
		((Delegate)action2).method = (nint)__ldftn(HoverboardOverlayHelper.RefreshEvent);
		object obj3 = action2 + 16;
		obj3 = this;
		SSEventsManagerController.OnSSEventChangedHandler += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj4 = action3 + 16;
		obj4 = this;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v31 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action3;
	}

	public void SelectedInMenu()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0081: Expected VT, but got Obj
		//IL_008f: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		HoverboardThemeButton hoverboardThemeButton = default;
		hoverboardThemeButton.themeIndex = 0;
		object obj = hoverboardThemeButton + 8;
		obj = hoverboardThemeButton;
		_eventBoardId = (Boards.BoardId?)obj;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v20 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool hasEventBeenTried = ((SSEventsManagerController)(object)flurryUserId).IsAnyEventEnabled();
		_hasEventBeenTried = hasEventBeenTried;
		bool currentlySelected = _currentlySelected;
		Boards.BoardId? boardId = ((HoverboardOverlayHelper)currentlySelected).EventBoard();
	}

	public void RefreshSelected(bool selected)
	{
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		obj2 = 0;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v39 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		HoverboardOverlayHelper hoverboardOverlayHelper;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj5 = default;
			object obj4 = obj5 - 3;
			if ((nint)obj5 == 3 || ((nint)obj4 != 1 && (nint)obj4 != 2 && (nint)obj4 != 3 && (nint)obj4 == 4))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
				if (obj != null)
				{
					hoverboardOverlayHelper = (HoverboardOverlayHelper)0;
					_ = 1;
					object obj6 = default;
					hoverboardOverlayHelper = (HoverboardOverlayHelper)obj6;
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		hoverboardOverlayHelper = (HoverboardOverlayHelper)obj2;
	}

	private bool BoardHasFreeThemes(Boards.BoardId boardId)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I
		//IL_005a: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Func<_0021_00210, bool> func = default;
		object obj = func + 16;
		object obj2 = default;
		obj = obj2;
		return (byte)(int)Enumerable.SingleOrDefault<TSource>((IEnumerable<TSource>)(nint)((UnityEngine.Object)this).m_CachedPtr, (Func<TSource, bool>)(object)func) != 0;
	}

	private Boards.BoardId? EventBoard()
	{
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_0671: Expected Obj, but got I4
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_0016: Expected Obj, but got I
		//IL_06cc: Expected I, but got Obj
		//IL_06e2: Expected Obj, but got I
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_04d4: Expected Obj, but got I4
		//IL_01b8: Expected I, but got Obj
		//IL_0142: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_079d: Expected I, but got Obj
		//IL_07b3: Expected Obj, but got I
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_05bd: Expected Obj, but got I4
		//IL_04e7: Expected I, but got Obj
		//IL_02a1: Expected I, but got Obj
		//IL_02b7: Expected Obj, but got I
		//IL_0246: Expected I, but got Obj
		//IL_0888: Expected Obj, but got I
		//IL_08af: Expected Obj, but got I4
		//IL_08cd: Expected Obj, but got I
		//IL_0534: Expected I, but got Obj
		//IL_054a: Expected Obj, but got I
		//IL_028e: Expected Obj, but got I4
		//IL_05da: Expected Obj, but got I4
		//IL_05eb: Expected Obj, but got I
		//IL_0855: Expected Obj, but got I4
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected Obj, but got Unknown
		//IL_044b: Expected I, but got Obj
		//IL_0461: Expected Obj, but got I
		//IL_02e2: Expected I, but got Obj
		//IL_0575: Expected I, but got Obj
		//IL_081f: Expected Obj, but got I4
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected Obj, but got Unknown
		//IL_032f: Expected I, but got Obj
		//IL_0345: Expected Obj, but got I
		//IL_048c: Expected I, but got Obj
		//IL_0781: Expected Obj, but got I4
		//IL_0902: Expected Obj, but got I4
		//IL_0913: Expected Obj, but got I
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Expected VT, but got Unknown
		//IL_061a: Expected Obj, but got I4
		//IL_0370: Expected I, but got Obj
		//IL_03bd: Expected I, but got Obj
		//IL_03d3: Expected Obj, but got I
		//IL_0635: Expected VT, but got I4
		//IL_07ee: Expected Obj, but got I4
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Expected Obj, but got Unknown
		//IL_099a: Expected Obj, but got I4
		//IL_0643: Expected VT, but got I4
		//IL_03fe: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		object obj3 = this & 1;
		if ((object)this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+54]");
			string text = ((Component)0).tag;
			((GameObject)(object)text).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+50]");
			string text2 = ((Component)0).tag;
			((GameObject)(object)text2).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+44]");
			string text3 = ((Component)0).tag;
			((GameObject)(object)text3).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+48]");
			string text4 = ((Component)0).tag;
			((GameObject)(object)text4).tag = null;
			goto IL_0655;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+38]");
		obj2 = 0;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		bool flag = (nint)0 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E6C");
		object obj4 = default;
		bool flag2;
		if (obj4 != null)
		{
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v92 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v97 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+C]");
			if (!BoardManager.HasBoardBeenSeen(Boards.BoardId.normal))
			{
				flag2 = true;
				goto IL_06be;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+C]");
		flag2 = ((HoverboardOverlayHelper)null).IsBoardFree(Boards.BoardId.normal);
		goto IL_06be;
		IL_0655:
		Boards.BoardId? boardId = default;
		return boardId;
		IL_06be:
		nint num3 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v32 (Il2CppClass<Info.Boards>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v118 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Boards.BoardId, Boards.Board> boardData = Boards.boardData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+C]");
		Boards.Board board = boardData.get_Item(Boards.BoardId.normal);
		object obj8;
		if (~(board.isNewInThisUpdate ? 1u : 0u) == 0)
		{
			nint num5 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v73 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v114 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UserSave.lastPurchasedBundle != InAppData.BundleTier.None)
			{
				obj8 = 0;
			}
			else
			{
				nint num7 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v58 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num8 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S1_v83 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+C]");
				if (!BoardManager.IsBoardUnlocked(Boards.BoardId.normal))
				{
					goto IL_043d;
				}
				nint num9 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v92 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num10 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v109 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+C]");
				bool flag3 = BoardManager.AreAllNewThemesSeenForBoard(Boards.BoardId.normal);
				bool flag4 = !flag3;
				obj8 = 0;
				if (!flag4)
				{
					nint num11 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S0_v100 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num12 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v105 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+C]");
					bool flag5 = BoardManager.IsBoardActive(Boards.BoardId.normal);
					obj8 = 0;
					if (!flag5)
					{
						goto IL_043d;
					}
				}
			}
		}
		else
		{
			obj8 = 0;
		}
		goto IL_078f;
		IL_043d:
		nint num13 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S1_v65 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num14 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S1_v72 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+C]");
		bool flag6 = BoardManager.HasAllThemesBeenSeen(Boards.BoardId.normal);
		object obj13 = (flag6 ? 1 : 0) ^ 1;
		obj8 = obj13 & 1;
		goto IL_078f;
		IL_078f:
		nint num15 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v43 (Il2CppClass<Info.Boards>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num16 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v65 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Boards.BoardId, Boards.Board> boardData2 = Boards.boardData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+C]");
		Boards.Board board2 = boardData2.get_Item(Boards.BoardId.normal);
		object obj17;
		if (~(board2.hasOnlineTimeLimit ? 1u : 0u) == 0)
		{
			nint num17 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S1_v44 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num18 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S1_v51 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+C]");
			bool flag7 = BoardManager.HasBoardBeenSeen(Boards.BoardId.normal);
			object obj16 = (flag7 ? 1 : 0) ^ 1;
			obj17 = obj16 & 1;
		}
		else
		{
			obj17 = 0;
		}
		bool flag8 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+54]");
		string text5 = ((Component)0).tag;
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+C]");
		bool flag9 = obj18 == null;
		string text6 = (((GameObject)(object)text5).tag = (string)(flag9 & flag));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+50]");
		string text8 = ((Component)0).tag;
		((GameObject)(object)text8).tag = null;
		object obj19 = (flag2 ? 1 : 0) ^ 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+44]");
		string text9 = ((Component)0).tag;
		object obj20 = ((text6 == null) ? obj19 : ((object)0));
		object obj21 = obj8 & obj20;
		bool flag10 = obj21 != null;
		((GameObject)(object)text9).tag = (string)flag10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<Info.Boards+BoardId>)+48]");
		string text10 = ((Component)0).tag;
		Boards.BoardId? boardId2 = (Boards.BoardId?)(object)(obj8 ^ 1);
		bool flag11 = !flag8;
		bool flag12 = !flag11;
		boardId = boardId2;
		if (!flag12)
		{
			boardId = (Boards.BoardId?)(object)0;
		}
		Boards.BoardId? boardId3 = (Boards.BoardId?)((text6 == null) ? boardId : ((object)0));
		object obj22 = obj17 & (Nullable)boardId3;
		bool flag13 = obj22 != null;
		((GameObject)(object)text10).tag = (string)flag13;
		goto IL_0655;
	}

	public int GetIndex()
	{
		return (int)_cachedBoardId;
	}

	public Boards.BoardId GetBoardType()
	{
		return (Boards.BoardId)_placementIndex;
	}

	private void Update()
	{
		//IL_00fd: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!BoardManager.IsBoardUnlocked(_cachedBoardId))
		{
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v11 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v16 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BoardManager.boardUnlocked += (Action<Boards.BoardId>)_cachedBoardId;
		}
		Boards.BoardId? boardId = ((HoverboardOverlayHelper)1).EventBoard();
	}

	private void RefreshBottomIndicators()
	{
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_01b9: Expected Obj, but got I4
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_0154: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I4
		LateUpdate();
		string text = _limitedBubble.tag;
		if (((GameObject)(object)text).activeInHierarchy)
		{
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v22 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v29 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (BoardManager.HasBoardBeenSeen(_cachedBoardId))
			{
				string text2 = _limitedBubble.tag;
				((GameObject)(object)text2).tag = null;
			}
		}
		string text3 = _giftBubble.tag;
		if (!((GameObject)(object)text3).activeInHierarchy)
		{
			return;
		}
		string text4 = _giftBubble.tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E6C");
		object obj2 = default;
		string text5;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S2_v11 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S2_v16 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!BoardManager.HasBoardBeenSeen(_cachedBoardId))
			{
				text5 = (string)1;
				goto IL_01be;
			}
		}
		bool flag = ((HoverboardOverlayHelper)null).IsBoardFree(_cachedBoardId);
		text5 = (string)flag;
		goto IL_01be;
		IL_01be:
		((GameObject)(object)text4).tag = text5;
	}

	private void LateUpdate()
	{
		//IL_0189: Expected Obj, but got I4
		//IL_01ee: Expected I, but got Obj
		//IL_0204: Expected Obj, but got I
		//IL_000f: Expected Obj, but got VT
		//IL_0046: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		object obj = 0;
		bool flag3;
		if (~(_hasEventBeenTried ? 1u : 0u) == 0)
		{
			obj = _eventBoardId;
			bool flag = (nint)obj == (nint)_cachedBoardId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			bool flag2 = (nint)0 != 0;
			object obj2 = flag & flag2;
			if (obj2 != null)
			{
				Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
				flag3 = previousBoardId == _cachedBoardId;
			}
			else
			{
				flag3 = false;
			}
		}
		else
		{
			flag3 = false;
		}
		Boards.BoardId previousBoardId2 = PlayerSave.previousBoardId;
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v6 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v20 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = BoardManager.HasBoardBeenSeen(_cachedBoardId);
		string text = _trialSprite.tag;
		((GameObject)(object)text).tag = (string)flag3;
		string text2 = _selectedSprite.tag;
		bool flag5 = previousBoardId2 == _cachedBoardId;
		object obj4 = (flag3 ? 1 : 0) ^ 1;
		string text3 = (string)(flag5 & obj4);
		((GameObject)(object)text2).tag = text3;
		string text4 = _ownedSprite.tag;
		object obj5 = flag3 | flag5;
		object obj6 = obj5 ^ 1;
		string text5 = (string)(flag4 & obj6);
		((GameObject)(object)text4).tag = text5;
	}

	private bool IsBoardFree(Boards.BoardId boardId)
	{
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v36 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 > -1)
		{
			nint num4 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v21 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v30 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Boards.BoardId, List<HoverboardThemes.HoverboardTheme>> hoverboardCustomThemes = HoverboardThemes.hoverboardCustomThemes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			List<HoverboardThemes.HoverboardTheme> source = hoverboardCustomThemes.get_Item(Boards.BoardId.normal);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num6 = 0;
			_ = 0;
			Func<HoverboardThemes.HoverboardTheme, bool> func = default;
			object obj9 = func + 16;
			object obj10 = default;
			obj9 = obj10;
			return Enumerable.Any(source, func);
		}
		return false;
	}

	public unsafe HoverboardOverlayHelper()
	{
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected VT, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02bf: Expected Obj, but got I4
		//IL_002e: Expected VT, but got Obj
		//IL_0040: Expected F4, but got Obj
		//IL_003b: Expected native int or pointer, but got VT
		//IL_0052: Expected F4, but got I
		//IL_004d: Expected native int or pointer, but got VT
		//IL_0072: Expected F4, but got Obj
		//IL_006d: Expected native int or pointer, but got VT
		//IL_0087: Expected F4, but got I
		//IL_0082: Expected native int or pointer, but got VT
		//IL_00ac: Expected F4, but got Obj
		//IL_00a7: Expected native int or pointer, but got VT
		//IL_00c1: Expected F4, but got I
		//IL_00bc: Expected native int or pointer, but got VT
		//IL_00d2: Expected Ref, but got VT
		//IL_00f2: Expected I, but got Obj
		//IL_0108: Expected Obj, but got I
		//IL_031d: Expected VT, but got Obj
		//IL_0326: Expected Obj, but got I4
		//IL_0350: Expected F4, but got Obj
		//IL_034b: Expected native int or pointer, but got VT
		//IL_0365: Expected F4, but got I
		//IL_0360: Expected native int or pointer, but got VT
		//IL_036e: Expected Obj, but got VT
		//IL_01ab: Expected VT, but got Obj
		//IL_01b4: Expected Obj, but got I4
		//IL_01e6: Expected F4, but got Obj
		//IL_01e1: Expected native int or pointer, but got VT
		//IL_01fb: Expected F4, but got I
		//IL_01f6: Expected native int or pointer, but got VT
		//IL_0204: Expected Obj, but got VT
		//IL_0133: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 144);
		Transform transform = (Transform)(obj + 120);
		object obj2 = obj + 108;
		object obj3 = obj + 96;
		Transform transform2 = (Transform)(obj + 84);
		object obj4 = obj + 72;
		Transform transform3 = (Transform)(obj + 60);
		object obj5 = obj + 48;
		object obj6 = obj + 36;
		object obj7 = obj + 24;
		Transform transform4 = (Transform)(obj + 12);
		object obj8 = obj + 132;
		obj8 = 0;
		_ = 0;
		if (~(_dirtyDist ? 1u : 0u) != 0)
		{
			return;
		}
		_dirtyDist = false;
		Transform parentInternal = _cachedTransform.parentInternal;
		transform.position = (Vector3)_trackerTransform;
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = _3DClipCam.WorldToViewportPoint(vector);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector3 = _2DOverlayCam.ScreenToViewportPoint(vector);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Vector3*)(nint)vector)->z = 0f;
		transform2.Internal_LookAt_Injected(ref *(Vector3*)parentInternal, ref *(Vector3*)vector);
		obj8 = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S3_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S3_v13 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = Mathf.InverseLerp(_topOverlayMaxX, _topOverlayMinX, _currentDistFromCenter);
		obj4 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
		_ = 0;
		transform3.localPosition = (Vector3)_cachedTransform;
		obj5 = 0;
		_ = 0;
		obj5 = obj4;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
		obj6 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
		_ = 0;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
		_ = 0;
		transform4.localPosition = (Vector3)_cachedTransform;
		obj = 0;
		_ = 0;
		obj = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 eulerAngles2 = ((Transform)vector).eulerAngles;
	}
}
