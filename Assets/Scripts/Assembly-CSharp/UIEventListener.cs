using Cpp2ILInjected;
using UnityEngine;

public class UIEventListener : MonoBehaviour
{
	public delegate void VoidDelegate(GameObject go);

	public delegate void BoolDelegate(GameObject go, bool state);

	public delegate void FloatDelegate(GameObject go, float delta);

	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	public object parameter;

	public VoidDelegate onSubmit;

	public VoidDelegate onClick;

	public VoidDelegate onDoubleClick;

	public BoolDelegate onHover;

	public BoolDelegate onPress;

	public BoolDelegate onSelect;

	public FloatDelegate onScroll;

	public VoidDelegate onDragStart;

	public VectorDelegate onDrag;

	public VoidDelegate onDragOver;

	public VoidDelegate onDragOut;

	public VoidDelegate onDragEnd;

	public ObjectDelegate onDrop;

	public KeyCodeDelegate onKey;

	public BoolDelegate onTooltip;

	private bool isColliderEnabled
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

	private void OnSubmit()
	{
		if (isColliderEnabled)
		{
			VoidDelegate voidDelegate = onSubmit;
			if (onSubmit != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnClick()
	{
		if (isColliderEnabled)
		{
			VoidDelegate voidDelegate = onClick;
			if (onClick != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnDoubleClick()
	{
		if (isColliderEnabled)
		{
			VoidDelegate voidDelegate = onDoubleClick;
			if (onDoubleClick != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnHover(bool isOver)
	{
		if (isColliderEnabled)
		{
			BoolDelegate boolDelegate = onHover;
			if (onHover != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnPress(bool isPressed)
	{
		if (isColliderEnabled)
		{
			BoolDelegate boolDelegate = onPress;
			if (onPress != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnSelect(bool selected)
	{
		if (isColliderEnabled)
		{
			BoolDelegate boolDelegate = onSelect;
			if (onSelect != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnScroll(float delta)
	{
		if (isColliderEnabled)
		{
			FloatDelegate floatDelegate = onScroll;
			if (onScroll != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnDragStart()
	{
		VoidDelegate voidDelegate = onDragStart;
		if (onDragStart != null)
		{
			GameObject gameObject = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void OnDrag(Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		VectorDelegate vectorDelegate = onDrag;
		if (onDrag != null)
		{
			GameObject gameObject = base.gameObject;
			_ = delta.x;
			obj = delta.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v8.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void OnDragOver()
	{
		if (isColliderEnabled)
		{
			VoidDelegate voidDelegate = onDragOver;
			if (onDragOver != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnDragOut()
	{
		if (isColliderEnabled)
		{
			VoidDelegate voidDelegate = onDragOut;
			if (onDragOut != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnDragEnd()
	{
		VoidDelegate voidDelegate = onDragEnd;
		if (onDragEnd != null)
		{
			GameObject gameObject = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void OnDrop(GameObject go)
	{
		if (isColliderEnabled)
		{
			ObjectDelegate objectDelegate = onDrop;
			if (onDrop != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnKey(KeyCode key)
	{
		if (isColliderEnabled)
		{
			KeyCodeDelegate keyCodeDelegate = onKey;
			if (onKey != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void OnTooltip(bool show)
	{
		if (isColliderEnabled)
		{
			BoolDelegate boolDelegate = onTooltip;
			if (onTooltip != null)
			{
				GameObject gameObject = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public static UIEventListener Get(GameObject go)
	{
		UIEventListener uIEventListener = go.GetComponent<UIEventListener>();
		if (uIEventListener == null)
		{
			uIEventListener = go.AddComponent<UIEventListener>();
		}
		return uIEventListener;
	}
}
