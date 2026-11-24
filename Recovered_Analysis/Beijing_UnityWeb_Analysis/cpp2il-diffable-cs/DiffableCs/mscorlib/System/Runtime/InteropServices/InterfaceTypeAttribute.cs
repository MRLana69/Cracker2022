namespace System.Runtime.InteropServices;

public sealed class InterfaceTypeAttribute : Attribute
{
	internal ComInterfaceType _val; //Field offset: 0x8

	public InterfaceTypeAttribute(ComInterfaceType interfaceType) { }

}

