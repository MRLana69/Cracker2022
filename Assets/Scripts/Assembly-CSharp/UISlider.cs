using System;
using Cpp2ILInjected;
using UnityEngine;

public class UISlider : UIProgressBar
{
	private enum Direction
	{
		Horizontal,
		Vertical,
		Upgraded
	}

	private Transform foreground;

	private float rawValue = 1f;

	private Direction direction;

	protected bool mInverted;

	public bool isColliderEnabled
	{
		get
		{
			Collider component = GetComponent<Collider>();
			if (component != null)
			{
				return component.enabled;
			}
			Collider2D component2 = GetComponent<Collider2D>();
			if (component2 != null)
			{
				return component2.enabled;
			}
			return false;
		}
	}

	public float sliderValue
	{
		get
		{
			return value;
		}
		set
		{
			base.value = value;
		}
	}

	public bool inverted
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = mFill & (FillDirection)(-3);
			return (nint)obj == 1;
		}
		set
		{
		}
	}

	protected override void Upgrade()
	{
		if (direction != Direction.Upgraded)
		{
			mValue = rawValue;
			if (foreground != null)
			{
				UIWidget component = foreground.GetComponent<UIWidget>();
				mFG = component;
			}
			direction = Direction.Upgraded;
			bool flag = true;
			if (!mInverted)
			{
				flag = true;
			}
			if (direction == Direction.Horizontal)
			{
				flag = mInverted;
			}
			mFill = (flag ? FillDirection.RightToLeft : FillDirection.LeftToRight);
		}
	}

	protected unsafe override void OnStart()
	{
		if (!(mBG != null))
		{
			goto IL_0095;
		}
		Collider component = mBG.GetComponent<Collider>();
		if (!(component != null))
		{
			Collider2D component2 = mBG.GetComponent<Collider2D>();
			if (!(component2 != null))
			{
				goto IL_0095;
			}
		}
		Component component3 = mBG;
		goto IL_035b;
		IL_0095:
		component3 = this;
		goto IL_035b;
		IL_035b:
		GameObject go = component3.gameObject;
		UIEventListener uIEventListener = UIEventListener.Get(go);
		UIEventListener.BoolDelegate boolDelegate = default;
		boolDelegate._002Ector(this, (nint)__ldftn(UISlider.OnPressBackground));
		Delegate obj = Delegate.Combine(uIEventListener.onPress, boolDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIEventListener.BoolDelegate onPress = default;
		uIEventListener.onPress = onPress;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIEventListener.VectorDelegate vectorDelegate = default;
		vectorDelegate._002Ector(this, (nint)__ldftn(UISlider.OnDragBackground));
		Delegate obj2 = Delegate.Combine(uIEventListener.onDrag, vectorDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIEventListener.VectorDelegate onDrag = default;
		uIEventListener.onDrag = onDrag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		if (!(thumb != null))
		{
			return;
		}
		Collider component4 = thumb.GetComponent<Collider>();
		if (!(component4 != null))
		{
			Collider2D component5 = thumb.GetComponent<Collider2D>();
			if (!(component5 != null))
			{
				return;
			}
		}
		if (!(mFG == null))
		{
			Transform transform = mFG.cachedTransform;
			if (!(thumb != transform))
			{
				return;
			}
		}
		GameObject go2 = thumb.gameObject;
		UIEventListener uIEventListener2 = UIEventListener.Get(go2);
		UIEventListener.BoolDelegate boolDelegate2 = default;
		boolDelegate2._002Ector(this, (nint)__ldftn(UISlider.OnPressForeground));
		Delegate obj3 = Delegate.Combine(uIEventListener2.onPress, boolDelegate2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIEventListener.BoolDelegate onPress2 = default;
		uIEventListener2.onPress = onPress2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIEventListener.VectorDelegate vectorDelegate2 = default;
		vectorDelegate2._002Ector(this, (nint)__ldftn(UISlider.OnDragForeground));
		Delegate obj4 = Delegate.Combine(uIEventListener2.onDrag, vectorDelegate2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIEventListener.VectorDelegate onDrag2 = default;
		uIEventListener2.onDrag = onDrag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	protected unsafe void OnPressBackground(GameObject go, bool isPressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0041: Expected F4, but got I
		//IL_003c: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		UICamera.ControlScheme currentScheme = UICamera.currentScheme;
		if (currentScheme == UICamera.ControlScheme.Controller)
		{
			return;
		}
		mCam = UICamera.currentCamera;
		Vector2 lastEventPosition = UICamera.lastEventPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+8]");
		((Vector2*)(nint)vector)->x = 0f;
		float num = ScreenToValue(vector);
		value = num;
		if (!isPressed)
		{
			OnDragFinished onDragFinished = base.onDragFinished;
			if (base.onDragFinished != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v65.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	protected unsafe void OnDragBackground(GameObject go, Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0041: Expected F4, but got I
		//IL_003c: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		UICamera.ControlScheme currentScheme = UICamera.currentScheme;
		if (currentScheme != UICamera.ControlScheme.Controller)
		{
			mCam = UICamera.currentCamera;
			Vector2 lastEventPosition = UICamera.lastEventPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+8]");
			((Vector2*)(nint)vector)->x = 0f;
			float num = ScreenToValue(vector);
			value = num;
		}
	}

	protected unsafe void OnPressForeground(GameObject go, bool isPressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00a4: Expected F4, but got I
		//IL_009f: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		UICamera.ControlScheme currentScheme = UICamera.currentScheme;
		if (currentScheme == UICamera.ControlScheme.Controller)
		{
			return;
		}
		mCam = UICamera.currentCamera;
		if (isPressed)
		{
			float num;
			if (mFG == null)
			{
				num = 0f;
			}
			else
			{
				float num2 = value;
				Vector2 lastEventPosition = UICamera.lastEventPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+8]");
				((Vector2*)(nint)vector)->x = 0f;
				float num3 = ScreenToValue(vector);
				num = num2 - num3;
			}
			mOffset = num;
		}
		else
		{
			OnDragFinished onDragFinished = base.onDragFinished;
			if (base.onDragFinished != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v72.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	protected unsafe void OnDragForeground(GameObject go, Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0041: Expected F4, but got I
		//IL_003c: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		UICamera.ControlScheme currentScheme = UICamera.currentScheme;
		if (currentScheme != UICamera.ControlScheme.Controller)
		{
			mCam = UICamera.currentCamera;
			Vector2 lastEventPosition = UICamera.lastEventPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+8]");
			((Vector2*)(nint)vector)->x = 0f;
			float num = ScreenToValue(vector);
			float num2 = mOffset + num;
			value = num2;
		}
	}

	public unsafe override void OnPan(Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0061: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		if (enabled && isColliderEnabled)
		{
			((Vector2*)(nint)vector)->x = delta.x;
			_ = delta.x;
			base.OnPan(vector);
		}
	}
}
