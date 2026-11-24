using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Missions;
using UnityEngine;

public class AwardFinishedCellHelper : MonoBehaviour
{
	private const string AWARD_COMPLETE_DESCRIPTION_HEX_COLOR = "[549133]";

	private const string AWARD_COMPLETE_VALUE_HEX_COLOR = "[015A01]";

	private const string END_COLOR_SYMBOL = "[-]";

	private static readonly Color32 COMPLETED_TITLE_TEXT_COLOR;

	private static readonly Color32 COMPLETED_TITLE_TEXT_SHADOW_COLOR;

	private static readonly Color32 COMPLETE_SEGMENT_BACKGROUND_COLOR;

	private UILabel _missionTitle;

	private UILabel _missionTextDescription;

	private GameObject _missionIconsDescriptionParent;

	private UISprite _cellBackground;

	private AwardCollectibleHelper _mainGoalElementsHelper;

	private UISprite _mysteryBoxIcon;

	private AwardCollectibleHelper[] _goalIcons;

	private string[] _mysteryBoxIconNames;

	private const string COMPLETED_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_bg_completed_small";

	private const string COMPLETED_GOAL_ICON_BACKGROUND_SPRITE_NAME = "icon_award_bg_completed";

	private Award _currentAward;

	public unsafe void InitCell(Award award)
	{
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected VT, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00d5: Expected F4, but got Obj
		//IL_00d0: Expected native int or pointer, but got VT
		//IL_016c: Expected F4, but got Obj
		//IL_0167: Expected native int or pointer, but got VT
		//IL_0181: Expected F4, but got I
		//IL_017c: Expected native int or pointer, but got VT
		//IL_0190: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0138: Expected Obj, but got VT
		//IL_014d: Expected F4, but got Obj
		//IL_0148: Expected native int or pointer, but got VT
		//IL_0054: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 32);
		object obj2 = obj + 16;
		object obj3 = obj + 24;
		object obj4 = obj + 20;
		if (award != null)
		{
			nint num = (nint)typeof(AwardCollectibleHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v22 (Il2CppClass<AwardCollectibleHelper>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(AwardCollectibleHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v29 (Il2CppClass<AwardCollectibleHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = AwardCollectibleHelper.SOCIAL_LOCK_CAN_COLOR;
			obj3 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		}
		else
		{
			obj2 = 0;
			obj2 = 0;
			obj2 = -1;
			_ = -1;
			_ = -1;
			_ = -1;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		}
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_missionTitle.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	private void SetupCellStructure()
	{
		CancelInvoke();
	}

	private void SetupCellContent()
	{
		//IL_004a: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		string text = _missionTextDescription.tag;
		Award currentAward = _currentAward;
		AwardStaticData awardData = currentAward._awardData;
		bool flag = awardData.hasDescription__BackingField;
		((GameObject)(object)text).tag = (string)flag;
		Award currentAward2 = _currentAward;
		AwardStaticData awardData2 = currentAward2._awardData;
		bool flag2 = awardData2.hasDescription__BackingField;
		string text2 = (string)((flag2 ? 1 : 0) ^ 1);
		_missionIconsDescriptionParent.tag = text2;
	}

	private void SetupCellColors()
	{
		//IL_04ee: Expected I, but got Obj
		//IL_0504: Expected Obj, but got I
		//IL_05ab: Expected I4, but got Obj
		//IL_05b6: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_009a: Expected I4, but got Obj
		//IL_003c: Expected I, but got Obj
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_0321: Expected Obj, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_03ad: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got I
		//IL_03ad: Expected I4, but got Obj
		//IL_052f: Expected I, but got Obj
		//IL_0545: Expected Obj, but got I
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_0430: Expected I4, but got Obj
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		//IL_0498: Expected I4, but got Obj
		//IL_019e: Expected I, but got Obj
		Award currentAward = _currentAward;
		AwardGoal[] array;
		if (currentAward._awardActiveTier != null)
		{
			AwardTier awardActiveTier = currentAward._awardActiveTier;
			array = awardActiveTier.listGoals__BackingField;
		}
		else
		{
			array = null;
		}
		Award currentAward2 = _currentAward;
		AwardStaticData awardData = currentAward2._awardData;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v2 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v29 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(awardData.title__BackingField);
		_missionTitle.fontSize = (int)text;
		IEnumerator enumerator = ((AwardStarHandler)null).AnimateStar((Animation)1);
		((FacebookGiftButton)(object)_mainGoalElementsHelper).Init((int)enumerator, "icon_diamond_can", (string)1, (Action)1, (UIScrollView)null);
		Award currentAward3 = _currentAward;
		AwardStaticData awardData2 = currentAward3._awardData;
		string key;
		if (~(awardData2.hasDescription__BackingField ? 1u : 0u) == 0)
		{
			Award currentAward4 = _currentAward;
			AwardStaticData awardData3 = currentAward4._awardData;
			if (~(awardData3.hasAnotherDescriptionForOneItemGoal__BackingField ? 1u : 0u) == 0)
			{
				object obj2 = array + 16;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v88+8]");
				if ((nint)0 == 1)
				{
					Award currentAward5 = _currentAward;
					AwardStaticData awardData4 = currentAward5._awardData;
					key = awardData4.descriptionForOneItemGoal__BackingField;
					goto IL_0521;
				}
			}
			Award currentAward6 = _currentAward;
			AwardStaticData awardData5 = currentAward6._awardData;
			key = awardData5.description__BackingField;
			goto IL_0521;
		}
		object obj4 = array + 12;
		object obj5 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			object obj6 = _goalIcons + 16;
			object obj7 = obj5 << 2;
			object obj8 = obj6 + obj7;
			IEnumerator enumerator2 = ((AwardStarHandler)null).AnimateStar((Animation)null);
			object obj9 = array + 16;
			object obj10 = obj5 << 2;
			object obj11 = obj9 + obj10;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S2_v22+10]");
			((FacebookGiftButton)obj8).Init((int)enumerator2, (string)0, (string)null, (Action)1, (UIScrollView)null);
			object obj13 = obj5 + 1;
			obj5 = obj13;
		}
		Award currentAward7 = _currentAward;
		AwardStaticData awardData6 = currentAward7._awardData;
		if (awardData6.id__BackingField == AwardId.COLLECT_OLD_TROPHY_ITEMS_MB)
		{
			object obj14 = _mysteryBoxIconNames + 16;
			_mysteryBoxIcon.fillCenter = (byte)(int)obj14 != 0;
			return;
		}
		Award currentAward8 = _currentAward;
		AwardStaticData awardData7 = currentAward8._awardData;
		if (awardData7.id__BackingField == AwardId.COLLECT_OLD_TROPHY_ITEMS_SMB)
		{
			object obj15 = _mysteryBoxIconNames + 20;
			_mysteryBoxIcon.fillCenter = (byte)(int)obj15 != 0;
		}
		return;
		IL_0521:
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v34 (Il2CppClass<Strings>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v81 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault(key);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private string FindBackgroundToUse(bool mainGoalIcon)
	{
		//IL_001f: Expected Obj, but got I4
		int pendingTopRunBeatenFriendsAward = TopRunSave.pendingTopRunBeatenFriendsAward;
		bool flag = pendingTopRunBeatenFriendsAward >= (mainGoalIcon ? 1 : 0);
		return (string)flag;
	}

	public unsafe AwardFinishedCellHelper()
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected I4, but got Unknown
		//IL_0121: Expected I4, but got Obj
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got VT
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01b8: Expected I4, but got Obj
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01cf: Expected VT, but got I4
		//IL_01e0: Expected I4, but got Obj
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0213: Expected Obj, but got VT
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_0236: Expected I4, but got Obj
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_024d: Expected VT, but got I4
		//IL_005f: Expected I4, but got Obj
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got VT
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00b5: Expected I4, but got Obj
		//IL_00be: Expected VT, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00d4: Expected I4, but got Obj
		//IL_00ea: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 72;
		Color black = Color.black;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 96);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4+8]");
		_ = 0;
		_missionTextDescription.rawPivot = pivot;
		nint num = (nint)typeof(AwardFinishedCellHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v10 (Il2CppClass<AwardFinishedCellHelper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(AwardFinishedCellHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v43 (Il2CppClass<AwardFinishedCellHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 - -64;
		obj4 = COMPLETE_SEGMENT_BACKGROUND_COLOR;
		object obj5 = obj2 + 88;
		obj5 = obj4;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		object obj6 = obj2 + 48;
		Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v20+8]");
		_ = 0;
		_cellBackground.rawPivot = pivot;
		object obj7 = obj2 + 40;
		obj7 = COMPLETED_TITLE_TEXT_COLOR;
		object obj8 = obj2 + 68;
		obj8 = obj7;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		object obj9 = obj2 + 24;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v30+8]");
		_ = 0;
		_missionTitle.rawPivot = pivot;
		object obj10 = obj2 + 16;
		obj10 = COMPLETED_TITLE_TEXT_SHADOW_COLOR;
		object obj11 = obj2 + 44;
		obj11 = obj10;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj11;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse((Matrix4x4)pivot);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
	}

	static AwardFinishedCellHelper()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0067: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		obj = 0;
		obj = 111;
		_ = 111;
		_ = 111;
		_ = -1;
		obj2 = obj;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		AwardCollectibleHelper.SOCIAL_LOCK_CAN_COLOR = (Color32)obj3;
	}
}
