using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Screens.NotEnoughCurrencyPopupInternal;

public class UiElementsManager
{
	private Dictionary<UiElementType, GameObject> _uiElements;

	public UiElementsManager()
	{
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.NotEnoughCurrencyPopupInternal.UiElementsManager)+18]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.NotEnoughCurrencyPopupInternal.UiElementsManager)+18]");
			if (((GameObject)0).activeInHierarchy)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.NotEnoughCurrencyPopupInternal.UiElementsManager)+18]");
				((GameObject)0).tag = null;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.NotEnoughCurrencyPopupInternal.UiElementsManager)+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CE4");
		}
	}

	public unsafe void ActivateUiElement(UiElementType uiElementType, GameObject prefab, Transform parent, OnActivatedPrefab onActivatedPrefab = null)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected VT, but got Unknown
		//IL_009c: Expected F4, but got Obj
		//IL_0097: Expected native int or pointer, but got VT
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c9: Expected F4, but got Obj
		//IL_00c4: Expected native int or pointer, but got VT
		//IL_00de: Expected F4, but got I
		//IL_00d9: Expected native int or pointer, but got VT
		//IL_00f3: Expected I4, but got VT
		//IL_00f3: Expected Obj, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0116: Expected F4, but got Obj
		//IL_0111: Expected native int or pointer, but got VT
		//IL_005c: Expected Obj, but got I
		//IL_0135: Expected F4, but got Obj
		//IL_0130: Expected native int or pointer, but got VT
		//IL_014a: Expected F4, but got I
		//IL_0145: Expected native int or pointer, but got VT
		//IL_015f: Expected I4, but got VT
		//IL_015f: Expected Obj, but got I
		bool flag;
		if (uiElementType != UiElementType.FirstPurchaseBonusBanner)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [uiElementType @ L1 (UI.Screens.NotEnoughCurrencyPopupInternal.UiElementType)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.NotEnoughCurrencyPopupInternal.UiElementsManager)+10]");
			((UISprite)0).fillCenter = (byte)uiElementType != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		object obj2 = default;
		object obj = obj2 + 36;
		obj = parent;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 40);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		object obj3 = obj2 + 16;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v10+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.NotEnoughCurrencyPopupInternal.UiElementsManager)+10]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj4 = obj2 + 32;
		obj4 = prefab;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.NotEnoughCurrencyPopupInternal.UiElementsManager)+C]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
	}

	public void DeactivateAllUiElements()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 8;
		object obj7 = default;
		obj6 = obj7;
	}

	public void DeactivateUiElement(UiElementType uiElementType)
	{
		throw new InvalidOperationException();
	}
}
