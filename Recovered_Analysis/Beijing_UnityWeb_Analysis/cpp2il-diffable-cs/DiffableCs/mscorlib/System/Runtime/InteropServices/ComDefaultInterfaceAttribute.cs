namespace System.Runtime.InteropServices;

public sealed class ComDefaultInterfaceAttribute : Attribute
{
	internal Type _val; //Field offset: 0x8

	public ComDefaultInterfaceAttribute(Type defaultInterface) { }

}

