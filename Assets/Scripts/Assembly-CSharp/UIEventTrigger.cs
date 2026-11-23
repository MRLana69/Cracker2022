using System.Collections.Generic;
using UnityEngine;

public class UIEventTrigger : MonoBehaviour
{
	public static UIEventTrigger current;

	public List<EventDelegate> onHoverOver;

	public List<EventDelegate> onHoverOut;

	public List<EventDelegate> onPress;

	public List<EventDelegate> onRelease;

	public List<EventDelegate> onSelect;

	public List<EventDelegate> onDeselect;

	public List<EventDelegate> onClick;

	public List<EventDelegate> onDoubleClick;

	public List<EventDelegate> onDragStart;

	public List<EventDelegate> onDragEnd;

	public List<EventDelegate> onDragOver;

	public List<EventDelegate> onDragOut;

	public List<EventDelegate> onDrag;

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

	private void OnHover(bool isOver)
	{
		//IL_0037: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		if (current == null && isColliderEnabled)
		{
			current = this;
			object obj = 12;
			if (!isOver)
			{
				obj = 16;
			}
			object list = (object)this + obj;
			EventDelegate.Execute((List<EventDelegate>)list);
			current = null;
		}
	}

	private void OnPress(bool pressed)
	{
		//IL_0037: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		if (current == null && isColliderEnabled)
		{
			current = this;
			object obj = 20;
			if (!pressed)
			{
				obj = 24;
			}
			object list = (object)this + obj;
			EventDelegate.Execute((List<EventDelegate>)list);
			current = null;
		}
	}

	private void OnSelect(bool selected)
	{
		//IL_0037: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		if (current == null && isColliderEnabled)
		{
			current = this;
			object obj = 28;
			if (!selected)
			{
				obj = 32;
			}
			object list = (object)this + obj;
			EventDelegate.Execute((List<EventDelegate>)list);
			current = null;
		}
	}

	private void OnClick()
	{
		if (current == null && isColliderEnabled)
		{
			current = this;
			EventDelegate.Execute(onClick);
			current = null;
		}
	}

	private void OnDoubleClick()
	{
		if (current == null && isColliderEnabled)
		{
			current = this;
			EventDelegate.Execute(onDoubleClick);
			current = null;
		}
	}

	private void OnDragStart()
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.Execute(onDragStart);
			current = null;
		}
	}

	private void OnDragEnd()
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.Execute(onDragEnd);
			current = null;
		}
	}

	private void OnDragOver(GameObject go)
	{
		if (current == null && isColliderEnabled)
		{
			current = this;
			EventDelegate.Execute(onDragOver);
			current = null;
		}
	}

	private void OnDragOut(GameObject go)
	{
		if (current == null && isColliderEnabled)
		{
			current = this;
			EventDelegate.Execute(onDragOut);
			current = null;
		}
	}

	private void OnDrag(Vector2 delta)
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.Execute(onDrag);
			current = null;
		}
	}

	public UIEventTrigger()
	{
		List<EventDelegate> list = default;
		list._002Ector();
		onHoverOver = list;
		List<EventDelegate> list2 = default;
		list2._002Ector();
		onHoverOut = list2;
		List<EventDelegate> list3 = default;
		list3._002Ector();
		onPress = list3;
		List<EventDelegate> list4 = default;
		list4._002Ector();
		onRelease = list4;
		List<EventDelegate> list5 = default;
		list5._002Ector();
		onSelect = list5;
		List<EventDelegate> list6 = default;
		list6._002Ector();
		onDeselect = list6;
		List<EventDelegate> list7 = default;
		list7._002Ector();
		onClick = list7;
		List<EventDelegate> list8 = default;
		list8._002Ector();
		onDoubleClick = list8;
		List<EventDelegate> list9 = default;
		list9._002Ector();
		onDragStart = list9;
		List<EventDelegate> list10 = default;
		list10._002Ector();
		onDragEnd = list10;
		List<EventDelegate> list11 = default;
		list11._002Ector();
		onDragOver = list11;
		List<EventDelegate> list12 = default;
		list12._002Ector();
		onDragOut = list12;
		List<EventDelegate> list13 = default;
		list13._002Ector();
		onDrag = list13;
		base._002Ector();
	}
}
