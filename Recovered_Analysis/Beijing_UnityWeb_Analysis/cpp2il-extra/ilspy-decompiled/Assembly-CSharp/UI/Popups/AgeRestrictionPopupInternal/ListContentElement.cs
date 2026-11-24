using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using UnityEngine;

namespace UI.Popups.AgeRestrictionPopupInternal;

public class ListContentElement
{
	private string content__BackingField;

	private int value__BackingField;

	private ListElementHelper helper__BackingField;

	public unsafe string content
	{
		get
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			text.m_stringLength = 0;
			object obj = text + 16;
			obj = this;
			return text;
		}
		private set
		{
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0294: Expected Obj, but got Unknown
			//IL_029d: Expected Obj, but got I4
			//IL_02b1: Expected I, but got Obj
			//IL_02c7: Expected Obj, but got I
			//IL_0443: Expected I4, but got Obj
			//IL_0455: Expected I, but got Obj
			//IL_046b: Expected Obj, but got I
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f2: Expected Obj, but got Unknown
			//IL_02fb: Expected Obj, but got VT
			//IL_0304: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Expected Obj, but got Unknown
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_031f: Expected VT, but got Unknown
			//IL_032c: Expected F4, but got Obj
			//IL_0327: Expected native int or pointer, but got VT
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Expected Obj, but got Unknown
			//IL_0354: Expected F4, but got Obj
			//IL_034f: Expected native int or pointer, but got VT
			//IL_0369: Expected F4, but got I
			//IL_0364: Expected native int or pointer, but got VT
			//IL_0378: Expected I4, but got VT
			//IL_0381: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Expected Obj, but got Unknown
			//IL_038f: Expected Obj, but got VT
			//IL_0398: Unknown result type (might be due to invalid IL or missing references)
			//IL_039d: Expected Obj, but got Unknown
			//IL_03b2: Expected F4, but got Obj
			//IL_03ad: Expected native int or pointer, but got VT
			//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c0: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_00ac: Expected F4, but got Obj
			//IL_00a7: Expected native int or pointer, but got VT
			//IL_00c1: Expected F4, but got I
			//IL_00bc: Expected native int or pointer, but got VT
			//IL_00d0: Expected I4, but got VT
			//IL_00d0: Expected Obj, but got I4
			//IL_00db: Expected Obj, but got I4
			//IL_0060: Expected I, but got Obj
			//IL_00f1: Expected VT, but got Obj
			//IL_011d: Expected Obj, but got I4
			//IL_012e: Expected F4, but got Obj
			//IL_0129: Expected native int or pointer, but got VT
			//IL_0143: Expected F4, but got I
			//IL_013e: Expected native int or pointer, but got VT
			//IL_0150: Expected Obj, but got VT
			//IL_0163: Expected I, but got Obj
			//IL_0179: Expected Obj, but got I
			//IL_01a4: Expected I, but got Obj
			//IL_01f1: Expected I, but got Obj
			//IL_0207: Expected Obj, but got I
			//IL_0280: Expected I4, but got Obj
			//IL_0232: Expected I, but got Obj
			Transform transform = default;
			object obj = transform + 60;
			obj = 0;
			_ = 0;
			nint num = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Info.Boards>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v38 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)value);
			nint num3 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v9 (Il2CppClass<GlobalColors>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v71 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = transform + 56;
			obj4 = GlobalColors.HOVERBOARD_CUSTOMIZATION_BASE_SKIN_FILL;
			object obj5 = transform + 72;
			obj5 = obj4;
			Matrix4x4 matrix4x = (Matrix4x4)(transform + 80);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
			object obj6 = transform + 40;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v20+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)(object)content__BackingField).rawPivot = (UIWidget.Pivot)matrix4x;
			object obj7 = transform + 32;
			obj7 = GlobalColors.HOVERBOARD_CUSTOMIZATION_BASE_SKIN_ICON;
			object obj8 = transform + 36;
			obj8 = obj7;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
			object obj9 = transform + 16;
			Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v30+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)this.value__BackingField).rawPivot = (UIWidget.Pivot)matrix4x;
			GameObject gameObject = ((Component)this.value__BackingField).gameObject;
			transform.localScale = (Vector3)gameObject;
			obj = transform;
			_ = ((Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			GameObject gameObject2 = ((Component)this.value__BackingField).gameObject;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((Transform)(object)gameObject2).parent = (Transform)matrix4x;
			nint num5 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num6 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)helper__BackingField).FindKernel((string)null) == 0)
			{
				return;
			}
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v55 (Il2CppClass<Strings>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v63 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format = Strings.GetDefault("BOARD_DISPLAY_NAME_WITH_SUFFIX");
			string args = Strings.GetDefault(board.name);
			string text = string.Format(format, (object[])(object)args);
			((UILabel)(object)helper__BackingField).fontSize = (int)text;
		}
	}

	public int value
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)content__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
		}
	}

	public ListElementHelper helper
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (ListElementHelper)value__BackingField;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			this.value__BackingField = (int)value;
		}
	}

	public unsafe ListContentElement(string content, int value)
	{
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0250: Expected Obj, but got I4
		//IL_0264: Expected I, but got Obj
		//IL_027a: Expected Obj, but got I
		//IL_02c7: Expected I4, but got Obj
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0305: Expected Obj, but got VT
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected VT, but got Unknown
		//IL_0336: Expected F4, but got Obj
		//IL_0331: Expected native int or pointer, but got VT
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_0083: Expected I4, but got VT
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got VT
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00c1: Expected F4, but got Obj
		//IL_00bc: Expected native int or pointer, but got VT
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ee: Expected F4, but got Obj
		//IL_00e9: Expected native int or pointer, but got VT
		//IL_0103: Expected F4, but got I
		//IL_00fe: Expected native int or pointer, but got VT
		//IL_0112: Expected I4, but got VT
		//IL_0112: Expected Obj, but got I4
		//IL_0126: Expected I4, but got Obj
		//IL_0126: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_0147: Expected VT, but got Obj
		//IL_0173: Expected Obj, but got I4
		//IL_0189: Expected F4, but got Obj
		//IL_0184: Expected native int or pointer, but got VT
		//IL_019e: Expected F4, but got I
		//IL_0199: Expected native int or pointer, but got VT
		//IL_01ab: Expected Obj, but got VT
		//IL_01b9: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I
		//IL_02b8: Expected I4, but got Obj
		//IL_01fa: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 60;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v37 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item((Boards.BoardId)content);
		int index = value - 1;
		HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index);
		object obj3 = transform + 56;
		obj3 = hoverboardTheme.buttonBgColor;
		object obj4 = transform + 72;
		obj4 = obj3;
		Matrix4x4 matrix4x = (Matrix4x4)(transform + 80);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		object obj5 = transform + 40;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v17+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)(object)this.content__BackingField).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj6 = transform + 32;
		obj6 = hoverboardTheme.buttonIconColor;
		object obj7 = transform + 36;
		obj7 = obj6;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		object obj8 = transform + 16;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v27+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)this.value__BackingField).rawPivot = (UIWidget.Pivot)matrix4x;
		((UISprite)this.value__BackingField).fillCenter = (byte)(int)hoverboardTheme.iconName != 0;
		GameObject gameObject = ((Component)this.value__BackingField).gameObject;
		transform.localScale = (Vector3)gameObject;
		obj = transform;
		_ = ((Object)transform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		GameObject gameObject2 = ((Component)this.value__BackingField).gameObject;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((Transform)(object)gameObject2).parent = (Transform)matrix4x;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S2_v46 (Il2CppClass<Strings>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S2_v52 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(hoverboardTheme.title);
		((UILabel)(object)helper__BackingField).fontSize = (int)text;
	}
}
