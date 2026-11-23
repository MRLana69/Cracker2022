using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class UIToggle : UIWidgetContainer
{
	public delegate bool Validate(bool choice);

	public static BetterList<UIToggle> list;

	public static UIToggle current;

	public int group;

	public Image activeSprite;

	public Animation activeAnimation;

	public Animator animator;

	public bool startsActive;

	public bool instantTween;

	public bool optionCanBeNone;

	public List<EventDelegate> onChange;

	public Validate validator;

	private Image checkSprite;

	private Animation checkAnimation;

	private GameObject eventReceiver;

	private string functionName;

	private bool startsChecked;

	private bool mIsActive;

	private bool mStarted;

	public bool value
	{
		get
		{
			//IL_0009: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0022: Expected Obj, but got I4
			object obj = 57;
			if (!mStarted)
			{
				obj = 28;
			}
			object obj2 = (object)this + obj;
			return (byte)(int)obj2 != 0;
		}
		set
		{
			if (~(mStarted ? 1u : 0u) != 0)
			{
				startsActive = value;
			}
			else if (group == 0 || value || ~(optionCanBeNone ? 1u : 0u) == 0)
			{
				Set(value);
			}
		}
	}

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

	public bool isChecked
	{
		get
		{
			//IL_0009: Expected Obj, but got I4
			//IL_0036: Expected I4, but got Obj
			//IL_0022: Expected Obj, but got I4
			object obj = 57;
			if (!mStarted)
			{
				obj = 28;
			}
			object obj2 = (object)this + obj;
			return (byte)(int)obj2 != 0;
		}
		set
		{
			this.value = value;
		}
	}

	public static UIToggle GetActiveToggle(int group)
	{
		//IL_003e: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I
		object obj = default;
		UIToggle result;
		object obj5 = default;
		while (true)
		{
			BetterList<UIToggle> betterList = list;
			bool flag = (nint)obj >= betterList.size;
			result = null;
			if (flag)
			{
				break;
			}
			BetterList<UIToggle> betterList2 = list;
			object obj2 = obj << 2;
			object obj3 = (object)betterList2.buffer + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21+10]");
			Object obj4 = (Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21+10]");
			if ((Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v22 (UnityEngine.Object)+C]");
				if ((nint)0 == group)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21+10]");
					result = (UIToggle)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v22 (UnityEngine.Object)+39]");
					if ((nint)0 != 0)
					{
						break;
					}
				}
			}
			obj = obj5 + 1;
		}
		return result;
	}

	private void OnEnable()
	{
		list.Add(this);
	}

	private void OnDisable()
	{
		bool flag = list.Remove(this);
	}

	private void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00b1: Expected Obj, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_010b: Expected Obj, but got I4
		//IL_0285: Expected Obj, but got I8
		object obj2 = default;
		object obj = obj2 - 32;
		if (~(startsChecked ? 1u : 0u) == 0)
		{
			startsActive = true;
			startsChecked = false;
		}
		if (!Application.isPlaying)
		{
			if (checkSprite != null && activeSprite == null)
			{
				object obj3 = this + 16;
				object obj4 = this + 40;
				obj3 = obj4;
				obj4 = 0;
			}
			if (checkAnimation != null && activeAnimation == null)
			{
				object obj5 = this + 20;
				object obj6 = this + 44;
				obj5 = obj6;
				obj6 = 0;
			}
			if (Application.isPlaying && activeSprite != null)
			{
				_ = 1065353216;
				float num = 1f;
				if (!startsActive)
				{
					num = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				_ = 4575657222473777152L;
				obj = 4575657222473777152L;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
			if (EventDelegate.IsValid(onChange))
			{
				eventReceiver = null;
				functionName = null;
			}
		}
		else
		{
			mStarted = true;
			instantTween = true;
			bool flag = (byte)((startsActive ? 1u : 0u) ^ 1u) != 0;
			mIsActive = flag;
			Set(startsActive);
			instantTween = instantTween;
		}
	}

	private void OnClick()
	{
		//IL_004f: Expected Obj, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected I4, but got Unknown
		//IL_0068: Expected Obj, but got I4
		if (enabled && isColliderEnabled && UICamera.currentTouchID != -2)
		{
			object obj = 57;
			if (!mStarted)
			{
				obj = 28;
			}
			object obj2 = (object)this + obj;
			bool flag = (byte)(obj2 ^ 1) != 0;
			value = flag;
		}
	}

	public void Set(bool state)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_060b: Expected Obj, but got I4
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_015a: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I
		//IL_03bf: Expected Obj, but got I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_03a3: Expected Obj, but got I4
		//IL_01cd: Expected Obj, but got I
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		Validate validate = validator;
		if (validator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			object obj3 = default;
			if (obj3 == null)
			{
				return;
			}
		}
		if (~(mStarted ? 1u : 0u) != 0)
		{
			startsActive = state;
			mIsActive = state;
			if (activeSprite != null)
			{
				_ = 1065353216;
				float num = 1f;
				if (!state)
				{
					num = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				_ = 4575657222473777152L;
				_ = 4575657222473777152L;
				object obj4 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
			return;
		}
		if (mIsActive == state)
		{
			return;
		}
		if (group != 0 && state)
		{
			while (true)
			{
				IL_05f9:
				BetterList<UIToggle> betterList = list;
				object obj5 = 0;
				while ((nint)obj5 < betterList.size)
				{
					BetterList<UIToggle> betterList2 = list;
					object obj6 = obj5 << 2;
					object obj7 = (object)betterList2.buffer + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v187+10]");
					Object obj8 = (Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v187+10]");
					if ((Object)0 != this)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v188 (UnityEngine.Object)+C]");
						if ((nint)0 == group)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v187+10]");
							((UIToggle)0).Set(state: false);
						}
					}
					BetterList<UIToggle> betterList3 = list;
					if (betterList.size != betterList3.size)
					{
						goto IL_05f9;
					}
					object obj9 = obj5 + 1;
					obj5 = obj9;
				}
				break;
			}
		}
		mIsActive = state;
		if (activeSprite != null)
		{
			if (~(instantTween ? 1u : 0u) == 0 || !NGUITools.GetActive(this))
			{
				_ = 1065353216;
				float num2 = 1f;
				if (!mIsActive)
				{
					num2 = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				_ = 4575657222473777152L;
				_ = 4575657222473777152L;
				object obj10 = obj + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			}
			else
			{
				GameObject go = activeSprite.gameObject;
				float alpha = 1f;
				if (!mIsActive)
				{
					alpha = 0f;
				}
				TweenAlpha tweenAlpha = TweenAlpha.Begin(go, 0.15f, alpha);
			}
		}
		object obj11;
		if (current == null)
		{
			current = this;
			if (EventDelegate.IsValid(onChange))
			{
				EventDelegate.Execute(onChange);
			}
			else if (eventReceiver != null)
			{
				string text = functionName;
				if (functionName != null)
				{
					obj11 = 0;
					if (text._stringLength != 0)
					{
						goto IL_06bb;
					}
				}
				obj11 = 1;
				goto IL_06bb;
			}
			goto IL_0402;
		}
		goto IL_0692;
		IL_0692:
		if (animator != null)
		{
			Direction playDirection = Direction.Forward;
			if (!state)
			{
				playDirection = Direction.Reverse;
			}
			ActiveAnimation activeAnimation = ActiveAnimation.Play(animator, null, playDirection, EnableCondition.IgnoreDisabledState, DisableCondition.DoNotDisable);
			if (activeAnimation != null && (~(instantTween ? 1u : 0u) == 0 || !NGUITools.GetActive(this)))
			{
				activeAnimation.Finish();
			}
		}
		else if (this.activeAnimation != null)
		{
			Direction playDirection2 = Direction.Forward;
			if (!state)
			{
				playDirection2 = Direction.Reverse;
			}
			ActiveAnimation activeAnimation2 = ActiveAnimation.Play(this.activeAnimation, null, playDirection2, EnableCondition.IgnoreDisabledState, DisableCondition.DoNotDisable);
			if (activeAnimation2 != null && (~(instantTween ? 1u : 0u) == 0 || !NGUITools.GetActive(this)))
			{
				activeAnimation2.Finish();
			}
		}
		return;
		IL_0402:
		current = current;
		goto IL_0692;
		IL_06bb:
		if (obj11 == null)
		{
			_ = mIsActive;
			object obj12 = obj + 47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj13 = default;
			eventReceiver.SendMessage(functionName, obj13, SendMessageOptions.DontRequireReceiver);
		}
		goto IL_0402;
	}

	public UIToggle()
	{
		List<EventDelegate> list = default;
		list._002Ector();
		onChange = list;
		functionName = "OnActivate";
		mIsActive = true;
		base._002Ector();
	}

	static UIToggle()
	{
		BetterList<UIToggle> betterList = default;
		list = betterList;
	}
}
