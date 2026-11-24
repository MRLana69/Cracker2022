namespace UnityEngine;

public sealed class Shader : Object
{

	private Shader() { }

	public static void DisableKeyword(string keyword) { }

	public static void EnableKeyword(string keyword) { }

	public static Shader Find(string name) { }

	public static int PropertyToID(string name) { }

	public static void SetGlobalColor(string name, Color value) { }

	public static void SetGlobalFloat(string name, float value) { }

	private static void SetGlobalFloatImpl(int name, float value) { }

	public static void SetGlobalInt(string name, int value) { }

	public static void SetGlobalVector(string name, Vector4 value) { }

	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

}

