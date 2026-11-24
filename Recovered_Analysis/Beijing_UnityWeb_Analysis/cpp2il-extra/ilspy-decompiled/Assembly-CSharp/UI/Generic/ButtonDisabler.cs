using Cpp2ILInjected;
using UnityEngine;

namespace UI.Generic;

public class ButtonDisabler : MonoBehaviour
{
	private UIWidget _widget;

	public unsafe void OnPress(bool pressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0073: Expected I4, but got Obj
		//IL_009a: Expected Obj, but got I4
		//IL_00b4: Expected I4, but got Obj
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004e: Expected I4, but got Obj
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 16);
		obj = 0;
		_ = 0;
		if (pressed)
		{
			object obj2 = this + 32;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
			object obj3 = obj2;
		}
		else
		{
			object obj4 = this + 16;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
			object obj3 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ L0_v1+8]");
		_ = 0;
		obj = ((UIWidget.Pivot*)(int)pivot)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (UIWidget+Pivot)+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_widget.rawPivot = pivot;
	}

	public ButtonDisabler()
	{
		CancelInvoke();
	}
}
