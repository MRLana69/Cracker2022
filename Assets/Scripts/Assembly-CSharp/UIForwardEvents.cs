using Cpp2ILInjected;
using UnityEngine;

public class UIForwardEvents : MonoBehaviour
{
	public GameObject target;

	public bool onHover;

	public bool onPress;

	public bool onClick;

	public bool onDoubleClick;

	public bool onSelect;

	public bool onDrag;

	public bool onDrop;

	public bool onSubmit;

	public bool onScroll;

	private void OnHover(bool isOver)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(onHover ? 1u : 0u) == 0 && target != null)
		{
			object obj3 = obj + 15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value = default;
			target.SendMessage("OnHover", value, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnPress(bool pressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(onPress ? 1u : 0u) == 0 && target != null)
		{
			object obj3 = obj + 15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value = default;
			target.SendMessage("OnPress", value, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnClick()
	{
		if (~(onClick ? 1u : 0u) == 0 && target != null)
		{
			target.SendMessage("OnClick", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnDoubleClick()
	{
		if (~(onDoubleClick ? 1u : 0u) == 0 && target != null)
		{
			target.SendMessage("OnDoubleClick", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnSelect(bool selected)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(onSelect ? 1u : 0u) == 0 && target != null)
		{
			object obj3 = obj + 15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value = default;
			target.SendMessage("OnSelect", value, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnDrag(Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(onDrag ? 1u : 0u) == 0 && target != null)
		{
			_ = delta.x;
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value = default;
			target.SendMessage("OnDrag", value, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnDrop(GameObject go)
	{
		if (~(onDrop ? 1u : 0u) == 0 && target != null)
		{
			target.SendMessage("OnDrop", go, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnSubmit()
	{
		if (~(onSubmit ? 1u : 0u) == 0 && target != null)
		{
			target.SendMessage("OnSubmit", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnScroll(float delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(onScroll ? 1u : 0u) == 0 && target != null)
		{
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value = default;
			target.SendMessage("OnScroll", value, SendMessageOptions.DontRequireReceiver);
		}
	}
}
