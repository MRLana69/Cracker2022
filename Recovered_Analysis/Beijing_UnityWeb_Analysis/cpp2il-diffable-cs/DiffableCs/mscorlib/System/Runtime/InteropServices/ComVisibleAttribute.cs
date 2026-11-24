namespace System.Runtime.InteropServices;

public sealed class ComVisibleAttribute : Attribute
{
	internal bool _val; //Field offset: 0x8

	public ComVisibleAttribute(bool visibility) { }

}

