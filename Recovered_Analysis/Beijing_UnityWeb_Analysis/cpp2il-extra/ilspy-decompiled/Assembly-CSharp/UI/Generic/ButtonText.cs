using Cpp2ILInjected;
using UnityEngine;

namespace UI.Generic;

public class ButtonText : MonoBehaviour
{
	private UILabel _label;

	private Collider _collider;

	private Color _activeColor;

	private Color _activeEffectColor;

	private Color _inactiveColor;

	private Color _inactiveEffectColor;

	private void TakeActiveColorFromWidget()
	{
		CancelInvoke();
	}

	public void Refresh()
	{
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 32;
		object obj4 = obj3 + 16;
		if (((ComputeShader)(object)_label).FindKernel((string)null) != 0)
		{
			object obj5 = _label + 80;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v16+8]");
			_ = 0;
			obj2 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			_ = 0;
			object obj6 = this + 20;
			obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+8]");
			_ = 0;
			object obj7 = _label + 328;
			obj3 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v31+8]");
			_ = 0;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj8 = this + 36;
			obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9+8]");
			_ = 0;
		}
	}

	public unsafe ButtonText()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_01d6: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0145: Expected I4, but got Obj
		//IL_0258: Expected Obj, but got I4
		//IL_0272: Expected I4, but got Obj
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0120: Expected I4, but got Obj
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_018f: Expected I4, but got Obj
		//IL_02c1: Expected Obj, but got I4
		//IL_02db: Expected I4, but got Obj
		//IL_02f1: Expected Obj, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_016a: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		_ = 0;
		obj2 = 0;
		_ = 0;
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 32);
		if (_label != null)
		{
			return;
		}
		nint num3 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_collider != null))
		{
			bool isTrigger = _collider.isTrigger;
			if (isTrigger)
			{
				object obj5 = this + 20;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
				object obj6 = obj5;
			}
			else
			{
				object obj7 = this + 52;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
				object obj6 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ L6_v2+8]");
			_ = 0;
			obj = ((UIWidget.Pivot*)(int)pivot)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v14 (UIWidget+Pivot)+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			_label.rawPivot = pivot;
			if (isTrigger)
			{
				object obj8 = this + 36;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
				object obj9 = obj8;
			}
			else
			{
				object obj10 = this + 68;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj10;
				object obj9 = obj10;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ L0_v2+8]");
			_ = 0;
			obj2 = ((UIWidget.Pivot*)(int)pivot)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v14 (UIWidget+Pivot)+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		}
	}
}
