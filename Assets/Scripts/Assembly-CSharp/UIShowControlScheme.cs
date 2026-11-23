using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIShowControlScheme : MonoBehaviour
{
	public GameObject target;

	public bool mouse;

	public bool touch;

	public bool controller = true;

	private unsafe void OnEnable()
	{
		UICamera.OnSchemeChange onSchemeChange = default;
		onSchemeChange._002Ector(this, (nint)__ldftn(UIShowControlScheme.OnScheme));
		Delegate obj = Delegate.Combine(UICamera.onSchemeChange, onSchemeChange);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UICamera.OnSchemeChange onSchemeChange2 = default;
		UICamera.onSchemeChange = onSchemeChange2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		OnScheme();
	}

	private unsafe void OnDisable()
	{
		UICamera.OnSchemeChange onSchemeChange = default;
		onSchemeChange._002Ector(this, (nint)__ldftn(UIShowControlScheme.OnScheme));
		Delegate obj = Delegate.Remove(UICamera.onSchemeChange, onSchemeChange);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UICamera.OnSchemeChange onSchemeChange2 = default;
		UICamera.onSchemeChange = onSchemeChange2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	private void OnScheme()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_00d8: Expected I4, but got Obj
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		if (target != null)
		{
			object obj;
			switch (UICamera.currentScheme)
			{
			default:
				return;
			case UICamera.ControlScheme.Mouse:
				obj = this + 16;
				break;
			case UICamera.ControlScheme.Touch:
				obj = this + 17;
				break;
			case UICamera.ControlScheme.Controller:
				obj = this + 18;
				break;
			}
			target.SetActive((byte)(int)obj != 0);
		}
	}
}
