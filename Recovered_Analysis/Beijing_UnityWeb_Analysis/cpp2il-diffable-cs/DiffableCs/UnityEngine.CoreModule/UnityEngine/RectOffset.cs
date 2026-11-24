namespace UnityEngine;

public class RectOffset
{
	internal nint m_Ptr; //Field offset: 0x8
	private readonly object m_SourceStyle; //Field offset: 0xC

	public int bottom
	{
		 get { } //Length: 49
	}

	public int horizontal
	{
		 get { } //Length: 49
	}

	public int left
	{
		 get { } //Length: 277
	}

	public int right
	{
		 get { } //Length: 49
	}

	public int top
	{
		 get { } //Length: 49
	}

	public int vertical
	{
		 get { } //Length: 49
	}

	public RectOffset() { }

	internal RectOffset(object sourceStyle, nint source) { }

	private void Destroy() { }

	protected override void Finalize() { }

	public int get_bottom() { }

	public int get_horizontal() { }

	public int get_left() { }

	public int get_right() { }

	public int get_top() { }

	public int get_vertical() { }

	private static nint InternalCreate() { }

	private static void InternalDestroy(nint ptr) { }

	public Rect Remove(Rect rect) { }

	private void Remove_Injected(ref Rect rect, out Rect ret) { }

	public override string ToString() { }

}

