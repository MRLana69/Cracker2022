using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIButtonOffset : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover;

	public Vector3 pressed;

	public float duration;

	[NonSerialized]
	private Vector3 mPos;

	[NonSerialized]
	private bool mStarted;

	[NonSerialized]
	private bool mPressed;

	private void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c1: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		if (~(mStarted ? 1u : 0u) != 0)
		{
			mStarted = true;
			if (tweenTarget == null)
			{
				Transform transform = base.transform;
				tweenTarget = transform;
			}
			Vector3 localPosition = tweenTarget.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			mPos = (Vector3)obj;
		}
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

	private unsafe void OnDisable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0091: Expected F4, but got I
		//IL_008c: Expected native int or pointer, but got VT
		//IL_00a0: Expected F4, but got VT
		//IL_009b: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		if (~(mStarted ? 1u : 0u) == 0 && tweenTarget != null)
		{
			TweenPosition component = tweenTarget.GetComponent<TweenPosition>();
			if (component != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+34]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)mPos;
				component.value = vector;
				component.enabled = false;
			}
		}
	}

	private unsafe void OnPress(bool isPressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_015a: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I
		//IL_01d4: Expected F4, but got I
		//IL_01cf: Expected native int or pointer, but got VT
		//IL_01f3: Expected F4, but got I
		//IL_01ee: Expected native int or pointer, but got VT
		//IL_00a1: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		mPressed = isPressed;
		if (!enabled)
		{
			return;
		}
		if (~(mStarted ? 1u : 0u) != 0)
		{
			Start();
		}
		GameObject go = tweenTarget.gameObject;
		if (!isPressed)
		{
			GameObject go2 = gameObject;
			bool flag = UICamera.IsHighlighted(go2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+34]");
			object obj2 = 0;
			bool flag2 = !flag;
			Vector3 vector2 = mPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+30]");
			object obj3 = 0;
			if (!flag2)
			{
				Vector3 vector3 = mPos + hover;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+30]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+14]");
				object obj4 = num + 0;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+18]");
				obj2 = obj5 + 0;
				vector2 = vector3;
				obj3 = obj4;
			}
		}
		else
		{
			Vector3 vector4 = mPos + pressed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+30]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+20]");
			object obj6 = num2 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+34]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+24]");
			object obj2 = num3 + 0;
			Vector3 vector2 = vector4;
			object obj3 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		TweenPosition tweenPosition = TweenPosition.Begin(go, duration, vector);
		tweenPosition.method = UITweener.Method.EaseInOut;
	}

	private unsafe void OnHover(bool isOver)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0102: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		//IL_0132: Expected F4, but got I
		//IL_012d: Expected native int or pointer, but got VT
		//IL_0151: Expected F4, but got I
		//IL_014c: Expected native int or pointer, but got VT
		//IL_00b6: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		if (enabled)
		{
			if (~(mStarted ? 1u : 0u) != 0)
			{
				Start();
			}
			GameObject go = tweenTarget.gameObject;
			if (isOver)
			{
				Vector3 vector2 = mPos + hover;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+30]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+14]");
				object obj2 = num + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+34]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+18]");
				object obj3 = num2 + 0;
				Vector3 vector3 = vector2;
				object obj4 = obj2;
			}
			else
			{
				Vector3 vector3 = mPos;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+30]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+34]");
				object obj3 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			TweenPosition tweenPosition = TweenPosition.Begin(go, duration, vector);
			tweenPosition.method = UITweener.Method.EaseInOut;
		}
	}

	private unsafe void OnDragOver()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0047: Expected Obj, but got VT
		//IL_0064: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_009b: Expected F4, but got I
		//IL_0096: Expected native int or pointer, but got VT
		//IL_00ba: Expected F4, but got I
		//IL_00b5: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		if (~(mPressed ? 1u : 0u) == 0)
		{
			GameObject go = tweenTarget.gameObject;
			object obj2 = mPos + hover;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+30]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+14]");
			object obj3 = num + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+34]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+18]");
			object obj4 = num2 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			TweenPosition tweenPosition = TweenPosition.Begin(go, duration, vector);
			tweenPosition.method = UITweener.Method.EaseInOut;
		}
	}

	private unsafe void OnDragOut()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004b: Expected F4, but got I
		//IL_0046: Expected native int or pointer, but got VT
		//IL_005a: Expected F4, but got VT
		//IL_0055: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		if (~(mPressed ? 1u : 0u) == 0)
		{
			GameObject go = tweenTarget.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonOffset)+34]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)mPos;
			TweenPosition tweenPosition = TweenPosition.Begin(go, duration, vector);
			tweenPosition.method = UITweener.Method.EaseInOut;
		}
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

	public UIButtonOffset()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0054: Expected VT, but got I8
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		hover = Vector3.zeroVector;
		_ = 4489188109421903872L;
		pressed = (Vector3)(-4611686017353646080L);
		base._002Ector();
	}
}
