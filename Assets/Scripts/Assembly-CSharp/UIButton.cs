using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIButton : UIButtonColor
{
	public static UIButton current;

	public bool dragHighlight;

	public string hoverSprite;

	public string pressedSprite;

	public string disabledSprite;

	public Sprite hoverSprite2D;

	public Sprite pressedSprite2D;

	public Sprite disabledSprite2D;

	public bool pixelSnap;

	public List<EventDelegate> onClick;

	[NonSerialized]
	private UISprite mSprite;

	[NonSerialized]
	private UI2DSprite mSprite2D;

	[NonSerialized]
	private string mNormalSprite;

	[NonSerialized]
	private Sprite mNormalSprite2D;

	public override bool isEnabled
	{
		get
		{
			bool flag = enabled;
			bool flag2 = !flag;
			bool result = false;
			if (!flag2)
			{
				GameObject gameObject = base.gameObject;
				Collider component = gameObject.GetComponent<Collider>();
				if ((bool)component)
				{
					bool flag3 = component.enabled;
					result = true;
					if (flag3)
					{
						goto IL_00f4;
					}
				}
				Collider2D component2 = GetComponent<Collider2D>();
				bool flag4 = component2;
				bool flag5 = !flag4;
				result = false;
				if (!flag5)
				{
					bool flag6 = component2.enabled;
					result = flag6;
				}
			}
			goto IL_00f4;
			IL_00f4:
			return result;
		}
		set
		{
			//IL_019c: Expected I, but got Obj
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected Obj, but got Unknown
			//IL_0063: Expected Obj, but got I4
			//IL_01fd: Expected Obj, but got I4
			//IL_0114: Expected Obj, but got I4
			//IL_007a: Expected Obj, but got I4
			//IL_0245: Expected Obj, but got I4
			//IL_012b: Expected Obj, but got I4
			//IL_00aa: Expected Obj, but got I
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected Obj, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected Obj, but got Unknown
			//IL_015b: Expected Obj, but got I
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Expected Obj, but got Unknown
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIButton>)+DC] (should have been resolved before IL gen)");
			object obj2 = default;
			if ((nint)obj2 == (value ? 1 : 0))
			{
				return;
			}
			GameObject gameObject = base.gameObject;
			Collider component = gameObject.GetComponent<Collider>();
			if (component != null)
			{
				component.enabled = value;
				object obj3 = 0;
				if (!value)
				{
					obj3 = 3;
				}
				UIButton[] components = GetComponents<UIButton>();
				object obj4 = 0;
				while ((nint)obj4 < components.Length)
				{
					object obj5 = obj4 << 2;
					object obj6 = (object)components + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v48+10]");
					object obj7 = 0;
					object obj8 = obj7;
					object obj9 = obj7 + 104;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S3_v9+124] (should have been resolved before IL gen)");
					object obj10 = obj4 + 1;
					obj4 = obj10;
				}
				return;
			}
			Collider2D component2 = GetComponent<Collider2D>();
			if (component2 != null)
			{
				component2.enabled = value;
				object obj11 = 0;
				if (!value)
				{
					obj11 = 3;
				}
				UIButton[] components2 = GetComponents<UIButton>();
				object obj12 = 0;
				while ((nint)obj12 < components2.Length)
				{
					object obj13 = obj12 << 2;
					object obj14 = (object)components2 + obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v33+10]");
					object obj15 = 0;
					object obj16 = obj15;
					object obj17 = obj15 + 104;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ S3_v4+124] (should have been resolved before IL gen)");
					object obj18 = obj12 + 1;
					obj12 = obj18;
				}
			}
			else
			{
				enabled = value;
			}
		}
	}

	public string normalSprite
	{
		get
		{
			//IL_0029: Expected I, but got Obj
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected Obj, but got Unknown
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				nint num = (nint)this;
				object obj = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<UIButton>)+EC] (should have been resolved before IL gen)");
			}
			return mNormalSprite;
		}
		set
		{
			//IL_000a: Expected I, but got Obj
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			//IL_0072: Expected Obj, but got I4
			//IL_0056: Expected Obj, but got I4
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				nint num = (nint)this;
				object obj = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v19 (Il2CppClass<UIButton>)+EC] (should have been resolved before IL gen)");
			}
			if (!(mSprite != null))
			{
				goto IL_00cc;
			}
			string text = mNormalSprite;
			object obj2;
			if (mNormalSprite != null)
			{
				obj2 = 0;
				if (text._stringLength != 0)
				{
					goto IL_0134;
				}
			}
			obj2 = 1;
			goto IL_0134;
			IL_00cc:
			mNormalSprite = value;
			if (mState == State.Normal)
			{
				SetSprite(value);
			}
			return;
			IL_0134:
			if (obj2 == null)
			{
				UISprite uISprite = mSprite;
				if (mNormalSprite == uISprite.mSpriteName)
				{
					mNormalSprite = value;
					SetSprite(value);
					return;
				}
			}
			goto IL_00cc;
		}
	}

	public Sprite normalSprite2D
	{
		get
		{
			//IL_0029: Expected I, but got Obj
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected Obj, but got Unknown
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				nint num = (nint)this;
				object obj = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<UIButton>)+EC] (should have been resolved before IL gen)");
			}
			return mNormalSprite2D;
		}
		set
		{
			//IL_000a: Expected I, but got Obj
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				nint num = (nint)this;
				object obj = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v13 (Il2CppClass<UIButton>)+EC] (should have been resolved before IL gen)");
			}
			if (mSprite2D != null)
			{
				UI2DSprite uI2DSprite = mSprite2D;
				if (mNormalSprite2D == uI2DSprite.mSprite)
				{
					mNormalSprite2D = value;
					SetSprite(value);
					return;
				}
			}
			mNormalSprite2D = value;
			if (mState == State.Normal)
			{
				SetSprite(value);
			}
		}
	}

	protected override void OnInit()
	{
		base.OnInit();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UISprite uISprite = default;
		mSprite = uISprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UI2DSprite uI2DSprite = default;
		mSprite2D = uI2DSprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		if (mSprite != null)
		{
			UISprite uISprite2 = mSprite;
			mNormalSprite = uISprite2.mSpriteName;
		}
		if (mSprite2D != null)
		{
			UI2DSprite uI2DSprite2 = mSprite2D;
			mNormalSprite2D = uI2DSprite2.mSprite;
		}
	}

	protected override void OnEnable()
	{
		//IL_008b: Expected I, but got Obj
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_006c: Expected I, but got Obj
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0051: Expected I, but got Obj
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIButton>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 != null)
		{
			if (~(mInitDone ? 1u : 0u) == 0)
			{
				GameObject hoveredObject = UICamera.hoveredObject;
				GameObject gameObject = base.gameObject;
				bool flag = hoveredObject == gameObject;
				nint num2 = (nint)this;
				object obj3 = this + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ S2_v8 (Il2CppClass<UIButton>)+104] (should have been resolved before IL gen)");
			}
		}
		else
		{
			nint num3 = (nint)this;
			object obj4 = this + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v3 (Il2CppClass<UIButton>)+124] (should have been resolved before IL gen)");
		}
	}

	protected override void OnDragOver()
	{
		//IL_0086: Expected I, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIButton>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		if (~(dragHighlight ? 1u : 0u) != 0)
		{
			UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
			GameObject gameObject = base.gameObject;
			if (!(currentTouch.pressed == gameObject))
			{
				return;
			}
		}
		base.OnDragOver();
	}

	protected override void OnDragOut()
	{
		//IL_0086: Expected I, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UIButton>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		if (~(dragHighlight ? 1u : 0u) != 0)
		{
			UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
			GameObject gameObject = base.gameObject;
			if (!(currentTouch.pressed == gameObject))
			{
				return;
			}
		}
		base.OnDragOut();
	}

	protected virtual void OnClick()
	{
		//IL_000a: Expected I, but got Obj
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		if (current == null)
		{
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S1_v5 (Il2CppClass<UIButton>)+DC] (should have been resolved before IL gen)");
			object obj2 = default;
			if (obj2 != null)
			{
				current = this;
				EventDelegate.Execute(onClick);
				current = null;
			}
		}
	}

	public override void SetState(State state, bool immediate)
	{
		//IL_00f2: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		base.SetState(state, immediate);
		if (mSprite != null)
		{
			object obj;
			object obj2;
			object sprite;
			switch (state)
			{
			case State.Normal:
				SetSprite(mNormalSprite);
				break;
			case State.Hover:
			{
				string text = hoverSprite;
				if (hoverSprite != null)
				{
					obj = 0;
					if (text._stringLength != 0)
					{
						goto IL_024f;
					}
				}
				obj = 1;
				goto IL_024f;
			}
			case State.Pressed:
				SetSprite(pressedSprite);
				break;
			case State.Disabled:
				{
					SetSprite(disabledSprite);
					break;
				}
				IL_024f:
				obj2 = 156;
				if (obj == null)
				{
					obj2 = 116;
				}
				sprite = (object)this + obj2;
				SetSprite((string)sprite);
				break;
			}
		}
		else
		{
			if (!(mSprite2D != null))
			{
				return;
			}
			switch (state)
			{
			case State.Normal:
				SetSprite(mNormalSprite2D);
				break;
			case State.Hover:
			{
				bool flag = hoverSprite2D != null;
				object obj3 = 160;
				if (flag)
				{
					obj3 = 128;
				}
				object sprite2 = (object)this + obj3;
				SetSprite((Sprite)sprite2);
				break;
			}
			case State.Pressed:
				SetSprite(pressedSprite2D);
				break;
			case State.Disabled:
				SetSprite(disabledSprite2D);
				break;
			}
		}
	}

	protected void SetSprite(string sp)
	{
		//IL_0047: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		//IL_00bf: Expected I, but got Obj
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		if (!(mSprite != null))
		{
			return;
		}
		object obj;
		if (sp != null)
		{
			obj = 0;
			if (sp._stringLength != 0)
			{
				goto IL_0106;
			}
		}
		obj = 1;
		goto IL_0106;
		IL_0106:
		if (obj != null)
		{
			return;
		}
		UISprite uISprite = mSprite;
		if (uISprite.mSpriteName != sp)
		{
			mSprite.spriteName = sp;
			if (~(pixelSnap ? 1u : 0u) == 0)
			{
				UISprite uISprite2 = mSprite;
				nint num = (nint)uISprite2;
				object obj2 = uISprite2 + 296;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S1_v8 (Il2CppClass<UISprite>)+1E4] (should have been resolved before IL gen)");
			}
		}
	}

	protected void SetSprite(Sprite sp)
	{
		//IL_00ab: Expected I, but got Obj
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		if (!(sp != null) || !(mSprite2D != null))
		{
			return;
		}
		UI2DSprite uI2DSprite = mSprite2D;
		if (uI2DSprite.mSprite != sp)
		{
			mSprite2D.sprite2D = sp;
			if (~(pixelSnap ? 1u : 0u) == 0)
			{
				UI2DSprite uI2DSprite2 = mSprite2D;
				nint num = (nint)uI2DSprite2;
				object obj = uI2DSprite2 + 296;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ S1_v8 (Il2CppClass<UI2DSprite>)+1E4] (should have been resolved before IL gen)");
			}
		}
	}

	public UIButton()
	{
		List<EventDelegate> list = default;
		list._002Ector();
		onClick = list;
		base._002Ector();
	}
}
