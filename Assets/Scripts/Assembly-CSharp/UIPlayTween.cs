using System;
using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected;
using UnityEngine;

public class UIPlayTween : MonoBehaviour
{
	public static UIPlayTween current;

	public GameObject tweenTarget;

	public int tweenGroup;

	public Trigger trigger;

	public Direction playDirection = Direction.Forward;

	public bool resetOnPlay;

	public bool resetIfDisabled;

	public EnableCondition ifDisabledOnPlay;

	public DisableCondition disableWhenFinished;

	public bool includeChildren;

	public List<EventDelegate> onFinished;

	private GameObject eventReceiver;

	private string callWhenFinished;

	private UITweener[] mTweens;

	private bool mStarted;

	private int mActive;

	private bool mActivated;

	private void Awake()
	{
		if (eventReceiver != null && EventDelegate.IsValid(onFinished))
		{
			eventReceiver = null;
			callWhenFinished = null;
		}
	}

	private void Start()
	{
		mStarted = true;
		if (tweenTarget == null)
		{
			GameObject gameObject = base.gameObject;
			tweenTarget = gameObject;
		}
	}

	private unsafe void OnEnable()
	{
		//IL_005e: Expected Obj, but got I4
		//IL_0252: Expected Obj, but got I4
		if (~(mStarted ? 1u : 0u) == 0)
		{
			GameObject go = base.gameObject;
			bool isOver = UICamera.IsHighlighted(go);
			OnHover(isOver);
		}
		if (UICamera.currentTouch == null)
		{
			goto IL_0227;
		}
		object obj = this.trigger - 2;
		if (this.trigger == Trigger.OnPress)
		{
			goto IL_00f7;
		}
		bool flag = (nint)obj == 1;
		Trigger trigger = this.trigger;
		if (!flag)
		{
			bool flag2 = (nint)obj == 2;
			trigger = this.trigger;
			if (!flag2)
			{
				if ((nint)obj == 3)
				{
					goto IL_00f7;
				}
				trigger = this.trigger;
			}
		}
		goto IL_0244;
		IL_0227:
		UIToggle component = GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.Callback callback = default;
			callback._002Ector(this, (nint)__ldftn(UIPlayTween.OnToggle));
			EventDelegate eventDelegate = EventDelegate.Add(component.onChange, callback);
		}
		return;
		IL_00f7:
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		GameObject gameObject = base.gameObject;
		bool flag3 = currentTouch.pressed == gameObject;
		mActivated = flag3;
		trigger = this.trigger;
		goto IL_0244;
		IL_0244:
		object obj2 = trigger - 1;
		if (trigger == Trigger.OnHover || ((nint)obj2 != 1 && (nint)obj2 == 2))
		{
			UICamera.MouseOrTouch currentTouch2 = UICamera.currentTouch;
			GameObject gameObject2 = base.gameObject;
			bool flag4 = currentTouch2.current == gameObject2;
			mActivated = flag4;
		}
		goto IL_0227;
	}

	private unsafe void OnDisable()
	{
		UIToggle component = GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.Callback callback = default;
			callback._002Ector(this, (nint)__ldftn(UIPlayTween.OnToggle));
			bool flag = EventDelegate.Remove(component.onChange, callback);
		}
	}

	private void OnDragOver()
	{
		if (trigger == Trigger.OnHover)
		{
			OnHover(isOver: true);
		}
	}

	private void OnHover(bool isOver)
	{
		//IL_0031: Expected Obj, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I4
		if (!enabled)
		{
			return;
		}
		object obj = (isOver ? 1 : 0) ^ 1;
		bool flag = trigger == Trigger.OnHoverFalse;
		object obj2 = obj & flag;
		if (obj2 == null && trigger != Trigger.OnHover)
		{
			bool flag2 = trigger == Trigger.OnHoverTrue;
			object obj3 = flag2 & isOver;
			if (obj3 == null)
			{
				return;
			}
		}
		bool flag3 = trigger == Trigger.OnHover;
		bool flag4 = isOver & flag3;
		mActivated = flag4;
		Play(isOver);
	}

	private void OnDragOut()
	{
		if (enabled && ~(mActivated ? 1u : 0u) == 0)
		{
			mActivated = false;
			Play(forward: false);
		}
	}

	private void OnPress(bool isPressed)
	{
		//IL_0031: Expected Obj, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I4
		if (!enabled)
		{
			return;
		}
		object obj = (isPressed ? 1 : 0) ^ 1;
		bool flag = trigger == Trigger.OnPressFalse;
		object obj2 = obj & flag;
		if (obj2 == null && trigger != Trigger.OnPress)
		{
			bool flag2 = trigger == Trigger.OnPressTrue;
			object obj3 = flag2 & isPressed;
			if (obj3 == null)
			{
				return;
			}
		}
		bool flag3 = trigger == Trigger.OnPress;
		bool flag4 = isPressed & flag3;
		mActivated = flag4;
		Play(isPressed);
	}

	private void OnClick()
	{
		if (enabled && trigger == Trigger.OnClick)
		{
			Play(forward: true);
		}
	}

	private void OnDoubleClick()
	{
		if (enabled && trigger == Trigger.OnDoubleClick)
		{
			Play(forward: true);
		}
	}

	private void OnSelect(bool isSelected)
	{
		//IL_0031: Expected Obj, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I4
		if (!enabled)
		{
			return;
		}
		object obj = (isSelected ? 1 : 0) ^ 1;
		bool flag = trigger == Trigger.OnSelectFalse;
		object obj2 = obj & flag;
		if (obj2 == null && trigger != Trigger.OnSelect)
		{
			bool flag2 = trigger == Trigger.OnSelectTrue;
			object obj3 = flag2 & isSelected;
			if (obj3 == null)
			{
				return;
			}
		}
		bool flag3 = trigger == Trigger.OnSelect;
		bool flag4 = isSelected & flag3;
		mActivated = flag4;
		Play(isSelected);
	}

	private void OnToggle()
	{
		//IL_0032: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_01b6: Expected I4, but got Obj
		//IL_0120: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		if (!enabled || !(UIToggle.current != null))
		{
			return;
		}
		object obj = this.trigger - 7;
		if (this.trigger != Trigger.OnActivate)
		{
			Trigger trigger;
			if ((nint)obj != 1)
			{
				trigger = this.trigger;
			}
			else
			{
				UIToggle uIToggle = UIToggle.current;
				object obj2 = 57;
				if (!uIToggle.mStarted)
				{
					obj2 = 28;
				}
				object obj3 = obj2 + (object)uIToggle;
				if (obj3 != null)
				{
					goto IL_00f2;
				}
				trigger = this.trigger;
			}
			if (trigger != Trigger.OnActivateFalse)
			{
				return;
			}
			UIToggle uIToggle2 = UIToggle.current;
			object obj4 = 57;
			if (!uIToggle2.mStarted)
			{
				obj4 = 28;
			}
			object obj5 = obj4 + (object)uIToggle2;
			if (obj5 != null)
			{
				return;
			}
		}
		goto IL_00f2;
		IL_00f2:
		UIToggle uIToggle3 = UIToggle.current;
		object obj6 = 57;
		if (!uIToggle3.mStarted)
		{
			obj6 = 28;
		}
		object obj7 = obj6 + (object)uIToggle3;
		Play((byte)(int)obj7 != 0);
	}

	private void Update()
	{
		//IL_0037: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		if (disableWhenFinished == DisableCondition.DoNotDisable)
		{
			return;
		}
		UITweener[] array = mTweens;
		if (mTweens == null)
		{
			return;
		}
		object obj = 1;
		object obj2 = 0;
		while (true)
		{
			if ((nint)obj2 < array.Length)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)mTweens + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+10]");
				Behaviour behaviour = (Behaviour)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v31 (UnityEngine.Behaviour)+28]");
				if ((nint)0 == tweenGroup)
				{
					if (behaviour.enabled)
					{
						break;
					}
					Direction direction = ((UITweener)behaviour).direction;
					bool flag = direction == (Direction)disableWhenFinished;
					object obj5 = obj & flag;
					obj = obj5;
				}
				object obj6 = obj2 + 1;
				obj2 = obj6;
				continue;
			}
			if (obj != null)
			{
				NGUITools.SetActive(tweenTarget, state: false);
			}
			object obj7 = this + 56;
			obj7 = 0;
			break;
		}
	}

	public unsafe void Play(bool forward)
	{
		//IL_0140: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_01a1: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I4
		//IL_01f4: Expected Obj, but got I4
		mActive = 0;
		GameObject gameObject = ((!(tweenTarget == null)) ? tweenTarget : base.gameObject);
		if (!NGUITools.GetActive(gameObject))
		{
			if (ifDisabledOnPlay != EnableCondition.EnableThenPlay)
			{
				return;
			}
			NGUITools.SetActive(gameObject, state: true);
		}
		UITweener[] components = default;
		if (~(includeChildren ? 1u : 0u) == 0)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v109 @ S4_v5 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		}
		else
		{
			components = gameObject.GetComponents<UITweener>();
		}
		mTweens = components;
		UITweener[] array = mTweens;
		if (array.Length == 0)
		{
			if (disableWhenFinished != DisableCondition.DoNotDisable)
			{
				NGUITools.SetActive(tweenTarget, state: false);
			}
			return;
		}
		bool flag = playDirection == Direction.Reverse;
		bool forward2 = flag ^ forward;
		object obj = 0;
		object obj2 = default;
		EventDelegate.Callback callback = default;
		EventDelegate.Callback callback2 = default;
		object obj6 = default;
		while ((nint)obj2 < array.Length)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)mTweens + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v35+10]");
			UITweener uITweener = (UITweener)0;
			if (uITweener.tweenGroup == tweenGroup)
			{
				object obj5 = 1;
				if (obj == null)
				{
					bool active = NGUITools.GetActive(gameObject);
					obj5 = 0;
					if (!active)
					{
						NGUITools.SetActive(gameObject, state: true);
						obj5 = 1;
					}
				}
				int num3 = mActive + 1;
				mActive = num3;
				if (playDirection == Direction.Toggle)
				{
					callback._002Ector(this, (nint)__ldftn(UIPlayTween.OnFinished));
					EventDelegate eventDelegate = EventDelegate.Add(uITweener.onFinished, callback, oneShot: true);
					uITweener.Toggle();
					obj = obj5;
				}
				else
				{
					if (~(resetOnPlay ? 1u : 0u) == 0 || (~(resetIfDisabled ? 1u : 0u) == 0 && !uITweener.enabled))
					{
						uITweener.Play(forward2);
						uITweener.ResetToBeginning();
					}
					callback2._002Ector(this, (nint)__ldftn(UIPlayTween.OnFinished));
					EventDelegate eventDelegate2 = EventDelegate.Add(uITweener.onFinished, callback2, oneShot: true);
					uITweener.Play(forward2);
					obj = obj5;
				}
			}
			obj2 = obj6 + 1;
		}
	}

	private void OnFinished()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		if (--mActive != 0 || !(current == null))
		{
			return;
		}
		current = this;
		EventDelegate.Execute(onFinished);
		object obj = this + 48;
		if (!(eventReceiver != null))
		{
			goto IL_00ef;
		}
		string text = callWhenFinished;
		object obj2;
		if (callWhenFinished != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_012c;
			}
		}
		obj2 = 1;
		goto IL_012c;
		IL_012c:
		if (obj2 == null)
		{
			eventReceiver.SendMessage(callWhenFinished, SendMessageOptions.DontRequireReceiver);
		}
		goto IL_00ef;
		IL_00ef:
		obj = 0;
		current = null;
	}

	public UIPlayTween()
	{
		List<EventDelegate> list = default;
		list._002Ector();
		onFinished = list;
		base._002Ector();
	}
}
