namespace UnityEngine;

public sealed class Resources
{

	internal static T[] ConvertObjects(Object[] rawObjects) { }

	public static Object[] FindObjectsOfTypeAll(Type type) { }

	public static T[] FindObjectsOfTypeAll() { }

	public static Object GetBuiltinResource(Type type, string path) { }

	public static T GetBuiltinResource(string path) { }

	public static Object Load(string path) { }

	public static T Load(string path) { }

	public static Object Load(string path, Type systemTypeInstance) { }

	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	public static T[] LoadAll(string path) { }

	public static void UnloadAsset(Object assetToUnload) { }

	public static AsyncOperation UnloadUnusedAssets() { }

}

