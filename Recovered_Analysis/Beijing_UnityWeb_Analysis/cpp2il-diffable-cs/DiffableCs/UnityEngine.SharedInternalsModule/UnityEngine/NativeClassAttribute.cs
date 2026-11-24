namespace UnityEngine;

internal sealed class NativeClassAttribute : Attribute
{
	private string <QualifiedNativeName>k__BackingField; //Field offset: 0x8
	private string <Declaration>k__BackingField; //Field offset: 0xC

	private string Declaration
	{
		 set { } //Length: 11
	}

	private string QualifiedNativeName
	{
		 set { } //Length: 69
	}

	public NativeClassAttribute(string qualifiedCppName) { }

	public NativeClassAttribute(string qualifiedCppName, string declaration) { }

	private void set_Declaration(string value) { }

	private void set_QualifiedNativeName(string value) { }

}

