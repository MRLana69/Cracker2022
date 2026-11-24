namespace System.Runtime.InteropServices;

public sealed class FieldOffsetAttribute : Attribute
{
	internal int _val; //Field offset: 0x8

	public FieldOffsetAttribute(int offset) { }

}

