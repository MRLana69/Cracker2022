namespace UnityEngine;

internal class ScrollViewState
{
	public Rect position; //Field offset: 0x8
	public Rect visibleRect; //Field offset: 0x18
	public Rect viewRect; //Field offset: 0x28
	public Vector2 scrollPosition; //Field offset: 0x38
	public bool apply; //Field offset: 0x40

	public ScrollViewState() { }

}

