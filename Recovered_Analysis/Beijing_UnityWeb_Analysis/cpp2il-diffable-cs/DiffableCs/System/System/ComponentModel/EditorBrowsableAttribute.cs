namespace System.ComponentModel;

public sealed class EditorBrowsableAttribute : Attribute
{
	private EditorBrowsableState browsableState; //Field offset: 0x8

	public EditorBrowsableAttribute(EditorBrowsableState state) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

