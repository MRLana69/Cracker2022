namespace UnityEngine;

public static class JsonUtility
{

	public static T FromJson(string json) { }

	public static object FromJson(string json, Type type) { }

	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	public static void FromJsonOverwrite(string json, object objectToOverwrite) { }

	public static string ToJson(object obj) { }

	public static string ToJson(object obj, bool prettyPrint) { }

	private static string ToJsonInternal(object obj, bool prettyPrint) { }

}

