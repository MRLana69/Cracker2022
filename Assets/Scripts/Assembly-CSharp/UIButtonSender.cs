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

	protected virtual void OnHover(bool isOver)
	{
		//IL_0064: Expected I, but got Obj
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		if (isOver)
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
		nint num = (nint)this;
		object obj = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v4 (Il2CppClass<UIButtonSender>)+F4] (should have been resolved before IL gen)");
	}

	protected virtual void OnPress(bool isPressed)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		if (trigger == Trigger.OnPress)
		{
			object obj = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v4+BC] (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnClick()
	{
		//IL_002f: Expected I, but got Obj
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		if (trigger == Trigger.OnClick)
		{
			nint num = (nint)this;
			object obj = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<UIButtonSender>)+F4] (should have been resolved before IL gen)");
		}
	}

	protected virtual void Send()
	{
	}

	protected virtual void Send(bool isPressed)
	{
	}
}
