namespace SYBO.Components.Utilities.Scriptables;

public class ScriptablesPopupAttribute : Attribute
{
	public Type Type; //Field offset: 0x8
	public string Namespace; //Field offset: 0xC
	public string PathContains; //Field offset: 0x10
	public bool HasNoneOption; //Field offset: 0x14

	public ScriptablesPopupAttribute(Type type) { }

}

