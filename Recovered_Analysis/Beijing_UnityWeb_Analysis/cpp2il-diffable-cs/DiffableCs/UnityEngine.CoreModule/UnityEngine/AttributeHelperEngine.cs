namespace UnityEngine;

internal class AttributeHelperEngine
{
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; //Field offset: 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; //Field offset: 0x4
	public static RequireComponent[] _requireComponentArray; //Field offset: 0x8

	private static AttributeHelperEngine() { }

	private static int CheckIsEditorScript(Type klass) { }

	private static T GetCustomAttributeOfType(Type klass) { }

	private static int GetDefaultExecutionOrderFor(Type klass) { }

	private static int GetExecuteMode(Type klass) { }

	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	private static Type[] GetRequiredComponents(Type klass) { }

}

