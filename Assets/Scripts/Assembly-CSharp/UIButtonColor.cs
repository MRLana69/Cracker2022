using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIButtonColor : UIWidgetContainer
{
	public enum State
	{
		Normal,
		Hover,
		Pressed,
		Disabled
	}

	public GameObject tweenTarget;

	public Color hover = (Color)4560115389389988322L;

	public Color pressed = (Color)4549659974404913080L;

	public Color disabledColor = (Color)4539628425446424576L;

	public float duration = 0.2f;

	[NonSerialized]
	protected Color mStartingColor;

	[NonSerialized]
	protected Color mDefaultColor;

	[NonSerialized]
	protected bool mInitDone;

	[NonSerialized]
	protected UIWidget mWidget;

	[NonSerialized]
	protected State mState;

	public State state
	{
		get
		{
			return mState;
		}
		set
		{
			//IL_0005: Expected I, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S3_v2 (Il2CppClass<UIButtonColor>)+124] (should have been resolved before IL gen)");
		}
	}

	public unsafe Color defaultColor
	{
		get
		{
			//IL_0052: Expected F4, but got VT
			//IL_004d: Expected native int or pointer, but got VT
			//IL_0067: Expected F4, but got I
			//IL_0062: Expected native int or pointer, but got VT
			//IL_0029: Expected I, but got Obj
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected Obj, but got Unknown
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				nint num = (nint)this;
				object obj = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v7 (Il2CppClass<UIButtonColor>)+EC] (should have been resolved before IL gen)");
			}
			Color color = default;
			((Color*)(nint)color)->r = (float)mDefaultColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIButtonColor)+5C]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
		set
		{
			//IL_0052: Expected VT, but got F4
			//IL_006c: Expected I, but got Obj
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			//IL_0029: Expected I, but got Obj
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected Obj, but got Unknown
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				nint num = (nint)this;
				object obj = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v9 (Il2CppClass<UIButtonColor>)+EC] (should have been resolved before IL gen)");
			}
			mDefaultColor = (Color)value.r;
			_ = value.b;
			mState = State.Disabled;
			nint num2 = (nint)this;
			object obj2 = this + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S3_v2 (Il2CppClass<UIButtonColor>)+124] (should have been resolved before IL gen)");
		}
	}

	public virtual bool isEnabled
	{
		get
		{
			return enabled;
		}
		set
		{
			enabled = value;
		}
	}

	public unsafe void ResetDefaultColor()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0023: Expected F4, but got I
		//IL_001e: Expected native int or pointer, but got VT
		//IL_0032: Expected F4, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+4C]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)mStartingColor;
		defaultColor = color;
	}

	public void CacheDefaultColor()
	{
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<UIButtonColor>)+EC] (should have been resolved before IL gen)");
		}
	}

	private void Start()
	{
		//IL_0067: Expected I, but got Obj
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0048: Expected I, but got Obj
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v9 (Il2CppClass<UIButtonColor>)+EC] (should have been resolved before IL gen)");
		}
		nint num2 = (nint)this;
		object obj2 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v3 (Il2CppClass<UIButtonColor>)+DC] (should have been resolved before IL gen)");
		object obj3 = default;
		if (obj3 == null)
		{
			nint num3 = (nint)this;
			object obj4 = this + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S3_v3 (Il2CppClass<UIButtonColor>)+124] (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnInit()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_0227: Expected VT, but got Obj
		//IL_0239: Expected VT, but got I
		//IL_0187: Expected VT, but got I
		//IL_01a6: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		mInitDone = true;
		object obj3 = this + 12;
		if (tweenTarget == null)
		{
			GameObject gameObject = base.gameObject;
			tweenTarget = gameObject;
		}
		if ((UnityEngine.Object)obj3 != null)
		{
			UIWidget component = tweenTarget.GetComponent<UIWidget>();
			mWidget = component;
		}
		if (mWidget != null)
		{
			UIWidget uIWidget = mWidget;
			mDefaultColor = uIWidget.mColor;
			mStartingColor = uIWidget.mColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v79 (UIWidget)+54]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v79 (UIWidget)+54]");
			_ = 0;
		}
		else
		{
			if (!((UnityEngine.Object)obj3 != null))
			{
				return;
			}
			Renderer component2 = ((GameObject)obj3).GetComponent<Renderer>();
			if (component2 != null)
			{
				if (Application.isPlaying)
				{
					Material material = component2.material;
					Color color = material.color;
				}
				else
				{
					Material sharedMaterial = component2.sharedMaterial;
					Color color2 = sharedMaterial.color;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				mDefaultColor = (Color)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				mStartingColor = (Color)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
				_ = 0;
			}
			else
			{
				Light component3 = ((GameObject)obj3).GetComponent<Light>();
				if (component3 != null)
				{
					Color color3 = component3.color;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					mDefaultColor = (Color)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					mStartingColor = (Color)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					_ = 0;
				}
				else
				{
					tweenTarget = null;
					mInitDone = false;
				}
			}
		}
	}

	protected virtual void OnEnable()
	{
		//IL_0026: Expected I, but got Obj
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		if (~(mInitDone ? 1u : 0u) == 0)
		{
			GameObject go = base.gameObject;
			bool flag = UICamera.IsHighlighted(go);
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S2_v12 (Il2CppClass<UIButtonColor>)+104] (should have been resolved before IL gen)");
		}
		if (UICamera.currentTouch == null)
		{
			return;
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		GameObject gameObject = base.gameObject;
		bool flag2 = currentTouch.pressed == gameObject;
		bool flag3 = !flag2;
		bool flag4 = !flag3;
		object obj2 = 10;
		if (!flag4)
		{
			UICamera.MouseOrTouch currentTouch2 = UICamera.currentTouch;
			GameObject gameObject2 = base.gameObject;
			bool flag5 = currentTouch2.current == gameObject2;
			bool flag6 = !flag5;
			obj2 = 9;
			if (flag6)
			{
				return;
			}
		}
		object obj3 = obj2 << 3;
		object obj4 = (object)this + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S2_v7+BC] (should have been resolved before IL gen)");
	}

	protected unsafe virtual void OnDisable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0046: Expected I, but got Obj
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_00ab: Expected F4, but got I
		//IL_00a6: Expected native int or pointer, but got VT
		//IL_00ba: Expected F4, but got VT
		//IL_00b5: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 16);
		if (~(mInitDone ? 1u : 0u) == 0 && tweenTarget != null)
		{
			nint num = (nint)this;
			object obj2 = this + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S3_v3 (Il2CppClass<UIButtonColor>)+124] (should have been resolved before IL gen)");
			TweenColor component = tweenTarget.GetComponent<TweenColor>();
			if (component != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+5C]");
				((Color*)(nint)color)->b = 0f;
				((Color*)(nint)color)->r = (float)mDefaultColor;
				component.value = color;
				component.enabled = false;
			}
		}
	}

	protected virtual void OnHover(bool isOver)
	{
		//IL_006c: Expected I, but got Obj
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_002e: Expected I, but got Obj
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_004d: Expected I, but got Obj
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIButtonColor>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 != null)
		{
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				nint num2 = (nint)this;
				object obj3 = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S1_v11 (Il2CppClass<UIButtonColor>)+EC] (should have been resolved before IL gen)");
			}
			if (tweenTarget != null)
			{
				nint num3 = (nint)this;
				object obj4 = this + 104;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ S3_v3 (Il2CppClass<UIButtonColor>)+124] (should have been resolved before IL gen)");
			}
		}
	}

	protected virtual void OnPress(bool isPressed)
	{
		//IL_0194: Expected I, but got Obj
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_004c: Expected I, but got Obj
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_01f5: Expected I, but got Obj
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I4
		//IL_0173: Expected Obj, but got I4
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIButtonColor>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 == null || UICamera.currentTouch == null)
		{
			return;
		}
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			nint num2 = (nint)this;
			object obj3 = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S1_v18 (Il2CppClass<UIButtonColor>)+EC] (should have been resolved before IL gen)");
		}
		if (!(tweenTarget != null))
		{
			return;
		}
		object obj4 = 2;
		if (!isPressed)
		{
			UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
			GameObject gameObject = base.gameObject;
			bool flag = currentTouch.current == gameObject;
			bool flag2 = !flag;
			obj4 = 0;
			if (!flag2)
			{
				UICamera.ControlScheme currentScheme = UICamera.currentScheme;
				bool flag3 = currentScheme == UICamera.ControlScheme.Controller;
				obj4 = 1;
				if (!flag3)
				{
					if (UICamera.currentScheme == UICamera.ControlScheme.Mouse)
					{
						GameObject hoveredObject = UICamera.hoveredObject;
						GameObject gameObject2 = base.gameObject;
						bool flag4 = hoveredObject != gameObject2;
						obj4 = 1;
						if (!flag4)
						{
							goto IL_01f0;
						}
					}
					obj4 = 0;
				}
			}
		}
		goto IL_01f0;
		IL_01f0:
		nint num3 = (nint)this;
		object obj5 = this + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S3_v3 (Il2CppClass<UIButtonColor>)+124] (should have been resolved before IL gen)");
	}

	protected virtual void OnDragOver()
	{
		//IL_006c: Expected I, but got Obj
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_002e: Expected I, but got Obj
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_004d: Expected I, but got Obj
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIButtonColor>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 != null)
		{
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				nint num2 = (nint)this;
				object obj3 = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S1_v11 (Il2CppClass<UIButtonColor>)+EC] (should have been resolved before IL gen)");
			}
			if (tweenTarget != null)
			{
				nint num3 = (nint)this;
				object obj4 = this + 104;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S3_v3 (Il2CppClass<UIButtonColor>)+124] (should have been resolved before IL gen)");
			}
		}
	}

	protected virtual void OnDragOut()
	{
		//IL_006c: Expected I, but got Obj
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_002e: Expected I, but got Obj
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_004d: Expected I, but got Obj
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIButtonColor>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 != null)
		{
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				nint num2 = (nint)this;
				object obj3 = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S1_v11 (Il2CppClass<UIButtonColor>)+EC] (should have been resolved before IL gen)");
			}
			if (tweenTarget != null)
			{
				nint num3 = (nint)this;
				object obj4 = this + 104;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S3_v3 (Il2CppClass<UIButtonColor>)+124] (should have been resolved before IL gen)");
			}
		}
	}

	public virtual void SetState(State state, bool instant)
	{
		//IL_0034: Expected I, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			mInitDone = true;
			nint num = (nint)this;
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ S1_v9 (Il2CppClass<UIButtonColor>)+EC] (should have been resolved before IL gen)");
		}
		if (state != mState)
		{
			mState = state;
			UpdateColor(instant);
		}
	}

	public unsafe void UpdateColor(bool instant)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0023: Expected Obj, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected VT, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected VT, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected VT, but got Unknown
		//IL_01db: Expected F4, but got I
		//IL_01d6: Expected native int or pointer, but got VT
		//IL_01ed: Expected F4, but got VT
		//IL_01e8: Expected native int or pointer, but got VT
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected VT, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 80);
		if (!(tweenTarget != null))
		{
			return;
		}
		object obj2 = mState - 1;
		TweenColor tweenColor;
		if (mState != State.Hover)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+38]");
					_ = 0;
					_ = disabledColor;
					Color color2 = color - -64;
					tweenColor = TweenColor.Begin(tweenTarget, duration, color2);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+5C]");
					_ = 0;
					_ = mDefaultColor;
					Color color3 = color + 16;
					tweenColor = TweenColor.Begin(tweenTarget, duration, color3);
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+28]");
				_ = 0;
				_ = pressed;
				Color color4 = color + 48;
				tweenColor = TweenColor.Begin(tweenTarget, duration, color4);
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+18]");
			_ = 0;
			_ = hover;
			Color color5 = color + 32;
			tweenColor = TweenColor.Begin(tweenTarget, duration, color5);
		}
		if (instant && tweenColor != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v20 (TweenColor)+68]");
			((Color*)(nint)color)->b = 0f;
			((Color*)(nint)color)->r = (float)tweenColor.to;
			tweenColor.value = color;
			tweenColor.enabled = false;
		}
	}

	public UIButtonColor()
	{
		//IL_001a: Expected VT, but got I8
		//IL_0029: Expected VT, but got I8
		//IL_0038: Expected VT, but got I8
		_ = 4575657222465388544L;
		_ = 4575657222464796407L;
		_ = 4575657222466868887L;
		base._002Ector();
	}
}
