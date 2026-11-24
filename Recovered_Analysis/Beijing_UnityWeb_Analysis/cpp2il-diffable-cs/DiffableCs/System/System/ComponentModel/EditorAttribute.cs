namespace System.ComponentModel;

public sealed class EditorAttribute : Attribute
{
	private string baseTypeName; //Field offset: 0x8
	private string typeName; //Field offset: 0xC

	public EditorAttribute(string typeName, string baseTypeName) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

