namespace UnityEngine;

public sealed class RectTransform : Transform
{
	public enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	public delegate ReapplyDrivenProperties
	{

		public ReapplyDrivenProperties(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(RectTransform driven, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(RectTransform driven) { }

	}

	private static ReapplyDrivenProperties reapplyDrivenProperties; //Field offset: 0x0

	public static event ReapplyDrivenProperties reapplyDrivenProperties
	{
		 add { } //Length: 2
		 remove { } //Length: 132
	}

	public Vector2 anchoredPosition
	{
		 get { } //Length: 11
		 set { } //Length: 43
	}

	public Vector2 anchorMax
	{
		 get { } //Length: 11
		 set { } //Length: 43
	}

	public Vector2 anchorMin
	{
		 get { } //Length: 60
		 set { } //Length: 43
	}

	public Vector2 offsetMax
	{
		 set { } //Length: 634
	}

	public Vector2 offsetMin
	{
		 set { } //Length: 11
	}

	public Vector2 pivot
	{
		 get { } //Length: 11
		 set { } //Length: 43
	}

	public Rect rect
	{
		 get { } //Length: 98
	}

	public Vector2 sizeDelta
	{
		 get { } //Length: 11
		 set { } //Length: 43
	}

	public static void add_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	public Vector2 get_anchoredPosition() { }

	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	public Vector2 get_anchorMax() { }

	private void get_anchorMax_Injected(out Vector2 ret) { }

	public Vector2 get_anchorMin() { }

	private void get_anchorMin_Injected(out Vector2 ret) { }

	public Vector2 get_pivot() { }

	private void get_pivot_Injected(out Vector2 ret) { }

	public Rect get_rect() { }

	private void get_rect_Injected(out Rect ret) { }

	public Vector2 get_sizeDelta() { }

	private void get_sizeDelta_Injected(out Vector2 ret) { }

	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	private Vector2 GetParentSize() { }

	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	public static void remove_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	public void set_anchoredPosition(Vector2 value) { }

	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	public void set_anchorMax(Vector2 value) { }

	private void set_anchorMax_Injected(ref Vector2 value) { }

	public void set_anchorMin(Vector2 value) { }

	private void set_anchorMin_Injected(ref Vector2 value) { }

	public void set_offsetMax(Vector2 value) { }

	public void set_offsetMin(Vector2 value) { }

	public void set_pivot(Vector2 value) { }

	private void set_pivot_Injected(ref Vector2 value) { }

	public void set_sizeDelta(Vector2 value) { }

	private void set_sizeDelta_Injected(ref Vector2 value) { }

	public void SetSizeWithCurrentAnchors(Axis axis, float size) { }

}

