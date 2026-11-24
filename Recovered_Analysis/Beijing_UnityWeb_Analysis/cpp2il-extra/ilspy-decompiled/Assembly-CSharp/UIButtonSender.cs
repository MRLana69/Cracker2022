using Cpp2ILInjected;
using UnityEngine;

public class UIButtonSender : MonoBehaviour
{
	public enum Trigger
	{
		OnClick,
		OnMouseOver,
		OnMouseOut,
		OnPress,
		OnRelease
	}

	public Trigger trigger;

	protected unsafe virtual void OnHover(bool isOver)
	{
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected I4, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_02bd: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00e0: Expected I4, but got Obj
		//IL_00fa: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I4
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		//IL_0359: Expected Obj, but got F4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0232: Expected I4, but got Obj
		//IL_024c: Expected Obj, but got I4
		//IL_0433: Expected I4, but got Obj
		//IL_0455: Expected Obj, but got I
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 80);
		object obj2 = obj + 32;
		object obj3 = obj + 16;
		object obj4 = obj - -64;
		obj4 = 0;
		_ = 0;
		object obj5 = obj + 48;
		obj5 = 0;
		_ = 0;
		if (!isActiveAndEnabled)
		{
			return;
		}
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonSender)+24]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonSender)+24]");
			string text = ((Component)0).tag;
			string text2 = (string)((isOver ? 1 : 0) ^ 1);
			((GameObject)(object)text).tag = text2;
		}
		object obj7 = this + 16;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v22+8]");
		_ = 0;
		obj4 = ((UIWidget.Pivot*)(int)pivot)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UIWidget+Pivot)+8]");
		_ = 0;
		obj2 = ((UIWidget.Pivot*)(int)pivot)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UIWidget+Pivot)+8]");
		_ = 0;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v37 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v50 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num5 = (float)obj2 - 30f / 255f;
		float num6 = ((!(0f > num5)) ? num5 : 0f);
		obj4 = num6;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
		float num7 = 0f - 30f / 255f;
		if (0f > num7)
		{
			float num8 = 0f;
		}
		else
		{
			float num8 = num7;
		}
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		float num9 = 0f - 30f / 255f;
		if (0f > num9)
		{
			float num10 = 0f;
		}
		else
		{
			float num10 = num9;
		}
		if (isOver)
		{
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
		}
		else
		{
			object obj9 = this + 16;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S2_v21+8]");
			_ = 0;
			obj5 = ((UIWidget.Pivot*)(int)pivot)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UIWidget+Pivot)+8]");
			_ = 0;
		}
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonSender)+20]");
		((UIWidget)0).rawPivot = pivot;
	}

	protected virtual void OnPress(bool isPressed)
	{
		if (isPressed)
		{
			if (trigger != Trigger.OnMouseOver)
			{
				return;
			}
		}
		else if (trigger != Trigger.OnMouseOut)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	protected virtual void OnClick()
	{
		CancelInvoke();
	}

	protected virtual void Send()
	{
		if (trigger == Trigger.OnClick)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	protected virtual void Send(bool isPressed)
	{
		if (trigger == Trigger.OnPress)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}
}
