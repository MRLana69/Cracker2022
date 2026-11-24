using System;
using Cpp2ILInjected;
using Info;
using NaughtyAttributes;
using UI.Pages;
using UnityEngine;

namespace UI.Popups.BoardBundlePopupInternal;

[Serializable]
internal class BundleIcon
{
	private UISprite _bundleIconBackground;

	private UISprite _bundleIcon;

	private UILabel _bundleIconLabel;

	public void SetupTheme(Boards.BoardId boardId, int theme)
	{
		//IL_001a: Expected VT, but got I4
		//IL_001a: Expected VT, but got I4
		//IL_001a: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.BoardBundlePopupInternal.BundleIcon)+20]");
		((PageTop)this).AdjustIcon((Vector3)0, (Vector3)boardId, (Vector3)theme);
	}

	public void SetupDefaultTheme(Boards.BoardId boardId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00f1: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got I4
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_0166: Expected I, but got Obj
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_0198: Expected Obj, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_01fc: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_00bd: Expected I, but got F4
		//IL_0021: Expected I, but got Obj
		//IL_0051: Expected I, but got Obj
		//IL_0077: Expected I, but got Obj
		MaxValueAttribute maxValueAttribute = default;
		object obj = maxValueAttribute + 96;
		object obj2 = maxValueAttribute + 60;
		obj2 = 0;
		obj = 0;
		obj = boardId;
		object obj3 = maxValueAttribute - -64;
		obj3 = obj;
		GameObject gameObject = ((Component)boardId).gameObject;
		nint num = (nint)typeof(BoardBundleItem);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v12 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag = obj4 == null;
		nint num2 = (nint)typeof(BoardBundleItem);
		if (!flag)
		{
			nint num3 = (nint)typeof(BoardBundleItem);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v47 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(BoardBundleItem);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(BoardBundleItem);
			}
		}
		object obj5 = maxValueAttribute + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ L0_v3 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+5C]");
		object obj6 = (nint)0 + (nint)52;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v5+8]");
		_ = 0;
		Transform transform = (Transform)(maxValueAttribute + 72);
		transform = (Transform)obj5;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v17+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		object obj7 = maxValueAttribute + 24;
		obj7 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11768");
		transform = (Transform)obj7;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v23+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v23+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1175A");
		obj = 0;
		obj = boardId;
		obj2 = obj;
		maxValueAttribute._002Ector(3f);
		transform = (Transform)(object)maxValueAttribute;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)maxValueAttribute.maxValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (NaughtyAttributes.MaxValueAttribute)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1174A");
	}
}
