using UnityEngine;

public class UIDragCamera : MonoBehaviour
{
	public UIDraggableCamera draggableCamera;

	private void Awake()
	{
		if (draggableCamera == null)
		{
			GameObject go = gameObject;
			UIDraggableCamera uIDraggableCamera = NGUITools.FindInParents<UIDraggableCamera>(go);
			draggableCamera = uIDraggableCamera;
		}
	}

	private void OnPress(bool isPressed)
	{
		if (enabled)
		{
			GameObject go = gameObject;
			if (NGUITools.GetActive(go) && draggableCamera != null)
			{
				draggableCamera.Press(isPressed);
			}
		}
	}

	private unsafe void OnDrag(Vector2 delta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0083: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		if (enabled)
		{
			GameObject go = gameObject;
			if (NGUITools.GetActive(go) && draggableCamera != null)
			{
				((Vector2*)(nint)vector)->x = delta.x;
				_ = delta.x;
				draggableCamera.Drag(vector);
			}
		}
	}

	private void OnScroll(float delta)
	{
		if (enabled)
		{
			GameObject go = gameObject;
			if (NGUITools.GetActive(go) && draggableCamera != null)
			{
				draggableCamera.Scroll(delta);
			}
		}
	}
}
