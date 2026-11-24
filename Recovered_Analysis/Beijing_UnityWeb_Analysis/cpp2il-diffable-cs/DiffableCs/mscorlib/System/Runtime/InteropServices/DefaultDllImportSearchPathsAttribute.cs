namespace System.Runtime.InteropServices;

public sealed class DefaultDllImportSearchPathsAttribute : Attribute
{
	internal DllImportSearchPath _paths; //Field offset: 0x8

	public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths) { }

}

