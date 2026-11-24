namespace UnityEngine;

public class ScriptableObject : Object
{

	public ScriptableObject() { }

	public static ScriptableObject CreateInstance(Type type) { }

	public static T CreateInstance() { }

	private static void CreateScriptableObject(ScriptableObject self) { }

	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

