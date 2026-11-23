using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIButtonMessage : MonoBehaviour
{
	public enum Trigger
	{
		OnClick,
		OnMouseOver,
		OnMouseOut,
		OnPress,
		OnRelease,
		OnDoubleClick
	}

	public GameObject target;

	public string functionName;

	public Trigger trigger;

	public bool includeChildren;

	private bool mStarted;

	private void Start()
	{
		mStarted = true;
	}

	private void OnEnable()
	{
		if (~(mStarted ? 1u : 0u) == 0)
		{
			GameObject go = gameObject;
			bool isOver = UICamera.IsHighlighted(go);
			OnHover(isOver);
		}
	}

	private void OnHover(bool isOver)
	{
		if (!enabled)
		{
			return;
		}
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
		Send();
	}

	private void OnPress(bool isPressed)
	{
		if (!enabled)
		{
			return;
		}
		if (isPressed)
		{
			if (trigger != Trigger.OnPress)
			{
				return;
			}
		}
		else if (trigger != Trigger.OnRelease)
		{
			return;
		}
		Send();
	}

	private void OnSelect(bool isSelected)
	{
		if (!enabled)
		{
			return;
		}
		if (isSelected)
		{
			UICamera.ControlScheme currentScheme = UICamera.currentScheme;
			if (currentScheme != UICamera.ControlScheme.Controller)
			{
				return;
			}
		}
		OnHover(isSelected);
	}

	private void OnClick()
	{
		if (enabled && trigger == Trigger.OnClick)
		{
			Send();
		}
	}

	private void OnDoubleClick()
	{
		if (enabled && trigger == Trigger.OnDoubleClick)
		{
			Send();
		}
	}

	private void Send()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_00ce: Expected Obj, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		string text = functionName;
		object obj;
		if (functionName != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_013e;
			}
		}
		obj = 1;
		goto IL_013e;
		IL_013e:
		if (obj != null)
		{
			return;
		}
		if (target == null)
		{
			GameObject gameObject = base.gameObject;
			target = gameObject;
		}
		if (~(includeChildren ? 1u : 0u) == 0)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S3_v6 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			object obj2 = 0;
			object obj6 = default;
			while (true)
			{
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v22+C]");
				if ((nint)obj3 < 0)
				{
					object obj4 = obj2 << 2;
					object obj5 = obj6 + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v29+10]");
					GameObject gameObject2 = ((Component)0).gameObject;
					GameObject value = base.gameObject;
					gameObject2.SendMessage(functionName, value, SendMessageOptions.DontRequireReceiver);
					object obj7 = obj2 + 1;
					obj2 = obj7;
					continue;
				}
				break;
			}
		}
		else
		{
			GameObject value2 = base.gameObject;
			target.SendMessage(functionName, value2, SendMessageOptions.DontRequireReceiver);
		}
	}
}
