using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using InApp;
using Info;
using UI.Generic;
using UI.Generic.Layout;
using UI.Popups.AgeRestrictionPopupInternal;
using UI.Popups.BoardBundlePopupInternal;
using UI.Screens;
using UI.Screens.PauseScreenInternal;
using UI.ScrollListSelectPopup;
using UI.SlideIns;
using UnityEngine;

namespace UI.Popups;

public class AgeRestrictionPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<ListContentElement> _003C_003E9__17_0;

		public static Predicate<ListContentElement> _003C_003E9__17_1;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			UISlideInCharacterEventRewardHelper._003C_003Ec obj = default;
			UISlideInCharacterEventRewardHelper._003C_003Ec._003C_003E9 = obj;
		}

		internal bool _003CInit_003Eb__17_0(ListContentElement entry)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
				if ((nint)0 == 1)
				{
					return true;
				}
				return false;
			}
			return false;
		}

		internal bool _003CInit_003Eb__17_1(ListContentElement entry)
		{
			return entry.content__BackingField != "----";
		}
	}

	private const int YEAR_START = 1900;

	private const int YEAR_END = 2018;

	private const int INITIAL_YEAR = 2000;

	private const string DEFAULT_VALUE_MONTH = "----";

	private const string DEFAULT_VALUE_YEAR = "----";

	private GameObject _ageCellPrefab;

	private ScrollView _listViewMonth;

	private ScrollView _listViewYear;

	private UIWidget _characterModelGuideWidget;

	private UIButtonOverlayOff _acceptButton;

	private UILabel _title;

	private UILabel _okLabel;

	private List<ListContentElement> _contentListMonth;

	private List<ListContentElement> _contentListYear;

	private CenterOnChild _centerOnChildMonth;

	private CenterOnChild _centerOnChildYear;

	private CharacterScreenController _character;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_00a5: Expected VT, but got Obj
		//IL_00a5: Expected VT, but got Obj
		//IL_00a5: Expected VT, but got Obj
		//IL_00b9: Expected I4, but got Obj
		//IL_00ee: Expected VT, but got Obj
		//IL_00ee: Expected VT, but got Obj
		//IL_00ee: Expected VT, but got Obj
		//IL_00fd: Expected I4, but got Obj
		//IL_011a: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I
		//IL_0577: Expected Obj, but got I
		//IL_0587: Expected Obj, but got I
		//IL_0597: Expected Obj, but got I
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected Obj, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected Obj, but got Unknown
		//IL_05d5: Expected I, but got Obj
		//IL_05eb: Expected Obj, but got I
		//IL_015b: Expected I, but got Obj
		//IL_01a8: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I
		//IL_061e: Expected Obj, but got I
		//IL_062e: Expected Obj, but got I
		//IL_063e: Expected Obj, but got I
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected Obj, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_067d: Expected Obj, but got I4
		//IL_0696: Expected Obj, but got I4
		//IL_0236: Expected I, but got Obj
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_0461: Expected I, but got Obj
		//IL_0477: Expected Obj, but got I
		//IL_031c: Expected I, but got Obj
		//IL_0332: Expected Obj, but got I
		//IL_0283: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_01e9: Expected I, but got Obj
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected Obj, but got Unknown
		//IL_04fb: Expected I, but got Obj
		//IL_0511: Expected Obj, but got I
		//IL_035d: Expected I, but got Obj
		//IL_02c4: Expected I, but got Obj
		ShowIfInactive();
		object obj = this + 68;
		List<ListContentElement> list = ((AgeRestrictionPopup)null).CreateContentListYear();
		obj = list;
		object obj2 = this + 72;
		IEnumerator enumerator = ((CloudSaveCelebrationPopup)null).AnimateRoutine();
		obj2 = enumerator;
		object obj3 = this + 76;
		string text = _listViewMonth.tag;
		CenterOnChild centerOnChild = ((GameObject)(object)text).AddComponent<CenterOnChild>();
		obj3 = centerOnChild;
		object obj4 = this + 80;
		string text2 = _listViewYear.tag;
		CenterOnChild centerOnChild2 = ((GameObject)(object)text2).AddComponent<CenterOnChild>();
		obj4 = centerOnChild2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterNameEventPopup characterNameEventPopup = default;
		characterNameEventPopup.PositionModelOnSprite((UISprite)(object)_contentListMonth, _ageCellPrefab, (Vector3)_listViewMonth, (Vector3)_centerOnChildMonth, (Vector3)"----");
		_listViewMonth.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)characterNameEventPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterNameEventPopup characterNameEventPopup2 = default;
		characterNameEventPopup2.PositionModelOnSprite((UISprite)(object)_contentListYear, _ageCellPrefab, (Vector3)_listViewYear, (Vector3)_centerOnChildYear, (Vector3)"----");
		_listViewYear.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)characterNameEventPopup2);
		List<ListContentElement> contentListMonth = _contentListMonth;
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v21 (Il2CppClass<UI.Popups.AgeRestrictionPopup+<>c>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v120 (Il2CppClass<UI.Popups.AgeRestrictionPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__17_0 == null;
		bool flag2 = !flag;
		Predicate<ListContentElement> predicate = _003C_003Ec._003C_003E9__17_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v94 (Il2CppClass<UI.Popups.AgeRestrictionPopup+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v114 (Il2CppClass<UI.Popups.AgeRestrictionPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Predicate<ListContentElement> predicate2 = default;
			object obj7 = predicate2 + 16;
			obj7 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v111 (Il2CppClass<UI.Popups.AgeRestrictionPopup+<>c>)+5C]");
			object obj8 = (nint)0 + (nint)4;
			obj8 = predicate2;
			predicate = predicate2;
		}
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S4_v4 (Il2CppMethodInfo)+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S4_v5+60]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S4_v6+78]");
		object obj11 = 0;
		object obj12 = obj11 & 0x7FF;
		object obj13 = obj12 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v163 @ S5_v6 (should have been resolved before IL gen)");
		List<ListContentElement> contentListYear = _contentListYear;
		nint num8 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v35 (Il2CppClass<UI.Popups.AgeRestrictionPopup+<>c>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num9 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v87 (Il2CppClass<UI.Popups.AgeRestrictionPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = _003C_003Ec._003C_003E9__17_1 == null;
		bool flag4 = !flag3;
		Predicate<ListContentElement> predicate3 = _003C_003Ec._003C_003E9__17_1;
		if (!flag4)
		{
			nint num10 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v61 (Il2CppClass<UI.Popups.AgeRestrictionPopup+<>c>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num11 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v81 (Il2CppClass<UI.Popups.AgeRestrictionPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num12 = 0;
			_ = 0;
			Predicate<ListContentElement> predicate4 = default;
			object obj16 = predicate4 + 16;
			obj16 = _003C_003Ec._003C_003E9;
			nint num13 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v78 (Il2CppClass<UI.Popups.AgeRestrictionPopup+<>c>)+5C]");
			object obj17 = (nint)0 + (nint)8;
			obj17 = predicate4;
			predicate3 = predicate4;
		}
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S4_v9 (Il2CppMethodInfo)+C]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S4_v10+60]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S4_v11+78]");
		object obj20 = 0;
		object obj21 = obj20 & 0x7FF;
		object obj22 = obj21 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v261 @ S5_v10 (should have been resolved before IL gen)");
		Vector3 localOffset = default;
		_listViewMonth.SmoothScrollToOffset(localOffset, (Action)1, 0f);
		Vector3 localOffset2 = default;
		_listViewYear.SmoothScrollToOffset(localOffset2, (Action)1, 0f);
		_centerOnChildMonth.CharacterFocusedFromClick();
		_centerOnChildYear.CharacterFocusedFromClick();
		nint num15 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S1_v54 (Il2CppClass<Strings>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num16 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S1_v66 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool fontSize = Strings.IsMapped("AgeRestrictionTitle");
		_title.fontSize = (fontSize ? 1 : 0);
		object obj24 = this - -64;
		bool fontSize2 = Strings.IsMapped("AgeRestrictionOk");
		((UILabel)obj24).fontSize = (fontSize2 ? 1 : 0);
		this._002Ector();
	}

	public unsafe override void Hide()
	{
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_0215: Expected Obj, but got I4
		//IL_014d: Expected I, but got Obj
		base.Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(AgeRestrictionPopup.OnSelectionChanged);
		object obj = action + 16;
		obj = this;
		_centerOnChildMonth.selectedObjectChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(AgeRestrictionPopup.OnSelectionChanged);
		object obj2 = action2 + 16;
		obj2 = this;
		_centerOnChildMonth.selectedObjectReselected -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(AgeRestrictionPopup.OnSelectionChanged);
		object obj3 = action3 + 16;
		obj3 = this;
		_centerOnChildYear.selectedObjectChanged -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr4;
		((Delegate)action4).method = (nint)__ldftn(AgeRestrictionPopup.OnSelectionChanged);
		object obj4 = action4 + 16;
		obj4 = this;
		_centerOnChildYear.selectedObjectReselected -= action4;
		nint num = (nint)typeof(CharacterModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v15 (Il2CppClass<CharacterModelPreviewFactory>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(CharacterModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v21 (Il2CppClass<CharacterModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardScreenManager instance = BoardScreenManager.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		bool flag = default;
		object obj6 = (flag ? 1 : 0) + 16;
		obj6 = this;
		((HoverboardBundle)(object)instance).AddCustomSetModelAndEffect(0, false, flag);
	}

	public unsafe override void LoseFocus()
	{
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_0135: Expected I, but got Obj
		//IL_0191: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I
		//IL_01d2: Expected I, but got Obj
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(AgeRestrictionPopup.OnSelectionChanged);
		object obj = action + 16;
		obj = this;
		_centerOnChildMonth.selectedObjectReselected += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		GameObject gameObject = default;
		((UnityEngine.Object)gameObject).m_CachedPtr = cachedPtr;
		_ = 0;
		object obj2 = gameObject + 16;
		obj2 = this;
		_centerOnChildMonth.selectedObject = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(AgeRestrictionPopup.OnSelectionChanged);
		object obj3 = action2 + 16;
		obj3 = this;
		_centerOnChildYear.selectedObjectReselected += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr2 = 0;
		GameObject gameObject2 = default;
		((UnityEngine.Object)gameObject2).m_CachedPtr = cachedPtr2;
		_ = 0;
		object obj4 = gameObject2 + 16;
		obj4 = this;
		_centerOnChildYear.selectedObject = gameObject2;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_character).FindKernel((string)null) == 0)
		{
			return;
		}
		string obj6 = _character.tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj6);
	}

	public override void GainFocus()
	{
		string text = _character.tag;
		((GameObject)(object)text).tag = null;
	}

	public void AcceptClicked()
	{
		//IL_001d: Expected Obj, but got I4
		string text = _character.tag;
		((GameObject)(object)text).tag = (string)1;
		_character.SetFreeze(0f);
	}

	public unsafe void MonthArrowUpClicked()
	{
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_040a: Expected Obj, but got I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0421: Expected Obj, but got I4
		//IL_023f: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I
		//IL_0036: Expected I, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_04bf: Expected I, but got Obj
		//IL_04d5: Expected Obj, but got I
		//IL_0364: Expected I, but got Obj
		//IL_037a: Expected Obj, but got I
		//IL_0280: Expected I, but got Obj
		//IL_0509: Expected Obj, but got I4
		//IL_0517: Expected I, but got Obj
		//IL_052d: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		//IL_060a: Expected Obj, but got I4
		//IL_0617: Expected Obj, but got I4
		//IL_02cd: Expected I, but got Obj
		//IL_02e3: Expected Obj, but got I
		//IL_055b: Expected Obj, but got I8
		//IL_00c4: Expected I, but got Obj
		//IL_03a5: Expected I, but got Obj
		//IL_05ee: Expected Obj, but got I4
		//IL_015d: Expected I4, but got Obj
		//IL_0111: Expected I, but got Obj
		//IL_030e: Expected I, but got Obj
		//IL_017d: Expected Obj, but got I8
		//IL_0582: Expected I, but got Obj
		//IL_0598: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I4
		//IL_01e2: Expected I, but got Obj
		object obj = default;
		string text = (string)(obj + 24);
		object obj2 = obj + 16;
		obj2 = 0;
		object obj3 = obj + 8;
		obj3 = 0;
		CenterOnChild centerOnChildYear = _centerOnChildYear;
		ListElementHelper component = centerOnChildYear._selectedObject.GetComponent<ListElementHelper>();
		ListContentElement listContentElement = component._listContentElement;
		CenterOnChild centerOnChildMonth = _centerOnChildMonth;
		ListElementHelper component2 = centerOnChildMonth._selectedObject.GetComponent<ListElementHelper>();
		ListContentElement listContentElement2 = component2._listContentElement;
		if (TryParseDateTime(0, listContentElement.value__BackingField, out *(DateTime*)listContentElement2.value__BackingField))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v49 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v101 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = obj2;
			text = (string)obj;
			AgeRestriction.Log(text);
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v57 (Il2CppClass<UIScreenController>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v97 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).ClosePopup((GameObject)(object)"AgeRestrictionPopup");
			nint num5 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v64 (Il2CppClass<System.DateTime>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v93 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
			obj3 = systemTimeAsFileTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
			object obj7 = default;
			object obj8 = default;
			bool flag2 = (byte)(obj7 - obj8) != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC8");
			long systemTimeAsFileTime2 = DateTime.GetSystemTimeAsFileTime();
			obj3 = systemTimeAsFileTime2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC8");
			object obj9 = default;
			object obj10 = default;
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10);
			bool flag4 = !flag3;
			bool consent = flag2;
			if (!flag4)
			{
				bool flag5 = (byte)((flag2 ? 1u : 0u) - 1u) != 0;
				consent = flag5;
			}
			nint num7 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v77 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v85 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AgeRestriction.shouldSendAgeEvent = false;
			bool isInitialized = AdSystemManager.isInitialized;
			((PokiUnitySDK)isInitialized).togglePlayerAdvertisingConsent(consent);
		}
		else
		{
			((AgeRestrictionPopup)(object)"Input is invalid")._003CShow_003Eb__18_0((CharacterScreenController)null);
		}
		nint num9 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v18 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num10 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v39 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (AgeRestriction.countryCodeRestricted)
		{
			nint num11 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v29 (Il2CppClass<UIScreenController>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num12 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v35 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag6 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag6).QueuePopup("ConsentPopup");
			return;
		}
		bool isInitialized2 = AdSystemManager.isInitialized;
		nint num13 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v18 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num14 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v25 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool waitForAgeRestriction = AgeRestriction.waitForAgeRestriction;
		PokiUnitySDK.LoadingProgressData data = (PokiUnitySDK.LoadingProgressData)((waitForAgeRestriction ? 1 : 0) ^ 1);
		((PokiUnitySDK)isInitialized2).gameLoadingProgress(data);
	}

	public void MonthArrowDownClicked()
	{
		//IL_001c: Expected I4, but got Obj
		//IL_001c: Expected Obj, but got I4
		((BoardBundlePopup)1).SetupBundle((BoardBundleItem)(object)_centerOnChildMonth, (Boards.BoardId)_contentListMonth, (InAppItemModel)(object)_listViewMonth);
	}

	public void YearArrowUpClicked()
	{
		//IL_0018: Expected I4, but got Obj
		((BoardBundlePopup)null).SetupBundle((BoardBundleItem)(object)_centerOnChildMonth, (Boards.BoardId)_contentListMonth, (InAppItemModel)(object)_listViewMonth);
	}

	public void YearArrowDownClicked()
	{
		//IL_001c: Expected I4, but got Obj
		//IL_001c: Expected Obj, but got I4
		((BoardBundlePopup)1).SetupBundle((BoardBundleItem)(object)_centerOnChildYear, (Boards.BoardId)_contentListYear, (InAppItemModel)(object)_listViewYear);
	}

	private unsafe static void ArrowClicked(bool up, CenterOnChild centerer, List<ListContentElement> content, ScrollView listView)
	{
		//IL_01b1: Expected Obj, but got Ref
		//IL_01ce: Expected Obj, but got I4
		//IL_01eb: Expected I4, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I
		//IL_0219: Expected I4, but got Obj
		//IL_0219: Expected Obj, but got I
		//IL_001e: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_0241: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I
		//IL_027d: Expected F4, but got Obj
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_02b1: Expected I4, but got Obj
		//IL_02b1: Expected Obj, but got I
		//IL_00cf: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_019d: Expected Obj, but got I
		//IL_011c: Expected I, but got Obj
		ref string reference = default;
		Transform transform = (Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 12));
		reference = ref *(string*)null;
		_ = 0;
		object obj = (up ? 1 : 0) + 28;
		obj = listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [up @ L0 (System.Boolean)+C]");
		((UILabel)0).fontSize = (int)centerer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [up @ L0 (System.Boolean)+1C]");
		string text = string.Format((string)(object)content, (object[])0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [up @ L0 (System.Boolean)+10]");
		((UILabel)0).fontSize = (int)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [up @ L0 (System.Boolean)+10]");
		if (!((UILabel)0).Wrap((string)(object)listView, out reference))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [up @ L0 (System.Boolean)+14]");
		GameObject gameObject = ((Component)0).gameObject;
		transform = (Transform)(object)reference;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (System.String&)+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform.localPosition;
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S2_v15 (Il2CppClass<NGUIText>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S2_v29 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform go = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [up @ L0 (System.Boolean)+1C]");
		NGUITools.AddWidgetCollider((GameObject)(object)go, considerInactive: false);
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S3_v7 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S3_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption = GUILayout.Width((float)transform);
		UIWidget uIWidget = (UIWidget)(gUILayoutOption + 6);
		Color color = uIWidget.color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [up @ L0 (System.Boolean)+14]");
		((UIWidget)0).height = (int)uIWidget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [up @ L0 (System.Boolean)+14]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v26+64]");
		Color color2 = ((UIWidget)0).color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [up @ L0 (System.Boolean)+18]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v26+64]");
		((UIWidget)num5).height = 0;
	}

	private List<ListContentElement> CreateContentListMonth()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_026f: Expected Obj, but got I4
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
		}
		object obj8 = obj5 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj5 + obj10;
		obj11 = 75;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj5 + obj12;
			if ((nint)obj13 == 75)
			{
				object obj14 = obj5 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0336;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0336;
		IL_0336:
		return (List<ListContentElement>)(object)list;
	}

	private List<ListContentElement> CreateContentListYear()
	{
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_02e0: Expected I, but got Obj
		//IL_02f6: Expected Obj, but got I
		//IL_025e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_01ae: Expected Obj, but got I4
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		//IL_01ed: Expected Obj, but got I4
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v65 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIKeyBinding.Modifier activeModifier = UIKeyBinding.GetActiveModifier();
		nint num3 = (nint)typeof(DateTimeFormatInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DateTimeFormatInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v61 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = ((DateTimeFormatInfo)activeModifier).Clone();
		string[] monthNames = ((DateTimeFormatInfo)obj3).MonthNames;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		int capacity = monthNames.Length + 1;
		List<ListContentElement> list = default;
		list._002Ector(capacity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ListContentElement listContentElement = default;
		object obj4 = listContentElement + 8;
		obj4 = "----";
		listContentElement.value__BackingField = int.MinValue;
		list.Add(listContentElement);
		string[] monthNames2 = ((DateTimeFormatInfo)obj3).MonthNames;
		object obj5 = monthNames2 + 12;
		object obj6 = default;
		TextInfo textInfo = default;
		ListContentElement listContentElement2 = default;
		object obj11 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			object obj7 = monthNames2 + 16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			string text = (string)obj9;
			if (obj9 != null && text.m_stringLength != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				string str = ((string)obj9).ToUpper((CultureInfo)activeModifier);
				int caseInsensitiveHashCode = textInfo.GetCaseInsensitiveHashCode(str);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj10 = listContentElement2 + 8;
				obj10 = caseInsensitiveHashCode;
				listContentElement2.value__BackingField = 1;
				list.Add(listContentElement2);
			}
			obj6 = obj11 + 1;
		}
		return list;
	}

	private void OnSelectionChanged()
	{
		//IL_0018: Expected I4, but got Obj
		((BoardBundlePopup)null).SetupBundle((BoardBundleItem)(object)_centerOnChildYear, (Boards.BoardId)_contentListYear, (InAppItemModel)(object)_listViewYear);
	}

	private bool IsValidDateTime(int year, int month)
	{
		//IL_0033: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_0045: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
		dailyChallengeRewardHelper.Refresh();
		((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)16;
		dailyChallengeRewardHelper._checkmark = (UISprite)year;
		dailyChallengeRewardHelper._rewardLayout = (Layout)month;
		return (byte)(int)dailyChallengeRewardHelper != 0;
	}

	private unsafe static bool TryParseDateTime(int year, int month, out DateTime dt)
	{
		//IL_001f: Expected Obj, but got Ref
		//IL_001f: Expected Obj, but got I4
		//IL_0023: Expected I4, but got Obj
		int num = default;
		((int*)num)->m_value = 0;
		return (byte)(int)PlaceModelUnderAnchor((GameObject)month, (Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref dt), num) != 0;
	}

	private void SetAcceptButtonActive(bool active)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0207: Expected Obj, but got I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_02c6: Expected Obj, but got I4
		//IL_02d8: Expected Obj, but got I4
		//IL_02ee: Expected Obj, but got I
		//IL_02fe: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00d3: Expected Obj, but got I4
		//IL_015b: Expected Obj, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if ((object)_centerOnChildMonth == null)
		{
			Dictionary<string, string>.KeyCollection keys = ((Dictionary<string, string>)(object)_contentListMonth).Keys;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @821F");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 73;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 73)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					goto IL_02b7;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_02b7;
		IL_02b7:
		bool flag = ((Dictionary<string, bool>)(object)_contentListYear).get_Item((string)active);
		object obj15 = (flag ? 1 : 0) ^ 1;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S4_v5 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S4_v6+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S4_v7+48]");
		object obj18 = 0;
		object obj19 = obj18 & 0x7FF;
		object obj20 = obj19 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v113 @ S5_v4 (should have been resolved before IL gen)");
	}

	private static GameObject PlaceModelUnderAnchor(GameObject model, Transform anchor, int layer)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_018e: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = anchor;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format = default;
		object arg = default;
		string text = string.Format((IFormatProvider)(object)"{0:0000}{1:00}", format, arg);
		nint num = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v10 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v28 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v17 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v24 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (GameObject)(object)((System.DefaultBinder)(object)text).BindToField((BindingFlags)"yyyyMM", (FieldInfo[])(object)currentCulture, (object)null, (CultureInfo)layer);
	}

	private static void PositionModelOnSprite(UIWidget tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got I4
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02c2: Expected Obj, but got I4
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_030a: Expected Obj, but got VT
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected F4, but got Unknown
		//IL_0345: Expected Obj, but got I
		//IL_0355: Expected Obj, but got I
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_03ce: Invalid comparison between VT and I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_00d9: Expected Obj, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		object obj6 = tracker + 68;
		obj6 = objectToPosition;
		object obj7 = tracker + 80;
		obj7 = positionOffset;
		float finalAlpha = newScale & 1;
		tracker.finalAlpha = finalAlpha;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S3_v3+60]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj11 = obj10 & 0x1FFF;
		object obj12 = obj11 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v78 @ S4_v4 (should have been resolved before IL gen)");
		object obj13 = tracker + 72;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		bool flag = newRotation == (Vector3)(object)0;
		object obj15 = default;
		object obj16 = default;
		object obj23 = default;
		object obj24 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj17;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj16 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
						obj17 = 0;
						goto IL_00de;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				obj17 = 0;
				goto IL_00de;
			}
			object obj18 = obj5 + 4;
			object obj19 = obj18 + 1;
			obj18 = obj19;
			object obj20 = obj19 << 2;
			object obj21 = obj5 + obj20;
			obj21 = 133;
			break;
			IL_00de:
			object obj22 = obj17 & 1;
			if (obj22 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj23 == obj24)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				break;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj25 = (nint)0 << 2;
			object obj26 = obj5 + obj25;
			if ((nint)obj26 == 133)
			{
				object obj27 = obj5 + 4;
				if ((nint)obj27 > -1)
				{
					object obj28 = obj27 + -1;
					obj27 = obj28;
				}
				goto IL_0412;
			}
		}
		object obj29 = default;
		if (obj29 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0412;
		IL_0412:
		((UI.ScrollListSelectPopup.ScrollListSelectPopup)(object)tracker)._002Ector();
	}

	private static void LogErr(string msg, UnityEngine.Object obj = null)
	{
		//IL_002c: Expected Obj, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I
		if ((object)obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+38]");
			((UIButtonOverlayOff)0).GoToNotAvailableState();
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+38]");
			((UIButtonOverlayOff)0).GoToSelectedState();
		}
		object obj2 = msg - -64;
		ButtonText component = ((Component)obj2).GetComponent<ButtonText>();
		component._002Ector();
	}

	public unsafe AgeRestrictionPopup()
	{
		//IL_000f: Expected Obj, but got I4
		CenterOnChild centerOnChildYear = _centerOnChildYear;
		ListElementHelper component = centerOnChildYear._selectedObject.GetComponent<ListElementHelper>();
		ListContentElement listContentElement = component._listContentElement;
		CenterOnChild centerOnChildMonth = _centerOnChildMonth;
		ListElementHelper component2 = centerOnChildMonth._selectedObject.GetComponent<ListElementHelper>();
		ListContentElement listContentElement2 = component2._listContentElement;
		bool flag = TryParseDateTime(0, listContentElement.value__BackingField, out *(DateTime*)listContentElement2.value__BackingField);
		LogErr((string)(object)this, (UnityEngine.Object)flag);
	}

	private void _003CShow_003Eb__18_0(CharacterScreenController csc)
	{
		//IL_0010: Expected I4, but got Obj
		string msg = string.ConcatArray((string[])(object)"[AgeRestrictionPopup] ", (int)this);
		SDebug.LogFormat(msg, (object[])(object)csc);
	}
}
