using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Popups.BoardBundlePopupInternal;
using UnityEngine;

namespace UI.ModelCamera;

public class ModelScreenSetups
{
	private static Dictionary<UIModelController.ModelScreen, ModelScreenSetup> _setups;

	public static ModelScreenSetup GetScreenSetup(UIModelController.ModelScreen screen)
	{
		//IL_000d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screen @ L0 (UIModelController+ModelScreen)+30]");
		return (ModelScreenSetup)0;
	}

	public ModelScreenSetups()
	{
		_ = -1;
		_ = -1;
	}

	static ModelScreenSetups()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got F4
		//IL_0092: Expected I, but got Obj
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00ce: Expected VT, but got Obj
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00f2: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got F4
		//IL_011b: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0172: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got F4
		//IL_019b: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I
		//IL_01e9: Expected I, but got Obj
		//IL_01ff: Expected Obj, but got I
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0250: Expected I, but got Obj
		//IL_0278: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I4
		//IL_02a5: Expected Obj, but got F4
		//IL_02bf: Expected I, but got Obj
		//IL_02ea: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 56;
		obj = 0;
		_ = 0;
		obj = -1f;
		_ = -5f;
		_ = 50f;
		nint num = (nint)typeof(BoardBundleItem);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+5C]");
		nint num2 = 0;
		object obj3 = obj2 + 72;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		BoardBundleItem.MODEL_POSITION = (Vector3)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj4 = obj2 + 44;
		obj4 = 0;
		_ = 0;
		obj4 = 28f;
		_ = -160f;
		_ = 15f;
		nint num3 = (nint)typeof(BoardBundleItem);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+5C]");
		object obj5 = (nint)0 + (nint)12;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		object obj6 = obj2 + 32;
		obj6 = 0;
		_ = 0;
		obj6 = 1.76f;
		_ = 1f;
		_ = 1f;
		nint num4 = (nint)typeof(BoardBundleItem);
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v34+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v40 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+5C]");
		object obj7 = (nint)0 + (nint)24;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		nint num5 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v45 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v67 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 16);
		transform.Rotate(-49.18f, 2.7f, 16.308f);
		nint num7 = (nint)typeof(BoardBundleItem);
		obj3 = transform;
		_ = ((Object)transform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v52 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+5C]");
		object obj9 = (nint)0 + (nint)36;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 3f;
		_ = -2f;
		_ = 1f;
		nint num8 = (nint)typeof(BoardBundleItem);
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v62 (Il2CppClass<UI.Popups.BoardBundlePopupInternal.BoardBundleItem>)+5C]");
		object obj10 = (nint)0 + (nint)52;
		obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+8]");
		_ = 0;
	}
}
