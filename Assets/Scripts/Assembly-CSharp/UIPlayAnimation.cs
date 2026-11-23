using System.Collections.Generic;
using AnimationOrTween;
using UnityEngine;

public class UIPlayAnimation : MonoBehaviour
{
	public static UIPlayAnimation current;

	public Animation target;

	public Animator animator;

	public string clipName;

	public Trigger trigger;

	public Direction playDirection = Direction.Forward;

	public bool resetOnPlay;

	public bool clearSelection;

	public EnableCondition ifDisabledOnPlay;

	public DisableCondition disableWhenFinished;

	public List<EventDelegate> onFinished;

	private GameObject eventReceiver;

	private string callWhenFinished;

	private bool mStarted;

	private bool mActivated;

	private bool dragHighlight;

	private bool dualState
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			object obj = trigger - 1;
			return (nint)obj < 2;
		}
	}

	private void Awake()
	{
		UIButton component = GetComponent<UIButton>();
		if (component != null)
		{
			dragHighlight = component.dragHighlight;
		}
		if (eventReceiver != null && EventDelegate.IsValid(onFinished))
		{
			eventReceiver = null;
			callWhenFinished = null;
		}
	}

	private void Start()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		mStarted = true;
		if (target == null && animator == null)
		{
			Animator componentInChildren = GetComponentInChildren<Animator>();
			animator = componentInChildren;
		}
		object obj2;
		if (animator != null)
		{
			object obj = this + 16;
			bool flag = ((Behaviour)obj).enabled;
			obj2 = obj;
			if (!flag)
			{
				return;
			}
		}
		else
		{
			object obj3 = this + 12;
			if ((Object)obj3 == null)
			{
				Animation componentInChildren2 = GetComponentInChildren<Animation>();
				target = componentInChildren2;
			}
			if (!((Object)obj3 != null))
			{
				return;
			}
			bool flag2 = ((Behaviour)obj3).enabled;
			bool flag3 = !flag2;
			obj2 = obj3;
			if (flag3)
			{
				return;
			}
		}
		((Behaviour)obj2).enabled = false;
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
			callback._002Ector(this, (nint)__ldftn(UIPlayAnimation.OnToggle));
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
			callback._002Ector(this, (nint)__ldftn(UIPlayAnimation.OnToggle));
			bool flag = EventDelegate.Remove(component.onChange, callback);
		}
	}

	private void OnHover(bool isOver)
	{
		//IL_0031: Expected Obj, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I4
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
		object obj4 = trigger - 1;
		bool onlyIfDifferent = (nint)obj4 < 2;
		Play(isOver, onlyIfDifferent);
	}

	private void OnPress(bool isPressed)
	{
		//IL_006d: Expected Obj, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		if (!enabled)
		{
			return;
		}
		if (UICamera.currentTouchID <= -2)
		{
			UICamera.ControlScheme currentScheme = UICamera.currentScheme;
			if (currentScheme != UICamera.ControlScheme.Controller)
			{
				return;
			}
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
		object obj4 = trigger - 1;
		bool onlyIfDifferent = (nint)obj4 < 2;
		Play(isPressed, onlyIfDifferent);
	}

	private void OnClick()
	{
		if (UICamera.currentTouchID <= -2)
		{
			UICamera.ControlScheme currentScheme = UICamera.currentScheme;
			if (currentScheme != UICamera.ControlScheme.Controller)
			{
				return;
			}
		}
		if (enabled && trigger == Trigger.OnClick)
		{
			Play(forward: true, onlyIfDifferent: false);
		}
	}

	private void OnDoubleClick()
	{
		if (UICamera.currentTouchID <= -2)
		{
			UICamera.ControlScheme currentScheme = UICamera.currentScheme;
			if (currentScheme != UICamera.ControlScheme.Controller)
			{
				return;
			}
		}
		if (enabled && trigger == Trigger.OnDoubleClick)
		{
			Play(forward: true, onlyIfDifferent: false);
		}
	}

	private void OnSelect(bool isSelected)
	{
		//IL_0031: Expected Obj, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I4
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
		object obj4 = trigger - 1;
		bool onlyIfDifferent = (nint)obj4 < 2;
		Play(isSelected, onlyIfDifferent);
	}

	private void OnToggle()
	{
		//IL_0032: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_01bc: Expected Obj, but got I4
		//IL_01d9: Expected I4, but got Obj
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
		object obj8 = this.trigger - 1;
		bool onlyIfDifferent = (nint)obj8 < 2;
		Play((byte)(int)obj7 != 0, onlyIfDifferent);
	}

	private void OnDragOver()
	{
		//IL_0015: Expected Obj, but got I4
		if (!enabled)
		{
			return;
		}
		object obj = trigger - 1;
		if ((nint)obj < 2)
		{
			UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
			GameObject gameObject = base.gameObject;
			if (currentTouch.dragged == gameObject)
			{
				Play(forward: true, onlyIfDifferent: true);
			}
			else if (~(dragHighlight ? 1u : 0u) == 0 && trigger == Trigger.OnPress)
			{
				Play(forward: true, onlyIfDifferent: true);
			}
		}
	}

	private void OnDragOut()
	{
		//IL_0015: Expected Obj, but got I4
		if (!enabled)
		{
			return;
		}
		object obj = trigger - 1;
		if ((nint)obj < 2)
		{
			GameObject hoveredObject = UICamera.hoveredObject;
			GameObject gameObject = base.gameObject;
			if (hoveredObject != gameObject)
			{
				Play(forward: false, onlyIfDifferent: true);
			}
		}
	}

	private void OnDrop(GameObject go)
	{
		if (enabled && trigger == Trigger.OnPress)
		{
			UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
			GameObject gameObject = base.gameObject;
			if (currentTouch.dragged != gameObject)
			{
				Play(forward: false, onlyIfDifferent: true);
			}
		}
	}

	public void Play(bool forward)
	{
		Play(forward, onlyIfDifferent: true);
	}

	public unsafe void Play(bool forward, bool onlyIfDifferent)
	{
		//IL_01ba: Expected Obj, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		if (!target && !animator)
		{
			return;
		}
		if (onlyIfDifferent)
		{
			if (mActivated == forward)
			{
				return;
			}
			mActivated = forward;
		}
		if (~(clearSelection ? 1u : 0u) == 0)
		{
			GameObject selectedObject = UICamera.selectedObject;
			GameObject gameObject = base.gameObject;
			if (selectedObject == gameObject)
			{
				UICamera.selectedObject = null;
			}
		}
		Direction direction = (Direction)(0 - playDirection);
		bool flag = !forward;
		Direction direction2 = direction;
		if (!flag)
		{
			direction2 = playDirection;
		}
		ActiveAnimation activeAnimation = ((!target) ? ActiveAnimation.Play(animator, clipName, direction2, ifDisabledOnPlay, disableWhenFinished) : ActiveAnimation.Play(target, clipName, direction2, ifDisabledOnPlay, disableWhenFinished));
		if (!(activeAnimation != null))
		{
			return;
		}
		if (~(resetOnPlay ? 1u : 0u) == 0)
		{
			activeAnimation.Reset();
		}
		object obj = 0;
		EventDelegate.Callback callback = default;
		while (true)
		{
			List<EventDelegate> list = onFinished;
			if ((nint)obj < list._size)
			{
				callback._002Ector(this, (nint)__ldftn(UIPlayAnimation.OnFinished));
				EventDelegate eventDelegate = EventDelegate.Add(activeAnimation.onFinished, callback, oneShot: true);
				object obj2 = obj + 1;
				obj = obj2;
				continue;
			}
			break;
		}
	}

	public void PlayForward()
	{
		Play(forward: true);
	}

	public void PlayReverse()
	{
		Play(forward: false);
	}

	private void OnFinished()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		if (!(current == null))
		{
			return;
		}
		current = this;
		EventDelegate.Execute(onFinished);
		object obj = this + 48;
		if (!(eventReceiver != null))
		{
			goto IL_00c2;
		}
		string text = callWhenFinished;
		object obj2;
		if (callWhenFinished != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_00ff;
			}
		}
		obj2 = 1;
		goto IL_00ff;
		IL_00c2:
		obj = 0;
		current = null;
		return;
		IL_00ff:
		if (obj2 == null)
		{
			eventReceiver.SendMessage(callWhenFinished, SendMessageOptions.DontRequireReceiver);
		}
		goto IL_00c2;
	}

	public UIPlayAnimation()
	{
		List<EventDelegate> list = default;
		list._002Ector();
		onFinished = list;
		base._002Ector();
	}
}
