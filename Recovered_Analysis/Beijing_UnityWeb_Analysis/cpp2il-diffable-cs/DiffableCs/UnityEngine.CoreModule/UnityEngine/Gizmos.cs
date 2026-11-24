namespace UnityEngine;

public sealed class Gizmos
{

	public static Color color
	{
		 set { } //Length: 51
	}

	public static void DrawLine(Vector3 from, Vector3 to) { }

	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	public static void DrawRay(Vector3 from, Vector3 direction) { }

	public static void DrawSphere(Vector3 center, float radius) { }

	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	public static void DrawWireSphere(Vector3 center, float radius) { }

	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	public static void set_color(Color value) { }

	private static void set_color_Injected(ref Color value) { }

}

