namespace UnityEngine;

public sealed class GL
{

	public static bool invertCulling
	{
		 set { } //Length: 27
	}

	public static void Begin(int mode) { }

	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	public static void Color(Color c) { }

	public static void End() { }

	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	private static void ImmediateColor(float r, float g, float b, float a) { }

	public static void set_invertCulling(bool value) { }

	public static void Vertex3(float x, float y, float z) { }

}

