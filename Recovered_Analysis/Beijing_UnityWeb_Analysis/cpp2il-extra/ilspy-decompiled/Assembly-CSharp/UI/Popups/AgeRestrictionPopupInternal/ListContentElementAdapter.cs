using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Ionic.Crc;
using Kiloo.Common.UI;
using UnityEngine;

namespace UI.Popups.AgeRestrictionPopupInternal;

public class ListContentElementAdapter : ListAdapter<ListContentElement>
{
	private readonly GameObject _ageCellPrefab;

	private readonly ScrollView _scrollView;

	private readonly CenterOnChild _centerOnChild;

	private readonly string _initialContent;

	public unsafe ListContentElementAdapter(List<ListContentElement> list, GameObject ageCell, ScrollView scrollView, CenterOnChild centerOnChild, string initialContent)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0191: Expected Obj, but got VT
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected VT, but got Unknown
		//IL_01c2: Expected F4, but got Obj
		//IL_01bd: Expected native int or pointer, but got VT
		//IL_01dc: Expected F4, but got Obj
		//IL_01d7: Expected native int or pointer, but got VT
		//IL_01f1: Expected F4, but got I
		//IL_01ec: Expected native int or pointer, but got VT
		//IL_0206: Expected I4, but got VT
		//IL_0206: Expected Obj, but got I
		//IL_0214: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I
		//IL_0117: Expected I4, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0175: Expected I4, but got Obj
		//IL_0175: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj = this + 48;
		obj = list;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v6 (Il2CppClass<GlobalColors>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v41 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 20;
		obj3 = GlobalColors.SOCIAL_GREY;
		object obj5 = obj4 + 16;
		obj5 = obj3;
		Matrix4x4 matrix4x = (Matrix4x4)(obj4 + 24);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.AgeRestrictionPopupInternal.ListContentElementAdapter)+20]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v21 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v37 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SOCIAL_BUTTON_FEEDBACK_CONNECTING");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.AgeRestrictionPopupInternal.ListContentElementAdapter)+24]");
		((UILabel)0).fontSize = (int)text;
		object obj7 = this + 52;
		obj7 = initialContent;
		object obj8 = ageCell & 1;
		object obj9 = scrollView & 1;
		object obj10 = centerOnChild & 1;
		((GameOverLeaderboardHandler)(object)this).SetOnlineContentListForLeaderboard((byte)(int)ageCell != 0, (Friend[])(object)scrollView, (byte)(int)centerOnChild != 0);
	}

	public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false)
	{
		//IL_0150: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected I4, but got Unknown
		nint num = (nint)typeof(CrcCalculatorStream);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<Ionic.Crc.CrcCalculatorStream>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CrcCalculatorStream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v34 (Il2CppClass<Ionic.Crc.CrcCalculatorStream>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.AgeRestrictionPopupInternal.ListContentElementAdapter)+20]");
		if (0 == CrcCalculatorStream.UnsetLengthLimit)
		{
			goto IL_00e4;
		}
		CenterOnChild centerOnChild = _centerOnChild;
		Action selectedObjectReselected = centerOnChild.selectedObjectReselected;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.AgeRestrictionPopupInternal.ListContentElementAdapter)+20]");
		if ((nint)selectedObjectReselected < 0)
		{
			CenterOnChild centerOnChild2 = _centerOnChild;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.AgeRestrictionPopupInternal.ListContentElementAdapter)+20]");
			bool flag = (byte)(0 - centerOnChild2.selectedObjectReselected) != 0;
			bool flag2 = default;
			if ((flag ? 1 : 0) >= (flag2 ? 1 : 0))
			{
				goto IL_00e4;
			}
		}
		int num3 = 0;
		goto IL_0188;
		IL_00e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		int num4 = default;
		bool flag3 = num4 > 0;
		bool flag4 = !flag3;
		num3 = num4;
		if (!flag4)
		{
			((CrcCalculatorStream)(object)_centerOnChild).Write((byte[])(object)container, dataIndex, num4);
			num3 = num4;
		}
		goto IL_0188;
		IL_0188:
		return (Container)num3;
	}
}
