namespace UnityEngine;

internal sealed class GUIClip
{

	internal static Rect visibleRect
	{
		 get { } //Length: 51
	}

	internal static Rect get_visibleRect() { }

	private static void get_visibleRect_Injected(out Rect ret) { }

	internal static void Internal_Pop() { }

	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	internal static void Pop() { }

	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	internal static void SetMatrix(Matrix4x4 m) { }

	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

}

