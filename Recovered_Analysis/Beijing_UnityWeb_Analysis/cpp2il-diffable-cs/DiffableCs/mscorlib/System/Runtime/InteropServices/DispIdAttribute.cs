namespace System.Runtime.InteropServices;

public sealed class DispIdAttribute : Attribute
{
	internal int _val; //Field offset: 0x8

	public DispIdAttribute(int dispId) { }

}

